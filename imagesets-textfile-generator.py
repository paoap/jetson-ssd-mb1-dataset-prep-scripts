import glob
import argparse
import os
import random

parser = argparse.ArgumentParser(prefix_chars="--")
parser.add_argument("--source", help="specify the directory of the images.", default='dataset/JPEGImages', type=str)
parser.add_argument("--target", help="specify the save location directory of the text files", default='dataset/Imagesets/Main', type=str)
args = parser.parse_args()

file_list = glob.glob(args.source + "/*.jpg")
random.shuffle(file_list)

n_samples = len(file_list)
print("total_images = {}".format(n_samples))

train_samples = n_samples*0.8
print("train_images = {}".format(train_samples))

val_samples = n_samples*0.2
print("val_images = {}".format(val_samples))

train_list=[]
val_list=[]

i=0
for f in file_list:
    i+=1
    x1=f.find("\\")+1
    x2=f.find(".")
    f=f[x1:x2]
    if i<=train_samples:
        train_list.append(f)
    else:
        val_list.append(f)

train_list = '\n'.join(train_list)
val_list = '\n'.join(val_list)
trainval_list = train_list+ '\n' + val_list

if not (os.path.isdir('dataset/Imagesets/Main')):
    os.mkdir("dataset/Imagesets/Main")

with open(args.target+"/train.txt","w") as output:
    output.write(str(train_list))

with open(args.target+"/val.txt","w") as output:
    output.write(str(val_list))

with open(args.target+"/test.txt","w") as output:
    output.write(str(val_list))

with open(args.target+"/trainval.txt","w") as output:
    output.write(str(trainval_list))
import glob
import argparse
import os
from PIL import Image

parser = argparse.ArgumentParser(prefix_chars="--")
parser.add_argument("--source", help="specify the directory of the images.", default='png', type=str)
parser.add_argument("--target", help="specify the save location directory of the text files", default='jpg', type=str)
args = parser.parse_args()

img_list = glob.glob(args.source + "/*.png")

if not (os.path.isdir(args.target)):
    os.mkdir(args.target)

os.closerange
i=0
for img in img_list:
    #open image in png format
    img_png = Image.open(img)
    
    #The image object is used to save the image in jpg format
    x1=img.find("\\")+1
    x2=img.find(".png")
    save_name= img[x1:x2]
    save_path = "{}/{}.jpg".format(args.target, save_name) 
    img_png.save(save_path)
    print("Successfully converted {} to {}".format(img,save_path))
    i+=1

print("{} files edited. Done.".format(i))
import glob
import argparse
import os

parser = argparse.ArgumentParser(prefix_chars="--")
parser.add_argument("--source", help="specify the directory of the original xml files.", default='DefaultAnnotations', type=str)
parser.add_argument("--target", help="specify the save location directory of the xml files", default='dataset/Annotations', type=str)
args = parser.parse_args()

file_list = glob.glob(args.source + "/*.xml")

if not (os.path.isdir('dataset/Annotations')):
    os.mkdir("dataset/Annotations")

os.closerange
i=0
for file in file_list:
    new_text=[]
    with open(file,'r') as f:
        text = f.readlines()
        for line in text:
            # change folder
            if line.find("<folder>dataset")>0:
                i+=1
                line="\t<folder>dataset</folder>\n"
            elif line.find("<database>Unknown")>0:
                line="\t\t<database>dataset</database>\n\t\t<annotation>custom</annotation>\n\t\t<image>custom</image>\n"
            elif line.find("<path>")>0:
                continue
            elif line.find("<truncated>1")>0:
                line="\t\t<truncated>0</truncated>\n"
            new_text.append(line)
        f.close
    
    x1=file.find("\\")+1
    save_name=file[x1:]
    with open(args.target +'/' + save_name,'w') as f:
        new_text = "".join(new_text)
        f.write(new_text)

print("{} files edited. Done.".format(i))
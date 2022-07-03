from tkinter import filedialog
from tkinter import *
import os
from PIL import Image

image_size = 512
# declare global variables
# global variables, except for StringVar(), should be declared before calling the function for it to be modifiable inside a function
files = [] # create a list of files
source_path = "" 
target_path = ""

def browse_source_button():
    global source_path # to access source_path global variable; otherwise, a local variable called source_path will be created
    global files
    global source_path_label
    source_path = filedialog.askdirectory()
    source_path_label.set(source_path)
    files = os.listdir(source_path)

def browse_target_button():
    global target_path
    global files
    global target_path_label
    target_path = filedialog.askdirectory()
    target_path_label.set(target_path)
    
    myCounter = 0
    for f in files:
        myCounter = myCounter+1
        current_image = source_path + '/' + f
        print(current_image)
        im = Image.open(current_image)
        w, h = im.size
        cropped_top = im.resize((image_size,image_size)) # create a square cropped image
        save_name_top = target_path + '/03_' + str(myCounter) + ".JPG"
        cropped_top.save(save_name_top)
        print('processing file ', myCounter , ' of ', len(files))
    print('Done!')

root = Tk() # creates a window
root.title("Image Cropping and Resizing Tool")
source_path_label = StringVar() # tkinter label can either have a static text of dynamic text in a variable; StringVar() should be declared after the Tk object is created
target_path_label = StringVar()

button1 = Button(text="Set Source Folder", command=browse_source_button)
button1.grid(row=0, column=0)
lbl1 = Label(master=root,textvariable=source_path_label)
lbl1.grid(row=0, column=3)

target_path = StringVar()
button2 = Button(text="Set Target Folder", command=browse_target_button)
button2.grid(row=1, column=0)
lbl2 = Label(master=root,textvariable=target_path_label)
lbl2.grid(row=1, column=3)

mainloop()
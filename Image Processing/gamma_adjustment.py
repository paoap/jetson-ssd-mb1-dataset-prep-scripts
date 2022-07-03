from tkinter import filedialog
from tkinter import *
import os
import cv2
import numpy as np
from random import *

image_size = 1024
# declare global variables
# global variables, except for StringVar(), should be declared before calling the function for it to be modifiable inside a function
files = [] # create a list of files
source_path = "" 
target_path = ""

def adjust_gamma(image, gamma=1.0):
	# build a lookup table mapping the pixel values [0, 255] to
	# their adjusted gamma values
	invGamma = 1.0 / gamma
	table = np.array([((i / 255.0) ** invGamma) * 255
		for i in np.arange(0, 256)]).astype("uint8")
	
    # apply gamma correction using the lookup table
	return cv2.LUT(image, table)

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
        current_image = source_path + '/' + f
        print(current_image)
        myCounter = myCounter+1
        print('processing file ', myCounter , ' of ', len(files))
        
        myDice = random()
        newGamma = 0
        if myDice > 0.5:
            newGamma = 1 + 0.2*random()
        else:
            newGamma = 1 - 0.1*random()
        print(newGamma)

        original = cv2.imread(current_image)
        adjusted = adjust_gamma(original, gamma=newGamma)
        
        """cv2.putText(adjusted, "g={}".format(newGamma), (10, 30), cv2.FONT_HERSHEY_SIMPLEX, 0.8, (0, 0, 255), 3)
        cv2.imshow("Images", np.hstack([original, adjusted]))
        if cv2.waitKey(0): # waits for the user to press any key before the window is closed
            cv2.destroyAllWindows()"""
        
        save_name = target_path + '/' + f
        cv2.imwrite(save_name,adjusted)
        # break
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
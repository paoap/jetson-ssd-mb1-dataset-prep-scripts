# jetson-ssd-mb1-dataset-prep-scripts
This set of python scripts are used to generate the necessary folders and text files for training SSD MobileNetV1 models using Jetson Inference. **The scripts requires that images are saved in jpg format.** I personally prefer saving my annotations in YOLO format since the format does not include file paths and makes file management less complicated.

## Related Repositories
LabelImg: https://github.com/tzutalin/labelImg \
Yolo2Pascal: https://github.com/hai-h-nguyen/Yolo2Pascal-annotation-conversion

## Installation
1. Download miniconda from [here](https://docs.conda.io/en/latest/miniconda.html) and install it to your computer. 
2. After installation, launch anaconda prompt. \
   a. Input the following commands (one line at a time) to create and activate a python environment:
      ```
      conda create -n jetson-ssd-mb1-dataset-prep-scripts
      conda activate jetson-ssd-mb1-dataset-prep-scripts
      ```
   b. While inside the concrete-void-space-analyzer python environment, install python and package installer for python using the following commands:
      ```
      conda install pip
      ```
   c. Once pip is installed, install the necessary python modules using pip:
      ```
      pip install pillow pyqt5 labelimg lxml
      ```
   d. Install git and download the repository
      ```
      conda install git
      git clone https://github.com/hai-h-nguyen/Yolo2Pascal-annotation-conversion
      git clone https://github.com/paoap/jetson-ssd-mb1-dataset-prep-scripts.git
      ```
   e. To exit the environment, type:
      ```
      conda deactivate
      ```      
4. Download and install your favorite programming IDE. I use VSCode. You can get it from [here](https://code.visualstudio.com/). \
   a. Install python extension for code linting. \
   b. Install pylance extension for code suggestion and completion. \
   c. Open jetson-ssd-mb1-dataset-prep-scripts folder in VSCODE

## Annotating using Labelimg
1. Open Anaconda prompt (miniconda) and input the following command:
   ```
   conda activate jetson-ssd-mb1-dataset-prep-scripts
   labelimg
   ```
2. Open the dataset folder
3. Change save directory to the dataset folder
4. Ensure that selected format is YOLO
5. Enable autosaving by going to Tools -> Enable autosaving
6. Annotating: \
   a. Press 'W' to annotate images by left-clicking and enclosing the object with rectangles. \
   b. Input the label for the annotation. \
   **IMPORTANT:** When an existing folder with annotations and appending new labels is opened in LabelImg, the class entries in classes.txt file will be replaced. For example, if the classes.txt file initially contained the labels 'toys' and 'tools' in the first and second lines, respectively, annotating with just 'tools' in this session would modify the classes.txt file and it will only contain the 'tools' class. Going to the next image will cause Labelimg to crash. If this happens, open the classes.txt file and input the classes in the correct arrangement per line. To label images with existing classes.txt file, create temporary annotations for each class in the proper order. E.g., start with 'toys' and then 'tools' then you can delete these temporary boxes and annotate the objects in any order. \
   c. Go to the next image by pressing 'D' or previous image by pressing 'A'. \
   d. Right-click a box to edit annotation class.

## Converting Yolo format to PascalVOC
1. Copy the whole folder (e.g., dataset) containing the images, labels and classes files to the Yolo2Pascal-annotation-conversion. The Yolo2Pascal-annotation-conversion folder should have the following folder structure:
```
Yolo2Pascal-annotation-conversion
   |----- dataset	<--- folder containing the *.jpg and *.txt files
   |----- demo
   |----- pascal2yolo
   |----- yolo2pascal
   |----- .gitignore
   |----- readme.md
```
**NOTE:** Using png files will cause yolo2voc.py to generate 0,0 coordinates as the script utilizes QtImage and could not properly read the 4-channel image files.

3. In Anaconda Prompt: \
   a. Activate environment:
      ```
         conda activate jetson-ssd-mb1-dataset-prep-scripts
      ```
   b. Navigate to the Yolo2Pascal-annotation-conversion installation directory
      * Windows:
         ```
         cd %userprofile%/Yolo2Pascal-annotation-conversion
         ```
      * Ubuntu:
         ```
         cd ~/Pascal-annotation-conversion
         ```
   c. Convert the dataset
      * Windows:
         ```
         python yolo2pascal/yolo2voc.py dataset
         ```
      * Ubuntu:
         ```
         python3 yolo2pascal/yolo2voc.py dataset
         ```
      This process will generate additional xml files into the dataset folder

## Fixing the PascalVOC format to Readable Format of SSD Pytorch in Jetson Inference

   The SSD MobileNetV1 path format in the Jetson Inference repository is as follows:
   ```
   <folder>dataset</folder>
	<filename>image.jpg</filename>
	<source>
		<database>dataset</database>
		<annotation>custom</annotation>
		<image>custom</image>
	</source>
   ```
   While YOLO2Pascal generates the following format:
   ```
   <folder>dataset</folder>
	<filename>image.jpg</filename>
	<path>dataset\image.jpg</path>
	<source>
		<database>Unknown</database>
	</source>
   ```
   We will modify the generated xml files by YOLO2Pascal to the format that can be properly referenced by the SSD MobileNet pytorch training script.

1. Copy all the generated xml of YOLO2Pascal and jpg files from dataset to the specific folders in jetson-ssd-mb1-dataset-prep-scripts. Create the necessary folders as shown below:
```
jetson-ssd-mb1-dataset-prep-scripts
   |----- DefaultAnnotations <--- copy the generated xml annotations of YOLO2Pascal here
   |----- dataset
      	     |----- Annotations   <--- annotation-corrector.py will save corrected annotations here
      	     |----- JPEGImages    <--- copy JPG image files here
      	     |----- ImageSets
         		|----- Main       <--- imagesets-textfile-generator.py will save imageset textfiles here
	     |----- labels.txt    <--- copy classes.txt to this location and rename to labels.txt
   |----- Image Processing
   |----- YOLO Label Modifier
   |----- annotation-corrector.py
   |----- images-text-file-generator.py
   |----- LICENSE
   |----- README.md
```   
3. In Anaconda Prompt: \
   a. Activate environment: \
      ```
         conda activate jetson-ssd-mb1-dataset-prep-scripts
      ```
   b. Navigate to the Yolo2Pascal-annotation-conversion installation directory
      * Windows:
         ```
         cd %userprofile%/jetson-ssd-mb1-dataset-prep-scripts
         ```
      * Ubuntu:
         ```
         cd ~/jetson-ssd-mb1-dataset-prep-scripts
         ```
   c. Convert the dataset
      * Windows:
         ```
         python annotation-corrector.py --source DefaultAnnotations --target dataset/Annotations
         ```
      * Ubuntu:
         ```
         python3 annotation-corrector.py --source DefaultAnnotations --target dataset/Annotations
         ```
      This process will generate the corrected xml files into the dataset folder. 
   
   d. Generate the training and validation reference textfiles:
      * Windows:
         ```
         python imagesets-textfile-generator.py --source dataset/JPEGImages --target dataset/Imagesets/Main
         ```
      * Ubuntu:
         ```
         python3 imagesets-textfile-generator.py --source dataset/JPEGImages --target dataset/Imagesets/Main
         ```
      The dataset folder can now be copied to ssd training folder in Jetson Inference

## Other Tools
* You can convert png to jpg using the included png2jpg.py script
* Existing YOLO annotations can be modified using the VB program that is included in this repository. You will need to install Visual Studio Community Edition and Visual Basic package to run the program.

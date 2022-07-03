# jetson-ssd-mb1-dataset-prep-scripts
These set of python scripts are used to generate the necessary folders and text files for training SSD MobileNetV1 models using Jetson Inference.

## related repository
LabelImg: https://github.com/tzutalin/labelImg
Yolo2Pascal: https://github.com/hai-h-nguyen/Yolo2Pascal-annotation-conversion

## Installation
1. Download miniconda from [here](https://docs.conda.io/en/latest/miniconda.html) and install it to your computer.
2. After installation, launch anaconda prompt.
   1. Input the following commands (one line at a time) to create and activate a python environment:
      ```
      conda create -n jetson-ssd-mb1-dataset-prep-scripts
      conda activate jetson-ssd-mb1-dataset-prep-scripts
      ```
   2. While inside the concrete-void-space-analyzer python environment, install python and package installer for python using the following commands:
      ```
      conda install pip
      ```
   3. Once pip is installed, install the necessary python modules using pip:
      ```
      pip install pyqt5 
      ```
   4. Install git and download the repository
      ```
      conda install git
      git clone https://github.com/hai-h-nguyen/Yolo2Pascal-annotation-conversion
      cd Yolo2Pascal-annotation-conversion/yolo2pascal
      git clone https://github.com/paoap/jetson-ssd-mb1-dataset-prep-scripts.git
      ```
   5. To exit the environment, type:
      ```
      conda deactivate
      ```      
4. Download and install your favorite programming IDE. I use VSCode. You can get it from [here](https://code.visualstudio.com/).
   1. Install python extension for code linting.
   2. Install pylance extension for code suggestion and completion.
   3. Clone this repository and open the folder in VSCode.

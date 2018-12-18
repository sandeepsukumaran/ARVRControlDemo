# ARVRControlDemo
This repository contains instructions and sample scripts to set up an AR-VR scene with virtual button control, using Vuforia and Unity.
Demo video is available on [YouTube](https://youtu.be/AWn4yc9eQdk).
Image target base obtained from [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Solar_system.jpg).
Image target marker obtained from this [blog](https://blog.theknightsofunity.com/wp-content/uploads/2016/11/marker_1.png).
Steps inferred from [Vuforia Unity samples](https://developer.vuforia.com/downloads/samples).

## Software versions:
* Unity Game Engine - Unity 2018.2.4f1 Personal (64bit)Unity 2018.2.4f1 Personal (64bit)
* Vuforia (included in Unity) - version 7.2.23

## Instructions:

### On Vuforia Developer Portal:
1. Login and setup a new License Key.
2. Set up a new database and upload your image target (Image_target.png).
3. Download the image target as a Unity package.

### In Unity:
1. Open a new project.
2. In File > Build Settings, select Android and hit Switch Platform.
3. In the Hierarchy, delete the Main Camera.
4. Change the following Player Settings, in Edit > Project Settings > Player:
  * Under XR Settings, check Virtual Reality Supported, and add the Vuforia and Cardboard SDKs.
  * Under Other Settings, Identification:
    * Set package name (eg: com.yourname.ARVRControlDemo)
    * Set suitable Minimum API Level (tested with 23).
5. Add an ARCamera to the Hierarchy using GameObject > Vuforia > ARCamera. This will prompt the import of all necessary Vuforia components.
6. In Window > Vuforia Configuration
  * Paste App License Key (from developer portal).
  * Under Digital Eyewear
    * Set Device Type to Phone + Viewer.
    * Set Viewer Config to Vuforia.
    * Set Viewer Type to Generic Cardboard (Vuforia).
7. Import the downloaded image target Unity package using Assets > Import Package > Custom Package.
8. Add an ImageTarget to the Hierarchy using GameObject > Vuforia > Camera Image > Camera Image Target.
9. Set up the ImageTarget's "Image Target Behaviour (Script)" fields in the Inspector as follows:
  * Set Type to Predefined.
  * Set Database to the imported target package.
  * Set Image Target to the target image in the imported package.
10. In the Hierarchy, as a child of the ImageTarget, create a sphere to act as the planet.
11. Create an empty game object child to the planet sphere, called CenterofGravity.
12. Create a sphere to act as the satellite, as the child of CenterofGravity.
13. Under the Assets folder, create a Scripts folder and place both povided C# scripts in it.
14. To CenterofGravity, attach the SatelliteRotation.cs script (drag and drop).
15. In the ImageTarget's Inspector fields, under Image Target Behaviour (Script)'s Advanced tab, choose Add Virtual Button twice.
16. In the first VirtualButton's Inspector fields, under Virtual Button Behaviour (Script):
  * Set Name to increaseButton
  * Set Sensitivity Setting to HIGH.
17. In the second VirtualButton's Inspector fields, under Virtual Button Behaviour (Script):
  * Set Name to decreaseButton
  * Set Sensitivity Setting to HIGH.
18. In the Scene View, move the increaseButton to one of the markers on the right side, and move the decreaseButton to the other.
19. Attach the VirtualButtonControlScript.cs script to the ImageTarget (drag and drop).
20. Build and Run.

### Final State of Hierarchy:
![Finaly Setup](/images/Setup.JPG)

# PoseClipboard
Unity Package to Copy and Paste transform orientations to your clipboard
![ezgif com-video-to-gif](https://github.com/hedgewizards/PoseClipboard/assets/105096969/595b4d5c-2333-4bf0-a70d-e2f2ebdeea63)

Unfortunately Unity's default serializer JsonUtility doesn't like to serailize deep hierarchies :( so it depends on Newtonsoft.JsonConvert

# To Install

In unity, go to Window -> Package Manage -> Plus -> Add Package from Git URL and paste in:

https://github.com/hedgewizards/PoseClipboard.git

![Unity_g9vI622p2o](https://github.com/hedgewizards/PoseClipboard/assets/105096969/ae6318c4-39a7-41ba-a1c5-7afcb97f9810)

# To use

Attach Pose Clipboard component to the root of your armature. click "Copy Pose" to put the pose into your clipboard. click "Paste Pose" to apply the pose from your clipboard.

only the transform's LocalPosition, LocalScale, and LocalRotation are replicated.

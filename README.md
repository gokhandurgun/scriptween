# Scriptween
Scriptween is an Editor tool built using DOTween.

## How to use
Scriptween is using Scriptable Objects to define DOTween methods. You can find sample scenes from Examples folder.

For a quick start:

**1. Create Scriptween**

Select Assets > Create > Scriptween

![image](https://user-images.githubusercontent.com/10315533/223221702-aa44df6b-6d50-48eb-af33-29e79d807a50.png)

**2. Select Tween Method**

Select Tween from dropdown and set related values.

![tutorial-scriptween-select](https://user-images.githubusercontent.com/10315533/223225097-3c1bba71-02b0-421c-bdf2-2e0f04276b9d.gif)

**3. Add ScriptweenMonoBehaviour Component**

Add ScriptweenMonoBehaviour component to any GameObject. Press "Add Tween" button and drop the Scriptween that already created. Set target component based on DOTween method.

![tutorial-scriptween-mono](https://user-images.githubusercontent.com/10315533/223226024-d540b89b-2252-4b0a-867f-8ae580985910.gif)

**4. See the Result**

Press Play button and see the result.

![tutorial-scriptween-test](https://user-images.githubusercontent.com/10315533/223227207-ae7069bd-4745-4bfc-9237-bf523049bb03.gif)

## Samples

I would like to share some use-cases, all of them include in the project.

* Material animations can be easily created. It's quite useful, instead of creating shaders to animate over time.
<img src="https://user-images.githubusercontent.com/10315533/223252816-05efcfea-2787-4d89-a58f-676b5208f920.gif" height=250>

* ScriptweenMonoBehaviour has TriggerEnter list to set Scriptweens. Of course, you can create your own script to hold Scriptweens and play whenever you want. [ExBarrier.cs](Examples/3D/Scripts/ExBarrier.cs) is good example to start.
<img src="https://user-images.githubusercontent.com/10315533/223253120-a621587f-d338-4fe2-b350-5d282fc9cec4.gif" height=250>

* Suppose implementing spike obstacles, which is really common on hyper-casual runner games. With Scriptween, you don't need developer's grace (kidding :)).
<img src="https://user-images.githubusercontent.com/10315533/223253730-f644400b-8824-4f41-8f0c-cc28b9480ba1.gif" height=250>

* Some UI animations, Scriptween very useful in making tutorials.
<img src="https://user-images.githubusercontent.com/10315533/223253856-f146bd8c-4159-409a-b671-54fafe0d2c9e.gif" height=250>

* You can create Sequences with several Scriptweens.
<img src="https://user-images.githubusercontent.com/10315533/223253180-dbe93447-c017-48db-9010-dacf4b4a2c61.gif" width=450>

## Install

* Unity 2021.3+
* Scriptween has a dependency to DOTween. Add DOTween 1.2.7+ and setup with all modules.
* Install [Scriptween (1.0).assetbundle](https://drive.google.com/uc?export=download&id=1FZ4Qy11GSlt1_RnsWDYj1NIp8rYhWeYk)

## Credits

I want to thank my friends (Mustafa & Furkan) for the project idea.
Also huge credit to Demigiant (@demigiant) who created DOTween.

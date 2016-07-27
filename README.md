# modmanager
A simple mod management tool created for the game Tooth & Tail(http://www.toothandtailgame.com/), but can be used for other games as well. The tool works by swapping modded files with the original ones. Right now the tool is still in development and it is not ready for the public.

__Platform:__ Windows

__Requires:__ .NET Framework v4.6

# Creating a profile
There isn't much you can do with the mod manager without a profile loaded. The profile contains info the mod manager needs in order to install an uninstall mods. In order to create a profile click *Profile* -> *Create new profile*. A window will pop up with the following fields.

+ __Game name__:
The name of the game for which the profile will be used.

+ __Game folder__:
The path to the folder containing the game executable.

+ __Mod files folder__:
The path to a folder which will contain the unarchived version of the mods added to your profile.

+ __Backup folder__:
The path to the folder containing backups of the original game files.

+ __Profile save location__:
The location where the profile file will be saved.

Once you are done filling out the fields, press **Confirm** and now you have a profile file.

__NOTE:__ The mod manager currenty does not automatically reload the last profile file when starting it up.


# Loading a profile file
To load a profile file, click *Profile* -> *Load profile*. __Make sure the file you selected is indeed a profile file!__

#Installing a mod
It should be noted that installing a mod is a 2-step process. First, the mod package needs to be added to your profile. After that's done, you can now install and uninstall the mod with the press of a button.

+ __Obtain the .TNT archive__
The mods are packaged conveniently in a single .TNT file.

+ __Add the mod to the profile__
In the mod manager, go to *Mod Packages* -> *Add package to profile (From .TNT archive)* and browse for the .TNT file of the mod you want to install.

+ __Installing/Uninstalling the mod__
You can now install/uninstall the mod at will using the **›** and **‹** buttons, respectively(or use the **››** and **‹‹** buttons to install/uninstall all mods at once).

#Packaging your own mod
This is a bit of a lengthy process as each individual file you alter/add needs to be manually added to the package.

###__Create a folder for the mod__ 
  This folder will be the root folder for all the files of the mod. You may simply copy-paste the mod files in this directory, or you may put them in a different one, as long as the mod folder can still be used as a root(eg. if you want to use the *my_mod* folder as the root folder for your mod,  *"C:/my_mod/textures"* is GOOD, *"C:/textures"* is BAD)

###__Create the package manifest__
  In the mod manager, go to **Package Editor** -> **Open Mod Package Editor**. This will open the package editor with all fields blank. Fill in the name, author(s) and the description of the mod(__NOTE: The mod name will also be the name of the .TNT archive__)
  
###__Add each mod file to the package__
  You've now reached the most fun part of the entire thing. Got several dozen files in your mod? You better be the patient type. On the right of the mod package info(name, author, description), there's a list which displays the game files/folders your mod targets. Below the list, there are 3 buttons: **New**, **Edit**, and **Delete**. To add a new mod file, press the **New** button. The mod editor window will pop up and you'll need to fill out the following:
  
  + __Modded file__ This is the path to the modded file inside you *mod folder*.
  + __Target file__ This is the path to the file/folder you want your modded file to replace/be added to(depending on the mod type)
  + __Mod type__ The mod manager can currently handle 2 types of mods:
    + Replacement mods are mods that replace existing files
    + Addition mods are mods that add new files
  
  After you filled in __ALL__ the fields in the mod editor window, press *Confirm*. Repeat the process for all files of your mod.

###__Save the mod manifest file__
  After all the mod files have been added, in the package editor, go to *File* ->*Save Package(New Manifest)* and select your *mod folder*. This will create a *package.json* file in that folder which is the manifest of the mod package.
  
###__Create the .TNT archive__
  From the main mod manager window, go to *Mod Packages* -> *Make .TNT Archive From .JSON Manifest* and browse for the manifest file you've created earlier. It will now create your .TNT archive in the folder above your mod folder. **Congratulations on creating your packaged mod!**

#Changelog

###v0.3 - More AnitStupid
  + The menu bar is less of an eye sore. It is now  white text over dark grey background
  + The mod manager now reloads the profile you had opened last time you ran the program
  + Additional exception handling for adding mod packages to profile
  + The mod manager now detects if you try to install a mod that conflicts(affects the same file) as a mod already enabled and will prevent the installation of the new one.
  + Fixed issue #6: *Cannot install mods if the game is on a different drive*

###v0.2 - Bug fixes and QoL improvements
  + Enabled the *New Package* and *Open Package Manifest* buttons in the package editor.
  + Added exception handling and error messages when loading profile files and mod manifests
  + Fixed issue #5: *Exception crashed the mod manager after the package editor is closed.*
  + Fixed issue #4: *When a ModPackage is removed from profile, the folder is not deleted*
  + Fixed issue #1: *NullReference Exception crashes the editor after a ModPackage target file update* (Unable to reproduce issue)
  
### v0.1 - Initial release
  + Ability to toggle mods On/Off
  + Ability to install mods from .TNT archives and raw .JSON manifests
  + Ability to create own mods via the package and mod editors
  

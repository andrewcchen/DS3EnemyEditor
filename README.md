## Dark Souls III map enemy editor

Crude tool for editing enemy placement in ds3 map files.
Developed for enemy randomizer testing.

![screenshot](https://raw.githubusercontent.com/andrewcchen/DS3EnemyEditor/master/Capture.png)

### Usage

Git clone or download a zip of master.

If you haven't already, first unpack game files with [UXM](https://github.com/JKAnderson/UXM).

Run Binary/DS3EnemyEditor.exe and load a .msb.dcx file,e.g. 
`C:\Program Files (x86)\Steam\steamapps\common\DARK SOULS III\Game\map\mapstudio\m30_00_00_00.msb.dcx` 

After making changes, remember to save.
You can save to a seperate folder and have modengine load it with modOverrideDirectory.
Or you can save to the original location and tell modengine to load it with loadUXMFiles=1. 

For now, also copy the script files from [the enemy randomizer](https://www.nexusmods.com/darksouls3/mods/484) to the mod override folder.
The mod's version of script files has all the enemy AIs in every map, otherwise enemy AI won't load.

### Tips

You should only need to change ModelName, ThinkParamID and NPCParamID.

### Credits

SoulsFormats by TKGP is used to read and write game files.

[Cinders wiki](http://ds3-cinders.wikidot.com/map-notes) for enemy ID and names.

Shoutouts to TKGP and katalash and many more in the DS3 modding community for making the tools that make modding possible.

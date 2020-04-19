## Dark Souls III map enemy editor

Crude tool for editing enemy placement in ds3 map files.
Developed for enemy randomizer testing.

### Usage

Git clone or download a zip of master.

If you haven't already, first unpack game files with [UXM](https://github.com/JKAnderson/UXM).

Run Binary/DS3EnemyEditor.exe and load a .msb.dcx file,e.g. 
`C:\Program Files (x86)\Steam\steamapps\common\DARK SOULS III\Game\map\mapstudio\m30_00_00_00.msb.dcx` 

After making changes, remember to save. 
You can save to the original location and tell modengine to load it with loadUXMFiles=1, 
or you can save to a seperate folder and load with modOverrideDirectory

### Credits

SoulsFormats by TKGP is used to read and write game files.

Shoutouts to TKGP and katalash and many more in the DS3 modding community for making the tools that make modding possible.

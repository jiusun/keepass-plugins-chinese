@echo off
cd %~dp0


echo Compiling PlgX
"../KeePass/KeePass.exe" /plgx-create "%~dp0KPEntryTemplates" 

copy /y KPEntryTemplates.plgx "../KeePass/Plugins/KPEntryTemplates.plgx"


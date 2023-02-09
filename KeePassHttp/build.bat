@echo off
cd %~dp0

echo Compiling PlgX
"../KeePass/KeePass.exe" /plgx-create "%~dp0KeePassHttp"

copy /y KeePassHttp.plgx "../KeePass/Plugins/KeePassHttp.plgx"


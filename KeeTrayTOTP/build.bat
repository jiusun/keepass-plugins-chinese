@echo off
cd %~dp0

echo Compiling PlgX
"../KeePass/KeePass.exe" /plgx-create "%~dp0KeeTrayTOTP"

copy /y KeeTrayTOTP.plgx "../KeePass/Plugins/KeeTrayTOTP.plgx"


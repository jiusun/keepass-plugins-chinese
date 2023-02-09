@echo off
cd %~dp0

echo Deleting existing PlgX folder
rmdir /s /q PlgX

echo Creating PlgX folder
mkdir PlgX

echo Copying files
xcopy "YAFD" PlgX /s /e /exclude:plgx-exclude.txt

echo Compiling PlgX
"../KeePass/KeePass.exe" /plgx-create "%~dp0PlgX" --plgx-prereq-kp:2.34

echo Releasing PlgX
move /y PlgX.plgx "YetAnotherFaviconDownloader.plgx"

copy /y YetAnotherFaviconDownloader.plgx "../KeePass/Plugins/YetAnotherFaviconDownloader.plgx"

echo Cleaning up
rmdir /s /q PlgX

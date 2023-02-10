@echo off
cd %~dp0


echo Compiling PlgX
"../KeePass/KeePass.exe" /plgx-create "%~dp0RDCAutoTypeAndTCATO" --plgx-prereq-kp:2.09 --plgx-prereq-net:2.0 --plgx-prereq-os:Windows

copy /y RDCAutoTypeAndTCATO.plgx "../KeePass/Plugins/RDCAutoTypeAndTCATO.plgx"


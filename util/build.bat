@echo off

SET COMMON_PATH=\Assets\HoloToolkit_Custom
SET MAIN_PATH=..\main_example%COMMON_PATH%

SET TARGET_1=drawing_example
SET TARGET_2=input_example
SET TARGET_3=spatial_example

:start
echo *** WARNING ***
echo This will replace the version of HoloToolkit_Custom in ALL projects with main_example.
set /p CHOICE=Do you want to continue? (Y/N)
if '%CHOICE%' == 'y' goto :yes
if '%CHOICE%' == 'Y' goto :yes
if '%CHOICE%' == 'n' goto :no
if '%CHOICE%' == 'N' goto :no

:yes
echo OK, I'm doin' it
echo ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
cd %cd%
echo . . .

rmdir /s /q ..\%TARGET_1%%COMMON_PATH%
rmdir /s /q ..\%TARGET_2%%COMMON_PATH%
rmdir /s /q ..\%TARGET_3%%COMMON_PATH%

xcopy /s /y %MAIN_PATH% ..\%TARGET_1%%COMMON_PATH%\
xcopy /s /y %MAIN_PATH% ..\%TARGET_2%%COMMON_PATH%\
xcopy /s /y %MAIN_PATH% ..\%TARGET_3%%COMMON_PATH%\

echo . . .
echo ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
goto :end

:no
echo . . .
echo Nothing was changed.
goto :end 

:end
@pause

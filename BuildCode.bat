
SETLOCAL EnableDelayedExpansion
@echo off
cls
del build\*.o

SET "debug="
SET "cwDWARF="
if "%1" equ "-d" SET "debug=-debug -map=^"C:\Users\admin\Documents\Dolphin Emulator\Maps\RMCP01.map^" -readelf=^"C:\MinGW\bin\readelf.exe^""
if "%1" equ "-d" SET "cwDWARF=-g"


:: Destination (change as necessary)
SET "SOURCE=Pulsar"
SET "RIIVO=D:\MKVN_Sourse\LatestCodeBuild"
::SET "RIIVO=D:\Games\Wii - Dolphin Load\Riivolution\TGBTesting\Binaries"
SET "ENGINE=D:\MKVN_Sourse\KamekInclude"
SET "CREATOR=D:\MKVN_Sourse\PulsarPackCreator\Resources"
echo %RIIVO%


:: CPP compilation settings
SET CC="../MKVN_Sourse/cw/mwcceppc.exe"
SET CFLAGS=-I- -i "../MKVN_Sourse/KamekInclude" -i "../MKVN_Sourse/GameSource" -i "../MKVN_Sourse/GameSource/MarioKartWii" -i PulsarEngine ^
  -opt all -inline auto -enum int -proc gekko -fp hard -sdata 0 -sdata2 0 -maxerrors 1 -func_align 4 %cwDWARF%
SET DEFINE=

:: CPP Sources
SET CPPFILES=
for /R PulsarEngine %%f in (*.cpp) do SET "CPPFILES=%%f !CPPFILES!"

:: Compile CPP
%CC% %CFLAGS% -c -o "build/kamek.o" "%ENGINE%\kamek.cpp"

SET OBJECTS=
FOR %%H IN (%CPPFILES%) DO (
    ::echo "Compiling %%H..."
    %CC% %CFLAGS% %DEFINE% -c -o "build/%%~nH.o" "%%H"
    SET "OBJECTS=build/%%~nH.o !OBJECTS!"
)

:: Link
echo Linking... %time%
"../MKVN_Sourse/KamekLinker/Kamek" "build/kamek.o" %OBJECTS% %debug% -dynamic -externals="../MKVN_Sourse/GameSource/symbols.txt" -versions="../MKVN_Sourse/GameSource/versions.txt" -output-combined=build\Code.pul

if %ErrorLevel% equ 0 (
    xcopy /Y build\*.pul "%RIIVO%" >nul
    xcopy /Y build\*.pul "%CREATOR%" >nul
    echo Binaries copied
)
pause
:end
ENDLOCAL
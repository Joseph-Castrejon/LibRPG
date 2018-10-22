@echo off


set GAMEPATH=E:\Projects\Game (In Progress)

rem "Use .NET Framework 3.5 to work well in Unity"
set CSC="C:\Windows\Microsoft.NET\Framework64\v3.5\"
set GAMELIBS="E:\Projects\Game (In Progress)\libs"
	

PATH=%PATH%;%CSC%;

echo %GAMEPATH%
cd %GAMEPATH%
csc /platform:x64 /lib:%GAMELIBS% Game-Classes.cs 

pause


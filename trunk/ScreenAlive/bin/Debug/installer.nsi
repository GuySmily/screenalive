; example1.nsi
;
; This script is perhaps one of the simplest NSIs you can make. All of the
; optional settings are left to their default settings. The installer simply 
; prompts the user asking them where to install, and drops a copy of example1.nsi
; there. 

;--------------------------------

; The name of the installer
Name "ScreenAlive"

; The file to write
OutFile "ScreenAliveSetup.exe"

; The default installation directory
InstallDir $DESKTOP

; Request application privileges for Windows Vista
RequestExecutionLevel user

;--------------------------------

; Pages

Page directory
Page instfiles

;--------------------------------

; The stuff to install
Section "" ;No components page, name is not important

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File ScreenAlive.exe

  CreateShortCut "$SMPROGRAMS\Startup\ScreenAlive.lnk" "$INSTDIR\ScreenAlive.exe" "" "$INSTDIR\ScreenAlive.exe" 0
  
SectionEnd ; end the section

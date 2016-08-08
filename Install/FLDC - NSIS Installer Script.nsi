; Edit this installer script with HM NIS Edit.
; Requires that NSIS (Nullsoft Scriptable Install System) compiler be installed.
; Copyright © 2016 FoldingCoin Inc


; ---- Helper defines / constants ----
!define PRODUCT_VERSION "3"  ;Match the displayed version in the program title. Example: 1.2.3
!define PRODUCT_4_VALUE_VERSION "3.0.0.0"  ;Match the executable version: Right-click the program executable file | Properties | Version. Example: 1.2.3.4
!define PRODUCT_YEAR "2016"
!define PRODUCT_NAME "FoldingBrowser"
!define PRODUCT_EXE_NAME "FoldingBrowser"  ;Executable name without extension
!define PRODUCT_PUBLISHER "FoldingCoin"
!define PRODUCT_WEB_SITE "http://foldingcoin.net"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXE_NAME}.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_EXE_NAME "Uninstall_${PRODUCT_EXE_NAME}"  ;Executable name without extension

!define REQUIRED_MS_DOT_NET_VERSION "4.0*"

SetCompressor lzma  ;Set compression method


!define MULTIUSER_EXECUTIONLEVEL admin ;Set the execution level for 'MultiUser.nsh'
!include MultiUser.nsh  ;Used for testing execution level. Does the installee have admin rights?

!include FileFunc.nsh  ;File Functions Header, for RefreshShellIcons
!insertmacro un.RefreshShellIcons

; ---- Modern UI section ----
!include MUI2.nsh

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_WELCOMEFINISHPAGE_BITMAP "Resources\Side-164x314.bmp"
!define MUI_ICON "Resources\FLDC_Installer-16_32_48.ico"
!define MUI_UNICON "Resources\Uninstaller-16_32_48.ico"
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_RIGHT
!define MUI_HEADERIMAGE_BITMAP "Resources\Header-150x57.bmp"
!define MUI_COMPONENTSPAGE_SMALLDESC   ;properties for the Components page. Without this, the description field is larger.

; Welcome page
!insertmacro MUI_PAGE_WELCOME

;License page
!insertmacro MUI_PAGE_LICENSE "..\Browser\bin\Release\LICENSE.txt"

;Directory page
!insertmacro MUI_PAGE_DIRECTORY

; Instfiles page
!insertmacro MUI_PAGE_INSTFILES

; Finish page
;!define MUI_FINISHPAGE_NOAUTOCLOSE  ;Enable for debugging to see where files get installed.
!define MUI_FINISHPAGE_RUN "$INSTDIR\${PRODUCT_EXE_NAME}.exe"
;!define MUI_FINISHPAGE_RUN_NOTCHECKED
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"
; ---- MUI section end ----

; ---- Installer Info ----
Name "${PRODUCT_NAME} v${PRODUCT_VERSION}"
OutFile "Installer\Install ${PRODUCT_NAME} v${PRODUCT_VERSION}.exe"
BrandingText "${PRODUCT_PUBLISHER}"
InstallDir "$PROGRAMFILES\${PRODUCT_NAME}"  ;Default installation folder (Set to: $INSTDIR during MUI_PAGE_DIRECTORY)
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
SetDatablockOptimize on
ShowInstDetails show
ShowUnInstDetails show
SetDateSave on
CRCCheck on
XPStyle on
SilentInstall normal  ;Silent install or uninstall: run from the command line with /S or /SD (case-sensitive) option. See NSIS help for more details.

; ---- Installer output file version information ----
  VIProductVersion "${PRODUCT_4_VALUE_VERSION}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductName" "${PRODUCT_NAME} v${PRODUCT_VERSION}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "Comments" "${PRODUCT_NAME} v${PRODUCT_VERSION} Installer"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "CompanyName" "${PRODUCT_PUBLISHER}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "Copyright © ${PRODUCT_YEAR} ${PRODUCT_PUBLISHER}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "${PRODUCT_NAME} v${PRODUCT_VERSION} Installer"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "${PRODUCT_VERSION}"

; ---- Installer sections, selectable on configuration page if shown ----
Section "!Main Program Installation" SEC01
  SetOverwrite on
  SectionIn RO  ;RO = Read only, which forces this section to be required
  SetShellVarContext all  ;Try to use the 'All Users' folder for shortcuts (WinXP only), otherwise default to the user's folder

  ;Program files to put in the installtion directory
  SetOutPath "$INSTDIR"  ;Destination
  File "..\Browser\bin\Release\*.pak"
  File "..\Browser\bin\Release\CefSharp.BrowserSubprocess.Core.dll"
  File "..\Browser\bin\Release\CefSharp.BrowserSubprocess.exe"
  File "..\Browser\bin\Release\CefSharp.BrowserSubprocess.exe.config"
  File "..\Browser\bin\Release\CefSharp.Core.dll"
  File "..\Browser\bin\Release\CefSharp.dll"
  File "..\Browser\bin\Release\CefSharp.WinForms.dll"
  File "..\Browser\bin\Release\d3dcompiler_43.dll"
  File "..\Browser\bin\Release\d3dcompiler_47.dll"
  File "..\Browser\bin\Release\FoldingBrowser.exe"
  File "..\Browser\bin\Release\icudtl.dat"
  File "..\Browser\bin\Release\libcef.dll"
  File "..\Browser\bin\Release\libEGL.dll"
  File "..\Browser\bin\Release\libGLESv2.dll"
  File "..\Browser\bin\Release\LICENSE.txt"
  File "..\Browser\bin\Release\natives_blob.bin"
  File "..\Browser\bin\Release\snapshot_blob.bin"
  File "..\Browser\bin\Release\widevinecdmadapter.dll"

  SetOutPath "$INSTDIR\Licenses"  ;Destination
  File "..\Browser\bin\Release\Licenses\*"
  
  SetOutPath "$INSTDIR\locales"  ;Destination
  File "..\Browser\bin\Release\locales\*.pak"

  ;Create program shortcuts
  SetShellVarContext all  ;Uninstall shortcuts from the 'All Users' folder (WinXP only), otherwise uninstall shortcuts from the user's folder
  SetOutPath "$INSTDIR"  ;Destination. Required to make the EXE shortcut 'start in' path correct
  CreateShortCut "$DESKTOP\Folding Browser.lnk" "$INSTDIR\FoldingBrowser.exe"
  CreateShortCut "$SMPROGRAMS\Folding Browser.lnk" "$INSTDIR\FoldingBrowser.exe"
SectionEnd

Section "Additional Files" SEC02
  SetOverwrite on
  SectionIn RO  ;Required section


SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\${PRODUCT_UNINST_EXE_NAME}.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\${PRODUCT_UNINST_EXE_NAME}.exe"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\FoldingBrowser.exe"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd


; ---- Installer functions ----
Function .onInit
  !insertmacro MULTIUSER_INIT  ;On install startup, ensure Admin user privilege level

  ;On startup, force uninstall of previous installation before installing this version
  ReadRegStr $R0 HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}" "UninstallString"
  StrCmp $R0 "" UninstallFinished
  MessageBox MB_YESNO|MB_ICONEXCLAMATION "Uninstall current copy of ${PRODUCT_NAME} and continue?" /SD IDYES IDYES UninstallPrevious
  Abort
UninstallPrevious:
  ClearErrors  ;Clear any errors and start the uninstaller of the previous program.
  ExecWait '$R0 _?=$INSTDIR'  ;Do not copy the uninstaller to a temp file for 'ExecWait' to work properly, and the uninstaller executable file cannot be deleted the normal way using this.
  IfErrors CancelledUninstallPrevious
    Delete "$R0"
    RMDir "$INSTDIR"
    Goto UninstallFinished
CancelledUninstallPrevious:
  Abort
UninstallFinished:

  ;Test if the Microsoft .NET Framework is installed, and popup a message if it's not.
  IfFileExists "$WINDIR\Microsoft.NET\Framework\v${REQUIRED_MS_DOT_NET_VERSION}" NETFrameworkInstalled 0
  StrCpy $0 "The Microsoft .NET Framework v${REQUIRED_MS_DOT_NET_VERSION} is not installed and is needed to run ${PRODUCT_NAME} v${PRODUCT_VERSION}.$\r$\n$\r$\nContinue installing ${PRODUCT_NAME} v${PRODUCT_VERSION}?"
  DetailPrint $0
  MessageBox MB_YESNO|MB_ICONEXCLAMATION "$0" /SD IDYES IDYES NETFrameworkInstalled IDNO 0
  Abort
NETFrameworkInstalled:
FunctionEnd



; ---- Uninstaller ----
Section Uninstall
  SetShellVarContext all  ;Uninstall shortcuts from the 'All Users' folder (WinXP only), otherwise uninstall shortcuts from the user's folder

  ;Delete the program shortcuts
  Delete "$SMPROGRAMS\Folding Browser.lnk"
  Delete "$DESKTOP\Folding Browser.lnk"

  ;Delete program files and folders
  Delete "$INSTDIR\Licenses\*"
  RMDir "$INSTDIR\Licenses"
  Delete "$INSTDIR\locales\*"
  RMDir "$INSTDIR\locales"
  ;Delete the main installation folder if possible
  Delete "$INSTDIR\*"
  RMDir "$INSTDIR"

  SetOutPath $APPDATA     ;Try changing to a different path to avoid being in the working folder
  ;Delete the main folder if possible
  RMDir /r "$INSTDIR"

  ;Delete the main folder if possible
  Delete "$INSTDIR\*"
  RMDir "$INSTDIR"

  SetShellVarContext current   ;for 'Current': $AppData = C:\Users\%username%\AppData\Roaming, otherwise for 'all': $AppData = C:\ProgramData
  ;Delete temp files and folders
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Dictionaries\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Dictionaries"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\GPUCache\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\GPUCache"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\IndexedDB\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\IndexedDB"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Local Storage\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Local Storage"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Pepper Data\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Pepper Data"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache"

  DeleteRegKey HKLM "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  ${un.RefreshShellIcons}   ;Make sure the desktop is refreshed to cleanup any deleted desktop icons
  SetAutoClose true
SectionEnd

; ---- Uninstaller functions ----
Function un.onInit
  !insertmacro MULTIUSER_UNINIT  ;On uninstall startup, ensure Admin user privilege level

  MessageBox MB_ICONQUESTION|MB_YESNO "Are you sure you want to completely remove $(^Name) and all of its components?" /SD IDYES IDYES +2
  Abort
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer." /SD IDOK
FunctionEnd
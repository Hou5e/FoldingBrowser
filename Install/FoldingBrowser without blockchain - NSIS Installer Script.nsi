; Edit this installer script with HM NIS Edit.
; Requires that NSIS (Nullsoft Scriptable Install System) compiler be installed.
; Copyright © 2023 FoldingCoin Developers, CureCoin Developers


;---- Helper defines / constants ----
!define PRODUCT_VERSION "23"  ;Match the displayed version in the program title. Example: 1.2.3
!define PRODUCT_4_VALUE_VERSION "23.0.0.0"  ;Match the executable version: Right-click the program executable file | Properties | Version. Example: 1.2.3.4
!define PRODUCT_YEAR "2023"
!define PRODUCT_NAME "FoldingBrowser"
!define PRODUCT_EXE_NAME "FoldingBrowser"  ;Executable name without extension
!define PRODUCT_PUBLISHER "FoldingBrowser"
!define PRODUCT_WEB_SITE "https://github.com/Hou5e/FoldingBrowser/releases"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXE_NAME}.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_EXE_NAME "Uninstall_${PRODUCT_EXE_NAME}"  ;Executable name without extension

;This constant must match the CureCoin installer version
!define CURECOIN_VERSION "2.1.0.1"

!define REQUIRED_MS_DOT_NET_VERSION "4.0*"

SetCompressor /SOLID lzma
SetCompressorDictSize 16
Var RunFoldingBrowser
Unicode true   ;For all languages to display properly (Installer won't run on Win95/98/ME)
!addincludedir "Include"
!addplugindir "Plugins\x86-unicode"

!define MULTIUSER_EXECUTIONLEVEL admin  ;Set the execution level for 'MultiUser.nsh'
!include MultiUser.nsh  ;Used for testing execution level. Does the installee have admin rights?

!include FileFunc.nsh  ;File Functions Header, for RefreshShellIcons
!insertmacro un.RefreshShellIcons

!include nsProcess.nsh  ;Used to see if the program is running and to close it, if it is

;---- Modern UI section ----
!include MUI2.nsh

;MUI Settings
!define MUI_ABORTWARNING
;Language page settings
!define MUI_LANGDLL_ALLLANGUAGES   ;Show all languages (Don't filter based on codepage)
!define MUI_LANGDLL_ALWAYSSHOW
!define MUI_LANGDLL_REGISTRY_ROOT "HKLM"
!define MUI_LANGDLL_REGISTRY_KEY "${PRODUCT_DIR_REGKEY}"
!define MUI_LANGDLL_REGISTRY_VALUENAME "Installer Language"

;Installer settings
!define MUI_WELCOMEFINISHPAGE_BITMAP "Resources\Side-164x314.bmp"
!define MUI_ICON "Resources\L-cysteine-3D-16_32_48.ico"
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_RIGHT
!define MUI_HEADERIMAGE_BITMAP "Resources\Header-150x57.bmp"
!define MUI_COMPONENTSPAGE_SMALLDESC   ;properties for the Components page. Without this, the description field is larger.
;!define MUI_COMPONENTSPAGE   ;Fix warning for unused language string for ${LANG_ASTURIAN}
;Uninstaller settings
!define MUI_UNWELCOMEFINISHPAGE_BITMAP "Resources\Side-164x314.bmp"
!define MUI_UNICON "Resources\Uninstaller-16_32_48.ico"
!define MUI_UNHEADERIMAGE
!define MUI_UNHEADERIMAGE_RIGHT
!define MUI_UNHEADERIMAGE_BITMAP "Resources\Header-150x57.bmp"

;Welcome page
!insertmacro MUI_PAGE_WELCOME

;License page
!insertmacro MUI_PAGE_LICENSE "LICENSE.txt"

;Components page
!insertmacro MUI_PAGE_COMPONENTS

;Directory page
!insertmacro MUI_PAGE_DIRECTORY

;Instfiles page
!insertmacro MUI_PAGE_INSTFILES

;Finish page
;Enable for debugging to see where files get installed.
;!define MUI_FINISHPAGE_NOAUTOCLOSE
;!define MUI_FINISHPAGE_RUN "$INSTDIR\${PRODUCT_EXE_NAME}.exe"
;!define MUI_FINISHPAGE_RUN_NOTCHECKED
;!insertmacro MUI_PAGE_FINISH

;Uninstaller pages
!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH

;Language files
!insertmacro MUI_LANGUAGE "English"  ;(default language is listed first)
!insertmacro MUI_LANGUAGE "French"
!insertmacro MUI_LANGUAGE "German"
!insertmacro MUI_LANGUAGE "Spanish"
!insertmacro MUI_LANGUAGE "SpanishInternational"
!insertmacro MUI_LANGUAGE "SimpChinese"
!insertmacro MUI_LANGUAGE "TradChinese"
!insertmacro MUI_LANGUAGE "Japanese"
!insertmacro MUI_LANGUAGE "Korean"
!insertmacro MUI_LANGUAGE "Italian"
!insertmacro MUI_LANGUAGE "Dutch"
!insertmacro MUI_LANGUAGE "Danish"
!insertmacro MUI_LANGUAGE "Swedish"
!insertmacro MUI_LANGUAGE "Norwegian"
!insertmacro MUI_LANGUAGE "NorwegianNynorsk"
!insertmacro MUI_LANGUAGE "Finnish"
!insertmacro MUI_LANGUAGE "Greek"
!insertmacro MUI_LANGUAGE "Russian"
!insertmacro MUI_LANGUAGE "Portuguese"
!insertmacro MUI_LANGUAGE "PortugueseBR"
!insertmacro MUI_LANGUAGE "Polish"
!insertmacro MUI_LANGUAGE "Ukrainian"
!insertmacro MUI_LANGUAGE "Czech"
!insertmacro MUI_LANGUAGE "Slovak"
!insertmacro MUI_LANGUAGE "Croatian"
!insertmacro MUI_LANGUAGE "Bulgarian"
!insertmacro MUI_LANGUAGE "Hungarian"
!insertmacro MUI_LANGUAGE "Thai"
!insertmacro MUI_LANGUAGE "Romanian"
!insertmacro MUI_LANGUAGE "Latvian"
!insertmacro MUI_LANGUAGE "Macedonian"
!insertmacro MUI_LANGUAGE "Estonian"
!insertmacro MUI_LANGUAGE "Turkish"
!insertmacro MUI_LANGUAGE "Lithuanian"
!insertmacro MUI_LANGUAGE "Slovenian"
!insertmacro MUI_LANGUAGE "Serbian"
!insertmacro MUI_LANGUAGE "SerbianLatin"
!insertmacro MUI_LANGUAGE "Arabic"
!insertmacro MUI_LANGUAGE "Farsi"
!insertmacro MUI_LANGUAGE "Hebrew"
!insertmacro MUI_LANGUAGE "Indonesian"
!insertmacro MUI_LANGUAGE "Mongolian"
!insertmacro MUI_LANGUAGE "Luxembourgish"
!insertmacro MUI_LANGUAGE "Albanian"
!insertmacro MUI_LANGUAGE "Breton"
!insertmacro MUI_LANGUAGE "Belarusian"
!insertmacro MUI_LANGUAGE "Icelandic"
!insertmacro MUI_LANGUAGE "Malay"
!insertmacro MUI_LANGUAGE "Bosnian"
!insertmacro MUI_LANGUAGE "Kurdish"
!insertmacro MUI_LANGUAGE "Irish"
!insertmacro MUI_LANGUAGE "Uzbek"
!insertmacro MUI_LANGUAGE "Galician"
!insertmacro MUI_LANGUAGE "Afrikaans"
!insertmacro MUI_LANGUAGE "Catalan"
!insertmacro MUI_LANGUAGE "Esperanto"
!insertmacro MUI_LANGUAGE "Asturian"
!insertmacro MUI_LANGUAGE "Basque"
!insertmacro MUI_LANGUAGE "Pashto"
!insertmacro MUI_LANGUAGE "ScotsGaelic"
!insertmacro MUI_LANGUAGE "Georgian"
!insertmacro MUI_LANGUAGE "Vietnamese"
!insertmacro MUI_LANGUAGE "Welsh"
!insertmacro MUI_LANGUAGE "Armenian"
!insertmacro MUI_LANGUAGE "Corsican"
!insertmacro MUI_LANGUAGE "Tatar"
!insertmacro MUI_LANGUAGE "Hindi"
!insertmacro MUI_RESERVEFILE_LANGDLL
;---- MUI section end ----

;---- Installer Info ----
Name "${PRODUCT_NAME} v${PRODUCT_VERSION}"
OutFile "Installer\Install-${PRODUCT_NAME}-v${PRODUCT_VERSION}.exe"
BrandingText "${PRODUCT_PUBLISHER}"
InstallDir "$PROGRAMFILES\${PRODUCT_NAME}"  ;Default installation folder (Set to: $INSTDIR during MUI_PAGE_DIRECTORY)
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
SetDatablockOptimize on
ShowInstDetails show
AutoCloseWindow true
ShowUnInstDetails show
SetDateSave on
CRCCheck on
XPStyle on
SilentInstall normal  ;Silent install or uninstall: run from the command line with /S or /SD (case-sensitive) option. See NSIS help for more details.

;---- Installer output file version information ----
  VIProductVersion "${PRODUCT_4_VALUE_VERSION}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductName" "${PRODUCT_NAME} v${PRODUCT_VERSION}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "Comments" "${PRODUCT_NAME} v${PRODUCT_VERSION} Installer"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "CompanyName" "FoldingCoin Developers, CureCoin Developers"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "Copyright © ${PRODUCT_YEAR} FoldingCoin Developers, CureCoin Developers"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "${PRODUCT_NAME} v${PRODUCT_VERSION} Installer"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "${PRODUCT_VERSION}"

;---- Installer sections, selectable on configuration page if shown ----
Section "!${PRODUCT_NAME} v${PRODUCT_VERSION}" SEC01
  SetOverwrite on
  SectionIn RO  ;RO = Read only, which forces this section to be required
  SetShellVarContext all  ;Try to use the 'All Users' folder for shortcuts (WinXP only), otherwise default to the user's folder

  ;If the FoldingBrowser is running, then close it
  Call CloseFoldingBrowser

  ;Program files to put in the installtion directory
  SetOutPath "$INSTDIR"  ;Destination
  File "..\Browser\bin\Release\*.pak"
  File "..\Browser\bin\Release\CefSharp.BrowserSubprocess.Core.dll"
  File "..\Browser\bin\Release\CefSharp.BrowserSubprocess.exe"
  File "..\Browser\bin\Release\CefSharp.Core.dll"
  File "..\Browser\bin\Release\CefSharp.dll"
  File "..\Browser\bin\Release\CefSharp.WinForms.dll"
  File "..\Browser\bin\Release\chrome_elf.dll"
  File "..\Browser\bin\Release\d3dcompiler_47.dll"
  File "..\Browser\bin\Release\FoldingBrowser.exe"
  File "..\Browser\bin\Release\FoldingBrowser.exe.config"
  File "..\Browser\bin\Release\icudtl.dat"
  File "..\Browser\bin\Release\libcef.dll"
  File "..\Browser\bin\Release\libEGL.dll"
  File "..\Browser\bin\Release\libGLESv2.dll"
  File "..\Browser\bin\Release\LICENSE.txt"
  File "..\Browser\bin\Release\*.bin"

  SetOutPath "$INSTDIR\Licenses"  ;Destination
  File "..\Browser\bin\Release\Licenses\*"

  SetOutPath "$INSTDIR\locales"  ;Destination
  File "..\Browser\bin\Release\locales\*.pak"

  SetOutPath "$INSTDIR\swiftshader"  ;Destination
  File "..\Browser\bin\Release\swiftshader\*.dll"

  ;Create program shortcuts
  SetShellVarContext all  ;Uninstall shortcuts from the 'All Users' folder (WinXP only), otherwise uninstall shortcuts from the user's folder
  SetOutPath "$INSTDIR"  ;Destination. Required to make the EXE shortcut 'start in' path correct
  CreateShortCut "$DESKTOP\Folding Browser.lnk" "$INSTDIR\FoldingBrowser.exe"
  CreateShortCut "$SMPROGRAMS\Folding Browser.lnk" "$INSTDIR\FoldingBrowser.exe"
  ;Set the default commandline options to indicate FoldingBrowser was installed. This initiates the 'Get Setup for Folding' dialog in the FoldingBrowser
  StrCpy $RunFoldingBrowser "$INSTDIR\${PRODUCT_EXE_NAME}.exe -Instl"
SectionEnd

Section "CureCoin Qt Wallet v${CURECOIN_VERSION}" SEC02
  SetOverwrite on
  AddSize 22800
  SectionIn 1
  ;If the CureCoin Wallet is running, then close it
  Call CloseCureCoin
  ;NOTE: CureCoin will not be uninstalled from this program's uninstaller, but it can be uninstalled with its own uninstlaller.
  Call CureCoinInstall
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

!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC01} "Web browser for FoldingCoin (FLDC) web wallet"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC02} "CureCoin Wallet: Needed for earning CureCoin, in addition to earning FoldingCoin"
!insertmacro MUI_FUNCTION_DESCRIPTION_END


; ---- Installer functions ----
Function .onInit
  ;On install startup, ensure Admin user privilege level
  !insertmacro MULTIUSER_INIT

  ;Language selection page
  !insertmacro MUI_LANGDLL_DISPLAY

  ;On startup, force uninstall of previous installation before installing this version
  ReadRegStr $R0 HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}" "UninstallString"
  StrCmp $R0 "" UninstallFinished

  ;Test if the Uninstaller EXE file is present. If not, then delete registry keys and skip trying to run the uninstaller that doesn't exist
  ;MessageBox MB_OK "$R0"
  IfFileExists "$R0" SkipMissingUninstaller 0
    DeleteRegKey HKLM "${PRODUCT_UNINST_KEY}"
    DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
    DeleteRegKey HKLM "Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
    DeleteRegKey HKLM "Software\Wow6432Node\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXE_NAME}.exe"
    Goto UninstallFinished
SkipMissingUninstaller:

  MessageBox MB_YESNO|MB_ICONEXCLAMATION "Uninstall current copy of ${PRODUCT_NAME} and continue?$\r$\n(User settings will be left in your user profile)" /SD IDYES IDYES UninstallPrevious
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

  ;Test if the Microsoft Visual C++ 2019 (x86) Redistributable is installed, and try to install it if it's not. Required by the CefSharp component
  ReadRegStr $3 HKLM "SOFTWARE\Wow6432Node\Microsoft\VisualStudio\14.0\VC\Runtimes\x86" "Installed"
  StrCmp $3 1 VCRedistributableInstalled
  ReadRegStr $3 HKLM "SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x86" "Installed"
  StrCmp $3 1 VCRedistributableInstalled

  MessageBox MB_OK "Installing the missing Microsoft Visual C++ 2019 (x86) Redistributable may take about 1 minute."
  ;Destination: $PLUGINSDIR is a temporary folder that is automatically deleted when the installer exits
  SetOutPath "$PLUGINSDIR"
  File "VCx86Redist\vc_redist.x86.exe"

  ;Initializes the plugins directory ($PLUGINSDIR) if it's not already initialized.
  InitPluginsDir

  ;Run the VC++ 2019 (x86) Redist. installer. For silent install use: /install /quiet /norestart
  ExecWait '"$PLUGINSDIR\vc_redist.x86.exe" /install /quiet /norestart' $4
  IntCmp $4 0 MsVCInstEnd  ;Skip error message if the installation was OK
  StrCpy $5 "MS VC++ 2019 (x86) Redist install error: $4 (undefined = error running exe, 0 = no error, 1 = cancel button, 2 = aborted by script)"
  MessageBox MB_OK "$5" /SD IDOK
  DetailPrint $5
MsVCInstEnd:

  ;Test if the Microsoft Visual C++ 2019 (x86) Redistributable is installed, and popup a message if it's not. Required by the CefSharp component
  ReadRegStr $3 HKLM "SOFTWARE\Wow6432Node\Microsoft\VisualStudio\14.0\VC\Runtimes\x86" "Installed"
  StrCmp $3 1 VCRedistributableInstalled
  ReadRegStr $3 HKLM "SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x86" "Installed"
  StrCmp $3 1 VCRedistributableInstalled
  MessageBox MB_YESNO|MB_ICONEXCLAMATION "Please install the Microsoft Visual C++ 2019 (x86) Redistributable.$\r$\n${PRODUCT_NAME} v${PRODUCT_VERSION} will not run without it.$\r$\n$\r$\nContinue installing ${PRODUCT_NAME} v${PRODUCT_VERSION}?" /SD IDYES IDYES VCRedistributableInstalled IDNO 0
  Abort
VCRedistributableInstalled:
FunctionEnd

Function CureCoinInstall
  ;Test if the CureCoin wallet.dat file is present before installing anything. Sets the check box in the initial FoldingBrowser install dialog
  SetShellVarContext current   ;for 'Current': $AppData = C:\Users\%username%\AppData\Roaming, otherwise for 'all': $AppData = C:\ProgramData
  ;MessageBox MB_OK "$APPDATA\curecoin\wallet.dat"
  IfFileExists "$APPDATA\curecoin\wallet.dat" CureWalletDatExists 0
  ;Change the commandline options to indicate the CureCoin wallet was installed
  StrCpy $RunFoldingBrowser "$INSTDIR\${PRODUCT_EXE_NAME}.exe -InstWithCure"
CureWalletDatExists:

  ;Destination: $PLUGINSDIR is a temporary folder that is automatically deleted when the installer exits
  SetOutPath "$PLUGINSDIR"
  File "CureInst\Install-CureCoin-Wallet-v${CURECOIN_VERSION}.exe"

  ;Initializes the plugins directory ($PLUGINSDIR) if it's not already initialized.
  InitPluginsDir

  ;The CureCoin installer was made with NSIS, so it can be run silently with /S
  ExecWait '"$PLUGINSDIR\Install-CureCoin-Wallet-v${CURECOIN_VERSION}.exe" /S /FoldingBrowserInstall' $1
  IntCmp $1 0 CureCoinInstEnd  ;Skip error message if the installation was OK
  StrCpy $2 "CureCoin install error: $1 (undefined = error running exe, 0 = no error, 1 = cancel button, 2 = aborted by script)"
  MessageBox MB_OK "$2" /SD IDOK
  DetailPrint $2
CureCoinInstEnd:
FunctionEnd

Function .oninstsuccess
  ;MessageBox MB_OK "$RunFoldingBrowser"   ;Enable for debugging commandline string
  Exec $RunFoldingBrowser
FunctionEnd

Function CloseFoldingBrowser
  Push $R0
RetryMsg:
  ;See if program is running
  ${nsProcess::FindProcess} "FoldingBrowser.exe" $R0    ;Returns 0 when found, or some number when not found.
  IntCmp $R0 0 0 0 ProceedWhenNotFound

  ;Close the program
  ${nsProcess::KillProcess} "FoldingBrowser.exe" $R0
  Sleep 400

  ;See if program is running
  ${nsProcess::FindProcess} "FoldingBrowser.exe" $R0
  IntCmp $R0 0 0 0 ProceedWhenNotFound
  Sleep 600

  ;See if program is running
  ${nsProcess::FindProcess} "FoldingBrowser.exe" $R0
  ;MessageBox MB_OK "Found: $R0"    ;Enable for debugging
  IntCmp $R0 0 0 0 ProceedWhenNotFound
  
  ;Ask to close program
  MessageBox MB_RETRYCANCEL "Please close the running FoldingBrowser software, and press 'Retry'.$\r$\n$\r$\nNote: FoldingBrowser maybe running in the system tray in the lower righthand corner of your screen." /SD IDCANCEL IDCANCEL ProceedWhenNotFound

  ;See if program is running
  ${nsProcess::FindProcess} "FoldingBrowser.exe" $R0
  IntCmp $R0 0 0 0 ProceedWhenNotFound

  Goto RetryMsg
ProceedWhenNotFound:
  Pop $R0
  ${nsProcess::Unload}
FunctionEnd

Function CloseCureCoin
  Push $R1
RetryLoop:
  ;See if program is running
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1    ;Returns 0 when found, or some number when not found.
  ;MessageBox MB_OK "Found: $R1"    ;Enable for debugging
  IntCmp $R1 0 0 0 ContinueWhenNotFound

  ;Ask to close program
  MessageBox MB_RETRYCANCEL "Please close the running CureCoin Wallet software,$\r$\nand press 'Retry' (takes about 20 seconds).$\r$\n$\r$\nNote: CureCoin maybe running in the system tray in the lower righthand corner of your screen." /SD IDCANCEL IDCANCEL ContinueWhenNotFound

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ContinueWhenNotFound
  Sleep 5000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ContinueWhenNotFound
  Sleep 5000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ContinueWhenNotFound
  Sleep 5000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ContinueWhenNotFound
  Sleep 3000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ContinueWhenNotFound
  Sleep 3000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ContinueWhenNotFound
  Sleep 3000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ContinueWhenNotFound
  Sleep 3000

  Goto RetryLoop
ContinueWhenNotFound:
  Pop $R1
FunctionEnd


;---- Uninstaller ----
Section Uninstall
  SetShellVarContext all  ;Uninstall shortcuts from the 'All Users' folder (WinXP only), otherwise uninstall shortcuts from the user's folder

  ;If the FoldingBrowser is running, then close it
  Call un.CloseFoldingBrowser

  ;Delete the program shortcuts
  Delete "$SMPROGRAMS\Folding Browser.lnk"
  Delete "$DESKTOP\Folding Browser.lnk"

  ;Delete program files and folders
  Delete "$INSTDIR\Licenses\*"
  RMDir "$INSTDIR\Licenses"
  Delete "$INSTDIR\locales\*"
  RMDir "$INSTDIR\locales"
  Delete "$INSTDIR\swiftshader\*"
  RMDir "$INSTDIR\swiftshader"
  ;Delete the main installation folder if possible
  Delete "$INSTDIR\*"
  RMDir "$INSTDIR"

  SetOutPath $APPDATA     ;Try changing to a different path to avoid being in the working folder
  ;Delete the main folder if possible
  RMDir /r "$INSTDIR"

  ;Delete the main folder, if possible
  Delete "$INSTDIR\*"
  RMDir "$INSTDIR"

  SetShellVarContext current   ;for 'Current': $AppData = C:\Users\%username%\AppData\Roaming, otherwise for 'all': $AppData = C:\ProgramData
  ;Delete temp files and folders
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Application Cache\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Application Cache"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\blob_storage\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\blob_storage"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Cache\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Cache"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\databases\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\databases"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Dictionaries\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Dictionaries"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\File System\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\File System"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\GPUCache\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\GPUCache"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\IndexedDB\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\IndexedDB"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Local Storage\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Local Storage"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Pepper Data\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Pepper Data"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\Service Worker\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\Service Worker"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\VideoDecodeStats\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache\VideoDecodeStats"
  Delete "$APPDATA\${PRODUCT_NAME}\Cache\*"
  RMDir /r "$APPDATA\${PRODUCT_NAME}\Cache"
  ;Leave settings files in this folder for reinstalls / upgrades

  DeleteRegKey HKLM "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  DeleteRegKey HKLM "Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
  DeleteRegKey HKLM "Software\Wow6432Node\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXE_NAME}.exe"
  ${un.RefreshShellIcons}   ;Make sure the desktop is refreshed to cleanup any deleted desktop icons
SectionEnd


;---- Uninstaller functions ----
Function un.onInit
  !insertmacro MULTIUSER_UNINIT  ;On uninstall startup, ensure Admin user privilege level

  ;Use same language as installer
  !insertmacro MUI_UNGETLANGUAGE
FunctionEnd

Function un.CloseFoldingBrowser
  Push $R0
unRetryMsg:
  ;See if program is running
  ${nsProcess::FindProcess} "FoldingBrowser.exe" $R0    ;Returns 0 when found, or some number when not found.
  IntCmp $R0 0 0 0 unProceedWhenNotFound

  ;Close the program
  ${nsProcess::KillProcess} "FoldingBrowser.exe" $R0
  Sleep 400

  ;See if program is running
  ${nsProcess::FindProcess} "FoldingBrowser.exe" $R0
  IntCmp $R0 0 0 0 unProceedWhenNotFound
  Sleep 600

  ;See if program is running
  ${nsProcess::FindProcess} "FoldingBrowser.exe" $R0
  ;MessageBox MB_OK "Found: $R0"    ;Enable for debugging
  IntCmp $R0 0 0 0 unProceedWhenNotFound

  ;Ask to close program
  MessageBox MB_RETRYCANCEL "Please close the running FoldingBrowser software, and press 'Retry'.$\r$\n$\r$\nNote: FoldingBrowser maybe running in the system tray in the lower righthand corner of your screen." /SD IDCANCEL IDCANCEL unProceedWhenNotFound

  ;See if program is running
  ${nsProcess::FindProcess} "FoldingBrowser.exe" $R0
  IntCmp $R0 0 0 0 unProceedWhenNotFound

  Goto unRetryMsg
unProceedWhenNotFound:
  Pop $R0
  ${nsProcess::Unload}
FunctionEnd
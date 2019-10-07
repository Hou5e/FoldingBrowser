; Edit this installer script with HM NIS Edit.
; Requires that NSIS (Nullsoft Scriptable Install System) compiler be installed.
; Copyright © 2019 CureCoin

;---- Helper defines / constants ----
!define PRODUCT_VERSION "2.0.0.2"  ;Match the displayed version in the program title. Example: 1.2.3
!define PRODUCT_4_VALUE_VERSION "2.0.0.2"  ;Match the executable version: Right-click the program executable file | Properties | Version. Example: 1.2.3.4
!define PRODUCT_UPDATED "2019-10-06"
!define PRODUCT_YEAR "2019"
!define PRODUCT_NAME "CureCoin"
!define PRODUCT_EXE_NAME "curecoin-qt"  ;Executable name without extension
!define PRODUCT_PUBLISHER "CureCoin"
!define PRODUCT_WEB_SITE "https://github.com/cygnusxi/CurecoinSource/releases"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXE_NAME}.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_EXE_NAME "Uninstall_${PRODUCT_EXE_NAME}"  ;Executable name without extension

SetCompressor lzma  ;Set compression method
Unicode true   ;For all languages to display properly (Installer won't run on Win95/98/ME)

!define MULTIUSER_EXECUTIONLEVEL admin  ;Set the execution level for 'MultiUser.nsh'
!include MultiUser.nsh  ;Used for testing execution level. Does the installee have admin rights?

!include FileFunc.nsh  ;File Functions Header, for: RefreshShellIcons, GetTime
!insertmacro un.RefreshShellIcons
!insertmacro GetTime

!include nsProcess.nsh  ;Used to see if the program is running and to close it, if it is

;---- Modern UI section ----
!include MUI2.nsh

;MUI Settings
!define MUI_ABORTWARNING
!define MUI_WELCOMEFINISHPAGE_BITMAP "Resources\CURE - Side-164x314.bmp"
!define MUI_ICON "Resources\CureCoinLogo-16_32_48.ico"
!define MUI_UNICON "Resources\Uninstaller-16_32_48.ico"
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_RIGHT
!define MUI_HEADERIMAGE_BITMAP "Resources\CURE - Header-150x57.bmp"
!define MUI_COMPONENTSPAGE_SMALLDESC   ;properties for the Components page. Without this, the description field is larger.

;Welcome page
!insertmacro MUI_PAGE_WELCOME

;License page
!insertmacro MUI_PAGE_LICENSE "CureCoin\license.txt"

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
!insertmacro MUI_UNPAGE_INSTFILES

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
!insertmacro MUI_LANGUAGE "Georgian"
!insertmacro MUI_LANGUAGE "Vietnamese"
!insertmacro MUI_LANGUAGE "Welsh"
!insertmacro MUI_LANGUAGE "Armenian"
!insertmacro MUI_RESERVEFILE_LANGDLL
;---- MUI section end ----

;---- Installer Info ----
Name "${PRODUCT_NAME} Wallet v${PRODUCT_VERSION}"
OutFile "CureInst\Install-${PRODUCT_NAME}-Wallet-v${PRODUCT_VERSION}.exe"
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
  VIAddVersionKey /LANG=${LANG_ENGLISH} "CompanyName" "${PRODUCT_PUBLISHER}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "Copyright © ${PRODUCT_YEAR} ${PRODUCT_PUBLISHER}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "${PRODUCT_NAME} v${PRODUCT_VERSION} Installer: ${PRODUCT_UPDATED} Update"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "${PRODUCT_VERSION}"

;---- Installer sections, selectable on configuration page if shown ----
Section "!Main Program Installation" SEC01
  SetOverwrite on
  SectionIn RO  ;RO = Read only, which forces this section to be required
  SetShellVarContext all  ;Try to use the 'All Users' folder for shortcuts (WinXP only), otherwise default to the user's folder

  ;If the CureCoin Wallet is running, then close it
  Call CloseCureCoin

  ;Program files to put in the installtion directory
  SetOutPath "$INSTDIR"  ;Destination
  File "CureCoin\license.txt"
  File "CureCoin\curecoin-qt.exe"
  File "CureCoin\Curecoin- cygnusxi - Source files on GitHub.url"

  SetShellVarContext current   ;for 'Current': $AppData = C:\Users\%username%\AppData\Roaming, otherwise for 'all': $AppData = C:\ProgramData
  SetOutPath "$APPDATA\curecoin"

  ;Make a backup copy of 'wallet.dat'
  ${GetTime} "" "L" $0 $1 $2 $3 $4 $5 $6
  CopyFiles /SILENT "$APPDATA\curecoin\wallet.dat" "$APPDATA\curecoin\wallet-Backup_$2-$1-$0_$4_$5.dat"

  File "CureCoin\curecoin.conf.example"
  ;(Only add on new installations) Include a 'peers.dat' file for a better list of bootstrap nodes
  SetOverwrite off
  File "CureCoin\peers.dat"
  SetOverwrite on

  ;Create program shortcuts
  SetShellVarContext all  ;Uninstall shortcuts from the 'All Users' folder (WinXP only), otherwise uninstall shortcuts from the user's folder
  SetOutPath "$INSTDIR"  ;Destination. Required to make the EXE shortcut 'start in' path correct
  CreateShortCut "$DESKTOP\CureCoin.lnk" "$INSTDIR\curecoin-qt.exe"
  CreateShortCut "$SMPROGRAMS\CureCoin.lnk" "$INSTDIR\curecoin-qt.exe"
  CreateShortCut "$SMPROGRAMS\CureCoin -ZapWalletTxes (Can fix issues).lnk" "$INSTDIR\curecoin-qt.exe" "-zapwallettxes"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\${PRODUCT_UNINST_EXE_NAME}.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\${PRODUCT_UNINST_EXE_NAME}.exe"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\curecoin-qt.exe"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr HKLM "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd


; ---- Installer functions ----
Function .onInit
  ;On install startup, ensure Admin user privilege level
  !insertmacro MULTIUSER_INIT
FunctionEnd

Function .oninstsuccess
  SetShellVarContext current
  ClearErrors
  ${GetOptions} $CMDLINE "/FoldingBrowser" $0
  IfErrors NoCommandLineArg 0
  StrCmp $0 "Install" 0 NoCommandLineArg
  ;FoldingBrowser Only: Once installed, auto-run the main program with the command line options to load settings for the local RPC login and port. This is used to get the CureCoin wallet address for CryptoBullions account signup through the FoldingBrowser
  ;MessageBox MB_OK "Got Cmdline Arg with parmeters: $0"    ;Enable for debugging
  Exec "$INSTDIR\${PRODUCT_EXE_NAME}.exe -conf=$APPDATA\curecoin\curecoin.conf.example"
  Goto SkipDifferentFinish

NoCommandLineArg:
  ClearErrors
  ;Normal CureCoin Wallet install: Once installed, auto-run the main program with the command line options to rescan for missing transactions
  ;MessageBox MB_OK "No matching Command Line args: $CMDLINE"    ;Enable for debugging
  Exec "$INSTDIR\${PRODUCT_EXE_NAME}.exe -zapwallettxes"
SkipDifferentFinish:
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

  ;If the CureCoin Wallet is running, then close it
  Call un.CloseCureCoin

  ;Delete the program shortcuts
  Delete "$SMPROGRAMS\CureCoin.lnk"
  Delete "$SMPROGRAMS\CureCoin -ZapWalletTxes (Can fix issues).lnk"
  Delete "$SMPROGRAMS\CureCoin Wallet Rescan (Can fix missing tx).lnk"

  Delete "$DESKTOP\CureCoin.lnk"

  ;Delete the main installation folder, if possible
  Delete "$INSTDIR\license.txt"
  Delete "$INSTDIR\curecoin-qt.exe"
  Delete "$INSTDIR\CureCoin\Curecoin- cygnusxi - Source files on GitHub.url"
  Delete "$INSTDIR\*"
  RMDir "$INSTDIR"

  SetOutPath $APPDATA     ;Try changing to a different path to avoid being in the working folder
  ;Delete the main folder if possible
  RMDir /r "$INSTDIR"

  ;Delete the main folder, if possible
  Delete "$INSTDIR\*"
  RMDir "$INSTDIR"

  DeleteRegKey HKLM "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  DeleteRegKey HKLM "Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
  DeleteRegKey HKLM "Software\Wow6432Node\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXE_NAME}.exe"
  ${un.RefreshShellIcons}   ;Make sure the desktop is refreshed to cleanup any deleted desktop icons
  SetAutoClose true
SectionEnd


;---- Uninstaller functions ----
Function un.onInit
  !insertmacro MULTIUSER_UNINIT  ;On uninstall startup, ensure Admin user privilege level

  MessageBox MB_ICONQUESTION|MB_YESNO "Are you sure you want to remove $(^Name)?$\r$\n(User settings and blockchain will be left in your user profile)" /SD IDYES IDYES +2
  Abort
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer." /SD IDOK
FunctionEnd

Function un.CloseCureCoin
  Push $R1
unRetryLoop:
  ;See if program is running
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1    ;Returns 0 when found, or some number when not found.
  ;MessageBox MB_OK "Found: $R1"    ;Enable for debugging
  IntCmp $R1 0 0 0 ExitWhenNotFound

  ;Ask to close program
  MessageBox MB_RETRYCANCEL "Please close the running CureCoin Wallet software,$\r$\nand press 'Retry' (takes about 20 seconds).$\r$\n$\r$\nNote: CureCoin maybe running in the system tray in the lower righthand corner of your screen." /SD IDCANCEL IDCANCEL ExitWhenNotFound

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ExitWhenNotFound
  Sleep 5000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ExitWhenNotFound
  Sleep 5000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ExitWhenNotFound
  Sleep 5000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ExitWhenNotFound
  Sleep 3000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ExitWhenNotFound
  Sleep 3000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ExitWhenNotFound
  Sleep 3000

  ;Try exiting loop
  ${nsProcess::FindProcess} "curecoin-qt.exe" $R1
  IntCmp $R1 0 0 0 ExitWhenNotFound
  Sleep 3000

  Goto unRetryLoop
ExitWhenNotFound:
  Pop $R1
FunctionEnd
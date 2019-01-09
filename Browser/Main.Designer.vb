<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnStopNav = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.btnToolsGetWallet = New System.Windows.Forms.Button()
        Me.btnMyWallet = New System.Windows.Forms.Button()
        Me.btnToolsGetFAH = New System.Windows.Forms.Button()
        Me.btnFAHWebControl = New System.Windows.Forms.Button()
        Me.btnToolsBrowserTools = New System.Windows.Forms.Button()
        Me.btnFoldingCoinWebsite = New System.Windows.Forms.Button()
        Me.btnCureCoinWebsite = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.gbxTools = New System.Windows.Forms.GroupBox()
        Me.btnToolsCureCoinSetup = New System.Windows.Forms.Button()
        Me.btnToolsFAHConfig = New System.Windows.Forms.Button()
        Me.btnToolsOptions = New System.Windows.Forms.Button()
        Me.btnToolsSavedData = New System.Windows.Forms.Button()
        Me.txtToolsWalletName = New System.Windows.Forms.TextBox()
        Me.cbxToolsWalletId = New System.Windows.Forms.ComboBox()
        Me.lblToolsWalletNum = New System.Windows.Forms.Label()
        Me.btnCurePool = New System.Windows.Forms.Button()
        Me.chkToolsShow = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFoldingCoinTwitter = New System.Windows.Forms.Button()
        Me.btnCureCoinTwitter = New System.Windows.Forms.Button()
        Me.btnFoldingCoinBlockchain = New System.Windows.Forms.Button()
        Me.btnEOC_UserStats = New System.Windows.Forms.Button()
        Me.btnCureCoinBlockchain = New System.Windows.Forms.Button()
        Me.btnFoldingCoinDiscord = New System.Windows.Forms.Button()
        Me.btnBTCBlockchain = New System.Windows.Forms.Button()
        Me.btnCureCoinDiscord = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnFindPrevious = New System.Windows.Forms.Button()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnFindClose = New System.Windows.Forms.Button()
        Me.btnFoldingCoinTeamStats = New System.Windows.Forms.Button()
        Me.btnFoldingCoinDistribution = New System.Windows.Forms.Button()
        Me.btnFoldingCoinShop = New System.Windows.Forms.Button()
        Me.btnFAHNews = New System.Windows.Forms.Button()
        Me.btnFoldingCoinUserStats = New System.Windows.Forms.Button()
        Me.btnFAHTwitter = New System.Windows.Forms.Button()
        Me.btnCureCoinTeamStats = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.gbxDownload = New System.Windows.Forms.GroupBox()
        Me.lblDownloadText = New System.Windows.Forms.Label()
        Me.pbProgIcon = New System.Windows.Forms.PictureBox()
        Me.pnlFind = New System.Windows.Forms.Panel()
        Me.pnlFindDivider = New System.Windows.Forms.Panel()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.pnlBtnLinks = New System.Windows.Forms.Panel()
        Me.pnlBtnLinksDividerBottom = New System.Windows.Forms.Panel()
        Me.gbxFAHRelated = New System.Windows.Forms.GroupBox()
        Me.gbxCureCoinRelated = New System.Windows.Forms.GroupBox()
        Me.gbxFoldingCoinRelated = New System.Windows.Forms.GroupBox()
        Me.pnlBtnLinksDividerTop = New System.Windows.Forms.Panel()
        Me.pnlURL = New System.Windows.Forms.Panel()
        Me.ToolStripContainer1.SuspendLayout()
        Me.gbxTools.SuspendLayout()
        Me.gbxDownload.SuspendLayout()
        CType(Me.pbProgIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFind.SuspendLayout()
        Me.pnlBtnLinks.SuspendLayout()
        Me.gbxFAHRelated.SuspendLayout()
        Me.gbxCureCoinRelated.SuspendLayout()
        Me.gbxFoldingCoinRelated.SuspendLayout()
        Me.pnlURL.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStopNav
        '
        Me.btnStopNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStopNav.BackColor = System.Drawing.Color.Transparent
        Me.btnStopNav.FlatAppearance.BorderSize = 0
        Me.btnStopNav.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnStopNav.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnStopNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopNav.Location = New System.Drawing.Point(1109, 6)
        Me.btnStopNav.Name = "btnStopNav"
        Me.btnStopNav.Size = New System.Drawing.Size(17, 17)
        Me.btnStopNav.TabIndex = 2
        Me.btnStopNav.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnStopNav, "Cancel navigation / download:   <ESC>")
        Me.btnStopNav.UseVisualStyleBackColor = False
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtURL.Location = New System.Drawing.Point(94, 4)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(1011, 20)
        Me.txtURL.TabIndex = 0
        Me.txtURL.WordWrap = False
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.BackColor = System.Drawing.SystemColors.Window
        Me.btnGo.FlatAppearance.BorderSize = 0
        Me.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(1084, 6)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(17, 17)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.ToolTip1.SetToolTip(Me.btnGo, "Go to URL:   <ENTER>")
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(62, 8)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(32, 13)
        Me.lblURL.TabIndex = 1
        Me.lblURL.Text = "URL:"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1207, 672)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(-1, 37)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1207, 672)
        Me.ToolStripContainer1.TabIndex = 5
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'btnToolsGetWallet
        '
        Me.btnToolsGetWallet.BackColor = System.Drawing.SystemColors.Window
        Me.btnToolsGetWallet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnToolsGetWallet.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnToolsGetWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToolsGetWallet.Location = New System.Drawing.Point(88, 16)
        Me.btnToolsGetWallet.Name = "btnToolsGetWallet"
        Me.btnToolsGetWallet.Size = New System.Drawing.Size(81, 23)
        Me.btnToolsGetWallet.TabIndex = 1
        Me.btnToolsGetWallet.Text = "2. Get Wallet"
        Me.ToolTip1.SetToolTip(Me.btnToolsGetWallet, "One Time Only! Get a CounterWallet for FLDC")
        Me.btnToolsGetWallet.UseVisualStyleBackColor = False
        '
        'btnMyWallet
        '
        Me.btnMyWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMyWallet.FlatAppearance.BorderSize = 0
        Me.btnMyWallet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMyWallet.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnMyWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyWallet.Location = New System.Drawing.Point(230, 19)
        Me.btnMyWallet.Name = "btnMyWallet"
        Me.btnMyWallet.Size = New System.Drawing.Size(86, 54)
        Me.btnMyWallet.TabIndex = 3
        Me.btnMyWallet.Text = "FLDC Wallet"
        Me.btnMyWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnMyWallet, "View wallet at CounterWallet")
        Me.btnMyWallet.UseVisualStyleBackColor = True
        '
        'btnToolsGetFAH
        '
        Me.btnToolsGetFAH.BackColor = System.Drawing.SystemColors.Window
        Me.btnToolsGetFAH.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnToolsGetFAH.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnToolsGetFAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToolsGetFAH.Location = New System.Drawing.Point(7, 16)
        Me.btnToolsGetFAH.Name = "btnToolsGetFAH"
        Me.btnToolsGetFAH.Size = New System.Drawing.Size(77, 23)
        Me.btnToolsGetFAH.TabIndex = 0
        Me.btnToolsGetFAH.Text = "1. Get F@H"
        Me.ToolTip1.SetToolTip(Me.btnToolsGetFAH, "One Time Only! Install and setup Folding@Home")
        Me.btnToolsGetFAH.UseVisualStyleBackColor = False
        '
        'btnFAHWebControl
        '
        Me.btnFAHWebControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFAHWebControl.FlatAppearance.BorderSize = 0
        Me.btnFAHWebControl.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFAHWebControl.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFAHWebControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFAHWebControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFAHWebControl.Location = New System.Drawing.Point(10, 19)
        Me.btnFAHWebControl.Name = "btnFAHWebControl"
        Me.btnFAHWebControl.Size = New System.Drawing.Size(86, 54)
        Me.btnFAHWebControl.TabIndex = 0
        Me.btnFAHWebControl.Text = "Web Control"
        Me.btnFAHWebControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFAHWebControl, "Folding@Home Web Control to View App Status")
        Me.btnFAHWebControl.UseVisualStyleBackColor = True
        '
        'btnToolsBrowserTools
        '
        Me.btnToolsBrowserTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToolsBrowserTools.BackColor = System.Drawing.SystemColors.Window
        Me.btnToolsBrowserTools.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnToolsBrowserTools.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnToolsBrowserTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToolsBrowserTools.Location = New System.Drawing.Point(492, 266)
        Me.btnToolsBrowserTools.Name = "btnToolsBrowserTools"
        Me.btnToolsBrowserTools.Size = New System.Drawing.Size(69, 23)
        Me.btnToolsBrowserTools.TabIndex = 1
        Me.btnToolsBrowserTools.Text = "Web Tools"
        Me.ToolTip1.SetToolTip(Me.btnToolsBrowserTools, "Web Developer Tools:  <F12>")
        Me.btnToolsBrowserTools.UseVisualStyleBackColor = False
        '
        'btnFoldingCoinWebsite
        '
        Me.btnFoldingCoinWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinWebsite.FlatAppearance.BorderSize = 0
        Me.btnFoldingCoinWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFoldingCoinWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFoldingCoinWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoldingCoinWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinWebsite.Location = New System.Drawing.Point(10, 19)
        Me.btnFoldingCoinWebsite.Name = "btnFoldingCoinWebsite"
        Me.btnFoldingCoinWebsite.Size = New System.Drawing.Size(82, 54)
        Me.btnFoldingCoinWebsite.TabIndex = 0
        Me.btnFoldingCoinWebsite.Text = "FoldingCoin"
        Me.btnFoldingCoinWebsite.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinWebsite, "FoldingCoin Website")
        Me.btnFoldingCoinWebsite.UseVisualStyleBackColor = True
        '
        'btnCureCoinWebsite
        '
        Me.btnCureCoinWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCureCoinWebsite.FlatAppearance.BorderSize = 0
        Me.btnCureCoinWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCureCoinWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCureCoinWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCureCoinWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinWebsite.Location = New System.Drawing.Point(10, 19)
        Me.btnCureCoinWebsite.Name = "btnCureCoinWebsite"
        Me.btnCureCoinWebsite.Size = New System.Drawing.Size(66, 54)
        Me.btnCureCoinWebsite.TabIndex = 0
        Me.btnCureCoinWebsite.Text = "CureCoin"
        Me.btnCureCoinWebsite.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinWebsite, "CureCoin Website")
        Me.btnCureCoinWebsite.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReload.BackColor = System.Drawing.Color.Transparent
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(1130, 6)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(17, 17)
        Me.btnReload.TabIndex = 3
        Me.btnReload.Text = "R"
        Me.ToolTip1.SetToolTip(Me.btnReload, "Reload Page:   <F5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or, reload ignoring cache:   CTRL+<F5>")
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(8, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "B"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Go back one page:   ALT+<Left>")
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnFwd
        '
        Me.btnFwd.BackColor = System.Drawing.Color.Transparent
        Me.btnFwd.FlatAppearance.BorderSize = 0
        Me.btnFwd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFwd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFwd.Location = New System.Drawing.Point(35, 3)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(25, 25)
        Me.btnFwd.TabIndex = 0
        Me.btnFwd.Text = "F"
        Me.ToolTip1.SetToolTip(Me.btnFwd, "Go forward one page:   ALT+<Right>")
        Me.btnFwd.UseVisualStyleBackColor = False
        '
        'gbxTools
        '
        Me.gbxTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxTools.BackColor = System.Drawing.Color.DarkSalmon
        Me.gbxTools.Controls.Add(Me.btnToolsCureCoinSetup)
        Me.gbxTools.Controls.Add(Me.btnToolsFAHConfig)
        Me.gbxTools.Controls.Add(Me.btnToolsGetFAH)
        Me.gbxTools.Controls.Add(Me.btnToolsGetWallet)
        Me.gbxTools.Location = New System.Drawing.Point(615, 275)
        Me.gbxTools.Name = "gbxTools"
        Me.gbxTools.Size = New System.Drawing.Size(370, 44)
        Me.gbxTools.TabIndex = 2
        Me.gbxTools.TabStop = False
        Me.gbxTools.Text = "Redo Initial Setup Steps:"
        '
        'btnToolsCureCoinSetup
        '
        Me.btnToolsCureCoinSetup.BackColor = System.Drawing.SystemColors.Window
        Me.btnToolsCureCoinSetup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnToolsCureCoinSetup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnToolsCureCoinSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToolsCureCoinSetup.Location = New System.Drawing.Point(266, 16)
        Me.btnToolsCureCoinSetup.Name = "btnToolsCureCoinSetup"
        Me.btnToolsCureCoinSetup.Size = New System.Drawing.Size(96, 23)
        Me.btnToolsCureCoinSetup.TabIndex = 3
        Me.btnToolsCureCoinSetup.Text = "4. CURE Setup"
        Me.ToolTip1.SetToolTip(Me.btnToolsCureCoinSetup, "(One-Time only) Setup CureCoin's CryptoBullions Folding Pool info")
        Me.btnToolsCureCoinSetup.UseVisualStyleBackColor = False
        '
        'btnToolsFAHConfig
        '
        Me.btnToolsFAHConfig.BackColor = System.Drawing.SystemColors.Window
        Me.btnToolsFAHConfig.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnToolsFAHConfig.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnToolsFAHConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToolsFAHConfig.Location = New System.Drawing.Point(173, 16)
        Me.btnToolsFAHConfig.Name = "btnToolsFAHConfig"
        Me.btnToolsFAHConfig.Size = New System.Drawing.Size(89, 23)
        Me.btnToolsFAHConfig.TabIndex = 2
        Me.btnToolsFAHConfig.Text = "3. F@H Config"
        Me.ToolTip1.SetToolTip(Me.btnToolsFAHConfig, "Setup Folding@Home: Username, Team, Passkey Config")
        Me.btnToolsFAHConfig.UseVisualStyleBackColor = False
        '
        'btnToolsOptions
        '
        Me.btnToolsOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToolsOptions.BackColor = System.Drawing.SystemColors.Window
        Me.btnToolsOptions.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnToolsOptions.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnToolsOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToolsOptions.Location = New System.Drawing.Point(604, 329)
        Me.btnToolsOptions.Name = "btnToolsOptions"
        Me.btnToolsOptions.Size = New System.Drawing.Size(67, 23)
        Me.btnToolsOptions.TabIndex = 3
        Me.btnToolsOptions.Text = "Options"
        Me.ToolTip1.SetToolTip(Me.btnToolsOptions, "Show Options")
        Me.btnToolsOptions.UseVisualStyleBackColor = False
        '
        'btnToolsSavedData
        '
        Me.btnToolsSavedData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToolsSavedData.BackColor = System.Drawing.SystemColors.Window
        Me.btnToolsSavedData.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnToolsSavedData.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnToolsSavedData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToolsSavedData.Location = New System.Drawing.Point(677, 329)
        Me.btnToolsSavedData.Name = "btnToolsSavedData"
        Me.btnToolsSavedData.Size = New System.Drawing.Size(84, 23)
        Me.btnToolsSavedData.TabIndex = 4
        Me.btnToolsSavedData.Text = "Saved Data"
        Me.ToolTip1.SetToolTip(Me.btnToolsSavedData, "Show Saved Settings from .Dat File")
        Me.btnToolsSavedData.UseVisualStyleBackColor = False
        '
        'txtToolsWalletName
        '
        Me.txtToolsWalletName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToolsWalletName.Location = New System.Drawing.Point(889, 330)
        Me.txtToolsWalletName.Name = "txtToolsWalletName"
        Me.txtToolsWalletName.Size = New System.Drawing.Size(112, 20)
        Me.txtToolsWalletName.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtToolsWalletName, "Change wallet name, press <Enter> to save it")
        '
        'cbxToolsWalletId
        '
        Me.cbxToolsWalletId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxToolsWalletId.FormattingEnabled = True
        Me.cbxToolsWalletId.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxToolsWalletId.Location = New System.Drawing.Point(858, 330)
        Me.cbxToolsWalletId.Name = "cbxToolsWalletId"
        Me.cbxToolsWalletId.Size = New System.Drawing.Size(30, 21)
        Me.cbxToolsWalletId.TabIndex = 6
        Me.cbxToolsWalletId.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cbxToolsWalletId, "Wallet Id (0-9) to use. Default: 0.")
        '
        'lblToolsWalletNum
        '
        Me.lblToolsWalletNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblToolsWalletNum.AutoSize = True
        Me.lblToolsWalletNum.Location = New System.Drawing.Point(789, 333)
        Me.lblToolsWalletNum.Name = "lblToolsWalletNum"
        Me.lblToolsWalletNum.Size = New System.Drawing.Size(72, 13)
        Me.lblToolsWalletNum.TabIndex = 5
        Me.lblToolsWalletNum.Text = "Use Wallet #:"
        '
        'btnCurePool
        '
        Me.btnCurePool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCurePool.FlatAppearance.BorderSize = 0
        Me.btnCurePool.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCurePool.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCurePool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCurePool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCurePool.Location = New System.Drawing.Point(298, 19)
        Me.btnCurePool.Name = "btnCurePool"
        Me.btnCurePool.Size = New System.Drawing.Size(75, 54)
        Me.btnCurePool.TabIndex = 4
        Me.btnCurePool.Text = "Pool Login"
        Me.btnCurePool.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCurePool, "Login to the CureCoin Folding Pool")
        Me.btnCurePool.UseVisualStyleBackColor = True
        '
        'chkToolsShow
        '
        Me.chkToolsShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkToolsShow.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkToolsShow.AutoSize = True
        Me.chkToolsShow.BackColor = System.Drawing.Color.Transparent
        Me.chkToolsShow.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkToolsShow.FlatAppearance.BorderSize = 0
        Me.chkToolsShow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.chkToolsShow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.chkToolsShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkToolsShow.Location = New System.Drawing.Point(1176, -1)
        Me.chkToolsShow.Name = "chkToolsShow"
        Me.chkToolsShow.Size = New System.Drawing.Size(24, 23)
        Me.chkToolsShow.TabIndex = 1
        Me.chkToolsShow.Text = "T"
        Me.chkToolsShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.chkToolsShow, "Show / Hide Tools and Settings")
        Me.chkToolsShow.UseVisualStyleBackColor = False
        '
        'btnFoldingCoinTwitter
        '
        Me.btnFoldingCoinTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinTwitter.FlatAppearance.BorderSize = 0
        Me.btnFoldingCoinTwitter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFoldingCoinTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFoldingCoinTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoldingCoinTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinTwitter.Location = New System.Drawing.Point(98, 19)
        Me.btnFoldingCoinTwitter.Name = "btnFoldingCoinTwitter"
        Me.btnFoldingCoinTwitter.Size = New System.Drawing.Size(60, 54)
        Me.btnFoldingCoinTwitter.TabIndex = 1
        Me.btnFoldingCoinTwitter.Text = "Twitter"
        Me.btnFoldingCoinTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinTwitter, "FoldingCoin Twitter")
        Me.btnFoldingCoinTwitter.UseVisualStyleBackColor = False
        '
        'btnCureCoinTwitter
        '
        Me.btnCureCoinTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCureCoinTwitter.FlatAppearance.BorderSize = 0
        Me.btnCureCoinTwitter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCureCoinTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCureCoinTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCureCoinTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinTwitter.Location = New System.Drawing.Point(82, 19)
        Me.btnCureCoinTwitter.Name = "btnCureCoinTwitter"
        Me.btnCureCoinTwitter.Size = New System.Drawing.Size(60, 54)
        Me.btnCureCoinTwitter.TabIndex = 1
        Me.btnCureCoinTwitter.Text = "Twitter"
        Me.btnCureCoinTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinTwitter, "CureCoin Twitter")
        Me.btnCureCoinTwitter.UseVisualStyleBackColor = False
        '
        'btnFoldingCoinBlockchain
        '
        Me.btnFoldingCoinBlockchain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinBlockchain.FlatAppearance.BorderSize = 0
        Me.btnFoldingCoinBlockchain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFoldingCoinBlockchain.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFoldingCoinBlockchain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoldingCoinBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinBlockchain.Location = New System.Drawing.Point(322, 19)
        Me.btnFoldingCoinBlockchain.Name = "btnFoldingCoinBlockchain"
        Me.btnFoldingCoinBlockchain.Size = New System.Drawing.Size(78, 54)
        Me.btnFoldingCoinBlockchain.TabIndex = 4
        Me.btnFoldingCoinBlockchain.Text = "Blockchain"
        Me.btnFoldingCoinBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinBlockchain, "FoldingCoin & CounterParty Tokens Blockchain Explorer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doesn't show BTC transact" &
        "ions)")
        Me.btnFoldingCoinBlockchain.UseVisualStyleBackColor = True
        '
        'btnEOC_UserStats
        '
        Me.btnEOC_UserStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEOC_UserStats.FlatAppearance.BorderSize = 0
        Me.btnEOC_UserStats.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEOC_UserStats.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnEOC_UserStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEOC_UserStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEOC_UserStats.Location = New System.Drawing.Point(366, 19)
        Me.btnEOC_UserStats.Name = "btnEOC_UserStats"
        Me.btnEOC_UserStats.Size = New System.Drawing.Size(82, 54)
        Me.btnEOC_UserStats.TabIndex = 4
        Me.btnEOC_UserStats.Text = "My Stats"
        Me.btnEOC_UserStats.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEOC_UserStats, "Extreme Overclocking Folding Stats")
        Me.btnEOC_UserStats.UseVisualStyleBackColor = True
        '
        'btnCureCoinBlockchain
        '
        Me.btnCureCoinBlockchain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCureCoinBlockchain.FlatAppearance.BorderSize = 0
        Me.btnCureCoinBlockchain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCureCoinBlockchain.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCureCoinBlockchain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCureCoinBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinBlockchain.Location = New System.Drawing.Point(214, 19)
        Me.btnCureCoinBlockchain.Name = "btnCureCoinBlockchain"
        Me.btnCureCoinBlockchain.Size = New System.Drawing.Size(78, 54)
        Me.btnCureCoinBlockchain.TabIndex = 3
        Me.btnCureCoinBlockchain.Text = "Blockchain"
        Me.btnCureCoinBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinBlockchain, "CureCoin Blockchain Explorer")
        Me.btnCureCoinBlockchain.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinDiscord
        '
        Me.btnFoldingCoinDiscord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinDiscord.FlatAppearance.BorderSize = 0
        Me.btnFoldingCoinDiscord.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFoldingCoinDiscord.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFoldingCoinDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoldingCoinDiscord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinDiscord.Location = New System.Drawing.Point(164, 19)
        Me.btnFoldingCoinDiscord.Name = "btnFoldingCoinDiscord"
        Me.btnFoldingCoinDiscord.Size = New System.Drawing.Size(60, 54)
        Me.btnFoldingCoinDiscord.TabIndex = 2
        Me.btnFoldingCoinDiscord.Text = "Discord"
        Me.btnFoldingCoinDiscord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinDiscord, "Contact us on the FoldingCoin Discord" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Questions and Comments")
        Me.btnFoldingCoinDiscord.UseVisualStyleBackColor = False
        '
        'btnBTCBlockchain
        '
        Me.btnBTCBlockchain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBTCBlockchain.FlatAppearance.BorderSize = 0
        Me.btnBTCBlockchain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBTCBlockchain.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnBTCBlockchain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBTCBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBTCBlockchain.Location = New System.Drawing.Point(406, 19)
        Me.btnBTCBlockchain.Name = "btnBTCBlockchain"
        Me.btnBTCBlockchain.Size = New System.Drawing.Size(68, 54)
        Me.btnBTCBlockchain.TabIndex = 5
        Me.btnBTCBlockchain.Text = "BTC Only"
        Me.btnBTCBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBTCBlockchain, "BTC Only Blockchain Explorer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doesn't show Counterparty Tokens)")
        Me.btnBTCBlockchain.UseVisualStyleBackColor = True
        '
        'btnCureCoinDiscord
        '
        Me.btnCureCoinDiscord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCureCoinDiscord.FlatAppearance.BorderSize = 0
        Me.btnCureCoinDiscord.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCureCoinDiscord.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCureCoinDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCureCoinDiscord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinDiscord.Location = New System.Drawing.Point(148, 19)
        Me.btnCureCoinDiscord.Name = "btnCureCoinDiscord"
        Me.btnCureCoinDiscord.Size = New System.Drawing.Size(60, 54)
        Me.btnCureCoinDiscord.TabIndex = 2
        Me.btnCureCoinDiscord.Text = "Discord"
        Me.btnCureCoinDiscord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinDiscord, "Contact us on the CureCoin Discord" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Questions and Comments")
        Me.btnCureCoinDiscord.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(1151, 6)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(17, 17)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "H"
        Me.ToolTip1.SetToolTip(Me.btnHome, "Go to Homepage")
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnFindPrevious
        '
        Me.btnFindPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnFindPrevious.FlatAppearance.BorderSize = 0
        Me.btnFindPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFindPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFindPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindPrevious.Location = New System.Drawing.Point(262, 2)
        Me.btnFindPrevious.Name = "btnFindPrevious"
        Me.btnFindPrevious.Size = New System.Drawing.Size(17, 17)
        Me.btnFindPrevious.TabIndex = 0
        Me.btnFindPrevious.Text = "U"
        Me.ToolTip1.SetToolTip(Me.btnFindPrevious, "Find Previous:  SHIFT+<ENTER>   Or   SHIFT+<F3>")
        Me.btnFindPrevious.UseVisualStyleBackColor = False
        '
        'btnFindNext
        '
        Me.btnFindNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindNext.BackColor = System.Drawing.Color.Transparent
        Me.btnFindNext.FlatAppearance.BorderSize = 0
        Me.btnFindNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFindNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindNext.Location = New System.Drawing.Point(286, 2)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(17, 17)
        Me.btnFindNext.TabIndex = 3
        Me.btnFindNext.Text = "D"
        Me.ToolTip1.SetToolTip(Me.btnFindNext, "Find Next:  <ENTER>   Or   <F3>")
        Me.btnFindNext.UseVisualStyleBackColor = False
        '
        'btnFindClose
        '
        Me.btnFindClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindClose.BackColor = System.Drawing.Color.Transparent
        Me.btnFindClose.FlatAppearance.BorderSize = 0
        Me.btnFindClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFindClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFindClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindClose.Location = New System.Drawing.Point(310, 2)
        Me.btnFindClose.Name = "btnFindClose"
        Me.btnFindClose.Size = New System.Drawing.Size(17, 17)
        Me.btnFindClose.TabIndex = 4
        Me.btnFindClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnFindClose, "Close Find:   <ESC>")
        Me.btnFindClose.UseVisualStyleBackColor = False
        '
        'btnFoldingCoinTeamStats
        '
        Me.btnFoldingCoinTeamStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinTeamStats.FlatAppearance.BorderSize = 0
        Me.btnFoldingCoinTeamStats.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFoldingCoinTeamStats.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFoldingCoinTeamStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoldingCoinTeamStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinTeamStats.Location = New System.Drawing.Point(632, 19)
        Me.btnFoldingCoinTeamStats.Name = "btnFoldingCoinTeamStats"
        Me.btnFoldingCoinTeamStats.Size = New System.Drawing.Size(80, 54)
        Me.btnFoldingCoinTeamStats.TabIndex = 8
        Me.btnFoldingCoinTeamStats.Text = "Team Stats"
        Me.btnFoldingCoinTeamStats.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinTeamStats, "Folding Stats for Team FoldingCoin")
        Me.btnFoldingCoinTeamStats.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinDistribution
        '
        Me.btnFoldingCoinDistribution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinDistribution.FlatAppearance.BorderSize = 0
        Me.btnFoldingCoinDistribution.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFoldingCoinDistribution.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFoldingCoinDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoldingCoinDistribution.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinDistribution.Location = New System.Drawing.Point(480, 19)
        Me.btnFoldingCoinDistribution.Name = "btnFoldingCoinDistribution"
        Me.btnFoldingCoinDistribution.Size = New System.Drawing.Size(80, 54)
        Me.btnFoldingCoinDistribution.TabIndex = 6
        Me.btnFoldingCoinDistribution.Text = "Distribution"
        Me.btnFoldingCoinDistribution.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinDistribution, "Completed FLDC Distributions")
        Me.btnFoldingCoinDistribution.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinShop
        '
        Me.btnFoldingCoinShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinShop.FlatAppearance.BorderSize = 0
        Me.btnFoldingCoinShop.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFoldingCoinShop.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFoldingCoinShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoldingCoinShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinShop.Location = New System.Drawing.Point(566, 19)
        Me.btnFoldingCoinShop.Name = "btnFoldingCoinShop"
        Me.btnFoldingCoinShop.Size = New System.Drawing.Size(60, 54)
        Me.btnFoldingCoinShop.TabIndex = 7
        Me.btnFoldingCoinShop.Text = "Shop"
        Me.btnFoldingCoinShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinShop, "Merchandise for Sale")
        Me.btnFoldingCoinShop.UseVisualStyleBackColor = True
        '
        'btnFAHNews
        '
        Me.btnFAHNews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFAHNews.FlatAppearance.BorderSize = 0
        Me.btnFAHNews.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFAHNews.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFAHNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFAHNews.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFAHNews.Location = New System.Drawing.Point(190, 19)
        Me.btnFAHNews.Name = "btnFAHNews"
        Me.btnFAHNews.Size = New System.Drawing.Size(82, 54)
        Me.btnFAHNews.TabIndex = 2
        Me.btnFAHNews.Text = "News"
        Me.btnFAHNews.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFAHNews, "Folding@Home News and Updates")
        Me.btnFAHNews.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinUserStats
        '
        Me.btnFoldingCoinUserStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinUserStats.FlatAppearance.BorderSize = 0
        Me.btnFoldingCoinUserStats.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFoldingCoinUserStats.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFoldingCoinUserStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoldingCoinUserStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinUserStats.Location = New System.Drawing.Point(278, 19)
        Me.btnFoldingCoinUserStats.Name = "btnFoldingCoinUserStats"
        Me.btnFoldingCoinUserStats.Size = New System.Drawing.Size(82, 54)
        Me.btnFoldingCoinUserStats.TabIndex = 3
        Me.btnFoldingCoinUserStats.Text = "My Stats"
        Me.btnFoldingCoinUserStats.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinUserStats, "FoldingCoin Stats")
        Me.btnFoldingCoinUserStats.UseVisualStyleBackColor = True
        '
        'btnFAHTwitter
        '
        Me.btnFAHTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFAHTwitter.FlatAppearance.BorderSize = 0
        Me.btnFAHTwitter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFAHTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFAHTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFAHTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFAHTwitter.Location = New System.Drawing.Point(102, 19)
        Me.btnFAHTwitter.Name = "btnFAHTwitter"
        Me.btnFAHTwitter.Size = New System.Drawing.Size(82, 54)
        Me.btnFAHTwitter.TabIndex = 1
        Me.btnFAHTwitter.Text = "Twitter"
        Me.btnFAHTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFAHTwitter, "Folding@Home Twitter")
        Me.btnFAHTwitter.UseVisualStyleBackColor = False
        '
        'btnCureCoinTeamStats
        '
        Me.btnCureCoinTeamStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCureCoinTeamStats.FlatAppearance.BorderSize = 0
        Me.btnCureCoinTeamStats.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCureCoinTeamStats.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCureCoinTeamStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCureCoinTeamStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinTeamStats.Location = New System.Drawing.Point(379, 19)
        Me.btnCureCoinTeamStats.Name = "btnCureCoinTeamStats"
        Me.btnCureCoinTeamStats.Size = New System.Drawing.Size(80, 54)
        Me.btnCureCoinTeamStats.TabIndex = 5
        Me.btnCureCoinTeamStats.Text = "Team Stats"
        Me.btnCureCoinTeamStats.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinTeamStats, "Folding Stats for Team CureCoin")
        Me.btnCureCoinTeamStats.UseVisualStyleBackColor = True
        '
        'txtMsg
        '
        Me.txtMsg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMsg.Location = New System.Drawing.Point(5, 277)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsg.Size = New System.Drawing.Size(584, 78)
        Me.txtMsg.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(70, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(233, 18)
        Me.ProgressBar1.TabIndex = 1
        '
        'lblPercent
        '
        Me.lblPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.SystemColors.Window
        Me.lblPercent.Location = New System.Drawing.Point(176, 12)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(23, 13)
        Me.lblPercent.TabIndex = 2
        Me.lblPercent.Text = "0%"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxDownload
        '
        Me.gbxDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDownload.BackColor = System.Drawing.Color.LemonChiffon
        Me.gbxDownload.Controls.Add(Me.lblDownloadText)
        Me.gbxDownload.Controls.Add(Me.lblPercent)
        Me.gbxDownload.Controls.Add(Me.ProgressBar1)
        Me.gbxDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDownload.Location = New System.Drawing.Point(775, -2)
        Me.gbxDownload.Name = "gbxDownload"
        Me.gbxDownload.Size = New System.Drawing.Size(307, 31)
        Me.gbxDownload.TabIndex = 0
        Me.gbxDownload.TabStop = False
        Me.gbxDownload.Visible = False
        '
        'lblDownloadText
        '
        Me.lblDownloadText.AutoSize = True
        Me.lblDownloadText.BackColor = System.Drawing.Color.Transparent
        Me.lblDownloadText.Location = New System.Drawing.Point(2, 12)
        Me.lblDownloadText.Name = "lblDownloadText"
        Me.lblDownloadText.Size = New System.Drawing.Size(67, 13)
        Me.lblDownloadText.TabIndex = 1
        Me.lblDownloadText.Text = "Download:"
        Me.lblDownloadText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbProgIcon
        '
        Me.pbProgIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbProgIcon.Location = New System.Drawing.Point(950, 14)
        Me.pbProgIcon.Name = "pbProgIcon"
        Me.pbProgIcon.Size = New System.Drawing.Size(50, 50)
        Me.pbProgIcon.TabIndex = 140
        Me.pbProgIcon.TabStop = False
        '
        'pnlFind
        '
        Me.pnlFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFind.BackColor = System.Drawing.SystemColors.Window
        Me.pnlFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFind.Controls.Add(Me.pnlFindDivider)
        Me.pnlFind.Controls.Add(Me.btnFindClose)
        Me.pnlFind.Controls.Add(Me.btnFindNext)
        Me.pnlFind.Controls.Add(Me.btnFindPrevious)
        Me.pnlFind.Controls.Add(Me.txtFind)
        Me.pnlFind.Location = New System.Drawing.Point(835, 28)
        Me.pnlFind.Name = "pnlFind"
        Me.pnlFind.Size = New System.Drawing.Size(333, 25)
        Me.pnlFind.TabIndex = 3
        Me.pnlFind.Visible = False
        '
        'pnlFindDivider
        '
        Me.pnlFindDivider.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFindDivider.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlFindDivider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlFindDivider.Location = New System.Drawing.Point(255, 3)
        Me.pnlFindDivider.Name = "pnlFindDivider"
        Me.pnlFindDivider.Size = New System.Drawing.Size(2, 16)
        Me.pnlFindDivider.TabIndex = 2
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(4, 4)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(248, 14)
        Me.txtFind.TabIndex = 1
        '
        'pnlBtnLinks
        '
        Me.pnlBtnLinks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBtnLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlBtnLinks.BackColor = System.Drawing.SystemColors.Window
        Me.pnlBtnLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBtnLinks.Controls.Add(Me.pnlBtnLinksDividerBottom)
        Me.pnlBtnLinks.Controls.Add(Me.btnToolsBrowserTools)
        Me.pnlBtnLinks.Controls.Add(Me.gbxFAHRelated)
        Me.pnlBtnLinks.Controls.Add(Me.gbxCureCoinRelated)
        Me.pnlBtnLinks.Controls.Add(Me.txtToolsWalletName)
        Me.pnlBtnLinks.Controls.Add(Me.gbxFoldingCoinRelated)
        Me.pnlBtnLinks.Controls.Add(Me.cbxToolsWalletId)
        Me.pnlBtnLinks.Controls.Add(Me.pnlBtnLinksDividerTop)
        Me.pnlBtnLinks.Controls.Add(Me.btnToolsSavedData)
        Me.pnlBtnLinks.Controls.Add(Me.pbProgIcon)
        Me.pnlBtnLinks.Controls.Add(Me.btnToolsOptions)
        Me.pnlBtnLinks.Controls.Add(Me.txtMsg)
        Me.pnlBtnLinks.Controls.Add(Me.lblToolsWalletNum)
        Me.pnlBtnLinks.Controls.Add(Me.gbxTools)
        Me.pnlBtnLinks.Location = New System.Drawing.Point(94, 28)
        Me.pnlBtnLinks.Name = "pnlBtnLinks"
        Me.pnlBtnLinks.Size = New System.Drawing.Size(1011, 360)
        Me.pnlBtnLinks.TabIndex = 2
        '
        'pnlBtnLinksDividerBottom
        '
        Me.pnlBtnLinksDividerBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBtnLinksDividerBottom.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlBtnLinksDividerBottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlBtnLinksDividerBottom.Location = New System.Drawing.Point(6, 263)
        Me.pnlBtnLinksDividerBottom.Name = "pnlBtnLinksDividerBottom"
        Me.pnlBtnLinksDividerBottom.Size = New System.Drawing.Size(997, 2)
        Me.pnlBtnLinksDividerBottom.TabIndex = 1
        '
        'gbxFAHRelated
        '
        Me.gbxFAHRelated.Controls.Add(Me.btnFAHNews)
        Me.gbxFAHRelated.Controls.Add(Me.btnFoldingCoinUserStats)
        Me.gbxFAHRelated.Controls.Add(Me.btnFAHTwitter)
        Me.gbxFAHRelated.Controls.Add(Me.btnEOC_UserStats)
        Me.gbxFAHRelated.Controls.Add(Me.btnFAHWebControl)
        Me.gbxFAHRelated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbxFAHRelated.Location = New System.Drawing.Point(5, 10)
        Me.gbxFAHRelated.Name = "gbxFAHRelated"
        Me.gbxFAHRelated.Size = New System.Drawing.Size(468, 80)
        Me.gbxFAHRelated.TabIndex = 1
        Me.gbxFAHRelated.TabStop = False
        Me.gbxFAHRelated.Text = "Folding@Home Related:"
        '
        'gbxCureCoinRelated
        '
        Me.gbxCureCoinRelated.Controls.Add(Me.btnCureCoinTeamStats)
        Me.gbxCureCoinRelated.Controls.Add(Me.btnCureCoinWebsite)
        Me.gbxCureCoinRelated.Controls.Add(Me.btnCureCoinBlockchain)
        Me.gbxCureCoinRelated.Controls.Add(Me.btnCurePool)
        Me.gbxCureCoinRelated.Controls.Add(Me.btnCureCoinTwitter)
        Me.gbxCureCoinRelated.Controls.Add(Me.btnCureCoinDiscord)
        Me.gbxCureCoinRelated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbxCureCoinRelated.Location = New System.Drawing.Point(5, 174)
        Me.gbxCureCoinRelated.Name = "gbxCureCoinRelated"
        Me.gbxCureCoinRelated.Size = New System.Drawing.Size(468, 80)
        Me.gbxCureCoinRelated.TabIndex = 3
        Me.gbxCureCoinRelated.TabStop = False
        Me.gbxCureCoinRelated.Text = "CureCoin Related:"
        '
        'gbxFoldingCoinRelated
        '
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnFoldingCoinTeamStats)
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnFoldingCoinWebsite)
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnFoldingCoinTwitter)
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnFoldingCoinShop)
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnFoldingCoinBlockchain)
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnMyWallet)
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnBTCBlockchain)
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnFoldingCoinDiscord)
        Me.gbxFoldingCoinRelated.Controls.Add(Me.btnFoldingCoinDistribution)
        Me.gbxFoldingCoinRelated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbxFoldingCoinRelated.Location = New System.Drawing.Point(5, 92)
        Me.gbxFoldingCoinRelated.Name = "gbxFoldingCoinRelated"
        Me.gbxFoldingCoinRelated.Size = New System.Drawing.Size(719, 80)
        Me.gbxFoldingCoinRelated.TabIndex = 2
        Me.gbxFoldingCoinRelated.TabStop = False
        Me.gbxFoldingCoinRelated.Text = "FoldingCoin Related:"
        '
        'pnlBtnLinksDividerTop
        '
        Me.pnlBtnLinksDividerTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBtnLinksDividerTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlBtnLinksDividerTop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlBtnLinksDividerTop.Location = New System.Drawing.Point(6, 2)
        Me.pnlBtnLinksDividerTop.Name = "pnlBtnLinksDividerTop"
        Me.pnlBtnLinksDividerTop.Size = New System.Drawing.Size(997, 2)
        Me.pnlBtnLinksDividerTop.TabIndex = 0
        '
        'pnlURL
        '
        Me.pnlURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlURL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlURL.Controls.Add(Me.btnGo)
        Me.pnlURL.Controls.Add(Me.chkToolsShow)
        Me.pnlURL.Controls.Add(Me.gbxDownload)
        Me.pnlURL.Controls.Add(Me.btnFwd)
        Me.pnlURL.Controls.Add(Me.lblURL)
        Me.pnlURL.Controls.Add(Me.txtURL)
        Me.pnlURL.Controls.Add(Me.btnStopNav)
        Me.pnlURL.Controls.Add(Me.btnReload)
        Me.pnlURL.Controls.Add(Me.btnBack)
        Me.pnlURL.Controls.Add(Me.btnHome)
        Me.pnlURL.Location = New System.Drawing.Point(0, 2)
        Me.pnlURL.Name = "pnlURL"
        Me.pnlURL.Size = New System.Drawing.Size(1205, 31)
        Me.pnlURL.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1205, 708)
        Me.Controls.Add(Me.pnlFind)
        Me.Controls.Add(Me.pnlBtnLinks)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.pnlURL)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(16, 38)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.gbxTools.ResumeLayout(False)
        Me.gbxDownload.ResumeLayout(False)
        Me.gbxDownload.PerformLayout()
        CType(Me.pbProgIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFind.ResumeLayout(False)
        Me.pnlFind.PerformLayout()
        Me.pnlBtnLinks.ResumeLayout(False)
        Me.pnlBtnLinks.PerformLayout()
        Me.gbxFAHRelated.ResumeLayout(False)
        Me.gbxCureCoinRelated.ResumeLayout(False)
        Me.gbxFoldingCoinRelated.ResumeLayout(False)
        Me.pnlURL.ResumeLayout(False)
        Me.pnlURL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStopNav As System.Windows.Forms.Button
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents btnToolsGetWallet As System.Windows.Forms.Button
    Friend WithEvents btnMyWallet As System.Windows.Forms.Button
    Friend WithEvents btnToolsGetFAH As System.Windows.Forms.Button
    Friend WithEvents btnFAHWebControl As System.Windows.Forms.Button
    Friend WithEvents btnToolsBrowserTools As System.Windows.Forms.Button
    Friend WithEvents btnFoldingCoinWebsite As System.Windows.Forms.Button
    Friend WithEvents btnCureCoinWebsite As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnFwd As System.Windows.Forms.Button
    Friend WithEvents gbxTools As System.Windows.Forms.GroupBox
    Friend WithEvents chkToolsShow As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents gbxDownload As System.Windows.Forms.GroupBox
    Friend WithEvents btnFoldingCoinTwitter As Button
    Friend WithEvents btnCureCoinTwitter As Button
    Friend WithEvents pbProgIcon As PictureBox
    Friend WithEvents btnToolsFAHConfig As Button
    Friend WithEvents btnEOC_UserStats As Button
    Friend WithEvents cbxToolsWalletId As ComboBox
    Friend WithEvents lblToolsWalletNum As Label
    Friend WithEvents txtToolsWalletName As TextBox
    Friend WithEvents btnToolsSavedData As Button
    Friend WithEvents btnFoldingCoinBlockchain As Button
    Friend WithEvents btnCureCoinBlockchain As Button
    Friend WithEvents btnToolsCureCoinSetup As Button
    Friend WithEvents btnCurePool As Button
    Friend WithEvents btnFoldingCoinDiscord As Button
    Friend WithEvents btnBTCBlockchain As Button
    Friend WithEvents btnCureCoinDiscord As Button
    Friend WithEvents btnFoldingCoinDistribution As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnToolsOptions As Button
    Private WithEvents pnlFind As Panel
    Private WithEvents txtFind As TextBox
    Friend WithEvents btnFindClose As Button
    Friend WithEvents btnFindNext As Button
    Friend WithEvents btnFindPrevious As Button
    Friend WithEvents pnlFindDivider As Panel
    Friend WithEvents btnFoldingCoinShop As Button
    Friend WithEvents pnlBtnLinks As Panel
    Friend WithEvents pnlBtnLinksDividerTop As Panel
    Friend WithEvents lblDownloadText As Label
    Friend WithEvents pnlURL As Panel
    Friend WithEvents gbxCureCoinRelated As GroupBox
    Friend WithEvents gbxFoldingCoinRelated As GroupBox
    Friend WithEvents btnFoldingCoinTeamStats As Button
    Friend WithEvents gbxFAHRelated As GroupBox
    Friend WithEvents btnFoldingCoinUserStats As Button
    Friend WithEvents btnCureCoinTeamStats As Button
    Friend WithEvents btnFAHNews As Button
    Friend WithEvents btnFAHTwitter As Button
    Friend WithEvents pnlBtnLinksDividerBottom As Panel
End Class

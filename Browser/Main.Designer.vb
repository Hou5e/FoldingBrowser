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
        Me.btnGetWallet = New System.Windows.Forms.Button()
        Me.btnMyWallet = New System.Windows.Forms.Button()
        Me.btnGetFAH = New System.Windows.Forms.Button()
        Me.btnFAHControl = New System.Windows.Forms.Button()
        Me.btnBrowserTools = New System.Windows.Forms.Button()
        Me.btnFoldingCoinWebsite = New System.Windows.Forms.Button()
        Me.btnCureCoin = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.gbxTools = New System.Windows.Forms.GroupBox()
        Me.btnCureCoinSetup = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnSavedData = New System.Windows.Forms.Button()
        Me.txtWalletName = New System.Windows.Forms.TextBox()
        Me.cbxWalletId = New System.Windows.Forms.ComboBox()
        Me.btnFAHConfig = New System.Windows.Forms.Button()
        Me.lblWalletNum = New System.Windows.Forms.Label()
        Me.btnCurePool = New System.Windows.Forms.Button()
        Me.chkShowTools = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFoldingCoinTwitter = New System.Windows.Forms.Button()
        Me.btnCureCoinTwitter = New System.Windows.Forms.Button()
        Me.btnFoldingCoinBlockchain = New System.Windows.Forms.Button()
        Me.btnEOC = New System.Windows.Forms.Button()
        Me.btnCureCoinBlockchain = New System.Windows.Forms.Button()
        Me.btnFoldingCoinDiscord = New System.Windows.Forms.Button()
        Me.btnBTCBlockchain = New System.Windows.Forms.Button()
        Me.btnCureCoinDiscord = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnFindPrevious = New System.Windows.Forms.Button()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnFindClose = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.gbxCheckboxForTools = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.gbxDownload = New System.Windows.Forms.GroupBox()
        Me.pbProgIcon = New System.Windows.Forms.PictureBox()
        Me.btnFLDC_Distribution = New System.Windows.Forms.Button()
        Me.pnlFind = New System.Windows.Forms.Panel()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.ToolStripContainer1.SuspendLayout()
        Me.gbxTools.SuspendLayout()
        Me.gbxCheckboxForTools.SuspendLayout()
        Me.gbxDownload.SuspendLayout()
        CType(Me.pbProgIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFind.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStopNav
        '
        Me.btnStopNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStopNav.BackColor = System.Drawing.SystemColors.Control
        Me.btnStopNav.FlatAppearance.BorderSize = 0
        Me.btnStopNav.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnStopNav.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnStopNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopNav.Location = New System.Drawing.Point(1073, 49)
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
        Me.txtURL.Location = New System.Drawing.Point(112, 48)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(956, 20)
        Me.txtURL.TabIndex = 0
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.BackColor = System.Drawing.SystemColors.Window
        Me.btnGo.FlatAppearance.BorderSize = 0
        Me.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(1050, 49)
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
        Me.lblURL.Location = New System.Drawing.Point(81, 52)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(32, 13)
        Me.lblURL.TabIndex = 29
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1214, 634)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 73)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1214, 634)
        Me.ToolStripContainer1.TabIndex = 5
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'btnGetWallet
        '
        Me.btnGetWallet.Location = New System.Drawing.Point(77, -1)
        Me.btnGetWallet.Name = "btnGetWallet"
        Me.btnGetWallet.Size = New System.Drawing.Size(78, 20)
        Me.btnGetWallet.TabIndex = 1
        Me.btnGetWallet.Text = "2. Get Wallet"
        Me.btnGetWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnGetWallet, "One Time Only! Get a CounterWallet")
        Me.btnGetWallet.UseVisualStyleBackColor = True
        '
        'btnMyWallet
        '
        Me.btnMyWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMyWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyWallet.Location = New System.Drawing.Point(170, 0)
        Me.btnMyWallet.Name = "btnMyWallet"
        Me.btnMyWallet.Size = New System.Drawing.Size(86, 41)
        Me.btnMyWallet.TabIndex = 10
        Me.btnMyWallet.Text = "FLDC Wallet"
        Me.btnMyWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnMyWallet, "View wallet at CounterWallet")
        Me.btnMyWallet.UseVisualStyleBackColor = True
        '
        'btnGetFAH
        '
        Me.btnGetFAH.Location = New System.Drawing.Point(5, -1)
        Me.btnGetFAH.Name = "btnGetFAH"
        Me.btnGetFAH.Size = New System.Drawing.Size(73, 20)
        Me.btnGetFAH.TabIndex = 0
        Me.btnGetFAH.Text = "1. Get F@H"
        Me.btnGetFAH.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnGetFAH, "One Time Only! Install and setup Folding@Home")
        Me.btnGetFAH.UseVisualStyleBackColor = True
        '
        'btnFAHControl
        '
        Me.btnFAHControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFAHControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFAHControl.Location = New System.Drawing.Point(1, 0)
        Me.btnFAHControl.Name = "btnFAHControl"
        Me.btnFAHControl.Size = New System.Drawing.Size(88, 41)
        Me.btnFAHControl.TabIndex = 8
        Me.btnFAHControl.Text = "F@H Control"
        Me.btnFAHControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFAHControl, "Folding@Home Web Control to View App Status")
        Me.btnFAHControl.UseVisualStyleBackColor = True
        '
        'btnBrowserTools
        '
        Me.btnBrowserTools.Location = New System.Drawing.Point(610, 40)
        Me.btnBrowserTools.Name = "btnBrowserTools"
        Me.btnBrowserTools.Size = New System.Drawing.Size(69, 20)
        Me.btnBrowserTools.TabIndex = 23
        Me.btnBrowserTools.Text = "Web Tools"
        Me.btnBrowserTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBrowserTools, "Web Developer Tools:  <F12>")
        Me.btnBrowserTools.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinWebsite
        '
        Me.btnFoldingCoinWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinWebsite.Location = New System.Drawing.Point(94, 0)
        Me.btnFoldingCoinWebsite.Name = "btnFoldingCoinWebsite"
        Me.btnFoldingCoinWebsite.Size = New System.Drawing.Size(82, 41)
        Me.btnFoldingCoinWebsite.TabIndex = 9
        Me.btnFoldingCoinWebsite.Text = "FoldingCoin"
        Me.btnFoldingCoinWebsite.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinWebsite, "FoldingCoin Website")
        Me.btnFoldingCoinWebsite.UseVisualStyleBackColor = True
        '
        'btnCureCoin
        '
        Me.btnCureCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCureCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoin.Location = New System.Drawing.Point(411, 0)
        Me.btnCureCoin.Name = "btnCureCoin"
        Me.btnCureCoin.Size = New System.Drawing.Size(66, 41)
        Me.btnCureCoin.TabIndex = 16
        Me.btnCureCoin.Text = "CureCoin"
        Me.btnCureCoin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoin, "CureCoin Website")
        Me.btnCureCoin.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReload.BackColor = System.Drawing.SystemColors.Control
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(1094, 49)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(17, 17)
        Me.btnReload.TabIndex = 3
        Me.btnReload.Text = "R"
        Me.ToolTip1.SetToolTip(Me.btnReload, "Reload Page:   <F5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or, reload ignoring cache:   CTRL+<F5>")
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(28, 45)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "B"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Go back one page:   ALT+<Left>")
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnFwd
        '
        Me.btnFwd.BackColor = System.Drawing.SystemColors.Control
        Me.btnFwd.FlatAppearance.BorderSize = 0
        Me.btnFwd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFwd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFwd.Location = New System.Drawing.Point(54, 45)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(25, 25)
        Me.btnFwd.TabIndex = 7
        Me.btnFwd.Text = "F"
        Me.ToolTip1.SetToolTip(Me.btnFwd, "Go forward one page:   ALT+<Right>")
        Me.btnFwd.UseVisualStyleBackColor = False
        '
        'gbxTools
        '
        Me.gbxTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxTools.Controls.Add(Me.btnCureCoinSetup)
        Me.gbxTools.Controls.Add(Me.btnOptions)
        Me.gbxTools.Controls.Add(Me.btnSavedData)
        Me.gbxTools.Controls.Add(Me.txtWalletName)
        Me.gbxTools.Controls.Add(Me.cbxWalletId)
        Me.gbxTools.Controls.Add(Me.btnFAHConfig)
        Me.gbxTools.Controls.Add(Me.btnGetFAH)
        Me.gbxTools.Controls.Add(Me.btnGetWallet)
        Me.gbxTools.Controls.Add(Me.lblWalletNum)
        Me.gbxTools.Location = New System.Drawing.Point(843, 1)
        Me.gbxTools.Name = "gbxTools"
        Me.gbxTools.Size = New System.Drawing.Size(369, 46)
        Me.gbxTools.TabIndex = 26
        Me.gbxTools.TabStop = False
        '
        'btnCureCoinSetup
        '
        Me.btnCureCoinSetup.Location = New System.Drawing.Point(238, -1)
        Me.btnCureCoinSetup.Name = "btnCureCoinSetup"
        Me.btnCureCoinSetup.Size = New System.Drawing.Size(89, 20)
        Me.btnCureCoinSetup.TabIndex = 3
        Me.btnCureCoinSetup.Text = "4. CURE Setup"
        Me.btnCureCoinSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinSetup, "(One-Time only) Setup CureCoin Folding Pool info")
        Me.btnCureCoinSetup.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(15, 22)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(57, 20)
        Me.btnOptions.TabIndex = 4
        Me.btnOptions.Text = "Options"
        Me.btnOptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnOptions, "Show Options")
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnSavedData
        '
        Me.btnSavedData.Location = New System.Drawing.Point(79, 22)
        Me.btnSavedData.Name = "btnSavedData"
        Me.btnSavedData.Size = New System.Drawing.Size(72, 20)
        Me.btnSavedData.TabIndex = 5
        Me.btnSavedData.Text = "Saved Data"
        Me.btnSavedData.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSavedData, "Show Saved Settings from .Dat File")
        Me.btnSavedData.UseVisualStyleBackColor = True
        '
        'txtWalletName
        '
        Me.txtWalletName.Location = New System.Drawing.Point(254, 22)
        Me.txtWalletName.Name = "txtWalletName"
        Me.txtWalletName.Size = New System.Drawing.Size(112, 20)
        Me.txtWalletName.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtWalletName, "Change wallet name, press <Enter> to save it")
        '
        'cbxWalletId
        '
        Me.cbxWalletId.FormattingEnabled = True
        Me.cbxWalletId.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxWalletId.Location = New System.Drawing.Point(223, 22)
        Me.cbxWalletId.Name = "cbxWalletId"
        Me.cbxWalletId.Size = New System.Drawing.Size(30, 21)
        Me.cbxWalletId.TabIndex = 7
        Me.cbxWalletId.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cbxWalletId, "Wallet Id (0-9) to use. Default: 0.")
        '
        'btnFAHConfig
        '
        Me.btnFAHConfig.Location = New System.Drawing.Point(154, -1)
        Me.btnFAHConfig.Name = "btnFAHConfig"
        Me.btnFAHConfig.Size = New System.Drawing.Size(85, 20)
        Me.btnFAHConfig.TabIndex = 2
        Me.btnFAHConfig.Text = "3. F@H Config"
        Me.btnFAHConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFAHConfig, "Setup Folding@Home: Username, Team, Passkey Config")
        Me.btnFAHConfig.UseVisualStyleBackColor = True
        '
        'lblWalletNum
        '
        Me.lblWalletNum.AutoSize = True
        Me.lblWalletNum.Location = New System.Drawing.Point(154, 25)
        Me.lblWalletNum.Name = "lblWalletNum"
        Me.lblWalletNum.Size = New System.Drawing.Size(72, 13)
        Me.lblWalletNum.TabIndex = 6
        Me.lblWalletNum.Text = "Use Wallet #:"
        '
        'btnCurePool
        '
        Me.btnCurePool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCurePool.Location = New System.Drawing.Point(526, 20)
        Me.btnCurePool.Name = "btnCurePool"
        Me.btnCurePool.Size = New System.Drawing.Size(75, 21)
        Me.btnCurePool.TabIndex = 18
        Me.btnCurePool.Text = "Pool Login"
        Me.btnCurePool.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCurePool, "Login to the CureCoin Folding Pool")
        Me.btnCurePool.UseVisualStyleBackColor = True
        '
        'chkShowTools
        '
        Me.chkShowTools.AutoSize = True
        Me.chkShowTools.Checked = True
        Me.chkShowTools.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowTools.Location = New System.Drawing.Point(7, 9)
        Me.chkShowTools.Name = "chkShowTools"
        Me.chkShowTools.Size = New System.Drawing.Size(52, 17)
        Me.chkShowTools.TabIndex = 0
        Me.chkShowTools.Text = "Tools"
        Me.chkShowTools.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinTwitter
        '
        Me.btnFoldingCoinTwitter.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnFoldingCoinTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinTwitter.Location = New System.Drawing.Point(250, 20)
        Me.btnFoldingCoinTwitter.Name = "btnFoldingCoinTwitter"
        Me.btnFoldingCoinTwitter.Size = New System.Drawing.Size(60, 21)
        Me.btnFoldingCoinTwitter.TabIndex = 13
        Me.btnFoldingCoinTwitter.Text = "Twitter"
        Me.btnFoldingCoinTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinTwitter, "FoldingCoin Twitter")
        Me.btnFoldingCoinTwitter.UseVisualStyleBackColor = False
        '
        'btnCureCoinTwitter
        '
        Me.btnCureCoinTwitter.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCureCoinTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinTwitter.Location = New System.Drawing.Point(471, 20)
        Me.btnCureCoinTwitter.Name = "btnCureCoinTwitter"
        Me.btnCureCoinTwitter.Size = New System.Drawing.Size(60, 21)
        Me.btnCureCoinTwitter.TabIndex = 19
        Me.btnCureCoinTwitter.Text = "Twitter"
        Me.btnCureCoinTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinTwitter, "CureCoin Twitter")
        Me.btnCureCoinTwitter.UseVisualStyleBackColor = False
        '
        'btnFoldingCoinBlockchain
        '
        Me.btnFoldingCoinBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinBlockchain.Location = New System.Drawing.Point(249, 0)
        Me.btnFoldingCoinBlockchain.Name = "btnFoldingCoinBlockchain"
        Me.btnFoldingCoinBlockchain.Size = New System.Drawing.Size(78, 21)
        Me.btnFoldingCoinBlockchain.TabIndex = 11
        Me.btnFoldingCoinBlockchain.Text = "Blockchain"
        Me.btnFoldingCoinBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinBlockchain, "FoldingCoin & CounterParty Tokens Blockchain Explorer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doesn't show BTC transact" &
        "ions)")
        Me.btnFoldingCoinBlockchain.UseVisualStyleBackColor = True
        '
        'btnEOC
        '
        Me.btnEOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEOC.Location = New System.Drawing.Point(606, 0)
        Me.btnEOC.Name = "btnEOC"
        Me.btnEOC.Size = New System.Drawing.Size(77, 41)
        Me.btnEOC.TabIndex = 22
        Me.btnEOC.Text = "F@H Stats"
        Me.btnEOC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEOC, "Extreme Overclocking Folding Stats")
        Me.btnEOC.UseVisualStyleBackColor = True
        '
        'btnCureCoinBlockchain
        '
        Me.btnCureCoinBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinBlockchain.Location = New System.Drawing.Point(472, 0)
        Me.btnCureCoinBlockchain.Name = "btnCureCoinBlockchain"
        Me.btnCureCoinBlockchain.Size = New System.Drawing.Size(78, 21)
        Me.btnCureCoinBlockchain.TabIndex = 17
        Me.btnCureCoinBlockchain.Text = "Blockchain"
        Me.btnCureCoinBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinBlockchain, "CureCoin Blockchain Explorer")
        Me.btnCureCoinBlockchain.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinDiscord
        '
        Me.btnFoldingCoinDiscord.BackColor = System.Drawing.Color.Black
        Me.btnFoldingCoinDiscord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinDiscord.ForeColor = System.Drawing.Color.White
        Me.btnFoldingCoinDiscord.Location = New System.Drawing.Point(354, 0)
        Me.btnFoldingCoinDiscord.Name = "btnFoldingCoinDiscord"
        Me.btnFoldingCoinDiscord.Size = New System.Drawing.Size(52, 21)
        Me.btnFoldingCoinDiscord.TabIndex = 14
        Me.btnFoldingCoinDiscord.Text = "Discord"
        Me.btnFoldingCoinDiscord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinDiscord, "Contact us on the FoldingCoin Discord" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Questions and Comments")
        Me.btnFoldingCoinDiscord.UseVisualStyleBackColor = False
        '
        'btnBTCBlockchain
        '
        Me.btnBTCBlockchain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBTCBlockchain.Location = New System.Drawing.Point(321, 0)
        Me.btnBTCBlockchain.Name = "btnBTCBlockchain"
        Me.btnBTCBlockchain.Size = New System.Drawing.Size(39, 21)
        Me.btnBTCBlockchain.TabIndex = 12
        Me.btnBTCBlockchain.Text = "BTC"
        Me.btnBTCBlockchain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBTCBlockchain, "BTC Only Blockchain Explorer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doesn't show Counterparty Tokens)")
        Me.btnBTCBlockchain.UseVisualStyleBackColor = True
        '
        'btnCureCoinDiscord
        '
        Me.btnCureCoinDiscord.BackColor = System.Drawing.Color.Black
        Me.btnCureCoinDiscord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoinDiscord.ForeColor = System.Drawing.Color.White
        Me.btnCureCoinDiscord.Location = New System.Drawing.Point(545, 0)
        Me.btnCureCoinDiscord.Name = "btnCureCoinDiscord"
        Me.btnCureCoinDiscord.Size = New System.Drawing.Size(56, 21)
        Me.btnCureCoinDiscord.TabIndex = 20
        Me.btnCureCoinDiscord.Text = "Discord"
        Me.btnCureCoinDiscord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinDiscord, "Contact us on the CureCoin Discord" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Questions and Comments")
        Me.btnCureCoinDiscord.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHome.BackColor = System.Drawing.SystemColors.Control
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(1115, 49)
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
        Me.btnFindPrevious.BackColor = System.Drawing.Color.White
        Me.btnFindPrevious.FlatAppearance.BorderSize = 0
        Me.btnFindPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFindPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFindPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindPrevious.Location = New System.Drawing.Point(262, 2)
        Me.btnFindPrevious.Name = "btnFindPrevious"
        Me.btnFindPrevious.Size = New System.Drawing.Size(17, 17)
        Me.btnFindPrevious.TabIndex = 2
        Me.btnFindPrevious.Text = "U"
        Me.ToolTip1.SetToolTip(Me.btnFindPrevious, "Find Previous:  SHIFT+<ENTER>   Or   SHIFT+<F3>")
        Me.btnFindPrevious.UseVisualStyleBackColor = False
        '
        'btnFindNext
        '
        Me.btnFindNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindNext.BackColor = System.Drawing.Color.White
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
        Me.btnFindClose.BackColor = System.Drawing.Color.White
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
        'txtMsg
        '
        Me.txtMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMsg.Location = New System.Drawing.Point(795, 0)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsg.Size = New System.Drawing.Size(42, 73)
        Me.txtMsg.TabIndex = 25
        '
        'gbxCheckboxForTools
        '
        Me.gbxCheckboxForTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCheckboxForTools.Controls.Add(Me.chkShowTools)
        Me.gbxCheckboxForTools.Location = New System.Drawing.Point(1149, 42)
        Me.gbxCheckboxForTools.Name = "gbxCheckboxForTools"
        Me.gbxCheckboxForTools.Size = New System.Drawing.Size(63, 28)
        Me.gbxCheckboxForTools.TabIndex = 27
        Me.gbxCheckboxForTools.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 14)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 21)
        Me.ProgressBar1.TabIndex = 0
        '
        'lblPercent
        '
        Me.lblPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.SystemColors.Window
        Me.lblPercent.Location = New System.Drawing.Point(43, 18)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(23, 13)
        Me.lblPercent.TabIndex = 1
        Me.lblPercent.Text = "0%"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxDownload
        '
        Me.gbxDownload.BackColor = System.Drawing.SystemColors.Info
        Me.gbxDownload.Controls.Add(Me.lblPercent)
        Me.gbxDownload.Controls.Add(Me.ProgressBar1)
        Me.gbxDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDownload.Location = New System.Drawing.Point(685, 4)
        Me.gbxDownload.Name = "gbxDownload"
        Me.gbxDownload.Size = New System.Drawing.Size(108, 42)
        Me.gbxDownload.TabIndex = 24
        Me.gbxDownload.TabStop = False
        Me.gbxDownload.Text = "Download:"
        Me.gbxDownload.Visible = False
        '
        'pbProgIcon
        '
        Me.pbProgIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgIcon.Location = New System.Drawing.Point(1154, 11)
        Me.pbProgIcon.Name = "pbProgIcon"
        Me.pbProgIcon.Size = New System.Drawing.Size(50, 30)
        Me.pbProgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbProgIcon.TabIndex = 140
        Me.pbProgIcon.TabStop = False
        '
        'btnFLDC_Distribution
        '
        Me.btnFLDC_Distribution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFLDC_Distribution.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFLDC_Distribution.Location = New System.Drawing.Point(307, 20)
        Me.btnFLDC_Distribution.Name = "btnFLDC_Distribution"
        Me.btnFLDC_Distribution.Size = New System.Drawing.Size(80, 21)
        Me.btnFLDC_Distribution.TabIndex = 15
        Me.btnFLDC_Distribution.Text = "Distribution"
        Me.btnFLDC_Distribution.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFLDC_Distribution.UseVisualStyleBackColor = True
        '
        'pnlFind
        '
        Me.pnlFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFind.BackColor = System.Drawing.Color.White
        Me.pnlFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFind.Controls.Add(Me.pnlDivider)
        Me.pnlFind.Controls.Add(Me.btnFindClose)
        Me.pnlFind.Controls.Add(Me.btnFindNext)
        Me.pnlFind.Controls.Add(Me.btnFindPrevious)
        Me.pnlFind.Controls.Add(Me.txtFind)
        Me.pnlFind.Location = New System.Drawing.Point(843, 71)
        Me.pnlFind.Name = "pnlFind"
        Me.pnlFind.Size = New System.Drawing.Size(333, 25)
        Me.pnlFind.TabIndex = 28
        Me.pnlFind.Visible = False
        '
        'pnlDivider
        '
        Me.pnlDivider.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDivider.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlDivider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlDivider.Location = New System.Drawing.Point(255, 3)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(2, 16)
        Me.pnlDivider.TabIndex = 1
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(4, 4)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(248, 14)
        Me.txtFind.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 708)
        Me.Controls.Add(Me.btnFoldingCoinWebsite)
        Me.Controls.Add(Me.btnMyWallet)
        Me.Controls.Add(Me.pnlFind)
        Me.Controls.Add(Me.gbxDownload)
        Me.Controls.Add(Me.btnBrowserTools)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.gbxTools)
        Me.Controls.Add(Me.btnFwd)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnEOC)
        Me.Controls.Add(Me.btnCureCoin)
        Me.Controls.Add(Me.btnFAHControl)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.btnStopNav)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.pbProgIcon)
        Me.Controls.Add(Me.btnFoldingCoinTwitter)
        Me.Controls.Add(Me.lblURL)
        Me.Controls.Add(Me.gbxCheckboxForTools)
        Me.Controls.Add(Me.btnCureCoinBlockchain)
        Me.Controls.Add(Me.btnFoldingCoinBlockchain)
        Me.Controls.Add(Me.btnBTCBlockchain)
        Me.Controls.Add(Me.btnFoldingCoinDiscord)
        Me.Controls.Add(Me.btnCureCoinDiscord)
        Me.Controls.Add(Me.btnFLDC_Distribution)
        Me.Controls.Add(Me.btnCureCoinTwitter)
        Me.Controls.Add(Me.btnCurePool)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(16, 38)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.gbxTools.ResumeLayout(False)
        Me.gbxTools.PerformLayout()
        Me.gbxCheckboxForTools.ResumeLayout(False)
        Me.gbxCheckboxForTools.PerformLayout()
        Me.gbxDownload.ResumeLayout(False)
        Me.gbxDownload.PerformLayout()
        CType(Me.pbProgIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFind.ResumeLayout(False)
        Me.pnlFind.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStopNav As System.Windows.Forms.Button
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents btnGetWallet As System.Windows.Forms.Button
    Friend WithEvents btnMyWallet As System.Windows.Forms.Button
    Friend WithEvents btnGetFAH As System.Windows.Forms.Button
    Friend WithEvents btnFAHControl As System.Windows.Forms.Button
    Friend WithEvents btnBrowserTools As System.Windows.Forms.Button
    Friend WithEvents btnFoldingCoinWebsite As System.Windows.Forms.Button
    Friend WithEvents btnCureCoin As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnFwd As System.Windows.Forms.Button
    Friend WithEvents gbxTools As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowTools As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents gbxCheckboxForTools As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents gbxDownload As System.Windows.Forms.GroupBox
    Friend WithEvents btnFoldingCoinTwitter As Button
    Friend WithEvents btnCureCoinTwitter As Button
    Friend WithEvents pbProgIcon As PictureBox
    Friend WithEvents btnFAHConfig As Button
    Friend WithEvents btnEOC As Button
    Friend WithEvents cbxWalletId As ComboBox
    Friend WithEvents lblWalletNum As Label
    Friend WithEvents txtWalletName As TextBox
    Friend WithEvents btnSavedData As Button
    Friend WithEvents btnFoldingCoinBlockchain As Button
    Friend WithEvents btnCureCoinBlockchain As Button
    Friend WithEvents btnCureCoinSetup As Button
    Friend WithEvents btnCurePool As Button
    Friend WithEvents btnFoldingCoinDiscord As Button
    Friend WithEvents btnBTCBlockchain As Button
    Friend WithEvents btnCureCoinDiscord As Button
    Friend WithEvents btnFLDC_Distribution As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnOptions As Button
    Private WithEvents pnlFind As Panel
    Private WithEvents txtFind As TextBox
    Friend WithEvents btnFindClose As Button
    Friend WithEvents btnFindNext As Button
    Friend WithEvents btnFindPrevious As Button
    Friend WithEvents pnlDivider As Panel
End Class

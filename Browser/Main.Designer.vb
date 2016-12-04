<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.btnFLDC_DailyDistro = New System.Windows.Forms.Button()
        Me.btnCureCoin = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.gbxTools = New System.Windows.Forms.GroupBox()
        Me.btnCurePool = New System.Windows.Forms.Button()
        Me.btnCureCoinSetup = New System.Windows.Forms.Button()
        Me.btnShowDat = New System.Windows.Forms.Button()
        Me.txtWalletName = New System.Windows.Forms.TextBox()
        Me.cbxWalletId = New System.Windows.Forms.ComboBox()
        Me.btnFAHConfig = New System.Windows.Forms.Button()
        Me.lblWalletNum = New System.Windows.Forms.Label()
        Me.chkShowTools = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTwitterFoldingCoin = New System.Windows.Forms.Button()
        Me.btnTwitterCureCoin = New System.Windows.Forms.Button()
        Me.btnBlockchainFLDC = New System.Windows.Forms.Button()
        Me.btnEOC = New System.Windows.Forms.Button()
        Me.btnBlockchainCURE = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.gbxCheckboxForTools = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.gbxDownload = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolStripContainer1.SuspendLayout()
        Me.gbxTools.SuspendLayout()
        Me.gbxCheckboxForTools.SuspendLayout()
        Me.gbxDownload.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnStopNav.Location = New System.Drawing.Point(936, 49)
        Me.btnStopNav.Name = "btnStopNav"
        Me.btnStopNav.Size = New System.Drawing.Size(17, 17)
        Me.btnStopNav.TabIndex = 2
        Me.btnStopNav.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnStopNav, "Cancel navigation / download, or press <Esc>")
        Me.btnStopNav.UseVisualStyleBackColor = False
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Location = New System.Drawing.Point(111, 48)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(820, 20)
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
        Me.btnGo.Location = New System.Drawing.Point(913, 49)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(17, 17)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.ToolTip1.SetToolTip(Me.btnGo, "Go to URL")
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(81, 52)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(32, 13)
        Me.lblURL.TabIndex = 80
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1052, 634)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 73)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1052, 634)
        Me.ToolStripContainer1.TabIndex = 4
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
        Me.btnMyWallet.Location = New System.Drawing.Point(0, 0)
        Me.btnMyWallet.Name = "btnMyWallet"
        Me.btnMyWallet.Size = New System.Drawing.Size(72, 37)
        Me.btnMyWallet.TabIndex = 9
        Me.btnMyWallet.Text = "My Wallet"
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
        Me.btnFAHControl.Location = New System.Drawing.Point(71, 0)
        Me.btnFAHControl.Name = "btnFAHControl"
        Me.btnFAHControl.Size = New System.Drawing.Size(87, 37)
        Me.btnFAHControl.TabIndex = 10
        Me.btnFAHControl.Text = "F@H Control"
        Me.btnFAHControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFAHControl, "View Folding@Home App Status")
        Me.btnFAHControl.UseVisualStyleBackColor = True
        '
        'btnBrowserTools
        '
        Me.btnBrowserTools.Location = New System.Drawing.Point(530, 36)
        Me.btnBrowserTools.Name = "btnBrowserTools"
        Me.btnBrowserTools.Size = New System.Drawing.Size(69, 20)
        Me.btnBrowserTools.TabIndex = 4
        Me.btnBrowserTools.Text = "Web Tools"
        Me.btnBrowserTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBrowserTools, "Web Browser Debug Tools")
        Me.btnBrowserTools.UseVisualStyleBackColor = True
        '
        'btnFoldingCoinWebsite
        '
        Me.btnFoldingCoinWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFoldingCoinWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoldingCoinWebsite.Location = New System.Drawing.Point(157, 0)
        Me.btnFoldingCoinWebsite.Name = "btnFoldingCoinWebsite"
        Me.btnFoldingCoinWebsite.Size = New System.Drawing.Size(82, 37)
        Me.btnFoldingCoinWebsite.TabIndex = 11
        Me.btnFoldingCoinWebsite.Text = "FoldingCoin"
        Me.btnFoldingCoinWebsite.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFoldingCoinWebsite, "FoldingCoin Website")
        Me.btnFoldingCoinWebsite.UseVisualStyleBackColor = True
        '
        'btnFLDC_DailyDistro
        '
        Me.btnFLDC_DailyDistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFLDC_DailyDistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFLDC_DailyDistro.Location = New System.Drawing.Point(309, 0)
        Me.btnFLDC_DailyDistro.Name = "btnFLDC_DailyDistro"
        Me.btnFLDC_DailyDistro.Size = New System.Drawing.Size(79, 37)
        Me.btnFLDC_DailyDistro.TabIndex = 14
        Me.btnFLDC_DailyDistro.Text = "Daily Dist."
        Me.btnFLDC_DailyDistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnFLDC_DailyDistro, "FoldingCoin Daily Distributions")
        Me.btnFLDC_DailyDistro.UseVisualStyleBackColor = True
        '
        'btnCureCoin
        '
        Me.btnCureCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCureCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCureCoin.Location = New System.Drawing.Point(387, 0)
        Me.btnCureCoin.Name = "btnCureCoin"
        Me.btnCureCoin.Size = New System.Drawing.Size(66, 37)
        Me.btnCureCoin.TabIndex = 15
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
        Me.btnReload.Location = New System.Drawing.Point(957, 49)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(17, 17)
        Me.btnReload.TabIndex = 3
        Me.btnReload.Text = "R"
        Me.ToolTip1.SetToolTip(Me.btnReload, "Reload page")
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
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "B"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Go back one page")
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
        Me.btnFwd.TabIndex = 6
        Me.btnFwd.Text = "F"
        Me.ToolTip1.SetToolTip(Me.btnFwd, "Go forward one page")
        Me.btnFwd.UseVisualStyleBackColor = False
        '
        'gbxTools
        '
        Me.gbxTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxTools.Controls.Add(Me.btnCurePool)
        Me.gbxTools.Controls.Add(Me.btnCureCoinSetup)
        Me.gbxTools.Controls.Add(Me.btnShowDat)
        Me.gbxTools.Controls.Add(Me.txtWalletName)
        Me.gbxTools.Controls.Add(Me.cbxWalletId)
        Me.gbxTools.Controls.Add(Me.btnFAHConfig)
        Me.gbxTools.Controls.Add(Me.btnGetFAH)
        Me.gbxTools.Controls.Add(Me.btnGetWallet)
        Me.gbxTools.Controls.Add(Me.lblWalletNum)
        Me.gbxTools.Location = New System.Drawing.Point(654, 1)
        Me.gbxTools.Name = "gbxTools"
        Me.gbxTools.Size = New System.Drawing.Size(396, 46)
        Me.gbxTools.TabIndex = 133
        Me.gbxTools.TabStop = False
        '
        'btnCurePool
        '
        Me.btnCurePool.Location = New System.Drawing.Point(326, -1)
        Me.btnCurePool.Name = "btnCurePool"
        Me.btnCurePool.Size = New System.Drawing.Size(68, 20)
        Me.btnCurePool.TabIndex = 132
        Me.btnCurePool.Text = "Pool Login"
        Me.btnCurePool.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCurePool, "Login to the CureCoin Folding Pool")
        Me.btnCurePool.UseVisualStyleBackColor = True
        '
        'btnCureCoinSetup
        '
        Me.btnCureCoinSetup.Location = New System.Drawing.Point(238, -1)
        Me.btnCureCoinSetup.Name = "btnCureCoinSetup"
        Me.btnCureCoinSetup.Size = New System.Drawing.Size(89, 20)
        Me.btnCureCoinSetup.TabIndex = 131
        Me.btnCureCoinSetup.Text = "4. CURE Setup"
        Me.btnCureCoinSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCureCoinSetup, "(One-Time only) Setup CureCoin Folding Pool info")
        Me.btnCureCoinSetup.UseVisualStyleBackColor = True
        '
        'btnShowDat
        '
        Me.btnShowDat.Location = New System.Drawing.Point(47, 22)
        Me.btnShowDat.Name = "btnShowDat"
        Me.btnShowDat.Size = New System.Drawing.Size(67, 20)
        Me.btnShowDat.TabIndex = 3
        Me.btnShowDat.Text = "Saved Info"
        Me.btnShowDat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnShowDat, "Show Saved Settings from .Dat File")
        Me.btnShowDat.UseVisualStyleBackColor = True
        '
        'txtWalletName
        '
        Me.txtWalletName.Location = New System.Drawing.Point(238, 22)
        Me.txtWalletName.Name = "txtWalletName"
        Me.txtWalletName.Size = New System.Drawing.Size(128, 20)
        Me.txtWalletName.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtWalletName, "Change wallet name, press <Enter> to save it")
        '
        'cbxWalletId
        '
        Me.cbxWalletId.FormattingEnabled = True
        Me.cbxWalletId.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxWalletId.Location = New System.Drawing.Point(207, 22)
        Me.cbxWalletId.Name = "cbxWalletId"
        Me.cbxWalletId.Size = New System.Drawing.Size(30, 21)
        Me.cbxWalletId.TabIndex = 5
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
        Me.lblWalletNum.Location = New System.Drawing.Point(138, 25)
        Me.lblWalletNum.Name = "lblWalletNum"
        Me.lblWalletNum.Size = New System.Drawing.Size(72, 13)
        Me.lblWalletNum.TabIndex = 130
        Me.lblWalletNum.Text = "Use Wallet #:"
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
        'btnTwitterFoldingCoin
        '
        Me.btnTwitterFoldingCoin.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTwitterFoldingCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwitterFoldingCoin.Location = New System.Drawing.Point(232, 18)
        Me.btnTwitterFoldingCoin.Name = "btnTwitterFoldingCoin"
        Me.btnTwitterFoldingCoin.Size = New System.Drawing.Size(78, 19)
        Me.btnTwitterFoldingCoin.TabIndex = 13
        Me.btnTwitterFoldingCoin.Text = "Twitter"
        Me.btnTwitterFoldingCoin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnTwitterFoldingCoin, "FoldingCoin Twitter")
        Me.btnTwitterFoldingCoin.UseVisualStyleBackColor = False
        '
        'btnTwitterCureCoin
        '
        Me.btnTwitterCureCoin.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTwitterCureCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwitterCureCoin.Location = New System.Drawing.Point(446, 18)
        Me.btnTwitterCureCoin.Name = "btnTwitterCureCoin"
        Me.btnTwitterCureCoin.Size = New System.Drawing.Size(78, 19)
        Me.btnTwitterCureCoin.TabIndex = 17
        Me.btnTwitterCureCoin.Text = "Twitter"
        Me.btnTwitterCureCoin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnTwitterCureCoin, "CureCoin Twitter")
        Me.btnTwitterCureCoin.UseVisualStyleBackColor = False
        '
        'btnBlockchainFLDC
        '
        Me.btnBlockchainFLDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlockchainFLDC.Location = New System.Drawing.Point(232, 0)
        Me.btnBlockchainFLDC.Name = "btnBlockchainFLDC"
        Me.btnBlockchainFLDC.Size = New System.Drawing.Size(78, 19)
        Me.btnBlockchainFLDC.TabIndex = 12
        Me.btnBlockchainFLDC.Text = "Blockchain"
        Me.btnBlockchainFLDC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBlockchainFLDC, "FoldingCoin Blockchain Explorer")
        Me.btnBlockchainFLDC.UseVisualStyleBackColor = True
        '
        'btnEOC
        '
        Me.btnEOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEOC.Location = New System.Drawing.Point(523, 0)
        Me.btnEOC.Name = "btnEOC"
        Me.btnEOC.Size = New System.Drawing.Size(83, 37)
        Me.btnEOC.TabIndex = 18
        Me.btnEOC.Text = "F@H Points"
        Me.btnEOC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEOC, "Extreme Overclocking Folding Stats")
        Me.btnEOC.UseVisualStyleBackColor = True
        '
        'btnBlockchainCURE
        '
        Me.btnBlockchainCURE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlockchainCURE.Location = New System.Drawing.Point(446, 0)
        Me.btnBlockchainCURE.Name = "btnBlockchainCURE"
        Me.btnBlockchainCURE.Size = New System.Drawing.Size(78, 19)
        Me.btnBlockchainCURE.TabIndex = 16
        Me.btnBlockchainCURE.Text = "Blockchain"
        Me.btnBlockchainCURE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBlockchainCURE, "CureCoin Blockchain Explorer")
        Me.btnBlockchainCURE.UseVisualStyleBackColor = True
        '
        'txtMsg
        '
        Me.txtMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMsg.Location = New System.Drawing.Point(606, 0)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsg.Size = New System.Drawing.Size(47, 74)
        Me.txtMsg.TabIndex = 135
        '
        'gbxCheckboxForTools
        '
        Me.gbxCheckboxForTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCheckboxForTools.Controls.Add(Me.chkShowTools)
        Me.gbxCheckboxForTools.Location = New System.Drawing.Point(987, 42)
        Me.gbxCheckboxForTools.Name = "gbxCheckboxForTools"
        Me.gbxCheckboxForTools.Size = New System.Drawing.Size(63, 28)
        Me.gbxCheckboxForTools.TabIndex = 136
        Me.gbxCheckboxForTools.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 14)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(152, 21)
        Me.ProgressBar1.TabIndex = 137
        '
        'lblPercent
        '
        Me.lblPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.SystemColors.Window
        Me.lblPercent.Location = New System.Drawing.Point(69, 18)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(23, 13)
        Me.lblPercent.TabIndex = 138
        Me.lblPercent.Text = "0%"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxDownload
        '
        Me.gbxDownload.BackColor = System.Drawing.SystemColors.Info
        Me.gbxDownload.Controls.Add(Me.lblPercent)
        Me.gbxDownload.Controls.Add(Me.ProgressBar1)
        Me.gbxDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDownload.Location = New System.Drawing.Point(609, 5)
        Me.gbxDownload.Name = "gbxDownload"
        Me.gbxDownload.Size = New System.Drawing.Size(160, 42)
        Me.gbxDownload.TabIndex = 139
        Me.gbxDownload.TabStop = False
        Me.gbxDownload.Text = "Download:"
        Me.gbxDownload.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Location = New System.Drawing.Point(992, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 140
        Me.PictureBox2.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 708)
        Me.Controls.Add(Me.btnBrowserTools)
        Me.Controls.Add(Me.gbxDownload)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.gbxTools)
        Me.Controls.Add(Me.btnFwd)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnEOC)
        Me.Controls.Add(Me.btnCureCoin)
        Me.Controls.Add(Me.btnFLDC_DailyDistro)
        Me.Controls.Add(Me.btnFoldingCoinWebsite)
        Me.Controls.Add(Me.btnFAHControl)
        Me.Controls.Add(Me.btnMyWallet)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.btnStopNav)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.btnTwitterCureCoin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnTwitterFoldingCoin)
        Me.Controls.Add(Me.lblURL)
        Me.Controls.Add(Me.gbxCheckboxForTools)
        Me.Controls.Add(Me.btnBlockchainCURE)
        Me.Controls.Add(Me.btnBlockchainFLDC)
        Me.MinimumSize = New System.Drawing.Size(16, 38)
        Me.Name = "Main"
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.gbxTools.ResumeLayout(False)
        Me.gbxTools.PerformLayout()
        Me.gbxCheckboxForTools.ResumeLayout(False)
        Me.gbxCheckboxForTools.PerformLayout()
        Me.gbxDownload.ResumeLayout(False)
        Me.gbxDownload.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnFLDC_DailyDistro As System.Windows.Forms.Button
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
    Friend WithEvents btnTwitterFoldingCoin As Button
    Friend WithEvents btnTwitterCureCoin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnFAHConfig As Button
    Friend WithEvents btnEOC As Button
    Friend WithEvents cbxWalletId As ComboBox
    Friend WithEvents lblWalletNum As Label
    Friend WithEvents txtWalletName As TextBox
    Friend WithEvents btnShowDat As Button
    Friend WithEvents btnBlockchainFLDC As Button
    Friend WithEvents btnBlockchainCURE As Button
    Friend WithEvents btnCureCoinSetup As Button
    Friend WithEvents btnCurePool As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayOptionsDialog
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
        Me.txtDisplayText = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.MsgTextTop = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkShowRawData = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chkShowPanelOnMouseEnterEvent = New System.Windows.Forms.CheckBox()
        Me.lblHomepage = New System.Windows.Forms.Label()
        Me.cbxHomepage = New System.Windows.Forms.ComboBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDisplayText
        '
        Me.txtDisplayText.BackColor = System.Drawing.Color.White
        Me.txtDisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDisplayText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDisplayText.Location = New System.Drawing.Point(0, 0)
        Me.txtDisplayText.Multiline = True
        Me.txtDisplayText.Name = "txtDisplayText"
        Me.txtDisplayText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplayText.Size = New System.Drawing.Size(81, 178)
        Me.txtDisplayText.TabIndex = 0
        Me.txtDisplayText.WordWrap = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(597, 229)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 28)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Close"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'MsgTextTop
        '
        Me.MsgTextTop.AutoSize = True
        Me.MsgTextTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgTextTop.Location = New System.Drawing.Point(21, 9)
        Me.MsgTextTop.Name = "MsgTextTop"
        Me.MsgTextTop.Size = New System.Drawing.Size(72, 18)
        Me.MsgTextTop.TabIndex = 4
        Me.MsgTextTop.Text = "Options:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(288, 229)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(124, 28)
        Me.btnSaveChanges.TabIndex = 2
        Me.btnSaveChanges.Text = "Save Changes"
        Me.ToolTip1.SetToolTip(Me.btnSaveChanges, "If modified, this button allows saving any of those changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the encrypted Dat" &
        " file. Be careful when doing this.")
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'chkShowRawData
        '
        Me.chkShowRawData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkShowRawData.AutoSize = True
        Me.chkShowRawData.Location = New System.Drawing.Point(13, 235)
        Me.chkShowRawData.Name = "chkShowRawData"
        Me.chkShowRawData.Size = New System.Drawing.Size(104, 17)
        Me.chkShowRawData.TabIndex = 1
        Me.chkShowRawData.Text = "Show Raw Data"
        Me.chkShowRawData.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(24, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkShowPanelOnMouseEnterEvent)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHomepage)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbxHomepage)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDisplayText)
        Me.SplitContainer1.Size = New System.Drawing.Size(663, 180)
        Me.SplitContainer1.SplitterDistance = 578
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 3
        '
        'chkShowPanelOnMouseEnterEvent
        '
        Me.chkShowPanelOnMouseEnterEvent.AutoSize = True
        Me.chkShowPanelOnMouseEnterEvent.Checked = True
        Me.chkShowPanelOnMouseEnterEvent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowPanelOnMouseEnterEvent.Location = New System.Drawing.Point(234, 64)
        Me.chkShowPanelOnMouseEnterEvent.Name = "chkShowPanelOnMouseEnterEvent"
        Me.chkShowPanelOnMouseEnterEvent.Size = New System.Drawing.Size(254, 17)
        Me.chkShowPanelOnMouseEnterEvent.TabIndex = 2
        Me.chkShowPanelOnMouseEnterEvent.Text = "Show Web Button Panel On Mouse-Enter Event"
        Me.chkShowPanelOnMouseEnterEvent.UseVisualStyleBackColor = True
        '
        'lblHomepage
        '
        Me.lblHomepage.AutoSize = True
        Me.lblHomepage.Location = New System.Drawing.Point(169, 28)
        Me.lblHomepage.Name = "lblHomepage"
        Me.lblHomepage.Size = New System.Drawing.Size(62, 13)
        Me.lblHomepage.TabIndex = 0
        Me.lblHomepage.Text = "Homepage:"
        '
        'cbxHomepage
        '
        Me.cbxHomepage.FormattingEnabled = True
        Me.cbxHomepage.Location = New System.Drawing.Point(234, 25)
        Me.cbxHomepage.Name = "cbxHomepage"
        Me.cbxHomepage.Size = New System.Drawing.Size(228, 21)
        Me.cbxHomepage.TabIndex = 1
        Me.cbxHomepage.Text = "Default"
        '
        'DisplayOptionsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(709, 269)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.chkShowRawData)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.MsgTextTop)
        Me.KeyPreview = True
        Me.Name = "DisplayOptionsDialog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisplayText As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents MsgTextTop As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkShowRawData As CheckBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cbxHomepage As ComboBox
    Friend WithEvents lblHomepage As Label
    Friend WithEvents chkShowPanelOnMouseEnterEvent As CheckBox
End Class

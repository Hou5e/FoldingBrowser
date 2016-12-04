<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayTextDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayTextDialog))
        Me.txtDisplayText = New System.Windows.Forms.TextBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.MsgTextTop = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.lblWarningInfo = New System.Windows.Forms.Label()
        Me.txtWarningMessage = New System.Windows.Forms.TextBox()
        Me.btnMakeBackup = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtDisplayText
        '
        Me.txtDisplayText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDisplayText.Location = New System.Drawing.Point(24, 30)
        Me.txtDisplayText.Multiline = True
        Me.txtDisplayText.Name = "txtDisplayText"
        Me.txtDisplayText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplayText.Size = New System.Drawing.Size(734, 291)
        Me.txtDisplayText.TabIndex = 1
        Me.txtDisplayText.WordWrap = False
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(668, 425)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(90, 28)
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'MsgTextTop
        '
        Me.MsgTextTop.AutoSize = True
        Me.MsgTextTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgTextTop.Location = New System.Drawing.Point(21, 9)
        Me.MsgTextTop.Name = "MsgTextTop"
        Me.MsgTextTop.Size = New System.Drawing.Size(45, 18)
        Me.MsgTextTop.TabIndex = 6
        Me.MsgTextTop.Text = "Msg:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveChanges.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(24, 425)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(124, 28)
        Me.btnSaveChanges.TabIndex = 2
        Me.btnSaveChanges.Text = "Save Changes"
        Me.ToolTip1.SetToolTip(Me.btnSaveChanges, "If modified, this button allows saving any of those changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the encrypted Dat" &
        " file. Be careful when doing this.")
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'lblWarningInfo
        '
        Me.lblWarningInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarningInfo.BackColor = System.Drawing.Color.Firebrick
        Me.lblWarningInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWarningInfo.Location = New System.Drawing.Point(13, 324)
        Me.lblWarningInfo.Name = "lblWarningInfo"
        Me.lblWarningInfo.Size = New System.Drawing.Size(756, 96)
        Me.lblWarningInfo.TabIndex = 5
        '
        'txtWarningMessage
        '
        Me.txtWarningMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWarningMessage.BackColor = System.Drawing.Color.Tomato
        Me.txtWarningMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarningMessage.Location = New System.Drawing.Point(24, 331)
        Me.txtWarningMessage.Multiline = True
        Me.txtWarningMessage.Name = "txtWarningMessage"
        Me.txtWarningMessage.ReadOnly = True
        Me.txtWarningMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWarningMessage.Size = New System.Drawing.Size(734, 82)
        Me.txtWarningMessage.TabIndex = 4
        Me.txtWarningMessage.Text = resources.GetString("txtWarningMessage.Text")
        Me.txtWarningMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMakeBackup
        '
        Me.btnMakeBackup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMakeBackup.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnMakeBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeBackup.Location = New System.Drawing.Point(329, 425)
        Me.btnMakeBackup.Name = "btnMakeBackup"
        Me.btnMakeBackup.Size = New System.Drawing.Size(124, 28)
        Me.btnMakeBackup.TabIndex = 3
        Me.btnMakeBackup.Text = "Make Backup"
        Me.ToolTip1.SetToolTip(Me.btnMakeBackup, "Saves a unique folder to a location you selected." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save a copy of: FoldingBrowser" &
        " INI and DAT, CureCoin wallet.dat")
        Me.btnMakeBackup.UseVisualStyleBackColor = True
        '
        'DisplayTextDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 465)
        Me.Controls.Add(Me.btnMakeBackup)
        Me.Controls.Add(Me.txtWarningMessage)
        Me.Controls.Add(Me.lblWarningInfo)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.MsgTextTop)
        Me.Controls.Add(Me.txtDisplayText)
        Me.Name = "DisplayTextDialog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisplayText As System.Windows.Forms.TextBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents MsgTextTop As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents lblWarningInfo As Label
    Friend WithEvents txtWarningMessage As TextBox
    Friend WithEvents btnMakeBackup As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class

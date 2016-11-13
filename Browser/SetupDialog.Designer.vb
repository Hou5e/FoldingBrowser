<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupDialog
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

    'NOTE: The following procedure is required by the Windows Form InstallDialog
    'It can be modified using the Windows Form InstallDialog.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.chkGetWallet = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.chkGetFAHSoftware = New System.Windows.Forms.CheckBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(326, 130)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 28)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(230, 130)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(90, 28)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'chkGetWallet
        '
        Me.chkGetWallet.AutoSize = True
        Me.chkGetWallet.Checked = True
        Me.chkGetWallet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGetWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGetWallet.Location = New System.Drawing.Point(44, 85)
        Me.chkGetWallet.Name = "chkGetWallet"
        Me.chkGetWallet.Size = New System.Drawing.Size(229, 22)
        Me.chkGetWallet.TabIndex = 1
        Me.chkGetWallet.Text = "Get Wallet Bitcoin Address"
        Me.chkGetWallet.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(25, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(215, 24)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Get Setup for Folding:"
        '
        'chkGetFAHSoftware
        '
        Me.chkGetFAHSoftware.AutoSize = True
        Me.chkGetFAHSoftware.Checked = True
        Me.chkGetFAHSoftware.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGetFAHSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGetFAHSoftware.Location = New System.Drawing.Point(44, 55)
        Me.chkGetFAHSoftware.Name = "chkGetFAHSoftware"
        Me.chkGetFAHSoftware.Size = New System.Drawing.Size(372, 22)
        Me.chkGetFAHSoftware.TabIndex = 0
        Me.chkGetFAHSoftware.Text = "Get Folding@Home Software (Desktop client)"
        Me.chkGetFAHSoftware.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(12, 132)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(128, 26)
        Me.lblNote.TabIndex = 5
        Me.lblNote.Text = "Note: This setup can be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "done from the 'Tools' later"
        '
        'SetupDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 170)
        Me.Controls.Add(Me.chkGetFAHSoftware)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.chkGetWallet)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "SetupDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Get Setup for Folding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents chkGetWallet As CheckBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents chkGetFAHSoftware As CheckBox
    Friend WithEvents lblNote As Label
End Class

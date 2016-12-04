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
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.chkGetWalletForFLDC = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.chkGetFAHSoftware = New System.Windows.Forms.CheckBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkSetupCURE = New System.Windows.Forms.CheckBox()
        Me.lblRecommended = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(430, 203)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(334, 203)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(90, 28)
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'chkGetWalletForFLDC
        '
        Me.chkGetWalletForFLDC.AutoSize = True
        Me.chkGetWalletForFLDC.Checked = True
        Me.chkGetWalletForFLDC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGetWalletForFLDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGetWalletForFLDC.Location = New System.Drawing.Point(81, 104)
        Me.chkGetWalletForFLDC.Name = "chkGetWalletForFLDC"
        Me.chkGetWalletForFLDC.Size = New System.Drawing.Size(355, 22)
        Me.chkGetWalletForFLDC.TabIndex = 3
        Me.chkGetWalletForFLDC.Text = "Get Wallet Bitcoin Address For FoldingCoin"
        Me.ToolTip1.SetToolTip(Me.chkGetWalletForFLDC, "Needed to build a FoldingCoin Username and to receive FLDC")
        Me.chkGetWalletForFLDC.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(15, 21)
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
        Me.chkGetFAHSoftware.Location = New System.Drawing.Point(81, 70)
        Me.chkGetFAHSoftware.Name = "chkGetFAHSoftware"
        Me.chkGetFAHSoftware.Size = New System.Drawing.Size(372, 22)
        Me.chkGetFAHSoftware.TabIndex = 2
        Me.chkGetFAHSoftware.Text = "Get Folding@Home Software (Desktop client)"
        Me.ToolTip1.SetToolTip(Me.chkGetFAHSoftware, "Get the Folding@Home Software")
        Me.chkGetFAHSoftware.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(16, 218)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(269, 13)
        Me.lblNote.TabIndex = 7
        Me.lblNote.Text = "Note: This setup can manually be done from the 'Tools'."
        '
        'chkSetupCURE
        '
        Me.chkSetupCURE.AutoSize = True
        Me.chkSetupCURE.Checked = True
        Me.chkSetupCURE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSetupCURE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetupCURE.Location = New System.Drawing.Point(81, 138)
        Me.chkSetupCURE.Name = "chkSetupCURE"
        Me.chkSetupCURE.Size = New System.Drawing.Size(279, 22)
        Me.chkSetupCURE.TabIndex = 4
        Me.chkSetupCURE.Text = "Setup CureCoin Folding Pool Info"
        Me.ToolTip1.SetToolTip(Me.chkSetupCURE, "Setup new user account on CryptoBullionPools.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the CureCoin Folding Pool")
        Me.chkSetupCURE.UseVisualStyleBackColor = True
        '
        'lblRecommended
        '
        Me.lblRecommended.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRecommended.AutoSize = True
        Me.lblRecommended.Location = New System.Drawing.Point(16, 199)
        Me.lblRecommended.Name = "lblRecommended"
        Me.lblRecommended.Size = New System.Drawing.Size(253, 13)
        Me.lblRecommended.TabIndex = 6
        Me.lblRecommended.Text = "It's recommended that new users setup all 3 options."
        '
        'SetupDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 243)
        Me.Controls.Add(Me.chkSetupCURE)
        Me.Controls.Add(Me.chkGetFAHSoftware)
        Me.Controls.Add(Me.lblRecommended)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.chkGetWalletForFLDC)
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
    Friend WithEvents chkGetWalletForFLDC As CheckBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents chkGetFAHSoftware As CheckBox
    Friend WithEvents lblNote As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkSetupCURE As CheckBox
    Friend WithEvents lblRecommended As Label
End Class

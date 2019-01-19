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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.chkGetWalletForFLDC = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.chkGetFAHSoftware = New System.Windows.Forms.CheckBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkSetupCURE = New System.Windows.Forms.CheckBox()
        Me.lblRecommended = New System.Windows.Forms.Label()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(447, 141)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 35)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(349, 141)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 35)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'chkGetWalletForFLDC
        '
        Me.chkGetWalletForFLDC.AutoSize = True
        Me.chkGetWalletForFLDC.Checked = True
        Me.chkGetWalletForFLDC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGetWalletForFLDC.Location = New System.Drawing.Point(121, 78)
        Me.chkGetWalletForFLDC.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGetWalletForFLDC.Name = "chkGetWalletForFLDC"
        Me.chkGetWalletForFLDC.Size = New System.Drawing.Size(284, 20)
        Me.chkGetWalletForFLDC.TabIndex = 3
        Me.chkGetWalletForFLDC.Text = "Get Wallet Bitcoin Address For FoldingCoin"
        Me.ToolTip1.SetToolTip(Me.chkGetWalletForFLDC, "Needed to build a FoldingCoin Username and to receive FLDC")
        Me.chkGetWalletForFLDC.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(89, 16)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(136, 16)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Get Setup for Folding:"
        '
        'chkGetFAHSoftware
        '
        Me.chkGetFAHSoftware.AutoSize = True
        Me.chkGetFAHSoftware.Checked = True
        Me.chkGetFAHSoftware.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGetFAHSoftware.Location = New System.Drawing.Point(121, 50)
        Me.chkGetFAHSoftware.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGetFAHSoftware.Name = "chkGetFAHSoftware"
        Me.chkGetFAHSoftware.Size = New System.Drawing.Size(298, 20)
        Me.chkGetFAHSoftware.TabIndex = 2
        Me.chkGetFAHSoftware.Text = "Get Folding@Home Software (Desktop client)"
        Me.ToolTip1.SetToolTip(Me.chkGetFAHSoftware, "Get the Folding@Home Software")
        Me.chkGetFAHSoftware.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(4, 160)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(337, 16)
        Me.lblNote.TabIndex = 7
        Me.lblNote.Text = "Note: This setup can manually be done from the 'Tools'."
        '
        'chkSetupCURE
        '
        Me.chkSetupCURE.AutoSize = True
        Me.chkSetupCURE.Checked = True
        Me.chkSetupCURE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSetupCURE.Location = New System.Drawing.Point(121, 106)
        Me.chkSetupCURE.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSetupCURE.Name = "chkSetupCURE"
        Me.chkSetupCURE.Size = New System.Drawing.Size(223, 20)
        Me.chkSetupCURE.TabIndex = 4
        Me.chkSetupCURE.Text = "Setup CureCoin Folding Pool Info"
        Me.ToolTip1.SetToolTip(Me.chkSetupCURE, "Setup new user account on CryptoBullionPools.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the CureCoin Folding Pool")
        Me.chkSetupCURE.UseVisualStyleBackColor = True
        '
        'lblRecommended
        '
        Me.lblRecommended.AutoSize = True
        Me.lblRecommended.Location = New System.Drawing.Point(4, 139)
        Me.lblRecommended.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecommended.Name = "lblRecommended"
        Me.lblRecommended.Size = New System.Drawing.Size(315, 16)
        Me.lblRecommended.TabIndex = 6
        Me.lblRecommended.Text = "It's recommended that new users setup all 3 options."
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlDivider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlDivider.Location = New System.Drawing.Point(89, 36)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(134, 2)
        Me.pnlDivider.TabIndex = 8
        '
        'SetupDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(555, 195)
        Me.Controls.Add(Me.pnlDivider)
        Me.Controls.Add(Me.chkSetupCURE)
        Me.Controls.Add(Me.chkGetFAHSoftware)
        Me.Controls.Add(Me.lblRecommended)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.chkGetWalletForFLDC)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SetupDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get Setup for Folding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents chkGetWalletForFLDC As CheckBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents chkGetFAHSoftware As CheckBox
    Friend WithEvents lblNote As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkSetupCURE As CheckBox
    Friend WithEvents lblRecommended As Label
    Friend WithEvents pnlDivider As Panel
End Class

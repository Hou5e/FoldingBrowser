<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserPwdDialog
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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblMsgText = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.chkNewUser = New System.Windows.Forms.CheckBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(131, 64)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(456, 22)
        Me.txtEmail.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(497, 195)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 34)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(399, 195)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 34)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblMsgText
        '
        Me.lblMsgText.AutoSize = True
        Me.lblMsgText.Location = New System.Drawing.Point(13, 9)
        Me.lblMsgText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgText.Name = "lblMsgText"
        Me.lblMsgText.Size = New System.Drawing.Size(143, 16)
        Me.lblMsgText.TabIndex = 5
        Me.lblMsgText.Text = "Please Enter Your Info:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(131, 94)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(456, 22)
        Me.txtPassword.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(82, 67)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(56, 97)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(71, 16)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(131, 124)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(456, 22)
        Me.txtUsername.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(53, 127)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 16)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Username:"
        '
        'chkNewUser
        '
        Me.chkNewUser.AutoSize = True
        Me.chkNewUser.Location = New System.Drawing.Point(131, 36)
        Me.chkNewUser.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNewUser.Name = "chkNewUser"
        Me.chkNewUser.Size = New System.Drawing.Size(86, 20)
        Me.chkNewUser.TabIndex = 6
        Me.chkNewUser.Text = "New User"
        Me.chkNewUser.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(5, 161)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(582, 16)
        Me.lblNote.TabIndex = 10
        Me.lblNote.Text = "NOTE: If you get to a blank screen during the signup process, just press the 'Dis" &
    "cord' button again"
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlDivider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlDivider.Location = New System.Drawing.Point(13, 28)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(140, 2)
        Me.pnlDivider.TabIndex = 11
        '
        'UserPwdDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(603, 245)
        Me.Controls.Add(Me.pnlDivider)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.chkNewUser)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblMsgText)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserPwdDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Save Login Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblMsgText As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents chkNewUser As CheckBox
    Friend WithEvents lblNote As Label
    Friend WithEvents pnlDivider As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.UserNameTb = New System.Windows.Forms.TextBox()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.errorLbl1 = New System.Windows.Forms.Label()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HelpLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 120)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLbl.Location = New System.Drawing.Point(6, 25)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(70, 14)
        Me.UsernameLbl.TabIndex = 1
        Me.UsernameLbl.Text = "User Name:"
        Me.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UserNameTb
        '
        Me.UserNameTb.Location = New System.Drawing.Point(97, 22)
        Me.UserNameTb.Name = "UserNameTb"
        Me.UserNameTb.Size = New System.Drawing.Size(133, 22)
        Me.UserNameTb.TabIndex = 2
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Location = New System.Drawing.Point(6, 66)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(62, 14)
        Me.PasswordLbl.TabIndex = 3
        Me.PasswordLbl.Text = "Password:"
        Me.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PasswordTb
        '
        Me.PasswordTb.Location = New System.Drawing.Point(97, 62)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTb.Size = New System.Drawing.Size(133, 22)
        Me.PasswordTb.TabIndex = 4
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(38, 124)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(75, 25)
        Me.LoginBtn.TabIndex = 5
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(145, 124)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 25)
        Me.ExitBtn.TabIndex = 6
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'HelpBtn
        '
        Me.HelpBtn.Location = New System.Drawing.Point(284, 386)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(50, 25)
        Me.HelpBtn.TabIndex = 7
        Me.HelpBtn.Text = "Help"
        Me.HelpBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.errorLbl1)
        Me.GroupBox1.Controls.Add(Me.LoginBtn)
        Me.GroupBox1.Controls.Add(Me.ExitBtn)
        Me.GroupBox1.Controls.Add(Me.UserNameTb)
        Me.GroupBox1.Controls.Add(Me.PasswordTb)
        Me.GroupBox1.Controls.Add(Me.UsernameLbl)
        Me.GroupBox1.Controls.Add(Me.PasswordLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 155)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'errorLbl1
        '
        Me.errorLbl1.AutoSize = True
        Me.errorLbl1.ForeColor = System.Drawing.Color.Red
        Me.errorLbl1.Location = New System.Drawing.Point(9, 93)
        Me.errorLbl1.Name = "errorLbl1"
        Me.errorLbl1.Size = New System.Drawing.Size(43, 14)
        Me.errorLbl1.TabIndex = 7
        Me.errorLbl1.Text = "Label1"
        '
        'TimeLbl
        '
        Me.TimeLbl.AutoSize = True
        Me.TimeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLbl.Location = New System.Drawing.Point(13, 316)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(84, 16)
        Me.TimeLbl.TabIndex = 9
        Me.TimeLbl.Text = "Current Time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'HelpLbl
        '
        Me.HelpLbl.AutoSize = True
        Me.HelpLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpLbl.Location = New System.Drawing.Point(154, 389)
        Me.HelpLbl.Name = "HelpLbl"
        Me.HelpLbl.Size = New System.Drawing.Size(120, 20)
        Me.HelpLbl.TabIndex = 10
        Me.HelpLbl.Text = "Start Here -->"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 423)
        Me.Controls.Add(Me.HelpLbl)
        Me.Controls.Add(Me.TimeLbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LoginForm"
        Me.Text = "The Bear & The Troll Tavern -- Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLbl As System.Windows.Forms.Label
    Friend WithEvents UserNameTb As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLbl As System.Windows.Forms.Label
    Friend WithEvents PasswordTb As System.Windows.Forms.TextBox
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents HelpBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TimeLbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HelpLbl As System.Windows.Forms.Label
    Friend WithEvents errorLbl1 As System.Windows.Forms.Label

End Class

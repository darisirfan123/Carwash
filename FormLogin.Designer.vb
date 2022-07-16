<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxPwd = New System.Windows.Forms.CheckBox()
        Me.TextBoxUsrname = New System.Windows.Forms.TextBox()
        Me.TextBoxPwd = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnRegistrasi = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(328, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 85)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENERGY STAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(699, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Computer Store"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(412, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(412, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'CheckBoxPwd
        '
        Me.CheckBoxPwd.AutoSize = True
        Me.CheckBoxPwd.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBoxPwd.Location = New System.Drawing.Point(416, 406)
        Me.CheckBoxPwd.Name = "CheckBoxPwd"
        Me.CheckBoxPwd.Size = New System.Drawing.Size(131, 24)
        Me.CheckBoxPwd.TabIndex = 4
        Me.CheckBoxPwd.Text = "Show Password"
        Me.CheckBoxPwd.UseVisualStyleBackColor = True
        '
        'TextBoxUsrname
        '
        Me.TextBoxUsrname.Location = New System.Drawing.Point(417, 292)
        Me.TextBoxUsrname.Name = "TextBoxUsrname"
        Me.TextBoxUsrname.Size = New System.Drawing.Size(316, 26)
        Me.TextBoxUsrname.TabIndex = 5
        '
        'TextBoxPwd
        '
        Me.TextBoxPwd.Location = New System.Drawing.Point(417, 374)
        Me.TextBoxPwd.Name = "TextBoxPwd"
        Me.TextBoxPwd.Size = New System.Drawing.Size(316, 26)
        Me.TextBoxPwd.TabIndex = 6
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.GhostWhite
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.ForeColor = System.Drawing.Color.Indigo
        Me.BtnLogin.Location = New System.Drawing.Point(528, 436)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(92, 46)
        Me.BtnLogin.TabIndex = 7
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnRegistrasi
        '
        Me.BtnRegistrasi.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegistrasi.FlatAppearance.BorderSize = 0
        Me.BtnRegistrasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrasi.ForeColor = System.Drawing.Color.Fuchsia
        Me.BtnRegistrasi.Location = New System.Drawing.Point(617, 497)
        Me.BtnRegistrasi.Name = "BtnRegistrasi"
        Me.BtnRegistrasi.Size = New System.Drawing.Size(92, 46)
        Me.BtnRegistrasi.TabIndex = 8
        Me.BtnRegistrasi.Text = "Registrasi"
        Me.BtnRegistrasi.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(443, 510)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Don't have an account?"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1176, 623)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnRegistrasi)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TextBoxPwd)
        Me.Controls.Add(Me.TextBoxUsrname)
        Me.Controls.Add(Me.CheckBoxPwd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxPwd As CheckBox
    Friend WithEvents TextBoxUsrname As TextBox
    Friend WithEvents TextBoxPwd As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnRegistrasi As Button
    Friend WithEvents Label5 As Label
End Class

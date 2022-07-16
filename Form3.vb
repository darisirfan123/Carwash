Public Class Form3
    Dim acc As New TextBox
    Private Sub BtnLaptop_Click(sender As Object, e As EventArgs) Handles BtnLaptop.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPc_Click(sender As Object, e As EventArgs) Handles BtnPC.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKeranjang_Click(sender As Object, e As EventArgs) Handles BtnKeranjang.Click
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub BTNtambahkan_Click(sender As Object, e As EventArgs) Handles BTNtambahkan.Click
        If CBmouse.Checked = True And CBkeyboard.Checked = False And CBheadphone.Checked = False And CBtaslaptop.Checked = False And CBcoolingpad.Checked = False Then
            acc.Text = "Mouse"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = True And CBheadphone.Checked = False And CBtaslaptop.Checked = False And CBcoolingpad.Checked = False Then
            acc.Text = "Keyboard"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = False And CBheadphone.Checked = True And CBtaslaptop.Checked = False And CBcoolingpad.Checked = False Then
            acc.Text = "Headphone"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = False And CBheadphone.Checked = False And CBtaslaptop.Checked = True And CBcoolingpad.Checked = False Then
            acc.Text = "Tas Laptop"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = False And CBheadphone.Checked = False And CBtaslaptop.Checked = False And CBcoolingpad.Checked = True Then
            acc.Text = "Coolingpad"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = True And CBheadphone.Checked = False And CBtaslaptop.Checked = False And CBcoolingpad.Checked = False Then
            acc.Text = "Mouse, Keyboard"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = False And CBheadphone.Checked = True And CBtaslaptop.Checked = False And CBcoolingpad.Checked = False Then
            acc.Text = "Mouse, Headphone"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = False And CBheadphone.Checked = False And CBtaslaptop.Checked = True And CBcoolingpad.Checked = False Then
            acc.Text = "Mouse, Tas Laptop"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = False And CBheadphone.Checked = False And CBtaslaptop.Checked = False And CBcoolingpad.Checked = True Then
            acc.Text = "Mouse, Coolingpad"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = True And CBheadphone.Checked = True And CBtaslaptop.Checked = False And CBcoolingpad.Checked = False Then
            acc.Text = "Keyboard, Headphone"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = True And CBheadphone.Checked = False And CBtaslaptop.Checked = True And CBcoolingpad.Checked = False Then
            acc.Text = "Keyboard, Tas Laptop"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = True And CBheadphone.Checked = False And CBtaslaptop.Checked = False And CBcoolingpad.Checked = True Then
            acc.Text = "Keyboard, Coolingpad"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = False And CBheadphone.Checked = True And CBtaslaptop.Checked = True And CBcoolingpad.Checked = False Then
            acc.Text = "Headphone, Tas Laptop"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = False And CBheadphone.Checked = True And CBtaslaptop.Checked = False And CBcoolingpad.Checked = True Then
            acc.Text = "Headphone, Coolingpad"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = False And CBheadphone.Checked = False And CBtaslaptop.Checked = True And CBcoolingpad.Checked = True Then
            acc.Text = "Tas Laptop, Coolingpad"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = True And CBheadphone.Checked = True And CBtaslaptop.Checked = False And CBcoolingpad.Checked = False Then
            acc.Text = "Mouse, Keyboard, Headphone"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = True And CBheadphone.Checked = False And CBtaslaptop.Checked = True And CBcoolingpad.Checked = False Then
            acc.Text = "Mouse, Keyboard, Tas Laptop"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = True And CBheadphone.Checked = False And CBtaslaptop.Checked = False And CBcoolingpad.Checked = True Then
            acc.Text = "Mouse, Keyboard, Coolingpad"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = True And CBheadphone.Checked = True And CBtaslaptop.Checked = True And CBcoolingpad.Checked = False Then
            acc.Text = "Keyboard, Headphone, Tas Laptop"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = True And CBheadphone.Checked = True And CBtaslaptop.Checked = False And CBcoolingpad.Checked = True Then
            acc.Text = "Keyboard, Headphone, Coolingpad"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = False And CBheadphone.Checked = True And CBtaslaptop.Checked = True And CBcoolingpad.Checked = True Then
            acc.Text = "Headphone, Tas Laptop, Coolingpad"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = True And CBheadphone.Checked = True And CBtaslaptop.Checked = True And CBcoolingpad.Checked = False Then
            acc.Text = "Mouse, Keyboard, Headphone, Tas laptop"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = True And CBheadphone.Checked = True And CBtaslaptop.Checked = False And CBcoolingpad.Checked = True Then
            acc.Text = "Mouse, Keyboard, Headphone, Coolingpad"
        ElseIf CBmouse.Checked = False And CBkeyboard.Checked = True And CBheadphone.Checked = True And CBtaslaptop.Checked = True And CBcoolingpad.Checked = True Then
            acc.Text = "Keyboard, Headphone, Tas Laptop, Coolingpad"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = False And CBheadphone.Checked = True And CBtaslaptop.Checked = True And CBcoolingpad.Checked = True Then
            acc.Text = "Mouse, Headphone, Tas Laptop, Coolingpad"
        ElseIf CBmouse.Checked = True And CBkeyboard.Checked = True And CBheadphone.Checked = False And CBtaslaptop.Checked = True And CBcoolingpad.Checked = True Then
            acc.Text = "Mouse, Keyboard, Tas Laptop, Coolingpad"
        Else acc.Text = "Mouse, Keyboard, Headphone, Tas Laptop, Coolingpad"
        End If
        Form4.lvKeranjang.Items.Add(acc.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Keluar dari aplikasi" & vbCrLf &
       "Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
       Windows.Forms.DialogResult.Yes Then
            FormLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        FormUser.Show()
        Me.Hide()
    End Sub
End Class
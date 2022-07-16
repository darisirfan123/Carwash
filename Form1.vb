Public Class FormMain
    Dim CurrentItem As Integer = 0
    Private Sub BtnLaptop_Click(sender As Object, e As EventArgs) Handles BtnLaptop.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAcc_Click(sender As Object, e As EventArgs) Handles BtnAcc.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKeranjang_Click(sender As Object, e As EventArgs) Handles BtnKeranjang.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub RadioPC1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPC1.CheckedChanged
        If RadioPC1.Checked Then
            lvPC.Items.Clear()
            lvPC.Items.Add("Gigabyte B356M")
            lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("Intel Core i3")
            lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("Palit GTX 1050 Ti")
            lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("8 Gb")
            lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("Rp. 12.000.000")
        End If
    End Sub

    Private Sub RadioPC3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPC3.CheckedChanged
        lvPC.Items.Clear()
        lvPC.Items.Add("MSI MPG Z490")
        lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("Intel Core i7")
        lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("ROG Strix RTX 3070")
        lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("16 Gb")
        lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("Rp. 43.000.000")
    End Sub

    Private Sub RadioPC2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPC2.CheckedChanged
        If RadioPC2.Checked Then
            lvPC.Items.Clear()
            lvPC.Items.Add("Asrock B450M")
            lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("AMD Ryzen 5")
            lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("Gigabyte GTX 1080 Mini")
            lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("16 Gb")
            lvPC.Items(lvPC.Items.Count - 1).SubItems.Add("Rp. 15.000.000")
        End If


    End Sub

    Private Sub BtnBeli_Click(sender As Object, e As EventArgs) Handles BtnBeli.Click
        If RadioPC1.Checked Then
            Form4.lvKeranjang.Items.Add("Paket PC 1")
        End If

        If RadioPC2.Checked Then
            Form4.lvKeranjang.Items.Add("Paket PC 2")
        End If

        If RadioPC3.Checked Then
            Form4.lvKeranjang.Items.Add("Paket PC 3")
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
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

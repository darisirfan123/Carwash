Public Class Form2
    Dim CurrentItem As Integer = 0
    Private Sub BtnPC_Click(sender As Object, e As EventArgs) Handles BtnPC.Click
        FormMain.Show()
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

    Private Sub RadAcer_CheckedChanged(sender As Object, e As EventArgs) Handles RadAcer.CheckedChanged
        If RadAcer.Checked Then
            lvlaptop.Items.Clear()
            lvlaptop.Items.Add("Acer Nitro 5")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Intel Core i5-10300H")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("512 GB")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("nVidia GTX1650Ti")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Rp. 13.499.000")
        End If
    End Sub

    Private Sub RadAsus_CheckedChanged(sender As Object, e As EventArgs) Handles RadAsus.CheckedChanged
        If RadAsus.Checked Then
            lvlaptop.Items.Clear()
            lvlaptop.Items.Add("Asus VivoBook S14 M433UA")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("AMD Ryzen")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("512 GB")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("AMD Radeon")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Rp. 11.499.000")
        End If
    End Sub

    Private Sub RadHp_CheckedChanged(sender As Object, e As EventArgs) Handles RadHp.CheckedChanged
        If RadHp.Checked Then
            lvlaptop.Items.Clear()
            lvlaptop.Items.Add("HP 14Z")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Intel Core i7-1165G7")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("512 GB")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Intel Iris X Graphics")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Rp. 13.650.000")
        End If
    End Sub

    Private Sub RadDell_CheckedChanged(sender As Object, e As EventArgs) Handles RadDell.CheckedChanged
        If RadDell.Checked Then
            lvlaptop.Items.Clear()
            lvlaptop.Items.Add("Dell XPS 13")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Intel Core i7 85504")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("256 GB")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Intel UHD Graphics 620")
            lvlaptop.Items(lvlaptop.Items.Count - 1).SubItems.Add("Rp. 15.199.000")
        End If
    End Sub

    Private Sub BtnBeli_Click(sender As Object, e As EventArgs) Handles BtnBeli.Click
        If RadAcer.Checked Then
            Form4.lvKeranjang.Items.Add("Acer Nitro 5")
        End If

        If RadAsus.Checked Then
            Form4.lvKeranjang.Items.Add("Asus Vivobook")
        End If

        If RadHp.Checked Then
            Form4.lvKeranjang.Items.Add("HP 14Z")
        End If

        If RadDell.Checked Then
            Form4.lvKeranjang.Items.Add("Dell XPS 13")
        End If
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
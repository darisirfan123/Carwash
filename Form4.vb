Public Class Form4
    Private Sub BtnPC_Click(sender As Object, e As EventArgs) Handles BtnPC.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLaptop_Click(sender As Object, e As EventArgs) Handles BtnLaptop.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAcc_Click(sender As Object, e As EventArgs) Handles BtnAcc.Click
        Form3.Show()
        Me.Hide()
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
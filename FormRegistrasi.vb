Imports System.Data
Imports System.Data.SqlClient
Public Class FormRegistrasi
    Dim Cmd As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TBUsername.Text = "" Or TBPassword.Text = "" Then
            MsgBox("Isi username dan password!")
        Else
            Dim InputData As String = "INSERT INTO TBL_USER ([username],[password],[nama_lengkap],[nohp],[alamat],[tanggal_lahir]) VALUES ('" & TBUsername.Text & "', '" & TBPassword.Text & "', '" & TBNama.Text & "', '" & TBNohp.Text & "', '" & TBAlamat.Text & "', '" & TBTanggal.Text & "')"
            Cmd = New SqlCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Pendaftaran selesai, silakan login kembali", "Information", MessageBoxButtons.OK)
            Me.Hide()
            FormMain.Show()
        End If

    End Sub

    Private Sub FormRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiReg()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class
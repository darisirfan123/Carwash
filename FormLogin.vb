Imports System.Data.SqlClient
Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TextBoxUsrname.Text = "" Or TextBoxPwd.Text = "" Then
            MsgBox("Silakan isi username dan password !")
        Else
            Conn.Close()
            Call Koneksi()
            Cmd = New SqlCommand("Select * from TBL_USER where password = '" &
                TextBoxPwd.Text & "' and username ='" & TextBoxUsrname.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            If Not Rd.HasRows Then
                MsgBox("Username atau Password salah !")
            Else
                Me.Hide()
                FormMain.Show()
                '''Conn.Close()
            End If
        End If
    End Sub
    Private Sub BtnRegistrasi_Click(sender As Object, e As EventArgs) Handles BtnRegistrasi.Click
        FormRegistrasi.Show()
        Me.Hide()
    End Sub
End Class


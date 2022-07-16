Imports System.Data
Imports System.Data.SqlClient
Public Class FormUser
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection

        conn.ConnectionString = ("Data Source=LAPTOP-G184HP03\SQLEXPRESS;Initial Catalog=DB_APLIKASI;Integrated Security=True")
        conn.Open()

        Dim strsql As String

        strsql = " SELECT ([username],[password],[nama_lengkap],[nohp],[alamat],[tanggal_lahir]) from TBL_USER where username=" + FormLogin.TextBoxUsrname.Text + ""

        Dim cmd As New SqlCommand(strsql, conn)

        Dim myreader As SqlDataReader
        '''myreader = cmd.ExecuteReader

        '''conn.Close()
    End Sub
    Sub loadData()
        isiData("SELECT * FROM TBL_USER", DGVuser)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        FormUser.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKeranjang_Click(sender As Object, e As EventArgs) Handles BtnKeranjang.Click

    End Sub
End Class
Imports System.Data.SqlClient
Module ModuleLogin
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd, Rd2 As SqlDataReader
    Public Cmd As SqlCommand
    Public Cmd2 As SqlCommand
    Public Ds As DataSet

    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Data Source=LAPTOP-G184HP03\SQLEXPRESS;Initial Catalog=DB_APLIKASI;Integrated Security=True"
        Conn = New SqlConnection(MyDB)

    End Sub

    Public Sub Insert()

    End Sub
End Module

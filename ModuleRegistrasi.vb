Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleRegistrasi
    Public ConnReg As SqlConnection
    Public MyDB As String

    Sub KoneksiReg()
        MyDB = "Data Source=LAPTOP-G184HP03\SQLEXPRESS;Initial Catalog=DB_APLIKASI;Integrated Security=True"
        Conn = New SqlConnection(MyDB)

        If Conn.State = ConnectionState.Closed Then
            Try
                Conn.Open()
                MsgBox("Koneksi berhasil")
            Catch ex As Exception
                MsgBox("Koneksi gagal: " & ex.Message.ToString)
            End Try
        End If
    End Sub
End Module

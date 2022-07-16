Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleDGV
    Public da As New SqlDataAdapter
    Public dt As New DataTable
    Public Sub isiData(sql As String, dataGrid As DataGridView)
        dataGrid.DataSource = ambilData(sql)
    End Sub
    Public Function ambilData(sql As String) As DataTable
        Try
            Koneksi()
            da = New SqlDataAdapter(sql, Conn)
            dt = New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Conn.Close()
        End Try
    End Function

End Module

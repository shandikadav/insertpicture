Imports System.Data.SqlClient
Public Class belajarCariData

    Sub tampilkandata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT * FROM siswa", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "siswa")
        DataGridView1.DataSource = (ds.Tables("siswa"))
    End Sub

    Private Sub belajarCariData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkandata()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM siswa WHERE Nama LIKE '%" & TextBox1.Text & "%'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            konekdb()
            Dim da As New SqlDataAdapter("SELECT * FROM siswa WHERE Nama LIKE '%" & TextBox1.Text & "%'", konek)
            Dim ds As New DataSet
            da.Fill(ds, "ketemugan")
            DataGridView1.DataSource = (ds.Tables("ketemugan"))
            DataGridView1.ReadOnly = True
        End If
    End Sub
End Class
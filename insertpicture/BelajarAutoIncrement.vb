Imports System.Data.SqlClient
Public Class BelajarAutoIncrement

    Private Sub jalankansql(ByVal sql As String)
        Dim sqlcmd As New SqlCommand
        Try
            konekdb()
            sqlcmd.Connection = konek
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = sql
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            konek.Close()
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try
    End Sub

    Sub autoincrement()
        konekdb()
        Dim hitung As Long
        Dim urutan As String
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand("SELECT * FROM siswa WHERE ID in (SELECT MAX(ID) FROM siswa)", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = False Then
            urutan = "SIS" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            urutan = "SIS" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = urutan
    End Sub

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Sub tampilkandata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT * FROM siswa", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "siswa")
        DataGridView1.DataSource = (ds.Tables("siswa"))
    End Sub

    Private Sub BelajarAutoIncrement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkandata()
        TextBox1.Enabled = False
        autoincrement()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesan, sql As String
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox2.Focus()
        Else

            pesan = MsgBox("Apakah Anda yakin ingin menyimpan data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
            End If
            sql = "INSERT INTO siswa VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            jalankansql(sql)
            MsgBox("Data berhasil disimpan!", vbInformation)
            bersihkandata()
            tampilkandata()
            autoincrement()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
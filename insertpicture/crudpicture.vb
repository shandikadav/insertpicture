Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Public Class crudpicture

    Sub jalankansql(ByVal sql As String)
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

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Sub tampilkandata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT * FROM data", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "data")
        DataGridView1.DataSource = (ds.Tables("data"))
    End Sub
    Private Sub crudpicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkandata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan lengkapi data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            TextBox1.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            konekdb()
            Dim cmd As New SqlCommand("INSERT INTO data VALUES(@nis,@nama,@kelas,@foto)", konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            cmd.Parameters.Add("@nis", SqlDbType.Int).Value = TextBox1.Text
            cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = TextBox2.Text
            cmd.Parameters.Add("@kelas", SqlDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.Add("@foto", SqlDbType.Image).Value = ms.ToArray
            If cmd.ExecuteNonQuery = 1 Then
                MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampilkandata()
                bersihkandata()
            Else
                MessageBox.Show("Data gagal disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan lengkapi data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            TextBox1.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            konekdb()
            Dim cmd As New SqlCommand("UPDATE data SET Nama = '" + TextBox2.Text + "', Kelas = '" + TextBox3.Text + "', Foto=@foto WHERE NIS = '" + TextBox1.Text + "'", konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim img As Byte()
            img = ms.ToArray
            cmd.Parameters.Add("@foto", SqlDbType.Image).Value = img
            If cmd.ExecuteNonQuery = 1 Then
                MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampilkandata()
                bersihkandata()
            Else
                MessageBox.Show("Data gagal diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pesan, sql As String
        If TextBox1.Text = "" Then
            MessageBox.Show("Silahkan masukan kode NIS yang ingin dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            TextBox1.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "DELETE FROM data WHERE NIS LIKE '" + TextBox1.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkandata()
            bersihkandata()
        End If
    End Sub
End Class
Public Class Form1
    Private Sub ManageDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDataToolStripMenuItem.Click
        crudpicture.MdiParent = Me
        BelajarAutoIncrement.Close()
        belajarCariData.Close()
        crudpicture.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub KodeOtomatisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KodeOtomatisToolStripMenuItem.Click
        BelajarAutoIncrement.MdiParent = Me
        crudpicture.Close()
        belajarCariData.Close()
        BelajarAutoIncrement.Show()

    End Sub

    Private Sub CariDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CariDataToolStripMenuItem.Click
        belajarCariData.MdiParent = Me
        crudpicture.Close()
        BelajarAutoIncrement.Close()
        belajarCariData.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Report.MdiParent = Me
        crudpicture.Close()
        belajarCariData.Close()
        BelajarAutoIncrement.Close()
        Report.Show()
    End Sub
End Class

Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.siswa' table. You can move, or remove it, as needed.
        Me.siswaTableAdapter.Fill(Me.DataSet1.siswa)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
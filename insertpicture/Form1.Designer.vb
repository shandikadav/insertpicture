<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManageDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KodeOtomatisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageDataToolStripMenuItem, Me.KodeOtomatisToolStripMenuItem, Me.CariDataToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManageDataToolStripMenuItem
        '
        Me.ManageDataToolStripMenuItem.Name = "ManageDataToolStripMenuItem"
        Me.ManageDataToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ManageDataToolStripMenuItem.Text = "Manage Data"
        '
        'KodeOtomatisToolStripMenuItem
        '
        Me.KodeOtomatisToolStripMenuItem.Name = "KodeOtomatisToolStripMenuItem"
        Me.KodeOtomatisToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.KodeOtomatisToolStripMenuItem.Text = "Kode Otomatis"
        '
        'CariDataToolStripMenuItem
        '
        Me.CariDataToolStripMenuItem.Name = "CariDataToolStripMenuItem"
        Me.CariDataToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CariDataToolStripMenuItem.Text = "Cari Data"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 338)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManageDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KodeOtomatisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CariDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
End Class

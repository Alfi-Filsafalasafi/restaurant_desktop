Public Class Form_report_detailku

    Private Sub Form_report_detailku_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_report.Enabled = True
    End Sub

    Private Sub Form_report_detailku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chart_laporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chart_laporan.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
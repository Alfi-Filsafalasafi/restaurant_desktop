Public Class Form_cetak_order

    Private Sub Form_cetak_order_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_order.Close()
        MsgBox("silahkan lakukan pembayaran di kasir ", MsgBoxStyle.Information)
    End Sub

    Private Sub Form_report_chart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_cetak_order_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub
End Class
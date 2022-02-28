Public Class Form_laporan

    Private Sub Form_laporan_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_menu_admin.Visible = True
    End Sub

    Private Sub Form_laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data_laporan_perbulan.v_laporan_rell' table. You can move, or remove it, as needed.
        Me.V_laporan_rellTableAdapter.Fill(Me.Data_laporan_perbulan.v_laporan_rell)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generate.Click


    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub
End Class
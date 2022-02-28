Public Class Form_view_photo

    Private Sub Form_view_photo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_manage_menu.Enabled = True
        Form_view_order.Enabled = True
        Form_order.Enabled = True
        Form_menu_order.Enabled = True
        Form_edit_profil.Enabled = True
        Form_daftar.Enabled = True
        Form_rangking.Enabled = True
        Form_manage_member.Enabled = True
        Form_menu_tanpa_nama.Enabled = True
        Form_menu_member.Enabled = True
        Form_menu_cashier.Enabled = True
        Form_menu_chef.Enabled = True
    End Sub

    Private Sub Form_view_photo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
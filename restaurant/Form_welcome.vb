Public Class Form_welcome

    Private Sub cb_login_sbagai_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_login_sbagai.SelectedIndexChanged

    End Sub

    Private Sub btn_lanjut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lanjut.Click
        If cb_login_sbagai.Text = "" Then
            MsgBox("Isi perintah terlebih dahulu", MsgBoxStyle.Exclamation)
        Else
            Me.Visible = False
            Form_login.Show()
            Form_login.txt_tabel.Text = "ms_" + cb_login_sbagai.Text
        End If
     
    End Sub

    Private Sub Form_welcome_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("selamat tinggal", MsgBoxStyle.Information)
        Form_menu_tanpa_nama.Visible = True
    End Sub

    Private Sub Form_welcome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Form_welcome_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cb_login_sbagai.Text = ""
    End Sub

    Private Sub Form_welcome_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

    End Sub

    Private Sub lbl_daftar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_daftar.LinkClicked
        Me.Visible = False
        Form_daftar.Show()
    End Sub
End Class
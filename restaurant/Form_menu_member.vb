Imports System.IO
Public Class Form_menu_member
    Sub jumlah()
        konek_db()
        Dim tampil_jm As New SqlClient.SqlCommand("select * from v_rangking where id_member = '" & st_iid.Text & "' ", koneksi)
        Dim reader_jm As SqlClient.SqlDataReader
        reader_jm = tampil_jm.ExecuteReader
        Dim i As Integer = 0
        Do While reader_jm.Read
            lbl_jml_psn.Text = reader_jm!jumlah_pemesanan
        Loop
    End Sub
    Sub tampil_iden()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_member where id_member = '" & st_iid.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_email.Text = reader!email
            lbl_join_date.Text = reader!join_date
            lbl_name.Text = reader!name
            lbl_gender.Text = reader!gender
            lbl_hp.Text = reader!handphone
            Dim img() As Byte
            img = reader!photo
            Dim ms As New MemoryStream(img)
            pc_lb_me.Image = Image.FromStream(ms)

        Loop
        jumlah()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        st_waktu.Text = "|| waktu = " + Format(Now, "hh::mm::ss")
        st_tanggal.Text = "|| tanggal = " + Format(Now, "dd/MM/yy")
    End Sub

    Private Sub Form_menu_member_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Form_menu_member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_menu_member_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_iden()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pengaturan_akun.Click
        Me.Visible = False
        Form_edit_profil.Show()
    End Sub

    Private Sub btn_view_menuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_menuu.Click
        Me.Visible = False
        Form_menu_order.Show()
    End Sub

    Private Sub lbl_name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_name.Click

    End Sub

    Private Sub btn_order_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_order_menu.Click
        Me.Visible = False
        Form_order.Show()
        Form_order.lbl_id_member.Text = Me.lbl_id_member.Text
    End Sub

    Private Sub btn_history_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_history.Click
        Me.Visible = False
        Form_history_order.Show()
        Form_history_order.lbl_id_member.Text = Me.lbl_id_member.Text
    End Sub

    Private Sub Panel2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.GotFocus
        Panel2.BackColor = Color.White
    End Sub

    Private Sub Panel2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.LostFocus
        Panel2.BackColor = Color.White
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub lbl_email_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_gender.Click

    End Sub

    Private Sub lbl_hp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_hp.Click

    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub btn_log_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ganti_pass.Click
        Form_gantipassword.Show()
        Me.Enabled = False

    End Sub

    Private Sub lbl_join_date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_join_date.Click

    End Sub

    Private Sub Form_menu_member_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        tampil_iden()
    End Sub

    Private Sub pc_lb_me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_lb_me.Click
        Form_view_photo.pc_v.Image = pc_lb_me.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub btn_log_out_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log_out.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar ? ", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            MsgBox("selamat tinggal", MsgBoxStyle.Information)
            Me.Close()
            Form_welcome.Show()
            Form_welcome.cb_login_sbagai.Text = ""
            Form_login.txt_username.Text = ""
            Form_login.txt_password.Text = ""
            Form_login.txt_tabel.Text = ""
        End If
    End Sub
End Class
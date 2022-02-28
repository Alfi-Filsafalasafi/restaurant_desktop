Imports System.IO
Public Class Form_menu_chef
    Dim hari As String
    Sub tampil_iden()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_ms_employee where id_employee = '" & lbl_id_employee.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_email.Text = reader!email
            lbl_gender.Text = reader!gender
            lbl_hp.Text = reader!handphone
            lbl_gaji.Text = reader!gaji
            Dim img() As Byte
            img = reader!photo
            Dim ms As New MemoryStream(img)
            pc_lb_me.Image = Image.FromStream(ms)

        Loop

    End Sub
    Sub tampil_mkn_hari()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(qty) as jumlah from v_detail_order where jenis = 'makanan' and date = '" & Format(Date.Now, "yyyy-MM-dd") & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Try
            reader.Read()
            lbl_mkn_jual_hari.Text = reader!jumlah
        Catch ex As Exception
            lbl_mkn_jual_hari.Text = "0"
        End Try

    End Sub
    Sub hari_kemarin()

        konek_db()
        Dim harinya As New SqlClient.SqlCommand("select DATEADD(day,-1, GETDATE()) as kemarin", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = harinya.ExecuteReader
        Do While reader.Read
            hari = Format(reader!kemarin, "yyyy-MM-dd")

        Loop
    End Sub
    Sub tampil_mkn_hari_kmrn()

        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(qty) as jumlah from v_detail_order where jenis = 'makanan' and date = '" & hari & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Try
            reader.Read()
            lbl_mkn_jual_kem.Text = reader!jumlah
        Catch ex As Exception
            lbl_mkn_jual_kem.Text = "0"
        End Try

    End Sub
    Sub tampil_mnm_hari()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(qty) as jumlah from v_detail_order where jenis = 'minuman' and date = '" & Format(Date.Now, "yyyy-MM-dd") & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Try
            reader.Read()
            lbl_mnm_jual_hari.Text = reader!jumlah
        Catch ex As Exception
            lbl_mnm_jual_hari.Text = "0"
        End Try

    End Sub

    Sub tampil_mnm_hari_kem()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(qty) as jumlah from v_detail_order where jenis = 'minuman' and date = '" & hari & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Try
            reader.Read()
            lbl_mnm_kem.Text = reader!jumlah
        Catch ex As Exception
            lbl_mnm_kem.Text = "0"
        End Try

    End Sub

    Private Sub Form_menu_chef_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Form_login.txt_tabel.Text = ""
        Form_welcome.Show()
        Form_welcome.cb_login_sbagai.Text = ""
        Form_login.txt_username.Text = ""
        Form_login.txt_password.Text = ""
    End Sub

    Private Sub Form_menu_chef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        st_waktu.Text = "|| waktu = " + Format(Now, "hh::mm::ss")
        st_tanggal.Text = "|| tanggal = " + Format(Now, "dd/MM/yy")
    End Sub

    Private Sub btn_pengaturan_akun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pengaturan_akun.Click
        Me.Visible = False
        Form_view_order.Show()
    End Sub

    Private Sub btn_view_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_order.Click

        Me.Visible = False
        Form_edit_profil.Show()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ganti_pass.Click
        Form_gantipassword.Show()
        Me.Enabled = False
    End Sub

    Private Sub Form_menu_chef_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_iden()
    End Sub

    Private Sub pc_lb_me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_lb_me.Click
        Form_view_photo.pc_v.Image = pc_lb_me.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub Form_menu_chef_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        hari_kemarin()
        tampil_mkn_hari()
        tampil_mnm_hari()
        tampil_mkn_hari_kmrn()
        tampil_mnm_hari_kem()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log_out.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar ? ", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            MsgBox("selamat tinggal", MsgBoxStyle.Information)
            Me.Close()

        End If
    End Sub
End Class
Imports System.IO
Public Class Form_menu_cashier
    Dim hari, hari2 As String
    Sub hari_kemarin()

        konek_db()
        Dim harinya As New SqlClient.SqlCommand("select DATEADD(day,-1, GETDATE()) as kemarin", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = harinya.ExecuteReader
        Do While reader.Read
            hari = Format(reader!kemarin, "yyyy-MM-dd")

        Loop
    End Sub
    Sub hari_2()

        konek_db()
        Dim harinya As New SqlClient.SqlCommand("select DATEADD(day,-2, GETDATE()) as kemarin", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = harinya.ExecuteReader
        Do While reader.Read
            hari2 = Format(reader!kemarin, "yyyy-MM-dd")

        Loop
    End Sub
    Sub tampil_pendapatan()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(total) as jumlah from v_detail_order where date = '" & Format(Date.Now, "yyyy-MM-dd") & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Try
            reader.Read()
            lbl_pendapatan.Text = reader!jumlah
        Catch ex As Exception
            lbl_pendapatan.Text = "0"
        End Try
    End Sub
    Sub tampil_pendapatan_kem()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(total) as jumlah from v_detail_order where date = '" & hari & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Try
            reader.Read()
            lbl_pdp_1.Text = reader!jumlah
        Catch ex As Exception
            lbl_pdp_1.Text = "0"
        End Try
    End Sub

    Sub tampil_pendapatan_2()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(total) as jumlah from v_detail_order where date = '" & hari2 & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Try
            reader.Read()
            lbl_pdp_2.Text = reader!jumlah
        Catch ex As Exception
            lbl_pdp_2.Text = "0"
        End Try
    End Sub
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
    Private Sub Form_menu_cashier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_welcome.Show()
        Form_welcome.cb_login_sbagai.Text = ""
        Form_login.txt_username.Text = ""
        Form_login.txt_password.Text = ""
        Form_login.txt_tabel.Text = ""
    End Sub

    Private Sub Form_menu_cashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        st_waktu.Text = "|| Waktu = " + Format(Now, "hh:mm:ss")
        st_tanggal.Text = "|| Tanggal = " + Format(Now, "dd/MM/yyyy")
    End Sub

    Private Sub btn_pengaturan_akun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pengaturan_akun.Click
        Me.Visible = False
        Form_payment.Show()
    End Sub

    Private Sub btn_view_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_payment.Click

        Me.Visible = False
        Form_edit_profil.Show()
    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub pc_lb_me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_lb_me.Click
        Form_view_photo.pc_v.Image = pc_lb_me.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ganti_pass.Click
        Form_gantipassword.Show()
        Me.Enabled = False
    End Sub

    Private Sub Form_menu_cashier_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_iden()

    End Sub

    Private Sub Form_menu_cashier_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        hari_kemarin()
        hari_2()
        tampil_pendapatan_kem()
        tampil_pendapatan()
        tampil_pendapatan_2()
    End Sub

    Private Sub btn_log_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log_out.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar ? ", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            MsgBox("selamat tinggal", MsgBoxStyle.Information)
            Me.Close()

        End If

    End Sub
End Class
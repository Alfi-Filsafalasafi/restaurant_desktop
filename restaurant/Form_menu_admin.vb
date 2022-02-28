Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form_menu_admin
    Dim hari, sekarang As String

    Sub hari_kemarin()
        konek_db()
        Dim harinya As New SqlClient.SqlCommand("select DATEADD(day,-6, GETDATE()) as kemarin", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = harinya.ExecuteReader
        Do While reader.Read
            hari = Format(reader!kemarin, "yyyy-MM-dd")

        Loop
    End Sub
 
    Sub tampil_pelanggan()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select count(id_order) as jumlah from header_order where date = '" & Format(Date.Now, "yyyy-MM-dd") & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_pengunjung.Text = reader!jumlah
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
    Sub tampil_member()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select count(id_member) as jumlah from ms_member ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_member.Text = reader!jumlah
        Loop
    End Sub
    Sub tampil_employee()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select count(id_employee) as jumlah from ms_employee ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_employee.Text = reader!jumlah
        Loop
    End Sub
    Sub tampilchart()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendapatan where  date between '" & hari & "' and '" & Format(Date.Now, "yyyy-MM-dd") & "'", koneksi)
        Dim data As New DataTable
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        data.Load(reader)

        chart_laporan.DataSource = data

        Dim serias As Series = chart_laporan.Series("Jumlah Pendapatan")
        serias.Name = "Jumlah Pendapatan"
        chart_laporan.Series(serias.Name).XValueMember = "date"
        chart_laporan.Series(serias.Name).YValueMembers = "jumlah"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        st_waktu.Text = "|| Waktu = " + Format(Now, "hh:mm:ss")
        st_tanggal.Text = "|| Tanggal = " + Format(Now, "dd/MM/yyyy")

    End Sub

    Private Sub Form_menu_admin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_welcome.Show()
        Form_welcome.cb_login_sbagai.Text = ""
        Form_login.txt_username.Text = ""
        Form_login.txt_password.Text = ""
        Form_login.txt_tabel.Text = ""
    End Sub
 
    Private Sub Form_menu_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_log_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ganti_pass.Click
        Form_gantipassword.Show()
        Me.Enabled = False
    End Sub


    Private Sub btn_pengaturan_akun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pengaturan_akun.Click
        Me.Visible = False
        Form_edit_profil.Show()
    End Sub

    Private Sub btn_manage_employee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_manage_employee.Click
        Me.Visible = False
        Form_manage_employee.Show()
    End Sub

    Private Sub btn_member_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_member.Click
        Me.Visible = False
        Form_manage_member.Show()
    End Sub

    Private Sub btn_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        Me.Visible = False
        Form_manage_menu.Show()
    End Sub

    Private Sub btn_report_transaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_report_transaksi.Click
        Me.Visible = False
        Form_report.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        form_grafik_makanan.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        Form_rangking.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub chart_laporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Form_menu_admin_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        hari_kemarin()
        tampil_pelanggan()
        tampil_member()
        tampil_employee()
        tampil_pendapatan()
        tampilchart()
    End Sub

    Private Sub lbl_employee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_employee.Click

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub btn_log_out_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log_out.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar ? ", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            MsgBox("selamat tinggal", MsgBoxStyle.Information)
            Me.Visible = False
            Form_welcome.Show()
            Form_welcome.cb_login_sbagai.Text = ""
            Form_login.txt_username.Text = ""
            Form_login.txt_password.Text = ""
            Form_login.tabel = ""
        End If
    End Sub
End Class
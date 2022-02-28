Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form_report

    Sub tampiltahun()
        konek_db()
        txt_tahun.Items.Clear()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_tahun", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_tahun.Items.Add(reader("tahun"))

        Loop
    End Sub

    Sub tampilbulan()
        konek_db()
        txt_bulan.Items.Clear()
        txt_bulan_sampai.Items.Clear()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_bulan", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_bulan.Items.Add(reader("bulan"))
            txt_bulan_sampai.Items.Add(reader("bulan"))
        Loop
    End Sub

    Sub jumlah_pemilihan()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(jumlah) as total from v_laporan_rell where tahun= '" & txt_tahun.Text & "' and id_bulan >='" & txt_id_bulan.Text & "' and id_bulan <='" & txt_id_bulan_sampai.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Try
            reader.Read()
            Form_report_detailku.lbl_jumlah.Text = reader!total
        Catch ex As Exception
            MsgBox("tidak ada data pelanggan", MsgBoxStyle.Critical)
        End Try

    End Sub

    Sub jumlah()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(jumlah) as total from v_laporan_rell", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_jumlah.Text = reader!total
        Loop
    End Sub

    Private Sub Form_report_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_menu_admin.Visible = True
    End Sub

    Private Sub Form_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataLaporan.v_laporan_rell' table. You can move, or remove it, as needed.

        ''TODO: This line of code loads data into the 'Data_laporan_perbulan.v_laporan_rell' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generate.Click
        konek_db()
        If txt_tahun.Text <> "" And txt_bulan.Text <> "" And txt_bulan_sampai.Text <> "" Then
            Dim tampil As New SqlClient.SqlCommand("select * from v_laporan_rell where tahun= '" & txt_tahun.Text & "' and id_bulan >='" & txt_id_bulan.Text & "' and id_bulan <='" & txt_id_bulan_sampai.Text & "'", koneksi)
            Dim data As New DataTable
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            data.Load(reader)

            Form_report_detailku.chart_laporan.DataSource = data

            Dim serias As Series = Form_report_detailku.chart_laporan.Series("Jumlah Pengunjung")
            serias.Name = "Jumlah Pengunjung"
            Form_report_detailku.chart_laporan.Series(serias.Name).XValueMember = "bulan"
            Form_report_detailku.chart_laporan.Series(serias.Name).YValueMembers = "jumlah"

            Form_report_detailku.lbl_bulan.Text = txt_bulan.Text
            Form_report_detailku.lbl_sampai.Text = txt_bulan_sampai.Text
            Form_report_detailku.lbl_tahun.Text = txt_tahun.Text

   
            jumlah_pemilihan()
            Form_report_detailku.Show()
            Me.Enabled = False

        Else
            MsgBox("pilih tahun dan bulan secara lengkap !", MsgBoxStyle.Exclamation)

        End If


    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        jumlah()
        tampilbulan()
        tampiltahun()
    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub txt_bulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bulan.SelectedIndexChanged

    End Sub

    Private Sub txt_bulan_sampai_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bulan_sampai.SelectedIndexChanged

    End Sub

    Private Sub txt_bulan_sampai_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_bulan_sampai.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_bulan where bulan='" & txt_bulan_sampai.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        If txt_bulan_sampai.Text = "" Then
            txt_id_bulan_sampai.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_bulan_sampai.Text = reader!id_bulan
            End If
        End While
    End Sub

    Private Sub txt_bulan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_bulan.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_bulan where bulan='" & txt_bulan.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        If txt_bulan.Text = "" Then
            txt_id_bulan.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_bulan.Text = reader!id_bulan
            End If
        End While
    End Sub

    Private Sub Form_report_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.V_laporan_rellTableAdapter.Fill(Me.DataLaporan.v_laporan_rell)
        jumlah()
        tampilbulan()
        tampiltahun()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
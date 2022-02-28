Imports System.Windows.Forms.DataVisualization.Charting
Public Class form_grafik_makanan

    Sub tampil_tahun()
        txt_tahun.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_tahun", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_tahun.Items.Add(reader("tahun"))
        Loop
    End Sub

    Sub tampil_bulan()
        txt_bulan.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_bulan", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_bulan.Items.Add(reader("bulan"))
        Loop
    End Sub

    Sub bersihteks()
        lbl_id_bulan.Text = ""

        tampil_bulan()
        tampil_tahun()
    End Sub

    Private Sub form_grafik_makanan_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form_menu_admin.Visible = True
    End Sub

    Private Sub form_grafik_makanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data_grafik_makanan.v_grafik_makanan' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chart_makanan.Click

    End Sub

    Private Sub btn_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generate.Click
        If txt_bulan.Text = "" Or txt_tahun.Text = "" Then
            MsgBox("pilih bulan beserta tahun terlebih dahulu !", MsgBoxStyle.Critical)

        Else
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_grafik_makanan where tahun = '" & txt_tahun.Text & "' and bulan = '" & lbl_id_bulan.Text & "'", koneksi)
            Dim data As New DataTable
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            data.Load(reader)

            Form_grafik_detail.chart_makanan.DataSource = data
          
            Dim serias As Series = Form_grafik_detail.chart_makanan.Series("Jumlah Pemesan")
            serias.Name = "Jumlah Pemesan"
            Form_grafik_detail.chart_makanan.Series(serias.Name).XValueMember = "name"
            Form_grafik_detail.chart_makanan.Series(serias.Name).YValueMembers = "jumlah"

            Form_grafik_detail.lbl_bulan.Text = txt_bulan.Text
            Form_grafik_detail.lbl_tahun.Text = txt_tahun.Text
            Form_grafik_detail.Show()
            Me.Enabled = False

        End If


    End Sub

    Private Sub txt_bulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bulan.SelectedIndexChanged

    End Sub

    Private Sub txt_bulan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_bulan.TextChanged

            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ref_bulan where bulan = '" & txt_bulan.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
    

            reader = tampil.ExecuteReader
            Do While reader.Read
                lbl_id_bulan.Text = reader!id_bulan
            Loop

    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        bersihteks()
    End Sub

    Private Sub form_grafik_makanan_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_grafik_m ", koneksi)
        Dim data As New DataTable
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        data.Load(reader)

        chart_makanan.DataSource = data

        Dim serias As Series = chart_makanan.Series("Jumlah Pemesan")
        serias.Name = "Jumlah Pemesan"
        chart_makanan.Series(serias.Name).XValueMember = "name"
        chart_makanan.Series(serias.Name).YValueMembers = "jumlah"
        bersihteks()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
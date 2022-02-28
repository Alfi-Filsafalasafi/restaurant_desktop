Public Class Form_history_order

    Sub reset_header()
        lv_header_order.Items.Clear()
    End Sub

    Sub reset_detail()
        lv_detail_order.Items.Clear()
    End Sub
    Sub tampil_header()
        reset_header()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_header_order where id_member = '" & lbl_id_member.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_header_order.Items.Add(reader!id_order)
            lv_header_order.Items(i).SubItems.Add(reader!date)
            lv_header_order.Items(i).SubItems.Add(reader!payment)

            i = i + +1
        Loop
    End Sub

    Sub total()
        konek_db()
        Dim total As New SqlClient.SqlCommand("select SUM(total) AS tot FROM detail_order where id_order = '" & lv_header_order.SelectedItems(0).SubItems(0).Text & "' GROUP BY id_order ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = total.ExecuteReader
        Do While reader.Read
            lbl_total.Text = reader!tot
        Loop
    End Sub
    Sub tampil_bulan()
        konek_db()
        txt_bulan.Items.Clear()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_bulan", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_bulan.Items.Add(reader("bulan"))
        Loop
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form_history_order_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_menu_member.Visible = True
    End Sub

    Private Sub Form_history_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_history_order_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_bulan()
        tampil_header()
        lbl_nama.Text = Form_menu_member.lbl_name.Text
    End Sub

    Private Sub lv_header_order_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_header_order.MouseClick
        reset_detail()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_detail_order where id_order = '" & lv_header_order.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_detail_order.Items.Add(reader!menu)
            lv_detail_order.Items(i).SubItems.Add(reader!price)
            lv_detail_order.Items(i).SubItems.Add(reader!qty)
            lv_detail_order.Items(i).SubItems.Add(reader!total)
            lv_detail_order.Items(i).SubItems.Add(reader!type_masak)

            i = i + +1

        Loop
        total()

    End Sub

    Private Sub lv_header_order_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_header_order.SelectedIndexChanged

    End Sub

    Private Sub txt_bulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bulan.SelectedIndexChanged

    End Sub

    Private Sub txt_bulan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_bulan.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_bulan where bulan = '" & txt_bulan.Text & "'", koneksi)
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

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        lv_detail_order.Items.Clear()
        If txt_bulan.Text <> "" Then
            reset_header()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_header_order where id_member = '" & lbl_id_member.Text & "' and MONTH(date) = '" & txt_id_bulan.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_header_order.Items.Add(reader!id_order)
                lv_header_order.Items(i).SubItems.Add(reader!date)
                lv_header_order.Items(i).SubItems.Add(reader!payment)

                i = i + +1
            Loop
        End If


        If txt_tahun.Text <> "" Then
            reset_header()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_header_order where id_member = '" & lbl_id_member.Text & "' and YEAR(date) = '" & txt_tahun.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_header_order.Items.Add(reader!id_order)
                lv_header_order.Items(i).SubItems.Add(reader!date)
                lv_header_order.Items(i).SubItems.Add(reader!payment)

                i = i + +1
            Loop
        End If

        If txt_bulan.Text <> "" And txt_tahun.Text <> "" Then
            reset_header()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_header_order where id_member = '" & lbl_id_member.Text & "' and MONTH(date) = '" & txt_id_bulan.Text & "' and YEAR(date) = '" & txt_tahun.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_header_order.Items.Add(reader!id_order)
                lv_header_order.Items(i).SubItems.Add(reader!date)
                lv_header_order.Items(i).SubItems.Add(reader!payment)

                i = i + +1
            Loop
        End If
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        txt_tahun.Items.Clear()
        txt_tahun.Items.Add("2018")
        txt_tahun.Items.Add("2019")
        txt_tahun.Items.Add("2020")
        txt_tahun.Items.Add("2021")
        txt_tahun.Items.Add("2022")
        txt_tahun.Items.Add("2023")
        txt_tahun.Items.Add("2024")
        txt_tahun.Items.Add("2025")
        txt_tahun.Items.Add("2026")
        txt_tahun.Items.Add("2027")
        txt_tahun.Items.Add("2028")
        txt_tahun.Items.Add("2029")
        txt_tahun.Items.Add("2030")
        txt_tahun.Items.Add("2031")
        txt_tahun.Items.Add("2032")
        txt_tahun.Items.Add("2033")
        txt_tahun.Items.Add("2034")
        txt_tahun.Items.Add("2035")


        tampil_bulan()
        tampil_header()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
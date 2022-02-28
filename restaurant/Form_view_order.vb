Public Class Form_view_order
    Sub reset_header()
        lv_order.Items.Clear()
    End Sub
    Sub reset_detail()
        lv_view_order.Items.Clear()
    End Sub

    Sub total()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select SUM(total) as tot from v_detail_order where id_order = '" & lv_order.SelectedItems(0).SubItems(0).Text & "' group by id_order", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_total.Text = reader!tot
        Loop
    End Sub
    Sub tampil_data()
        reset_header()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_header_order where pembayaran ='sudah bayar'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_order.Items.Add(reader!id_order)
            lv_order.Items(i).SubItems.Add(reader!id_member)
            lv_order.Items(i).SubItems.Add(reader!member)
            lv_order.Items(i).SubItems.Add(reader!date)
            lv_order.Items(i).SubItems.Add(reader!meja)

            i = i + +1
        Loop
    End Sub
    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_order.MouseClick
        reset_detail()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_detail_order where id_order = '" & lv_order.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_view_order.Items.Add(i + 1)
            lv_view_order.Items(i).SubItems.Add(reader!menu)
            lv_view_order.Items(i).SubItems.Add(reader!qty)
            lv_view_order.Items(i).SubItems.Add(reader!type_masak)

            i = i + +1

            txt_id_order.Text = reader!id_order
        Loop
        total()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_order.SelectedIndexChanged

    End Sub

    Private Sub Form_view_order_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_menu_chef.Visible = True
    End Sub

    Private Sub Form_view_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_view_order_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_data()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        konek_db()
        Dim finish As New SqlClient.SqlCommand("update header_order set pembayaran = 'finish' where id_order = '" & txt_id_order.Text & "'", koneksi)

        Try
            finish.ExecuteNonQuery()
            MsgBox("nomor order '" & txt_id_order.Text & "' telah di lakukan")
            tampil_data()
            reset_detail()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
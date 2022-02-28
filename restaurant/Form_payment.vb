Public Class Form_payment
    Sub reset_header()
        lv_order.Items.Clear()
    End Sub
 
    Sub reset_detail()
        lv_view_order.Items.Clear()
    End Sub
    
    Sub bersihteks()
        txt_card_number.Text = ""
        cb_bank.Text = ""
        cb_payment.Text = ""
        txt_id_bank.Text = ""
        lbl_total.Text = "-"
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
        Dim tampil As New SqlClient.SqlCommand("select * from v_header_order where pembayaran ='proses'", koneksi)
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

    Sub tampil_payment()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_payment", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            cb_payment.Items.Add(reader("name"))
        Loop

    End Sub

    Sub tampil_bank()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_bank", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            cb_bank.Items.Add(reader("name"))
        Loop
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_total.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form_payment_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_menu_cashier.Visible = True
    End Sub

    Private Sub Form_payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Form_payment_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_bank()
        tampil_data()
        tampil_payment()
    End Sub

    Private Sub lv_order_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_order.MouseClick
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
        GroupBox3.Enabled = True
    End Sub

    Private Sub lv_order_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_order.SelectedIndexChanged

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_card_number.Text = "" And txt_id_bank.Text = "" And txt_id_payment.Text = "" Then
            MsgBox("lengkapi perintah terlebih dahulu", MsgBoxStyle.Exclamation)

        Else
            konek_db()
            Dim update As New SqlClient.SqlCommand("update header_order set id_payment = '" & txt_id_payment.Text &
                                                   "', id_employee = '" & Form_menu_cashier.lbl_id_employee.Text & "', id_bank = '" & txt_id_bank.Text &
                                                   "', pembayaran='sudah bayar', card_number='" & txt_card_number.Text & "' where id_order = '" & txt_id_order.Text & "'", koneksi)

            Try
                Update.ExecuteNonQuery()
                MsgBox("proses pembayaran berhasil")


                bersihteks()
                tampil_data()
                reset_detail()
                GroupBox3.Enabled = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub cb_payment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_payment.SelectedIndexChanged

    End Sub

    Private Sub cb_payment_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_payment.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_payment where name = '" & cb_payment.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        If cb_payment.Text = "" Then
            txt_id_payment.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_payment.Text = reader!id_payment
            End If
        End While
    End Sub

    Private Sub txt_card_number_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_card_number.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[+,0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If

    End Sub

    Private Sub txt_card_number_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_card_number.TextChanged
       
    End Sub

    Private Sub cb_bank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_bank.SelectedIndexChanged

    End Sub

    Private Sub cb_bank_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_bank.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_bank where name = '" & cb_bank.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        If cb_bank.Text = "" Then
            txt_id_bank.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_bank.Text = reader!id_bank
            End If
        End While
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
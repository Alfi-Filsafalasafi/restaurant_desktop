Imports System.IO
Public Class Form_order
    Dim stoku As String
    Dim id_type_masak As Integer
    Sub aksesteks_false()
        txt_name.Enabled = False
        txt_qty.Enabled = False
        txt_price.Enabled = False
        txt_message.Enabled = False
        txt_type_masak.Enabled = False
    End Sub
    Sub reset_detail()
        lv_order.Items.Clear()
    End Sub

    Sub cetak()
        konek_db()
        Dim cetak_detail As cetak_detail = New cetak_detail
        Dim data As New DataTable
        Dim tampil As New SqlClient.SqlCommand("select * from v_detail_order where id_order = '" & txt_id_order.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        data.Load(reader)
        cetak_detail.SetDataSource(data)
        Form_cetak_order.report_v_cetak.ReportSource = cetak_detail

        Form_cetak_order.Show()
    End Sub


    Sub total()
        konek_db()
        Dim total As New SqlClient.SqlCommand("select SUM(total) AS tot FROM detail_order where id_order = '" & txt_id_order.Text & "' GROUP BY id_order ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = total.ExecuteReader
        Do While reader.Read
            lbl_total.Text = reader!tot
        Loop
    End Sub

    Sub buttonawal()
        btn_add.Enabled = False
        btn_update.Enabled = False
        btn_delet.Enabled = False

        lv_menu.Enabled = True
        btn_save_edit.Enabled = False

    End Sub


    Sub reset()
        lv_menu.Items.Clear()
    End Sub

    Sub bersihteks()
        txt_name.Text = ""
        txt_price.Text = ""
        txt_qty.Text = ""
        picture.Image = Nothing
        txt_message.Text = ""
        txt_type_masak.Text = ""
        txt_meja.Text = ""
        txt_message.Text = ""
    End Sub


    Sub tampil_menu()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where id_menu <> '0' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_menu)
            lv_menu.Items(i).SubItems.Add(reader!name)
            lv_menu.Items(i).SubItems.Add(reader!price)
            lv_menu.Items(i).SubItems.Add(reader!stok)


            i = i + +1
        Loop



    End Sub

    Sub tampil_detail()
        reset_detail()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_detail_order where id_order = '" & txt_id_order.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_order.Items.Add(reader!menu)
            lv_order.Items(i).SubItems.Add(reader!qty)
            lv_order.Items(i).SubItems.Add(reader!price)
            lv_order.Items(i).SubItems.Add(reader!total)

            i = i + +1
        Loop

    End Sub


    Sub meja()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_meja ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_meja.Items.Add(reader("meja"))
        Loop
    End Sub

    Sub tampil_type_masak()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_type_masak", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_type_masak.Items.Add(reader("type_masak"))
        Loop

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form_order_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If lbl_id_member.Text = "0" Then
            Form_menu_tanpa_nama.Show()
        Else
            Form_menu_member.Show()
        End If
    End Sub

    Private Sub Form_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_order_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_menu()
        btn_add.Enabled = False
        btn_delet.Enabled = False
        txt_qty.Enabled = False
        bersihteks()
        meja()

        tampil_type_masak()

        konek_db()
        Dim insert_header As New SqlClient.SqlCommand("insert into header_order values('0','" & lbl_id_member.Text & "', '" & Format(Date.Now, "yyyy-MM-dd") & "', '0', '0', '0','proses','')", koneksi)
        Try
            insert_header.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Dim tampil_id As New SqlClient.SqlCommand("select id_order from header_order where id_member = '" & lbl_id_member.Text & "' and id_employee = '0' and date = '" & Format(Date.Now, "yyyy-MM-dd") & "' and id_payment='0' and id_bank ='0' and pembayaran='proses' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil_id.ExecuteReader
        Do While reader.Read
            txt_id_order.Text = reader!id_order
        Loop

    End Sub

    Private Sub lv_menu_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where id_menu = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_name.Text = reader!name
            txt_price.Text = reader!price
            txt_id_menu.Text = reader!id_menu
            txt_qty.Enabled = True
            txt_message.Enabled = True
            txt_type_masak.Enabled = True
            Dim img() As Byte
            img = reader!photo
            Dim ms As New MemoryStream(img)
            picture.Image = Image.FromStream(ms)
            stoku = reader!stok
            If stoku <> "Ada" Then
                MsgBox("stok sedang tidak ada, tidak bisa memesan menu ini ", MsgBoxStyle.Critical)
                bersihteks()

            End If
        Loop
        btn_add.Enabled = True
        btn_update.Enabled = False
        btn_save_edit.Enabled = False
        btn_delet.Enabled = False
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub txt_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_qty.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[+,0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If

    End Sub

    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If txt_qty.Text <> "" Or txt_message.Text <> "" Or txt_id_type_masak.Text <> "" Then
            konek_db()
            Dim insert_detail As New SqlClient.SqlCommand("insert into detail_order values('" & txt_id_order.Text & "', '" & txt_id_menu.Text & "', '" & txt_qty.Text & "', '" & txt_price.Text & "', '" & txt_message.Text & "' ,'" & txt_id_type_masak.Text & "' , '" & txt_price.Text * txt_qty.Text & "')", koneksi)

            Try
                insert_detail.ExecuteNonQuery()
                tampil_detail()
                total()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            bersihteks()
            buttonawal()

            aksesteks_false()

        Else
            MsgBox("data harus lengkap", MsgBoxStyle.Exclamation)
        End If




    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        If txt_search.Text <> "" Then
            reset()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where name LIKE'%" & txt_search.Text & "%' and  id_menu <> '0'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_menu.Items.Add(reader!id_menu)
                lv_menu.Items(i).SubItems.Add(reader!name)
                lv_menu.Items(i).SubItems.Add(reader!price)

                i = i + +1
            Loop
        End If
        If txt_search.Text = "" Then
            tampil_menu()
        End If
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        txt_search.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        Dim answer As Integer
        answer = MsgBox("apakah yakin akan membatalkan orderan ? ", MsgBoxStyle.YesNo)
        If answer = vbYes Then
            konek_db()
            Dim batal_detail As New SqlClient.SqlCommand("delete from detail_order where id_order = '" & txt_id_order.Text & "'", koneksi)
            Dim batal_header As New SqlClient.SqlCommand("delete  from header_order where id_order = '" & txt_id_order.Text & "'", koneksi)

            Try
                batal_detail.ExecuteNonQuery()
                batal_header.ExecuteNonQuery()
                MsgBox("orderan anda telah di batalkan", MsgBoxStyle.Information)
         
                    Me.Close()


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub txt_id_order_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id_order.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub txt_type_masak_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_type_masak.SelectedIndexChanged

    End Sub

    Private Sub lv_order_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_order.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_detail_order where menu = '" & lv_order.SelectedItems(0).SubItems(0).Text & "' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            txt_name.Text = reader!menu
            txt_price.Text = reader!price
            txt_qty.Text = reader!qty
            txt_message.Text = reader!message
            txt_type_masak.Text = reader!type_masak
            id_type_masak = reader!id_type_masak
            txt_id_detail.Text = reader!id_detail
        Loop
        btn_update.Enabled = True
        btn_delet.Enabled = True
        btn_add.Enabled = False

    End Sub

    Private Sub lv_order_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_order.SelectedIndexChanged

    End Sub

    Private Sub txt_type_masak_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_type_masak.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_type_masak where type_masak = '" & txt_type_masak.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        If txt_type_masak.Text = "" Then
            txt_id_type_masak.Text = ""
        End If
        Do While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_type_masak.Text = reader!id_type_masak
            Else
                txt_id_type_masak.Text = ""
            End If
        Loop
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        txt_qty.Enabled = True
        txt_message.Enabled = True
        txt_type_masak.Enabled = True
        btn_add.Enabled = False
        btn_save_edit.Enabled = True
        btn_delet.Enabled = False
        btn_update.Enabled = False
        lv_menu.Enabled = False
    End Sub

    Private Sub btn_delet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delet.Click
        konek_db()
        Dim hapus As New SqlClient.SqlCommand("delete from detail_order where id_detail = '" & txt_id_detail.Text & "'", koneksi)
        Try
            hapus.ExecuteNonQuery()
            tampil_detail()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        aksesteks_false()
        btn_update.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save_edit.Click
        konek_db()
        Dim update As New SqlClient.SqlCommand("update detail_order set qty = '" & txt_qty.Text &
                                               "', message = '" & txt_message.Text & "', id_type_masak = '" & txt_id_type_masak.Text &
                                               "', total = '" & txt_price.Text * txt_qty.Text & "' where id_detail = '" & txt_id_detail.Text & "'", koneksi)
        Try
            update.ExecuteNonQuery()
            tampil_detail()
            total()
            buttonawal()
            aksesteks_false()
            bersihteks()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_order.Click
        If txt_meja.Text = "" Then
            MsgBox("pilih mja terlebih dahulu ", MsgBoxStyle.Exclamation)
        Else
            Dim asnwer As Integer
            asnwer = MsgBox("apakah makanan & minuman sudah cukup ? ", MsgBoxStyle.YesNo)
            If asnwer = vbYes Then

                konek_db()
                Dim update As New SqlClient.SqlCommand("update header_order set id_meja = '" & txt_id_meja.Text & "' where id_order = '" & txt_id_order.Text & "'", koneksi)
                Try
                    update.ExecuteNonQuery()


                    MsgBox("terima kasih ")
                    cetak()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If
       
    End Sub

    Private Sub txt_meja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_meja.SelectedIndexChanged

    End Sub

    Private Sub txt_meja_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_meja.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_meja where meja = '" & txt_meja.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        If txt_meja.Text <> "" Then
            txt_id_meja.Text = ""
        End If

        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_meja.Text = reader!id_meja
            End If
        End While
    End Sub

    Private Sub txt_id_meja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id_meja.TextChanged
        If txt_id_meja.Text <> "" Then
            btn_order.Enabled = True
        End If
        If txt_id_meja.Text = "" Then
            btn_order.Enabled = False
        End If
    End Sub

    Private Sub picture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picture.Click
        Form_view_photo.pc_v.Image = picture.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub lbl_id_member_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_id_member.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class
Imports System.IO
Public Class Form_manage_menu
    Dim aksi As String
    Sub update_detail()
        konek_db()
        Dim update As New SqlClient.SqlCommand("update detail_order set id_menu = '0' where id_menu = '" & txt_id.Text & "'", koneksi)
        Try
            update.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("gagal update detail karena " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub reset()
        lv_menu.Items.Clear()
    End Sub

    Sub pemilihan()
        If txt_jenis_cari.Text = "" And txt_search.Text = "" Then
            tampil_data()

        End If
        If txt_jenis_cari.Text <> "" And txt_search.Text = "" Then
            reset()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where jenis LIKE'%" & txt_jenis_cari.Text & "%' and id_menu <> '0'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_menu.Items.Add(reader!id_menu)
                lv_menu.Items(i).SubItems.Add(reader!name)
                lv_menu.Items(i).SubItems.Add(reader!price)
                lv_menu.Items(i).SubItems.Add(reader!stok)
                lv_menu.Items(i).SubItems.Add(reader!jenis)

                i = i + +1
            Loop
        End If
        If txt_jenis_cari.Text = "" And txt_search.Text <> "" Then
            reset()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where name LIKE'%" & txt_search.Text & "%' and id_menu <> '0' ", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_menu.Items.Add(reader!id_menu)
                lv_menu.Items(i).SubItems.Add(reader!name)
                lv_menu.Items(i).SubItems.Add(reader!price)
                lv_menu.Items(i).SubItems.Add(reader!stok)
                lv_menu.Items(i).SubItems.Add(reader!jenis)

                i = i + +1
            Loop
        End If
        If txt_jenis_cari.Text <> "" And txt_search.Text <> "" Then
            reset()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where name LIKE'%" & txt_search.Text & "%' and jenis LIKE'%" & txt_jenis_cari.Text & "%' and id_menu <> '0'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_menu.Items.Add(reader!id_menu)
                lv_menu.Items(i).SubItems.Add(reader!name)
                lv_menu.Items(i).SubItems.Add(reader!price)
                lv_menu.Items(i).SubItems.Add(reader!stok)
                lv_menu.Items(i).SubItems.Add(reader!jenis)

                i = i + +1
            Loop
        End If
    End Sub
    Sub bersihteks()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_photo.Text = ""
        txt_price.Text = ""
        cb_stok.Items.Clear()
        cb_stok.Items.Add("Ada")
        cb_stok.Items.Add("Tidak Ada")
        txt_jenis.Items.Clear()
        txt_jenis.Items.Add("Makanan")
        txt_jenis.Items.Add("Minuman")
        txt_photo.Text = ""

        pc_menu.Image = Nothing
        txt_deskripsi.Text = ""
    End Sub

    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_edit.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_menu.Enabled = True

    End Sub

    Sub aksesteks(ByVal akses As Boolean)

        txt_name.Enabled = akses
        txt_price.Enabled = akses
        cb_stok.Enabled = akses
        txt_jenis.Enabled = akses
        btn_upload.Enabled = akses
        txt_deskripsi.Enabled = akses
    End Sub

    Sub tampil_data()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where id_menu <> '0'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_menu)
            lv_menu.Items(i).SubItems.Add(reader!name)
            lv_menu.Items(i).SubItems.Add(reader!price)
            lv_menu.Items(i).SubItems.Add(reader!stok)
            lv_menu.Items(i).SubItems.Add(reader!jenis)

            i = i + +1
        Loop
    End Sub

    Private Sub Form_manage_menu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Visible = False
        Form_menu_admin.Visible = True
    End Sub

    Private Sub Form_manage_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        aksi = "T"
        aksesteks(True)

        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksi = "U"
        aksesteks(True)
        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub Form_manage_menu_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_data()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub lv_menu_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where id_menu = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            txt_id.Text = reader!id_menu
            txt_name.Text = reader!name
            txt_price.Text = reader!price
            cb_stok.Text = reader!stok
            txt_jenis.Text = reader!jenis
            txt_photo.Text = reader!photo.ToString
            Dim img() As Byte
            img = reader!photo
            Dim ms As New MemoryStream(img)
            pc_menu.Image = Image.FromStream(ms)
            txt_deskripsi.Text = reader!deskripsi
        Loop

        btn_tambah.Enabled = False
        btn_edit.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
        btn_batal.Enabled = True

    End Sub

    Private Sub lv_menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_menu.SelectedIndexChanged
       
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        pemilihan()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txt_search.Text = ""
        txt_jenis_cari.Items.Clear()
        txt_jenis_cari.Items.Add("Makanan")
        txt_jenis_cari.Items.Add("Minuman")

        tampil_data()
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_name.Text <> "" And txt_photo.Text <> "" And txt_price.Text <> "" And txt_deskripsi.Text <> "" And cb_stok.Text <> "" And txt_jenis.Text <> "" Then
            Dim ms As New MemoryStream
            pc_menu.Image.Save(ms, pc_menu.Image.RawFormat)
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into ms_menu values ('" & txt_name.Text & "', '" & txt_price.Text &
                                                       "', '" & cb_stok.Text & "', @image, '" & txt_deskripsi.Text & "', '" & txt_jenis.Text & "')", koneksi)

                tambah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                    tampil_data()
                Catch ex As Exception
                    MsgBox("data gagal di tambah " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If


            If aksi = "U" Then
                konek_db()
                Dim update As New SqlClient.SqlCommand("update ms_menu set name = '" & txt_name.Text & "', price = '" & txt_price.Text &
                                                        "', stok = '" & cb_stok.Text & "' , deskripsi = '" & txt_deskripsi.Text &
                                                        "', jenis= '" & txt_jenis.Text & "', photo = @image where id_menu = '" & txt_id.Text & "'", koneksi)
                update.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    update.ExecuteNonQuery()
                    MsgBox("data berhasil di ubah", MsgBoxStyle.Information)
                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                    tampil_data()
                Catch ex As Exception
                    MsgBox("data gagal di ubah " + ex.Message, MsgBoxStyle.Critical)

                End Try
            End If
        Else
            MsgBox("lengkapi data ", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        konek_db()
        Dim hapus As New SqlClient.SqlCommand("delete from ms_menu where id_menu = '" & txt_id.Text & "'", koneksi)
        Try
            hapus.ExecuteNonQuery()
            MsgBox("data berhasil di hapus", MsgBoxStyle.Information)
            buttonawal()
            bersihteks()
            aksesteks(False)
            tampil_data()
        Catch ex As Exception
            MsgBox("data gagal di hapus " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        buttonawal()
        bersihteks()
        aksesteks(False)
        tampil_data()
    End Sub

    Private Sub btn_upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload.Click
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        pc_menu.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
    End Sub

    Private Sub txt_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_price.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[+,0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If

    End Sub

    Private Sub txt_price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_price.TextChanged

    End Sub

    Private Sub pc_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_menu.Click
        Form_view_photo.pc_v.Image = pc_menu.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub txt_jenis_cari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_jenis_cari.SelectedIndexChanged

    End Sub

    Private Sub txt_jenis_cari_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_jenis_cari.TextChanged
        pemilihan()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
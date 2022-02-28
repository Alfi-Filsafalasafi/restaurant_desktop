Imports System.IO
Public Class Form_menu_tanpa_nama

    Sub bersihteks()
        lbl_deskripsi.Text = "-"
        lbl_harga.Text = "-"
        lbl_stok.Text = "-"
        lbl_nama.Text = "-"
        picture.Image = Nothing

    End Sub
    Sub tampil_datamakanan()
        lv_makanan.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where jenis ='Makanan'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_makanan.Items.Add(i + 1)
            lv_makanan.Items(i).SubItems.Add(reader!name)

            i = i + +1
        Loop
    End Sub
    Sub tampil_dataminuman()
        lv_minuman.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where jenis ='Minuman' and id_menu <> '0'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_minuman.Items.Add(i + 1)
            lv_minuman.Items(i).SubItems.Add(reader!name)

            i = i + +1
        Loop
    End Sub
    Private Sub Form_menu_tanpa_nama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_menu_tanpa_nama_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_datamakanan()
        tampil_dataminuman()
        bersihteks()
    End Sub

    Private Sub lv_makanan_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_makanan.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where name = '" & lv_makanan.SelectedItems(0).SubItems(1).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_nama.Text = reader!name
            lbl_harga.Text = reader!price
            lbl_deskripsi.Text = reader!deskripsi
            lbl_stok.Text = reader!stok
            Dim img() As Byte
            img = reader!photo
            Dim ms As New MemoryStream(img)
            picture.Image = Image.FromStream(ms)
        Loop
    End Sub

    Private Sub lv_makanan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_makanan.SelectedIndexChanged

    End Sub

    Private Sub lv_minuman_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_minuman.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where name = '" & lv_minuman.SelectedItems(0).SubItems(1).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_nama.Text = reader!name
            lbl_harga.Text = reader!price
            lbl_deskripsi.Text = reader!deskripsi
            lbl_stok.Text = reader!stok
            Dim img() As Byte
            img = reader!photo
            Dim ms As New MemoryStream(img)
            picture.Image = Image.FromStream(ms)
        Loop
    End Sub

    Private Sub lv_minuman_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_minuman.SelectedIndexChanged

    End Sub

    Private Sub btn_refresh_makanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh_makanan.Click
        txt_cari_makanan.Text = ""
        bersihteks()
    End Sub

    Private Sub btn_cari_minuman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_minuman.Click
        bersihteks()
        txt_cari_minuman.Text = ""
    End Sub

    Private Sub txt_cari_makanan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari_makanan.TextChanged
        lv_makanan.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where jenis ='Makanan' and name like '%" & txt_cari_makanan.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_makanan.Items.Add(i + 1)
            lv_makanan.Items(i).SubItems.Add(reader!name)

            i = i + +1
        Loop
    End Sub

    Private Sub txt_cari_minuman_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari_minuman.TextChanged
        lv_minuman.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where jenis ='Minuman' and name like '%" & txt_cari_minuman.Text & "%' and id_menu <> '0'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_minuman.Items.Add(i + 1)
            lv_minuman.Items(i).SubItems.Add(reader!name)

            i = i + +1
        Loop
    End Sub

    Private Sub picture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picture.Click
        Form_view_photo.pc_v.Image = picture.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub btn_klik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_klik.Click
        Me.Visible = False
        Form_order.lbl_id_member.Text = "0"
        Form_order.Show()
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Me.Visible = False
        Form_welcome.cb_login_sbagai.Text = "Member"
        Form_welcome.Show()
    End Sub

    Private Sub btn_daftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_daftar.Click
        Me.Visible = False
        Form_daftar.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_cari_makanan.Text = ""
        txt_cari_minuman.Text = ""
        bersihteks()
    End Sub
End Class
Imports System.IO
Public Class Form_menu_order
    Sub reset()
        lv_menu.Items.Clear()
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

            i = i + +1
        Loop
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


                i = i + +1
            Loop
        End If
    End Sub

    Private Sub Form_menu_order_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_menu_member.Visible = True
    End Sub

    Private Sub Form_menu_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lv_menu_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_menu.MouseClick

        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_menu where id_menu = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
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

    Private Sub lv_menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub Form_menu_order_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_data()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged

        pemilihan()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_search.Text = ""
        txt_jenis_cari.Items.Clear()
        txt_jenis_cari.Items.Add("Makanan")
        txt_jenis_cari.Items.Add("Minuman")

        tampil_data()

    End Sub

    Private Sub picture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picture.Click
        Form_view_photo.pc_v.Image = picture.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_jenis_cari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_jenis_cari.SelectedIndexChanged
        pemilihan()
    End Sub
End Class
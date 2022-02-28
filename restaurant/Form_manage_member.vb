Imports System.IO
Public Class Form_manage_member
    Dim aksi As String
    Sub update_tanpa_nama()
        konek_db()
        Dim update As New SqlClient.SqlCommand("update header_order set id_member = '0' where id_member = '" & txt_id.Text & "'", koneksi)
        Try
            update.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ubah gagal karena " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub reset()
        lv_member.Items.Clear()
    End Sub
    Sub bersihteks()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_email.Text = ""
        txt_password.Text = ""
        txt_hp.Text = ""
        txt_gender.Items.Clear()
        txt_gender.Items.Add("Laki - Laki")
        txt_gender.Items.Add("Perempuan")
        txt_date.Text = ""
        pc_me.Image = Nothing

    End Sub

    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_edit.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_member.Enabled = True
    End Sub

    Sub aksesteks(ByVal akses As Boolean)
        btn_upload.Enabled = akses
        txt_name.Enabled = akses
        txt_email.Enabled = akses
        txt_gender.Enabled = akses
        txt_hp.Enabled = akses
        txt_date.Enabled = akses
        txt_password.Enabled = akses
    End Sub

    Sub tampil_data()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_member where id_member <> '0' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_member.Items.Add(reader!id_member)
            lv_member.Items(i).SubItems.Add(reader!name)
            lv_member.Items(i).SubItems.Add(reader!email)
            lv_member.Items(i).SubItems.Add(reader!gender)
            lv_member.Items(i).SubItems.Add(reader!handphone)
            lv_member.Items(i).SubItems.Add(reader!join_date)

            i = i + +1
        Loop
    End Sub

    Private Sub Form_manage_member_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Form_menu_admin.Visible = True
    End Sub

    Private Sub Form_manage_member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_manage_member_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_data()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        aksi = "T"
        aksesteks(True)
        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_member.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksi = "U"
        aksesteks(True)
        txt_id.Enabled = False
        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_member.Enabled = False
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_email.Text = "" Or txt_gender.Text = "" Or txt_hp.Text = "" Or txt_name.Text = "" Or txt_password.Text = "" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Exclamation)
        Else
            Dim ms As New MemoryStream
            pc_me.Image.Save(ms, pc_me.Image.RawFormat)
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into ms_member values('" & txt_name.Text & "', '" & txt_email.Text &
                                                       "', '" & txt_password.Text & "', '" & txt_hp.Text & "', '" & txt_gender.Text & "', '" & Format(txt_date.Value, "yyy-MM-dd") &
                                                       "', @image)", koneksi)
                tambah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                    tampil_data()
                Catch ex As Exception
                    MsgBox("data gagal di tambah", MsgBoxStyle.Critical)
                End Try
            End If



            If aksi = "U" Then
                konek_db()
                Dim ubah As New SqlClient.SqlCommand("update ms_member set name = '" & txt_name.Text & "', email = '" & txt_email.Text &
                                                     "', password = '" & txt_password.Text & "', gender = '" & txt_gender.Text &
                                                     "', handphone = '" & txt_hp.Text & "', join_date = '" & Format(txt_date.Value, "yyyy-MM-dd") &
                                                     "', photo=@image where id_member = '" & txt_id.Text & "'", koneksi)
                ubah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    ubah.ExecuteNonQuery()
                    MsgBox("data berhasil di update", MsgBoxStyle.Information)
                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                    tampil_data()
                Catch ex As Exception
                    MsgBox("data gagal di update", MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan menghapus data ini ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("delete from ms_member where id_member = '" & txt_id.Text & "'", koneksi)
            Try
                update_tanpa_nama()
                hapus.ExecuteNonQuery()
                MsgBox("data berhasil di hapus", MsgBoxStyle.Information)
                buttonawal()
                bersihteks()
                aksesteks(False)
                tampil_data()
            Catch ex As Exception
                MsgBox("data gagal di simpan", MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        buttonawal()
        bersihteks()
        aksesteks(False)
        tampil_data()
    End Sub

    Private Sub lv_member_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_member.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_member where id_member = '" & lv_member.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            txt_id.Text = reader!id_member
            txt_name.Text = reader!name
            txt_email.Text = reader!email
            txt_gender.Text = reader!gender
            txt_password.Text = reader!password
            txt_date.Text = reader!join_date
            txt_hp.Text = reader!handphone

            Dim img() As Byte
            img = reader!photo
            Dim ms As New MemoryStream(img)
            pc_me.Image = Image.FromStream(ms)
        Loop

        btn_tambah.Enabled = False
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        btn_simpan.Enabled = False
        btn_batal.Enabled = True
    End Sub

    Private Sub lv_member_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_member.SelectedIndexChanged

    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_member where name LIKE'%" & txt_search.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_member.Items.Add(reader!id_member)
            lv_member.Items(i).SubItems.Add(reader!name)
            lv_member.Items(i).SubItems.Add(reader!email)
            lv_member.Items(i).SubItems.Add(reader!gender)
            lv_member.Items(i).SubItems.Add(reader!handphone)
            lv_member.Items(i).SubItems.Add(reader!join_date)

            i = i + +1
        Loop
    End Sub

    Private Sub txt_hp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_hp.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[+,0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If

    End Sub

    Private Sub txt_hp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_hp.TextChanged

    End Sub

    Private Sub btn_upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload.Click
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        pc_me.ImageLocation = open_photo.FileName
    End Sub

    Private Sub pc_me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_me.Click
        Form_view_photo.pc_v.Image = pc_me.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
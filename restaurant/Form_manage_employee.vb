Imports System.IO
Public Class Form_manage_employee
    Dim aksi As String
    Sub update_tanpa_nama()
        konek_db()
        Dim update As New SqlClient.SqlCommand("update header_order set id_employee = '0' where id_employee = '" & txt_id.Text & "'", koneksi)
        Try
            update.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ubah gagal karena " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub reset()
        lv_employee.Items.Clear()
    End Sub
    Sub bersihteks()
        txt_id.Text = ""
        txt_handphone.Text = ""
        txt_name.Text = ""
        txt_email.Text = ""
        txt_password.Text = ""
        cb_position.Text = ""
        txt_photo.Text = ""
        pc_me.Image = Nothing
        cb_gender.Items.Clear()
        cb_gender.Items.Add("Laki - Laki")
        cb_gender.Items.Add("Perempuan")
        txt_id_position.Text = ""
    End Sub
    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_edit.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_employee.Enabled = True
    End Sub
    Sub aksesteks(ByVal akses As Boolean)
        btn_upload.Enabled = akses
        txt_name.Enabled = akses
        txt_email.Enabled = akses
        txt_password.Enabled = akses
        cb_position.Enabled = akses
        cb_gender.Enabled = akses
        txt_handphone.Enabled = akses
    End Sub

    Sub tampil_data()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_ms_employee", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_employee.Items.Add(reader!id_employee)
            lv_employee.Items(i).SubItems.Add(reader!name)
            lv_employee.Items(i).SubItems.Add(reader!gender)
            lv_employee.Items(i).SubItems.Add(reader!email)
            lv_employee.Items(i).SubItems.Add(reader!handphone)
            lv_employee.Items(i).SubItems.Add(reader!name_position)

            i = i + +1
        Loop

    End Sub

    Sub tampil_position()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_position", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            cb_position.Items.Add(reader("name_position"))
        Loop
    End Sub

    Private Sub Form_manage_employee_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Visible = False
        Form_menu_admin.Visible = True
    End Sub

    Private Sub Form_manage_employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lv_employee_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_employee.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_ms_employee where id_employee = '" & lv_employee.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            txt_id.Text = reader!id_employee
            txt_name.Text = reader!name
            txt_email.Text = reader!email
            cb_gender.Text = reader!gender
            txt_password.Text = reader!password
            txt_handphone.Text = reader!handphone
            cb_position.Text = reader!name_position


            Dim img() As Byte
            img = reader!photo
            txt_photo.Text = reader!photo.ToString
            Dim ms As New MemoryStream(img)
            pc_me.Image = Image.FromStream(ms)
        Loop

        btn_tambah.Enabled = False
        btn_edit.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
        btn_batal.Enabled = True
    End Sub

    Private Sub lv_employee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_employee.SelectedIndexChanged

    End Sub

    Private Sub cb_position_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_position.SelectedIndexChanged

    End Sub

    Private Sub Form_manage_employee_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        buttonawal()
        aksesteks(False)
        bersihteks()
        tampil_data()
        tampil_position()
    End Sub

    Private Sub cb_position_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_position.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ref_position where name_position = '" & cb_position.Text & "' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        If cb_position.Text = "" Then
            txt_id_position.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_position.Text = reader!id_position
            End If
        End While
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_ms_employee where name LIKE'%" & txt_search.Text & "%' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_employee.Items.Add(reader!id_employee)
            lv_employee.Items(i).SubItems.Add(reader!name)
            lv_employee.Items(i).SubItems.Add(reader!gender)
            lv_employee.Items(i).SubItems.Add(reader!email)
            lv_employee.Items(i).SubItems.Add(reader!handphone)
            lv_employee.Items(i).SubItems.Add(reader!name_position)

            i = i + +1
        Loop
    End Sub

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        aksi = "T"
        aksesteks(True)
        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_employee.Enabled = False
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
        lv_employee.Enabled = False
    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        buttonawal()
        bersihteks()
        tampil_data()
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_email.Text = "" Or txt_handphone.Text = "" Or txt_id_position.Text = "" Or txt_name.Text = "" Or txt_password.Text = "" Or txt_photo.Text = "" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Exclamation)
        Else
            Dim ms As New MemoryStream
            pc_me.Image.Save(ms, pc_me.Image.RawFormat)
            If aksi = "T" Then
                konek_db()
                Dim tampil As New SqlClient.SqlCommand("insert into ms_employee values('" & txt_name.Text &
                                                       "', '" & txt_email.Text & "', '" & txt_password.Text & "', '" & txt_handphone.Text &
                                                       "', '" & cb_gender.Text & "', '" & txt_id_position.Text & "', @image)", koneksi)
                tampil.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    tampil.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)


                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di tambah" + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If

            If aksi = "U" Then
                konek_db()
                Dim update As New SqlClient.SqlCommand("update ms_employee set name = '" & txt_name.Text & "', email = '" & txt_email.Text &
                                                       "', password ='" & txt_password.Text & "', gender = '" & cb_gender.Text &
                                                       "', id_position = '" & txt_id_position.Text & "', handphone = '" & txt_handphone.Text &
                                                       "', photo=@image where id_employee = '" & txt_id.Text & "'", koneksi)
                update.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray

                Try
                    update.ExecuteNonQuery()
                    MsgBox("data berhasil di ubah", MsgBoxStyle.Information)


                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di ubah " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
        tampil_data()
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan menghapus data ini ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("delete from ms_employee where id_employee = '" & txt_id.Text & "'", koneksi)
            Try
                update_tanpa_nama()
                hapus.ExecuteNonQuery()
                MsgBox("data berhasil di hapus", MsgBoxStyle.Information)
                bersihteks()
                buttonawal()
                tampil_data()
            Catch ex As Exception
                MsgBox("data gagal di hapus", MsgBoxStyle.Critical)
            End Try
        End If



    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        txt_search.Text = ""
    End Sub

    Private Sub txt_handphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_handphone.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[+,0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If

    End Sub

    Private Sub txt_handphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_handphone.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub btn_upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload.Click
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        pc_me.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
    End Sub
End Class
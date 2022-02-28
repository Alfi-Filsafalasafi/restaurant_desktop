Imports System.IO
Public Class Form_edit_profil
    Dim aksi As String
    Sub aksesteks(ByVal akses As Boolean)

        txt_name.Enabled = akses
        txt_email.Enabled = akses
        txt_gender.Enabled = akses

        txt_hp.Enabled = akses
        txt_ketik.Enabled = akses
        btn_simpan.Enabled = akses
        btn_batal.Enabled = akses

    End Sub

    Sub tampildata()
        If Form_welcome.cb_login_sbagai.Text = "member" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ms_member where email = '" & Form_login.txt_username.Text & "' and password = '" & Form_login.txt_password.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Do While reader.Read
                txt_ketik.Text = ""
                ed_id.Text = "ID Member"
                ed_photo.Text = "Photo Member"
                txt_id.Text = reader!id_member
                txt_name.Text = reader!name
                txt_email.Text = reader!email
                txt_password.Text = reader!password
                txt_hp.Text = reader!handphone
                txt_photo.Text = reader!photo.ToString
                txt_gender.Text = reader!gender
                lbl_join_date.Text = reader!join_date

                lbl_id.Text = reader!id_member
                lbl_name.Text = reader!name
                lbl_email.Text = reader!email
                lbl_password.Text = reader!password
                lbl_hp.Text = reader!handphone
                lbl_position.Text = "Member"


                Dim img() As Byte
                img = reader!photo
                Dim ms As New MemoryStream(img)
                pc_me.Image = Image.FromStream(ms)
                pc_lb_me.Image = Image.FromStream(ms)
            Loop
        End If

        If Form_welcome.cb_login_sbagai.Text = "admin" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ms_admin where email = '" & Form_login.txt_username.Text & "' and password = '" & Form_login.txt_password.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Do While reader.Read
                ed_id.Text = "ID Admin"
                ed_photo.Text = "Photo Admin"
                txt_id.Text = reader!id_admin
                txt_name.Text = reader!name
                txt_email.Text = reader!email
                txt_password.Text = reader!password
                txt_hp.Text = reader!handphone
                txt_gender.Text = reader!gender
                txt_photo.Text = reader!photo.ToString
                lbl_id.Text = reader!id_admin
                lbl_name.Text = reader!name
                lbl_email.Text = reader!email
                lbl_password.Text = reader!password
                lbl_hp.Text = reader!handphone
                lbl_position.Text = "Admin"

                Dim img() As Byte
                img = reader!photo
                Dim ms As New MemoryStream(img)
                pc_me.Image = Image.FromStream(ms)
                pc_lb_me.Image = Image.FromStream(ms)



               

            Loop
        End If

        If Form_welcome.cb_login_sbagai.Text = "employee" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_ms_employee where email = '" & Form_login.txt_username.Text & "' and password = '" & Form_login.txt_password.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Do While reader.Read
                ed_id.Text = "ID Employee"
                ed_photo.Text = "Photo Employee"
                txt_id.Text = reader!id_employee
                txt_name.Text = reader!name
                txt_email.Text = reader!email
                txt_password.Text = reader!password
                txt_hp.Text = reader!handphone
                txt_gender.Text = reader!gender
                txt_photo.Text = reader!photo.ToString
                lbl_id.Text = reader!id_employee
                lbl_name.Text = reader!name
                lbl_email.Text = reader!email
                lbl_password.Text = reader!password
                lbl_hp.Text = reader!handphone
                lbl_position.Text = reader!name_position


                Dim img() As Byte
                img = reader!photo
                Dim ms As New MemoryStream(img)
                pc_me.Image = Image.FromStream(ms)
                pc_lb_me.Image = Image.FromStream(ms)
            Loop
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        tampildata()
        aksesteks(False)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_email.Text = "" Or txt_gender.Text = "" Or txt_hp.Text = "" Or txt_ketik.Text = "" Or txt_name.Text = "" Or txt_password.Text = "" Or txt_photo.Text = "" Then
            MsgBox("data belum lengkap ", MsgBoxStyle.Critical)
        Else
            If txt_ketik.Text = txt_password.Text Then
                If Form_welcome.cb_login_sbagai.Text = "member" Then
                    konek_db()
                    Dim ms As New MemoryStream
                    pc_me.Image.Save(ms, pc_me.Image.RawFormat)
                    Dim update As New SqlClient.SqlCommand("update ms_member set name = '" & txt_name.Text & "', email = '" & txt_email.Text &
                                                           "', password ='" & txt_password.Text & "', handphone = '" & txt_hp.Text &
                                                           "', gender = '" & txt_gender.Text & "', photo=@image where id_member = '" & txt_id.Text & "'", koneksi)
                    update.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                    Try
                        Form_login.txt_username.Text = txt_email.Text
                        Form_menu_member.lbl_name.Text = txt_name.Text
                        Form_menu_member.st_nama.Text = "||  Nama Pengguna  =  " + txt_name.Text
                        update.ExecuteNonQuery()
                        MsgBox("Data berhasil di perbarui", MsgBoxStyle.Information)
                        aksesteks(False)
                        tampildata()

                    Catch ex As Exception
                        MsgBox("data gagal di perbarui" + ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If

                If Form_welcome.cb_login_sbagai.Text = "employee" Then
                    konek_db()
                    Dim ms As New MemoryStream
                    pc_me.Image.Save(ms, pc_me.Image.RawFormat)
                    Dim update As New SqlClient.SqlCommand("update ms_employee set name = '" & txt_name.Text & "', email = '" & txt_email.Text &
                                                            "', password ='" & txt_password.Text & "', handphone = '" & txt_hp.Text &
                                                            "', gender = '" & txt_gender.Text & "',photo = @image where id_employee = '" & txt_id.Text & "'", koneksi)
                    update.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                    Try
                        Form_login.txt_username.Text = txt_email.Text
                        Form_menu_cashier.lbl_name.Text = txt_name.Text
                        Form_menu_cashier.st_nama.Text = "|| Nama Pengguna  =  " + txt_name.Text
                        Form_menu_chef.lbl_name.Text = txt_name.Text
                        Form_menu_chef.st_nama.Text = "|| Nama Pengguna  =  " + txt_name.Text
                        update.ExecuteNonQuery()
                        MsgBox("Data berhasil di perbarui", MsgBoxStyle.Information)
                        aksesteks(False)
                        tampildata()
                    Catch ex As Exception
                        MsgBox("data gagal di perbarui" + ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If


                If Form_welcome.cb_login_sbagai.Text = "admin" Then
                    konek_db()
                    Dim ms As New MemoryStream
                    pc_me.Image.Save(ms, pc_me.Image.RawFormat)
                    Dim update As New SqlClient.SqlCommand("update ms_admin set name = '" & txt_name.Text & "', email = '" & txt_email.Text &
                                                            "', password ='" & txt_password.Text & "', handphone = '" & txt_hp.Text &
                                                            "', gender = '" & txt_gender.Text & "',photo=@image where id_admin = '" & txt_id.Text & "'", koneksi)
                    update.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                    Try
                        Form_login.txt_username.Text = txt_email.Text
                        Form_menu_admin.lbl_nama.Text = txt_name.Text
                        Form_menu_admin.st_nama.Text = txt_name.Text
                        update.ExecuteNonQuery()
                        MsgBox("Data berhasil di perbarui", MsgBoxStyle.Information)

                        aksesteks(False)
                        tampildata()
                    Catch ex As Exception
                        MsgBox("data gagal di perbarui" + ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If
            Else
                MsgBox("ketik ulang anda salah ", MsgBoxStyle.Exclamation)
            End If
            End If



    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksesteks(True)
        txt_id.Enabled = False
        btn_edit.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form_edit_profil_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Form_welcome.cb_login_sbagai.Text = "member" Then
            Form_menu_member.Visible = True

        End If

        If Form_welcome.cb_login_sbagai.Text = "admin" Then
            Form_menu_admin.Visible = True
        End If

        If Form_welcome.cb_login_sbagai.Text = "employee" And Form_login.level = "1" Then
            Form_menu_cashier.tampil_iden()
            Form_menu_cashier.Visible = True

        End If

        If Form_welcome.cb_login_sbagai.Text = "employee" And Form_login.level = "2" Then
            Form_menu_chef.tampil_iden()
            Form_menu_chef.Visible = True

        End If
      
    End Sub

    Private Sub Form_edit_profil_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      
    End Sub

    Private Sub Form_edit_profil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_edit_profil_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
        aksesteks(False)
    End Sub

    Private Sub btn_upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload.Click
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        pc_me.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
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

    Private Sub pc_me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_me.Click
        Form_view_photo.pc_v.Image = pc_me.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub pc_lb_me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_lb_me.Click
        Form_view_photo.pc_v.Image = pc_lb_me.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
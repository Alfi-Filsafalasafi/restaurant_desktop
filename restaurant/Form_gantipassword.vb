Public Class Form_gantipassword
    Sub bersihteks()
        txt_ketik_ulang.Text = ""
        txt_pass_baru.Text = ""
        txt_pass_lama.Text = ""
        txt_username.Text = ""
    End Sub
    Sub tampildata()
        If Form_welcome.cb_login_sbagai.Text = "member" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ms_member where email = '" & Form_login.txt_username.Text & "' and password = '" & Form_login.txt_password.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Do While reader.Read
                lbl_pass.Text = reader!password
                lbl_username.Text = reader!email
                lbl_id.Text = reader!id_member

            Loop
        End If

        If Form_welcome.cb_login_sbagai.Text = "admin" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from ms_admin where email = '" & Form_login.txt_username.Text & "' and password = '" & Form_login.txt_password.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Do While reader.Read
                lbl_pass.Text = reader!password
                lbl_username.Text = reader!email
                lbl_id.Text = reader!id_admin




            Loop
        End If

        If Form_welcome.cb_login_sbagai.Text = "employee" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_ms_employee where email = '" & Form_login.txt_username.Text & "' and password = '" & Form_login.txt_password.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Do While reader.Read
                lbl_pass.Text = reader!password
                lbl_username.Text = reader!email
                lbl_id.Text = reader!id_employee
            Loop
        End If

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form_gantipassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form_menu_admin.Enabled = True
        Form_menu_cashier.Enabled = True
        Form_menu_chef.Enabled = True
        Form_menu_member.Enabled = True
    End Sub

    Private Sub Form_gantipassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_konfir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_konfir.Click
        If txt_ketik_ulang.Text = "" Or txt_pass_baru.Text = "" Or txt_pass_lama.Text = "" Or txt_username.Text = "" Then
            MsgBox("data belum lengkap ", MsgBoxStyle.Critical)
        Else
            If txt_username.Text = lbl_username.Text Then
                If txt_pass_lama.Text = lbl_pass.Text Then
                    If txt_pass_baru.Text = txt_ketik_ulang.Text Then
                        If Form_welcome.cb_login_sbagai.Text = "member" Then

                            konek_db()

                            Dim update As New SqlClient.SqlCommand("update ms_member set password ='" & txt_pass_baru.Text & "' where id_member = '" & lbl_id.Text & "'", koneksi)

                            Try
                                Form_login.txt_password.Text = txt_pass_baru.Text

                                update.ExecuteNonQuery()
                                MsgBox("Data berhasil di perbarui", MsgBoxStyle.Information)
                                bersihteks()
                                tampildata()

                            Catch ex As Exception
                                MsgBox("data gagal di perbarui" + ex.Message, MsgBoxStyle.Critical)
                            End Try
                        End If

                        If Form_welcome.cb_login_sbagai.Text = "employee" Then
                            konek_db()

                            Dim update As New SqlClient.SqlCommand("update ms_employee set  password ='" & txt_pass_baru.Text & "' where id_employee = '" & lbl_id.Text & "'", koneksi)

                            Try
                                Form_login.txt_password.Text = txt_pass_baru.Text
                                update.ExecuteNonQuery()
                                MsgBox("Data berhasil di perbarui", MsgBoxStyle.Information)
                                bersihteks()
                                tampildata()

                            Catch ex As Exception
                                MsgBox("data gagal di perbarui" + ex.Message, MsgBoxStyle.Critical)
                            End Try
                        End If


                        If Form_welcome.cb_login_sbagai.Text = "admin" Then
                            konek_db()

                            Dim update As New SqlClient.SqlCommand("update ms_admin set password ='" & txt_pass_baru.Text & "' where id_admin = '" & lbl_id.Text & "'", koneksi)

                            Try
                                Form_login.txt_password.Text = txt_pass_baru.Text
                                update.ExecuteNonQuery()
                                MsgBox("Data berhasil di perbarui", MsgBoxStyle.Information)

                                bersihteks()
                                tampildata()
                            Catch ex As Exception
                                MsgBox("data gagal di perbarui" + ex.Message, MsgBoxStyle.Critical)
                            End Try
                        End If
                    Else
                        MsgBox("ketik ulang password tidak benar", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("password lama anda tidak benar ", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("email anda tidak sesuai", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Form_gantipassword_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
        bersihteks()
    End Sub
End Class
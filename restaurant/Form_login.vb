Public Class Form_login
    Public tabel As String

    Public level As String

    Private Sub btn_masuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_masuk.Click
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from " & txt_tabel.Text & " where email = '" & txt_username.Text & "' and password ='" & txt_password.Text & "'", koneksi)

        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        reader.Read()
        Try


            If txt_tabel.Text = "ms_admin" Then
                Form_menu_admin.lbl_nama.Text = reader!name
                Form_menu_admin.st_nama.Text = "||    Nama Pengguna : " + reader!name
                Form_menu_admin.st_email.Text = "||  Email : " + reader!email
                Form_menu_admin.st_position.Text = "|| Position : Admin"
                Form_menu_admin.st_server.Text = " || Server = SQL SERVER "

                Me.Visible = False
                Form_menu_admin.Show()
            End If
            If txt_tabel.Text = "ms_employee" Then
                level = reader!id_position

                If level = "1" Then
                    Me.Visible = False
                    Form_menu_cashier.Show()
                    Form_menu_cashier.st_nama.Text = "|| Nama Pengguna = " + reader!name
                    Form_menu_cashier.st_email.Text = "|| Email = " + reader!email
                    Form_menu_cashier.st_position.Text = "|| Position = Cashier"
                    Form_menu_cashier.st_server.Text = "|| Server = SQL SERVER"
                    Form_menu_cashier.lbl_name.Text = reader!name
                    Form_menu_cashier.lbl_id_employee.Text = reader!id_employee

                End If
                If level = "2" Then
                    Form_menu_chef.lbl_name.Text = reader!name
                    Me.Visible = False
                    Form_menu_chef.Show()
                    Form_menu_chef.st_nama.Text = "|| Nama Pengguna = " + reader!name
                    Form_menu_chef.st_email.Text = "|| Email = " + reader!email
                    Form_menu_chef.st_position.Text = "|| Position = Chef"
                    Form_menu_chef.st_server.Text = "|| Server = SQL SERVER"
                    Form_menu_chef.lbl_id_employee.Text = reader!id_employee

                End If
            End If
            If txt_tabel.Text = "ms_member" Then

                Form_menu_member.lbl_name.Text = reader!name
                Form_menu_member.st_nama.Text = "|| Nama Pengguna = " + reader!name
                Form_menu_member.st_iid.Text = reader!id_member
                Form_menu_member.st_email.Text = "|| Email = " + reader!email
                Form_menu_member.st_position.Text = "|| Position = Member "
                Me.Visible = False
                Form_menu_member.Show()
                Form_order.lbl_id_member.Text = reader!id_member
                Form_history_order.lbl_id_member.Text = reader!id_member
                Form_history_order.lbl_nama.Text = reader!name
                Form_menu_member.lbl_id_member.Text = reader!id_member
            End If
        Catch ex As Exception
            MsgBox("username atau password anda salah  ", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub cb_level_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form_login_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Visible = False
        Form_welcome.Visible = True
    End Sub

    Private Sub Form_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username.TextChanged
       
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form_login_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'txt_tabel.Text = "ms_" + Form_welcome.cb_login_sbagai.Text
        txt_username.Text = ""
        txt_password.Text = ""

    End Sub

    Private Sub Form_login_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
       
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class

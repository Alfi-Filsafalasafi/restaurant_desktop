Imports System.IO
Public Class Form_daftar

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nama.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_email.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form_daftar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
        Form_welcome.Show()
        Form_login.tabel = "ms_member"
    End Sub

    Private Sub Form_daftar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub btn_daftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_daftar.Click
        If txt_nama.Text <> "" And txt_email.Text <> "" And txt_date.Text <> "" And txt_gender.Text <> "" And txt_handphone.Text <> "" And txt_password.Text <> "" And txt_photo.Text <> "" Then
            If txt_ketik.Text = txt_password.Text Then
                konek_db()
                Dim ms As New MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim tampil As New SqlClient.SqlCommand("insert into ms_member values('" & txt_nama.Text & "', '" & txt_email.Text &
                                                       "', '" & txt_password.Text & "', '" & txt_handphone.Text & "', '" & txt_gender.Text &
                                                       "', '" & Format(txt_date.Value, "yyyy-MM-dd") & "',@image)", koneksi)
                tampil.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    tampil.ExecuteNonQuery()
                    MsgBox("selamat Anda telah terdaftar,   Kebijakan dan Privasi Berlaku,  Data pribadi rentan masalah , jaga baik - baik ", MsgBoxStyle.Information)
                    Me.Close()
                    MsgBox("Silahkan Login")
                    Form_welcome.Show()
                    Form_welcome.cb_login_sbagai.Text = "member"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("ketik ulang password anda salah , silahkan ulang kembali", MsgBoxStyle.Exclamation)
            End If
           
        Else
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btn_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari.Click
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        PictureBox1.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form_view_photo.pc_v.Image = PictureBox1.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
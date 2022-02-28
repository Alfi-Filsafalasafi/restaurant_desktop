Imports System.IO
Public Class Form_rangking
    Sub reset()
        lv_member.Items.Clear()
    End Sub
    Sub bersihteks()
        lbl_nama.Text = "-"
        lbl_email.Text = "-"
        lbl_nohp.Text = "-"
        lbl_gender.Text = "-"
        pc_me.Image = Nothing

    End Sub

    Sub tampil_data()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_rangking ORDER BY jumlah_pemesanan DESC ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_member.Items.Add(i + 1)
            lv_member.Items(i).SubItems.Add(reader!id_member)
            lv_member.Items(i).SubItems.Add(reader!member)
            lv_member.Items(i).SubItems.Add(reader!jumlah_pemesanan)



            i = i + +1
        Loop
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form_rangking_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_menu_admin.Show()
    End Sub

    Private Sub Form_rangking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data_rangking.v_rangking' table. You can move, or remove it, as needed.
        Me.V_rangkingTableAdapter.Fill(Me.Data_rangking.v_rangking)

    End Sub

    Private Sub Form_rangking_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_data()
        bersihteks()
    End Sub

    Private Sub lv_member_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_member.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ms_member where id_member = '" & lv_member.SelectedItems(0).SubItems(1).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read

            lbl_nama.Text = reader!name
            lbl_email.Text = reader!email
            lbl_gender.Text = reader!gender

            lbl_nohp.Text = reader!handphone
            Dim img() As Byte
            img = reader!photo
            Dim ms As New MemoryStream(img)
            pc_me.Image = Image.FromStream(ms)
        Loop


    End Sub

    Private Sub lv_member_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_member.SelectedIndexChanged

    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        bersihteks()
        tampil_data()
    End Sub

    Private Sub pc_me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_me.Click
        Form_view_photo.pc_v.Image = pc_me.Image
        Form_view_photo.Show()
        Me.Enabled = False
    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
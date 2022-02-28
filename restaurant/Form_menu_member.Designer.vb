<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu_member
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.st_waktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_nama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.st_email = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_tanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_iid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_id_member = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.btn_ganti_pass = New System.Windows.Forms.Button()
        Me.btn_view_menuu = New System.Windows.Forms.Button()
        Me.btn_order_menu = New System.Windows.Forms.Button()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.btn_pengaturan_akun = New System.Windows.Forms.Button()
        Me.lbl_join_date = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_hp = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_jml_psn = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pc_lb_me = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.pc_lb_me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'st_waktu
        '
        Me.st_waktu.AutoSize = False
        Me.st_waktu.Name = "st_waktu"
        Me.st_waktu.Size = New System.Drawing.Size(170, 29)
        Me.st_waktu.Text = "||  Waktu :"
        Me.st_waktu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_nama
        '
        Me.st_nama.AutoSize = False
        Me.st_nama.Name = "st_nama"
        Me.st_nama.Size = New System.Drawing.Size(330, 29)
        Me.st_nama.Text = "||    Nama Pengguna :  "
        Me.st_nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 88)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(957, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 88)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Member OF SMK RESTAURANT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_name
        '
        Me.lbl_name.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_name.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(183, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(710, 88)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Pelanggan"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 88)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome ,"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'st_email
        '
        Me.st_email.AutoSize = False
        Me.st_email.Name = "st_email"
        Me.st_email.Size = New System.Drawing.Size(250, 29)
        Me.st_email.Text = "||  Email :  "
        Me.st_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_tanggal
        '
        Me.st_tanggal.AutoSize = False
        Me.st_tanggal.Name = "st_tanggal"
        Me.st_tanggal.Size = New System.Drawing.Size(185, 29)
        Me.st_tanggal.Text = "||  Tanggal :"
        Me.st_tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_position
        '
        Me.st_position.AutoSize = False
        Me.st_position.Name = "st_position"
        Me.st_position.Size = New System.Drawing.Size(180, 29)
        Me.st_position.Text = "|| Position :"
        Me.st_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_id, Me.st_iid, Me.st_nama, Me.st_email, Me.st_position, Me.st_tanggal, Me.st_waktu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 34)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_id
        '
        Me.st_id.AutoSize = False
        Me.st_id.Name = "st_id"
        Me.st_id.Size = New System.Drawing.Size(95, 29)
        Me.st_id.Text = "|| ID Member :  "
        Me.st_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_iid
        '
        Me.st_iid.AutoSize = False
        Me.st_iid.Name = "st_iid"
        Me.st_iid.Size = New System.Drawing.Size(120, 29)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbl_id_member
        '
        Me.lbl_id_member.AutoSize = True
        Me.lbl_id_member.Location = New System.Drawing.Point(128, 359)
        Me.lbl_id_member.Name = "lbl_id_member"
        Me.lbl_id_member.Size = New System.Drawing.Size(13, 13)
        Me.lbl_id_member.TabIndex = 18
        Me.lbl_id_member.Text = "0"
        Me.lbl_id_member.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.btn_log_out)
        Me.Panel2.Controls.Add(Me.btn_ganti_pass)
        Me.Panel2.Controls.Add(Me.btn_view_menuu)
        Me.Panel2.Controls.Add(Me.btn_order_menu)
        Me.Panel2.Controls.Add(Me.btn_history)
        Me.Panel2.Controls.Add(Me.btn_pengaturan_akun)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 619)
        Me.Panel2.TabIndex = 19
        '
        'btn_log_out
        '
        Me.btn_log_out.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_log_out.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btn_log_out.FlatAppearance.BorderSize = 0
        Me.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.Image = Global.restaurant.My.Resources.Resources.stand_by
        Me.btn_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_log_out.Location = New System.Drawing.Point(0, 282)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Padding = New System.Windows.Forms.Padding(20, 0, 142, 0)
        Me.btn_log_out.Size = New System.Drawing.Size(285, 55)
        Me.btn_log_out.TabIndex = 19
        Me.btn_log_out.Text = "Log Out"
        Me.btn_log_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_log_out.UseVisualStyleBackColor = False
        '
        'btn_ganti_pass
        '
        Me.btn_ganti_pass.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_ganti_pass.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btn_ganti_pass.FlatAppearance.BorderSize = 0
        Me.btn_ganti_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ganti_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ganti_pass.Image = Global.restaurant.My.Resources.Resources.lock
        Me.btn_ganti_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ganti_pass.Location = New System.Drawing.Point(1, 219)
        Me.btn_ganti_pass.Name = "btn_ganti_pass"
        Me.btn_ganti_pass.Padding = New System.Windows.Forms.Padding(20, 0, 84, 0)
        Me.btn_ganti_pass.Size = New System.Drawing.Size(285, 55)
        Me.btn_ganti_pass.TabIndex = 18
        Me.btn_ganti_pass.Text = "Ganti Password"
        Me.btn_ganti_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ganti_pass.UseVisualStyleBackColor = False
        '
        'btn_view_menuu
        '
        Me.btn_view_menuu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_view_menuu.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btn_view_menuu.FlatAppearance.BorderSize = 0
        Me.btn_view_menuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_menuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_menuu.Image = Global.restaurant.My.Resources.Resources.burger
        Me.btn_view_menuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_view_menuu.Location = New System.Drawing.Point(0, 11)
        Me.btn_view_menuu.Name = "btn_view_menuu"
        Me.btn_view_menuu.Padding = New System.Windows.Forms.Padding(20, 0, 69, 0)
        Me.btn_view_menuu.Size = New System.Drawing.Size(285, 55)
        Me.btn_view_menuu.TabIndex = 16
        Me.btn_view_menuu.Text = "Lihat Daftar Menu"
        Me.btn_view_menuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view_menuu.UseVisualStyleBackColor = False
        '
        'btn_order_menu
        '
        Me.btn_order_menu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_order_menu.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btn_order_menu.FlatAppearance.BorderSize = 0
        Me.btn_order_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_menu.Image = Global.restaurant.My.Resources.Resources.box
        Me.btn_order_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_order_menu.Location = New System.Drawing.Point(0, 63)
        Me.btn_order_menu.Name = "btn_order_menu"
        Me.btn_order_menu.Padding = New System.Windows.Forms.Padding(20, 0, 108, 0)
        Me.btn_order_menu.Size = New System.Drawing.Size(285, 55)
        Me.btn_order_menu.TabIndex = 17
        Me.btn_order_menu.Text = "Pesan Menu"
        Me.btn_order_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_order_menu.UseVisualStyleBackColor = False
        '
        'btn_history
        '
        Me.btn_history.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_history.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btn_history.FlatAppearance.BorderSize = 0
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_history.Image = Global.restaurant.My.Resources.Resources.history
        Me.btn_history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_history.Location = New System.Drawing.Point(0, 113)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Padding = New System.Windows.Forms.Padding(20, 0, 48, 0)
        Me.btn_history.Size = New System.Drawing.Size(285, 55)
        Me.btn_history.TabIndex = 14
        Me.btn_history.Text = "Riwayat Pemesanan"
        Me.btn_history.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_history.UseVisualStyleBackColor = False
        '
        'btn_pengaturan_akun
        '
        Me.btn_pengaturan_akun.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_pengaturan_akun.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btn_pengaturan_akun.FlatAppearance.BorderSize = 0
        Me.btn_pengaturan_akun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pengaturan_akun.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pengaturan_akun.Image = Global.restaurant.My.Resources.Resources.user_profiles
        Me.btn_pengaturan_akun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pengaturan_akun.Location = New System.Drawing.Point(0, 167)
        Me.btn_pengaturan_akun.Name = "btn_pengaturan_akun"
        Me.btn_pengaturan_akun.Padding = New System.Windows.Forms.Padding(20, 0, 72, 0)
        Me.btn_pengaturan_akun.Size = New System.Drawing.Size(285, 55)
        Me.btn_pengaturan_akun.TabIndex = 15
        Me.btn_pengaturan_akun.Text = "Pengaturan Akun"
        Me.btn_pengaturan_akun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pengaturan_akun.UseVisualStyleBackColor = False
        '
        'lbl_join_date
        '
        Me.lbl_join_date.AutoSize = True
        Me.lbl_join_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_join_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_join_date.Location = New System.Drawing.Point(800, 226)
        Me.lbl_join_date.Name = "lbl_join_date"
        Me.lbl_join_date.Size = New System.Drawing.Size(14, 20)
        Me.lbl_join_date.TabIndex = 66
        Me.lbl_join_date.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(938, 194)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 20)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(800, 194)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 20)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Join Date"
        '
        'lbl_hp
        '
        Me.lbl_hp.AutoSize = True
        Me.lbl_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hp.ForeColor = System.Drawing.Color.Black
        Me.lbl_hp.Location = New System.Drawing.Point(800, 142)
        Me.lbl_hp.Name = "lbl_hp"
        Me.lbl_hp.Size = New System.Drawing.Size(14, 20)
        Me.lbl_hp.TabIndex = 59
        Me.lbl_hp.Text = "-"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.ForeColor = System.Drawing.Color.Black
        Me.lbl_gender.Location = New System.Drawing.Point(453, 226)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(14, 20)
        Me.lbl_gender.TabIndex = 58
        Me.lbl_gender.Text = "-"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.Black
        Me.lbl_email.Location = New System.Drawing.Point(450, 142)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(14, 20)
        Me.lbl_email.TabIndex = 57
        Me.lbl_email.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(938, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 20)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(525, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 20)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(525, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 20)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(800, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Handphone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(453, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(450, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Email"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(454, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 1)
        Me.Panel3.TabIndex = 67
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(457, 247)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 1)
        Me.Panel4.TabIndex = 68
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(804, 167)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 1)
        Me.Panel5.TabIndex = 68
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Location = New System.Drawing.Point(804, 247)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 1)
        Me.Panel6.TabIndex = 69
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lbl_jml_psn)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(1145, 104)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(191, 145)
        Me.Panel7.TabIndex = 70
        '
        'lbl_jml_psn
        '
        Me.lbl_jml_psn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_jml_psn.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jml_psn.ForeColor = System.Drawing.Color.Black
        Me.lbl_jml_psn.Location = New System.Drawing.Point(0, 62)
        Me.lbl_jml_psn.Name = "lbl_jml_psn"
        Me.lbl_jml_psn.Size = New System.Drawing.Size(189, 81)
        Me.lbl_jml_psn.TabIndex = 71
        Me.lbl_jml_psn.Text = "-"
        Me.lbl_jml_psn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label4.Size = New System.Drawing.Size(189, 49)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Jumlah Pemesanan pada tahun ini"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pc_lb_me
        '
        Me.pc_lb_me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pc_lb_me.Location = New System.Drawing.Point(314, 107)
        Me.pc_lb_me.Name = "pc_lb_me"
        Me.pc_lb_me.Size = New System.Drawing.Size(119, 157)
        Me.pc_lb_me.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pc_lb_me.TabIndex = 46
        Me.pc_lb_me.TabStop = False
        '
        'Form_menu_member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbl_join_date)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lbl_hp)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pc_lb_me)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_id_member)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form_menu_member"
        Me.Text = "SMK RESTAURANT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.pc_lb_me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents st_waktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_nama As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents st_email As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_tanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_pengaturan_akun As System.Windows.Forms.Button
    Friend WithEvents st_position As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btn_history As System.Windows.Forms.Button
    Friend WithEvents btn_order_menu As System.Windows.Forms.Button
    Friend WithEvents btn_view_menuu As System.Windows.Forms.Button
    Friend WithEvents st_id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents st_iid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_id_member As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_ganti_pass As System.Windows.Forms.Button
    Friend WithEvents lbl_join_date As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbl_hp As System.Windows.Forms.Label
    Friend WithEvents lbl_gender As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pc_lb_me As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbl_jml_psn As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_log_out As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu_cashier
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
        Me.st_server = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_id_employee = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.st_email = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_tanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.btn_ganti_pass = New System.Windows.Forms.Button()
        Me.btn_payment = New System.Windows.Forms.Button()
        Me.btn_pengaturan_akun = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_gaji = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbl_pendapatan = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbl_pdp_1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_pdp_2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pc_lb_me = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc_lb_me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'st_waktu
        '
        Me.st_waktu.AutoSize = False
        Me.st_waktu.ForeColor = System.Drawing.Color.White
        Me.st_waktu.Name = "st_waktu"
        Me.st_waktu.Size = New System.Drawing.Size(170, 29)
        Me.st_waktu.Text = "||  Waktu :"
        Me.st_waktu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_nama
        '
        Me.st_nama.AutoSize = False
        Me.st_nama.ForeColor = System.Drawing.Color.White
        Me.st_nama.Name = "st_nama"
        Me.st_nama.Size = New System.Drawing.Size(330, 29)
        Me.st_nama.Text = "||    Nama Pengguna :"
        Me.st_nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_server
        '
        Me.st_server.AutoSize = False
        Me.st_server.ForeColor = System.Drawing.Color.White
        Me.st_server.Name = "st_server"
        Me.st_server.Size = New System.Drawing.Size(200, 29)
        Me.st_server.Text = "|| Server :"
        Me.st_server.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.lbl_id_employee)
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
        'lbl_id_employee
        '
        Me.lbl_id_employee.AutoSize = True
        Me.lbl_id_employee.Location = New System.Drawing.Point(499, 43)
        Me.lbl_id_employee.Name = "lbl_id_employee"
        Me.lbl_id_employee.Size = New System.Drawing.Size(82, 13)
        Me.lbl_id_employee.TabIndex = 16
        Me.lbl_id_employee.Text = "lbl_id_employee"
        Me.lbl_id_employee.Visible = False
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(936, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(426, 88)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CASHIER OF SMK RESTAURANT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_name
        '
        Me.lbl_name.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_name.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(183, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(707, 88)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Jeneng Cashier"
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
        Me.st_email.ForeColor = System.Drawing.Color.White
        Me.st_email.Name = "st_email"
        Me.st_email.Size = New System.Drawing.Size(250, 29)
        Me.st_email.Text = "||  Email :"
        Me.st_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_tanggal
        '
        Me.st_tanggal.AutoSize = False
        Me.st_tanggal.ForeColor = System.Drawing.Color.White
        Me.st_tanggal.Name = "st_tanggal"
        Me.st_tanggal.Size = New System.Drawing.Size(185, 29)
        Me.st_tanggal.Text = "||  Tanggal :"
        Me.st_tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_position
        '
        Me.st_position.AutoSize = False
        Me.st_position.ForeColor = System.Drawing.Color.White
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nama, Me.st_email, Me.st_position, Me.st_server, Me.st_tanggal, Me.st_waktu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 34)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.btn_log_out)
        Me.Panel2.Controls.Add(Me.btn_ganti_pass)
        Me.Panel2.Controls.Add(Me.btn_payment)
        Me.Panel2.Controls.Add(Me.btn_pengaturan_akun)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 619)
        Me.Panel2.TabIndex = 16
        '
        'btn_log_out
        '
        Me.btn_log_out.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_log_out.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_log_out.FlatAppearance.BorderSize = 0
        Me.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.ForeColor = System.Drawing.Color.White
        Me.btn_log_out.Image = Global.restaurant.My.Resources.Resources.stand_by
        Me.btn_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_log_out.Location = New System.Drawing.Point(0, 150)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Padding = New System.Windows.Forms.Padding(20, 0, 115, 0)
        Me.btn_log_out.Size = New System.Drawing.Size(255, 50)
        Me.btn_log_out.TabIndex = 17
        Me.btn_log_out.Text = "Log Out"
        Me.btn_log_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_log_out.UseVisualStyleBackColor = False
        '
        'btn_ganti_pass
        '
        Me.btn_ganti_pass.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_ganti_pass.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_ganti_pass.FlatAppearance.BorderSize = 0
        Me.btn_ganti_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ganti_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ganti_pass.ForeColor = System.Drawing.Color.White
        Me.btn_ganti_pass.Image = Global.restaurant.My.Resources.Resources.lock
        Me.btn_ganti_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ganti_pass.Location = New System.Drawing.Point(0, 100)
        Me.btn_ganti_pass.Name = "btn_ganti_pass"
        Me.btn_ganti_pass.Padding = New System.Windows.Forms.Padding(20, 0, 57, 0)
        Me.btn_ganti_pass.Size = New System.Drawing.Size(255, 50)
        Me.btn_ganti_pass.TabIndex = 16
        Me.btn_ganti_pass.Text = "Ganti Password"
        Me.btn_ganti_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ganti_pass.UseVisualStyleBackColor = False
        '
        'btn_payment
        '
        Me.btn_payment.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_payment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_payment.FlatAppearance.BorderSize = 0
        Me.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payment.ForeColor = System.Drawing.Color.White
        Me.btn_payment.Image = Global.restaurant.My.Resources.Resources.user_profiles
        Me.btn_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_payment.Location = New System.Drawing.Point(0, 50)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_payment.Size = New System.Drawing.Size(255, 50)
        Me.btn_payment.TabIndex = 14
        Me.btn_payment.Text = "Pengaturan Akun"
        Me.btn_payment.UseVisualStyleBackColor = False
        '
        'btn_pengaturan_akun
        '
        Me.btn_pengaturan_akun.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_pengaturan_akun.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_pengaturan_akun.FlatAppearance.BorderSize = 0
        Me.btn_pengaturan_akun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pengaturan_akun.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pengaturan_akun.ForeColor = System.Drawing.Color.White
        Me.btn_pengaturan_akun.Image = Global.restaurant.My.Resources.Resources.pay
        Me.btn_pengaturan_akun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pengaturan_akun.Location = New System.Drawing.Point(0, 0)
        Me.btn_pengaturan_akun.Name = "btn_pengaturan_akun"
        Me.btn_pengaturan_akun.Padding = New System.Windows.Forms.Padding(20, 0, 80, 0)
        Me.btn_pengaturan_akun.Size = New System.Drawing.Size(255, 50)
        Me.btn_pengaturan_akun.TabIndex = 15
        Me.btn_pengaturan_akun.Text = "Pembayaran"
        Me.btn_pengaturan_akun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pengaturan_akun.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lbl_gaji)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(1111, 110)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(207, 145)
        Me.Panel7.TabIndex = 88
        '
        'lbl_gaji
        '
        Me.lbl_gaji.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_gaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gaji.ForeColor = System.Drawing.Color.Black
        Me.lbl_gaji.Location = New System.Drawing.Point(0, 62)
        Me.lbl_gaji.Name = "lbl_gaji"
        Me.lbl_gaji.Size = New System.Drawing.Size(205, 81)
        Me.lbl_gaji.TabIndex = 71
        Me.lbl_gaji.Text = "4.020.000"
        Me.lbl_gaji.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 49)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Gaji Anda Sementara Ini"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Location = New System.Drawing.Point(770, 253)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 1)
        Me.Panel6.TabIndex = 87
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(770, 173)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 1)
        Me.Panel5.TabIndex = 85
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(423, 253)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 1)
        Me.Panel4.TabIndex = 86
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(420, 173)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 1)
        Me.Panel3.TabIndex = 84
        '
        'lbl_join_date
        '
        Me.lbl_join_date.AutoSize = True
        Me.lbl_join_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_join_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_join_date.Location = New System.Drawing.Point(766, 232)
        Me.lbl_join_date.Name = "lbl_join_date"
        Me.lbl_join_date.Size = New System.Drawing.Size(14, 20)
        Me.lbl_join_date.TabIndex = 83
        Me.lbl_join_date.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(904, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 20)
        Me.Label20.TabIndex = 82
        Me.Label20.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(766, 200)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 20)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "Join Date"
        '
        'lbl_hp
        '
        Me.lbl_hp.AutoSize = True
        Me.lbl_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hp.ForeColor = System.Drawing.Color.Black
        Me.lbl_hp.Location = New System.Drawing.Point(766, 148)
        Me.lbl_hp.Name = "lbl_hp"
        Me.lbl_hp.Size = New System.Drawing.Size(14, 20)
        Me.lbl_hp.TabIndex = 80
        Me.lbl_hp.Text = "-"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.ForeColor = System.Drawing.Color.Black
        Me.lbl_gender.Location = New System.Drawing.Point(419, 232)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(14, 20)
        Me.lbl_gender.TabIndex = 79
        Me.lbl_gender.Text = "-"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.Black
        Me.lbl_email.Location = New System.Drawing.Point(416, 148)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(14, 20)
        Me.lbl_email.TabIndex = 78
        Me.lbl_email.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(904, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 20)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(491, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 20)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(491, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 20)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(766, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Handphone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(419, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(416, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Email"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.PictureBox4)
        Me.Panel8.Controls.Add(Me.lbl_pendapatan)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Location = New System.Drawing.Point(280, 302)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(360, 192)
        Me.Panel8.TabIndex = 89
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.restaurant.My.Resources.Resources.user
        Me.PictureBox4.Location = New System.Drawing.Point(7, 47)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(86, 103)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 72
        Me.PictureBox4.TabStop = False
        '
        'lbl_pendapatan
        '
        Me.lbl_pendapatan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_pendapatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pendapatan.ForeColor = System.Drawing.Color.Black
        Me.lbl_pendapatan.Location = New System.Drawing.Point(0, 85)
        Me.lbl_pendapatan.Name = "lbl_pendapatan"
        Me.lbl_pendapatan.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lbl_pendapatan.Size = New System.Drawing.Size(358, 105)
        Me.lbl_pendapatan.TabIndex = 71
        Me.lbl_pendapatan.Text = "909000"
        Me.lbl_pendapatan.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Label9.Size = New System.Drawing.Size(358, 105)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Jumlah Pendapatan Hari Ini"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.lbl_pdp_1)
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Location = New System.Drawing.Point(659, 302)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(320, 192)
        Me.Panel9.TabIndex = 90
        '
        'lbl_pdp_1
        '
        Me.lbl_pdp_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pdp_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_pdp_1.Location = New System.Drawing.Point(103, 87)
        Me.lbl_pdp_1.Name = "lbl_pdp_1"
        Me.lbl_pdp_1.Size = New System.Drawing.Size(212, 75)
        Me.lbl_pdp_1.TabIndex = 74
        Me.lbl_pdp_1.Text = "-"
        Me.lbl_pdp_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.restaurant.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(7, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(114, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label5.Size = New System.Drawing.Size(193, 67)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Jumlah Pendapatan 1 Hari Yang Lalu"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.PictureBox2)
        Me.Panel10.Controls.Add(Me.lbl_pdp_2)
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.Location = New System.Drawing.Point(998, 303)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(320, 192)
        Me.Panel10.TabIndex = 91
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(7, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 103)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'lbl_pdp_2
        '
        Me.lbl_pdp_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pdp_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_pdp_2.Location = New System.Drawing.Point(103, 85)
        Me.lbl_pdp_2.Name = "lbl_pdp_2"
        Me.lbl_pdp_2.Size = New System.Drawing.Size(212, 75)
        Me.lbl_pdp_2.TabIndex = 71
        Me.lbl_pdp_2.Text = "-"
        Me.lbl_pdp_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(113, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label7.Size = New System.Drawing.Size(193, 67)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Jumlah Pendapatan 2 Hari Yang Lalu"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pc_lb_me
        '
        Me.pc_lb_me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pc_lb_me.Location = New System.Drawing.Point(280, 113)
        Me.pc_lb_me.Name = "pc_lb_me"
        Me.pc_lb_me.Size = New System.Drawing.Size(119, 157)
        Me.pc_lb_me.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pc_lb_me.TabIndex = 71
        Me.pc_lb_me.TabStop = False
        '
        'Form_menu_cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
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
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form_menu_cashier"
        Me.Text = "SMK RESTAURANT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc_lb_me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents st_waktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_nama As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_server As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents st_email As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_tanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_pengaturan_akun As System.Windows.Forms.Button
    Friend WithEvents st_position As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btn_payment As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_id_employee As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbl_gaji As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_pendapatan As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_pdp_2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_pdp_1 As System.Windows.Forms.Label
    Friend WithEvents btn_ganti_pass As System.Windows.Forms.Button
    Friend WithEvents btn_log_out As System.Windows.Forms.Button
End Class

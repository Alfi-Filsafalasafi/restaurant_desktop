<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu_admin
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_nama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_email = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_server = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_tanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_waktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.btn_ganti_pass = New System.Windows.Forms.Button()
        Me.btn_pengaturan_akun = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_manage_employee = New System.Windows.Forms.Button()
        Me.btn_member = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_report_transaksi = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_pengunjung = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_employee = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_member = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbl_pendapatan = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chart_laporan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_nama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 88)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(925, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(437, 88)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ADMIN OF SMK RESTAURANT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nama
        '
        Me.lbl_nama.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_nama.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(183, 0)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(680, 88)
        Me.lbl_nama.TabIndex = 1
        Me.lbl_nama.Text = "Jeneng Admine"
        Me.lbl_nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(543, 422)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(236, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Grafik penjualan selama 7 hari"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_nama
        '
        Me.st_nama.AutoSize = False
        Me.st_nama.ForeColor = System.Drawing.Color.White
        Me.st_nama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.st_nama.Name = "st_nama"
        Me.st_nama.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.st_nama.Size = New System.Drawing.Size(330, 29)
        Me.st_nama.Text = " Nama Pengguna :"
        Me.st_nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'st_position
        '
        Me.st_position.AutoSize = False
        Me.st_position.ForeColor = System.Drawing.Color.White
        Me.st_position.Name = "st_position"
        Me.st_position.Size = New System.Drawing.Size(180, 29)
        Me.st_position.Text = "|| Position :"
        Me.st_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'st_tanggal
        '
        Me.st_tanggal.AutoSize = False
        Me.st_tanggal.ForeColor = System.Drawing.Color.White
        Me.st_tanggal.Name = "st_tanggal"
        Me.st_tanggal.Size = New System.Drawing.Size(185, 29)
        Me.st_tanggal.Text = "||  Tanggal :"
        Me.st_tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.btn_log_out)
        Me.TabPage1.Controls.Add(Me.btn_ganti_pass)
        Me.TabPage1.Controls.Add(Me.btn_pengaturan_akun)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1354, 78)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pengaturan"
        '
        'btn_log_out
        '
        Me.btn_log_out.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_log_out.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_log_out.FlatAppearance.BorderSize = 2
        Me.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.Image = Global.restaurant.My.Resources.Resources.stand_by
        Me.btn_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_log_out.Location = New System.Drawing.Point(363, 3)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_log_out.Size = New System.Drawing.Size(125, 72)
        Me.btn_log_out.TabIndex = 2
        Me.btn_log_out.Text = "Log Out"
        Me.btn_log_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_log_out.UseVisualStyleBackColor = False
        '
        'btn_ganti_pass
        '
        Me.btn_ganti_pass.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_ganti_pass.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_ganti_pass.FlatAppearance.BorderSize = 2
        Me.btn_ganti_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ganti_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ganti_pass.Image = Global.restaurant.My.Resources.Resources.lock
        Me.btn_ganti_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ganti_pass.Location = New System.Drawing.Point(188, 3)
        Me.btn_ganti_pass.Name = "btn_ganti_pass"
        Me.btn_ganti_pass.Padding = New System.Windows.Forms.Padding(10, 0, 7, 0)
        Me.btn_ganti_pass.Size = New System.Drawing.Size(175, 72)
        Me.btn_ganti_pass.TabIndex = 1
        Me.btn_ganti_pass.Text = "Ganti Password"
        Me.btn_ganti_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ganti_pass.UseVisualStyleBackColor = False
        '
        'btn_pengaturan_akun
        '
        Me.btn_pengaturan_akun.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_pengaturan_akun.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_pengaturan_akun.FlatAppearance.BorderSize = 2
        Me.btn_pengaturan_akun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pengaturan_akun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pengaturan_akun.Image = Global.restaurant.My.Resources.Resources.user_profiles
        Me.btn_pengaturan_akun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pengaturan_akun.Location = New System.Drawing.Point(3, 3)
        Me.btn_pengaturan_akun.Name = "btn_pengaturan_akun"
        Me.btn_pengaturan_akun.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_pengaturan_akun.Size = New System.Drawing.Size(185, 72)
        Me.btn_pengaturan_akun.TabIndex = 0
        Me.btn_pengaturan_akun.Text = "Pengaturan Akun"
        Me.btn_pengaturan_akun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pengaturan_akun.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 88)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1362, 109)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_menu)
        Me.TabPage2.Controls.Add(Me.btn_manage_employee)
        Me.TabPage2.Controls.Add(Me.btn_member)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1354, 78)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manajemen Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_menu.FlatAppearance.BorderSize = 2
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.Color.White
        Me.btn_menu.Image = Global.restaurant.My.Resources.Resources.food__1_
        Me.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu.Location = New System.Drawing.Point(383, 3)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Padding = New System.Windows.Forms.Padding(10, 0, 15, 0)
        Me.btn_menu.Size = New System.Drawing.Size(172, 72)
        Me.btn_menu.TabIndex = 6
        Me.btn_menu.Text = "Manage Menu"
        Me.btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'btn_manage_employee
        '
        Me.btn_manage_employee.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_manage_employee.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_manage_employee.FlatAppearance.BorderSize = 2
        Me.btn_manage_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manage_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manage_employee.ForeColor = System.Drawing.Color.White
        Me.btn_manage_employee.Image = Global.restaurant.My.Resources.Resources.leader
        Me.btn_manage_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_manage_employee.Location = New System.Drawing.Point(188, 3)
        Me.btn_manage_employee.Name = "btn_manage_employee"
        Me.btn_manage_employee.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_manage_employee.Size = New System.Drawing.Size(195, 72)
        Me.btn_manage_employee.TabIndex = 3
        Me.btn_manage_employee.Text = "Manage Employee"
        Me.btn_manage_employee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_manage_employee.UseVisualStyleBackColor = False
        '
        'btn_member
        '
        Me.btn_member.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_member.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_member.FlatAppearance.BorderSize = 2
        Me.btn_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_member.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_member.ForeColor = System.Drawing.Color.White
        Me.btn_member.Image = Global.restaurant.My.Resources.Resources.user_1_
        Me.btn_member.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_member.Location = New System.Drawing.Point(3, 3)
        Me.btn_member.Name = "btn_member"
        Me.btn_member.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_member.Size = New System.Drawing.Size(185, 72)
        Me.btn_member.TabIndex = 4
        Me.btn_member.Text = "Manage Member"
        Me.btn_member.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_member.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.btn_report_transaksi)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1354, 78)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Laporan"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.restaurant.My.Resources.Resources.trophy
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(428, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button2.Size = New System.Drawing.Size(208, 72)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Rangking Pelanggan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.restaurant.My.Resources.Resources.product
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(188, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button1.Size = New System.Drawing.Size(240, 72)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Grafik Makanan Minuman"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_report_transaksi
        '
        Me.btn_report_transaksi.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_report_transaksi.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_report_transaksi.FlatAppearance.BorderSize = 2
        Me.btn_report_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report_transaksi.ForeColor = System.Drawing.Color.White
        Me.btn_report_transaksi.Image = Global.restaurant.My.Resources.Resources.support
        Me.btn_report_transaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_report_transaksi.Location = New System.Drawing.Point(3, 3)
        Me.btn_report_transaksi.Name = "btn_report_transaksi"
        Me.btn_report_transaksi.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_report_transaksi.Size = New System.Drawing.Size(185, 72)
        Me.btn_report_transaksi.TabIndex = 5
        Me.btn_report_transaksi.Text = "Angka Pelanggan"
        Me.btn_report_transaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_report_transaksi.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Controls.Add(Me.lbl_pengunjung)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(83, 231)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(340, 150)
        Me.Panel7.TabIndex = 71
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.restaurant.My.Resources.Resources.buyer
        Me.PictureBox1.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'lbl_pengunjung
        '
        Me.lbl_pengunjung.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pengunjung.ForeColor = System.Drawing.Color.Black
        Me.lbl_pengunjung.Location = New System.Drawing.Point(127, 67)
        Me.lbl_pengunjung.Name = "lbl_pengunjung"
        Me.lbl_pengunjung.Size = New System.Drawing.Size(201, 44)
        Me.lbl_pengunjung.TabIndex = 71
        Me.lbl_pengunjung.Text = "-"
        Me.lbl_pengunjung.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Label4.Size = New System.Drawing.Size(338, 57)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Jumlah Pengunjung Hari Ini"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lbl_employee)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(500, 231)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 150)
        Me.Panel2.TabIndex = 73
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant.My.Resources.Resources.cooking__1_
        Me.PictureBox2.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 110)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'lbl_employee
        '
        Me.lbl_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_employee.ForeColor = System.Drawing.Color.Black
        Me.lbl_employee.Location = New System.Drawing.Point(130, 67)
        Me.lbl_employee.Name = "lbl_employee"
        Me.lbl_employee.Size = New System.Drawing.Size(192, 44)
        Me.lbl_employee.TabIndex = 71
        Me.lbl_employee.Text = "-"
        Me.lbl_employee.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.Label5.Size = New System.Drawing.Size(338, 57)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Jumlah Employee"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.lbl_member)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(920, 230)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 150)
        Me.Panel3.TabIndex = 74
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.restaurant.My.Resources.Resources.target
        Me.PictureBox3.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 110)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 72
        Me.PictureBox3.TabStop = False
        '
        'lbl_member
        '
        Me.lbl_member.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_member.ForeColor = System.Drawing.Color.Black
        Me.lbl_member.Location = New System.Drawing.Point(135, 67)
        Me.lbl_member.Name = "lbl_member"
        Me.lbl_member.Size = New System.Drawing.Size(184, 45)
        Me.lbl_member.TabIndex = 71
        Me.lbl_member.Text = "-"
        Me.lbl_member.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.Label7.Size = New System.Drawing.Size(338, 58)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Jumlah Member"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.lbl_pendapatan)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(83, 434)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(418, 219)
        Me.Panel4.TabIndex = 73
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.restaurant.My.Resources.Resources.wage
        Me.PictureBox4.Location = New System.Drawing.Point(24, 42)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 110)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 72
        Me.PictureBox4.TabStop = False
        '
        'lbl_pendapatan
        '
        Me.lbl_pendapatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pendapatan.ForeColor = System.Drawing.Color.Black
        Me.lbl_pendapatan.Location = New System.Drawing.Point(140, 103)
        Me.lbl_pendapatan.Name = "lbl_pendapatan"
        Me.lbl_pendapatan.Size = New System.Drawing.Size(249, 66)
        Me.lbl_pendapatan.TabIndex = 71
        Me.lbl_pendapatan.Text = "909000"
        Me.lbl_pendapatan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.Label9.Size = New System.Drawing.Size(416, 129)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Jumlah Pendapatan Hari Ini"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chart_laporan
        '
        ChartArea1.Name = "ChartArea1"
        Me.chart_laporan.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chart_laporan.Legends.Add(Legend1)
        Me.chart_laporan.Location = New System.Drawing.Point(547, 453)
        Me.chart_laporan.Name = "chart_laporan"
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Jumlah Pendapatan"
        Me.chart_laporan.Series.Add(Series1)
        Me.chart_laporan.Size = New System.Drawing.Size(713, 200)
        Me.chart_laporan.TabIndex = 75
        Me.chart_laporan.Text = "Chart1"
        '
        'Form_menu_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.chart_laporan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_menu_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_laporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_nama As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_email As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_position As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_server As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_tanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_waktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btn_ganti_pass As System.Windows.Forms.Button
    Friend WithEvents btn_pengaturan_akun As System.Windows.Forms.Button
    Friend WithEvents btn_manage_employee As System.Windows.Forms.Button
    Friend WithEvents btn_member As System.Windows.Forms.Button
    Friend WithEvents btn_report_transaksi As System.Windows.Forms.Button
    Friend WithEvents btn_menu As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_pengunjung As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_employee As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_member As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_pendapatan As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chart_laporan As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btn_log_out As System.Windows.Forms.Button
End Class

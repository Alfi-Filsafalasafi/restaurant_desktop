<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu_tanpa_nama
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_daftar = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_refresh_makanan = New System.Windows.Forms.Button()
        Me.txt_cari_makanan = New System.Windows.Forms.TextBox()
        Me.lv_makanan = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cari_minuman = New System.Windows.Forms.Button()
        Me.txt_cari_minuman = New System.Windows.Forms.TextBox()
        Me.lv_minuman = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.picture = New System.Windows.Forms.PictureBox()
        Me.lbl_stok = New System.Windows.Forms.Label()
        Me.lbl_harga = New System.Windows.Forms.Label()
        Me.lbl_deskripsi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_klik = New System.Windows.Forms.Button()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.btn_daftar)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 85)
        Me.Panel1.TabIndex = 7
        '
        'btn_daftar
        '
        Me.btn_daftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_daftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_daftar.ForeColor = System.Drawing.Color.White
        Me.btn_daftar.Location = New System.Drawing.Point(1145, 26)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(187, 37)
        Me.btn_daftar.TabIndex = 3
        Me.btn_daftar.Text = "Daftar Sebagai Member"
        Me.btn_daftar.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(1035, 26)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(104, 37)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(535, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(478, 85)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Punya Akun Member ?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 85)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang di SMK RESTAURANT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_refresh_makanan)
        Me.GroupBox1.Controls.Add(Me.txt_cari_makanan)
        Me.GroupBox1.Controls.Add(Me.lv_makanan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 607)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Makanan"
        '
        'btn_refresh_makanan
        '
        Me.btn_refresh_makanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh_makanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh_makanan.Location = New System.Drawing.Point(332, 34)
        Me.btn_refresh_makanan.Name = "btn_refresh_makanan"
        Me.btn_refresh_makanan.Size = New System.Drawing.Size(75, 35)
        Me.btn_refresh_makanan.TabIndex = 3
        Me.btn_refresh_makanan.Text = "Refresh"
        Me.btn_refresh_makanan.UseVisualStyleBackColor = True
        '
        'txt_cari_makanan
        '
        Me.txt_cari_makanan.Location = New System.Drawing.Point(21, 37)
        Me.txt_cari_makanan.Name = "txt_cari_makanan"
        Me.txt_cari_makanan.Size = New System.Drawing.Size(291, 26)
        Me.txt_cari_makanan.TabIndex = 2
        '
        'lv_makanan
        '
        Me.lv_makanan.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lv_makanan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lv_makanan.ForeColor = System.Drawing.Color.White
        Me.lv_makanan.FullRowSelect = True
        Me.lv_makanan.GridLines = True
        Me.lv_makanan.Location = New System.Drawing.Point(21, 77)
        Me.lv_makanan.Name = "lv_makanan"
        Me.lv_makanan.Size = New System.Drawing.Size(386, 510)
        Me.lv_makanan.TabIndex = 0
        Me.lv_makanan.UseCompatibleStateImageBehavior = False
        Me.lv_makanan.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nomor"
        Me.ColumnHeader1.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Makanan"
        Me.ColumnHeader2.Width = 275
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_cari_minuman)
        Me.GroupBox2.Controls.Add(Me.txt_cari_minuman)
        Me.GroupBox2.Controls.Add(Me.lv_minuman)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(911, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 607)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar Minuman"
        '
        'btn_cari_minuman
        '
        Me.btn_cari_minuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cari_minuman.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_minuman.Location = New System.Drawing.Point(332, 34)
        Me.btn_cari_minuman.Name = "btn_cari_minuman"
        Me.btn_cari_minuman.Size = New System.Drawing.Size(75, 35)
        Me.btn_cari_minuman.TabIndex = 3
        Me.btn_cari_minuman.Text = "Refresh"
        Me.btn_cari_minuman.UseVisualStyleBackColor = True
        '
        'txt_cari_minuman
        '
        Me.txt_cari_minuman.Location = New System.Drawing.Point(21, 37)
        Me.txt_cari_minuman.Name = "txt_cari_minuman"
        Me.txt_cari_minuman.Size = New System.Drawing.Size(291, 26)
        Me.txt_cari_minuman.TabIndex = 2
        '
        'lv_minuman
        '
        Me.lv_minuman.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lv_minuman.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_minuman.ForeColor = System.Drawing.Color.White
        Me.lv_minuman.FullRowSelect = True
        Me.lv_minuman.GridLines = True
        Me.lv_minuman.Location = New System.Drawing.Point(21, 77)
        Me.lv_minuman.Name = "lv_minuman"
        Me.lv_minuman.Size = New System.Drawing.Size(386, 510)
        Me.lv_minuman.TabIndex = 0
        Me.lv_minuman.UseCompatibleStateImageBehavior = False
        Me.lv_minuman.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nomor"
        Me.ColumnHeader3.Width = 82
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nama Minuman"
        Me.ColumnHeader4.Width = 275
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.picture)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(465, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 267)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "VIEW IMAGE"
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.SystemColors.Control
        Me.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picture.Location = New System.Drawing.Point(14, 31)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(408, 216)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picture.TabIndex = 0
        Me.picture.TabStop = False
        '
        'lbl_stok
        '
        Me.lbl_stok.AutoSize = True
        Me.lbl_stok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stok.Location = New System.Drawing.Point(582, 584)
        Me.lbl_stok.Name = "lbl_stok"
        Me.lbl_stok.Size = New System.Drawing.Size(14, 20)
        Me.lbl_stok.TabIndex = 17
        Me.lbl_stok.Text = "-"
        '
        'lbl_harga
        '
        Me.lbl_harga.AutoSize = True
        Me.lbl_harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_harga.Location = New System.Drawing.Point(583, 551)
        Me.lbl_harga.Name = "lbl_harga"
        Me.lbl_harga.Size = New System.Drawing.Size(14, 20)
        Me.lbl_harga.TabIndex = 16
        Me.lbl_harga.Text = "-"
        '
        'lbl_deskripsi
        '
        Me.lbl_deskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deskripsi.Location = New System.Drawing.Point(583, 468)
        Me.lbl_deskripsi.Name = "lbl_deskripsi"
        Me.lbl_deskripsi.Size = New System.Drawing.Size(296, 77)
        Me.lbl_deskripsi.TabIndex = 15
        Me.lbl_deskripsi.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(482, 584)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "STOK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(482, 551)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(480, 468)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Deskripsi"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(464, 452)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(435, 187)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(486, 667)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Pesan Tanpa Menggunakan Member  ?"
        '
        'btn_klik
        '
        Me.btn_klik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_klik.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_klik.Location = New System.Drawing.Point(775, 660)
        Me.btn_klik.Name = "btn_klik"
        Me.btn_klik.Size = New System.Drawing.Size(104, 32)
        Me.btn_klik.TabIndex = 20
        Me.btn_klik.Text = "Klik Di sini"
        Me.btn_klik.UseVisualStyleBackColor = True
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(462, 426)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(180, 29)
        Me.lbl_nama.TabIndex = 21
        Me.lbl_nama.Text = "Nama Makanan"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(824, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form_menu_tanpa_nama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.btn_klik)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_stok)
        Me.Controls.Add(Me.lbl_harga)
        Me.Controls.Add(Me.lbl_deskripsi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form_menu_tanpa_nama"
        Me.Text = "SMK RESTAURANT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_daftar As System.Windows.Forms.Button
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_refresh_makanan As System.Windows.Forms.Button
    Friend WithEvents txt_cari_makanan As System.Windows.Forms.TextBox
    Friend WithEvents lv_makanan As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cari_minuman As System.Windows.Forms.Button
    Friend WithEvents txt_cari_minuman As System.Windows.Forms.TextBox
    Friend WithEvents lv_minuman As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents picture As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_stok As System.Windows.Forms.Label
    Friend WithEvents lbl_harga As System.Windows.Forms.Label
    Friend WithEvents lbl_deskripsi As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_klik As System.Windows.Forms.Button
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

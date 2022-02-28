<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_order
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lv_menu = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_save_edit = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_type_masak = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_message = New System.Windows.Forms.RichTextBox()
        Me.btn_delet = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id_type_masak = New System.Windows.Forms.TextBox()
        Me.lv_order = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_order = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_id_order = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_id_member = New System.Windows.Forms.Label()
        Me.txt_id_menu = New System.Windows.Forms.TextBox()
        Me.txt_id_detail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_meja = New System.Windows.Forms.ComboBox()
        Me.txt_id_meja = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.picture = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 80)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1362, 80)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FORM PEMESANAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lv_menu)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 327)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Menu Makanan dan Minuman"
        '
        'btn_refresh
        '
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Location = New System.Drawing.Point(536, 25)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(99, 35)
        Me.btn_refresh.TabIndex = 15
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(155, 29)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(353, 26)
        Me.txt_search.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cari Menu"
        '
        'lv_menu
        '
        Me.lv_menu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lv_menu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_menu.ForeColor = System.Drawing.Color.White
        Me.lv_menu.FullRowSelect = True
        Me.lv_menu.GridLines = True
        Me.lv_menu.Location = New System.Drawing.Point(28, 70)
        Me.lv_menu.Name = "lv_menu"
        Me.lv_menu.Size = New System.Drawing.Size(607, 229)
        Me.lv_menu.TabIndex = 0
        Me.lv_menu.UseCompatibleStateImageBehavior = False
        Me.lv_menu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 41
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Menu"
        Me.ColumnHeader2.Width = 326
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.Width = 126
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stok"
        Me.ColumnHeader4.Width = 85
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_save_edit)
        Me.GroupBox2.Controls.Add(Me.btn_update)
        Me.GroupBox2.Controls.Add(Me.txt_type_masak)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_message)
        Me.GroupBox2.Controls.Add(Me.btn_delet)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.txt_qty)
        Me.GroupBox2.Controls.Add(Me.txt_price)
        Me.GroupBox2.Controls.Add(Me.txt_name)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_id_type_masak)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(732, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 299)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses Pemesanan"
        '
        'btn_save_edit
        '
        Me.btn_save_edit.Enabled = False
        Me.btn_save_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_edit.Location = New System.Drawing.Point(472, 156)
        Me.btn_save_edit.Name = "btn_save_edit"
        Me.btn_save_edit.Size = New System.Drawing.Size(116, 55)
        Me.btn_save_edit.TabIndex = 13
        Me.btn_save_edit.Text = "Simpan Perubahan"
        Me.btn_save_edit.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Location = New System.Drawing.Point(472, 93)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(116, 55)
        Me.btn_update.TabIndex = 12
        Me.btn_update.Text = "Ubah "
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txt_type_masak
        '
        Me.txt_type_masak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_type_masak.Enabled = False
        Me.txt_type_masak.FormattingEnabled = True
        Me.txt_type_masak.Location = New System.Drawing.Point(176, 249)
        Me.txt_type_masak.Name = "txt_type_masak"
        Me.txt_type_masak.Size = New System.Drawing.Size(278, 24)
        Me.txt_type_masak.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Type Masak"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Pesan bagi Koki"
        '
        'txt_message
        '
        Me.txt_message.Enabled = False
        Me.txt_message.Location = New System.Drawing.Point(176, 164)
        Me.txt_message.Name = "txt_message"
        Me.txt_message.Size = New System.Drawing.Size(278, 68)
        Me.txt_message.TabIndex = 0
        Me.txt_message.Text = ""
        '
        'btn_delet
        '
        Me.btn_delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delet.Location = New System.Drawing.Point(472, 220)
        Me.btn_delet.Name = "btn_delet"
        Me.btn_delet.Size = New System.Drawing.Size(116, 55)
        Me.btn_delet.TabIndex = 7
        Me.btn_delet.Text = "Hapus dari daftar pesanan"
        Me.btn_delet.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Location = New System.Drawing.Point(472, 29)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(116, 55)
        Me.btn_add.TabIndex = 6
        Me.btn_add.Text = "Tambahkan"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_qty
        '
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(176, 121)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(278, 26)
        Me.txt_qty.TabIndex = 5
        '
        'txt_price
        '
        Me.txt_price.Enabled = False
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(176, 75)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(278, 26)
        Me.txt_price.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.Enabled = False
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(176, 29)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(278, 26)
        Me.txt_name.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jumlah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Menu"
        '
        'txt_id_type_masak
        '
        Me.txt_id_type_masak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_type_masak.Location = New System.Drawing.Point(498, 249)
        Me.txt_id_type_masak.Name = "txt_id_type_masak"
        Me.txt_id_type_masak.Size = New System.Drawing.Size(51, 26)
        Me.txt_id_type_masak.TabIndex = 11
        Me.txt_id_type_masak.Visible = False
        '
        'lv_order
        '
        Me.lv_order.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lv_order.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lv_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_order.ForeColor = System.Drawing.Color.White
        Me.lv_order.FullRowSelect = True
        Me.lv_order.GridLines = True
        Me.lv_order.Location = New System.Drawing.Point(1, 48)
        Me.lv_order.Name = "lv_order"
        Me.lv_order.Size = New System.Drawing.Size(607, 195)
        Me.lv_order.TabIndex = 1
        Me.lv_order.UseCompatibleStateImageBehavior = False
        Me.lv_order.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Menu"
        Me.ColumnHeader7.Width = 264
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "QTY"
        Me.ColumnHeader8.Width = 94
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Price"
        Me.ColumnHeader9.Width = 126
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Total"
        Me.ColumnHeader10.Width = 119
        '
        'btn_order
        '
        Me.btn_order.Enabled = False
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(1161, 660)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(180, 57)
        Me.btn_order.TabIndex = 8
        Me.btn_order.Text = "Pesan Sekarang"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(737, 677)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(798, 675)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(817, 677)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Rp."
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(851, 677)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(16, 24)
        Me.lbl_total.TabIndex = 12
        Me.lbl_total.Text = "-"
        '
        'txt_id_order
        '
        Me.txt_id_order.Enabled = False
        Me.txt_id_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_order.Location = New System.Drawing.Point(165, 14)
        Me.txt_id_order.Name = "txt_id_order"
        Me.txt_id_order.Size = New System.Drawing.Size(228, 26)
        Me.txt_id_order.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nomor Pemesanan"
        '
        'btn_batal
        '
        Me.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.Location = New System.Drawing.Point(413, 12)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(180, 30)
        Me.btn_batal.TabIndex = 8
        Me.btn_batal.Text = "Batalkan Pemesanan"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lv_order)
        Me.GroupBox3.Controls.Add(Me.btn_batal)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_id_order)
        Me.GroupBox3.Location = New System.Drawing.Point(734, 408)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 246)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'lbl_id_member
        '
        Me.lbl_id_member.AutoSize = True
        Me.lbl_id_member.Location = New System.Drawing.Point(717, 84)
        Me.lbl_id_member.Name = "lbl_id_member"
        Me.lbl_id_member.Size = New System.Drawing.Size(10, 13)
        Me.lbl_id_member.TabIndex = 14
        Me.lbl_id_member.Text = "-"
        Me.lbl_id_member.Visible = False
        '
        'txt_id_menu
        '
        Me.txt_id_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_menu.Location = New System.Drawing.Point(756, 85)
        Me.txt_id_menu.Name = "txt_id_menu"
        Me.txt_id_menu.Size = New System.Drawing.Size(100, 17)
        Me.txt_id_menu.TabIndex = 15
        Me.txt_id_menu.Visible = False
        '
        'txt_id_detail
        '
        Me.txt_id_detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_detail.Location = New System.Drawing.Point(937, 86)
        Me.txt_id_detail.Name = "txt_id_detail"
        Me.txt_id_detail.Size = New System.Drawing.Size(40, 17)
        Me.txt_id_detail.TabIndex = 16
        Me.txt_id_detail.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1040, 660)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 24)
        Me.Label12.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(979, 662)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 24)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Nomor Meja  :"
        '
        'txt_meja
        '
        Me.txt_meja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_meja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_meja.FormattingEnabled = True
        Me.txt_meja.Location = New System.Drawing.Point(983, 689)
        Me.txt_meja.Name = "txt_meja"
        Me.txt_meja.Size = New System.Drawing.Size(136, 24)
        Me.txt_meja.TabIndex = 14
        '
        'txt_id_meja
        '
        Me.txt_id_meja.Enabled = False
        Me.txt_id_meja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_meja.Location = New System.Drawing.Point(937, 689)
        Me.txt_id_meja.Name = "txt_id_meja"
        Me.txt_id_meja.Size = New System.Drawing.Size(39, 23)
        Me.txt_id_meja.TabIndex = 10
        Me.txt_id_meja.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.picture)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(24, 436)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(670, 281)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "View Photo"
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.SystemColors.Control
        Me.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picture.Location = New System.Drawing.Point(26, 19)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(623, 246)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picture.TabIndex = 1
        Me.picture.TabStop = False
        '
        'Form_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txt_id_meja)
        Me.Controls.Add(Me.txt_meja)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_id_detail)
        Me.Controls.Add(Me.txt_id_menu)
        Me.Controls.Add(Me.lbl_id_member)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form_order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMK RESTAURANT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lv_menu As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_delet As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lv_order As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents txt_id_order As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_member As System.Windows.Forms.Label
    Friend WithEvents txt_id_menu As System.Windows.Forms.TextBox
    Friend WithEvents txt_message As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_type_masak As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_id_type_masak As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents txt_id_detail As System.Windows.Forms.TextBox
    Friend WithEvents btn_save_edit As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_meja As System.Windows.Forms.ComboBox
    Friend WithEvents txt_id_meja As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents picture As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class

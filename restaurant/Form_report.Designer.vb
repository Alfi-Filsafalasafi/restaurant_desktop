<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_report
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_bulan_sampai = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bulan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_tahun = New System.Windows.Forms.ComboBox()
        Me.txt_id_bulan_sampai = New System.Windows.Forms.TextBox()
        Me.txt_id_bulan = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.bindinglaporan = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataLaporan = New restaurant.DataLaporan()
        Me.V_laporan_rellTableAdapter = New restaurant.DataLaporanTableAdapters.v_laporan_rellTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_jumlah = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindinglaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 80)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant.My.Resources.Resources.left_arrow__1_
        Me.PictureBox2.Location = New System.Drawing.Point(30, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 80)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FORM ANGKA PELANGGAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_generate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_bulan_sampai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_bulan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_tahun)
        Me.GroupBox1.Controls.Add(Me.txt_id_bulan_sampai)
        Me.GroupBox1.Controls.Add(Me.txt_id_bulan)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1370, 79)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btn_refresh
        '
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Location = New System.Drawing.Point(1104, 22)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(101, 45)
        Me.btn_refresh.TabIndex = 13
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_generate
        '
        Me.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.Location = New System.Drawing.Point(977, 22)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(101, 45)
        Me.btn_generate.TabIndex = 12
        Me.btn_generate.Text = "Generate"
        Me.btn_generate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(657, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "S/d"
        '
        'txt_bulan_sampai
        '
        Me.txt_bulan_sampai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_bulan_sampai.FormattingEnabled = True
        Me.txt_bulan_sampai.Location = New System.Drawing.Point(722, 30)
        Me.txt_bulan_sampai.Name = "txt_bulan_sampai"
        Me.txt_bulan_sampai.Size = New System.Drawing.Size(166, 28)
        Me.txt_bulan_sampai.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Bulan"
        '
        'txt_bulan
        '
        Me.txt_bulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_bulan.FormattingEnabled = True
        Me.txt_bulan.Location = New System.Drawing.Point(463, 30)
        Me.txt_bulan.Name = "txt_bulan"
        Me.txt_bulan.Size = New System.Drawing.Size(166, 28)
        Me.txt_bulan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tahun"
        '
        'txt_tahun
        '
        Me.txt_tahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_tahun.FormattingEnabled = True
        Me.txt_tahun.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.txt_tahun.Location = New System.Drawing.Point(122, 30)
        Me.txt_tahun.Name = "txt_tahun"
        Me.txt_tahun.Size = New System.Drawing.Size(166, 28)
        Me.txt_tahun.TabIndex = 0
        '
        'txt_id_bulan_sampai
        '
        Me.txt_id_bulan_sampai.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_bulan_sampai.Location = New System.Drawing.Point(769, 44)
        Me.txt_id_bulan_sampai.Name = "txt_id_bulan_sampai"
        Me.txt_id_bulan_sampai.Size = New System.Drawing.Size(100, 9)
        Me.txt_id_bulan_sampai.TabIndex = 16
        '
        'txt_id_bulan
        '
        Me.txt_id_bulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_bulan.Location = New System.Drawing.Point(500, 33)
        Me.txt_id_bulan.Name = "txt_id_bulan"
        Me.txt_id_bulan.Size = New System.Drawing.Size(100, 9)
        Me.txt_id_bulan.TabIndex = 15
        '
        'Chart1
        '
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = -60
        ChartArea2.AxisY.Interval = 1.0R
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.DataSource = Me.bindinglaporan
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(0, 209)
        Me.Chart1.Name = "Chart1"
        Series2.BorderColor = System.Drawing.Color.Red
        Series2.BorderWidth = 4
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Navy
        Series2.Legend = "Legend1"
        Series2.MarkerSize = 20
        Series2.Name = "Jumlah Pengunjung"
        Series2.XValueMember = "bulan"
        Series2.YValueMembers = "jumlah"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1370, 540)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        '
        'bindinglaporan
        '
        Me.bindinglaporan.DataMember = "v_laporan_rell"
        Me.bindinglaporan.DataSource = Me.DataLaporan
        '
        'DataLaporan
        '
        Me.DataLaporan.DataSetName = "DataLaporan"
        Me.DataLaporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_laporan_rellTableAdapter
        '
        Me.V_laporan_rellTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(332, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Grafik peningkatan pelanggan sampai saat ini"
        '
        'lbl_jumlah
        '
        Me.lbl_jumlah.AutoSize = True
        Me.lbl_jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah.Location = New System.Drawing.Point(1197, 175)
        Me.lbl_jumlah.Name = "lbl_jumlah"
        Me.lbl_jumlah.Size = New System.Drawing.Size(14, 20)
        Me.lbl_jumlah.TabIndex = 4
        Me.lbl_jumlah.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1032, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Jumlah Pengunjung"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1180, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "="
        '
        'Form_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_jumlah)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMK RESTAURANT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindinglaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_tahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_generate As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_bulan_sampai As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_bulan As System.Windows.Forms.ComboBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents txt_id_bulan As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_bulan_sampai As System.Windows.Forms.TextBox
    Friend WithEvents bindinglaporan As System.Windows.Forms.BindingSource
    Friend WithEvents DataLaporan As restaurant.DataLaporan
    Friend WithEvents V_laporan_rellTableAdapter As restaurant.DataLaporanTableAdapters.v_laporan_rellTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_jumlah As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

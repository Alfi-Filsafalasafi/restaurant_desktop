<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_grafik_makanan
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
        Me.chart_makanan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.VgrafikmakananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_grafik_makanan = New restaurant.Data_grafik_makanan()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_id_bulan = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bulan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_tahun = New System.Windows.Forms.ComboBox()
        Me.txt_id_bulan = New System.Windows.Forms.TextBox()
        Me.V_grafik_makananTableAdapter = New restaurant.Data_grafik_makananTableAdapters.v_grafik_makananTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_makanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VgrafikmakananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_grafik_makanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant.My.Resources.Resources.left_arrow__1_
        Me.PictureBox2.Location = New System.Drawing.Point(36, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
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
        Me.Label1.Text = "FORM GRAFIK MAKANAN DAN MINUMAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chart_makanan
        '
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = -60
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX2.TitleForeColor = System.Drawing.Color.Transparent
        ChartArea2.AxisY.Interval = 1.0R
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.Transparent
        ChartArea2.AxisY2.TitleForeColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.chart_makanan.ChartAreas.Add(ChartArea2)
        Me.chart_makanan.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend2.Name = "Legend1"
        Me.chart_makanan.Legends.Add(Legend2)
        Me.chart_makanan.Location = New System.Drawing.Point(0, 212)
        Me.chart_makanan.Name = "chart_makanan"
        Me.chart_makanan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.LabelForeColor = System.Drawing.Color.Transparent
        Series2.Legend = "Legend1"
        Series2.Name = "Jumlah Pemesan"
        Series2.XValueMember = "name"
        Series2.YValueMembers = "jumlah"
        Me.chart_makanan.Series.Add(Series2)
        Me.chart_makanan.Size = New System.Drawing.Size(1370, 537)
        Me.chart_makanan.TabIndex = 7
        Me.chart_makanan.Text = "Chart1"
        '
        'VgrafikmakananBindingSource
        '
        Me.VgrafikmakananBindingSource.DataMember = "v_grafik_makanan"
        Me.VgrafikmakananBindingSource.DataSource = Me.Data_grafik_makanan
        '
        'Data_grafik_makanan
        '
        Me.Data_grafik_makanan.DataSetName = "Data_grafik_makanan"
        Me.Data_grafik_makanan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.lbl_id_bulan)
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_generate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_bulan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_tahun)
        Me.GroupBox1.Controls.Add(Me.txt_id_bulan)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1370, 79)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'lbl_id_bulan
        '
        Me.lbl_id_bulan.AutoSize = True
        Me.lbl_id_bulan.Location = New System.Drawing.Point(496, 7)
        Me.lbl_id_bulan.Name = "lbl_id_bulan"
        Me.lbl_id_bulan.Size = New System.Drawing.Size(0, 20)
        Me.lbl_id_bulan.TabIndex = 16
        Me.lbl_id_bulan.Visible = False
        '
        'btn_refresh
        '
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Location = New System.Drawing.Point(793, 22)
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
        Me.btn_generate.Location = New System.Drawing.Point(672, 22)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(101, 45)
        Me.btn_generate.TabIndex = 12
        Me.btn_generate.Text = "Generate"
        Me.btn_generate.UseVisualStyleBackColor = True
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
        Me.txt_tahun.Location = New System.Drawing.Point(122, 30)
        Me.txt_tahun.Name = "txt_tahun"
        Me.txt_tahun.Size = New System.Drawing.Size(166, 28)
        Me.txt_tahun.TabIndex = 0
        '
        'txt_id_bulan
        '
        Me.txt_id_bulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_bulan.Location = New System.Drawing.Point(500, 33)
        Me.txt_id_bulan.Name = "txt_id_bulan"
        Me.txt_id_bulan.Size = New System.Drawing.Size(100, 9)
        Me.txt_id_bulan.TabIndex = 15
        '
        'V_grafik_makananTableAdapter
        '
        Me.V_grafik_makananTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Grafik pemesanan makanan sampai saat ini"
        '
        'form_grafik_makanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chart_makanan)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "form_grafik_makanan"
        Me.Text = "SMK RESTAURANT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_makanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VgrafikmakananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_grafik_makanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chart_makanan As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_generate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_bulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_tahun As System.Windows.Forms.ComboBox
    Friend WithEvents txt_id_bulan As System.Windows.Forms.TextBox
    Friend WithEvents Data_grafik_makanan As restaurant.Data_grafik_makanan
    Friend WithEvents VgrafikmakananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_grafik_makananTableAdapter As restaurant.Data_grafik_makananTableAdapters.v_grafik_makananTableAdapter
    Friend WithEvents lbl_id_bulan As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

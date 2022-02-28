<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_report_detailku
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_tahun = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_bulan = New System.Windows.Forms.Label()
        Me.lbl_sampai = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chart_laporan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_jumlah = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.chart_laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(672, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Tahun"
        '
        'lbl_tahun
        '
        Me.lbl_tahun.AutoSize = True
        Me.lbl_tahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tahun.Location = New System.Drawing.Point(724, 21)
        Me.lbl_tahun.Name = "lbl_tahun"
        Me.lbl_tahun.Size = New System.Drawing.Size(45, 20)
        Me.lbl_tahun.TabIndex = 33
        Me.lbl_tahun.Text = "2020"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(354, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Grafik peningkatan angka pelanggan pada bulan"
        '
        'lbl_bulan
        '
        Me.lbl_bulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bulan.Location = New System.Drawing.Point(466, 21)
        Me.lbl_bulan.Name = "lbl_bulan"
        Me.lbl_bulan.Size = New System.Drawing.Size(95, 20)
        Me.lbl_bulan.TabIndex = 31
        Me.lbl_bulan.Text = "September"
        Me.lbl_bulan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_sampai
        '
        Me.lbl_sampai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sampai.Location = New System.Drawing.Point(578, 21)
        Me.lbl_sampai.Name = "lbl_sampai"
        Me.lbl_sampai.Size = New System.Drawing.Size(95, 20)
        Me.lbl_sampai.TabIndex = 30
        Me.lbl_sampai.Text = "September"
        Me.lbl_sampai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(564, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "-"
        '
        'chart_laporan
        '
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -60
        ChartArea1.AxisY.Interval = 1.0R
        ChartArea1.Name = "ChartArea1"
        Me.chart_laporan.ChartAreas.Add(ChartArea1)
        Me.chart_laporan.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend1.Name = "Legend1"
        Me.chart_laporan.Legends.Add(Legend1)
        Me.chart_laporan.Location = New System.Drawing.Point(0, 62)
        Me.chart_laporan.Name = "chart_laporan"
        Series1.BorderColor = System.Drawing.Color.Red
        Series1.BorderWidth = 4
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Navy
        Series1.Legend = "Legend1"
        Series1.MarkerSize = 20
        Series1.Name = "Jumlah Pengunjung"
        Me.chart_laporan.Series.Add(Series1)
        Me.chart_laporan.Size = New System.Drawing.Size(1340, 657)
        Me.chart_laporan.TabIndex = 27
        Me.chart_laporan.Text = "Chart1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1050, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(902, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Jumlah Pengunjung"
        '
        'lbl_jumlah
        '
        Me.lbl_jumlah.AutoSize = True
        Me.lbl_jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah.Location = New System.Drawing.Point(1067, 21)
        Me.lbl_jumlah.Name = "lbl_jumlah"
        Me.lbl_jumlah.Size = New System.Drawing.Size(14, 20)
        Me.lbl_jumlah.TabIndex = 35
        Me.lbl_jumlah.Text = "-"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant.My.Resources.Resources.left_arrow
        Me.PictureBox2.Location = New System.Drawing.Point(30, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'Form_report_detailku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_jumlah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_tahun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_bulan)
        Me.Controls.Add(Me.lbl_sampai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chart_laporan)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_report_detailku"
        Me.Text = "SMK RESTAURANT"
        CType(Me.chart_laporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_tahun As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_bulan As System.Windows.Forms.Label
    Friend WithEvents lbl_sampai As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chart_laporan As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_jumlah As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

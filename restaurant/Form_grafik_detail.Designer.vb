<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_grafik_detail
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chart_makanan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_tahun = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_bulan = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.chart_makanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chart_makanan
        '
        ChartArea2.Name = "ChartArea1"
        Me.chart_makanan.ChartAreas.Add(ChartArea2)
        Me.chart_makanan.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend2.Name = "Legend1"
        Me.chart_makanan.Legends.Add(Legend2)
        Me.chart_makanan.Location = New System.Drawing.Point(0, 71)
        Me.chart_makanan.Name = "chart_makanan"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Jumlah Pemesan"
        Me.chart_makanan.Series.Add(Series2)
        Me.chart_makanan.Size = New System.Drawing.Size(1334, 648)
        Me.chart_makanan.TabIndex = 0
        Me.chart_makanan.Text = "Chart1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(598, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Tahun"
        '
        'lbl_tahun
        '
        Me.lbl_tahun.AutoSize = True
        Me.lbl_tahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tahun.Location = New System.Drawing.Point(654, 27)
        Me.lbl_tahun.Name = "lbl_tahun"
        Me.lbl_tahun.Size = New System.Drawing.Size(45, 20)
        Me.lbl_tahun.TabIndex = 31
        Me.lbl_tahun.Text = "2020"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(366, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Grafik peningkatan Makanan Minuman pada bulan"
        '
        'lbl_bulan
        '
        Me.lbl_bulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bulan.Location = New System.Drawing.Point(509, 27)
        Me.lbl_bulan.Name = "lbl_bulan"
        Me.lbl_bulan.Size = New System.Drawing.Size(95, 20)
        Me.lbl_bulan.TabIndex = 29
        Me.lbl_bulan.Text = "September"
        Me.lbl_bulan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant.My.Resources.Resources.left_arrow
        Me.PictureBox2.Location = New System.Drawing.Point(39, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'Form_grafik_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_tahun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_bulan)
        Me.Controls.Add(Me.chart_makanan)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_grafik_detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMK RESTAURANT"
        CType(Me.chart_makanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chart_makanan As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_tahun As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_bulan As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

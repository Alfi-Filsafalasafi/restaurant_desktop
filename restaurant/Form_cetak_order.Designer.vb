<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cetak_order
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
        Me.report_v_cetak = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cetak_detail1 = New restaurant.cetak_detail()
        Me.SuspendLayout()
        '
        'report_v_cetak
        '
        Me.report_v_cetak.ActiveViewIndex = 0
        Me.report_v_cetak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.report_v_cetak.Cursor = System.Windows.Forms.Cursors.Default
        Me.report_v_cetak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.report_v_cetak.Location = New System.Drawing.Point(0, 0)
        Me.report_v_cetak.Name = "report_v_cetak"
        Me.report_v_cetak.ReportSource = Me.cetak_detail1
        Me.report_v_cetak.Size = New System.Drawing.Size(1370, 749)
        Me.report_v_cetak.TabIndex = 0
        '
        'Form_cetak_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.report_v_cetak)
        Me.Name = "Form_cetak_order"
        Me.Text = "CETAK PESANAN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents report_v_cetak As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cetak_detail1 As restaurant.cetak_detail
End Class

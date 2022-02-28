<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_view_photo
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
        Me.pc_v = New System.Windows.Forms.PictureBox()
        CType(Me.pc_v, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pc_v
        '
        Me.pc_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pc_v.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pc_v.Location = New System.Drawing.Point(0, 0)
        Me.pc_v.Name = "pc_v"
        Me.pc_v.Size = New System.Drawing.Size(1334, 691)
        Me.pc_v.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pc_v.TabIndex = 0
        Me.pc_v.TabStop = False
        '
        'Form_view_photo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 691)
        Me.Controls.Add(Me.pc_v)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_view_photo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pc_v, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pc_v As System.Windows.Forms.PictureBox
End Class

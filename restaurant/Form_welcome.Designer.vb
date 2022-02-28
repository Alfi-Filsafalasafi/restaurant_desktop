<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_welcome
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_login_sbagai = New System.Windows.Forms.ComboBox()
        Me.btn_lanjut = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_daftar = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome in"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SMK RESTAURANT  ^^"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_login_sbagai)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 64)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN SEBAGAI"
        '
        'cb_login_sbagai
        '
        Me.cb_login_sbagai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_login_sbagai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_login_sbagai.FormattingEnabled = True
        Me.cb_login_sbagai.Items.AddRange(New Object() {"admin", "employee", "member"})
        Me.cb_login_sbagai.Location = New System.Drawing.Point(11, 22)
        Me.cb_login_sbagai.Name = "cb_login_sbagai"
        Me.cb_login_sbagai.Size = New System.Drawing.Size(245, 28)
        Me.cb_login_sbagai.TabIndex = 0
        '
        'btn_lanjut
        '
        Me.btn_lanjut.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_lanjut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_lanjut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lanjut.ForeColor = System.Drawing.Color.White
        Me.btn_lanjut.Location = New System.Drawing.Point(17, 170)
        Me.btn_lanjut.Name = "btn_lanjut"
        Me.btn_lanjut.Size = New System.Drawing.Size(271, 47)
        Me.btn_lanjut.TabIndex = 3
        Me.btn_lanjut.Text = "Lanjut"
        Me.btn_lanjut.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Belum Punya Akun ?"
        '
        'lbl_daftar
        '
        Me.lbl_daftar.AutoSize = True
        Me.lbl_daftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_daftar.Location = New System.Drawing.Point(189, 231)
        Me.lbl_daftar.Name = "lbl_daftar"
        Me.lbl_daftar.Size = New System.Drawing.Size(44, 16)
        Me.lbl_daftar.TabIndex = 5
        Me.lbl_daftar.TabStop = True
        Me.lbl_daftar.Text = "Daftar"
        '
        'Form_welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 272)
        Me.Controls.Add(Me.lbl_daftar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_lanjut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMK RESTAURANT"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_login_sbagai As System.Windows.Forms.ComboBox
    Friend WithEvents btn_lanjut As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_daftar As System.Windows.Forms.LinkLabel
End Class

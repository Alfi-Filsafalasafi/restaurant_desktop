<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_gantipassword
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
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_konfir = New System.Windows.Forms.Button()
        Me.txt_pass_baru = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_pass_lama = New System.Windows.Forms.TextBox()
        Me.txt_ketik_ulang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.lbl_pass)
        Me.Panel1.Controls.Add(Me.lbl_id)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 60)
        Me.Panel1.TabIndex = 22
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(369, 2)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(14, 20)
        Me.lbl_pass.TabIndex = 39
        Me.lbl_pass.Text = "-"
        Me.lbl_pass.Visible = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(369, 30)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(14, 20)
        Me.lbl_id.TabIndex = 40
        Me.lbl_id.Text = "-"
        Me.lbl_id.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant.My.Resources.Resources.left_arrow__1_
        Me.PictureBox2.Location = New System.Drawing.Point(13, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.restaurant.My.Resources.Resources.lock
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(110, 0, 90, 0)
        Me.Label1.Size = New System.Drawing.Size(454, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ganti Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_konfir
        '
        Me.btn_konfir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_konfir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_konfir.Location = New System.Drawing.Point(34, 318)
        Me.btn_konfir.Name = "btn_konfir"
        Me.btn_konfir.Size = New System.Drawing.Size(387, 51)
        Me.btn_konfir.TabIndex = 5
        Me.btn_konfir.Text = "Konfirmasi Password"
        Me.btn_konfir.UseVisualStyleBackColor = True
        '
        'txt_pass_baru
        '
        Me.txt_pass_baru.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_pass_baru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass_baru.Location = New System.Drawing.Point(185, 225)
        Me.txt_pass_baru.Name = "txt_pass_baru"
        Me.txt_pass_baru.Size = New System.Drawing.Size(236, 26)
        Me.txt_pass_baru.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Password Baru"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Password Lama"
        '
        'txt_pass_lama
        '
        Me.txt_pass_lama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_pass_lama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass_lama.Location = New System.Drawing.Point(185, 184)
        Me.txt_pass_lama.Name = "txt_pass_lama"
        Me.txt_pass_lama.Size = New System.Drawing.Size(236, 26)
        Me.txt_pass_lama.TabIndex = 2
        '
        'txt_ketik_ulang
        '
        Me.txt_ketik_ulang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_ketik_ulang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ketik_ulang.Location = New System.Drawing.Point(185, 270)
        Me.txt_ketik_ulang.Name = "txt_ketik_ulang"
        Me.txt_ketik_ulang.Size = New System.Drawing.Size(236, 26)
        Me.txt_ketik_ulang.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Ketik Ulang "
        '
        'txt_username
        '
        Me.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(185, 141)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(236, 26)
        Me.txt_username.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Username Saat Ini"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(391, 50)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Isi Semua Perintah dengan Tepat demi Keamanan Data Anda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(369, 109)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(14, 20)
        Me.lbl_username.TabIndex = 38
        Me.lbl_username.Text = "-"
        Me.lbl_username.Visible = False
        '
        'Form_gantipassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_ketik_ulang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pass_lama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_konfir)
        Me.Controls.Add(Me.txt_pass_baru)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_gantipassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_konfir As System.Windows.Forms.Button
    Friend WithEvents txt_pass_baru As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_pass_lama As System.Windows.Forms.TextBox
    Friend WithEvents txt_ketik_ulang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
End Class

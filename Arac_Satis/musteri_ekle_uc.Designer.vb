<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class musteri_ekle_uc
    Inherits System.Windows.Forms.UserControl

    'UserControl, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fullname_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tc_box = New System.Windows.Forms.TextBox()
        Me.telno_box = New System.Windows.Forms.TextBox()
        Me.eposta_box = New System.Windows.Forms.TextBox()
        Me.adres_box = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tam Adı"
        '
        'fullname_box
        '
        Me.fullname_box.Location = New System.Drawing.Point(256, 19)
        Me.fullname_box.Margin = New System.Windows.Forms.Padding(4)
        Me.fullname_box.Name = "fullname_box"
        Me.fullname_box.Size = New System.Drawing.Size(435, 27)
        Me.fullname_box.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TC Kimlik Numarası"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Telefon Numarası"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "E-Posta Adresi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adres"
        '
        'tc_box
        '
        Me.tc_box.Location = New System.Drawing.Point(256, 72)
        Me.tc_box.Margin = New System.Windows.Forms.Padding(4)
        Me.tc_box.Name = "tc_box"
        Me.tc_box.Size = New System.Drawing.Size(435, 27)
        Me.tc_box.TabIndex = 1
        '
        'telno_box
        '
        Me.telno_box.Location = New System.Drawing.Point(256, 121)
        Me.telno_box.Margin = New System.Windows.Forms.Padding(4)
        Me.telno_box.Name = "telno_box"
        Me.telno_box.Size = New System.Drawing.Size(435, 27)
        Me.telno_box.TabIndex = 1
        '
        'eposta_box
        '
        Me.eposta_box.Location = New System.Drawing.Point(256, 171)
        Me.eposta_box.Margin = New System.Windows.Forms.Padding(4)
        Me.eposta_box.Name = "eposta_box"
        Me.eposta_box.Size = New System.Drawing.Size(435, 27)
        Me.eposta_box.TabIndex = 1
        '
        'adres_box
        '
        Me.adres_box.Location = New System.Drawing.Point(256, 228)
        Me.adres_box.Margin = New System.Windows.Forms.Padding(4)
        Me.adres_box.Name = "adres_box"
        Me.adres_box.Size = New System.Drawing.Size(435, 173)
        Me.adres_box.TabIndex = 2
        Me.adres_box.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 441)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 50)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Kaydet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(530, 441)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Temizle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Arac_Satis.My.Resources.Resources.musteri_ekle
        Me.PictureBox1.Location = New System.Drawing.Point(869, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'musteri_ekle_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.adres_box)
        Me.Controls.Add(Me.eposta_box)
        Me.Controls.Add(Me.telno_box)
        Me.Controls.Add(Me.tc_box)
        Me.Controls.Add(Me.fullname_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "musteri_ekle_uc"
        Me.Size = New System.Drawing.Size(1263, 523)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents fullname_box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tc_box As TextBox
    Friend WithEvents telno_box As TextBox
    Friend WithEvents eposta_box As TextBox
    Friend WithEvents adres_box As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arac_ekle_uc
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.marka_box = New System.Windows.Forms.TextBox()
        Me.model_box = New System.Windows.Forms.TextBox()
        Me.serino_box = New System.Windows.Forms.TextBox()
        Me.renk_box = New System.Windows.Forms.TextBox()
        Me.km_box = New System.Windows.Forms.TextBox()
        Me.plaka_box = New System.Windows.Forms.TextBox()
        Me.fiyat_box = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.durum_box = New System.Windows.Forms.ComboBox()
        Me.yakit_box = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Seri No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Renk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Km"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Yakıt Türü"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Plaka"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Fiyatı"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 431)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Durumu"
        '
        'marka_box
        '
        Me.marka_box.Location = New System.Drawing.Point(181, 18)
        Me.marka_box.Name = "marka_box"
        Me.marka_box.Size = New System.Drawing.Size(261, 27)
        Me.marka_box.TabIndex = 1
        '
        'model_box
        '
        Me.model_box.Location = New System.Drawing.Point(181, 65)
        Me.model_box.Name = "model_box"
        Me.model_box.Size = New System.Drawing.Size(261, 27)
        Me.model_box.TabIndex = 1
        '
        'serino_box
        '
        Me.serino_box.Location = New System.Drawing.Point(181, 113)
        Me.serino_box.Name = "serino_box"
        Me.serino_box.Size = New System.Drawing.Size(261, 27)
        Me.serino_box.TabIndex = 1
        '
        'renk_box
        '
        Me.renk_box.Location = New System.Drawing.Point(181, 165)
        Me.renk_box.Name = "renk_box"
        Me.renk_box.Size = New System.Drawing.Size(261, 27)
        Me.renk_box.TabIndex = 1
        '
        'km_box
        '
        Me.km_box.Location = New System.Drawing.Point(181, 218)
        Me.km_box.Name = "km_box"
        Me.km_box.Size = New System.Drawing.Size(261, 27)
        Me.km_box.TabIndex = 1
        '
        'plaka_box
        '
        Me.plaka_box.Location = New System.Drawing.Point(181, 321)
        Me.plaka_box.Name = "plaka_box"
        Me.plaka_box.Size = New System.Drawing.Size(261, 27)
        Me.plaka_box.TabIndex = 1
        '
        'fiyat_box
        '
        Me.fiyat_box.Location = New System.Drawing.Point(181, 372)
        Me.fiyat_box.Name = "fiyat_box"
        Me.fiyat_box.Size = New System.Drawing.Size(261, 27)
        Me.fiyat_box.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Arac_Satis.My.Resources.Resources.arac_ekle
        Me.PictureBox1.Location = New System.Drawing.Point(610, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 493)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 50)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Temizle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 493)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 50)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Kaydet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'durum_box
        '
        Me.durum_box.FormattingEnabled = True
        Me.durum_box.Items.AddRange(New Object() {"Sıfır", "İkinci El"})
        Me.durum_box.Location = New System.Drawing.Point(181, 428)
        Me.durum_box.Name = "durum_box"
        Me.durum_box.Size = New System.Drawing.Size(261, 28)
        Me.durum_box.TabIndex = 8
        '
        'yakit_box
        '
        Me.yakit_box.FormattingEnabled = True
        Me.yakit_box.Items.AddRange(New Object() {"Benzinli", "Dizel", "LPG", "Elektrikli", "Hibrit"})
        Me.yakit_box.Location = New System.Drawing.Point(181, 267)
        Me.yakit_box.Name = "yakit_box"
        Me.yakit_box.Size = New System.Drawing.Size(261, 28)
        Me.yakit_box.TabIndex = 9
        '
        'arac_ekle_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.yakit_box)
        Me.Controls.Add(Me.durum_box)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.fiyat_box)
        Me.Controls.Add(Me.plaka_box)
        Me.Controls.Add(Me.km_box)
        Me.Controls.Add(Me.renk_box)
        Me.Controls.Add(Me.serino_box)
        Me.Controls.Add(Me.model_box)
        Me.Controls.Add(Me.marka_box)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "arac_ekle_uc"
        Me.Size = New System.Drawing.Size(974, 618)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents marka_box As TextBox
    Friend WithEvents model_box As TextBox
    Friend WithEvents serino_box As TextBox
    Friend WithEvents renk_box As TextBox
    Friend WithEvents km_box As TextBox
    Friend WithEvents plaka_box As TextBox
    Friend WithEvents fiyat_box As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents durum_box As ComboBox
    Friend WithEvents yakit_box As ComboBox
End Class

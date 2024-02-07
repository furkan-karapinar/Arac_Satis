<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arac_list_uc
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fiyat_box = New System.Windows.Forms.TextBox()
        Me.plaka_box = New System.Windows.Forms.TextBox()
        Me.km_box = New System.Windows.Forms.TextBox()
        Me.renk_box = New System.Windows.Forms.TextBox()
        Me.serino_box = New System.Windows.Forms.TextBox()
        Me.model_box = New System.Windows.Forms.TextBox()
        Me.marka_box = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.yakit_box = New System.Windows.Forms.ComboBox()
        Me.durum_box = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(473, 497)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 50)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Temizle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 497)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 50)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Güncelle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fiyat_box
        '
        Me.fiyat_box.Location = New System.Drawing.Point(187, 380)
        Me.fiyat_box.Name = "fiyat_box"
        Me.fiyat_box.Size = New System.Drawing.Size(261, 27)
        Me.fiyat_box.TabIndex = 23
        '
        'plaka_box
        '
        Me.plaka_box.Location = New System.Drawing.Point(187, 329)
        Me.plaka_box.Name = "plaka_box"
        Me.plaka_box.Size = New System.Drawing.Size(261, 27)
        Me.plaka_box.TabIndex = 22
        '
        'km_box
        '
        Me.km_box.Location = New System.Drawing.Point(187, 226)
        Me.km_box.Name = "km_box"
        Me.km_box.Size = New System.Drawing.Size(261, 27)
        Me.km_box.TabIndex = 20
        '
        'renk_box
        '
        Me.renk_box.Location = New System.Drawing.Point(187, 173)
        Me.renk_box.Name = "renk_box"
        Me.renk_box.Size = New System.Drawing.Size(261, 27)
        Me.renk_box.TabIndex = 19
        '
        'serino_box
        '
        Me.serino_box.Location = New System.Drawing.Point(187, 121)
        Me.serino_box.Name = "serino_box"
        Me.serino_box.ReadOnly = True
        Me.serino_box.Size = New System.Drawing.Size(261, 27)
        Me.serino_box.TabIndex = 25
        '
        'model_box
        '
        Me.model_box.Location = New System.Drawing.Point(187, 73)
        Me.model_box.Name = "model_box"
        Me.model_box.Size = New System.Drawing.Size(261, 27)
        Me.model_box.TabIndex = 18
        '
        'marka_box
        '
        Me.marka_box.Location = New System.Drawing.Point(187, 26)
        Me.marka_box.Name = "marka_box"
        Me.marka_box.Size = New System.Drawing.Size(261, 27)
        Me.marka_box.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 439)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Durumu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fiyatı"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Plaka"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Yakıt Türü"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Km"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Renk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Seri No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Marka"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(473, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(538, 438)
        Me.DataGridView1.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(286, 497)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 50)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Kaydı Sil"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'yakit_box
        '
        Me.yakit_box.FormattingEnabled = True
        Me.yakit_box.Items.AddRange(New Object() {"Benzinli", "Dizel", "LPG", "Elektrikli", "Hibrit"})
        Me.yakit_box.Location = New System.Drawing.Point(187, 275)
        Me.yakit_box.Name = "yakit_box"
        Me.yakit_box.Size = New System.Drawing.Size(261, 28)
        Me.yakit_box.TabIndex = 31
        '
        'durum_box
        '
        Me.durum_box.FormattingEnabled = True
        Me.durum_box.Items.AddRange(New Object() {"Sıfır", "İkinci El"})
        Me.durum_box.Location = New System.Drawing.Point(187, 436)
        Me.durum_box.Name = "durum_box"
        Me.durum_box.Size = New System.Drawing.Size(261, 28)
        Me.durum_box.TabIndex = 30
        '
        'arac_list_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.yakit_box)
        Me.Controls.Add(Me.durum_box)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "arac_list_uc"
        Me.Size = New System.Drawing.Size(1038, 570)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents fiyat_box As TextBox
    Friend WithEvents plaka_box As TextBox
    Friend WithEvents km_box As TextBox
    Friend WithEvents renk_box As TextBox
    Friend WithEvents serino_box As TextBox
    Friend WithEvents model_box As TextBox
    Friend WithEvents marka_box As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents yakit_box As ComboBox
    Friend WithEvents durum_box As ComboBox
End Class

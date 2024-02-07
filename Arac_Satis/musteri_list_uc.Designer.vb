<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class musteri_list_uc
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.adres_box = New System.Windows.Forms.RichTextBox()
        Me.eposta_box = New System.Windows.Forms.TextBox()
        Me.telno_box = New System.Windows.Forms.TextBox()
        Me.tc_box = New System.Windows.Forms.TextBox()
        Me.fullname_box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 421)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 50)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Güncelle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'adres_box
        '
        Me.adres_box.Location = New System.Drawing.Point(247, 229)
        Me.adres_box.Margin = New System.Windows.Forms.Padding(4)
        Me.adres_box.Name = "adres_box"
        Me.adres_box.Size = New System.Drawing.Size(435, 173)
        Me.adres_box.TabIndex = 13
        Me.adres_box.Text = ""
        '
        'eposta_box
        '
        Me.eposta_box.Location = New System.Drawing.Point(247, 172)
        Me.eposta_box.Margin = New System.Windows.Forms.Padding(4)
        Me.eposta_box.Name = "eposta_box"
        Me.eposta_box.Size = New System.Drawing.Size(435, 27)
        Me.eposta_box.TabIndex = 9
        '
        'telno_box
        '
        Me.telno_box.Location = New System.Drawing.Point(247, 122)
        Me.telno_box.Margin = New System.Windows.Forms.Padding(4)
        Me.telno_box.Name = "telno_box"
        Me.telno_box.Size = New System.Drawing.Size(435, 27)
        Me.telno_box.TabIndex = 10
        '
        'tc_box
        '
        Me.tc_box.Location = New System.Drawing.Point(247, 73)
        Me.tc_box.Margin = New System.Windows.Forms.Padding(4)
        Me.tc_box.Name = "tc_box"
        Me.tc_box.ReadOnly = True
        Me.tc_box.Size = New System.Drawing.Size(435, 27)
        Me.tc_box.TabIndex = 11
        '
        'fullname_box
        '
        Me.fullname_box.Location = New System.Drawing.Point(247, 20)
        Me.fullname_box.Margin = New System.Windows.Forms.Padding(4)
        Me.fullname_box.Name = "fullname_box"
        Me.fullname_box.Size = New System.Drawing.Size(435, 27)
        Me.fullname_box.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 229)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Adres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "E-Posta Adresi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefon Numarası"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TC Kimlik Numarası"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tam Adı"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(714, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(602, 472)
        Me.DataGridView1.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(520, 421)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 50)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Kaydı Sil"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'musteri_list_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
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
        Me.Name = "musteri_list_uc"
        Me.Size = New System.Drawing.Size(1336, 517)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents adres_box As RichTextBox
    Friend WithEvents eposta_box As TextBox
    Friend WithEvents telno_box As TextBox
    Friend WithEvents tc_box As TextBox
    Friend WithEvents fullname_box As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
End Class

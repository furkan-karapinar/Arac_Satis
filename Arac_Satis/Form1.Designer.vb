<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cikis_btn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.satis_btn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.sozlesme_btn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.arac__list_btn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.arac_ekle_btn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.musteri_list_btn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.musteri_ekle_btn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cikis_btn
        '
        Me.cikis_btn.BackColor = System.Drawing.SystemColors.Control
        Me.cikis_btn.color = System.Drawing.SystemColors.Control
        Me.cikis_btn.colorActive = System.Drawing.SystemColors.Control
        Me.cikis_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cikis_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cikis_btn.ForeColor = System.Drawing.Color.Black
        Me.cikis_btn.Image = CType(resources.GetObject("cikis_btn.Image"), System.Drawing.Image)
        Me.cikis_btn.ImagePosition = 13
        Me.cikis_btn.ImageZoom = 45
        Me.cikis_btn.LabelPosition = 25
        Me.cikis_btn.LabelText = "Çıkış"
        Me.cikis_btn.Location = New System.Drawing.Point(13, 752)
        Me.cikis_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cikis_btn.Name = "cikis_btn"
        Me.cikis_btn.Size = New System.Drawing.Size(154, 113)
        Me.cikis_btn.TabIndex = 2
        '
        'satis_btn
        '
        Me.satis_btn.BackColor = System.Drawing.SystemColors.Control
        Me.satis_btn.color = System.Drawing.SystemColors.Control
        Me.satis_btn.colorActive = System.Drawing.SystemColors.Control
        Me.satis_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.satis_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.satis_btn.ForeColor = System.Drawing.Color.Black
        Me.satis_btn.Image = CType(resources.GetObject("satis_btn.Image"), System.Drawing.Image)
        Me.satis_btn.ImagePosition = 13
        Me.satis_btn.ImageZoom = 45
        Me.satis_btn.LabelPosition = 25
        Me.satis_btn.LabelText = "Satışlar"
        Me.satis_btn.Location = New System.Drawing.Point(13, 629)
        Me.satis_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.satis_btn.Name = "satis_btn"
        Me.satis_btn.Size = New System.Drawing.Size(154, 113)
        Me.satis_btn.TabIndex = 2
        '
        'sozlesme_btn
        '
        Me.sozlesme_btn.BackColor = System.Drawing.SystemColors.Control
        Me.sozlesme_btn.color = System.Drawing.SystemColors.Control
        Me.sozlesme_btn.colorActive = System.Drawing.SystemColors.Control
        Me.sozlesme_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sozlesme_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sozlesme_btn.ForeColor = System.Drawing.Color.Black
        Me.sozlesme_btn.Image = CType(resources.GetObject("sozlesme_btn.Image"), System.Drawing.Image)
        Me.sozlesme_btn.ImagePosition = 13
        Me.sozlesme_btn.ImageZoom = 45
        Me.sozlesme_btn.LabelPosition = 25
        Me.sozlesme_btn.LabelText = "Sözleşme"
        Me.sozlesme_btn.Location = New System.Drawing.Point(13, 506)
        Me.sozlesme_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sozlesme_btn.Name = "sozlesme_btn"
        Me.sozlesme_btn.Size = New System.Drawing.Size(154, 113)
        Me.sozlesme_btn.TabIndex = 2
        '
        'arac__list_btn
        '
        Me.arac__list_btn.BackColor = System.Drawing.SystemColors.Control
        Me.arac__list_btn.color = System.Drawing.SystemColors.Control
        Me.arac__list_btn.colorActive = System.Drawing.SystemColors.Control
        Me.arac__list_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.arac__list_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.arac__list_btn.ForeColor = System.Drawing.Color.Black
        Me.arac__list_btn.Image = CType(resources.GetObject("arac__list_btn.Image"), System.Drawing.Image)
        Me.arac__list_btn.ImagePosition = 13
        Me.arac__list_btn.ImageZoom = 45
        Me.arac__list_btn.LabelPosition = 25
        Me.arac__list_btn.LabelText = "Araç Listesi"
        Me.arac__list_btn.Location = New System.Drawing.Point(13, 383)
        Me.arac__list_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.arac__list_btn.Name = "arac__list_btn"
        Me.arac__list_btn.Size = New System.Drawing.Size(154, 113)
        Me.arac__list_btn.TabIndex = 2
        '
        'arac_ekle_btn
        '
        Me.arac_ekle_btn.BackColor = System.Drawing.SystemColors.Control
        Me.arac_ekle_btn.color = System.Drawing.SystemColors.Control
        Me.arac_ekle_btn.colorActive = System.Drawing.SystemColors.Control
        Me.arac_ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.arac_ekle_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.arac_ekle_btn.ForeColor = System.Drawing.Color.Black
        Me.arac_ekle_btn.Image = CType(resources.GetObject("arac_ekle_btn.Image"), System.Drawing.Image)
        Me.arac_ekle_btn.ImagePosition = 13
        Me.arac_ekle_btn.ImageZoom = 45
        Me.arac_ekle_btn.LabelPosition = 25
        Me.arac_ekle_btn.LabelText = "Araç Ekle"
        Me.arac_ekle_btn.Location = New System.Drawing.Point(13, 260)
        Me.arac_ekle_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.arac_ekle_btn.Name = "arac_ekle_btn"
        Me.arac_ekle_btn.Size = New System.Drawing.Size(154, 113)
        Me.arac_ekle_btn.TabIndex = 2
        '
        'musteri_list_btn
        '
        Me.musteri_list_btn.BackColor = System.Drawing.SystemColors.Control
        Me.musteri_list_btn.color = System.Drawing.SystemColors.Control
        Me.musteri_list_btn.colorActive = System.Drawing.SystemColors.Control
        Me.musteri_list_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.musteri_list_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.musteri_list_btn.ForeColor = System.Drawing.Color.Black
        Me.musteri_list_btn.Image = CType(resources.GetObject("musteri_list_btn.Image"), System.Drawing.Image)
        Me.musteri_list_btn.ImagePosition = 13
        Me.musteri_list_btn.ImageZoom = 45
        Me.musteri_list_btn.LabelPosition = 25
        Me.musteri_list_btn.LabelText = "Müşteri Listesi"
        Me.musteri_list_btn.Location = New System.Drawing.Point(13, 137)
        Me.musteri_list_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.musteri_list_btn.Name = "musteri_list_btn"
        Me.musteri_list_btn.Size = New System.Drawing.Size(154, 113)
        Me.musteri_list_btn.TabIndex = 2
        '
        'musteri_ekle_btn
        '
        Me.musteri_ekle_btn.BackColor = System.Drawing.SystemColors.Control
        Me.musteri_ekle_btn.color = System.Drawing.SystemColors.Control
        Me.musteri_ekle_btn.colorActive = System.Drawing.SystemColors.Control
        Me.musteri_ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.musteri_ekle_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.musteri_ekle_btn.ForeColor = System.Drawing.Color.Black
        Me.musteri_ekle_btn.Image = CType(resources.GetObject("musteri_ekle_btn.Image"), System.Drawing.Image)
        Me.musteri_ekle_btn.ImagePosition = 13
        Me.musteri_ekle_btn.ImageZoom = 45
        Me.musteri_ekle_btn.LabelPosition = 25
        Me.musteri_ekle_btn.LabelText = "Müşteri Ekle"
        Me.musteri_ekle_btn.Location = New System.Drawing.Point(13, 14)
        Me.musteri_ekle_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.musteri_ekle_btn.Name = "musteri_ekle_btn"
        Me.musteri_ekle_btn.Size = New System.Drawing.Size(154, 113)
        Me.musteri_ekle_btn.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1011, 853)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(207, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 853)
        Me.Panel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1230, 878)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cikis_btn)
        Me.Controls.Add(Me.satis_btn)
        Me.Controls.Add(Me.sozlesme_btn)
        Me.Controls.Add(Me.arac__list_btn)
        Me.Controls.Add(Me.arac_ekle_btn)
        Me.Controls.Add(Me.musteri_list_btn)
        Me.Controls.Add(Me.musteri_ekle_btn)
        Me.Name = "Form1"
        Me.Text = "Araç Satış Otomasyonu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents musteri_ekle_btn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents musteri_list_btn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents arac_ekle_btn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents arac__list_btn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents sozlesme_btn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents satis_btn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents cikis_btn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Panel1 As Panel
End Class

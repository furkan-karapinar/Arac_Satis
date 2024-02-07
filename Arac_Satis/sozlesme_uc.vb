Public Class sozlesme_uc
    Dim dc As Database_Control = New Database_Control
    Dim path As String = Application.StartupPath & "\database.db"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '**' 'Ekle'
        Dim columns_list As List(Of String) = New List(Of String)
        columns_list.Add("tc_no")
        columns_list.Add("tam_ad")
        columns_list.Add("tel_no")
        columns_list.Add("ehliyet_no")
        columns_list.Add("ehliyet_tarihi")

        columns_list.Add("marka")
        columns_list.Add("model")
        columns_list.Add("seri_no")
        columns_list.Add("renk")
        columns_list.Add("plaka")
        columns_list.Add("fiyat")
        columns_list.Add("satis_tarihi")


        Dim value_list As List(Of String) = New List(Of String)
        value_list.Add(tcno_box.Text)
        value_list.Add(fullname_box.Text)
        value_list.Add(telno_box.Text)
        value_list.Add(ehliyetno_box.Text)
        value_list.Add(DateTimePicker1.Value.Date)
        value_list.Add(marka_box.Text)
        value_list.Add(model_box.Text)
        value_list.Add(serino_box.Text)
        value_list.Add(renk_box.Text)
        value_list.Add(ComboBox2.Text)
        value_list.Add(fiyat_box.Text)
        value_list.Add(DateTimePicker2.Value.Date)



        Dim result = dc.Insert_Data(path, "satislar", columns_list, value_list)
        If result <> 1 Then
            MsgBox("Kayıt Hatası")
        Else
            tcno_box.Text = String.Empty
            fullname_box.Text = String.Empty
            telno_box.Text = String.Empty
            ehliyetno_box.Text = String.Empty
            marka_box.Text = String.Empty
            model_box.Text = String.Empty
            serino_box.Text = String.Empty
            renk_box.Text = String.Empty
            ComboBox2.Text = String.Empty
            fiyat_box.Text = String.Empty

        End If
        Update_Items()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '**' 'Kaldır'

        dc.Delete_Data(path, "satislar", "tc_no", tcno_box.Text)
        tcno_box.Text = String.Empty
        fullname_box.Text = String.Empty
        telno_box.Text = String.Empty
        ehliyetno_box.Text = String.Empty
        marka_box.Text = String.Empty
        model_box.Text = String.Empty
        serino_box.Text = String.Empty
        renk_box.Text = String.Empty
        ComboBox2.Text = String.Empty
        fiyat_box.Text = String.Empty
        Update_Items()

    End Sub

    Private Sub Update_Items()
        tcno_box.Items.Clear()
        ComboBox2.Items.Clear()

        Dim liste As List(Of String) = New List(Of String)
        liste = (dc.Returnable_Run_Command(path, "SELECT tc_no FROM musteriler", "tc_no"))
        tcno_box.AutoCompleteMode = AutoCompleteMode.Append
        tcno_box.AutoCompleteSource = AutoCompleteSource.CustomSource
        tcno_box.AutoCompleteCustomSource.AddRange(liste.ToArray)
        tcno_box.Items.AddRange(liste.ToArray)

        Dim arac_list As List(Of String) = New List(Of String)
        arac_list = dc.Returnable_Run_Command(path, "SELECT plaka FROM araclar", "plaka")
        ComboBox2.AutoCompleteMode = AutoCompleteMode.Append
        ComboBox2.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBox2.AutoCompleteCustomSource.AddRange(arac_list.ToArray)
        ComboBox2.Items.AddRange(arac_list.ToArray)

        DataGridView1.DataSource = dc.Returnable_last10(path)
    End Sub

    Private Sub sozlesme_uc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_Items()
    End Sub

    Private Sub tcno_box_TextChanged(sender As Object, e As EventArgs) Handles tcno_box.TextChanged
        Dim ikincideger = tcno_box.Text

        fullname_box.Text = (dc.Get_Single_Data(path, "musteriler", "tc_no", "'" & ikinciDeger & "'", 0, "String"))
        telno_box.Text = (dc.Get_Single_Data(path, "musteriler", "tc_no", "'" & ikinciDeger & "'", 2, "String"))

    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        Dim ikincideger = ComboBox2.Text

        marka_box.Text = (dc.Get_Single_Data(path, "araclar", "plaka", "'" & ikinciDeger & "'", 0, "String"))
        model_box.Text = (dc.Get_Single_Data(path, "araclar", "plaka", "'" & ikinciDeger & "'", 1, "String"))
        serino_box.Text = (dc.Get_Single_Data(path, "araclar", "plaka", "'" & ikinciDeger & "'", 2, "String"))
        renk_box.Text = (dc.Get_Single_Data(path, "araclar", "plaka", "'" & ikinciDeger & "'", 3, "String"))
        fiyat_box.Text = (dc.Get_Single_Data(path, "araclar", "plaka", "'" & ikinciDeger & "'", 7, "String"))
    End Sub
End Class

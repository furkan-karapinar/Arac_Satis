Imports System.IO

Public Class arac_list_uc
    Dim dc As Database_Control = New Database_Control
    Dim path As String = Application.StartupPath & "\database.db"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        marka_box.Clear()
        model_box.Clear()
        serino_box.Clear()
        renk_box.Clear()
        km_box.Clear()
        yakit_box.Text = String.Empty
        plaka_box.Clear()
        fiyat_box.Clear()
        durum_box.Text = String.Empty
    End Sub

    Private Function empty_chack() As Integer
        If marka_box.Text = String.Empty Or model_box.Text = String.Empty Or serino_box.Text = String.Empty Or renk_box.Text = String.Empty Or km_box.Text = String.Empty Or yakit_box.Text = String.Empty Or plaka_box.Text = String.Empty Or fiyat_box.Text = String.Empty Or durum_box.Text = String.Empty Then
            MsgBox("Lütfen bütün alanları doldurunuz.")
            Return 1
        Else
            Return 0
        End If


    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '**' 'Kaydı Sil'
        If empty_chack() <> 1 Then
            dc.Delete_Data(path, "araclar", "seri_no", serino_box.Text)
            marka_box.Clear()
            model_box.Clear()
            serino_box.Clear()
            renk_box.Clear()
            km_box.Clear()
            yakit_box.Text = String.Empty
            plaka_box.Clear()
            fiyat_box.Clear()
            durum_box.Text = String.Empty
            Update_List()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '**' 'Güncelle'
        If empty_chack() <> 1 Then
            dc.Update_Data(path, "araclar", "marka", marka_box.Text, "seri_no", serino_box.Text)
            dc.Update_Data(path, "araclar", "model", model_box.Text, "seri_no", serino_box.Text)
            dc.Update_Data(path, "araclar", "seri_no", serino_box.Text, "seri_no", serino_box.Text)
            dc.Update_Data(path, "araclar", "renk", renk_box.Text, "seri_no", serino_box.Text)
            dc.Update_Data(path, "araclar", "km", km_box.Text, "seri_no", serino_box.Text)
            dc.Update_Data(path, "araclar", "yakit", yakit_box.Text, "seri_no", serino_box.Text)
            dc.Update_Data(path, "araclar", "plaka", plaka_box.Text, "seri_no", serino_box.Text)
            dc.Update_Data(path, "araclar", "fiyat", fiyat_box.Text, "seri_no", serino_box.Text)
            dc.Update_Data(path, "araclar", "durum", durum_box.Text, "seri_no", serino_box.Text)
            Update_List()
        End If



    End Sub


    Public Sub Update_List()
        DataGridView1.DataSource = dc.Connect_Data(path, "araclar", DataGridView1)
    End Sub
    Private Sub arac_list_uc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_List()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim secilenSatirIndex As Integer = DataGridView1.SelectedCells(0).RowIndex
        Dim ikinciDeger As Object = DataGridView1.Rows(secilenSatirIndex).Cells(2).Value
        marka_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 0, "String"))
        model_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 1, "String"))
        serino_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 2, "String"))
        renk_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 3, "String"))
        km_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 4, "Integer"))
        yakit_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 5, "String"))
        plaka_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 6, "String"))
        fiyat_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 7, "String"))
        durum_box.Text = (dc.Get_Single_Data(path, "araclar", "seri_no", "'" & ikinciDeger & "'", 8, "String"))
    End Sub
End Class

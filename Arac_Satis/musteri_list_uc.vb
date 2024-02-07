Imports System.Runtime.InteropServices.WindowsRuntime

Public Class musteri_list_uc
    Dim dc As Database_Control = New Database_Control
    Dim path As String = Application.StartupPath & "\database.db"
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        fullname_box.Clear()
        tc_box.Clear()
        telno_box.Clear()
        eposta_box.Clear()
        adres_box.Clear()
    End Sub

    Private Function empty_check() As Integer
        If fullname_box.Text = String.Empty Or tc_box.Text = String.Empty Or telno_box.Text = String.Empty Or eposta_box.Text = String.Empty Or adres_box.Text = String.Empty Then
            MsgBox("Lüften tüm alanları doldurunuz.")
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '**' 'Güncelle'
        If empty_check() <> 1 Then

            dc.Update_Data(path, "musteriler", "tam_ad", fullname_box.Text, "tc_no", tc_box.Text)
            dc.Update_Data(path, "musteriler", "tel_no", telno_box.Text, "tc_no", tc_box.Text)
            dc.Update_Data(path, "musteriler", "e_mail", eposta_box.Text, "tc_no", tc_box.Text)
            dc.Update_Data(path, "musteriler", "adres", adres_box.Text, "tc_no", tc_box.Text)
            Update_List()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '**' 'Kaydı Sil'

        If empty_check() <> 1 Then
            dc.Delete_Data(path, "musteriler", "tc_no", tc_box.Text)
            fullname_box.Clear()
            tc_box.Clear()
            telno_box.Clear()
            eposta_box.Clear()
            adres_box.Clear()
            Update_List()
        End If


    End Sub

    Public Sub Update_List()
        DataGridView1.DataSource = dc.Connect_Data(path, "musteriler", DataGridView1)
    End Sub
    Private Sub musteri_list_uc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_List()
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim secilenSatirIndex As Integer = DataGridView1.SelectedCells(0).RowIndex
        Dim ikinciDeger As Object = DataGridView1.Rows(secilenSatirIndex).Cells(1).Value

        fullname_box.Text = (dc.Get_Single_Data(path, "musteriler", "tc_no", "'" & ikinciDeger & "'", 0, "String"))
        tc_box.Text = (dc.Get_Single_Data(path, "musteriler", "tc_no", "'" & ikinciDeger & "'", 1, "String"))
        telno_box.Text = (dc.Get_Single_Data(path, "musteriler", "tc_no", "'" & ikinciDeger & "'", 2, "String"))
        eposta_box.Text = (dc.Get_Single_Data(path, "musteriler", "tc_no", "'" & ikinciDeger & "'", 3, "String"))
        adres_box.Text = (dc.Get_Single_Data(path, "musteriler", "tc_no", "'" & ikinciDeger & "'", 4, "String"))
    End Sub
End Class

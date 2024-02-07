Imports System.IO

Public Class arac_ekle_uc
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


    Private Function empty_check() As Integer
        If model_box.Text = String.Empty Or marka_box.Text = String.Empty Or serino_box.Text = String.Empty Or renk_box.Text = String.Empty Or km_box.Text = String.Empty Or yakit_box.Text = String.Empty Or plaka_box.Text = String.Empty Or fiyat_box.Text = String.Empty Or durum_box.Text = String.Empty Then
            MsgBox("Lütfen tüm alanları doldurunuz.")
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '**' 'Kayıt'
        If empty_check() <> 1 Then
            Dim columns_list As List(Of String) = New List(Of String)
            columns_list.Add("marka")
            columns_list.Add("model")
            columns_list.Add("seri_no")
            columns_list.Add("renk")
            columns_list.Add("km")
            columns_list.Add("yakit")
            columns_list.Add("plaka")
            columns_list.Add("fiyat")
            columns_list.Add("durum")

            Dim value_list As List(Of String) = New List(Of String)
            value_list.Add(marka_box.Text)
            value_list.Add(model_box.Text)
            value_list.Add(serino_box.Text)
            value_list.Add(renk_box.Text)
            value_list.Add(km_box.Text)
            value_list.Add(yakit_box.Text)
            value_list.Add(plaka_box.Text)
            value_list.Add(fiyat_box.Text)
            value_list.Add(durum_box.Text)


            Dim result = dc.Insert_Data(path, "araclar", columns_list, value_list)
            If result <> 1 Then
                MsgBox("Kayıt Hatası")
            Else
                model_box.Clear()
                marka_box.Clear()
                serino_box.Clear()
                renk_box.Clear()
                km_box.Clear()
                yakit_box.Text = String.Empty
                plaka_box.Clear()
                fiyat_box.Clear()
                durum_box.Text = String.Empty
            End If
        End If


    End Sub
End Class

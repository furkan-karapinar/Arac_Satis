Public Class musteri_ekle_uc

    Dim dc As Database_Control = New Database_Control
    Dim path As String = Application.StartupPath & "\database.db"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fullname_box.Clear()
        tc_box.Clear()
        telno_box.Clear()
        eposta_box.Clear()
        adres_box.Clear()
    End Sub

    Private Function empty_check() As Integer
        If fullname_box.Text = String.Empty Or tc_box.Text = String.Empty Or telno_box.Text = String.Empty Or eposta_box.Text = String.Empty Or adres_box.Text = String.Empty Then
            MsgBox("Lütfen tüm alanları doldurun.")
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '**' 'KAYIT' 

        If empty_check() <> 1 Then
            Dim columns_list As List(Of String) = New List(Of String)
            columns_list.Add("tam_ad")
            columns_list.Add("tc_no")
            columns_list.Add("tel_no")
            columns_list.Add("e_mail")
            columns_list.Add("adres")

            Dim value_list As List(Of String) = New List(Of String)
            value_list.Add(fullname_box.Text)
            value_list.Add(tc_box.Text)
            value_list.Add(telno_box.Text)
            value_list.Add(eposta_box.Text)
            value_list.Add(adres_box.Text)


            Dim result = dc.Insert_Data(path, "musteriler", columns_list, value_list)
            If result <> 1 Then
                MsgBox("Kayıt Hatası")
            Else
                fullname_box.Clear()
                tc_box.Clear()
                telno_box.Clear()
                eposta_box.Clear()
                adres_box.Clear()
            End If
        End If


    End Sub
End Class

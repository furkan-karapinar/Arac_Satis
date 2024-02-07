Public Class satislar_uc

    Dim dc As Database_Control = New Database_Control
    Dim path As String = Application.StartupPath & "\database.db"

    Private Sub listele()
        Try
            DataGridView1.DataSource = dc.Returnable_satis(path, DateTimePicker1.Value.Date)


            Dim toplamFiyat As Decimal = 0

            For Each satir As DataGridViewRow In DataGridView1.Rows
                If Not satir.IsNewRow Then
                    Dim fiyat As Decimal
                    If Decimal.TryParse(satir.Cells("fiyat").Value.ToString(), fiyat) Then
                        toplamFiyat += fiyat
                    End If
                End If
            Next

            Label2.Text = "Gün İçi Toplam Kazanç: " & toplamFiyat.ToString
        Catch ex As Exception
            Label2.Text = "Gün İçi Toplam Kazanç: 0"
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '**' 'Listele'

        listele()
    End Sub

    Private Sub satislar_uc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
End Class

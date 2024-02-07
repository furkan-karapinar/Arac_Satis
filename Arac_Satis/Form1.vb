Imports Bunifu.Framework.UI

Public Class Form1

    Dim dc As Database_Control = New Database_Control
    Dim path As String = Application.StartupPath & "\database.db"

    Dim miekle_uc As New musteri_ekle_uc
    Dim milist_uc As New musteri_list_uc
    Dim acekle_uc As New arac_ekle_uc
    Dim aclist_uc As New arac_list_uc
    Dim szlsm_uc As New sozlesme_uc
    Dim sts_uc As New satislar_uc

    Dim orj_b_color = Color.FromKnownColor(KnownColor.Control)
    Dim sel_b_color = Color.FromKnownColor(KnownColor.ActiveCaption)

    Private Function selected_btn(ByVal sel_btn As BunifuTileButton) As BunifuTileButton



        musteri_ekle_btn.color = orj_b_color
        musteri_list_btn.color = orj_b_color
        arac_ekle_btn.color = orj_b_color
        arac__list_btn.color = orj_b_color
        sozlesme_btn.color = orj_b_color
        satis_btn.color = orj_b_color

        musteri_ekle_btn.colorActive = orj_b_color
        musteri_list_btn.colorActive = orj_b_color
        arac_ekle_btn.colorActive = orj_b_color
        arac__list_btn.colorActive = orj_b_color
        sozlesme_btn.colorActive = orj_b_color
        satis_btn.colorActive = orj_b_color

        musteri_ekle_btn.ForeColor = Color.Black
        musteri_list_btn.ForeColor = Color.Black
        arac_ekle_btn.ForeColor = Color.Black
        arac__list_btn.ForeColor = Color.Black
        sozlesme_btn.ForeColor = Color.Black
        satis_btn.ForeColor = Color.Black

        sel_btn.color = sel_b_color
        sel_btn.colorActive = sel_b_color
        sel_btn.ForeColor = Color.DarkBlue
        Return sel_btn
    End Function

    Private Sub cikis_btn_Click(sender As Object, e As EventArgs) Handles cikis_btn.Click
        End
    End Sub

    Private Sub musteri_ekle_btn_Click(sender As Object, e As EventArgs) Handles musteri_ekle_btn.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(miekle_uc)
        musteri_ekle_btn = selected_btn(musteri_ekle_btn)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miekle_uc.Dock = DockStyle.Fill
        milist_uc.Dock = DockStyle.Fill
        acekle_uc.Dock = DockStyle.Fill
        aclist_uc.Dock = DockStyle.Fill
        szlsm_uc.Dock = DockStyle.Fill
        sts_uc.Dock = DockStyle.Fill


        Dim musteriler_list As List(Of String) = New List(Of String)
        musteriler_list.Add("tam_ad VARCHAR")
        musteriler_list.Add("tc_no VARCHAR")
        musteriler_list.Add("tel_no VARCHAR")
        musteriler_list.Add("e_mail VARCHAR")
        musteriler_list.Add("adres VARCHAR")


        Dim araclar_list As List(Of String) = New List(Of String)
        araclar_list.Add("marka VARCHAR")
        araclar_list.Add("model VARCHAR")
        araclar_list.Add("seri_no VARCHAR")
        araclar_list.Add("renk VARCHAR")
        araclar_list.Add("km INTEGER")
        araclar_list.Add("yakit VARCHAR")
        araclar_list.Add("plaka VARCHAR")
        araclar_list.Add("fiyat VARCHAR")
        araclar_list.Add("durum VARCHAR")

        Dim satislar_list As List(Of String) = New List(Of String)
        satislar_list.Add("id INTEGER PRIMARY KEY")
        satislar_list.Add("tc_no VARCHAR")
        satislar_list.Add("tam_ad VARCHAR")
        satislar_list.Add("tel_no VARCHAR")
        satislar_list.Add("ehliyet_no VARCHAR")
        satislar_list.Add("ehliyet_tarihi VARCHAR")
        satislar_list.Add("marka VARCHAR")
        satislar_list.Add("model VARCHAR")
        satislar_list.Add("seri_no VARCHAR")
        satislar_list.Add("renk VARCHAR")
        satislar_list.Add("plaka VARCHAR")
        satislar_list.Add("fiyat VARCHAR")
        satislar_list.Add("satis_tarihi VARCHAR")


        dc.Create_Datatable(path, "musteriler", musteriler_list)
        dc.Create_Datatable(path, "araclar", araclar_list)
        dc.Create_Datatable(path, "satislar", satislar_list)


    End Sub

    Private Sub musteri_list_btn_Click(sender As Object, e As EventArgs) Handles musteri_list_btn.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(milist_uc)
        milist_uc.Update_List()
        musteri_list_btn = selected_btn(musteri_list_btn)
    End Sub

    Private Sub arac_ekle_btn_Click(sender As Object, e As EventArgs) Handles arac_ekle_btn.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(acekle_uc)
        arac_ekle_btn = selected_btn(arac_ekle_btn)
    End Sub

    Private Sub arac__list_btn_Click(sender As Object, e As EventArgs) Handles arac__list_btn.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(aclist_uc)
        arac__list_btn = selected_btn(arac__list_btn)
    End Sub

    Private Sub sozlesme_btn_Click(sender As Object, e As EventArgs) Handles sozlesme_btn.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(szlsm_uc)
        sozlesme_btn = selected_btn(sozlesme_btn)
    End Sub

    Private Sub satis_btn_Click(sender As Object, e As EventArgs) Handles satis_btn.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(sts_uc)
        satis_btn = selected_btn(satis_btn)
    End Sub
End Class

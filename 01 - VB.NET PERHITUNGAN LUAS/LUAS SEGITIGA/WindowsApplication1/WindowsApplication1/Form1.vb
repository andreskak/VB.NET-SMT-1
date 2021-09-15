Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ll.Click

        Dim setengah As Double
        Dim alas As Integer
        Dim tinggi As Integer
        Dim hasil As Double


        setengah = 0.5
        alas = Val(alas_t.Text)
        tinggi = Val(tinggi_t.Text)





        hasil = setengah * alas * tinggi
        ll_text.Text = hasil


    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

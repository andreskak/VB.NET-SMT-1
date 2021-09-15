Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_luas.Click



        'variabel sisi1,sisi2 dan type data nya integer
        Dim sisi As String
        Dim Hasil As Integer

        'input
        sisi = 15

        'proses inisialisasi
        Hasil = sisi * sisi

        'output hasil 
        tb_luas.Text = Hasil


    End Sub
End Class

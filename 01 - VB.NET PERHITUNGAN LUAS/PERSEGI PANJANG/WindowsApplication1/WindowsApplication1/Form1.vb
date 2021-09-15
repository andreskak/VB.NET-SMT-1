Public Class Form1

    Private Sub btn_psj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_psj.Click
        'var and type data
        Dim panjang As Integer
        Dim lebar As Integer
        Dim hp As String

        panjang = 7
        lebar = 10

        'import
        hp = panjang * lebar

        tb_pl.Text = hp

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

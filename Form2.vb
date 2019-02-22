Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tampung As String
        tampung = TextBox3.Text
        TextBox3.Text = TextBox2.Text
        TextBox2.Text = TextBox1.Text
        TextBox1.Text = tampung
    End Sub
End Class
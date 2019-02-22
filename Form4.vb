Public Class Form4
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text
        TextBox4.TextAlign = HorizontalAlignment.Center
    End Sub
End Class
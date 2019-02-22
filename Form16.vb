Public Class Form16
    'Syntax untuk mengecek kesamaan antara textbox1 dan textbox2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            Label3.Text = "SAMA"
        Else
            Label3.Text = "TIDAK SAMA"
        End If
    End Sub
End Class
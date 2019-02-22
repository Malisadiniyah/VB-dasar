Public Class Form21
    Dim a, b As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If a > b Then
            MsgBox("Nilai A terbesar")
        ElseIf b > a Then
            MsgBox("Nilai B terbesar")
        Else
            MsgBox("Nilai A & B sama")
        End If
    End Sub
End Class
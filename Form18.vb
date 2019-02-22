Public Class Form18
    'Deklarasi variabel
    Dim a, b As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'a untuk menampung nilai text1, dan b untuk menampung nilai b
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        'Jika text1 lebih besar dari teks2
        If a > b Then
            MsgBox("Nilai Terbesar adalah : " & a & vbCrLf & "Nilai terkecil adalah : " & b)
            'Jika text1 dan text2 sama
        ElseIf a = b Then
            MsgBox("Nilai Pertama dan kedua sama")
            'Jika text2 lebih besar dari text1
        Else
            MsgBox("Nilai Terbesar adalah : " & b & vbCrLf & "Nilai terkecil adalah : " & a)
        End If
    End Sub
End Class
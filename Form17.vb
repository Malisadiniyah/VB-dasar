Public Class Form17
    'Syntax untuk username dan password, apabila text1 berisi alek dan text2 berasa tampan maka pesannya selamat datang
    'Jika tidak maka peringatan username atau password salah, jangan lupa atur property untuk text2 yaitu password charnya dengan 
    'tanda (*)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "alek" And TextBox2.Text = "tampan" Then
            MsgBox("Selamat Datang")
        Else
            MsgBox("Password atau username yang anda masukkan salah")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
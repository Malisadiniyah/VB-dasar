Public Class Form30
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Menghitung listrik terpakai
        TextBox6.Text = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
        'Menghitung tital listrik di masing - masing rumah
        TextBox17.Text = Val(TextBox1.Text) - Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox12.Text)
        'Membuat status merah apabila tidak ada listrik yang digunakan, hijau apabila listrik digunakan
        If TextBox6.Text <> 0 Then
            Panel1.BackColor = Color.Green
        Else
            Panel1.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Menghitung listrik terpakai
        TextBox7.Text = Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        'Menghitung total listrik di masing - masing rumah
        TextBox17.Text = Val(TextBox1.Text) - Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox12.Text)
        'Membuat status merah apabila tidak ada listrik yang digunakan, hijau apabila listrik digunakan 
        If TextBox7.Text <> 0 Then
            Panel2.BackColor = Color.Green
        Else
            Panel2.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Menghitung listrik terpakai
        TextBox12.Text = Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text)
        'Menghitung total listrik di masing - masing rumah
        TextBox17.Text = Val(TextBox1.Text) - Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox12.Text)
        'Membuat status merah apabila tidak ada listrik yang digunakan, hijau apabila listrik digunakan
        If TextBox12.Text <> 0 Then
            Panel3.BackColor = Color.Green
        Else
            Panel3.BackColor = Color.Red
        End If
    End Sub
End Class
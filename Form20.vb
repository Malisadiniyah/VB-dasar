Public Class Form20
    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Bulan==========================
        ComboBox1.Items.Add("01")
        ComboBox1.Items.Add("02")
        ComboBox1.Items.Add("03")
        ComboBox1.Items.Add("04")
        ComboBox1.Items.Add("05")
        ComboBox1.Items.Add("06")
        ComboBox1.Items.Add("07")
        ComboBox1.Items.Add("08")
        'Tahun==========================
        ComboBox2.Items.Add("1998")
        ComboBox2.Items.Add("1999")
        ComboBox2.Items.Add("2000")
        'Agama==========================
        ComboBox3.Items.Add("Islam")
        ComboBox3.Items.Add("Kristen")
        ComboBox3.Items.Add("Hindu")
        ComboBox3.Items.Add("Budha")
        ComboBox3.Items.Add("Kong hu cu")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'menghitung total
        Label1.Text = Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        'menghitung rata-rata
        Label2.Text = Val(Label11.Text) / 4
        'menentukan kelulusan
        If Val(Label12.Text) >= 75 Then
            MsgBox("Selamat Anda lulus", vbInformation, "100 program says")
        Else
            MsgBox("Maaf Anda belum lulus", vbInformation, "100 program says")
        End If
    End Sub
End Class
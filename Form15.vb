Public Class Form15
    'Menampilkan Combobox dengan bulan dan tahun saat form diplay / start
    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Januari")
        ComboBox1.Items.Add("Februari")
        ComboBox1.Items.Add("Maret")
        ComboBox1.Items.Add("April")
        ComboBox1.Items.Add("Mei")
        ComboBox1.Items.Add("Juni")
        ComboBox1.Items.Add("Juli")
        ComboBox1.Items.Add("Agustus")
        ComboBox1.Items.Add("September")
        ComboBox1.Items.Add("Oktober")
        ComboBox1.Items.Add("Nopember")
        ComboBox1.Items.Add("Desember")
        'Tahun===============================|
        ComboBox2.Items.Add("1998")
        ComboBox2.Items.Add("1999")
        ComboBox2.Items.Add("2000")
        ComboBox2.Items.Add("2001")
        ComboBox2.Items.Add("2002")
    End Sub
    Dim jk As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Menyimpan nilai radiobutton yang dipilih
        If RadioButton1.Checked = True Then
            jk = RadioButton1.Text
        Else
            jk = RadioButton2.Text
        End If
        'Menampilkan pesan
        MsgBox("Nama : " & TextBox1.Text & vbCrLf & "Tanggal Lahir : " & TextBox2.Text & " " & ComboBox1.Text & "-" & ComboBox2.Text & vbCrLf & "Jenis Kelamin : " & jk & vbCrLf & "Alamat : " & TextBox3.Text)
    End Sub
End Class
Public Class Form12
    'Syntax untuk mengaktifkan textbox agar siap ditambah
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Enabled = True
    End Sub
    'Syntax dibawah untuk menyimpan textbox ke dalam listbox
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Enabled = True
        ListBox1.Items.Add(TextBox1.Text)
    End Sub
    'Sintax dibawah untuk menghapus list dari listbox yang dipilih

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
    'Syntax dibawah untuk menghapus seluruh data pada listbox 

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub
    'Syntax dibawah untuk menampilkan daftar data pada listbox saat form di start / di play

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Sapi")
        ListBox1.Items.Add("Kuda")
        ListBox1.Items.Add("Singa")
        ListBox1.Items.Add("Gajah")
        TextBox1.Enabled = False
    End Sub
End Class
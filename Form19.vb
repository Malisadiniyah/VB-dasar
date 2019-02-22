Public Class Form19
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'Saat memilih hewan pada listbox maka text disampingnya akan menampilkan karakteristik dari hewan yang kita pilih
        Select Case ListBox1.SelectedItem
            Case Is = "Ayam"
                TextBox1.Text = "Hewan unggas yang biasanya berkokok dipagi hari, Biasanya dipelihara sebagai hewan ternak"
            Case Is = "Gajah"
                TextBox1.Text = "Salah satu hewan darat terbesar, memiliki gading, belalai dan kuping yang besar"
            Case Is = "Jerapah"
                TextBox1.Text = "Salat satu hewan tertinggi di dunia, memiliki leher yang panjang dan pemakan tumbuhan"
            Case Is = "Cicak"
                TextBox1.Text = "Hewan yang mampu berjalan di dinding, dan memiliki teknik perlindungan tubuh yaitu autotomi"
            Case Is = "Kuda"
                TextBox1.Text = "Hewan kuat yang biasa ditunggangi untuk berperang atau berkelahi"
        End Select
    End Sub
    'Menampilkan daftar hewan pada listbox
    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Ayam")
        ListBox1.Items.Add("Gajah")
        ListBox1.Items.Add("Jerapah")
        ListBox1.Items.Add("Cicak")
        ListBox1.Items.Add("Kuda")
    End Sub
End Class
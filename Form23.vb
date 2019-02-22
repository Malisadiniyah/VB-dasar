Public Class Form23
    'Untuk menghitung jumlah data pada listbox 2
    Sub hitung()
        Label3.Text = ListBox2.Items.Count & "Item"
    End Sub
    'Untuk menambahkan Makana pada listbox 1
    Sub tambah()
        With ListBox1.Items
            .Add("Nasi Goreng Cinta")
            .Add("Bebek Rebus jahe")
            .Add("Cumi - cumi Casablanca")
            .Add("Krecek Tahu")
        End With
        hitung()
    End Sub
    'Memanggil fungsi tambah saat form di play
    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tambah()
    End Sub
    'Menambahkan item dari listbox1 ke listbox2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("pilih makanan yang ingin anda pesan")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
        hitung()
    End Sub
    'Menghapus seluruh pesanan
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        tambah()
        hitung()
    End Sub
End Class
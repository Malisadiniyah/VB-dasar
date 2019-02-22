Public Class Form13
    'Syntax dibawah untuk menghapus data yang dipilih pada listbox
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
    'Syntax dibawah untuk menghidupkan dan mengosongkan tanda centang pada checkbox
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
    End Sub
    'Syntax dibawah untuk mengeluarkan form
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
    'Syntax dibawah untuk menambahkan tulisan pada checkbox ke dalam listbox
    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ListBox1.Items.Add(CheckBox1.Text)
        CheckBox1.Enabled = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        ListBox1.Items.Add(CheckBox2.Text)
        CheckBox2.Enabled = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        ListBox1.Items.Add(CheckBox3.Text)
        CheckBox3.Enabled = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        ListBox1.Items.Add(CheckBox4.Text)
        CheckBox4.Enabled = False
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        ListBox1.Items.Add(CheckBox5.Text)
        CheckBox5.Enabled = False
    End Sub
End Class
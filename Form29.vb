﻿Public Class Form29
    'Menambahkan data jabatan ke combo1
    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Direktur")
            .Add("Manajer")
            .Add("Sekertaris")
        End With
    End Sub
    'Menghitung total gaji yang diterima
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox6.Text = Val(TextBox3.Text) + Val(TextBox4.Text) - Val(TextBox5.Text) * Val(TextBox3.Text)
    End Sub
    'Menampilkan gaji, tunjangan dan pajak sesuai dengan jabatan yang dipilih
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Direktur" Then
            TextBox3.Text = 10000000
            TextBox4.Text = 2500000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Manajer" Then
            TextBox3.Text = 7000000
            TextBox4.Text = 2000000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Sekertaris" Then
            TextBox3.Text = 4000000
            TextBox4.Text = 1000000
            TextBox5.Text = 0.1
        End If
    End Sub
End Class
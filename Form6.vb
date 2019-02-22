Public Class Form6

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        Call nama()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call nama()
    End Sub
    Sub nama()
        Dim a As String
        a = InputBox("Ketikkan Nama Anda", "Informasi")
        TextBox1.Text = a
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Nama : " & TextBox1.Text & vbCrLf & "Alamat : " & TextBox2.Text & vbCrLf & "Tanggal Lahir : " & TextBox3.Text + " - " + TextBox4.Text + " - " + TextBox5.Text, vbInformation, "Informasi Tentang Anda")
    End Sub
End Class
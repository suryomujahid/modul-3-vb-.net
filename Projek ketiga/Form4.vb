Public Class Form4
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Mohon tulis dengan benar.")
        ElseIf ListBox1.Items.Contains(TextBox1.Text) Then
            MsgBox("Maaf makanan sudah ada didaftar.")
        Else
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Mohon pilih terlebih dahulu makanannya.")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class
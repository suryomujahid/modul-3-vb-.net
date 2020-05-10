Public Class Form3
    Sub hitung()
        Label3.Text = ListBox2.Items.Count & "Item"
    End Sub
    Sub tambah()
        With ListBox1.Items
            .Add("Nasi Gore")
            .Add("Bebek reBOSS")
            .Add("Cumi-cumi percuma")
            .Add("Tahu bulat 500-an")
        End With
        hitung()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Mohon pilih terlebih dahulu makanan yang ingin dipesan.")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
        hitung()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tambah()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Mohon pilih terlebih dahulu makanan yang ingin dihapus.")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
        hitung()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        hitung()
        tambah()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class
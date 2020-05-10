Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Dim a, b As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If a > b Then
            MsgBox("Nilai A Terbesar")
        ElseIf b > a Then
            MsgBox("Nilai B Terbesar")
        Else
            MsgBox("Nilai A & B Sama")
        End If
    End Sub
End Class

﻿Public Class Form9
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Direktur" Then
            TextBox3.Text = 10000000
            TextBox4.Text = 2500000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Manager" Then
            TextBox3.Text = 7000000
            TextBox4.Text = 200000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Sekretaris" Then
            TextBox3.Text = 4000000
            TextBox4.Text = 100000
            TextBox5.Text = 0.1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = (Val(TextBox3.Text) + Val(TextBox4.Text)) - (Val(TextBox5.Text) * Val(TextBox3.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class
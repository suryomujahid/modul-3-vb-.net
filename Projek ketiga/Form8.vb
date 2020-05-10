Public Class Form8
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case Is = "Sumatera"
                With ListBox1.Items
                    .Clear()
                    .Add("NAD")
                    .Add("Sumatera Utara")
                    .Add("Sumatera Barat")
                    .Add("Palembang")
                    .Add("Lampung")
                    .Add("Riau")
                End With
            Case Is = "Kalimantan"
                With ListBox1.Items
                    .Clear()
                    .Add("Kalimantan Barat")
                    .Add("Kalimatan Utara")
                    .Add("Kalimantan Selatan")
                    .Add("Kalimantan Timur")
                End With
            Case Is = "Jawa"
                With ListBox1.Items
                    .Clear()
                    .Add("Jawa Barat")
                    .Add("Banten")
                    .Add("Djogjakarta")
                    .Add("Jawa Timur")
                    .Add("Jakarta")
                    .Add("Jawa Tengah")
                End With
            Case Is = "Sulawesi"
                With ListBox1.Items
                    .Clear()
                    .Add("Sulawesi Utara")
                    .Add("Sulawesi Selatan")
                    .Add("Sulawesi Tenggara")
                End With
            Case Is = "Papua"
                With ListBox1.Items
                    .Clear()
                    .Add("Papua Barat")
                End With
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Mohon pilih provinsi.")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Mohon pilih provinsi.")
        Else
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form9.Show()
    End Sub
End Class
Public Class Form6
    Dim s1, s2, s3, s4, s5 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call goldar()
        Call syarat()
        MsgBox("NISN: " & TextBox1.Text & vbCrLf & "Nama Lengkap: " & TextBox2.Text & vbCrLf & "Alamat: " & TextBox3.Text &
               vbCrLf & "Tanggal Lahir: " & DateTimePicker1.Value & vbCrLf & "Agama: " & ComboBox1.Text &
               vbCrLf & "Golongan Darah: " & g & vbCrLf & "Prasyarat: " & vbCrLf & s1 & vbCrLf & s2 & vbCrLf &
               s3 & vbCrLf & s3 & vbCrLf & s4 & vbCrLf & s5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Dim g As String
    Sub goldar()
        If RadioButton1.Checked = True Then
            g = "A"
        ElseIf RadioButton2.Checked = True Then
            g = "O"
        ElseIf RadioButton3.Checked = True Then
            g = "B"
        ElseIf RadioButton4.Checked = True Then
            g = "AB"
        End If
    End Sub
    Sub syarat()
        If CheckBox1.Checked = True Then
            s1 = CheckBox1.Text & " : " & "ADA"
        Else
            s1 = CheckBox1.Text & " : " & "BELUM"
        End If
        If CheckBox2.Checked = True Then
            s2 = CheckBox2.Text & " : " & "ADA"
        Else
            s2 = CheckBox2.Text & " : " & "BELUM"
        End If
        If CheckBox3.Checked = True Then
            s3 = CheckBox3.Text & " : " & "ADA"
        Else
            s3 = CheckBox3.Text & " : " & "BELUM"
        End If
        If CheckBox4.Checked = True Then
            s4 = CheckBox4.Text & " : " & "ADA"
        Else
            s4 = CheckBox4.Text & " : " & "BELUM"
        End If
        If CheckBox5.Checked = True Then
            s5 = CheckBox5.Text & " : " & "ADA"
        Else
            s5 = CheckBox5.Text & " : " & "BELUM"
        End If
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
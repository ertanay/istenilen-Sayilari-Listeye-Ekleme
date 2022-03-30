Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ciftler, tekler, i, j As Integer



        If CheckBox1.Checked And CheckBox2.Checked Then
            MsgBox("1 tane sec!!!!")

        ElseIf CheckBox1.Checked Then
            For i = 1 To 10
                ciftler = ciftler + 1
                If i Mod 2 = 0 Then
                    ComboBox1.Items.Add(ciftler)
                End If
            Next

        ElseIf CheckBox2.Checked Then
            For j = 1 To 10
                tekler = tekler + 1
                If j Mod 2 = 1 Then
                    ComboBox1.Items.Add(tekler)
                End If
            Next
        Else
            MsgBox("1 tane sec!!!!")
        End If

    End Sub


End Class
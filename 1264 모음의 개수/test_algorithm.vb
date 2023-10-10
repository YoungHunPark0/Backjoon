Public Class test_algorithm
    '1264'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim alphabet As String = "aeiouAEIOU"
        Dim input() As String = input_textbox.Text.Split(vbCrLf)
        Dim count1 As Integer
        Dim outputText As String = ""

        For Each j As String In input
            count1 = 0

            For Each i As Char In j
                If alphabet.Contains(i) Then
                    count1 += 1
                ElseIf i = "#" Then
                    GoTo skip
                End If
            Next
            outputText &= count1.ToString() & vbCrLf
        Next

skip:
        output_textbox.Text = outputText
    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles input_textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub


End Class
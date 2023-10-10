Public Class test_algorithm
    '2439'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As Integer = input_textbox.Text
        Dim input As Integer = inbox
        Dim outputText As String = ""
        Dim i As Integer
        Dim j As Integer

        For i = 1 To input
            For j = 1 To input
                If j <= input - i Then
                    outputText &= " "
                Else
                    outputText &= "*"
                End If
                'For j = i To input - 1
                '    outputText &= " "
                'Next j

                'For j = 1 To i
                '    outputText &= "*"
                'Next j
                'outputText &= vbCrLf
                'Next i
            Next j

            outputText &= vbCrLf
        Next i
skip:
        output_textbox.Text = outputText
    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles input_textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub


End Class
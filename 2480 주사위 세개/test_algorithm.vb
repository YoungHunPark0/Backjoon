Public Class test_algorithm
    '2439'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As String = input_textbox.Text
        Dim input() As String = inbox.Split(" ")
        Dim outputText As String = ""
        Dim i As Integer
        Dim j As Integer
        'Dim k As Integer
        'Dim array() As String
        Dim max As Integer = 0
        Dim counter(6) As Integer
        Dim countvalue As Integer

        For i = 0 To input.Length - 1
            countvalue = Integer.Parse(input(i))
            For j = 0 To input.Length - 1
                If Integer.Parse(input(j)) = countvalue Then
                    counter(countvalue) += 1
                End If
            Next j

            If counter(countvalue) = 3 Then
                outputText = 10000 + countvalue * 1000
                GoTo skip
            ElseIf counter(countvalue) = 2 Then
                outputText = 1000 + countvalue * 100
                GoTo skip
            End If

            If countvalue > max Then
                max = countvalue
            End If
        Next i

        If outputText = "" Then
            outputText = max * 100
        End If

        'array = inbox
        'i = array(0)
        'j = array(1)
        'k = array(2)

        'If i = j And j = k Then
        '    outputText = (10000 + (i * 1000))
        'ElseIf i = j And j <> k Then
        '    outputText = (1000 + (i * 100))
        'ElseIf i = k And k <> j Then
        '    outputText = (1000 + (i * 100))
        'ElseIf j = k And k <> i Then
        '    outputText = (1000 + (j * 100))
        'ElseIf i > j And i > k Then
        '    outputText = (i * 100)
        'ElseIf j > i And j > k Then
        '    outputText = (j * 100)
        'ElseIf k > i And k > j Then
        '    outputText = (k * 100)
        'End If
skip:
        output_textbox.Text = outputText
    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles input_textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub


End Class
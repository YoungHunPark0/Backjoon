Public Class test_algorithm
    '2742 기찍N'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As String = CInt(input_textbox.Text)
        Dim outputText As String = ""
        Dim i As Integer
        'Dim j As Integer
        'j = inbox

        ' 2. 역순으로 계산하는 for문
        ' For 카운터 변수 = 시작 값 To 끝 값 Step 증가 값
        For i = inbox To 1 Step -1
            outputText &= i & vbCrLf
        Next i

        ' 1.처음으로 생각한 for문
        ' 이렇게 하니 10이상 입력값 들어가면 1로 초기화됨.
        'For i = 0 To inbox - 1
        '    '밑에 for문 실행시 입력값 부터 시작안해서 넣음
        '    If inbox = j Then
        '        outputText &= j & vbCrLf
        '        j -= 1
        '    ElseIf j > 1 Then
        '        j -= 1
        '    ElseIf j = 1 Then
        '        GoTo skip
        '    End If
        '    outputText &= j & vbCrLf
        'Next i

skip:
        output_textbox.Text = outputText
    End Sub

End Class
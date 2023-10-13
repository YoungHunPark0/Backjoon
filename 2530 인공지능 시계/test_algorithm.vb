Public Class test_algorithm
    '2530'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As String = input_textbox.Text
        Dim input() As String = inbox.Split(CChar(" "), vbCrLf)
        Dim outputText As String = ""
        Dim hour As Integer = CInt(input(0))
        Dim min As Integer = CInt(input(1))
        Dim sec As Integer = CInt(input(2))
        Dim cook As Integer = CInt(input(3))
        'Dim endhour As Integer
        'Dim endmin As Integer
        'Dim endsec As Integer
        Dim total As DateTime




        total = New Date(2000, 1, 1, hour, min, sec)

        total = DateAdd(DateInterval.Second, cook, total)

        If total.Hour >= 24 Then
            total = DateAdd(DateInterval.Hour, -24, total)
        End If

        outputText = total.ToString("H mm ss")
        'EX_DATE.Text = Format(Today, "yyyy-MM-dd").ToString
        'Format(DateAdd(DateInterval.Day, 1, Today), "yyyy-MM-dd").ToString = EX_DATE.Text
        ''cooktime = DateAdd(DateInterval.Second, cook, cooktime) ' stdt.Value = DateAdd("m", -3, Now) 이렇게 하는건지 알았는데 dateadd사용법을 알게됨



        '2. 다른방법으로 풀어본 것.
        'total = hour * 3600 + min * 60 + sec + cook

        'endhour = (total \ 3600) Mod 24
        'endmin = (total \ 60) Mod 60
        'endsec = total Mod 60

        'outputText = endhour & " " & endmin & " " & endsec

        'If endhour = 24 Then
        '    outputText = "0"
        'ElseIf endhour > 24 Then
        '    endhour = endhour - 24
        '    outputText += endhour
        'End If

skip:
        output_textbox.Text = outputText
    End Sub

    'If total.Hour >= 24 Then
    '    total = New DateTime(2000, 1, 1, total.Hour - 24, total.Minute, total.Second)
    'End If

    '엔터'
    'Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles input_textbox.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Button1.PerformClick()
    '    End If
    'End Sub

    '1. 전부 sec으로 통합한 후 계산하는 방식
    'Split을 통해서 1가지가 아닌 2가지로 하고 싶었는데 방법을 몰라서 검색
    '.Split 인수에는 문자열 유형이 아닌 “Char”(문자) 유형이 필요.
    '1." "c => .NET 문법에서 "이 공간을 문자열이 아닌 문자로 사용"을 의미.
    '2.CChar() 식을 char데이터형식으로 변환
    '/   : 나누기
    '\   : 정수나누기의 몫
    'Mod : 정수나누기의 나머지


End Class
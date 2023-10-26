Imports System.Collections.Generic

Public Class test_algorithm
    '1076 저항 - 브론즈2'
    '문제

    '전자 제품에는 저항이 들어간다. 저항은 색 3개를 이용해서 그 저항이 몇 옴인지 나타낸다. 처음 색 2개는 저항의 값이고, 마지막 색은 곱해야 하는 값이다. 저항의 값은 다음 표를 이용해서 구한다.
    '----------------------------
    '색	값	곱
    'black	0	1
    'brown	1	10
    'red	2	100
    'orange	3	1,000
    'yellow	4	10,000
    'green	5	100,000
    'blue	6	1,000,000
    'violet	7	10,000,000
    'grey	8	100,000,000
    'white	9	1,000,000,000
    '예를 들어, 저항의 색이 yellow, violet, red였다면 저항의 값은 4,700이 된다.
    '------------------------------
    '입력
    '첫째 줄에 첫 번째 색, 둘째 줄에 두 번째 색, 셋째 줄에 세 번째 색이 주어진다. 위의 표에 있는 색만 입력으로 주어진다.

    '출력
    '입력으로 주어진 저항의 저항값을 계산하여 첫째 줄에 출력한다.

    '예제 입력 1 
    'yellow
    'violet
    'red
    '예제 출력 1 
    '4700

    '예제 입력 2 
    'orange
    'red
    'blue
    '예제 출력 2 
    '32000000

    '예제 입력 3 
    'white
    'white
    'white
    '예제 출력 3 
    '99000000000
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As String = input_textbox.Text
        Dim input() As String = inbox.Split(vbCrLf)
        Dim outputText As String = ""
        Dim colors(,) As String = {
               {"black", "0"},
               {"brown", "1"},
               {"red", "2"},
               {"orange", "3"},
               {"yellow", "4"},
               {"green", "5"},
               {"blue", "6"},
               {"violet", "7"},
               {"grey", "8"},
               {"white", "9"}
           }

        Dim i As Integer
        Dim j As Integer
        Dim color As String
        Dim res As Double
        Dim resval(2) As Integer

        For i = 0 To input.Length - 1
            color = input(i).Trim()
            ' 1차원배열 - length
            ' 2차원배열에서는 getlength 사용
            ' length - 배열길이, length() - 문자열길이
            ' 1차원 배열처럼 쓰면 전체 배열 갯수를 반환한다.
            For j = 0 To colors.GetLength(0) - 1 ' 인덱스 0의 배열길이를 반환
                If colors(j, 0) = color Then
                    resval(i) = CInt(colors(j, 1))
                End If
            Next j
        Next i
        ' res를 integer로 하니까 오버플로우 생겨서 double로 변경함
        res = (resval(0) * 10 + resval(1)) * Math.Pow(10, resval(2))

        outputText = res.ToString()

skip:
        output_textbox.Text = outputText
    End Sub
    ' 이런형식으로 하니까 string을 integer인식을 못함
    ' 1차원배열로 정의
    'Dim black() As Integer = {0, 1}
    'Dim brown() As Integer = {1, 10}
    'Dim red() As Integer = {2, 100}
    'Dim orange() As Integer = {3, 1000}
    'Dim yellow() As Integer = {4, 10000}
    'Dim green() As Integer = {5, 100000}
    'Dim blue() As Integer = {6, 1000000}
    'Dim violet() As Integer = {7, 10000000}
    'Dim grey() As Integer = {8, 100000000}
    'Dim white() As Integer = {9, 1000000000}
    'Dim i As Integer
    'Dim j As Integer
    'Dim color() As String
    'Dim res() As Integer
    'Dim res2 As Integer
    'Dim colors() As String = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"}

    'For i = 0 To input.Length - 1
    '        color = input(i).Split("")
    '        res2 = 0
    '        For j = 0 To color.Length - 1
    '            res = colors(color(j))
    '            res2 += res(0) * res(1)
    '        Next j
    '        outputText &= res2 & vbCrLf
    '    Next i

    '2. 이렇게 하니 배열값을 못찾아옴

    '        Dim black As Integer = "0"
    '    Dim brown As Integer = "1"
    '    Dim red As Integer = "2"
    '    Dim orange As Integer = "3"
    '    Dim yellow As Integer = "4"
    '    Dim green As Integer = "5"
    '    Dim blue As Integer = "6"
    '    Dim violet As Integer = "7"
    '    Dim grey As Integer = "8"
    '    Dim white As Integer = "9"
    '    Dim colors() As String = {"black, brown, red, orange, yellow, green, blue, violet, grey, white"}
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim color() As String
    '    Dim res As Integer

    '    For i = 0 To input.Length - 1
    '            color = input(i).Split("")
    '            res = 0
    '            For j = 0 To color.Length - 1
    '                res = res * 10 + color(j)
    '            Next j
    '            outputText &= res & vbCrLf
    '        Next i

    'Dim outputText As String = ""
    '' 여러개의 배열에서 해당값을 얻으려면 딕셔너리를 사용하는것이 좋다.
    'Dim colorval As New Dictionary(Of String, Integer)
    'colorval("black") = 0
    'colorval("brown") = 1
    'colorval("red") = 2
    'colorval("orange") = 3
    'colorval("yellow") = 4
    'colorval("green") = 5
    'colorval("blue") = 6
    'colorval("violet") = 7
    'colorval("grey") = 8
    'colorval("white") = 9
    'For i = 0 To input.Length - 1
    '        color = input(i).Split(vbLf)
    '        res = 0
    '        For j = 0 To color.Length - 1
    '            res = res * 10 + colorval(color(j))
    '        Next j
    '        outputText &= res & vbCrLf
    '    Next i

End Class
Public Class test_algorithm
    '2742 기찍N'
    '문제
    '동규는 세수를 하다가 정렬이 하고 싶어졌다.
    '정수 여러 개를 생각한 뒤에, 이를 오름차순으로 정렬하고 싶어졌다.
    '정수 여러 개가 주어졌을 때, 가장 작은 수, 입력값의 평균값, 가장 큰 수를 출력하는 프로그램을 작성하시오.

    '입력
    '정수 세 개가 주어진다. 이 수는 1보다 크거나 같고, 1,000,000보다 작거나 같다. 이 수는 모두 다르다.

    '출력
    '제일 작은 수, 그 다음 수, 제일 큰 수를 차례대로 출력한다.

    '예제 입력 
    '3 1 2
    '예제 출력 
    '1 2 3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As String = input_textbox.Text
        Dim input() As String = inbox.Split(" ")
        Dim outputText As String = ""
        Dim i As Integer
        Dim sum As Integer
        Dim num As Integer
        Dim min As Integer = input(0)
        Dim max As Integer = input(0)
        Dim ave As Double

        For i = 0 To input.Length - 1

            num = CInt(input(i))
            If num > max Then
                max = num
            ElseIf num < min Then
                min = num
            End If
            sum += num
        Next i
        ave = sum / input.Length

        outputText = min & " " & ave & " " & max

skip:
        output_textbox.Text = outputText
    End Sub
    'VAL()은 문자를 숫자로 받는 함수. 반대로 STR()는 숫자를 문자로 받는 함수

End Class
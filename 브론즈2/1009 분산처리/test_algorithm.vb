Public Class test_algorithm
    '1075 나누기 - 브론즈2'
    '문제

    '두 정수 N과 F가 주어진다. 지민이는 정수 N의 가장 뒤 두 자리를 적절히 바꿔서 N을 F로 나누어 떨어지게 만들려고 한다. 만약 가능한 것이 여러 가지이면, 뒤 두 자리를 가능하면 작게 만들려고 한다.
    '예를 들어, N = 275이고, F=5이면, 답은 00이다. 200이 5로 나누어 떨어지기 때문이다. N=1021이고, F=11이면, 정답은 01인데, 1001이 11로 나누어 떨어지기 때문이다.

    '입력
    '첫째 줄에 N, 둘째 줄에 F가 주어진다. N은 100보다 크거나 같고, 2,000,000,000보다 작거나 같은 자연수이다. F는 100보다 작거나 같은 자연수이다.

    '출력
    '첫째 줄에 마지막 두 자리를 모두 출력한다. 한자리이면 앞에 0을 추가해서 두 자리로 만들어야 한다.

    '예제 입력 1 
    '1000
    '3
    '예제 출력 1 
    '02
    '예제 입력 2 
    '2000000000
    '100
    '예제 출력 2 
    '00
    '예제 입력 3 
    '23442
    '75
    '예제 출력 3 
    '00
    '예제 입력 4 
    '428392
    '17
    '예제 출력 4 
    '15
    '예제 입력 5 
    '32442
    '99
    '예제 출력 5 
    '72
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As String = input_textbox.Text
        Dim input() As String = inbox.Split(vbCrLf)
        Dim outputText As String = ""
        Dim i As Integer
        Dim j As Integer
        Dim t As Integer = CInt(input(0))
        Dim a As Integer
        Dim b As Integer
        Dim array() As String
        Dim pow As Double

        For i = 1 To t
            array = input(i).Split(CChar(" "))
            a = CInt(array(0))
            b = CInt(array(1))

            pow = CInt(Math.Pow(a, (b Mod 4)) Mod 10)
            'num = CStr(pow.ToString.Substring(pow.ToString.Length - 1, 1))
            If pow = 0 Then
                pow = 10
            End If
            outputText &= pow & vbCrLf
        Next i

skip:
        output_textbox.Text = outputText
    End Sub
    'substring(index, length) 문자열의 index부분부터 length만큼 추출 b = CInt(array(1).Substring(array(1).Length - 1, 1)) 해봤는데
    '9일경우는 9 1 두번만 연속되서 가능한데 7은 7 9 3 1 4번 돔 모두가 같지 않으니 못쓴다.
    'mid를 사용하면 원하는 입력값의 마지막자리를 고정 안됨
End Class
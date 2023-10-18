Public Class test_algorithm
    '1009 분산처리 - 브론즈2'
    '문제

    '재용이는 최신 컴퓨터 10대를 가지고 있다. 어느 날 재용이는 많은 데이터를 처리해야 될 일이 생겨서 각 컴퓨터에 1번부터 10번까지의 번호를 부여하고, 10대의 컴퓨터가 다음과 같은 방법으로 데이터들을 처리하기로 하였다.
    '1번 데이터는 1번 컴퓨터, 2번 데이터는 2번 컴퓨터, 3번 데이터는 3번 컴퓨터, ... ,
    '10번 데이터는 10번 컴퓨터, 11번 데이터는 1번 컴퓨터, 12번 데이터는 2번 컴퓨터, ...
    '총 데이터의 개수는 항상 ab개의 형태로 주어진다. 재용이는 문득 마지막 데이터가 처리될 컴퓨터의 번호가 궁금해졌다. 이를 수행해주는 프로그램을 작성하라.

    '입력
    '입력의 첫 줄에는 테스트 케이스의 개수 T가 주어진다. 그 다음 줄부터 각각의 테스트 케이스에 대해 정수 a와 b가 주어진다. (1 ≤ a < 100, 1 ≤ b < 1,000,000)

    '출력
    '각 테스트 케이스에 대해 마지막 데이터가 처리되는 컴퓨터의 번호를 출력한다.

    '예제 입력  
    '5
    '1 6
    '3 7
    '6 2
    '7 100
    '9 635

    '예제 출력  
    '1
    '7
    '6
    '1
    '9
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

            For j = 1 To b
                pow = CInt(Math.Pow(a, (b Mod 4)) Mod 10)
                'num = CStr(pow.ToString.Substring(pow.ToString.Length - 1, 1))
            Next j
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
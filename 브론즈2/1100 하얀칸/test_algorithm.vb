Imports System.Collections.Generic

Public Class test_algorithm
    '1100 하얀칸 - 브론즈2'
    '문제
    '체스판은 8×8크기이고, 검정 칸과 하얀 칸이 번갈아가면서 색칠되어 있다. 가장 왼쪽 위칸 (0,0)은 하얀색이다. 
    '체스판의 상태가 주어졌을 때, 하얀 칸 위에 말이 몇 개 있는지 출력하는 프로그램을 작성하시오.

    '입력
    '첫째 줄부터 8개의 줄에 체스판의 상태가 주어진다. '.’은 빈 칸이고, ‘F’는 위에 말이 있는 칸이다.

    '출력
    '첫째 줄에 문제의 정답을 출력한다.

    '예제 입력 1 
    '.F.F...F
    'F...F.F.
    '...F.F.F
    'F.F...F.
    '.F...F..
    'F...F.F.
    '.F.F.F.F
    '    ..FF..F.

    '예제 출력 1 
    '1

    '예제 입력 2 
    '........
    '........
    '........
    '........
    '........
    '........
    '........
    '........

    '예제 출력 2 
    '0

    '예제 입력 3 
    'FFFFFFFF
    'FFFFFFFF
    'FFFFFFFF
    'FFFFFFFF
    'FFFFFFFF
    'FFFFFFFF
    'FFFFFFFF
    'FFFFFFFF

    '예제 출력 3 
    '32

    '예제 입력 4 
    '........
    '..F.....
    '.....F..
    '.....F..
    '........
    '........
    '.......F
    '    .F......

    '예제 출력 4 
    '2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As String = input_textbox.Text
        Dim input() As String = inbox.Split(vbLf)
        Dim outputText As String = ""
        Dim array(7, 7) As Char
        Dim i As Integer
        Dim j As Integer
        Dim count As Integer = 0

        For i = 0 To 7
            For j = 0 To 7
                array(i, j) = input(i)(j)
            Next
        Next

        For i = 0 To 7
            For j = 0 To 7
                If (i + j) Mod 2 = 0 And array(i, j) = "F" Then
                    count += 1
                End If
            Next
        Next
        outputText = count

skip:
        output_textbox.Text = outputText
    End Sub
End Class
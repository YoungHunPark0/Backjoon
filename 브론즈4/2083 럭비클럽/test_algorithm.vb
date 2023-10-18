Public Class test_algorithm
    '1264'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inbox As String = input_textbox.Text
        Dim input() As String = inbox.Split(vbCrLf)
        Dim outputText As String = ""
        Dim name As String
        Dim age As Integer
        Dim weight As Integer
        Dim i As Integer
        Dim Arrary() As String
        Dim j As String

        For i = 0 To input.Length - 1
            Arrary = input(i).Split(" ")
            name = Arrary(0)
            age = Arrary(1)
            weight = Arrary(2)

            If age > 17 Or weight >= 80 Then
                j = "Senior"
            ElseIf name = vbLf & "#" Then
                GoTo skip
            Else
                j = "Junior"
            End If

            outputText &= name & " " & j & vbCrLf
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
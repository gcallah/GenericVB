Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim num1, num2 As Integer
        num1 = CInt(FirstNumBox.Text)
        num2 = CInt(ScndNumBox.Text)
        AnswerBox.Text = gcd(num1, num2)
    End Sub

    Function gcd(ByVal a, ByVal b) As Integer
        Do While (b <> 0)
            a = a Mod b
            Swap(a, b)
        Loop
        Return a
    End Function

    Public Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim c = b
        b = a
        a = c
    End Sub
End Class


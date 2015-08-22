Imports MathFuncs = gcd.math

Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim num1, num2 As Integer
        num1 = CInt(FirstNumBox.Text)
        num2 = CInt(ScndNumBox.Text)
        AnswerBox.Text = MathFuncs.gcd(num1, num2)
    End Sub

End Class


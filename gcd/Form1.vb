Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim num1, num2 As Integer
        Dim notHaveNums As Boolean
        notHaveNums = Not IsNumeric(FirstNumBox.Text) Or Not IsNumeric(ScndNumBox.Text)
        If notHaveNums Then
            MsgBox.Text = "Please enter numbers in both input fields!"
        Else
            MsgBox.Clear()
            num1 = CInt(FirstNumBox.Text)
            num2 = CInt(ScndNumBox.Text)
            AnswerBox.Text = MathFuncs.gcd(num1, num2)
        End If
    End Sub

    Private Sub FirstNumBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumBox.TextChanged
        If Not IsNumeric(FirstNumBox.Text) Then
            MsgBox.Text = "Please enter numbers only!"
        Else
            MsgBox.Clear()
        End If
    End Sub

    Private Sub ScndNumBox_TextChanged(sender As Object, e As EventArgs) Handles ScndNumBox.TextChanged
        If Not IsNumeric(ScndNumBox.Text) Then
            MsgBox.Text = "Please enter numbers only!"
        Else
            MsgBox.Clear()
        End If
    End Sub
End Class


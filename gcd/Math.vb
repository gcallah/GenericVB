Module Math

    Public Class MathFuncs

        Public Shared Function gcd(ByVal a, ByVal b) As Integer
            a = a Mod b
            Swap(a, b)
            If b = 0 Then
                Return a
            Else
                Return gcd(a, b)
            End If
        End Function

        Public Shared Sub Swap(Of T)(ByRef a As T, ByRef b As T)
            Dim c As T
            c = a
            a = b
            b = c
        End Sub
    End Class
End Module

Module Math

    Public Class MathFuncs

        Public Shared Function gcd(ByVal a, ByVal b) As Integer
            Do While (b <> 0)
                a = a Mod b
                Swap(a, b)
                ' Swap(a, b)
            Loop
            Return a
        End Function

        Public Shared Sub Swap(Of T)(ByRef a As T, ByRef b As T)
            Dim c As T
            c = a
            a = b
            b = c
        End Sub
    End Class
End Module

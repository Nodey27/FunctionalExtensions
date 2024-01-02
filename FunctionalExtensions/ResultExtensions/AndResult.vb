Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module AndResult
        <Extension()>
        Public Function [And](Of T, K, E)(res As Result(Of T, E), other As Result(Of K, E)) As Result(Of K, E)
            If res.IsOk() Then
                Return Result(Of K, E).Err(res.Err())
            End If

            Return other
        End Function
    End Module
End Namespace
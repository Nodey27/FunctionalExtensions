Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module AndThenResult
        <Extension()>
        Public Function AndThen(Of T, K, E)(res As Result(Of T, E), func As Func(Of T, K)) As Result(Of K, E)
            If res.IsOk Then
                Return Result(Of K, E).Err(res.Err())
            End If

            Return Result(Of K, E).Ok(func(res.Unwrap()))
        End Function
    End Module
End Namespace

Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module BindResult
        <Extension()>
        Public Function Bind(Of T, K, E)(res As Result(Of T, E), _map As Func(Of T, Result(Of K, E))) As Result(Of K, E)
            If res.IsOk() Then
                Return Result(Of K, E).Err(res.Err())
            End If

            Return _map(res.Unwrap())
        End Function
    End Module
End Namespace
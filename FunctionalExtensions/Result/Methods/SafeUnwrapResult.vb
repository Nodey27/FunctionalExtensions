Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module SafeUnwrapResult
        <Extension()>
        Public Function SafeUnwrap(Of T, E)(res As Result(Of T, E)) As Maybe(Of T)
            If res.IsErr() Then
                Return Maybe(Of T).None()
            End If

            Return Maybe(Of T).Some(res.Unwrap())
        End Function
    End Module
End Namespace
Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module SafeErrResult
        <Extension()>
        Public Function SafeErr(Of T, E)(res As Result(Of T, E)) As Maybe(Of E)
            If res.IsOk() Then
                Return Maybe(Of E).None()
            End If

            Return Maybe(Of E).Some(res.Err())
        End Function
    End Module
End Namespace
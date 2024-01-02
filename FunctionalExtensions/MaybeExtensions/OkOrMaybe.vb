Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module OkOrMaybe
        <Extension()>
        Public Function OkOr(Of T, E)(opt As Maybe(Of T), err As E) As Result(Of T, E)
            If opt.IsNone() Then
                Return Result(Of T, E).Err(err)
            End If

            Return Result(Of T, E).Ok(opt.Unwrap())
        End Function
    End Module
End Namespace
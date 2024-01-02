Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module MapMaybe
        <Extension()>
        Public Function Map(Of T, K)(opt As Maybe(Of T), _map As Func(Of T, K)) As Maybe(Of K)
            If opt.IsNone Then
                Return Maybe(Of K).None()
            End If

            Return Maybe(Of K).Some(_map(opt.Unwrap()))
        End Function
    End Module
End Namespace
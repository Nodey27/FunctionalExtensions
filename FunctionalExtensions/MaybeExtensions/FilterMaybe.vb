Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module FilterMaybe
        <Extension()>
        Public Function AndThen(Of T)(opt As Maybe(Of T), predicate As Func(Of T, Boolean)) As Maybe(Of T)
            If opt.IsNone() Then
                Return Maybe(Of T).None()
            End If

            If Not predicate(opt.Unwrap()) Then
                Return Maybe(Of T).None()
            End If

            Return Maybe(Of T).Some(opt.Unwrap())
        End Function
    End Module
End Namespace
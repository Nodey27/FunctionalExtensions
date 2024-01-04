Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module AndThenMaybe
        <Extension()>
        Public Function AndThen(Of T, K)(opt As Maybe(Of T), map As Func(Of T, Maybe(Of K))) As Maybe(Of K)
            If opt.IsNone() Then
                Return Maybe(Of K).None()
            End If

            Return map(opt.Unwrap())
        End Function
    End Module
End Namespace
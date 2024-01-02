Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module MatchMaybe
        <Extension()>
        Public Function Match(Of T, K, E)(opt As Maybe(Of T), onSome As Func(Of T, K), onNone As Func(Of K)) As K
            If opt.IsNone() Then
                Return onNone()
            End If

            Return onSome(opt.Unwrap())
        End Function
    End Module
End Namespace
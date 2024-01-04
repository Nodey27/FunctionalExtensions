Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module UnzipMaybe
        <Extension()>
        Public Function Unzip(Of T, K)(opt As Maybe(Of Tuple(Of T, K))) As Tuple(Of Maybe(Of T), Maybe(Of K))
            If opt.IsNone() Then
                Return New Tuple(Of Maybe(Of T), Maybe(Of K))(
                Maybe(Of T).None(), Maybe(Of K).None
            )
            End If

            Return New Tuple(Of Maybe(Of T), Maybe(Of K))(
                Maybe(Of T).Some(opt.Unwrap().Item1),
                Maybe(Of K).Some(opt.Unwrap.Item2)
            )
        End Function
    End Module
End Namespace
Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module ZipMaybe
        <Extension()>
        Public Function Zip(Of T, K)(opt As Maybe(Of T), other As Maybe(Of K)) As Maybe(Of Tuple(Of T, K))
            If opt.IsNone() Or other.IsNone Then
                Return Maybe(Of Tuple(Of T, K)).None()
            End If

            Return Maybe(Of Tuple(Of T, K)).Some(
            New Tuple(Of T, K)(opt.Unwrap(), other.Unwrap())
        )
        End Function
    End Module
End Namespace
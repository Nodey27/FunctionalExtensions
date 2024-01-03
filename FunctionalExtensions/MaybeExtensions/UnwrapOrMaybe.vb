Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module UnwrapOrMaybe
        <Extension()>
        Public Function UnwrapOr(Of T)(opt As Maybe(Of T), fallback As T) As T
            If opt.IsNone() Then
                Return fallback
            End If

            Return opt.Unwrap()
        End Function
    End Module
End Namespace
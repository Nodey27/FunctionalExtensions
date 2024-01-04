Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module UnwrapOrElse
        <Extension()>
        Public Function UnwrapOrElse(Of T)(opt As Maybe(Of T), fallback As Func(Of T)) As T
            If opt.IsNone() Then
                Return fallback()
            End If

            Return opt.Unwrap()
        End Function
    End Module
End Namespace
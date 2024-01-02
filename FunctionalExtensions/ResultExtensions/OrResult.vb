Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module OrResult
        <Extension()>
        Public Function [Or](Of T, E)(res As Result(Of T, E), other As Result(Of T, E)) As Result(Of T, E)
            If res.IsErr Then
                Return res
            End If

            Return other
        End Function
    End Module
End Namespace
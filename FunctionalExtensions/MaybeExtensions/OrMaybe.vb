Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module OrMaybe
        <Extension()>
        Public Function [Or](Of T)(opt_a As Maybe(Of T), opt_b As Maybe(Of T)) As Maybe(Of T)
            If opt_a.IsSome() Then
                Return opt_a
            End If

            If opt_b.IsSome() Then
                Return opt_b
            End If

            Return Maybe(Of T).None()
        End Function
    End Module
End Namespace

Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module XOrMaybe
        <Extension()>
        Public Function [XOr](Of T)(opt_a As Maybe(Of T), opt_b As Maybe(Of T)) As Maybe(Of T)
            If opt_a.IsNone() And opt_b.IsNone Or
                opt_a.IsSome And opt_b.IsSome Then
                Return Maybe(Of T).None()
            End If

            If opt_a.IsSome() Then
                Return opt_a
            End If

            Return opt_b
        End Function
    End Module
End Namespace
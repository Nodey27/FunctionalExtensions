Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module XOrMaybe
        <Extension()>
        Public Function [Or](Of T)(opt As Maybe(Of T), optb As Maybe(Of T)) As Maybe(Of T)
            If opt.IsNone() And optb.IsNone Or opt.IsSome And optb.IsSome Then
                Return Maybe(Of T).None()
            End If

            If opt.IsSome() Then
                Return opt
            End If

            Return optb
        End Function
    End Module
End Namespace
Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module InspectMaybe
        <Extension()>
        Public Function Inspect(Of T)(ByRef opt As Maybe(Of T), printer As Action(Of String)) As Maybe(Of T)
            If opt.IsNone Then
                printer.Invoke("Option is none")
            Else
                printer.Invoke($"Option contains value {opt.Unwrap()}")
            End If

            Return opt
        End Function
    End Module
End Namespace
Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module InspectResult
        <Extension()>
        Public Function Inspect(Of T, E)(res As Result(Of T, E), printer As Action(Of String)) As Result(Of T, E)
            If res.IsOk Then
                printer.Invoke($"Result holds error {res.Err()}")
            Else
                printer.Invoke($"Result hold value {res.Unwrap()}")
            End If

            Return res
        End Function
    End Module
End Namespace
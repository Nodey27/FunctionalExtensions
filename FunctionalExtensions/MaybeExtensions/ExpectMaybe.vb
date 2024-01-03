Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module ExpectMaybe
        <Extension()>
        Public Function Expect(Of T)(opt As Maybe(Of T), message As String) As T
            If opt.IsNone() Then
                Throw New ExpectException(message)
            End If

            Return opt.Unwrap()
        End Function
    End Module
End Namespace
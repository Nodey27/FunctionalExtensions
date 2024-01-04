Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class ExceptMaybeTest
    Private Const Message As String = "Should throw this message"

    <TestMethod>
    Public Sub ExpectThrowsExceptionWhenNone()
        Assert.ThrowsException(Of ExpectException)(
            Function()
                Return Maybe(Of Object).
                    None().
                    Expect(Message)
            End Function
        )
    End Sub

    <TestMethod>
    Public Sub ExpectThrowsExceptionWhenNoneWithCorrectMessage()
        Dim value = Nothing
        Try
            Maybe(Of Object).
                    None().
                    Expect(Message)
        Catch ex As Exception
            value = ex.Message
        End Try
        Assert.AreEqual(Message, value)
    End Sub

    <TestMethod>
    Public Sub ExpectReturnValueOnSome()
        Dim expected = 10
        Assert.AreEqual(
            expected,
            Maybe(Of Integer).
                    Some(expected).
                    Expect(Message)
        )
    End Sub
End Class

Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class AndThenMaybeTest

    Private Function SqaureThenToString(x As Integer) As Maybe(Of String)
        Return Maybe(Of String).Try(Function()
                                        If x >= 0 Then
                                            Return Math.Sqrt(x).ToString()
                                        Else
                                            Throw New Exception("Invalid digit")
                                        End If
                                    End Function)
    End Function

    <TestMethod>
    Public Sub AndThenCallsMethodOnSome()
        Dim value As Integer = 5
        Dim expected As String = Math.Sqrt(value).ToString()

        Assert.AreEqual(
            expected,
            Maybe(Of Integer).
                Some(value).
                AndThen(Function(x) SqaureThenToString(x)).
                Unwrap()
        )
    End Sub

    <TestMethod>
    Public Sub AndThenDoesNotCallMethodOnNone()
        Dim expected = Maybe(Of String).None()

        Assert.AreEqual(
            expected,
            Maybe(Of Integer).
                None().
                AndThen(Function(x) SqaureThenToString(x))
        )
    End Sub

    <TestMethod>
    Public Sub AndThenDoesNotCallMethodOnException()
        Dim expected = Maybe(Of String).None()

        Assert.AreEqual(
            expected,
            Maybe(Of Integer).
                Some(-5).
                AndThen(Function(x) SqaureThenToString(x))
        )
    End Sub
End Class

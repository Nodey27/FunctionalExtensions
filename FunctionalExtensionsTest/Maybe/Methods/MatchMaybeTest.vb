Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class MatchMaybeTest
    <TestMethod>
    Public Sub MatchCallsOnNoneWhenNone()
        Dim expected As Integer = -1
        Assert.AreEqual(
            expected,
            Maybe(Of Integer).None().
                Match(
                    Function(x) x,
                    Function() -1
                )
        )
    End Sub

    <TestMethod>
    Public Sub MatchCallsOnSomeWhenSome()
        Dim expected As Integer = 1
        Assert.AreEqual(
            expected,
            Maybe(Of Integer).Some(expected).
                Match(
                    Function(x) x,
                    Function() -1
                )
        )
    End Sub
End Class

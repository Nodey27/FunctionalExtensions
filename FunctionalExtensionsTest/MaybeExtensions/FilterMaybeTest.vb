Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class FilterMaybeTest
    <TestMethod>
    Public Sub FilterReturnsNoneWhenNone()
        Assert.AreEqual(
            Maybe(Of Object).None(),
            Maybe(Of Object).
                None().
                Filter(Function(x) x)
        )
    End Sub

    <TestMethod>
    Public Sub FilterReturnsNoneWhenPredicateFalse()
        Assert.AreEqual(
            Maybe(Of Integer).None(),
            Maybe(Of Integer).
                Some(-1).
                Filter(Function(x) x >= 0)
        )
    End Sub

    <TestMethod>
    Public Sub FilterReturnsSomeWhenPredicateTrue()
        Dim expected As Integer = 1
        Assert.AreEqual(
            Maybe(Of Integer).Some(expected),
            Maybe(Of Integer).
                Some(expected).
                Filter(Function(x) x >= 0)
        )
    End Sub
End Class

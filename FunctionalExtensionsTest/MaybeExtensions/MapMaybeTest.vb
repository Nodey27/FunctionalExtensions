Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class MapMaybeTest
    <TestMethod>
    Public Sub MapReturnsNoneOnNone()
        Assert.AreEqual(
            Maybe(Of Integer).None(),
            Maybe(Of Integer).None().Map(Function(x) x)
        )
    End Sub

    <TestMethod>
    Public Sub MapReturnsSomeOnSome()
        Dim value As Integer = 1
        Assert.AreEqual(
            Maybe(Of Integer).Some(value),
            Maybe(Of Integer).Some(value).Map(Function(x) x)
        )
    End Sub

    <TestMethod>
    Public Sub MapReturnsMappedSomeOnSome()
        Dim value As Integer = 1
        Assert.AreEqual(
            Maybe(Of String).Some(value.ToString()),
            Maybe(Of String).Some(value).Map(Function(x) x.ToString())
        )
    End Sub

    <TestMethod>
    Public Sub MapReturnsMappedSomeOnSomeInChain()
        Dim value As Integer = 1
        Assert.AreEqual(
            (value * value).ToString(),
            Maybe(Of String).Some(value).
                Map(Function(x) x * x).
                Map(Function(x) x.ToString()).
                Unwrap()
        )
    End Sub
End Class

Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class XOrMaybeTest
    <TestMethod>
    Public Sub XOrReturnsNoneWhenBothNone()
        Dim opt_a = Maybe(Of Integer).None()
        Dim opt_b = Maybe(Of Integer).None()
        Dim expected = Maybe(Of Integer).None()

        Assert.AreEqual(
            expected,
            opt_a.XOr(opt_b)
        )
    End Sub

    <TestMethod>
    Public Sub XOrReturnsNoneWhenBothSome()
        Dim opt_a = Maybe(Of Integer).Some(1)
        Dim opt_b = Maybe(Of Integer).Some(-1)
        Dim expected = Maybe(Of Integer).None()

        Assert.AreEqual(
            expected,
            opt_a.XOr(opt_b)
        )
    End Sub

    <TestMethod>
    Public Sub XOrReturnsOptAWhenSomeOptBNone()
        Dim value As Integer = 1
        Dim opt_a = Maybe(Of Integer).Some(value)
        Dim opt_b = Maybe(Of Integer).None()
        Dim expected = Maybe(Of Integer).Some(value)

        Assert.AreEqual(
            expected,
            opt_a.Or(opt_b)
        )
    End Sub

    <TestMethod>
    Public Sub XOrReturnsOptBWhenSomeOptANone()
        Dim value As Integer = 1
        Dim opt_b = Maybe(Of Integer).Some(value)
        Dim opt_a = Maybe(Of Integer).None()
        Dim expected = Maybe(Of Integer).Some(value)

        Assert.AreEqual(
            expected,
            opt_a.Or(opt_b)
        )
    End Sub
End Class

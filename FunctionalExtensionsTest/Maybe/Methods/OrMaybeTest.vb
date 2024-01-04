Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class OrMaybeTest
    <TestMethod>
    Public Sub OrReturnsNoneOnDualNone()
        Dim opt_a = Maybe(Of Integer).None()
        Dim opt_b = Maybe(Of Integer).None()
        Dim expected = Maybe(Of Integer).None()

        Assert.AreEqual(
            expected,
            opt_a.Or(opt_b)
        )
    End Sub

    <TestMethod>
    Public Sub OrReturnsOptAWhenSomeOptBNone()
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
    Public Sub OrReturnsOptBWhenSomeOptANone()
        Dim value As Integer = 1
        Dim opt_b = Maybe(Of Integer).Some(value)
        Dim opt_a = Maybe(Of Integer).None()
        Dim expected = Maybe(Of Integer).Some(value)

        Assert.AreEqual(
            expected,
            opt_a.Or(opt_b)
        )
    End Sub

    <TestMethod>
    Public Sub OrReturnsOptAWhenBothSome()
        Dim value As Integer = 1
        Dim opt_a = Maybe(Of Integer).Some(value)
        Dim opt_b = Maybe(Of Integer).Some(-1)
        Dim expected = Maybe(Of Integer).Some(value)

        Assert.AreEqual(
            expected,
            opt_a.Or(opt_b)
        )
    End Sub
End Class

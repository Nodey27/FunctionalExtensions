Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class MaybeTest

    <TestMethod>
    Public Sub CreateEmptyMaybe()
        Dim result As Maybe(Of Integer) = Maybe(Of Integer).None()
        Dim expected As Maybe(Of Integer) = Maybe(Of Integer).None()
        Dim notExpected As Maybe(Of Integer) = Maybe(Of Integer).Some(1)

        Assert.AreEqual(result, expected)
        Assert.AreNotEqual(result, notExpected)
    End Sub

    <TestMethod>
    Public Sub CreateFilledMaybe()
        Dim testValue As Integer = 1

        Dim result As Maybe(Of Integer) = Maybe(Of Integer).Some(testValue)
        Dim expected As Maybe(Of Integer) = Maybe(Of Integer).Some(1)
        Dim notExpected As Maybe(Of Integer) = Maybe(Of Integer).None()

        Assert.AreEqual(result, expected)
        Assert.AreNotEqual(result, notExpected)
    End Sub

    <TestMethod>
    Public Sub IsSomeReturnsTrueForSome()
        Dim testValue As Integer = 1

        Dim result As Maybe(Of Integer) = Maybe(Of Integer).Some(testValue)

        Assert.IsTrue(result.IsSome)
    End Sub

    <TestMethod>
    Public Sub IsSomeReturnsFalseForNone()
        Dim result As Maybe(Of Integer) = Maybe(Of Integer).None()

        Assert.IsFalse(result.IsSome())
    End Sub

    <TestMethod>
    Public Sub IsNoneReturnsFalseForSome()
        Dim testValue As Integer = 1

        Dim result As Maybe(Of Integer) = Maybe(Of Integer).Some(testValue)

        Assert.IsFalse(result.IsNone())
    End Sub

    <TestMethod>
    Public Sub IsNoneReturnsTrueForNone()
        Dim result As Maybe(Of Integer) = Maybe(Of Integer).None()

        Assert.IsTrue(result.IsNone())
    End Sub

    <TestMethod>
    Public Sub UnwrapPanicsWhenNone()
        Dim result As Maybe(Of Integer) = Maybe(Of Integer).None()

        Assert.ThrowsException(Of Panic)(Function() result.Unwrap())
    End Sub

    <TestMethod>
    Public Sub UnwrapReturnsValueWhenSome()
        Dim expected As Integer = 1

        Dim result As Maybe(Of Integer) = Maybe(Of Integer).Some(expected)

        Assert.AreEqual(expected, result.Unwrap())
    End Sub
End Class

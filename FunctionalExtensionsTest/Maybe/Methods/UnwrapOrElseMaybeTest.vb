Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class UnwrapOrElseMaybeTest
    <TestMethod>
    Public Sub UnwrapOrElseReturnsFallbackFunctionOnNone()
        Dim expected As String = "This is the fallback"
        Dim sut = Maybe(Of Object).None()
        Dim fallback = Function() expected

        Assert.AreEqual(
            expected,
            sut.UnwrapOrElse(fallback)
        )
    End Sub

    <TestMethod>
    Public Sub UnwrapOrElseReturnValueOnSome()
        Dim expected As Integer = 1
        Dim sut = Maybe(Of Integer).Some(expected)
        Dim fallback = Function() "This does not matter"

        Assert.AreEqual(
            expected,
            sut.UnwrapOrElse(fallback)
        )
    End Sub
End Class

Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class UnwrapOrMaybeTest
    <TestMethod>
    Public Sub UnwrapOrReturnsFallbackValueOnNone()
        Dim expected As String = "This is the fallback"
        Dim sut = Maybe(Of Object).None()
        Dim fallback As String = expected

        Assert.AreEqual(
            expected,
            sut.UnwrapOr(fallback)
        )
    End Sub

    <TestMethod>
    Public Sub UnwrapOrReturnValueOnSome()
        Dim expected As Integer = 1
        Dim sut = Maybe(Of Integer).Some(expected)
        Dim fallback As Integer = -1

        Assert.AreEqual(
            expected,
            sut.UnwrapOr(fallback)
        )
    End Sub
End Class

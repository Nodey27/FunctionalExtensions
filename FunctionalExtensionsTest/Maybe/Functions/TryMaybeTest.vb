Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class TryMaybeTest
    <TestMethod>
    Public Sub TryMaybeReturnsValueOnNoException()
        Dim expected As String = "WWhoooooo!"

        Assert.AreEqual(
            Maybe(Of String).Some(expected),
            Maybe(Of String).Try(
                Function() expected)
            )
    End Sub

    <TestMethod>
    Public Sub TryMaybeReturnsValueOnException()
        Dim message As String = "What!"
        Dim expected = Maybe(Of String).None()

        Assert.AreEqual(
            expected,
            Maybe(Of String).Try(
                Function()
                    Throw New Exception(message)
                    Return ""
                End Function)
        )
    End Sub
End Class

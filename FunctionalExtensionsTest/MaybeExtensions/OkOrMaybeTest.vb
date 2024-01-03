Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class OkOrMaybeTest
    <TestMethod>
    Public Sub OkOrReturnsErrWhenNone()
        Dim expected As String = "Maybe does not contain any value, Oops :)"
        Assert.AreEqual(
            Result(Of Object, String).Err(expected),
            Maybe(Of Object).None().
                OkOr(expected)
        )
    End Sub

    <TestMethod>
    Public Sub OkOrReturnsOkWhenSome()
        Dim expected As Integer = 1
        Assert.AreEqual(
            Result(Of Integer, String).Ok(expected),
            Maybe(Of Integer).Some(expected).
                OkOr("Does not matter")
        )
    End Sub
End Class

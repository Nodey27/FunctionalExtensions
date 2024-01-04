Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class SafeErrResultTest
    <TestMethod>
    Public Sub SafeErrReturnSomeOnErr()
        Dim message As String = "What!"
        Dim sut = Result(Of Integer, String).Err(message)
        Dim expected = Maybe(Of String).Some("What!")

        Assert.AreEqual(expected, sut.SafeErr())
    End Sub

    <TestMethod>
    Public Sub SafeErrReturnNoneOnOk()
        Dim sut = Result(Of Integer, String).Ok(1)
        Dim expected = Maybe(Of String).None()

        Assert.AreEqual(expected, sut.SafeErr())
    End Sub
End Class

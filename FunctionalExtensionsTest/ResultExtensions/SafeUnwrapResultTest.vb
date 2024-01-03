Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class SafeUnwrapResultTest
    <TestMethod>
    Public Sub SafeUnwrapReturnsSomeValueOnOk()
        Dim value As Integer = 1
        Dim sut = Result(Of Integer, String).Ok(value)
        Dim expected = Maybe(Of Integer).Some(value)

        Assert.AreEqual(expected, sut.SafeUnwrap())
    End Sub

    <TestMethod>
    Public Sub SafeUnwrapReturnsNoneOnErr()
        Dim sut = Result(Of Integer, String).Err("What!")
        Dim expected = Maybe(Of Integer).None()

        Assert.AreEqual(expected, sut.SafeUnwrap())
    End Sub
End Class

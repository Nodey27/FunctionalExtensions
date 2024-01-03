Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class IsErrAndResultTest
    <TestMethod>
    Public Sub IsErrReturnsErrOnTrue()
        Dim errMessage As String = "Scary"
        Dim sut = Result(Of Integer, String).Err(errMessage)

        Assert.IsTrue(sut.IsErrAnd(Function() True))
    End Sub

    <TestMethod>
    Public Sub IsErrReturnsErrOnFalse()
        Dim errMessage As String = "Scary"
        Dim sut = Result(Of Integer, String).Err(errMessage)

        Assert.IsFalse(sut.IsErrAnd(Function() False))
    End Sub

    <TestMethod>
    Public Sub IsErrReturnsPredicateErr()
        Dim sut = Result(Of Integer, String).Ok(1)

        Assert.IsFalse(sut.IsErrAnd(Function() True))
    End Sub

    <TestMethod>
    Public Sub IsErrReturnsPredicateOk()
        Dim sut = Result(Of Integer, String).Ok(1)

        Assert.IsFalse(sut.IsErrAnd(Function() False))
    End Sub
End Class

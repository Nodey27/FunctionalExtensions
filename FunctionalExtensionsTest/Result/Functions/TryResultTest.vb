Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class TryResultTest

    <TestMethod>
    Public Sub TryReturnsValueWhenNoException()
        Dim expected As Integer = 1
        Dim fun As Func(Of Integer) = Function() expected

        Dim res As Result(Of Integer, String) = Result(Of Integer, String).Try(
            fun,
            Function(err) "Err"
        )

        Assert.AreEqual(expected, res.Unwrap())
    End Sub

    <TestMethod>
    Public Sub TryReturnsErrWhenException()
        Dim expected As String = "Exception has occured!"
        Dim exc As Exception = New Exception(message:=expected)
        Dim fun As Func(Of Exception, String) = Function(err) err.Message

        Dim res As Result(Of Integer, String) = Result(Of Integer, String).Try(
            Function()
                Throw exc
                Return 10
            End Function,
            fun
        )

        Assert.AreEqual(expected, res.Err())
    End Sub
End Class

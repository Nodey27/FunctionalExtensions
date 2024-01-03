Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class UnzipMaybeTest
    <TestMethod>
    Public Sub UnzipsMaybeWithTupleSome()
        Dim expected_item1 As Integer = 1
        Dim expected_item2 As String = "one"
        Dim expected As New Tuple(Of Maybe(Of Integer), Maybe(Of String)) _
            (
            Maybe(Of Integer).Some(expected_item1),
            Maybe(Of String).Some(expected_item2)
            )
        Dim sut = Maybe(Of Tuple(Of Integer, String)).
            Some(New Tuple(Of Integer, String)(expected_item1, expected_item2))

        Assert.AreEqual(
            expected,
            sut.Unzip()
        )
    End Sub

    <TestMethod>
    Public Sub UnzipsMaybeWithTupleNone()
        Dim expected As New Tuple(Of Maybe(Of Integer), Maybe(Of String)) _
            (
            Maybe(Of Integer).None(),
            Maybe(Of String).None()
            )
        Dim sut = Maybe(Of Tuple(Of Integer, String)).None()

        Assert.AreEqual(
            expected,
            sut.Unzip()
        )
    End Sub
End Class

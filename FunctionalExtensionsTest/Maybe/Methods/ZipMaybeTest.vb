Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class ZipMaybeTest
    <TestMethod>
    Public Sub ZipsSomeValues()
        Dim expected_item1 = Maybe(Of Integer).Some(10)
        Dim expected_item2 = Maybe(Of String).Some("Hello")

        Assert.AreEqual(
            Maybe(Of Tuple(Of Integer, String)).
                Some(New Tuple(Of Integer, String)(expected_item1.Unwrap(), expected_item2.Unwrap())),
            expected_item1.Zip(expected_item2)
        )
    End Sub

    <TestMethod>
    Public Sub ZipsNoneValues()
        Dim expected_item1 = Maybe(Of Integer).None()
        Dim expected_item2 = Maybe(Of String).None()

        Assert.AreEqual(
            Maybe(Of Tuple(Of Integer, String)).None(),
            expected_item1.Zip(expected_item2)
        )
    End Sub
End Class

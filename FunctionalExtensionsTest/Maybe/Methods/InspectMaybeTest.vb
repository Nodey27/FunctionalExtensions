Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class InspectMaybeTest
    Private Const NoneMessage As String = "Option is none"
    Private ReadOnly SomeMessage As Func(Of Maybe(Of String), String) _
        = Function(obj) $"Option contains value {obj.Unwrap()}"

    <TestMethod>
    Public Sub InspectReadsNoneValue()
        Dim _global As String = ""
        Dim expected As String = NoneMessage

        Maybe(Of String).None().Inspect(
            Sub(x)
                _global = x
            End Sub
        )

        Assert.AreEqual(expected, _global)
    End Sub

    <TestMethod>
    Public Sub InspectReadsSomeValue()
        Dim _global As String = ""
        Dim message As String = "Yaay!"
        Dim expected As String = SomeMessage(Maybe(Of String).Some(message))

        Maybe(Of String).Some(message).Inspect(
            Sub(x)
                _global = x
            End Sub
        )

        Assert.AreEqual(expected, _global)
    End Sub
End Class

Namespace Functional
    Namespace UtilityClasses
        Public Structure Comparison(Of T As IEquatable(Of T))
            Public _actual As T
            Public _expected As T

            Private Sub New(actual As T, expected As T)
                _actual = actual
                _expected = expected
            End Sub

            Public Shared Function Create(Of X As IEquatable(Of X))(actual As X, expected As X) As Comparison(Of X)
                Return New Comparison(Of X)(actual, expected)
            End Function

            Public Function Compare() As Boolean
                Return _expected.Equals(_actual)
            End Function

            Public Overrides Function ToString() As String
                Return $"Expected {vbCrLf}{_expected}Actual{vbCrLf}{_actual}"
            End Function
        End Structure
    End Namespace
End Namespace
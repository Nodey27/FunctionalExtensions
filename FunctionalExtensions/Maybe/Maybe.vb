Namespace Functional
    Public Structure Maybe(Of T)
        Private ReadOnly _value As T
        Private ReadOnly _hasValue As Boolean

        Private Sub New(hasValue As Boolean, value As T)
            _hasValue = hasValue
            _value = value
        End Sub

        Public Function IsSome() As Boolean
            Return _hasValue
        End Function

        Public Function IsNone() As Boolean
            Return Not _hasValue
        End Function

        Public Function Unwrap() As T
            If Not _hasValue Then
                Throw New Panic($"Option panicked at unwrap on empty option")
            End If
            Return _value
        End Function

        Public Shared Function Some(value As T) As Maybe(Of T)
            Return New Maybe(Of T)(True, value)
        End Function

        Public Shared Function None() As Maybe(Of T)
            Return New Maybe(Of T)(False, Nothing)
        End Function
    End Structure
End Namespace
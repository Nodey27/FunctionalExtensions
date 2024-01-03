Namespace Functional
    Partial Public Structure Maybe(Of T)
        Public Shared Function [Try](Of K)(func As Func(Of K)) As Maybe(Of K)
            Try
                Return Maybe(Of K).Some(func())
            Catch ex As Exception
                Return Maybe(Of K).None()
            End Try
        End Function
    End Structure
End Namespace
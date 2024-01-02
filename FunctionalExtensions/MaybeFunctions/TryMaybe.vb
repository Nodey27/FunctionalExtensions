Namespace Functional
    Partial Public Structure Maybe(Of T)
        Public Shared Function [Try](Of K)(func As Func(Of K), onError As Func(Of Exception, K)) As Maybe(Of K)
            Try
                func()
            Catch ex As Exception
                onError(ex)
            End Try
        End Function
    End Structure
End Namespace
Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module CompareResult
        <Extension()>
        Public Function Compare(Of T As IEquatable(Of T), E)(res As Result(Of T, E), item As T, onError As Func(Of UtilityClasses.Comparison(Of T), E)) As Result(Of T, E)
            Return res.Map(Function(x)
                               Return UtilityClasses.Comparison(Of T).Create(res.Unwrap(), item)
                           End Function).
                    Assert(
                    Function(comparer) comparer.Compare(),
                    Function(comparer) onError(comparer)
                    ).
                    Map(Function(comparer) comparer._actual)
        End Function
    End Module
End Namespace
Imports Zverimex

Public MustInherit Class Animal
    Implements IComparable
    Public Property Name() As String
    Public Property LegCount() As Int16
    Public Overridable Sub Reply()

    End Sub

    Public Sub AllLegCount() Implements IComparable.AllLegCount
        Throw New NotImplementedException()
    End Sub
End Class

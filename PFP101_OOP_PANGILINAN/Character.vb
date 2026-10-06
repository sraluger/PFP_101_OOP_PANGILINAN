' Base class: everything every character has in common
Public MustInherit Class Character

    Private _name As String

    Public Sub New(name As String)
        _name = name
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

    ' Each child class must provide its own version
    Public MustOverride Function GetRole() As String

End Class

' Child class 1
Public Class Missionary
    Inherits Character

    Public Sub New(name As String)
        MyBase.New(name)
    End Sub

    Public Overrides Function GetRole() As String
        Return "Missionary"
    End Function
End Class

' Child class 2
Public Class Cannibal
    Inherits Character

    Public Sub New(name As String)
        MyBase.New(name)
    End Sub

    Public Overrides Function GetRole() As String
        Return "Cannibal"
    End Function
End Class
Public Class GameState

    ' ---- Constants (the rules of the puzzle) ----
    Public Const TotalMissionaries As Integer = 3
    Public Const TotalCannibals As Integer = 3
    Public Const BoatCapacity As Integer = 2

    ' ---- Private fields (Encapsulation: the UI cannot change these directly) ----
    Private _missionariesLeft As Integer
    Private _cannibalsLeft As Integer
    Private _boatOnLeft As Boolean
    Private _moves As Integer

    ' ---- Properties (read-only from outside the class) ----
    Public ReadOnly Property MissionariesLeft As Integer
        Get
            Return _missionariesLeft
        End Get
    End Property

    Public ReadOnly Property CannibalsLeft As Integer
        Get
            Return _cannibalsLeft
        End Get
    End Property

    ' The right side is calculated: whoever is not on the left is on the right
    Public ReadOnly Property MissionariesRight As Integer
        Get
            Return TotalMissionaries - _missionariesLeft
        End Get
    End Property

    Public ReadOnly Property CannibalsRight As Integer
        Get
            Return TotalCannibals - _cannibalsLeft
        End Get
    End Property

    Public ReadOnly Property BoatOnLeft As Boolean
        Get
            Return _boatOnLeft
        End Get
    End Property

    Public ReadOnly Property Moves As Integer
        Get
            Return _moves
        End Get
    End Property

    ' ---- Constructor: runs when we create a new GameState ----
    Public Sub New()
        ResetGame()
    End Sub

    ' ---- Methods ----
    Public Sub ResetGame()
        _missionariesLeft = TotalMissionaries
        _cannibalsLeft = TotalCannibals
        _boatOnLeft = True
        _moves = 0
    End Sub

    ' Can this many missionaries and cannibals ride the boat right now?
    Public Function IsValidMove(missionaries As Integer, cannibals As Integer) As Boolean
        Dim total As Integer = missionaries + cannibals

        If missionaries < 0 Or cannibals < 0 Then
            Return False
        End If

        ' Boat needs 1 or 2 people
        If total < 1 Or total > BoatCapacity Then
            Return False
        End If

        ' Those people must actually be on the boat's side
        If _boatOnLeft Then
            Return (missionaries <= _missionariesLeft) And (cannibals <= _cannibalsLeft)
        Else
            Return (missionaries <= MissionariesRight) And (cannibals <= CannibalsRight)
        End If
    End Function

    ' Safe = on each bank, missionaries are either absent or not outnumbered
    Public Function IsSafeState() As Boolean
        Dim leftSafe As Boolean = (_missionariesLeft = 0) Or (_missionariesLeft >= _cannibalsLeft)
        Dim rightSafe As Boolean = (MissionariesRight = 0) Or (MissionariesRight >= CannibalsRight)
        Return leftSafe And rightSafe
    End Function

    Public Function CheckWin() As Boolean
        Return (MissionariesRight = TotalMissionaries) And (CannibalsRight = TotalCannibals)
    End Function

    ' Moves the boat. Returns True if the move happened, False if it was invalid.
    Public Function MoveBoat(missionaries As Integer, cannibals As Integer) As Boolean
        If Not IsValidMove(missionaries, cannibals) Then
            Return False
        End If

        If _boatOnLeft Then
            _missionariesLeft -= missionaries
            _cannibalsLeft -= cannibals
        Else
            _missionariesLeft += missionaries
            _cannibalsLeft += cannibals
        End If

        _boatOnLeft = Not _boatOnLeft
        _moves += 1
        Return True
    End Function

End Class
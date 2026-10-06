Public Class frmCannibals

    ' ---- Objects and variables used by the form ----
    Private game As New GameState()                  ' the game logic object
    Private isPlaying As Boolean = False             ' has Start been pressed?
    Private allCharacters() As Button                ' the six character buttons
    Private selectedButtons As New List(Of Button)   ' characters picked for the boat

    ' Where the boat sits inside the river panel
    Private Const BoatLeftX As Integer = 10
    Private Const BoatRightX As Integer = 250

    ' ================= FORM LOAD =================
    Private Sub frmCannibals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        allCharacters = {btnM1, btnM2, btnM3, btnC1, btnC2, btnC3}

        ' Attach a Character object to each button (Tag can hold any object)
        btnM1.Tag = New Missionary("M1")
        btnM2.Tag = New Missionary("M2")
        btnM3.Tag = New Missionary("M3")
        btnC1.Tag = New Cannibal("C1")
        btnC2.Tag = New Cannibal("C2")
        btnC3.Tag = New Cannibal("C3")

        lblOOPInfo.Text = "Goodluck and have fun"


        ResetBoard()
    End Sub

    ' ================= HELPER SUBS =================

    ' Puts everything back to the starting position
    Private Sub ResetBoard()
        game.ResetGame()
        selectedButtons.Clear()
        isPlaying = False

        For i As Integer = 0 To allCharacters.Length - 1
            allCharacters(i).Parent = pnlLeftBank
            pnlLeftBank.Controls.SetChildIndex(allCharacters(i), i)  ' keep M1..C3 in order
            allCharacters(i).BackColor = GetNormalColor(allCharacters(i))
        Next

        pnlBoat.Left = BoatLeftX
        btnStart.Enabled = True
        btnMove.Enabled = False
        lblStatus.Text = "Status: Click Start Game to begin."
        UpdateLabels()
    End Sub

    ' Missionaries are blue, cannibals are red
    Private Function GetNormalColor(btn As Button) As Color
        If TypeOf btn.Tag Is Missionary Then
            Return Color.LightSkyBlue
        Else
            Return Color.Tomato
        End If
    End Function

    Private Sub UpdateLabels()
        lblMoves.Text = "Moves: " & game.Moves.ToString()
    End Sub

    ' Shows who is currently selected
    Private Sub ShowSelection()
        If selectedButtons.Count = 0 Then
            lblStatus.Text = "Status: Select up to 2 characters."
        Else
            Dim names As String = ""
            For Each btn As Button In selectedButtons
                Dim ch As Character = DirectCast(btn.Tag, Character)
                If names <> "" Then
                    names &= ", "
                End If
                names &= ch.Name & " (" & ch.GetRole() & ")"
            Next
            lblStatus.Text = "Status: Selected " & names & ". Press Move Boat."
        End If
    End Sub

    Private Sub EndGame(won As Boolean)
        isPlaying = False
        btnMove.Enabled = False

        If won Then
            lblStatus.Text = "Status: YOU WIN! Everyone crossed safely in " & game.Moves & " moves."
            MessageBox.Show("You win! Everyone crossed safely in " & game.Moves & " moves.",
                            "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            lblStatus.Text = "Status: YOU LOSE! Cannibals outnumbered missionaries. Press Reset Game."
            MessageBox.Show("Cannibals outnumbered the missionaries. You lose!",
                            "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ================= EVENT HANDLERS =================

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        isPlaying = True
        btnStart.Enabled = False
        btnMove.Enabled = True
        lblStatus.Text = "Status: Select up to 2 characters."
    End Sub

    ' One handler shared by all six character buttons
    Private Sub Character_Click(sender As Object, e As EventArgs) Handles btnM1.Click, btnM2.Click, btnM3.Click, btnC1.Click, btnC2.Click, btnC3.Click
        If Not isPlaying Then
            lblStatus.Text = "Status: Click Start Game first."
            Return
        End If

        Dim btn As Button = DirectCast(sender, Button)

        ' The character must be on the same side as the boat
        Dim onBoatSide As Boolean
        If game.BoatOnLeft Then
            onBoatSide = (btn.Parent Is pnlLeftBank)
        Else
            onBoatSide = (btn.Parent Is pnlRightBank)
        End If

        If Not onBoatSide Then
            lblStatus.Text = "Status: That character is not on the same side as the boat."
            Return
        End If

        ' Click again to deselect, otherwise select (maximum 2)
        If selectedButtons.Contains(btn) Then
            selectedButtons.Remove(btn)
            btn.BackColor = GetNormalColor(btn)
            ShowSelection()
        ElseIf selectedButtons.Count >= GameState.BoatCapacity Then
            lblStatus.Text = "Status: The boat holds only 2 people."
        Else
            selectedButtons.Add(btn)
            btn.BackColor = Color.Gold
            ShowSelection()
        End If
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        If selectedButtons.Count = 0 Then
            lblStatus.Text = "Status: Select at least 1 character first."
            Return
        End If

        ' Count how many missionaries and cannibals are selected
        Dim missionaries As Integer = 0
        Dim cannibals As Integer = 0
        For Each btn As Button In selectedButtons
            Dim ch As Character = DirectCast(btn.Tag, Character)
            If TypeOf ch Is Missionary Then
                missionaries += 1
            Else
                cannibals += 1
            End If
        Next

        ' Remember direction BEFORE the boat moves (MoveBoat flips it)
        Dim goingRight As Boolean = game.BoatOnLeft

        ' Ask the game object to make the move
        If Not game.MoveBoat(missionaries, cannibals) Then
            lblStatus.Text = "Status: Invalid move."
            Return
        End If

        ' Update the screen: move the characters to the other bank
        Dim destination As FlowLayoutPanel
        If goingRight Then
            destination = pnlRightBank
        Else
            destination = pnlLeftBank
        End If

        For Each btn As Button In selectedButtons
            btn.Parent = destination
            btn.BackColor = GetNormalColor(btn)
        Next
        selectedButtons.Clear()

        ' Move the boat
        If goingRight Then
            pnlBoat.Left = BoatRightX
        Else
            pnlBoat.Left = BoatLeftX
        End If

        UpdateLabels()

        ' Check win / lose
        If game.CheckWin() Then
            EndGame(True)
        ElseIf Not game.IsSafeState() Then
            EndGame(False)
        Else
            lblStatus.Text = "Status: Boat moved. Select up to 2 characters."
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetBoard()
    End Sub

End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCannibals
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblLeftTitle = New Label()
        lblRightTitle = New Label()
        lblTitle = New Label()
        pnlLeftBank = New FlowLayoutPanel()
        pnlRiver = New Panel()
        lblBoat = New Label()
        pnlBoat = New Panel()
        pnlRightBank = New FlowLayoutPanel()
        btnM1 = New Button()
        btnM2 = New Button()
        btnM3 = New Button()
        btnC1 = New Button()
        btnC2 = New Button()
        btnC3 = New Button()
        btnStart = New Button()
        btnMove = New Button()
        btnReset = New Button()
        lblStatus = New Label()
        lblMoves = New Label()
        grpOOP = New GroupBox()
        lblOOPInfo = New Label()
        pnlRiver.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblLeftTitle
        ' 
        lblLeftTitle.AutoSize = True
        lblLeftTitle.Location = New Point(12, 47)
        lblLeftTitle.Name = "lblLeftTitle"
        lblLeftTitle.Size = New Size(68, 15)
        lblLeftTitle.TabIndex = 1
        lblLeftTitle.Text = "LEFT BANK"
        ' 
        ' lblRightTitle
        ' 
        lblRightTitle.AutoSize = True
        lblRightTitle.Location = New Point(640, 60)
        lblRightTitle.Name = "lblRightTitle"
        lblRightTitle.Size = New Size(80, 15)
        lblRightTitle.TabIndex = 2
        lblRightTitle.Text = "RIGHT BANK"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.Location = New Point(12, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(433, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "CANNIBALS AND MISSIONARIES"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLeftBank
        ' 
        pnlLeftBank.BackColor = Color.LightGreen
        pnlLeftBank.Location = New Point(10, 85)
        pnlLeftBank.Name = "pnlLeftBank"
        pnlLeftBank.Padding = New Padding(5)
        pnlLeftBank.Size = New Size(250, 200)
        pnlLeftBank.TabIndex = 3
        ' 
        ' pnlRiver
        ' 
        pnlRiver.BackColor = Color.DodgerBlue
        pnlRiver.Controls.Add(lblBoat)
        pnlRiver.Location = New Point(260, 85)
        pnlRiver.Name = "pnlRiver"
        pnlRiver.Size = New Size(380, 200)
        pnlRiver.TabIndex = 4
        ' 
        ' lblBoat
        ' 
        lblBoat.AutoSize = True
        lblBoat.Dock = DockStyle.Fill
        lblBoat.ForeColor = SystemColors.Window
        lblBoat.Location = New Point(0, 0)
        lblBoat.Name = "lblBoat"
        lblBoat.Size = New Size(38, 15)
        lblBoat.TabIndex = 0
        lblBoat.Text = "BOAT"
        lblBoat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlBoat
        ' 
        pnlBoat.BackColor = Color.SaddleBrown
        pnlBoat.Location = New Point(10, 75)
        pnlBoat.Name = "pnlBoat"
        pnlBoat.Size = New Size(120, 50)
        pnlBoat.TabIndex = 5
        ' 
        ' pnlRightBank
        ' 
        pnlRightBank.BackColor = Color.LightGreen
        pnlRightBank.Location = New Point(640, 85)
        pnlRightBank.Name = "pnlRightBank"
        pnlRightBank.Padding = New Padding(5)
        pnlRightBank.Size = New Size(250, 200)
        pnlRightBank.TabIndex = 6
        ' 
        ' btnM1
        ' 
        btnM1.FlatStyle = FlatStyle.Flat
        btnM1.Location = New Point(10, 300)
        btnM1.Margin = New Padding(5)
        btnM1.Name = "btnM1"
        btnM1.Size = New Size(50, 50)
        btnM1.TabIndex = 7
        btnM1.Text = "M1"
        btnM1.UseVisualStyleBackColor = True
        ' 
        ' btnM2
        ' 
        btnM2.FlatStyle = FlatStyle.Flat
        btnM2.Location = New Point(80, 300)
        btnM2.Margin = New Padding(5)
        btnM2.Name = "btnM2"
        btnM2.Size = New Size(50, 50)
        btnM2.TabIndex = 8
        btnM2.Text = "M2"
        btnM2.UseVisualStyleBackColor = True
        ' 
        ' btnM3
        ' 
        btnM3.FlatStyle = FlatStyle.Flat
        btnM3.Location = New Point(152, 300)
        btnM3.Margin = New Padding(5)
        btnM3.Name = "btnM3"
        btnM3.Size = New Size(50, 50)
        btnM3.TabIndex = 9
        btnM3.Text = "M3"
        btnM3.UseVisualStyleBackColor = True
        ' 
        ' btnC1
        ' 
        btnC1.FlatStyle = FlatStyle.Flat
        btnC1.Location = New Point(12, 377)
        btnC1.Margin = New Padding(5)
        btnC1.Name = "btnC1"
        btnC1.Size = New Size(50, 50)
        btnC1.TabIndex = 10
        btnC1.Text = "C1"
        btnC1.UseVisualStyleBackColor = True
        ' 
        ' btnC2
        ' 
        btnC2.FlatStyle = FlatStyle.Flat
        btnC2.Location = New Point(80, 377)
        btnC2.Margin = New Padding(5)
        btnC2.Name = "btnC2"
        btnC2.Size = New Size(50, 50)
        btnC2.TabIndex = 11
        btnC2.Text = "C2"
        btnC2.UseVisualStyleBackColor = True
        ' 
        ' btnC3
        ' 
        btnC3.FlatStyle = FlatStyle.Flat
        btnC3.Location = New Point(152, 377)
        btnC3.Margin = New Padding(5)
        btnC3.Name = "btnC3"
        btnC3.Size = New Size(50, 50)
        btnC3.TabIndex = 12
        btnC3.Text = "M2"
        btnC3.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(260, 300)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(120, 40)
        btnStart.TabIndex = 13
        btnStart.Text = "Start Game"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnMove
        ' 
        btnMove.Location = New Point(390, 300)
        btnMove.Name = "btnMove"
        btnMove.Size = New Size(120, 40)
        btnMove.TabIndex = 14
        btnMove.Text = "Move Boat"
        btnMove.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(520, 300)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(120, 40)
        btnReset.TabIndex = 15
        btnReset.Text = "Reset Game"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblStatus.Location = New Point(10, 355)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(880, 25)
        lblStatus.TabIndex = 16
        lblStatus.Text = "Label1"
        ' 
        ' lblMoves
        ' 
        lblMoves.AutoSize = True
        lblMoves.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblMoves.Location = New Point(10, 385)
        lblMoves.Name = "lblMoves"
        lblMoves.Size = New Size(72, 20)
        lblMoves.TabIndex = 17
        lblMoves.Text = "Moves: 0"
        ' 
        ' grpOOP
        ' 
        grpOOP.Location = New Point(10, 420)
        grpOOP.Name = "grpOOP"
        grpOOP.Size = New Size(880, 205)
        grpOOP.TabIndex = 18
        grpOOP.TabStop = False
        grpOOP.Text = "OOP Concepts in This Game"
        ' 
        ' lblOOPInfo
        ' 
        lblOOPInfo.AutoSize = True
        lblOOPInfo.Dock = DockStyle.Fill
        lblOOPInfo.Location = New Point(0, 0)
        lblOOPInfo.Name = "lblOOPInfo"
        lblOOPInfo.Size = New Size(32, 15)
        lblOOPInfo.TabIndex = 19
        lblOOPInfo.Text = "OOP"
        ' 
        ' frmCannibals
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblOOPInfo)
        Controls.Add(grpOOP)
        Controls.Add(lblMoves)
        Controls.Add(lblStatus)
        Controls.Add(btnReset)
        Controls.Add(btnMove)
        Controls.Add(btnStart)
        Controls.Add(btnC3)
        Controls.Add(btnC2)
        Controls.Add(btnC1)
        Controls.Add(btnM3)
        Controls.Add(btnM2)
        Controls.Add(btnM1)
        Controls.Add(pnlRightBank)
        Controls.Add(pnlBoat)
        Controls.Add(pnlRiver)
        Controls.Add(pnlLeftBank)
        Controls.Add(lblTitle)
        Controls.Add(lblRightTitle)
        Controls.Add(lblLeftTitle)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Location = New Point(10, 60)
        Name = "frmCannibals"
        Text = "Animation"
        pnlRiver.ResumeLayout(False)
        pnlRiver.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblLeftTitle As Label
    Friend WithEvents lblRightTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlLeftBank As FlowLayoutPanel
    Friend WithEvents pnlRiver As Panel
    Friend WithEvents lblBoat As Label
    Friend WithEvents pnlBoat As Panel
    Friend WithEvents pnlRightBank As FlowLayoutPanel
    Friend WithEvents btnM1 As Button
    Friend WithEvents btnM2 As Button
    Friend WithEvents btnM3 As Button
    Friend WithEvents btnC1 As Button
    Friend WithEvents btnC2 As Button
    Friend WithEvents btnC3 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnMove As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblMoves As Label
    Friend WithEvents grpOOP As GroupBox
    Friend WithEvents lblOOPInfo As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        mnuLessons = New ToolStripMenuItem()
        mnuHelp = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        mnuSBIT2E = New ToolStripMenuItem()
        Lesson1ToolStripMenuItem = New ToolStripMenuItem()
        Lesson2ToolStripMenuItem = New ToolStripMenuItem()
        Lesson2ToolStripMenuItem1 = New ToolStripMenuItem()
        Lesson2ToolStripMenuItem2 = New ToolStripMenuItem()
        Lesson2ToolStripMenuItem3 = New ToolStripMenuItem()
        Lesson2ToolStripMenuItem4 = New ToolStripMenuItem()
        Lesson2ToolStripMenuItem5 = New ToolStripMenuItem()
        Lesson2ToolStripMenuItem6 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuLessons, mnuHelp, mnuExit, mnuSBIT2E})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuLessons
        ' 
        mnuLessons.DropDownItems.AddRange(New ToolStripItem() {Lesson1ToolStripMenuItem, Lesson2ToolStripMenuItem, Lesson2ToolStripMenuItem1, Lesson2ToolStripMenuItem2, Lesson2ToolStripMenuItem3, Lesson2ToolStripMenuItem4, Lesson2ToolStripMenuItem5, Lesson2ToolStripMenuItem6})
        mnuLessons.Name = "mnuLessons"
        mnuLessons.Size = New Size(60, 20)
        mnuLessons.Text = "Lessons"
        ' 
        ' mnuHelp
        ' 
        mnuHelp.Name = "mnuHelp"
        mnuHelp.Size = New Size(44, 20)
        mnuHelp.Text = "Help"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(38, 20)
        mnuExit.Text = "Exit"
        ' 
        ' mnuSBIT2E
        ' 
        mnuSBIT2E.Name = "mnuSBIT2E"
        mnuSBIT2E.Size = New Size(53, 20)
        mnuSBIT2E.Text = "SBIT2E"
        ' 
        ' Lesson1ToolStripMenuItem
        ' 
        Lesson1ToolStripMenuItem.Name = "Lesson1ToolStripMenuItem"
        Lesson1ToolStripMenuItem.Size = New Size(180, 22)
        Lesson1ToolStripMenuItem.Text = "Lesson 1:"
        ' 
        ' Lesson2ToolStripMenuItem
        ' 
        Lesson2ToolStripMenuItem.Name = "Lesson2ToolStripMenuItem"
        Lesson2ToolStripMenuItem.Size = New Size(180, 22)
        Lesson2ToolStripMenuItem.Text = "Lesson 2:"
        ' 
        ' Lesson2ToolStripMenuItem1
        ' 
        Lesson2ToolStripMenuItem1.Name = "Lesson2ToolStripMenuItem1"
        Lesson2ToolStripMenuItem1.Size = New Size(180, 22)
        Lesson2ToolStripMenuItem1.Text = "Lesson 3:"
        ' 
        ' Lesson2ToolStripMenuItem2
        ' 
        Lesson2ToolStripMenuItem2.Name = "Lesson2ToolStripMenuItem2"
        Lesson2ToolStripMenuItem2.Size = New Size(180, 22)
        Lesson2ToolStripMenuItem2.Text = "Lesson 4:"
        ' 
        ' Lesson2ToolStripMenuItem3
        ' 
        Lesson2ToolStripMenuItem3.Name = "Lesson2ToolStripMenuItem3"
        Lesson2ToolStripMenuItem3.Size = New Size(180, 22)
        Lesson2ToolStripMenuItem3.Text = "Lesson 5:"
        ' 
        ' Lesson2ToolStripMenuItem4
        ' 
        Lesson2ToolStripMenuItem4.Name = "Lesson2ToolStripMenuItem4"
        Lesson2ToolStripMenuItem4.Size = New Size(180, 22)
        Lesson2ToolStripMenuItem4.Text = "Lesson 6:"
        ' 
        ' Lesson2ToolStripMenuItem5
        ' 
        Lesson2ToolStripMenuItem5.Name = "Lesson2ToolStripMenuItem5"
        Lesson2ToolStripMenuItem5.Size = New Size(180, 22)
        Lesson2ToolStripMenuItem5.Text = "Lesson 7:"
        ' 
        ' Lesson2ToolStripMenuItem6
        ' 
        Lesson2ToolStripMenuItem6.Name = "Lesson2ToolStripMenuItem6"
        Lesson2ToolStripMenuItem6.Size = New Size(180, 22)
        Lesson2ToolStripMenuItem6.Text = "Lesson 8:"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PFP 101 - OBJECT ORIENTED PROGRAMMING"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuLessons As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuSBIT2E As ToolStripMenuItem
    Friend WithEvents Lesson1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lesson2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lesson2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Lesson2ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Lesson2ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Lesson2ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Lesson2ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents Lesson2ToolStripMenuItem6 As ToolStripMenuItem

End Class

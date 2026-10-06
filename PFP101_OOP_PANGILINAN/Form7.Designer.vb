<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week3))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 15)
        Label1.TabIndex = 0
        Label1.Text = "OOP: Getting Started with Microsoft VB.Net"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(750, 90)
        Label2.TabIndex = 1
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 15)
        Label3.TabIndex = 2
        Label3.Text = "Programming Languages:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(623, 90)
        Label4.TabIndex = 3
        Label4.Text = resources.GetString("Label4.Text")
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 15)
        Label5.TabIndex = 4
        Label5.Text = "What is a Program made of?"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(630, 90)
        Label6.TabIndex = 5
        Label6.Text = resources.GetString("Label6.Text")
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 335)
        Label7.Name = "Label7"
        Label7.Size = New Size(509, 105)
        Label7.TabIndex = 6
        Label7.Text = resources.GetString("Label7.Text")
        ' 
        ' Week3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Week3"
        Text = "Week 3:"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

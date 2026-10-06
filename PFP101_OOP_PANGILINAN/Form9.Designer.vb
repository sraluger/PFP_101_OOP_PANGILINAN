<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week5))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 15)
        Label1.TabIndex = 0
        Label1.Text = "OOP: Data Handling"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(489, 30)
        Label2.TabIndex = 1
        Label2.Text = "Variables - Provide a means to store data values that are not stored in files. " & vbCrLf & "Support the computation of values through their use in formulas in assignment statements."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 60)
        Label3.TabIndex = 2
        Label3.Text = "Types of Data:" & vbCrLf & "Data type name." & vbCrLf & "Description of data stored." & vbCrLf & "Memory storage requirement in bytes"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(441, 45)
        Label4.TabIndex = 3
        Label4.Text = "Naming Rules for Variables and Constants" & vbCrLf & "Names can include letters, digits, and the underscore, but must begin with a letter." & vbCrLf & "Names cannot contain spaces or periods."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(653, 90)
        Label5.TabIndex = 4
        Label5.Text = resources.GetString("Label5.Text")
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 285)
        Label6.Name = "Label6"
        Label6.Size = New Size(660, 60)
        Label6.TabIndex = 5
        Label6.Text = resources.GetString("Label6.Text")
        ' 
        ' Week5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Week5"
        Text = "Week5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

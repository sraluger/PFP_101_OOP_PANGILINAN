Public Class Week2I

    Private Sub Week2I_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Display the example code in the RichTextBox
        RichTextBox1.Text =
            "Public Class Animal" & vbCrLf &
            "    Public Overridable Sub Speak()" & vbCrLf &
            "        Console.WriteLine(""Animal speaks"")" & vbCrLf &
            "    End Sub" & vbCrLf &
            "End Class" & vbCrLf &
            "" & vbCrLf &
            "Public Class Dog" & vbCrLf &
            "    Inherits Animal" & vbCrLf &
            "    Public Overrides Sub Speak()" & vbCrLf &
            "        Console.WriteLine(""Dog barks"")" & vbCrLf &
            "    End Sub" & vbCrLf &
            "End Class"

        TextBox1.Text = "Click Run Code to see the output."

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Create a Dog object
        Dim myDog As New Dog()

        'Run the overridden Speak() method
        Dim result As String = myDog.Speak()

        'Display the result
        TextBox1.Text = result

    End Sub

End Class


'========================================
' BASE CLASS
'========================================

Public Class Animal

    Public Overridable Function Speak() As String

        Return "Animal speaks"

    End Function

End Class


'========================================
' CHILD CLASS
'========================================

Public Class Dog

    Inherits Animal

    Public Overrides Function Speak() As String

        Return "Dog barks"

    End Function

End Class
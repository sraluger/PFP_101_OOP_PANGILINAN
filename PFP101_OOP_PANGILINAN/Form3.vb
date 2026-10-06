Public Class Week2C
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim age As Integer

        If Integer.TryParse(textbox1.Text, age) Then

            If age >= 18 Then
                TextBox1.Text = "You are an adult."
            Else TextBox1.Text = "You are a minor."

            End If

        Else

            TextBox1.Text = "Please enter a valid number."

        End If

    End Sub

    Private Sub Week2C_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
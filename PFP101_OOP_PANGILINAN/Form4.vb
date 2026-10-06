Public Class Week2E

    'Create a BankAccount object
    Private account As New BankAccount()

    Private Sub Week2E_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Code displayed in the RichTextBox
        RichTextBox1.Text =
            "Public Class BankAccount" & vbCrLf &
            "    Private balance As Decimal" & vbCrLf &
            "" & vbCrLf &
            "    Public Sub Deposit(amount As Decimal)" & vbCrLf &
            "        If amount > 0 Then" & vbCrLf &
            "            balance += amount" & vbCrLf &
            "        End If" & vbCrLf &
            "    End Sub" & vbCrLf &
            "" & vbCrLf &
            "    Public Function GetBalance() As Decimal" & vbCrLf &
            "        Return balance" & vbCrLf &
            "    End Function" & vbCrLf &
            "End Class"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim amount As Decimal

        'Check if the input is a valid number
        If Decimal.TryParse(TextBox1.Text, amount) Then

            'Deposit the amount
            account.Deposit(amount)

            'Show the current balance
            MessageBox.Show(
                "Deposit successful!" & vbCrLf &
                "Current Balance: ₱" &
                account.GetBalance().ToString("N2"),
                "Bank Account"
            )

        Else

            MessageBox.Show(
                "Please enter a valid amount.",
                "Invalid Input"
            )

        End If

    End Sub

End Class


'========================================
' BANK ACCOUNT CLASS
'========================================

Public Class BankAccount

    'Private field - this demonstrates encapsulation
    Private balance As Decimal

    'Method for depositing money
    Public Sub Deposit(amount As Decimal)

        If amount > 0 Then
            balance += amount
        End If

    End Sub

    'Method for getting the balance
    Public Function GetBalance() As Decimal

        Return balance

    End Function

End Class
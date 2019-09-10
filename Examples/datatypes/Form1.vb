Public Class Form1
    Sub Numbers()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer
        firstNumber = Convert.ToDecimal(FirstNumberTextBox.Text)
        secondNumber = Convert.ToDecimal(SecondNumberTextBox.Text)

        'result = firstNumber + secondNumber
        'ResultTextBox.Text = result
        'Console.WriteLine(result)

    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ResultTextBox_TextChanged(sender As Object, e As EventArgs) Handles ResultTextBox.TextChanged

    End Sub

    Private Sub SecondNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles SecondNumberTextBox.TextChanged

    End Sub

    Private Sub FirstNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTextBox.TextChanged

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim result As Integer
        ResultTextBox.Text = result

    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer


        'firstNumber = Convert.ToDecimal(FirstNumberTextBox.Text)
        'secondNumber = Convert.ToDecimal(SecondNumberTextBox.Text)

        'result = firstNumber + secondNumber
        'ResultTextBox.Text = result
    End Sub

    Private Sub Sign_TextChanged(sender As Object, e As EventArgs)
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer
        firstNumber = Convert.ToDecimal(FirstNumberTextBox.Text)
        secondNumber = Convert.ToDecimal(SecondNumberTextBox.Text)
        Me.DisplayLabel1.text = "+"
        If DisplayLabel1.Text = "+" Then
            result = firstNumber + secondNumber
        End If



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles DisplayLabel1.Click

    End Sub
End Class

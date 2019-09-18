Option Explicit On
Option Strict On

Public Class UserInputForm
    Private Sub GetInputButton_Click(sender As Object, e As EventArgs) Handles GetInputButton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim resultNumber As Integer

        secondNumber = 7
        'firstNumber = Convert.ToInt32(NumberTextBox.Text)
        'firstNumber = Integer.Parse(NumberTextBox.Text)
        Try
            Console.WriteLine("In the Try Code")
            firstNumber = Integer.Parse(NumberTextBox.Text)
        Catch ex As Exception
            Console.WriteLine("In the Catch code")

        Finally
            Console.WriteLine("In the Finally code")
        End Try

        resultNumber = firstNumber + secondNumber
        Console.WriteLine(resultNumber)

    End Sub
End Class

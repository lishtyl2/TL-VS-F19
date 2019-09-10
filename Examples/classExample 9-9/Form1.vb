Option Strict On
Option Explicit On


Public Class Form1




    Sub StringMath()

        Dim result As Integer

        result = 5 + Integer.Parse(TextBox1.Text) 'integer.parse is a conversion string to integer. 
        Console.WriteLine(result)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click
        TextBox1.Clear()
        Focus()
    End Sub
End Class

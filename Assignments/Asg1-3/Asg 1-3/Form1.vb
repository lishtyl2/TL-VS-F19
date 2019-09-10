Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub EarlyBirdButton_Click(sender As Object, e As EventArgs) Handles EarlyBirdButton.Click
        Me.Label2.Text = "The early bird gets the worm."
    End Sub

    Private Sub PennySavedButton_Click(sender As Object, e As EventArgs) Handles PennySavedButton.Click
        Me.Label2.Text = "A penny saved is a penny not spent."
    End Sub

    Private Sub NoGutsButton_Click(sender As Object, e As EventArgs) Handles NoGutsButton.Click
        Me.Label2.Text = "No guts, no story."
    End Sub

    Private Sub ConfuciusButton_Click(sender As Object, e As EventArgs) Handles ConfuciusButton.Click
        Me.Label2.Text = "Man who laugh last, not get joke."
    End Sub
End Class

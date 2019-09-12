Public Class StringForm
    Private Sub StringForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        'Concatinate first and last name then display
        DisplayLabel.Text = TextBox1.Text & " " & TextBox2.Text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hello World"
    End Sub

    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click

    End Sub

    Private Sub Updatelabel_Click(sender As Object, e As EventArgs) Handles updatelabelbutton.Click
        Me.DisplayLabel.Text = "Hola Mundo"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DisplayLabel.Text = "Bonjour le monde"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DisplayLabel.Text = "مرحبا بالعالم"
    End Sub
End Class

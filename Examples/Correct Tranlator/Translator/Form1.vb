Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hello World"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SpanishButton_Click(sender As Object, e As EventArgs) Handles SpanishButton.Click
        Me.DisplayLabel1.Text = "Hola Mundo"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FrenchButton.Click
        Me.DisplayLabel1.Text = "Bonjour le monde"
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles DisplayLabel1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ArabicButton.Click
        Me.DisplayLabel1.Text = "مرحبا بالعالم"
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DisplayLabel1.Text = "Ciao mondo"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DisplayLabel1.Text = "Привет, мир"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DisplayLabel1.Text = "Hello World"
    End Sub
End Class

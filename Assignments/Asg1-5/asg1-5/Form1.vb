Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Label1.Text = "Soup Du Jour" & vbNewLine & vbNewLine & "The Soup Du Jour is the soup of the day."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Label1.Text = "Chef's Special" & vbNewLine & vbNewLine & "Harissa Meatballs" & vbNewLine & "w/ Tomato Sauce" & vbNewLine & "Shishito Peppers" & vbNewLine & "Orzo"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Label1.Text = "Daily Fish" & vbNewLine & vbNewLine & "Tilapia" & vbNewLine & "Brown Butter Grape Pan Sauce" & vbNewLine & "Farro and Kale"
    End Sub
End Class

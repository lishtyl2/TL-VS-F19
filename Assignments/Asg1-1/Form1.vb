Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateTitle(sender As Object, e As EventArgs) Handles UpdateTitleButton.Click
        Me.Text = "ERROR"
    End Sub

    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click

    End Sub

    Private Sub Updatelabel_Click(sender As Object, e As EventArgs) Handles updatelabelbutton.Click
        Me.DisplayLabel.Text = "Holla Bitches"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub
End Class

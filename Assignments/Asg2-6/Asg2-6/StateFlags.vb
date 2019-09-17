'Tyler Lish
'RCET0265
'Asg2-6
'State Flag Viewer



Public Class StateFlags
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub KansasButton_Click(sender As Object, e As EventArgs) Handles KansasButton.Click
        PictureBox1.Image = My.Resources.Kansas
    End Sub

    Private Sub NorthDakotaButton_Click(sender As Object, e As EventArgs) Handles NorthDakotaButton.Click
        PictureBox1.Image = My.Resources.North_Dakota
    End Sub

    Private Sub OregonButton_Click(sender As Object, e As EventArgs) Handles OregonButton.Click
        PictureBox1.Image = My.Resources.oregon_flag
    End Sub

    Private Sub VermontButton_Click(sender As Object, e As EventArgs) Handles VermontButton.Click
        PictureBox1.Image = My.Resources.vermont_flag
    End Sub

    Private Sub NewYorkButton_Click(sender As Object, e As EventArgs) Handles NewYorkButton.Click
        PictureBox1.Image = My.Resources.New_York
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PictureBox1.Image = My.Resources.please_select
    End Sub
End Class

'Tyler Lish
'RCET0265
'asg2-5
'Address label display program





Public Class MailingLabel
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles ZipCodeBox.MaskInputRejected
        ZipCodeBox.Focus()
        ZipCodeBox.SelectionStart = 0
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        DisplayLabel.Text = FirstNameBox.Text & " " & LastNameBox.Text _
            & vbNewLine & AddressBox.Text & vbNewLine & CityBox.Text _
            & "," & " " & StateBox.Text & " " & ZipCodeBox.Text

    End Sub
End Class

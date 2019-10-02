Public Class Form1




    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearAllFields()
    End Sub


    Sub ClearAllFields()
        NameTextBox.Text = ""
        GradeMaskedTextBox.Text = ""
        AgeMaskedTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        AnswerTextBox.Text = ""
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim RandomNumberMaker As Random
        Dim FirstRandomNumber As Single
        Dim SecondRandomNumber As Single
        Dim answer As Single

        FirstRandomNumber = CInt(Int((10 * Rnd()) + 1))
        SecondRandomNumber = CInt(Int((10 * Rnd()) + 1))

        Select Case True
            Case AddRadioButton.Checked
                FirstNumberTextBox.Text = FirstRandomNumber.ToString
                SecondNumberTextBox.Text = SecondRandomNumber.ToString
                answer = (FirstRandomNumber + SecondRandomNumber)
            Case SubtractRadioButton.Checked
                FirstNumberTextBox.Text = FirstRandomNumber.ToString
                SecondNumberTextBox.Text = SecondRandomNumber.ToString
                answer = (FirstRandomNumber - SecondRandomNumber)
            Case MultiplyRadioButton.Checked
                FirstNumberTextBox.Text = FirstRandomNumber.ToString
                SecondNumberTextBox.Text = SecondRandomNumber.ToString
                answer = (FirstRandomNumber * SecondRandomNumber)
            Case DivideRadioButton.Checked
                FirstNumberTextBox.Text = FirstRandomNumber.ToString
                SecondNumberTextBox.Text = SecondRandomNumber.ToString
                answer = FirstRandomNumber / SecondRandomNumber
            Case Else
                MessageBox.Show("You need to select a math function.")
        End Select
        AnswerTextBox.Text = answer.ToString


    End Sub
End Class

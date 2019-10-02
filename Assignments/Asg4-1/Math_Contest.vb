Public Class MathContest
    Dim age As Integer
    Dim grade As Integer
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim answer As Integer
    Dim totalright As Integer
    Dim totalwrong As Integer
    Dim overall As Double






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
    Private Sub DiableFields()
        AgeMaskedTextbox.Enabled = False
        GradeMaskedTextbox.Enabled = False
        addRadioButton.Enabled = False
        subtractRadioButton.Enabled = False
        multiplyRadioButton.Enabled = False
        divideRadioButton.Enabled = False
        answerTextBox.Enabled = False
        nameTextbox.Enabled = True
        SubmitButton_Click.Enabled = False
        ClearButton.Enabled = False
        SummaryButton.Enabled = False
        ExitButton.Enabled = True
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub EnableQuestion()
        addRadioButton.Enabled = True
        subtractRadioButton.Enabled = True
        multiplyRadioButton.Enabled = True
        divideRadioButton.Enabled = True

    End Sub

    Private Sub EnableAnswer()
        addRadioButton.Enabled = False
        subtractRadioButton.Enabled = False
        multiplyRadioButton.Enabled = False
        divideRadioButton.Enabled = False
        NameTextBox.Enabled = False
        ageMaskedTextbox.Enabled = False
        GradeMaskedTextbox.Enabled = False
        answerTextbox.Enabled = True
        SubmitButton.Enabled = True
        ClearButton.Enabled = True
        SummaryButton.Enabled = True
        AnswerTextbox.select()
        GenerateNumber()
    End Sub

    Private Sub GenerateNumber()
        firstNumber = CInt(Int((10 * Rnd()) + 1))
        secondNumber = CInt(Int((10 * Rnd()) + 1))
        firstNumberTextBox.Text() = Convert.ToString(firstNumber)
        secondNumberTextBox.Text() = Convert.ToString(secondNumber)
    End Sub
    Private Sub studentNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles studentNameTextBox.TextChanged
        DisableFields()
        If studentNameTextBox.Text = "" Then
            MessageBox.Show("You need to enter your name please.")
            studentNameTextBox.Select()
        Else
            ageMaskedTextBox.Enabled = True
        End If
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

'Tyler Lish
'RCET0265
'Asg4-1
'https:///github.com/lishtyl2/TL-VS-F19/tree/master/Assignments
Option Strict On
Option Explicit On

Public Class MathContest
    Dim age As Integer
    Dim grade As Integer
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim answer As Integer
    Dim totalRight As Integer
    Dim totalWrong As Integer
    Dim overall As Double

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearAllFields()
    End Sub

    Sub ClearAllFields()
        NameTextBox.Text = ""
        GradeComboBox.Text = ""
        AgeComboBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        AnswerTextBox.Text = ""
    End Sub
    Private Sub DisableFields()
        AgeComboBox.Enabled = False
        GradeComboBox.Enabled = False
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
        AnswerTextBox.Enabled = False
        NameTextBox.Enabled = True
        SubmitButton.Enabled = False
        ClearButton.Enabled = True
        SummaryButton.Enabled = False
        ExitButton.Enabled = True
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub EnableQuestion()
        AddRadioButton.Enabled = True
        SubtractRadioButton.Enabled = True
        MultiplyRadioButton.Enabled = True
        DivideRadioButton.Enabled = True

    End Sub
    Private Sub EnableAnswer()
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
        NameTextBox.Enabled = False
        AgeComboBox.Enabled = False
        GradeComboBox.Enabled = False
        AnswerTextBox.Enabled = True
        SubmitButton.Enabled = True
        ClearButton.Enabled = True
        SummaryButton.Enabled = True
        AnswerTextBox.Select()
        GenerateNumber()
    End Sub
    Private Sub GenerateNumber()
        firstNumber = CInt(Int((10 * Rnd()) + 1))
        secondNumber = CInt(Int((10 * Rnd()) + 1))
        FirstNumberTextBox.Text() = Convert.ToString(firstNumber)
        SecondNumberTextBox.Text() = Convert.ToString(secondNumber)
    End Sub
    Private Sub studentNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        DisableFields()
        If NameTextBox.Text = "" Then
            MessageBox.Show("You need to enter your name please.")
            NameTextBox.Select()
        Else
            AgeComboBox.Enabled = True
            GradeComboBox.Enabled = True
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Select Case True

            Case AddRadioButton.Checked
                answer = firstNumber + secondNumber
            Case SubtractRadioButton.Checked
                answer = firstNumber - secondNumber
            Case MultiplyRadioButton.Checked
                answer = firstNumber * secondNumber
            Case DivideRadioButton.Checked
                answer = firstNumber \ secondNumber
        End Select
        Try

            overall = Double.Parse(AnswerTextBox.Text)
        Catch ex As Exception
            overall = 0
        End Try
        If answer = overall Then
            MessageBox.Show("Woohoo!!")
            totalRight += 1
        Else
            MessageBox.Show("DOH! The correct answer is " & answer & ".")
            totalWrong += 1
        End If
        EnableAnswer()
        GenerateNumber()
        AnswerTextBox.Clear()

    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        EnableQuestion()
    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        EnableAnswer()
    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        EnableAnswer()
    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        EnableAnswer()
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        EnableAnswer()
    End Sub

    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisableFields()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MessageBox.Show(NameTextBox.Text & " had " & totalRight & " correct, and " & totalWrong _
                        & " incorrect.")
        totalRight = 0
        totalWrong = 0
        ExitButton.Enabled = True
        DisableFields()
        ClearAllFields()
    End Sub
End Class

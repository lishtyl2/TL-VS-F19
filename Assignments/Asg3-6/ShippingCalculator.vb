'Tyler Lish
' RCET0265
'Asg3-6
'Shipping Calculator
'https://github.com/lishtyl2/TL-VS-F19/tree/master/Assignments

Public Class ShippingCalculator
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim Pounds As Double
        Dim Ounces As Double
        Dim Cost As Double
        Dim errorMessage As String

        Try
            Pounds = Double.Parse(PoundsTextBox.Text)
        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a numeric value in the Pounds Textbox." &
                vbNewLine
            PoundsTextBox.Select()
            PoundsTextBox.Clear()
        End Try
        Try
            Ounces = Double.Parse(OuncesTextBox.Text)
        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a numeric value in the Ounces Textbox." &
                vbNewLine
            OuncesTextBox.Select()
            OuncesTextBox.Clear()
        End Try
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Hmmm...Something's not quite right.")
        Else
            Ounces = Double.Parse(OuncesTextBox.Text)
            Pounds = Double.Parse(PoundsTextBox.Text)
        End If

        Pounds = 1.92 * Pounds
        Ounces = 0.12 * Ounces
        Cost = Ounces + Pounds

        ShippingCostTextBox.Text = Cost.ToString("C")

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ShippingCostTextBox.Text = ""
        IDCodeTextBox.Text = ""
        OuncesTextBox.Text = ""
        PoundsTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class

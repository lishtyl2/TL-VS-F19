'Tyler Lish
' RCET0265
'Asg3-6
'Shipping Calculator
'https://github.com/lishtyl2/TL-VS-F19/tree/master/Assignments

Public Class ShippingFormCalculator
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim pounds As Double
        Dim ounces As Double
        Dim cost As Double
        Dim errorMessage As String
        Dim validateIdCode As Boolean = True

        If IDCodeTextBox.Text.Length() < 6 Or validateIdCode = False Then
            errorMessage = errorMessage & "Please enter a 6 digit ID Code." & vbNewLine
            IDCodeTextBox.Select()
            clearAll()
        End If
        Try
            pounds = Double.Parse(PoundsTextBox.Text)
        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a numeric value in the Pounds Textbox." &
            vbNewLine
            PoundsTextBox.Select()
            PoundsTextBox.Clear()
        End Try
        Try
            ounces = Double.Parse(OuncesTextBox.Text)
        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a numeric value in the Ounces Textbox." &
            vbNewLine
            OuncesTextBox.Select()
            OuncesTextBox.Clear()
        End Try
        Try
            Integer.Parse(IDCodeTextBox.Text)
        Catch ex As Exception
            validateIdCode = False
        End Try
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Hmmm...Something's not quite right.")
        Else
            ounces = Double.Parse(OuncesTextBox.Text)
            pounds = Double.Parse(PoundsTextBox.Text)
        End If
        pounds = 1.92 * pounds
        ounces = 0.12 * ounces
        cost = ounces + pounds
        ShippingCostTextBox.Text = cost.ToString("C")
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        clearAll()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub clearAll()
        IDCodeTextBox.Clear()
        OuncesTextBox.Clear()
        PoundsTextBox.Clear()
        ShippingCostTextBox.Clear()
    End Sub
End Class

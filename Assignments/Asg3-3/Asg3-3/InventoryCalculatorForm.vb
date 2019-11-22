'Tyler Lish
'RCET0265
'Asg3-3
'Inventory Calculator
'https://github.com/lishtyl2/TL-VS-F19/tree/master/Assignments
Option Strict On
Option Explicit On
Public Class InventoryCalculatorForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim beginningInventory As Integer
        Dim endingInventory As Integer
        Dim costOfGoodsSold As Double
        Dim averageInventory As Double
        Dim turnover As Double
        Dim errorMessage As String
        Try
            costOfGoodsSold = Integer.Parse(CostTextBox.Text)
        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a number in the Cost of Goods Textbox." & vbNewLine
            CostTextBox.Select()
            CostTextBox.Clear()
        End Try
        Try
            endingInventory = Integer.Parse(EndingTextBox.Text)

        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a number in the Ending Inventory Textbox." & vbNewLine
            EndingTextBox.Select()
            EndingTextBox.Clear()
        End Try
        Try
            beginningInventory = Integer.Parse(BeginningTextBox.Text)

        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a number in the Beginning Inventory Textbox." & vbNewLine
            BeginningTextBox.Select()
            BeginningTextBox.Clear()
        End Try
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Houston, We Have A Problem.")
        Else
            beginningInventory = Integer.Parse(BeginningTextBox.Text)
            endingInventory = Integer.Parse(EndingTextBox.Text)
            costOfGoodsSold = Integer.Parse(CostTextBox.Text)
        End If
        averageInventory = (beginningInventory + endingInventory) / 2
        turnover = costOfGoodsSold / averageInventory
        AverageTextBox.Text = averageInventory.ToString("C")
        TurnoverTextBox.Text = turnover.ToString("0.0")
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        BeginningTextBox.Text = ""
        EndingTextBox.Text = ""
        CostTextBox.Text = ""
        AverageTextBox.Text = ""
        TurnoverTextBox.Text = ""
    End Sub
End Class

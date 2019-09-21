'Tyler Lish
'RCET0265
'Asg3-3
'Inventory Calculator
'https://github.com/lishtyl2/TL-VS-F19/tree/master/Assignments
Option Strict On
Option Explicit On
Public Class InventoryCalculator
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim BeginningInventory As Integer
        Dim EndingInventory As Integer
        Dim CostOfGoodsSold As Double
        Dim AverageInventory As Double
        Dim Turnover As Double
        Dim errorMessage As String

        Try
            CostOfGoodsSold = Integer.Parse(CostTextBox.Text)

        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a number in the Cost of Goods Textbox." & vbNewLine
            CostTextBox.Select()
            CostTextBox.Clear()
        End Try
        Try
            EndingInventory = Integer.Parse(EndingTextBox.Text)

        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a number in the Ending Inventory Textbox." & vbNewLine
            EndingTextBox.Select()
            EndingTextBox.Clear()
        End Try
        Try
            BeginningInventory = Integer.Parse(BeginningTextBox.Text)

        Catch anyException As Exception
            errorMessage = errorMessage & "Please enter a number in the Beginning Inventory Textbox." & vbNewLine
            BeginningTextBox.Select()
            BeginningTextBox.Clear()
        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Houston, We Have A Problem.")
        Else

        End If

        BeginningInventory = Integer.Parse(BeginningTextBox.Text)
        EndingInventory = Integer.Parse(EndingTextBox.Text)
        CostOfGoodsSold = Integer.Parse(CostTextBox.Text)

        AverageInventory = (BeginningInventory + EndingInventory) / 2
        Turnover = CostOfGoodsSold / AverageInventory

        AverageTextBox.Text = AverageInventory.ToString("C")
        TurnoverTextBox.Text = Turnover.ToString("0.0")



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

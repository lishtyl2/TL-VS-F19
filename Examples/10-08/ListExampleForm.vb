Public Class ListExampleForm

    Sub CreateList()
        Dim namesList As New List(Of String)
        Dim numbers As New List(Of Integer)(New Integer() {3, 5, 7, 2, 8})


        namesList.Add("John")
        namesList.Add("Steve")
        namesList.Add("Basic Becky")
        namesList.Add("Emily")
        'Console.WriteLine(names(2))

        'For Each name As String In namesList
        '    Console.WriteLine(name)
        'Next

        'For i = 0 To namesList.Count - 1 'Step 2
        'Console.WriteLine(namesList(i))
        'Next
        'For Each amount As Integer 
        'Console.WriteLine(amount.ToString("C"))
    End Sub

    Private Sub ListExampleForm_click(sender As Object, e As EventArgs) Handles Me.Click
        CreateList()

    End Sub

    Sub FormatExample()
        'format data in nice rows and columns
        Dim output As String
        Dim currentString As String
        Dim safetyNet As Integer
        Dim startNumber As Integer
        Dim stopNumber As Integer

        output = ""
        startNumber = 1
        stopNumber = 10

        For row = 1 To 10
            For column = startNumber To stopNumber
                'currentString = Str(column).Trim
                currentString = column.ToString("C")
                safetyNet = 0
                'currentString.PadLeft(4)
                Do Until currentString.Length >= 7 Or safetyNet = 100
                    currentString = " " & currentString
                    safetyNet = +1
                Loop
                output &= currentString & " |"

            Next

            Console.WriteLine(output)
            stopNumber += 10
            startNumber += 10
            output = ""
        Next

        'Console.WriteLine(output.Length)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Console.WriteLine(invoiceHeader())
        Console.WriteLine(columnHeaders("Description", "Unit", "Rate", "SubTotal"))
        'FormatExample()
    End Sub

    '80 character limit. 
    Private Function invoiceHeader() As String

        Return "********************************************************************************" & vbNewLine &
                       "*                                Invoice                                       *" & vbNewLine &
                       "********************************************************************************"
    End Function

    Private Function columnHeaders(firstColumn As String, secondColumn As String, thirdColumn As String, fourthColumn As String) As String
        'Description, unit cost, rate, subtotal.
        Dim columnWidth As Integer
        columnWidth = 20
        firstColumn = "* " & firstColumn
        secondColumn = "| " & secondColumn
        thirdColumn = "| " & thirdColumn
        fourthColumn = "|          " & fourthColumn
        Return firstColumn.PadRight(columnWidth) & secondColumn.PadRight(columnWidth) &
            thirdColumn.PadRight(columnWidth) & fourthColumn.PadLeft(columnWidth - 1) & "*"

    End Function

    Private Sub PrintPreviewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog.Click
        OpenFileDialog1.ShowDialog()
        PrintPreviewDialog.ShowDialog()
        Dim myDoc As Printing.PrintDocument




    End Sub

    Private Sub PrintPreview_Click(sender As Object, e As EventArgs) Handles PrintPreview.Click
        PrintPreviewDialog.ShowDialog()

    End Sub

    Private Sub PrintMenu_Click(sender As Object, e As EventArgs) Handles PrintMenu.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        OpenFileDialog1.ShowDialog()
        Console.WriteLine(OpenFileDialog1.FileName)
    End Sub
End Class

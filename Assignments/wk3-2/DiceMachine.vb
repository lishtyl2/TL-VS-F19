Option Strict Off
Option Explicit Off


Public Class DiceMachine
    Dim summary As New List(Of String)
    Dim stopSummary As New List(Of String)
    Dim tempString As String
    Dim rollTotalArray(10, 10000) As String
    Private Sub DiceButton_Click(sender As Object, e As EventArgs) Handles DiceButton.Click
        Dim var As Single
        Dim var1 As Single
        Dim sum As Single
        DisplayInListBox()

        For i = 1 To 10000
            var = Int(Rnd() * 6 + 1)
            var1 = Int(Rnd() * 6 + 1)
            sum = var + var1
            DiceSum.Items.Insert(0, sum)

        Next
        DiceSum.Items.Insert(10000, vbCr)
    End Sub
    'Private Function ColumnHeaders(firstColumn As String, secondColumn As String, thirdColumn As String, fourthColumn As String, fifthColumn As String,
    '                               sixthColumn As String, seventhColumn As String, eighthColumn As String, ninthColumn As String, tenthColumn As String,
    '                               eleventhColumn As String, twelfthColumn As String) As String
    '    'This will place "|" and  spaces to help make the columns look better.
    '    Dim columnWidth As Integer = 20

    '    firstColumn = "| " & firstColumn
    '    secondColumn = "| " & secondColumn
    '    thirdColumn = "| " & thirdColumn
    '    fourthColumn = "| " & fourthColumn
    '    fifthColumn = "| " & fifthColumn
    '    sixthColumn = "| " & sixthColumn
    '    seventhColumn = "| " & seventhColumn
    '    eighthColumn = "| " & eighthColumn
    '    ninthColumn = "| " & ninthColumn
    '    tenthColumn = "| " & tenthColumn
    '    eleventhColumn = "| " & eleventhColumn
    '    twelfthColumn = "| " & twelfthColumn

    '    ' this will allign the columns.
    '    Return firstColumn.PadRight(columnWidth) & secondColumn.PadRight(columnWidth) &
    '       thirdColumn.PadRight(columnWidth) & fourthColumn.PadRight(columnWidth) &
    '       fifthColumn.PadRight(columnWidth) & sixthColumn.PadRight(columnWidth) &
    '       seventhColumn.PadRight(columnWidth) & eighthColumn.PadRight(columnWidth) &
    '       ninthColumn.PadRight(columnWidth) & tenthColumn.PadRight(columnWidth) &
    '       eleventhColumn.PadRight(columnWidth) & twelfthColumn.PadRight(columnWidth)

    'End Function

    Private Sub DisplayInListBox()
        'Add formatted Invoice Example to list box
        'TODO: May want to keep multiple sets of invoice data in a list or file
        DiceSum.Items.Add(HorizontalBoarder(80, "*"))
        DiceSum.Items.Add(MainHeader(80, "Dice Roll!!", "*"))
        DiceSum.Items.Add(HorizontalBoarder(80, "*"))
        DiceSum.Items.Add(columnHeaders("2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"))
    End Sub
    Private Function HorizontalBoarder(length As Integer, characterSet As String) As String
        'Create string of desired length form characterSet pattern
        For i = 1 To length
            tempString &= characterSet
        Next
        Return tempString 'Str(Len(tempString))
    End Function
    Private Function MainHeader(length As Integer, title As String, characterSet As String) As String
        'create boxed title header
        'TODO: might want multiple lines, Might want choice other than center justify
        'may be replaced with gereral purpose row with columns creator
        tempString = title

        Do Until tempString.Length >= length - 2 '2 should be replaced with length of
            tempString = " " & tempString & " " 'this doesn't work for odd number of charactors
        Loop

        Return characterSet & tempString & characterSet 'Str(Len(characterSet & tempString & characterSet))
    End Function
    Private Function columnHeaders(firstColumn As String, secondColumn As String, thirdColumn As String, fourthColumn As String, fifthColumn As String,
                                   sixthColumn As String, seventhColumn As String, eighthColumn As String, ninthColumn As String, tenthColumn As String,
                                       eleventhColumn As String) As String
        'This will place "|" and  spaces to help make the columns look better.
        Dim columnWidth As Integer = 20

        firstColumn = "| " & firstColumn
        secondColumn = "| " & secondColumn
        thirdColumn = "| " & thirdColumn
        fourthColumn = "| " & fourthColumn
        fifthColumn = "| " & fifthColumn
        sixthColumn = "| " & sixthColumn
        seventhColumn = "| " & seventhColumn
        eighthColumn = "| " & eighthColumn
        ninthColumn = "| " & ninthColumn
        tenthColumn = "| " & tenthColumn
        eleventhColumn = "| " & eleventhColumn


        ' this will allign the columns.
        Return firstColumn.PadRight(columnWidth) & secondColumn.PadRight(columnWidth) &
           thirdColumn.PadRight(columnWidth) & fourthColumn.PadRight(columnWidth) &
           fifthColumn.PadRight(columnWidth) & sixthColumn.PadRight(columnWidth) &
           seventhColumn.PadRight(columnWidth) & eighthColumn.PadRight(columnWidth) &
           ninthColumn.PadRight(columnWidth) & tenthColumn.PadRight(columnWidth) &
           eleventhColumn.PadRight(columnWidth)
    End Function
    'Private Sub sortNumbers()
    '    If 

    '    End If
    'End Sub
    Private Sub TotalDice(rollTotal As Integer)
        Static trackertwo As Integer
        Static trackerThree As Integer
        Static trackerFour As Integer
        Static trackerFive As Integer
        Static trackerSix As Integer
        Static trackerSeven As Integer
        Static trackerEight As Integer
        Static trackerNine As Integer
        Static trackerTen As Integer
        Static trackerEleven As Integer
        Static trackerTwelve As Integer
        Dim tracker As Integer
        If rollTotal = 2 Then
            trackertwo += 1
            tracker = trackertwo
            WriteDiceTotal(0, tracker, rollTotal)
        End If
        If rollTotal = 3 Then
            trackerThree += 1
            tracker = trackerThree
            WriteDiceTotal(1, tracker, rollTotal)
        End If
        If rollTotal = 4 Then
            trackerFour += 1
            tracker = trackerFour
            WriteDiceTotal(2, tracker, rollTotal)
        End If
        If rollTotal = 5 Then
            trackerFive += 1
            tracker = trackerFive
            WriteDiceTotal(3, tracker, rollTotal)
        End If
        If rollTotal = 6 Then
            trackerSix += 1
            tracker = trackerSix
            WriteDiceTotal(4, tracker, rollTotal)
        End If
        If rollTotal = 7 Then
            trackerSeven += 1
            tracker = trackerSeven
            WriteDiceTotal(5, tracker, rollTotal)
        End If
        If rollTotal = 8 Then
            trackerEight += 1
            tracker = trackerEight
            WriteDiceTotal(6, tracker, rollTotal)
        End If
        If rollTotal = 9 Then
            trackerNine += 1
            tracker = trackerNine
            WriteDiceTotal(7, tracker, rollTotal)
        End If
        If rollTotal = 10 Then
            trackerTen += 1
            tracker = trackerTen
            WriteDiceTotal(8, tracker, rollTotal)
        End If
        If rollTotal = 11 Then
            trackerEleven += 1
            tracker = trackerEleven
            WriteDiceTotal(9, tracker, rollTotal)
        End If
        If rollTotal = 12 Then
            trackerTwelve += 1
            tracker = trackerTwelve
            WriteDiceTotal(10, tracker, rollTotal)
        End If
    End Sub
    Private Sub WriteDiceTotal(collumn As Integer, row As Integer, rolltotal As Integer)
        rollTotalArray(collumn, row) = rolltotal


    End Sub
End Class

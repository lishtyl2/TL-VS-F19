Public Class Form1
    Private Function IsWayTooLong(ByVal numberFromZeroToFifteen As Integer) As String
        If numberFromZeroToFifteen = 0 Then
            Return "Your number is: Zero"
        End If
        If numberFromZeroToFifteen = 1 Then
            Return "Your number is: One"
        End If
        If numberFromZeroToFifteen = 2 Then
            Return "Your number is: Two"
        End If
        If numberFromZeroToFifteen = 3 Then
            Return "Your number is: Three"
        End If
        If numberFromZeroToFifteen = 4 Then
            Return "Your number is: Four"
        End If
        If numberFromZeroToFifteen = 5 Then
            Return "Your number is: Five"
        End If
        If numberFromZeroToFifteen = 6 Then
            Return "Your number is: Six"
        End If
        If numberFromZeroToFifteen = 7 Then
            Return "Your number is: Seven"
        End If
        If numberFromZeroToFifteen = 8 Then
            Return "Your number is: Eight"
        End If
        If numberFromZeroToFifteen = 9 Then
            Return "Your number is: Nine"
        End If
        If numberFromZeroToFifteen = 10 Then
            Return "Your number is: Ten"
        End If
        If numberFromZeroToFifteen = 11 Then
            Return "Your number is: Eleven"
        End If
        If numberFromZeroToFifteen = 12 Then
            Return "Your number is: Twelve"
        End If
        If numberFromZeroToFifteen = 13 Then
            Return "Your number is: Thirteen"
        End If
        If numberFromZeroToFifteen = 14 Then
            Return "Your number is: Fourteen"
        End If
        If numberFromZeroToFifteen = 15 Then
            Return "Your number is: Fifteen"
        End If
        If numberFromZeroToFifteen < 0 Then
            Return "Your number is: Too Low"
        End If
        If numberFromZeroToFifteen > 15 Then
            Return "Your number is: Too High"
        End If
    End Function
    'This is the working code from Sprints 1 and 2
    Private Function ValidateAndConvert(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String
        Dim message As String = ""
        Try
            toThisInteger = CInt(convertThisString)
        Catch ex As Exception
            message = "Must contain a number"
            If convertThisString = "" Then message = "is empty"
        End Try
        Return message
    End Function
    'Do Not change this code other that comment/uncomment the lines indicated
    Private Sub GetUserInput() Handles Me.Load
        Me.Hide()
        Dim tempNum As Integer = 0
        Dim userMessage As String = "Please Enter A Number Between 0 and 15" _
        & vbNewLine & "Type Q to Quit"
        Do
            userMessage = InputBox(userMessage, "Hello", "")
            If userMessage <> "Q" And userMessage <> "" Then
                userMessage = ValidateAndConvert(userMessage, tempNum)
                'If userMessage = "" Then userMessage = IsWayTooLong(tempNum) 'Replace this Line
                If userMessage = "" Then userMessage = ShortAndSweet(tempNum) 'With this one
            End If
        Loop Until userMessage = "Q" Or userMessage = ""
        Me.Close()
    End Sub
    'In as few lines as possible produce the same results as the function IsWayTooLong()
    'Hint use a loop and a List or Array
    'Also only have one return statement at the end
    Private Function ShortAndSweet(ByVal numberFromZeroToFifteen As Integer) As String
        ShortAndSweet = ""
        Dim numbers(,) As Object = {{0, "Zero"}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, {5, "Five"},
            {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}, {10, "Ten"}, {11, "Eleven"}, {12, "Twelve"},
            {13, "Thirteen"}, {14, "Fourteen"}, {15, "Fifteen"}}
        Dim i As Integer
        If numberFromZeroToFifteen < 0 Then
            Return "Your number is: Too Low"
        ElseIf numberFromZeroToFifteen > 15 Then
            Return "Your number is: Too High"
        End If
        For i = 0 To UBound(numbers)
            If numberFromZeroToFifteen = numbers(i, 0) Then
                ShortAndSweet = numbers(i, 1)
                Exit For
            End If
        Next
        Return ShortAndSweet
    End Function
End Class

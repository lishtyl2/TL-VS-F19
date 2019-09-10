Public Class Friday

    Private Sub DoStuffButton_Click(sender As Object, e As EventArgs) Handles DoStuffButton.Click
        FridayExample() 'Call the friday sub 
    End Sub
    Sub FridayExample()
        Dim statementOne As String
        Dim statementTwo As String
        Dim statementThree As String
        Dim currentString As String
        Dim rndNumber As Single
        Dim randomNumberExample As New Random

        statementOne = "The greatest wisdom ever is...." & vbNewLine & "stuff on new line"
        statementTwo = "Not the greatest wisdom ever..."
        statementThree = "Medicore wisdom"

        'For i = 0 To 1000
        '    rndNumber = randomNumberExample.Next(1, 4)
        '    Console.WriteLine("the current i is:" & Str(i) & Str(rndNumber))
        'Next

        'currentString = "Other info"
        rndNumber = randomNumberExample.Next(1, 4)
        If rndNumber = 1 Then
            Console.WriteLine(statementOne)
        ElseIf rndNumber = 2 Then
            Console.WriteLine(statementTwo)
        ElseIf rndNumber = 3 Then
            Console.WriteLine(statementThree)
        Else
            Console.WriteLine("Nope")
        End If

        'Console.ReadLine()

    End Sub
End Class

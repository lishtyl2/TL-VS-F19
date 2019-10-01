Public Class Form1
    Dim everoneCanSeeThis As Integer
    Sub UpdateRunningTotal(points As Integer, clearTotal As Boolean)
        Static total As Integer


        If clearTotal = True Then total = 0


        total += points
        everoneCanSeeThis += 1
        Console.WriteLine(total)
        'Console.WriteLine(everoneCanSeeThis)
        'Console.WriteLine(everoneCanSeeThis)
        'Console.WriteLine(everoneCanSeeThis)
        'Console.WriteLine(everoneCanSeeThis)
        'Console.WriteLine(everoneCanSeeThis)
        'Console.WriteLine(everoneCanSeeThis)
        'Console.WriteLine(everoneCanSeeThis)
        'Console.WriteLine(everoneCanSeeThis)
        'Console.WriteLine(clearTotal)

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim clearFlag As Boolean
        Dim twoPoints As Integer
        Dim touchDown As Integer

        clearFlag = False
        twoPoints = 2
        touchDown = 6

        UpdateRunningTotal(touchDown, clearFlag)
        'Console.WriteLine(total)
        everoneCanSeeThis += 1
        'Console.WriteLine(everoneCanSeeThis)


    End Sub

    Sub ResetAll()
        UpdateRunningTotal(0, True)
        BadRadioButton.Checked = False
        MehRadioButton.Checked = False
        GoodRadioButton.Checked = False


    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()

    End Sub


    Sub Response()

        'If BadRadioButton.Checked = True Then
        '    MessageBox.Show("That's so sad...")
        'End If

        Select Case True
            Case BadRadioButton.Checked
                MessageBox.Show("That's so sad...")
            Case MehRadioButton.Checked
                MessageBox.Show("Getting Better.")
            Case GoodRadioButton.Checked
                MessageBox.Show("Yay!")
            Case Else
                MessageBox.Show("You didn't pick anything.")
        End Select



    End Sub

    Public Sub RespondButton_Click(sender As Object, e As EventArgs) Handles RespondButton.Click




        'Response()
        doMath()
    End Sub


    Sub doMath()
        Dim RandomNumberMaker As Random
        Dim FirstRandomNumber As Single
        Dim SecondRandomNumber As Single

        'Fix this random number crap. 
        FirstRandomNumber = CInt(Int((6 * Rnd()) + 1))
        SecondRandomNumber = CInt(Int((6 * Rnd()) + 1))

        Select Case True
            Case AddButton.Checked
                Console.WriteLine(FirstRandomNumber + SecondRandomNumber)
            Case SubtractButton.Checked
                Console.WriteLine(FirstRandomNumber - SecondRandomNumber)
            Case Else
                Console.WriteLine("There is no math to do. ")
        End Select
    End Sub
End Class

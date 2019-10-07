Option Strict On
Option Explicit On
Public Class ReusableCode 'resuable reset
    Sub SetToDefaults()
        FirstTextbox.Clear()
        SecondTextbox.Clear()
        ThirdTextbox.Clear()
        'GoButton.Enabled = False
        FirstTextbox.Select()

    End Sub
    Sub HasValidInteger(txtbox As TextBox)
        Dim number As Integer
        Try

            'number = Integer.Parse(FirstTextbox.Text)
            'number = Integer.Parse(stringData)
            number = Integer.Parse(txtbox.Text)
        Catch ex As Exception
            MessageBox.Show("You need to put numbers in " & txtbox.Name, "ERROR")
        End Try


    End Sub

    Function myFunc() As Integer
        Return 0

    End Function
    Sub ValidateAllTextboxes()
        HasValidInteger(FirstTextbox)
        HasValidInteger(SecondTextbox)
        HasValidInteger(ThirdTextbox)

    End Sub
    'Private Function GetAllTextBoxes() As List(Of Control)
    '    'Temp storage for the control object. 
    '    Dim ctrl As Control
    '    'list of all textbox control objects found
    '    Dim listOfTextBoxes As New List(Of Control)
    '    'created this as a loop counter to avoid being stuck
    '    'in an infinate loop during debugging. 
    '    Dim loopCounter As Integer
    '    loopCounter = 0

    '    ctrl = UserInput.GetNextControl(ctrl, False)
    '    Do Until ctrl Is Nothing Or loopCounter >= 100
    '        loopCounter += 1

    '        If TypeName(ctrl) = "TextBox" Then
    '            Console.WriteLine(ctrl.Name & " is a " & TypeName(ctrl) & " and is a match!")
    '            listOfTextBoxes.Add(ctrl)

    '        End If
    '        ctrl = UserInput.GetNextControl(ctrl, False)

    '    Loop

    '    Return listOfTextBoxes



    'End Function
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetToDefaults()
    End Sub

    Private Sub ReusableCode_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetToDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        HasValidInteger(FirstTextbox)
        HasValidInteger(SecondTextbox)
        HasValidInteger(ThirdTextbox)
        'GetAllTextBoxes()
    End Sub

    Private Sub GoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem1.Click

    End Sub
End Class

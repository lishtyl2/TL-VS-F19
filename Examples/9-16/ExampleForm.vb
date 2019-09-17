Option Explicit On
Option Strict On

Public Class ExampleForm
    'PascalCase = First Letter Of Each Word
    'Objects

    'camelCase = not The First Word But Every Other Word.
    'variables

    'ALLCAPS
    'CONSTANTS

    'snake_case
    'used in python

    Sub VariablesAndConstants()

        Dim someNumber As Integer
        Dim result As Integer

        'constants can not change
        Const SOMECONSTANT = 7D

        someNumber = 5
        'Console.WriteLine(someNumber)

        'someNumber = 6
        'Console.WriteLine(someNumber)

        result = someNumber + CInt(SOMECONSTANT)
        Console.WriteLine(result)

    End Sub

    Private Sub ChangeItButton_Click(sender As Object, e As EventArgs) Handles ChangeItButton.Click
        VariablesAndConstants()
    End Sub
End Class

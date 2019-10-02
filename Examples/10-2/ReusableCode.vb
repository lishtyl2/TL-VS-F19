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
    End Sub
End Class

Option Strict On
Option Explicit On

Public Class ExampleForm
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim errorMessage As String
        LoadTestData() 'load sample data, remove for production

        'validate user input in reverse tab order. first tab with an error will be left selected. 
        Try
            'Try something that might throw an exception
            secondNumber = Integer.Parse(TextBox2.Text)
        Catch anyException As Exception
            'Exception thrown so do stuff
            errorMessage = errorMessage & "Please enter a number in the second box." & vbNewLine
            'dont do that is message in box and we have a problem is header. 
            TextBox2.Select()
            TextBox2.Clear()
        End Try

        Try
            'Try something that might throw an exception
            firstNumber = Integer.Parse(TextBox1.Text)
        Catch anyException As Exception
            'Exception thrown so do stuff
            errorMessage = errorMessage & "Please enter a number in the first box." & vbNewLine
            TextBox1.Select()
            TextBox1.Clear()
            'dont do that is message in box and we have a problem is header. 
        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "We have a problem")
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoadTestData()
        Dim Sample As Integer
        For Sample = 1 To 4 Step 1
            Select Case Sample
                Case = 1
                    TextBox1.Text = "5"
                    TextBox2.Text = "6"
                    Exit For
                Case = 2
                    TextBox1.Text = "5"
                    TextBox2.Text = "Bad"
                    Exit For
                Case = 3
                    TextBox1.Text = "Bad"
                    TextBox2.Text = "6"
                    Exit For
                Case = 4
                    TextBox1.Text = "Bad"
                    TextBox2.Text = "Bad"
                    Exit For
                Case Else
                    'do stuff
            End Select
        Next Sample

    End Sub
End Class

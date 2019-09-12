'Tyler Lish
'RCET0265
'This is a Daily Specials menu example. 
'Asg1-5
'https://github.com/lishtyl2/TL-VS-F19/tree/master/Assignments/Asg1-5/asg1-5

Public Class TodaysSpecialMenu


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        Me.Label1.Text = "Soup Du Jour" & vbNewLine & vbNewLine & "The Soup Du Jour is the soup of the day."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ChefsButton.Click
        Me.Label1.Text = "Chef's Special" & vbNewLine & vbNewLine & "Harissa Meatballs" _
            & vbNewLine & "w/ Tomato Sauce" & vbNewLine & "Shishito Peppers" & vbNewLine & "Orzo"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        Me.Label1.Text = "Daily Fish" & vbNewLine & vbNewLine & "Tilapia" & vbNewLine _
            & "Brown Butter Grape Pan Sauce" & vbNewLine & "Farro and Kale"
    End Sub
End Class

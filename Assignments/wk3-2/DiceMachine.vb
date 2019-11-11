Option Strict On
Option Explicit On


Public Class DiceMachine
    Private Sub DiceButton_Click(sender As Object, e As EventArgs) Handles DiceButton.Click
        For i = 1 To 10000
            Var = Int(Rnd() * 6 + 1)
            var1 = Int(Rnd() * 6 + 1)
            sum = Var + var1
            DiceSum.Items.Insert(0, sum)

        Next
        DiceSum.Items.Insert(10000, vbCr & ":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::")
    End Sub
End Class

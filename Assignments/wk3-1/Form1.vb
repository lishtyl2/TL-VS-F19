Option Strict On
Option Explicit On

Public Class Form1
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var As Single

        For i = 1 To 10
            Var = Int(Rnd() * 20) - 10
            ListBox1.Items.Insert(0, Var)

        Next
        ListBox1.Items.Insert(10, vbCr & ":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::")
    End Sub
End Class

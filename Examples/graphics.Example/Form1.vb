' Etch-A-Sketch
Public Class Form1
    Dim newcolor As Color
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Dim graph As graphics = PictureBox1.CreateGraphics
        ' Create pen.
        Dim blackPen As New Pen(newcolor, 3)
        Static x1, y1 As Single
        If x1 = 0 And y1 = 0 Then x1 = e.X : y1 = e.Y : newcolor = Color.Cyan
        If e.Button.ToString = "Left" Then
            graph.DrawLine(blackPen, x1, y1, e.X, e.Y)
        End If
        x1 = e.X : y1 = e.Y
        Label1.Text = e.Button.ToString & " " & e.X & " " & e.Y
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal _
   e As System.EventArgs) Handles Button1.Click
        Dim graph As graphics = PictureBox1.CreateGraphics
        Dim offset As Integer = 10
        For var As Integer = 1 To 10
            offset *= -1
            PictureBox1.Left += offset
            System.Threading.Thread.Sleep(100)
        Next
        graph.Clear(Color.DarkBlue)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal _
   e As System.EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        newcolor = ColorDialog1.Color
    End Sub
    'Dynamically adjust picturebox size as form is resized
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As _
   System.EventArgs) Handles Me.Resize
        If Me.Width < 300 Then Me.Width = 300
        PictureBox1.Width = Me.Width - PictureBox1.Left - 25
        PictureBox1.Height = Me.Height - PictureBox1.Top - 75
        Label1.Left = (Me.Width \ 2 - (Label1.Width + Button1.Width _
       + Button2.Width) \ 2) - 25
        Button1.Left = Label1.Left + 100
        Button2.Left = Button1.Left + 70
    End Sub
End Class
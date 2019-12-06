'Tyler Lish
'RCET0265
'Etch A Sketch
'ASG 13 - 1
'https://github.com/lishtyl2/TL-VS-F19/tree/master/Assignments

Public Class GraphicsForm

    Dim newcolor As Color
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Dim graph As Graphics = PictureBox1.CreateGraphics
        ' Create pen.
        Dim blackPen As New Pen(newcolor, 3)
        Static x1, y1 As Single
        If x1 = 0 And y1 = 0 Then x1 = e.X : y1 = e.Y : newcolor = Color.Cyan
        If e.Button.ToString = "Left" Then
            graph.DrawLine(blackPen, x1, y1, e.X, e.Y)
        End If
        If e.Button.ToString = "Right" Then
            graph.DrawLine(blackPen, x1, y1, e.X, e.Y)
        End If
        'Display mouse events in label
        x1 = e.X : y1 = e.Y
        Label1.Text = e.Button.ToString & " " & e.X & " " & e.Y
        Label1.Left = e.X - Label1.Width
        Label1.Top = e.Y - Label1.Height
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Dim graph As Graphics = PictureBox1.CreateGraphics
        Dim offset As Integer = 10
        My.Computer.Audio.Play(My.Resources.bomb_x, AudioPlayMode.Background)
        For var As Integer = 1 To 10
            offset *= -1
            PictureBox1.Left += offset
            System.Threading.Thread.Sleep(225)
        Next
        graph.Clear(Color.White)
    End Sub
    Private Sub ColorPickerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorPickerButton.Click
        ColorDialog1.ShowDialog()
        newcolor = ColorDialog1.Color
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles SineWaveButton.Click
        Dim x As Double
        Dim y As Double
        Dim blackPen As New Pen(Color.Black, 3)
        Dim g As Graphics
        Dim graticulPen As New Pen(Color.ForestGreen, 3)
        Dim sinWavePen As New Pen(Color.OrangeRed, 2)
        Dim cosWavePen As New Pen(Color.MediumPurple, 2)
        Dim graph As Graphics = PictureBox1.CreateGraphics
        Dim padding As Integer

        graph.Clear(Color.LightGray)
        g = PictureBox1.CreateGraphics
        g.DrawLine(graticulPen, 0, 150, PictureBox1.Width, 150)
        g.DrawRectangle(pen:=graticulPen, x:=2, y:=1, width:=3000, height:=300)

        For r As Double = 0 To 2000
            y = Math.Sin(r / 175 * 2 * Math.PI) * 150 + 150
            x = r
            g.DrawLine(sinWavePen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))

            y = Math.Cos(r / 175 * 2 * Math.PI) * 150 + 150
            x = r
            g.DrawLine(cosWavePen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))


            y = Math.Tan(r / 175 * 2 * Math.PI) * 150 + 150
            x = r
            g.DrawLine(blackPen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
        Next

    End Sub
End Class

Option Explicit On
Option Strict On

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
        'Display mouse events in label
        x1 = e.X : y1 = e.Y
        Label1.Text = e.Button.ToString & " " & e.X & " " & e.Y
        Label1.Left = e.X - Label1.Width
        Label1.Top = e.Y - Label1.Height
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim graph As Graphics = PictureBox1.CreateGraphics
        Dim offset As Integer = 10
        For var As Integer = 1 To 10
            offset *= -1
            PictureBox1.Left += offset
            System.Threading.Thread.Sleep(100)
        Next
        graph.Clear(Color.DarkBlue)
    End Sub
    Private Sub ColorPickerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorPickerButton.Click
        ColorDialog1.ShowDialog()
        newcolor = ColorDialog1.Color
    End Sub

    'Dynamically adjust picturebox size as form is resized

    Private Sub AutoSizeControls()
        If Me.Width < 300 Then Me.Width = 300

        'PictureBox1.Left = Me.Left
        'PictureBox1.Top = Me.Top

        PictureBox1.Width = Me.Width * 0.75
        PictureBox1.Height = Me.Height * 0.93

        'Label1.Left = (Me.Width \ 2 - (Label1.Width + Button1.Width + ColorPickerButton.Width) \ 2) - 25
        Button1.Left = PictureBox1.Left
        Button1.Top = PictureBox1.Top - PictureBox1.Height
        ColorPickerButton.Left = Button1.Left + 70
    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AutoSizeControls()
    End Sub
    Private Sub Form_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        AutoSizeControls()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    'AutoSizing Waveform Drawing Program. 0309
    'Draw Waveform
    'Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, PictureBox1.Click ', Me.Resize
    '    Dim graph As Graphics = PictureBox1.CreateGraphics
    '    Dim ptr As Integer
    '    Dim scfactor, fudge, radius, angle As Single
    '    Dim x1, x2, y1, y2, drawHeight, drawWidth As Single
    '    PictureBox1.Height = Me.Height - 35 'Resize the pictureBox
    '    PictureBox1.Width = Me.Width - 10
    '    graph.Clear(Color.MidnightBlue)
    '    fudge = 5I 'D
    '    drawHeight = PictureBox1.Height - fudge
    '    drawWidth = PictureBox1.Width - fudge
    '    graph.DrawRectangle(Pens.Cyan, 0, 0, drawWidth, drawHeight)
    '    graph.DrawLine(Pens.Cyan, 0, (drawHeight) / 2, drawWidth, (drawHeight) / 2)
    '    'Draw a sine wave
    '    radius = (drawHeight) / 2
    '    x1 = 0 : y1 = (drawHeight) / 2
    '    For angle = 0 To 360 Step 1.0 'Draw a sine wave
    '        y2 = CSng(-radius * Math.Sin(angle / 57.3) + (drawHeight) / 2)
    '        x2 = angle * (drawWidth) / 360
    '        graph.DrawLine(Pens.Yellow, x1, y1, x2, y2)
    '        x1 = x2 : y1 = y2
    '    Next
    'End Sub


End Class

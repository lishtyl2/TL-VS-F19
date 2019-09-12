Public Class controlExample
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        'setting an image like this works but it is hard coded to the file location of the current system
        'PictureBox1.Image = Image.FromFile("C:\Users\lisht\OneDrive\Documents\GitHub\TL-VS-F19\Examples\09-10\Resources\20150906_102339.jpg")

        'this works by using the resource manager. 
        'PictureBox1.Image = My.Resources._20150806_102244
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click

        If RadioButton1.Checked = True Then
            Console.WriteLine("Radio 1")
        ElseIf RadioButton2.Checked = True Then
            Console.WriteLine("Radio 2")
        ElseIf RadioButton3.Checked = True Then
            Console.WriteLine("Radio 3")

        End If

        Button1.Enabled = True
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'this works by using the resource manager. 
        PictureBox1.Image = My.Resources._20150906_102339
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'this works by using the resource manager. 
        PictureBox1.Image = My.Resources._20150806_102244
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Hide()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Show()

    End Sub
End Class

Public Class Form1

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim i As Integer 'Loop counter: index, column, row counter -- whatever your looping on
        Dim j As Integer 'Nested as Loop
        Dim outterLoopMax As Integer
        Dim innerLoopMax As Integer
        Dim loopStart As Integer
        Dim outterStep As Integer
        Dim innerStep As Integer

        outterLoopMax = Integer.Parse(TextBox1.Text)
        innerLoopMax = Integer.Parse(TextBox2.Text)
        loopStart = Integer.Parse(TextBox3.Text)
        outterStep = Integer.Parse(TextBox4.Text)
        innerStep = Integer.Parse(TextBox5.Text)

        'TextBox1.Text = Integer.Parse(outterLoopMax)
        'TextBox2.Text = Integer.Parse(innerLoopMax)
        'TextBox3.Text = Integer.Parse(loopStart)
        'TextBox4.Text = Integer.Parse(outterStep)
        'TextBox5.Text = Integer.Parse(innerStep)


        ' from 1 to 100 in increments of 1
        'i or loopcounter variable gets assigned by and incremented by the loop structure. 
        For i = loopStart To outterLoopMax Step outterStep 'Outer loop
            Console.WriteLine(i)
            For j = loopStart To innerLoopMax Step innerStep 'inner loop
                Console.WriteLine("outter loop i = " & Str(i) & " " & "inner loop j = " & Str(j))
            Next
        Next
    End Sub
End Class

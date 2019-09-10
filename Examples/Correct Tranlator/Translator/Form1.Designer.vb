<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SpanishButton = New System.Windows.Forms.Button()
        Me.DisplayLabel1 = New System.Windows.Forms.Label()
        Me.FrenchButton = New System.Windows.Forms.Button()
        Me.ArabicButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(702, 401)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(86, 37)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SpanishButton
        '
        Me.SpanishButton.Location = New System.Drawing.Point(264, 335)
        Me.SpanishButton.Name = "SpanishButton"
        Me.SpanishButton.Size = New System.Drawing.Size(99, 37)
        Me.SpanishButton.TabIndex = 1
        Me.SpanishButton.Text = "Spanish"
        Me.SpanishButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel1
        '
        Me.DisplayLabel1.AutoSize = True
        Me.DisplayLabel1.Location = New System.Drawing.Point(261, 115)
        Me.DisplayLabel1.Name = "DisplayLabel1"
        Me.DisplayLabel1.Size = New System.Drawing.Size(0, 17)
        Me.DisplayLabel1.TabIndex = 2
        '
        'FrenchButton
        '
        Me.FrenchButton.Location = New System.Drawing.Point(145, 335)
        Me.FrenchButton.Name = "FrenchButton"
        Me.FrenchButton.Size = New System.Drawing.Size(94, 37)
        Me.FrenchButton.TabIndex = 3
        Me.FrenchButton.Text = "French"
        Me.FrenchButton.UseVisualStyleBackColor = True
        '
        'ArabicButton
        '
        Me.ArabicButton.Location = New System.Drawing.Point(22, 335)
        Me.ArabicButton.Name = "ArabicButton"
        Me.ArabicButton.Size = New System.Drawing.Size(101, 37)
        Me.ArabicButton.TabIndex = 4
        Me.ArabicButton.Text = "Arabic"
        Me.ArabicButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Italian"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(540, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Russian"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(670, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 37)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "English"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ArabicButton)
        Me.Controls.Add(Me.FrenchButton)
        Me.Controls.Add(Me.DisplayLabel1)
        Me.Controls.Add(Me.SpanishButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Form1"
        Me.Text = "Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents SpanishButton As Button
    Friend WithEvents DisplayLabel1 As Windows.Forms.Label
    Friend WithEvents FrenchButton As Button
    Friend WithEvents ArabicButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

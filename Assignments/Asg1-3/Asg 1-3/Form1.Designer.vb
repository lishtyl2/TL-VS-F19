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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EarlyBirdButton = New System.Windows.Forms.Button()
        Me.PennySavedButton = New System.Windows.Forms.Button()
        Me.NoGutsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(643, 341)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(145, 62)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(718, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tyler Lish"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 2
        '
        'EarlyBirdButton
        '
        Me.EarlyBirdButton.Location = New System.Drawing.Point(448, 341)
        Me.EarlyBirdButton.Name = "EarlyBirdButton"
        Me.EarlyBirdButton.Size = New System.Drawing.Size(169, 62)
        Me.EarlyBirdButton.TabIndex = 3
        Me.EarlyBirdButton.Text = "Early Bird"
        Me.EarlyBirdButton.UseVisualStyleBackColor = True
        '
        'PennySavedButton
        '
        Me.PennySavedButton.Location = New System.Drawing.Point(277, 341)
        Me.PennySavedButton.Name = "PennySavedButton"
        Me.PennySavedButton.Size = New System.Drawing.Size(143, 62)
        Me.PennySavedButton.TabIndex = 4
        Me.PennySavedButton.Text = "Penny Saved"
        Me.PennySavedButton.UseVisualStyleBackColor = True
        '
        'NoGutsButton
        '
        Me.NoGutsButton.Location = New System.Drawing.Point(108, 341)
        Me.NoGutsButton.Name = "NoGutsButton"
        Me.NoGutsButton.Size = New System.Drawing.Size(152, 62)
        Me.NoGutsButton.TabIndex = 5
        Me.NoGutsButton.Text = "No Guts"
        Me.NoGutsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NoGutsButton)
        Me.Controls.Add(Me.PennySavedButton)
        Me.Controls.Add(Me.EarlyBirdButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Form1"
        Me.Text = "Something Meaningful"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EarlyBirdButton As Button
    Friend WithEvents PennySavedButton As Button
    Friend WithEvents NoGutsButton As Button
End Class

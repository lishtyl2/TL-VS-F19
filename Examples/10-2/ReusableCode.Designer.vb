<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReusableCode
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
        Me.GoButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInput = New System.Windows.Forms.GroupBox()
        Me.ThirdTextbox = New System.Windows.Forms.TextBox()
        Me.SecondTextbox = New System.Windows.Forms.TextBox()
        Me.FirstTextbox = New System.Windows.Forms.TextBox()
        Me.UserInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(304, 352)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(142, 86)
        Me.GoButton.TabIndex = 0
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(469, 352)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(142, 86)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(637, 352)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(142, 86)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UserInput
        '
        Me.UserInput.Controls.Add(Me.ThirdTextbox)
        Me.UserInput.Controls.Add(Me.SecondTextbox)
        Me.UserInput.Controls.Add(Me.FirstTextbox)
        Me.UserInput.Location = New System.Drawing.Point(13, 13)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(500, 333)
        Me.UserInput.TabIndex = 3
        Me.UserInput.TabStop = False
        Me.UserInput.Text = "Stuff and Things"
        '
        'ThirdTextbox
        '
        Me.ThirdTextbox.Location = New System.Drawing.Point(42, 155)
        Me.ThirdTextbox.Name = "ThirdTextbox"
        Me.ThirdTextbox.Size = New System.Drawing.Size(209, 22)
        Me.ThirdTextbox.TabIndex = 2
        Me.ThirdTextbox.Text = "Third"
        '
        'SecondTextbox
        '
        Me.SecondTextbox.Location = New System.Drawing.Point(42, 101)
        Me.SecondTextbox.Name = "SecondTextbox"
        Me.SecondTextbox.Size = New System.Drawing.Size(209, 22)
        Me.SecondTextbox.TabIndex = 1
        Me.SecondTextbox.Text = "Second"
        '
        'FirstTextbox
        '
        Me.FirstTextbox.Location = New System.Drawing.Point(42, 48)
        Me.FirstTextbox.Name = "FirstTextbox"
        Me.FirstTextbox.Size = New System.Drawing.Size(209, 22)
        Me.FirstTextbox.TabIndex = 0
        Me.FirstTextbox.Text = "First"
        '
        'ReusableCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.GoButton)
        Me.Name = "ReusableCode"
        Me.Text = "User Data"
        Me.UserInput.ResumeLayout(False)
        Me.UserInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GoButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserInput As GroupBox
    Friend WithEvents ThirdTextbox As TextBox
    Friend WithEvents SecondTextbox As TextBox
    Friend WithEvents FirstTextbox As TextBox
End Class

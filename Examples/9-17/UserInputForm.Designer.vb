<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInputForm
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
        Me.GetInputButton = New System.Windows.Forms.Button()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GetInputButton
        '
        Me.GetInputButton.Location = New System.Drawing.Point(168, 263)
        Me.GetInputButton.Name = "GetInputButton"
        Me.GetInputButton.Size = New System.Drawing.Size(149, 70)
        Me.GetInputButton.TabIndex = 0
        Me.GetInputButton.Text = "Get Input"
        Me.GetInputButton.UseVisualStyleBackColor = True
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(168, 91)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(149, 22)
        Me.NumberTextBox.TabIndex = 1
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(168, 68)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(108, 17)
        Me.NumberLabel.TabIndex = 2
        Me.NumberLabel.Text = "Enter a Number"
        '
        'UserInputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 387)
        Me.Controls.Add(Me.NumberLabel)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.GetInputButton)
        Me.Name = "UserInputForm"
        Me.Text = "Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetInputButton As Button
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents NumberLabel As Label
End Class

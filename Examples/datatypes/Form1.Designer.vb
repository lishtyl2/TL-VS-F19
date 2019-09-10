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
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.Plus = New System.Windows.Forms.Button()
        Me.DisplayLabel1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(577, 326)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(116, 53)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(240, 50)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(196, 22)
        Me.FirstNumberTextBox.TabIndex = 1
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(240, 156)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(196, 22)
        Me.SecondNumberTextBox.TabIndex = 2
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(240, 202)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(196, 22)
        Me.ResultTextBox.TabIndex = 3
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(447, 326)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(106, 53)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "="
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'Plus
        '
        Me.Plus.Location = New System.Drawing.Point(341, 326)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(75, 53)
        Me.Plus.TabIndex = 5
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'DisplayLabel1
        '
        Me.DisplayLabel1.AutoSize = True
        Me.DisplayLabel1.Location = New System.Drawing.Point(319, 102)
        Me.DisplayLabel1.Name = "DisplayLabel1"
        Me.DisplayLabel1.Size = New System.Drawing.Size(0, 17)
        Me.DisplayLabel1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplayLabel1)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.SecondNumberTextBox)
        Me.Controls.Add(Me.FirstNumberTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents Plus As Button
    Friend WithEvents DisplayLabel1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiceMachine
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
        Me.DiceSum = New System.Windows.Forms.ListBox()
        Me.DiceButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DiceSum
        '
        Me.DiceSum.FormattingEnabled = True
        Me.DiceSum.ItemHeight = 16
        Me.DiceSum.Location = New System.Drawing.Point(35, 32)
        Me.DiceSum.Name = "DiceSum"
        Me.DiceSum.Size = New System.Drawing.Size(929, 260)
        Me.DiceSum.TabIndex = 0
        '
        'DiceButton
        '
        Me.DiceButton.Location = New System.Drawing.Point(286, 336)
        Me.DiceButton.Name = "DiceButton"
        Me.DiceButton.Size = New System.Drawing.Size(263, 92)
        Me.DiceButton.TabIndex = 1
        Me.DiceButton.Text = "Roll those Dice"
        Me.DiceButton.UseVisualStyleBackColor = True
        '
        'DiceMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 440)
        Me.Controls.Add(Me.DiceButton)
        Me.Controls.Add(Me.DiceSum)
        Me.Name = "DiceMachine"
        Me.Text = "Dice Machine"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DiceSum As ListBox
    Friend WithEvents DiceButton As Button
End Class

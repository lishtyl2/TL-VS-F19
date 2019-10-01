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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.RespondButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BadRadioButton = New System.Windows.Forms.RadioButton()
        Me.MehRadioButton = New System.Windows.Forms.RadioButton()
        Me.GoodRadioButton = New System.Windows.Forms.RadioButton()
        Me.MathBox = New System.Windows.Forms.GroupBox()
        Me.SubtractButton = New System.Windows.Forms.RadioButton()
        Me.AddButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.MathBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(482, 257)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(206, 84)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = " Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'RespondButton
        '
        Me.RespondButton.Location = New System.Drawing.Point(240, 257)
        Me.RespondButton.Name = "RespondButton"
        Me.RespondButton.Size = New System.Drawing.Size(201, 84)
        Me.RespondButton.TabIndex = 1
        Me.RespondButton.Text = "Respond"
        Me.RespondButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GoodRadioButton)
        Me.GroupBox1.Controls.Add(Me.MehRadioButton)
        Me.GroupBox1.Controls.Add(Me.BadRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 201)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hows your day?"
        '
        'BadRadioButton
        '
        Me.BadRadioButton.AutoSize = True
        Me.BadRadioButton.Location = New System.Drawing.Point(43, 41)
        Me.BadRadioButton.Name = "BadRadioButton"
        Me.BadRadioButton.Size = New System.Drawing.Size(54, 21)
        Me.BadRadioButton.TabIndex = 0
        Me.BadRadioButton.TabStop = True
        Me.BadRadioButton.Text = "Bad"
        Me.BadRadioButton.UseVisualStyleBackColor = True
        '
        'MehRadioButton
        '
        Me.MehRadioButton.AutoSize = True
        Me.MehRadioButton.Location = New System.Drawing.Point(43, 90)
        Me.MehRadioButton.Name = "MehRadioButton"
        Me.MehRadioButton.Size = New System.Drawing.Size(56, 21)
        Me.MehRadioButton.TabIndex = 1
        Me.MehRadioButton.TabStop = True
        Me.MehRadioButton.Text = "Meh"
        Me.MehRadioButton.UseVisualStyleBackColor = True
        '
        'GoodRadioButton
        '
        Me.GoodRadioButton.AutoSize = True
        Me.GoodRadioButton.Location = New System.Drawing.Point(43, 135)
        Me.GoodRadioButton.Name = "GoodRadioButton"
        Me.GoodRadioButton.Size = New System.Drawing.Size(64, 21)
        Me.GoodRadioButton.TabIndex = 2
        Me.GoodRadioButton.TabStop = True
        Me.GoodRadioButton.Text = "Good"
        Me.GoodRadioButton.UseVisualStyleBackColor = True
        '
        'MathBox
        '
        Me.MathBox.Controls.Add(Me.SubtractButton)
        Me.MathBox.Controls.Add(Me.AddButton)
        Me.MathBox.Location = New System.Drawing.Point(83, 34)
        Me.MathBox.Name = "MathBox"
        Me.MathBox.Size = New System.Drawing.Size(200, 201)
        Me.MathBox.TabIndex = 3
        Me.MathBox.TabStop = False
        Me.MathBox.Text = "Math"
        '
        'SubtractButton
        '
        Me.SubtractButton.AutoSize = True
        Me.SubtractButton.Location = New System.Drawing.Point(43, 90)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(82, 21)
        Me.SubtractButton.TabIndex = 1
        Me.SubtractButton.TabStop = True
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.AutoSize = True
        Me.AddButton.Location = New System.Drawing.Point(43, 41)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(54, 21)
        Me.AddButton.TabIndex = 0
        Me.AddButton.TabStop = True
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MathBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RespondButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MathBox.ResumeLayout(False)
        Me.MathBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClearButton As Button
    Friend WithEvents RespondButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GoodRadioButton As RadioButton
    Friend WithEvents MehRadioButton As RadioButton
    Friend WithEvents BadRadioButton As RadioButton
    Friend WithEvents MathBox As GroupBox
    Friend WithEvents SubtractButton As RadioButton
    Friend WithEvents AddButton As RadioButton
End Class

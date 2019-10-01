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
        Me.SelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.BadDayRadioButton = New System.Windows.Forms.RadioButton()
        Me.MehDayRadioButton = New System.Windows.Forms.RadioButton()
        Me.GoodDayRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.RespondButton = New System.Windows.Forms.Button()
        Me.SelectionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectionGroupBox
        '
        Me.SelectionGroupBox.Controls.Add(Me.GoodDayRadioButton)
        Me.SelectionGroupBox.Controls.Add(Me.MehDayRadioButton)
        Me.SelectionGroupBox.Controls.Add(Me.BadDayRadioButton)
        Me.SelectionGroupBox.Location = New System.Drawing.Point(434, 112)
        Me.SelectionGroupBox.Name = "SelectionGroupBox"
        Me.SelectionGroupBox.Size = New System.Drawing.Size(213, 260)
        Me.SelectionGroupBox.TabIndex = 0
        Me.SelectionGroupBox.TabStop = False
        Me.SelectionGroupBox.Text = "Select One"
        '
        'BadDayRadioButton
        '
        Me.BadDayRadioButton.AutoSize = True
        Me.BadDayRadioButton.Location = New System.Drawing.Point(64, 61)
        Me.BadDayRadioButton.Name = "BadDayRadioButton"
        Me.BadDayRadioButton.Size = New System.Drawing.Size(54, 21)
        Me.BadDayRadioButton.TabIndex = 0
        Me.BadDayRadioButton.TabStop = True
        Me.BadDayRadioButton.Text = "Bad"
        Me.BadDayRadioButton.UseVisualStyleBackColor = True
        '
        'MehDayRadioButton
        '
        Me.MehDayRadioButton.AutoSize = True
        Me.MehDayRadioButton.Location = New System.Drawing.Point(64, 114)
        Me.MehDayRadioButton.Name = "MehDayRadioButton"
        Me.MehDayRadioButton.Size = New System.Drawing.Size(56, 21)
        Me.MehDayRadioButton.TabIndex = 1
        Me.MehDayRadioButton.TabStop = True
        Me.MehDayRadioButton.Text = "Meh"
        Me.MehDayRadioButton.UseVisualStyleBackColor = True
        '
        'GoodDayRadioButton
        '
        Me.GoodDayRadioButton.AutoSize = True
        Me.GoodDayRadioButton.Location = New System.Drawing.Point(64, 178)
        Me.GoodDayRadioButton.Name = "GoodDayRadioButton"
        Me.GoodDayRadioButton.Size = New System.Drawing.Size(64, 21)
        Me.GoodDayRadioButton.TabIndex = 2
        Me.GoodDayRadioButton.TabStop = True
        Me.GoodDayRadioButton.Text = "Good"
        Me.GoodDayRadioButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(62, 29)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(149, 99)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'RespondButton
        '
        Me.RespondButton.Location = New System.Drawing.Point(62, 148)
        Me.RespondButton.Name = "RespondButton"
        Me.RespondButton.Size = New System.Drawing.Size(149, 99)
        Me.RespondButton.TabIndex = 2
        Me.RespondButton.Text = "Respond"
        Me.RespondButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RespondButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SelectionGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SelectionGroupBox.ResumeLayout(False)
        Me.SelectionGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SelectionGroupBox As GroupBox
    Friend WithEvents GoodDayRadioButton As RadioButton
    Friend WithEvents MehDayRadioButton As RadioButton
    Friend WithEvents BadDayRadioButton As RadioButton
    Friend WithEvents ClearButton As Button
    Friend WithEvents RespondButton As Button
End Class

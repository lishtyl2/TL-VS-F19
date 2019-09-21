<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryCalculator
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
        Me.components = New System.ComponentModel.Container()
        Me.UserInputSide = New System.Windows.Forms.GroupBox()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.EndingLabel = New System.Windows.Forms.Label()
        Me.BeginningLabel = New System.Windows.Forms.Label()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.EndingTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningTextBox = New System.Windows.Forms.TextBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.AverageLabel = New System.Windows.Forms.Label()
        Me.TurnoverLabel = New System.Windows.Forms.Label()
        Me.TurnoverTextBox = New System.Windows.Forms.TextBox()
        Me.AverageTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UserInputSide.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserInputSide
        '
        Me.UserInputSide.Controls.Add(Me.CostLabel)
        Me.UserInputSide.Controls.Add(Me.EndingLabel)
        Me.UserInputSide.Controls.Add(Me.BeginningLabel)
        Me.UserInputSide.Controls.Add(Me.CostTextBox)
        Me.UserInputSide.Controls.Add(Me.EndingTextBox)
        Me.UserInputSide.Controls.Add(Me.BeginningTextBox)
        Me.UserInputSide.Location = New System.Drawing.Point(47, 36)
        Me.UserInputSide.Name = "UserInputSide"
        Me.UserInputSide.Size = New System.Drawing.Size(308, 318)
        Me.UserInputSide.TabIndex = 0
        Me.UserInputSide.TabStop = False
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(28, 202)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(130, 17)
        Me.CostLabel.TabIndex = 5
        Me.CostLabel.Text = "Cost of Goods Sold"
        Me.ToolTip1.SetToolTip(Me.CostLabel, "How much are you selling your stuff for?")
        '
        'EndingLabel
        '
        Me.EndingLabel.AutoSize = True
        Me.EndingLabel.Location = New System.Drawing.Point(28, 112)
        Me.EndingLabel.Name = "EndingLabel"
        Me.EndingLabel.Size = New System.Drawing.Size(114, 17)
        Me.EndingLabel.TabIndex = 4
        Me.EndingLabel.Text = "Ending Inventory"
        Me.ToolTip1.SetToolTip(Me.EndingLabel, "Insert how many you had at the end of the day/month/year")
        '
        'BeginningLabel
        '
        Me.BeginningLabel.AutoSize = True
        Me.BeginningLabel.Location = New System.Drawing.Point(28, 22)
        Me.BeginningLabel.Name = "BeginningLabel"
        Me.BeginningLabel.Size = New System.Drawing.Size(133, 17)
        Me.BeginningLabel.TabIndex = 3
        Me.BeginningLabel.Text = "Beginning Inventory"
        Me.ToolTip1.SetToolTip(Me.BeginningLabel, "Insert how many you had to begin with. ")
        '
        'CostTextBox
        '
        Me.CostTextBox.Location = New System.Drawing.Point(28, 225)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(249, 22)
        Me.CostTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CostTextBox, "How much are you selling your stuff for?")
        '
        'EndingTextBox
        '
        Me.EndingTextBox.Location = New System.Drawing.Point(28, 135)
        Me.EndingTextBox.Name = "EndingTextBox"
        Me.EndingTextBox.Size = New System.Drawing.Size(249, 22)
        Me.EndingTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EndingTextBox, "Insert how many you had at the end of the day/month/year")
        '
        'BeginningTextBox
        '
        Me.BeginningTextBox.Location = New System.Drawing.Point(28, 45)
        Me.BeginningTextBox.Name = "BeginningTextBox"
        Me.BeginningTextBox.Size = New System.Drawing.Size(249, 22)
        Me.BeginningTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BeginningTextBox, "Insert how many you had to begin with. ")
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.AverageLabel)
        Me.OutputGroupBox.Controls.Add(Me.TurnoverLabel)
        Me.OutputGroupBox.Controls.Add(Me.TurnoverTextBox)
        Me.OutputGroupBox.Controls.Add(Me.AverageTextBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(370, 36)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(273, 318)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        '
        'AverageLabel
        '
        Me.AverageLabel.AutoSize = True
        Me.AverageLabel.Location = New System.Drawing.Point(36, 21)
        Me.AverageLabel.Name = "AverageLabel"
        Me.AverageLabel.Size = New System.Drawing.Size(123, 17)
        Me.AverageLabel.TabIndex = 3
        Me.AverageLabel.Text = "Average Inventory"
        Me.ToolTip1.SetToolTip(Me.AverageLabel, "Don't type anything here. It will populate for you!")
        '
        'TurnoverLabel
        '
        Me.TurnoverLabel.AutoSize = True
        Me.TurnoverLabel.Location = New System.Drawing.Point(36, 111)
        Me.TurnoverLabel.Name = "TurnoverLabel"
        Me.TurnoverLabel.Size = New System.Drawing.Size(66, 17)
        Me.TurnoverLabel.TabIndex = 2
        Me.TurnoverLabel.Text = "Turnover"
        Me.ToolTip1.SetToolTip(Me.TurnoverLabel, "Don't type anything here. It will populate for you!")
        '
        'TurnoverTextBox
        '
        Me.TurnoverTextBox.Location = New System.Drawing.Point(36, 134)
        Me.TurnoverTextBox.Name = "TurnoverTextBox"
        Me.TurnoverTextBox.Size = New System.Drawing.Size(211, 22)
        Me.TurnoverTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TurnoverTextBox, "Don't type anything here. It will populate for you!")
        '
        'AverageTextBox
        '
        Me.AverageTextBox.Location = New System.Drawing.Point(36, 44)
        Me.AverageTextBox.Name = "AverageTextBox"
        Me.AverageTextBox.Size = New System.Drawing.Size(211, 22)
        Me.AverageTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.AverageTextBox, "Don't type anything here. It will populate for you!")
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(47, 371)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(308, 67)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "Calcula&te"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Click here to crunch those numbers.")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(370, 371)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(122, 67)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Everything is wrong, lets start over. ")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(521, 371)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(122, 67)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Just let me out of here. ")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'InventoryCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.UserInputSide)
        Me.Name = "InventoryCalculator"
        Me.Text = "Inventory Calculator"
        Me.UserInputSide.ResumeLayout(False)
        Me.UserInputSide.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserInputSide As GroupBox
    Friend WithEvents CostLabel As Label
    Friend WithEvents EndingLabel As Label
    Friend WithEvents BeginningLabel As Label
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents EndingTextBox As TextBox
    Friend WithEvents BeginningTextBox As TextBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents AverageLabel As Label
    Friend WithEvents TurnoverLabel As Label
    Friend WithEvents TurnoverTextBox As TextBox
    Friend WithEvents AverageTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class

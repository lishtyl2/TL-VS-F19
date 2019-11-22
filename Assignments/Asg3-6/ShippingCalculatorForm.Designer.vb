<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingFormCalculator
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
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.OuncesLabel = New System.Windows.Forms.Label()
        Me.OuncesTextBox = New System.Windows.Forms.TextBox()
        Me.PoundsLabel = New System.Windows.Forms.Label()
        Me.ShippingWeightLabel = New System.Windows.Forms.Label()
        Me.PoundsTextBox = New System.Windows.Forms.TextBox()
        Me.IDCodeLabel = New System.Windows.Forms.Label()
        Me.IDCodeTextBox = New System.Windows.Forms.TextBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ShippingCostLabel = New System.Windows.Forms.Label()
        Me.ShippingCostTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.OuncesLabel)
        Me.InputGroupBox.Controls.Add(Me.OuncesTextBox)
        Me.InputGroupBox.Controls.Add(Me.PoundsLabel)
        Me.InputGroupBox.Controls.Add(Me.ShippingWeightLabel)
        Me.InputGroupBox.Controls.Add(Me.PoundsTextBox)
        Me.InputGroupBox.Controls.Add(Me.IDCodeLabel)
        Me.InputGroupBox.Controls.Add(Me.IDCodeTextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 38)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(360, 296)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        '
        'OuncesLabel
        '
        Me.OuncesLabel.AutoSize = True
        Me.OuncesLabel.Location = New System.Drawing.Point(284, 250)
        Me.OuncesLabel.Name = "OuncesLabel"
        Me.OuncesLabel.Size = New System.Drawing.Size(27, 17)
        Me.OuncesLabel.TabIndex = 6
        Me.OuncesLabel.Text = ".oz"
        Me.ToolTip1.SetToolTip(Me.OuncesLabel, "How many ounces does it weigh? ")
        '
        'OuncesTextBox
        '
        Me.OuncesTextBox.Location = New System.Drawing.Point(178, 245)
        Me.OuncesTextBox.Name = "OuncesTextBox"
        Me.OuncesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.OuncesTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.OuncesTextBox, "How many ounces does it weigh? ")
        '
        'PoundsLabel
        '
        Me.PoundsLabel.AutoSize = True
        Me.PoundsLabel.Location = New System.Drawing.Point(113, 248)
        Me.PoundsLabel.Name = "PoundsLabel"
        Me.PoundsLabel.Size = New System.Drawing.Size(30, 17)
        Me.PoundsLabel.TabIndex = 4
        Me.PoundsLabel.Text = ".lbs"
        Me.ToolTip1.SetToolTip(Me.PoundsLabel, "How many pounds does it weigh?")
        '
        'ShippingWeightLabel
        '
        Me.ShippingWeightLabel.AutoSize = True
        Me.ShippingWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingWeightLabel.Location = New System.Drawing.Point(37, 217)
        Me.ShippingWeightLabel.Name = "ShippingWeightLabel"
        Me.ShippingWeightLabel.Size = New System.Drawing.Size(261, 25)
        Me.ShippingWeightLabel.TabIndex = 3
        Me.ShippingWeightLabel.Text = "Package Shipping Weight"
        '
        'PoundsTextBox
        '
        Me.PoundsTextBox.Location = New System.Drawing.Point(7, 245)
        Me.PoundsTextBox.Name = "PoundsTextBox"
        Me.PoundsTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PoundsTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.PoundsTextBox, "How many pounds does it weigh?")
        '
        'IDCodeLabel
        '
        Me.IDCodeLabel.AutoSize = True
        Me.IDCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDCodeLabel.Location = New System.Drawing.Point(6, 44)
        Me.IDCodeLabel.Name = "IDCodeLabel"
        Me.IDCodeLabel.Size = New System.Drawing.Size(139, 20)
        Me.IDCodeLabel.TabIndex = 1
        Me.IDCodeLabel.Text = "6 Digit ID Code"
        Me.ToolTip1.SetToolTip(Me.IDCodeLabel, "Please Enter your 6 Digit ID Code here. ")
        '
        'IDCodeTextBox
        '
        Me.IDCodeTextBox.Location = New System.Drawing.Point(6, 67)
        Me.IDCodeTextBox.MaxLength = 6
        Me.IDCodeTextBox.Name = "IDCodeTextBox"
        Me.IDCodeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDCodeTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.IDCodeTextBox, "Please Enter your 6 Digit ID Code here. ")
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.ShippingCostLabel)
        Me.OutputGroupBox.Controls.Add(Me.ShippingCostTextBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(409, 38)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(320, 296)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        '
        'ShippingCostLabel
        '
        Me.ShippingCostLabel.AutoSize = True
        Me.ShippingCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingCostLabel.Location = New System.Drawing.Point(6, 210)
        Me.ShippingCostLabel.Name = "ShippingCostLabel"
        Me.ShippingCostLabel.Size = New System.Drawing.Size(148, 25)
        Me.ShippingCostLabel.TabIndex = 1
        Me.ShippingCostLabel.Text = "Shipping Cost"
        '
        'ShippingCostTextBox
        '
        Me.ShippingCostTextBox.Location = New System.Drawing.Point(10, 241)
        Me.ShippingCostTextBox.Name = "ShippingCostTextBox"
        Me.ShippingCostTextBox.Size = New System.Drawing.Size(218, 22)
        Me.ShippingCostTextBox.TabIndex = 0
        Me.ShippingCostTextBox.TabStop = False
        '
        'CalculateButton
        '
        Me.CalculateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CalculateButton.Location = New System.Drawing.Point(12, 340)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(360, 98)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Click here to crunch those numbers. ")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(409, 340)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(115, 98)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Oops I entered wrong numbers, click here to clear everything.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(550, 340)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(115, 98)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Well, I'm done now, click here to exit. ")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ShippingFormCalculator
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "ShippingFormCalculator"
        Me.Text = "Shipping Calculator"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents OuncesLabel As Label
    Friend WithEvents OuncesTextBox As TextBox
    Friend WithEvents PoundsLabel As Label
    Friend WithEvents ShippingWeightLabel As Label
    Friend WithEvents PoundsTextBox As TextBox
    Friend WithEvents IDCodeLabel As Label
    Friend WithEvents IDCodeTextBox As TextBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents ShippingCostLabel As Label
    Friend WithEvents ShippingCostTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.InfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.AgeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EquationGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.InfoGroupBox.SuspendLayout()
        Me.ProblemGroupBox.SuspendLayout()
        Me.EquationGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfoGroupBox
        '
        Me.InfoGroupBox.Controls.Add(Me.GradeComboBox)
        Me.InfoGroupBox.Controls.Add(Me.AgeComboBox)
        Me.InfoGroupBox.Controls.Add(Me.Label3)
        Me.InfoGroupBox.Controls.Add(Me.Label2)
        Me.InfoGroupBox.Controls.Add(Me.Label1)
        Me.InfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.InfoGroupBox.Location = New System.Drawing.Point(60, 55)
        Me.InfoGroupBox.Name = "InfoGroupBox"
        Me.InfoGroupBox.Size = New System.Drawing.Size(404, 104)
        Me.InfoGroupBox.TabIndex = 0
        Me.InfoGroupBox.TabStop = False
        Me.InfoGroupBox.Text = "Student Information"
        '
        'GradeComboBox
        '
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.GradeComboBox.Location = New System.Drawing.Point(263, 76)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(64, 24)
        Me.GradeComboBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.GradeComboBox, "Input your grade here. ")
        '
        'AgeComboBox
        '
        Me.AgeComboBox.FormattingEnabled = True
        Me.AgeComboBox.Items.AddRange(New Object() {"7", "8", "9", "10", "11"})
        Me.AgeComboBox.Location = New System.Drawing.Point(191, 76)
        Me.AgeComboBox.Name = "AgeComboBox"
        Me.AgeComboBox.Size = New System.Drawing.Size(50, 24)
        Me.AgeComboBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.AgeComboBox, "Select your age here.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 76)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(164, 22)
        Me.NameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Insert your full name here. ")
        '
        'ProblemGroupBox
        '
        Me.ProblemGroupBox.Controls.Add(Me.Label6)
        Me.ProblemGroupBox.Controls.Add(Me.Label5)
        Me.ProblemGroupBox.Controls.Add(Me.Label4)
        Me.ProblemGroupBox.Controls.Add(Me.AnswerTextBox)
        Me.ProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.ProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.ProblemGroupBox.Location = New System.Drawing.Point(60, 183)
        Me.ProblemGroupBox.Name = "ProblemGroupBox"
        Me.ProblemGroupBox.Size = New System.Drawing.Size(216, 228)
        Me.ProblemGroupBox.TabIndex = 1
        Me.ProblemGroupBox.TabStop = False
        Me.ProblemGroupBox.Text = "Current Math Problem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Student Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Second Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "First Number"
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(6, 165)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AnswerTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AnswerTextBox, "Input your answer here. ")
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(6, 107)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SecondNumberTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.SecondNumberTextBox, "This will fill in for you.")
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(6, 51)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FirstNumberTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FirstNumberTextBox, "This will fill in for you. ")
        '
        'EquationGroupBox
        '
        Me.EquationGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.EquationGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.EquationGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.EquationGroupBox.Controls.Add(Me.AddRadioButton)
        Me.EquationGroupBox.Location = New System.Drawing.Point(296, 183)
        Me.EquationGroupBox.Name = "EquationGroupBox"
        Me.EquationGroupBox.Size = New System.Drawing.Size(168, 228)
        Me.EquationGroupBox.TabIndex = 2
        Me.EquationGroupBox.TabStop = False
        Me.EquationGroupBox.Text = "Math Problem Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(15, 179)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(68, 21)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.ToolTip1.SetToolTip(Me.DivideRadioButton, "This is the divide option.")
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(15, 127)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(76, 21)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.ToolTip1.SetToolTip(Me.MultiplyRadioButton, "This is the multiply option.")
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(15, 82)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(82, 21)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.ToolTip1.SetToolTip(Me.SubtractRadioButton, "This is the subtract option.")
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(15, 37)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(54, 21)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.AddRadioButton, "This is the add option.")
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(503, 55)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(260, 356)
        Me.ButtonGroupBox.TabIndex = 3
        Me.ButtonGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(7, 284)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(247, 66)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click here to close. ")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(7, 191)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(247, 66)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Click here to see how many you got correct and incorrect.")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(7, 107)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(247, 66)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Click here to clear the form")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(7, 22)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(247, 66)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.ToolTip1.SetToolTip(Me.SubmitButton, "Click here to submit your answer.")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.EquationGroupBox)
        Me.Controls.Add(Me.ProblemGroupBox)
        Me.Controls.Add(Me.InfoGroupBox)
        Me.Name = "MathContest"
        Me.Text = "Math Contest"
        Me.InfoGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.PerformLayout()
        Me.ProblemGroupBox.ResumeLayout(False)
        Me.ProblemGroupBox.PerformLayout()
        Me.EquationGroupBox.ResumeLayout(False)
        Me.EquationGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InfoGroupBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ProblemGroupBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents EquationGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents AgeComboBox As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
End Class

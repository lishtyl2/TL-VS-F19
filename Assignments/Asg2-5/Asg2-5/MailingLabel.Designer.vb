<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MailingLabel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeBox = New System.Windows.Forms.MaskedTextBox()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.LastNameBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameBox = New System.Windows.Forms.TextBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StateBox)
        Me.GroupBox1.Controls.Add(Me.ZipCodeBox)
        Me.GroupBox1.Controls.Add(Me.ZipCodeLabel)
        Me.GroupBox1.Controls.Add(Me.StateLabel)
        Me.GroupBox1.Controls.Add(Me.CityBox)
        Me.GroupBox1.Controls.Add(Me.CityLabel)
        Me.GroupBox1.Controls.Add(Me.AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressBox)
        Me.GroupBox1.Controls.Add(Me.LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameBox)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 378)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mailing Address"
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(25, 253)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(48, 22)
        Me.StateBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.StateBox, "Very nice, what about the state?")
        '
        'ZipCodeBox
        '
        Me.ZipCodeBox.Location = New System.Drawing.Point(25, 303)
        Me.ZipCodeBox.Mask = "00000"
        Me.ZipCodeBox.Name = "ZipCodeBox"
        Me.ZipCodeBox.Size = New System.Drawing.Size(48, 22)
        Me.ZipCodeBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.ZipCodeBox, "Now, I am going to need the zip code. ")
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(22, 282)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(65, 17)
        Me.ZipCodeLabel.TabIndex = 10
        Me.ZipCodeLabel.Text = "Zip Code"
        Me.ToolTip1.SetToolTip(Me.ZipCodeLabel, "Now, I am going to need the zip code. ")
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(19, 232)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(41, 17)
        Me.StateLabel.TabIndex = 8
        Me.StateLabel.Text = "State"
        Me.ToolTip1.SetToolTip(Me.StateLabel, "Very nice, what about the state?")
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(25, 203)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(223, 22)
        Me.CityBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.CityBox, "And what city is that in? ")
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(16, 182)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(31, 17)
        Me.CityLabel.TabIndex = 6
        Me.CityLabel.Text = "City"
        Me.ToolTip1.SetToolTip(Me.CityLabel, "And what city is that in? ")
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(13, 133)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(102, 17)
        Me.AddressLabel.TabIndex = 5
        Me.AddressLabel.Text = "Street Address"
        Me.ToolTip1.SetToolTip(Me.AddressLabel, "I want to know everything about you. Enter your address here.")
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(25, 153)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(223, 22)
        Me.AddressBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.AddressBox, "I want to know everything about you. Enter your address here.")
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(10, 81)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(76, 17)
        Me.LastNameLabel.TabIndex = 3
        Me.LastNameLabel.Text = "Last Name"
        Me.ToolTip1.SetToolTip(Me.LastNameLabel, "This is where your last name goes. ")
        '
        'LastNameBox
        '
        Me.LastNameBox.Location = New System.Drawing.Point(25, 104)
        Me.LastNameBox.Name = "LastNameBox"
        Me.LastNameBox.Size = New System.Drawing.Size(223, 22)
        Me.LastNameBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.LastNameBox, "This is where your last name goes. ")
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(7, 28)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(76, 17)
        Me.FirstNameLabel.TabIndex = 1
        Me.FirstNameLabel.Text = "First Name"
        Me.ToolTip1.SetToolTip(Me.FirstNameLabel, "Enter your first name here.")
        '
        'FirstNameBox
        '
        Me.FirstNameBox.Location = New System.Drawing.Point(25, 51)
        Me.FirstNameBox.Name = "FirstNameBox"
        Me.FirstNameBox.Size = New System.Drawing.Size(223, 22)
        Me.FirstNameBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FirstNameBox, "Enter your first name here.")
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(409, 67)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(311, 220)
        Me.DisplayLabel.TabIndex = 1
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(641, 378)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(147, 60)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click here to exit the application")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(481, 378)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(154, 59)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Click here to clear the current mailing label")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(354, 378)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(121, 58)
        Me.GenerateButton.TabIndex = 10
        Me.GenerateButton.Text = "&Generate"
        Me.ToolTip1.SetToolTip(Me.GenerateButton, "Click here to generate the mailing label")
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'MailingLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MailingLabel"
        Me.Text = "Mailing Label"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ZipCodeBox As MaskedTextBox
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents LastNameBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents FirstNameBox As TextBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents GenerateButton As Button
    Friend WithEvents StateBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class

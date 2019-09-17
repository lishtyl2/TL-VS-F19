<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StateFlags
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KansasButton = New System.Windows.Forms.Button()
        Me.NorthDakotaButton = New System.Windows.Forms.Button()
        Me.OregonButton = New System.Windows.Forms.Button()
        Me.VermontButton = New System.Windows.Forms.Button()
        Me.NewYorkButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Asg2_6.My.Resources.Resources.please_select
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(692, 393)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'KansasButton
        '
        Me.KansasButton.Location = New System.Drawing.Point(12, 480)
        Me.KansasButton.Name = "KansasButton"
        Me.KansasButton.Size = New System.Drawing.Size(115, 60)
        Me.KansasButton.TabIndex = 1
        Me.KansasButton.Text = "&Kansas"
        Me.KansasButton.UseVisualStyleBackColor = True
        '
        'NorthDakotaButton
        '
        Me.NorthDakotaButton.Location = New System.Drawing.Point(133, 480)
        Me.NorthDakotaButton.Name = "NorthDakotaButton"
        Me.NorthDakotaButton.Size = New System.Drawing.Size(129, 60)
        Me.NorthDakotaButton.TabIndex = 2
        Me.NorthDakotaButton.Text = "North &Dakota"
        Me.NorthDakotaButton.UseVisualStyleBackColor = True
        '
        'OregonButton
        '
        Me.OregonButton.Location = New System.Drawing.Point(268, 480)
        Me.OregonButton.Name = "OregonButton"
        Me.OregonButton.Size = New System.Drawing.Size(131, 60)
        Me.OregonButton.TabIndex = 3
        Me.OregonButton.Text = "&Oregon"
        Me.OregonButton.UseVisualStyleBackColor = True
        '
        'VermontButton
        '
        Me.VermontButton.Location = New System.Drawing.Point(405, 480)
        Me.VermontButton.Name = "VermontButton"
        Me.VermontButton.Size = New System.Drawing.Size(130, 60)
        Me.VermontButton.TabIndex = 4
        Me.VermontButton.Text = "&Vermont"
        Me.VermontButton.UseVisualStyleBackColor = True
        '
        'NewYorkButton
        '
        Me.NewYorkButton.Location = New System.Drawing.Point(541, 480)
        Me.NewYorkButton.Name = "NewYorkButton"
        Me.NewYorkButton.Size = New System.Drawing.Size(138, 60)
        Me.NewYorkButton.TabIndex = 5
        Me.NewYorkButton.Text = "New &York"
        Me.NewYorkButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(188, 417)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(152, 57)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(346, 417)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(158, 57)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'StateFlags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 552)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NewYorkButton)
        Me.Controls.Add(Me.VermontButton)
        Me.Controls.Add(Me.OregonButton)
        Me.Controls.Add(Me.NorthDakotaButton)
        Me.Controls.Add(Me.KansasButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "StateFlags"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents KansasButton As Button
    Friend WithEvents NorthDakotaButton As Button
    Friend WithEvents OregonButton As Button
    Friend WithEvents VermontButton As Button
    Friend WithEvents NewYorkButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
End Class

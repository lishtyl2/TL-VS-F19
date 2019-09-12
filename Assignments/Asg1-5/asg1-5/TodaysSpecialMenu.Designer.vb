<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodaysSpecialMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodaysSpecialMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.ChefsButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(488, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 318)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click to select your specials!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(881, 512)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(815, 487)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(144, 49)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(673, 487)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(136, 49)
        Me.SoupButton.TabIndex = 3
        Me.SoupButton.Text = "Soup Du Jour"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'ChefsButton
        '
        Me.ChefsButton.Location = New System.Drawing.Point(527, 487)
        Me.ChefsButton.Name = "ChefsButton"
        Me.ChefsButton.Size = New System.Drawing.Size(140, 49)
        Me.ChefsButton.TabIndex = 4
        Me.ChefsButton.Text = "Chef's Special"
        Me.ChefsButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(369, 487)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(152, 49)
        Me.FishButton.TabIndex = 5
        Me.FishButton.Text = "Daily Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'TodaysSpecialMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 538)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.ChefsButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "TodaysSpecialMenu"
        Me.Text = "Baked Goods"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SoupButton As Button
    Friend WithEvents ChefsButton As Button
    Friend WithEvents FishButton As Button
End Class

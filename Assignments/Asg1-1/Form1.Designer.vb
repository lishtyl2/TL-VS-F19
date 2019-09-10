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
        Me.UpdateTitleButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.updatelabelbutton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UpdateTitleButton
        '
        Me.UpdateTitleButton.Location = New System.Drawing.Point(361, 379)
        Me.UpdateTitleButton.Name = "UpdateTitleButton"
        Me.UpdateTitleButton.Size = New System.Drawing.Size(121, 33)
        Me.UpdateTitleButton.TabIndex = 0
        Me.UpdateTitleButton.Text = "Update Title"
        Me.UpdateTitleButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(361, 337)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(121, 36)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(79, 70)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(600, 151)
        Me.DisplayLabel.TabIndex = 2
        Me.DisplayLabel.Text = "Hello World"
        '
        'updatelabelbutton
        '
        Me.updatelabelbutton.Location = New System.Drawing.Point(234, 379)
        Me.updatelabelbutton.Name = "updatelabelbutton"
        Me.updatelabelbutton.Size = New System.Drawing.Size(121, 33)
        Me.updatelabelbutton.TabIndex = 3
        Me.updatelabelbutton.Text = "Update Label"
        Me.updatelabelbutton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(506, 379)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(121, 36)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.updatelabelbutton)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateTitleButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpdateTitleButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents updatelabelbutton As Button
    Friend WithEvents ClearButton As Button
End Class

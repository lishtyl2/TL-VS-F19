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
        Me.ThisButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ThisButton
        '
        Me.ThisButton.Location = New System.Drawing.Point(12, 309)
        Me.ThisButton.Name = "ThisButton"
        Me.ThisButton.Size = New System.Drawing.Size(237, 129)
        Me.ThisButton.TabIndex = 0
        Me.ThisButton.Text = "Ready Go"
        Me.ThisButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ThisButton)
        Me.Name = "Form1"
        Me.Text = "Behind the curtain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ThisButton As Button
End Class

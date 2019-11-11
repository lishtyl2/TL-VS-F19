<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StocksForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SymbolGroupBox = New System.Windows.Forms.GroupBox()
        Me.StockSymbolTextBox = New System.Windows.Forms.TextBox()
        Me.PriceGroupBox = New System.Windows.Forms.GroupBox()
        Me.WednesdayTextBox = New System.Windows.Forms.TextBox()
        Me.TuesdayTextBox = New System.Windows.Forms.TextBox()
        Me.MondayTextBox = New System.Windows.Forms.TextBox()
        Me.StockList = New System.Windows.Forms.ListBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CalculateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SymbolGroupBox.SuspendLayout()
        Me.PriceGroupBox.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 26)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'SymbolGroupBox
        '
        Me.SymbolGroupBox.Controls.Add(Me.StockSymbolTextBox)
        Me.SymbolGroupBox.Location = New System.Drawing.Point(50, 63)
        Me.SymbolGroupBox.Name = "SymbolGroupBox"
        Me.SymbolGroupBox.Size = New System.Drawing.Size(234, 77)
        Me.SymbolGroupBox.TabIndex = 1
        Me.SymbolGroupBox.TabStop = False
        Me.SymbolGroupBox.Text = "Stock Symbol"
        '
        'StockSymbolTextBox
        '
        Me.StockSymbolTextBox.Location = New System.Drawing.Point(32, 39)
        Me.StockSymbolTextBox.Name = "StockSymbolTextBox"
        Me.StockSymbolTextBox.Size = New System.Drawing.Size(153, 22)
        Me.StockSymbolTextBox.TabIndex = 0
        '
        'PriceGroupBox
        '
        Me.PriceGroupBox.Controls.Add(Me.WednesdayTextBox)
        Me.PriceGroupBox.Controls.Add(Me.TuesdayTextBox)
        Me.PriceGroupBox.Controls.Add(Me.MondayTextBox)
        Me.PriceGroupBox.Location = New System.Drawing.Point(314, 63)
        Me.PriceGroupBox.Name = "PriceGroupBox"
        Me.PriceGroupBox.Size = New System.Drawing.Size(378, 77)
        Me.PriceGroupBox.TabIndex = 2
        Me.PriceGroupBox.TabStop = False
        Me.PriceGroupBox.Text = "Price per day"
        '
        'WednesdayTextBox
        '
        Me.WednesdayTextBox.Location = New System.Drawing.Point(263, 39)
        Me.WednesdayTextBox.Name = "WednesdayTextBox"
        Me.WednesdayTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WednesdayTextBox.TabIndex = 2
        '
        'TuesdayTextBox
        '
        Me.TuesdayTextBox.Location = New System.Drawing.Point(144, 39)
        Me.TuesdayTextBox.Name = "TuesdayTextBox"
        Me.TuesdayTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TuesdayTextBox.TabIndex = 1
        '
        'MondayTextBox
        '
        Me.MondayTextBox.Location = New System.Drawing.Point(26, 39)
        Me.MondayTextBox.Name = "MondayTextBox"
        Me.MondayTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MondayTextBox.TabIndex = 0
        '
        'StockList
        '
        Me.StockList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockList.FormattingEnabled = True
        Me.StockList.ItemHeight = 16
        Me.StockList.Location = New System.Drawing.Point(12, 210)
        Me.StockList.Name = "StockList"
        Me.StockList.Size = New System.Drawing.Size(532, 228)
        Me.StockList.TabIndex = 3
        '
        'CalculateButton
        '
        Me.CalculateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CalculateButton.Location = New System.Drawing.Point(550, 341)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(150, 97)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem1, Me.ClearToolStripMenuItem1, Me.SummaryToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 76)
        '
        'CalculateToolStripMenuItem1
        '
        Me.CalculateToolStripMenuItem1.Name = "CalculateToolStripMenuItem1"
        Me.CalculateToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.CalculateToolStripMenuItem1.Text = "&Calculate"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.ClearToolStripMenuItem1.Text = "C&lear"
        '
        'SummaryToolStripMenuItem1
        '
        Me.SummaryToolStripMenuItem1.Name = "SummaryToolStripMenuItem1"
        Me.SummaryToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.SummaryToolStripMenuItem1.Text = "&Summary"
        '
        'StocksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 450)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.StockList)
        Me.Controls.Add(Me.PriceGroupBox)
        Me.Controls.Add(Me.SymbolGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StocksForm"
        Me.Text = "Stock Program"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SymbolGroupBox.ResumeLayout(False)
        Me.SymbolGroupBox.PerformLayout()
        Me.PriceGroupBox.ResumeLayout(False)
        Me.PriceGroupBox.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SymbolGroupBox As GroupBox
    Friend WithEvents StockSymbolTextBox As TextBox
    Friend WithEvents PriceGroupBox As GroupBox
    Friend WithEvents WednesdayTextBox As TextBox
    Friend WithEvents TuesdayTextBox As TextBox
    Friend WithEvents MondayTextBox As TextBox
    Friend WithEvents StockList As ListBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CalculateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem1 As ToolStripMenuItem
End Class

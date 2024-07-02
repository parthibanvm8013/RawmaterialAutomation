<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_Main
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MDI_Main))
        MenuStrip1 = New MenuStrip()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        ItemToolStripMenuItem = New ToolStripMenuItem()
        GenericToolStripMenuItem = New ToolStripMenuItem()
        ItemCategoryToolStripMenuItem = New ToolStripMenuItem()
        TransactionToolStripMenuItem = New ToolStripMenuItem()
        ItemGenericMappingToolStripMenuItem = New ToolStripMenuItem()
        GenericStockUpdationToolStripMenuItem = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        BillOfQuantityToolStripMenuItem = New ToolStripMenuItem()
        StockInHandToolStripMenuItem = New ToolStripMenuItem()
        StockLedgerToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MasterToolStripMenuItem, TransactionToolStripMenuItem, ReportsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ItemToolStripMenuItem, GenericToolStripMenuItem, ItemCategoryToolStripMenuItem})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(55, 20)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' ItemToolStripMenuItem
        ' 
        ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        ItemToolStripMenuItem.Size = New Size(180, 22)
        ItemToolStripMenuItem.Text = "Item"
        ' 
        ' GenericToolStripMenuItem
        ' 
        GenericToolStripMenuItem.Name = "GenericToolStripMenuItem"
        GenericToolStripMenuItem.Size = New Size(180, 22)
        GenericToolStripMenuItem.Text = "Generic"
        ' 
        ' ItemCategoryToolStripMenuItem
        ' 
        ItemCategoryToolStripMenuItem.Name = "ItemCategoryToolStripMenuItem"
        ItemCategoryToolStripMenuItem.Size = New Size(180, 22)
        ItemCategoryToolStripMenuItem.Text = "Item Category"
        ' 
        ' TransactionToolStripMenuItem
        ' 
        TransactionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ItemGenericMappingToolStripMenuItem, GenericStockUpdationToolStripMenuItem})
        TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        TransactionToolStripMenuItem.Size = New Size(79, 20)
        TransactionToolStripMenuItem.Text = "Transaction"
        ' 
        ' ItemGenericMappingToolStripMenuItem
        ' 
        ItemGenericMappingToolStripMenuItem.Name = "ItemGenericMappingToolStripMenuItem"
        ItemGenericMappingToolStripMenuItem.Size = New Size(198, 22)
        ItemGenericMappingToolStripMenuItem.Text = "Item Generic Mapping"
        ' 
        ' GenericStockUpdationToolStripMenuItem
        ' 
        GenericStockUpdationToolStripMenuItem.Name = "GenericStockUpdationToolStripMenuItem"
        GenericStockUpdationToolStripMenuItem.Size = New Size(198, 22)
        GenericStockUpdationToolStripMenuItem.Text = "Generic Stock Updation"
        ' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BillOfQuantityToolStripMenuItem, StockInHandToolStripMenuItem, StockLedgerToolStripMenuItem})
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(59, 20)
        ReportsToolStripMenuItem.Text = "Reports"
        ' 
        ' BillOfQuantityToolStripMenuItem
        ' 
        BillOfQuantityToolStripMenuItem.Name = "BillOfQuantityToolStripMenuItem"
        BillOfQuantityToolStripMenuItem.Size = New Size(153, 22)
        BillOfQuantityToolStripMenuItem.Text = "Bill of Quantity"
        ' 
        ' StockInHandToolStripMenuItem
        ' 
        StockInHandToolStripMenuItem.Name = "StockInHandToolStripMenuItem"
        StockInHandToolStripMenuItem.Size = New Size(153, 22)
        StockInHandToolStripMenuItem.Text = "Stock in Hand"
        ' 
        ' StockLedgerToolStripMenuItem
        ' 
        StockLedgerToolStripMenuItem.Name = "StockLedgerToolStripMenuItem"
        StockLedgerToolStripMenuItem.Size = New Size(153, 22)
        StockLedgerToolStripMenuItem.Text = "Stock Ledger"
        ' 
        ' MDI_Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "MDI_Main"
        Text = "Generic Automation"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenericToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemGenericMappingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenericStockUpdationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillOfQuantityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockInHandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockLedgerToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItem
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TxbItemName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CmbItemCategory = New ComboBox()
        Label3 = New Label()
        TxbIndQty = New TextBox()
        T = New Label()
        TxbPactQty = New TextBox()
        Label4 = New Label()
        TxbItemStrength = New TextBox()
        ChbActivate = New CheckBox()
        BtnSave = New Button()
        BtnClear = New Button()
        DgvSaveList = New DataGridView()
        Label5 = New Label()
        sno = New DataGridViewTextBoxColumn()
        ItemName = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        Indqty = New DataGridViewTextBoxColumn()
        PackQty = New DataGridViewTextBoxColumn()
        Strength = New DataGridViewTextBoxColumn()
        Active = New DataGridViewTextBoxColumn()
        Addedby = New DataGridViewTextBoxColumn()
        AddedOn = New DataGridViewTextBoxColumn()
        CType(DgvSaveList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxbItemName
        ' 
        TxbItemName.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbItemName.Location = New Point(136, 12)
        TxbItemName.Name = "TxbItemName"
        TxbItemName.Size = New Size(308, 22)
        TxbItemName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter The Item Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(450, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 15)
        Label2.TabIndex = 2
        Label2.Text = "Select the Category"
        ' 
        ' CmbItemCategory
        ' 
        CmbItemCategory.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CmbItemCategory.FormattingEnabled = True
        CmbItemCategory.Location = New Point(560, 15)
        CmbItemCategory.Name = "CmbItemCategory"
        CmbItemCategory.Size = New Size(228, 23)
        CmbItemCategory.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 4
        Label3.Text = "Individual Qty"
        ' 
        ' TxbIndQty
        ' 
        TxbIndQty.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbIndQty.Location = New Point(136, 41)
        TxbIndQty.Name = "TxbIndQty"
        TxbIndQty.Size = New Size(122, 22)
        TxbIndQty.TabIndex = 5
        ' 
        ' T
        ' 
        T.AutoSize = True
        T.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        T.Location = New Point(264, 44)
        T.Name = "T"
        T.Size = New Size(55, 15)
        T.TabIndex = 6
        T.Text = "Pack Qty"
        ' 
        ' TxbPactQty
        ' 
        TxbPactQty.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbPactQty.Location = New Point(322, 41)
        TxbPactQty.Name = "TxbPactQty"
        TxbPactQty.Size = New Size(122, 22)
        TxbPactQty.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(450, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 8
        Label4.Text = "ITem Strength"
        ' 
        ' TxbItemStrength
        ' 
        TxbItemStrength.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbItemStrength.Location = New Point(560, 44)
        TxbItemStrength.Name = "TxbItemStrength"
        TxbItemStrength.Size = New Size(97, 22)
        TxbItemStrength.TabIndex = 9
        ' 
        ' ChbActivate
        ' 
        ChbActivate.AutoSize = True
        ChbActivate.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ChbActivate.Location = New Point(678, 48)
        ChbActivate.Name = "ChbActivate"
        ChbActivate.Size = New Size(62, 19)
        ChbActivate.TabIndex = 10
        ChbActivate.Text = "Active"
        ChbActivate.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSave.Location = New Point(136, 70)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 11
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnClear.Location = New Point(217, 70)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(75, 23)
        BtnClear.TabIndex = 12
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' DgvSaveList
        ' 
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DgvSaveList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgvSaveList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DgvSaveList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgvSaveList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgvSaveList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvSaveList.Columns.AddRange(New DataGridViewColumn() {sno, ItemName, Category, Indqty, PackQty, Strength, Active, Addedby, AddedOn})
        DgvSaveList.Location = New Point(12, 118)
        DgvSaveList.Name = "DgvSaveList"
        DgvSaveList.RowTemplate.Height = 25
        DgvSaveList.Size = New Size(776, 217)
        DgvSaveList.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 14
        Label5.Text = "Item List"
        ' 
        ' sno
        ' 
        sno.HeaderText = "S.No"
        sno.Name = "sno"
        sno.ReadOnly = True
        sno.Width = 58
        ' 
        ' Name
        ' 
        ItemName.HeaderText = "Name"
        ItemName.Name = "Name"
        ItemName.ReadOnly = True
        ItemName.Width = 62
        ' 
        ' Category
        ' 
        Category.HeaderText = "Category"
        Category.Name = "Category"
        Category.ReadOnly = True
        Category.Width = 81
        ' 
        ' Indqty
        ' 
        Indqty.HeaderText = "Indv.Qty"
        Indqty.Name = "Indqty"
        Indqty.ReadOnly = True
        Indqty.Width = 79
        ' 
        ' PackQty
        ' 
        PackQty.HeaderText = "Pack Qty"
        PackQty.Name = "PackQty"
        PackQty.ReadOnly = True
        PackQty.Width = 80
        ' 
        ' Strength
        ' 
        Strength.HeaderText = "Strength"
        Strength.Name = "Strength"
        Strength.ReadOnly = True
        Strength.Width = 78
        ' 
        ' Active
        ' 
        Active.HeaderText = "Active"
        Active.Name = "Active"
        Active.ReadOnly = True
        Active.Width = 68
        ' 
        ' Addedby
        ' 
        Addedby.HeaderText = "Added By"
        Addedby.Name = "Addedby"
        Addedby.ReadOnly = True
        Addedby.Width = 87
        ' 
        ' AddedOn
        ' 
        AddedOn.HeaderText = "Added On"
        AddedOn.Name = "AddedOn"
        AddedOn.ReadOnly = True
        AddedOn.Width = 88
        ' 
        ' FrmItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(DgvSaveList)
        Controls.Add(BtnClear)
        Controls.Add(BtnSave)
        Controls.Add(ChbActivate)
        Controls.Add(TxbItemStrength)
        Controls.Add(Label4)
        Controls.Add(TxbPactQty)
        Controls.Add(T)
        Controls.Add(TxbIndQty)
        Controls.Add(Label3)
        Controls.Add(CmbItemCategory)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxbItemName)

        CType(DgvSaveList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxbItemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbItemCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbIndQty As TextBox
    Friend WithEvents T As Label
    Friend WithEvents TxbPactQty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbItemStrength As TextBox
    Friend WithEvents ChbActivate As CheckBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents DgvSaveList As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents sno As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Indqty As DataGridViewTextBoxColumn
    Friend WithEvents PackQty As DataGridViewTextBoxColumn
    Friend WithEvents Strength As DataGridViewTextBoxColumn
    Friend WithEvents Active As DataGridViewTextBoxColumn
    Friend WithEvents Addedby As DataGridViewTextBoxColumn
    Friend WithEvents AddedOn As DataGridViewTextBoxColumn
End Class

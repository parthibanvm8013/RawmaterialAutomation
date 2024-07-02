<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenericMaster
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label5 = New Label()
        DgvSaveList = New DataGridView()
        sno = New DataGridViewTextBoxColumn()
        GenericName = New DataGridViewTextBoxColumn()
        Strength = New DataGridViewTextBoxColumn()
        Active = New DataGridViewTextBoxColumn()
        Addedby = New DataGridViewTextBoxColumn()
        AddedOn = New DataGridViewTextBoxColumn()
        BtnClear = New Button()
        BtnSave = New Button()
        ChbActivate = New CheckBox()
        Label1 = New Label()
        TxbItemName = New TextBox()
        TxbItemStrength = New TextBox()
        Label4 = New Label()
        TxbPactQty = New TextBox()
        T = New Label()
        TxbIndQty = New TextBox()
        Label3 = New Label()
        CType(DgvSaveList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 25
        Label5.Text = "Item List"
        ' 
        ' DgvSaveList
        ' 
        DataGridViewCellStyle3.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DgvSaveList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DgvSaveList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DgvSaveList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DgvSaveList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DgvSaveList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvSaveList.Columns.AddRange(New DataGridViewColumn() {sno, GenericName, Strength, Active, Addedby, AddedOn})
        DgvSaveList.Location = New Point(13, 102)
        DgvSaveList.Name = "DgvSaveList"
        DgvSaveList.RowTemplate.Height = 25
        DgvSaveList.Size = New Size(515, 196)
        DgvSaveList.TabIndex = 24
        ' 
        ' sno
        ' 
        sno.HeaderText = "S.No"
        sno.Name = "sno"
        sno.ReadOnly = True
        sno.Width = 58
        ' 
        ' GenericName
        ' 
        GenericName.HeaderText = "Name"
        GenericName.Name = "GenericName"
        GenericName.ReadOnly = True
        GenericName.Width = 62
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
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnClear.Location = New Point(425, 40)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(75, 23)
        BtnClear.TabIndex = 23
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSave.Location = New Point(344, 39)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 22
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' ChbActivate
        ' 
        ChbActivate.AutoSize = True
        ChbActivate.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ChbActivate.Location = New Point(452, 15)
        ChbActivate.Name = "ChbActivate"
        ChbActivate.Size = New Size(62, 19)
        ChbActivate.TabIndex = 21
        ChbActivate.Text = "Active"
        ChbActivate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(14, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 20
        Label1.Text = "Raw Material Name"
        ' 
        ' TxbItemName
        ' 
        TxbItemName.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbItemName.Location = New Point(158, 12)
        TxbItemName.Name = "TxbItemName"
        TxbItemName.Size = New Size(288, 22)
        TxbItemName.TabIndex = 19
        ' 
        ' TxbItemStrength
        ' 
        TxbItemStrength.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbItemStrength.Location = New Point(158, 40)
        TxbItemStrength.Name = "TxbItemStrength"
        TxbItemStrength.Size = New Size(122, 22)
        TxbItemStrength.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(14, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 26
        Label4.Text = "ITem Strength"
        ' 
        ' TxbPactQty
        ' 
        TxbPactQty.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbPactQty.Location = New Point(344, 68)
        TxbPactQty.Name = "TxbPactQty"
        TxbPactQty.Size = New Size(156, 22)
        TxbPactQty.TabIndex = 31
        ' 
        ' T
        ' 
        T.AutoSize = True
        T.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        T.Location = New Point(286, 71)
        T.Name = "T"
        T.Size = New Size(55, 15)
        T.TabIndex = 30
        T.Text = "Pack Qty"
        ' 
        ' TxbIndQty
        ' 
        TxbIndQty.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbIndQty.Location = New Point(158, 68)
        TxbIndQty.Name = "TxbIndQty"
        TxbIndQty.Size = New Size(122, 22)
        TxbIndQty.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(34, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 28
        Label3.Text = "Individual Qty"
        ' 
        ' FrmGenericMaster
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(538, 308)
        Controls.Add(TxbPactQty)
        Controls.Add(T)
        Controls.Add(TxbIndQty)
        Controls.Add(Label3)
        Controls.Add(TxbItemStrength)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(DgvSaveList)
        Controls.Add(BtnClear)
        Controls.Add(BtnSave)
        Controls.Add(ChbActivate)
        Controls.Add(Label1)
        Controls.Add(TxbItemName)
        Name = "FrmGenericMaster"
        Text = "FrmGenericMaster"
        CType(DgvSaveList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents DgvSaveList As DataGridView
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents ChbActivate As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbItemName As TextBox
    Friend WithEvents sno As DataGridViewTextBoxColumn
    Friend WithEvents GenericName As DataGridViewTextBoxColumn
    Friend WithEvents Strength As DataGridViewTextBoxColumn
    Friend WithEvents Active As DataGridViewTextBoxColumn
    Friend WithEvents Addedby As DataGridViewTextBoxColumn
    Friend WithEvents AddedOn As DataGridViewTextBoxColumn
    Friend WithEvents TxbItemStrength As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbPactQty As TextBox
    Friend WithEvents T As Label
    Friend WithEvents TxbIndQty As TextBox
    Friend WithEvents Label3 As Label
End Class

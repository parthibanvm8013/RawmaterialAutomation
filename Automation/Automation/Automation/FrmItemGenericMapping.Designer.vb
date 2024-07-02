<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmItemGenericMapping
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        CmbItemCategory = New ComboBox()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        DgvSaveList = New DataGridView()
        sno = New DataGridViewTextBoxColumn()
        GenericName = New DataGridViewTextBoxColumn()
        Strength = New DataGridViewTextBoxColumn()
        Active = New DataGridViewTextBoxColumn()
        Addedby = New DataGridViewTextBoxColumn()
        AddedOn = New DataGridViewTextBoxColumn()
        BtnClear = New Button()
        BtnSave = New Button()
        CType(DgvSaveList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CmbItemCategory
        ' 
        CmbItemCategory.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CmbItemCategory.FormattingEnabled = True
        CmbItemCategory.Location = New Point(127, 68)
        CmbItemCategory.Name = "CmbItemCategory"
        CmbItemCategory.Size = New Size(453, 23)
        CmbItemCategory.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(17, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 15)
        Label2.TabIndex = 4
        Label2.Text = "Select the Category"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(239, 97)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(84, 19)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "Percentage"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(329, 97)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(70, 19)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Strength"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.Simple
        ComboBox1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(17, 123)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(563, 143)
        ComboBox1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(17, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 15)
        Label1.TabIndex = 9
        Label1.Text = "Select The Generic ITems"
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
        DgvSaveList.Location = New Point(17, 260)
        DgvSaveList.Name = "DgvSaveList"
        DgvSaveList.RowTemplate.Height = 25
        DgvSaveList.Size = New Size(563, 318)
        DgvSaveList.TabIndex = 25
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
        BtnClear.Location = New Point(505, 95)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(75, 23)
        BtnClear.TabIndex = 27
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSave.Location = New Point(424, 95)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 26
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' FrmItemGenericMapping
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(588, 579)
        Controls.Add(BtnClear)
        Controls.Add(BtnSave)
        Controls.Add(DgvSaveList)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(CmbItemCategory)
        Controls.Add(Label2)
        Name = "FrmItemGenericMapping"
        Text = "Generic Master Mapping"
        CType(DgvSaveList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmbItemCategory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvSaveList As DataGridView
    Friend WithEvents sno As DataGridViewTextBoxColumn
    Friend WithEvents GenericName As DataGridViewTextBoxColumn
    Friend WithEvents Strength As DataGridViewTextBoxColumn
    Friend WithEvents Active As DataGridViewTextBoxColumn
    Friend WithEvents Addedby As DataGridViewTextBoxColumn
    Friend WithEvents AddedOn As DataGridViewTextBoxColumn
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSave As Button
End Class

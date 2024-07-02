<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockupdate
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
        CmbItemCategory = New ComboBox()
        Label2 = New Label()
        TxbNewStock = New TextBox()
        T = New Label()
        TxboldStock = New TextBox()
        Label3 = New Label()
        LblAdjStock = New Label()
        BtnClear = New Button()
        BtnSave = New Button()
        SuspendLayout()
        ' 
        ' CmbItemCategory
        ' 
        CmbItemCategory.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CmbItemCategory.FormattingEnabled = True
        CmbItemCategory.Location = New Point(116, 21)
        CmbItemCategory.Name = "CmbItemCategory"
        CmbItemCategory.Size = New Size(453, 23)
        CmbItemCategory.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 15)
        Label2.TabIndex = 6
        Label2.Text = "Select the Item"
        ' 
        ' TxbNewStock
        ' 
        TxbNewStock.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxbNewStock.Location = New Point(314, 50)
        TxbNewStock.Name = "TxbNewStock"
        TxbNewStock.Size = New Size(122, 22)
        TxbNewStock.TabIndex = 11
        ' 
        ' T
        ' 
        T.AutoSize = True
        T.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        T.Location = New Point(244, 53)
        T.Name = "T"
        T.Size = New Size(64, 15)
        T.TabIndex = 10
        T.Text = "New Stock"
        ' 
        ' TxboldStock
        ' 
        TxboldStock.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TxboldStock.Location = New Point(116, 50)
        TxboldStock.Name = "TxboldStock"
        TxboldStock.Size = New Size(122, 22)
        TxboldStock.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(7, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 8
        Label3.Text = "Old Qty"
        ' 
        ' LblAdjStock
        ' 
        LblAdjStock.AutoSize = True
        LblAdjStock.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LblAdjStock.Location = New Point(466, 57)
        LblAdjStock.Name = "LblAdjStock"
        LblAdjStock.Size = New Size(90, 15)
        LblAdjStock.TabIndex = 12
        LblAdjStock.Text = "Adjusted Stock"
        ' 
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnClear.Location = New Point(494, 86)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(75, 23)
        BtnClear.TabIndex = 25
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSave.Location = New Point(413, 86)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 24
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' FrmStockupdate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(581, 120)
        Controls.Add(BtnClear)
        Controls.Add(BtnSave)
        Controls.Add(LblAdjStock)
        Controls.Add(TxbNewStock)
        Controls.Add(T)
        Controls.Add(TxboldStock)
        Controls.Add(Label3)
        Controls.Add(CmbItemCategory)
        Controls.Add(Label2)
        Name = "FrmStockupdate"
        Text = "Stock Update"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmbItemCategory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbNewStock As TextBox
    Friend WithEvents T As Label
    Friend WithEvents TxboldStock As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblAdjStock As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSave As Button
End Class

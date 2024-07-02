Public Class MDI_Main
    Private Sub ItemGenericMappingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemGenericMappingToolStripMenuItem.Click
        FrmItemGenericMapping.Close()
        FrmItemGenericMapping.MdiParent = Me
        FrmItemGenericMapping.Show()
    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        FrmItem.Close()
        FrmItem.MdiParent = Me
        FrmItem.Show()

    End Sub

    Private Sub GenericToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenericToolStripMenuItem.Click
        FrmGenericMaster.Close()
        FrmGenericMaster.MdiParent = Me
        FrmGenericMaster.Show()

    End Sub

    Private Sub ItemCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemCategoryToolStripMenuItem.Click

    End Sub

    Private Sub GenericStockUpdationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenericStockUpdationToolStripMenuItem.Click
        FrmStockupdate.Close()
        FrmStockupdate.MdiParent = Me
        FrmStockupdate.Show()
    End Sub
End Class
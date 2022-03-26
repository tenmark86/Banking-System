Imports System

Public Class Form6

    Private Sub TbltransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbltransBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TbltransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransDataSet)

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransDataSet.tbltrans' table. You can move, or remove it, as needed.
        Me.TbltransTableAdapter.Fill(Me.TransDataSet.tbltrans)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub



    Private Sub TRANSACTION_IDToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub NAMEToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Friend Shared Sub Show()
        Throw New NotImplementedException()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TYPELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
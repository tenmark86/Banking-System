Imports System

Public Class Form3

    Private Sub ItemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CUSDataSet)

    End Sub

    Friend Shared Function Show() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NewMethod()
    End Sub

    Private Sub NewMethod()
        'TODO: This line of code loads data into the 'CUSDataSet.items' table. You can move, or remove it, as needed.
        Using form3 As Form3 = Me
            Dim p = form3.ItemsTableAdapter.Fill(form3.CUSDataSet.items)
        End Using
    End Sub

    Private Sub CodeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub LAST_NAMETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAST_NAMETextBox.TextChanged

    End Sub

    Private Sub LAST_NAMELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GENDERLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FIRST_NAMELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ItemsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsBindingNavigator.RefreshItems

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FIRST_NAMETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FIRST_NAMETextBox.TextChanged

    End Sub
End Class
Imports System

Public Class Form5

    Private Sub TblwithdrawalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblwithdrawalBindingNavigatorSaveItem.Click
        Dim p = Me.Validate()
        Dim p1 = TblwithdrawalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Withdrawal_DataSet)

    End Sub

    Private Function Validate() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Withdrawal_DataSet.tblwithdrawal' table. You can move, or remove it, as needed.
        Me.TblwithdrawalTableAdapter.Fill(Me.Withdrawal_DataSet.tblwithdrawal)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p = Me.Close()
        Form4.Show()
    End Sub

    Private Function Close() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Hide()
        Throw New NotImplementedException()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
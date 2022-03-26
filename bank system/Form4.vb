Imports System

Public Class Form4
    Public Sub New()
    End Sub

    Private Sub TblacctsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblacctsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblacctsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AcctsDataSet)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AcctsDataSet1.tblaccts' table. You can move, or remove it, as needed.
        Me.TblacctsTableAdapter1.Fill(Me.AcctsDataSet1.tblaccts)
        'TODO: This line of code loads data into the 'AcctsDataSet.tblaccts' table. You can move, or remove it, as needed.
        Me.TblacctsTableAdapter.Fill(Me.AcctsDataSet.tblaccts)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form3.Show()
    End Sub

    Friend Shared Sub Show()
        Throw New NotImplementedException()
    End Sub

    Private Sub DESCRIPTIONLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class
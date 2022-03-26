Imports System

Public Class frmLOGIN

    Private Sub btnLOGIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLOGIN.Click
        If TextBox1.Text = "mark" And
            TextBox2.Text = "mark" Then
            Dim p = Form3.Show()

        Else
            Dim MsgBoxStyle As Object = Nothing
            MsgBox(
                "sorry, the username or password is incorrect!!!!", retryCancel:=MsgBoxStyle.RetryCancel)
        End If
    End Sub

    Private Sub MsgBox(v As String, retryCancel As Object)
        Throw New NotImplementedException()
    End Sub

    Private Sub txtUSERNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPASSWORD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True

    End Sub

    Private Sub frmLOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
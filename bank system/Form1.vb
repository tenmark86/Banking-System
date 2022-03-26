Imports System

Public Class frmsplash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar2.Value = ProgressBar2.Value + 1
#Disable Warning BC42019 ' Operands of type Object used for operator
        Label4.Text = CStr(ProgressBar2.Value & "%" & "completed")
#Enable Warning BC42019 ' Operands of type Object used for operator
#Disable Warning BC42019 ' Operands of type Object used for operator
        If ProgressBar2.Value < 100 Then
#Enable Warning BC42019 ' Operands of type Object used for operator
            Return
        End If
        Timer1.Enabled = False
        If TextBox1.Text = "admin" And
            TextBox2.Text = "admin" Then
            MsgBox(
                "welcome", MsgBoxStyle.Information, "security check")
            ProgressBar2.Value = 0
            frmLOGIN.Show()
        Else
            MsgBox("invalid username or password", MsgBoxStyle.Information, "security check")
            Label4.Text = ""
            ProgressBar2.Value = 0
            TextBox1.Focus()
        End If
    End Sub

    Private Sub MsgBox(v1 As String, information As Object, v2 As String)
        Throw New NotImplementedException()
    End Sub

    Private Sub frmsplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 100

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ProgressBar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class


Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Partial Class frmsplash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
#Disable Warning BC42020 ' Variable declaration without an 'As' clause
            Dim p = MyBase.Dispose(disposing)
#Enable Warning BC42020 ' Variable declaration without an 'As' clause
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsplash))
        Dim progressBar11 As Forms.ProgressBar = Me.ProgressBar1
        progressBar11 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        progressBar11.Location = New System.Drawing.Point(80, 853)
        Dim padding As Forms.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Dim padding1 As Forms.Padding = padding
        NewMethod1(progressBar11, padding1)
        progressBar11.Name = "ProgressBar1"
        progressBar11.Size = New System.Drawing.Size(
            1824,
            48)
        progressBar11.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(151, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(628, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LIONS SAVINGS AND CREDITS SACCO (MWIKI)"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(12, 616)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(673, 23)
        Me.ProgressBar2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(771, 585)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 27)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(771, 594)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 27)
        Me.Label3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(750, 612)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(115, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "USERNAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(115, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 27)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "PASSWORD"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(330, 172)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 35)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(330, 286)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(281, 35)
        Me.TextBox2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(330, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "ENTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(527, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 42)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmsplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 651)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
#Disable Warning BC42017 ' Late bound resolution
        Me.Controls.Add(Me.ProgressBar2)
#Enable Warning BC42017 ' Late bound resolution
        Me.Controls.Add(progressBar11)
        Dim v = Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tempus Sans ITC",
                                          15.75!,
                                          System.Drawing.FontStyle.Bold,
                                          System.Drawing.GraphicsUnit.Point,
                                          CType(0, Byte))
        Me.Margin = padding1
        Me.Name = "frmsplash"
        NewMethod()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Shared Sub NewMethod1(progressBar11 As Forms.ProgressBar, padding1 As Forms.Padding)
        progressBar11.Margin = padding1
    End Sub

    Private Function AutoScaleDimensions() As Object
        Throw New System.NotImplementedException()
    End Function

    Private Function Controls() As Object
        Throw New System.NotImplementedException()
    End Function

    Private Function Font() As Object
        Throw New System.NotImplementedException()
    End Function

    Private Function Margin() As Forms.Padding
        Throw New System.NotImplementedException()
    End Function

    Private Sub NewMethod()
        Me.Text = "t"
    End Sub

    Private Function Text() As String
        Throw New System.NotImplementedException()
    End Function

    Private Sub ResumeLayout(v As Boolean)
        Throw New System.NotImplementedException()
    End Sub

    Private Sub PerformLayout()
        Throw New System.NotImplementedException()
    End Sub

    Private Sub SuspendLayout()
        Throw New System.NotImplementedException()
    End Sub

    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private Name As String

    Private Function GetDebuggerDisplay() As String
        Return Me.ToString()
    End Function
End Class

Namespace System.Windows
    Class Forms
        Public Class Form
            Public Event Load(sender As Object, e As EventArgs)

            Friend Function Dispose(disposing As Boolean) As Object
                Throw New NotImplementedException()
            End Function
        End Class

        Friend Class Label
            Public Sub New()
            End Sub

            Public Property BackColor As Object
            Public Property Font As Object
            Public Property ForeColor As Object
            Public Property Location As Object
            Public Property Margin As Padding
            Public Property Name As String
            Public Property Size As Object
            Public Property TabIndex As Integer
            Public Property Text As String

            Friend Function AutoSize() As Boolean
                Throw New NotImplementedException()
            End Function
        End Class

        Friend Class ProgressBar
            Friend Location As Object
            Friend Size As Size

            Public Sub New()
            End Sub

            Public Property TabIndex As Integer

            Friend Function Name() As String
                Throw New NotImplementedException()
            End Function

            Friend Function Margin() As Padding
                Throw New NotImplementedException()
            End Function

            Friend Function Value() As Object
                Throw New NotImplementedException()
            End Function
        End Class

        Friend Class Timer
            Private components As IContainer

            Public Sub New(components As IContainer)
                Me.components = components
            End Sub

            Public Property Interval As Integer
            Public Event Tick(sender As Object, e As EventArgs)

            Friend Function Enabled() As Boolean
                Throw New NotImplementedException()
            End Function
        End Class

        Friend Class TextBox
            Friend UseSystemPasswordChar As Boolean

            Public Sub New()
            End Sub

            Public Property Location As Object
            Public Property Name As String
            Public Property Size As Object
            Public Property TabIndex As Integer
            Public Property PasswordChar As Char
            Public Property Text As String
        End Class

        Friend Class Button
            Friend BackColor As Object

            Public Sub New()
            End Sub

            Public Event Click(sender As Object, e As EventArgs)
        End Class

        Friend Class Padding
            Private v1 As Integer
            Private v2 As Integer
            Private v3 As Integer
            Private v4 As Integer

            Public Sub New(v1 As Integer, v2 As Integer, v3 As Integer, v4 As Integer)
                Me.v1 = v1
                Me.v2 = v2
                Me.v3 = v3
                Me.v4 = v4
            End Sub
        End Class

        Friend Class ToolStripButton
            Public Event Click(sender As Object, e As EventArgs)
        End Class

        Friend Class BindingNavigator
            Private components As IContainer

            Public Sub New(components As IContainer)
                Me.components = components
            End Sub

            Friend Sub SuspendLayout()
                Throw New NotImplementedException()
            End Sub
        End Class

        Friend Class BindingSource
            Private components As IContainer

            Public Sub New(components As IContainer)
                Me.components = components
            End Sub

            Friend Function EndEdit() As Object
                Throw New NotImplementedException()
            End Function
        End Class

        Friend Class ToolStripLabel
            Public Sub New()
            End Sub
        End Class

        Friend Class ToolStripSeparator
            Public Sub New()
            End Sub
        End Class

        Friend Class ToolStripTextBox
            Public Sub New()
            End Sub
        End Class

        Friend Class DataGridViewTextBoxColumn
            Public Sub New()
            End Sub
        End Class

        Friend Class DataGridViewCellEventArgs
        End Class
    End Class
End Namespace

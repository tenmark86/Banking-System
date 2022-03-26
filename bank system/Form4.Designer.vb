Imports System.Windows

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim NAMELabel As System.Windows.Forms.Label
        Dim ACCOUNT_TYPELabel As System.Windows.Forms.Label
        Dim DESCRIPTIONLabel As System.Windows.Forms.Label
        Dim MINIMUM_BALANCELabel As System.Windows.Forms.Label
        Dim RATELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.TblacctsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblacctsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Dim form4 As Form4 = Me
        form4.AcctsDataSet1 = New bank_system.acctsDataSet1()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblacctsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NAMETextBox = New System.Windows.Forms.TextBox()
        Me.ACCOUNT_TYPETextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPTIONTextBox = New System.Windows.Forms.TextBox()
        Me.MINIMUM_BALANCETextBox = New System.Windows.Forms.TextBox()
        Me.RATETextBox = New System.Windows.Forms.TextBox()
        NewMethod()
        Me.TblacctsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblacctsTableAdapter = New bank_system.acctsDataSetTableAdapters.tblacctsTableAdapter()
        Me.TableAdapterManager = New bank_system.acctsDataSetTableAdapters.TableAdapterManager()
        Me.TblacctsTableAdapter1 = New bank_system.acctsDataSet1TableAdapters.tblacctsTableAdapter()
        Me.TableAdapterManager1 = New bank_system.acctsDataSet1TableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ACCOUNTTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MINIMUMBALANCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NAMELabel = New System.Windows.Forms.Label()
        ACCOUNT_TYPELabel = New System.Windows.Forms.Label()
        DESCRIPTIONLabel = New System.Windows.Forms.Label()
        MINIMUM_BALANCELabel = New System.Windows.Forms.Label()
        RATELabel = New System.Windows.Forms.Label()
        CType(Me.TblacctsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblacctsBindingNavigator.SuspendLayout()
        CType(Me.TblacctsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcctsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcctsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblacctsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.BackColor = System.Drawing.Color.Transparent
        NAMELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NAMELabel.ForeColor = System.Drawing.Color.Lime
        NAMELabel.Location = New System.Drawing.Point(33, 105)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(66, 20)
        NAMELabel.TabIndex = 11
        NAMELabel.Text = "NAME:"
        '
        'ACCOUNT_TYPELabel
        '
        ACCOUNT_TYPELabel.AutoSize = True
        ACCOUNT_TYPELabel = NewMethod1(ACCOUNT_TYPELabel)
        ACCOUNT_TYPELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ACCOUNT_TYPELabel.ForeColor = System.Drawing.Color.Lime
        ACCOUNT_TYPELabel.Location = New System.Drawing.Point(33, 148)
        ACCOUNT_TYPELabel.Name = "ACCOUNT_TYPELabel"
        ACCOUNT_TYPELabel.Size = New System.Drawing.Size(144, 20)
        ACCOUNT_TYPELabel.TabIndex = 12
        ACCOUNT_TYPELabel.Text = "ACCOUNT TYPE:"
        '
        'DESCRIPTIONLabel
        '
        DESCRIPTIONLabel.AutoSize = True
        DESCRIPTIONLabel.BackColor = System.Drawing.Color.Transparent
        DESCRIPTIONLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DESCRIPTIONLabel.ForeColor = System.Drawing.Color.Lime
        DESCRIPTIONLabel.Location = New System.Drawing.Point(33, 202)
        DESCRIPTIONLabel.Name = "DESCRIPTIONLabel"
        DESCRIPTIONLabel.Size = New System.Drawing.Size(125, 20)
        DESCRIPTIONLabel.TabIndex = 13
        DESCRIPTIONLabel.Text = "DESCRIPTION:"
        AddHandler DESCRIPTIONLabel.Click, AddressOf Me.DESCRIPTIONLabel_Click
        '
        'MINIMUM_BALANCELabel
        '
        MINIMUM_BALANCELabel.AutoSize = True
        MINIMUM_BALANCELabel.BackColor = System.Drawing.Color.Transparent
        MINIMUM_BALANCELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MINIMUM_BALANCELabel.ForeColor = System.Drawing.Color.Lime
        MINIMUM_BALANCELabel.Location = New System.Drawing.Point(33, 262)
        MINIMUM_BALANCELabel.Name = "MINIMUM_BALANCELabel"
        MINIMUM_BALANCELabel.Size = New System.Drawing.Size(183, 20)
        MINIMUM_BALANCELabel.TabIndex = 14
        MINIMUM_BALANCELabel.Text = "MINIMUM BALANCE:"
        '
        'RATELabel
        '
        RATELabel.AutoSize = True
        RATELabel.BackColor = System.Drawing.Color.Transparent
        RATELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RATELabel.ForeColor = System.Drawing.Color.Lime
        RATELabel.Location = New System.Drawing.Point(33, 322)
        RATELabel.Name = "RATELabel"
        RATELabel.Size = New System.Drawing.Size(58, 20)
        RATELabel.TabIndex = 15
        RATELabel.Text = "RATE:"
        '
        'TblacctsBindingNavigator
        '
        Me.TblacctsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblacctsBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.TblacctsBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TblacctsBindingNavigator.BindingSource = Me.TblacctsBindingSource1
        Me.TblacctsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblacctsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblacctsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblacctsBindingNavigatorSaveItem, Me.toolStripSeparator, Me.toolStripSeparator1})
        Me.TblacctsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblacctsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblacctsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblacctsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblacctsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblacctsBindingNavigator.Name = "TblacctsBindingNavigator"
        Me.TblacctsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblacctsBindingNavigator.Size = New System.Drawing.Size(1087, 25)
        Me.TblacctsBindingNavigator.TabIndex = 0
        Me.TblacctsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TblacctsBindingSource1
        '
        Me.TblacctsBindingSource1.DataMember = "tblaccts"
        Me.TblacctsBindingSource1.DataSource = Me.AcctsDataSet1
        '
        'AcctsDataSet1
        '
        Me.AcctsDataSet1.DataSetName = "acctsDataSet1"
        Me.AcctsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblacctsBindingNavigatorSaveItem
        '
        Me.TblacctsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblacctsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblacctsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblacctsBindingNavigatorSaveItem.Name = "TblacctsBindingNavigatorSaveItem"
        Me.TblacctsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblacctsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(576, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 73)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "PREVIOUS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(811, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 73)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "NEXT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NAMETextBox
        '
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblacctsBindingSource1, "NAME", True))
        Me.NAMETextBox.Location = New System.Drawing.Point(136, 106)
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.Size = New System.Drawing.Size(294, 22)
        Me.NAMETextBox.TabIndex = 12
        '
        'ACCOUNT_TYPETextBox
        '
        Me.ACCOUNT_TYPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblacctsBindingSource1, "ACCOUNT TYPE", True))
        Me.ACCOUNT_TYPETextBox.Location = New System.Drawing.Point(173, 148)
        Me.ACCOUNT_TYPETextBox.Name = "ACCOUNT_TYPETextBox"
        Me.ACCOUNT_TYPETextBox.Size = New System.Drawing.Size(294, 22)
        Me.ACCOUNT_TYPETextBox.TabIndex = 13
        '
        'DESCRIPTIONTextBox
        '
        Me.DESCRIPTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblacctsBindingSource1, "DESCRIPTION", True))
        Me.DESCRIPTIONTextBox.Location = New System.Drawing.Point(160, 202)
        Me.DESCRIPTIONTextBox.Name = "DESCRIPTIONTextBox"
        Me.DESCRIPTIONTextBox.Size = New System.Drawing.Size(294, 22)
        Me.DESCRIPTIONTextBox.TabIndex = 14
        '
        'MINIMUM_BALANCETextBox
        '
        Me.MINIMUM_BALANCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblacctsBindingSource1, "MINIMUM BALANCE", True))
        Me.MINIMUM_BALANCETextBox.Location = New System.Drawing.Point(222, 260)
        Me.MINIMUM_BALANCETextBox.Name = "MINIMUM_BALANCETextBox"
        Me.MINIMUM_BALANCETextBox.Size = New System.Drawing.Size(261, 22)
        Me.MINIMUM_BALANCETextBox.TabIndex = 15
        '
        'RATETextBox
        '
        Me.RATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblacctsBindingSource1, "RATE", True))
        Me.RATETextBox.Location = New System.Drawing.Point(148, 318)
        Me.RATETextBox.Name = "RATETextBox"
        Me.RATETextBox.Size = New System.Drawing.Size(306, 22)
        Me.RATETextBox.TabIndex = 16
        '
        'AcctsDataSet
        '
        Me.AcctsDataSet.DataSetName = "acctsDataSet"
        Me.AcctsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblacctsBindingSource
        '
        Me.TblacctsBindingSource.DataMember = "tblaccts"
        Me.TblacctsBindingSource.DataSource = Me.AcctsDataSet
        '
        'TblacctsTableAdapter
        '
        Me.TblacctsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblacctsTableAdapter = Me.TblacctsTableAdapter
        Me.TableAdapterManager.UpdateOrder = bank_system.acctsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblacctsTableAdapter1
        '
        Me.TblacctsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tblacctsTableAdapter = Me.TblacctsTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = bank_system.acctsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ACCOUNTTYPEDataGridViewTextBoxColumn, Me.DESCRIPTIONDataGridViewTextBoxColumn, Me.MINIMUMBALANCEDataGridViewTextBoxColumn, Me.RATEDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblacctsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(512, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 150)
        Me.DataGridView1.TabIndex = 17
        '
        'ACCOUNTTYPEDataGridViewTextBoxColumn
        '
        Me.ACCOUNTTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT TYPE"
        Me.ACCOUNTTYPEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT TYPE"
        Me.ACCOUNTTYPEDataGridViewTextBoxColumn.Name = "ACCOUNTTYPEDataGridViewTextBoxColumn"
        '
        'DESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.Name = "DESCRIPTIONDataGridViewTextBoxColumn"
        '
        'MINIMUMBALANCEDataGridViewTextBoxColumn
        '
        Me.MINIMUMBALANCEDataGridViewTextBoxColumn.DataPropertyName = "MINIMUM BALANCE"
        Me.MINIMUMBALANCEDataGridViewTextBoxColumn.HeaderText = "MINIMUM BALANCE"
        Me.MINIMUMBALANCEDataGridViewTextBoxColumn.Name = "MINIMUMBALANCEDataGridViewTextBoxColumn"
        '
        'RATEDataGridViewTextBoxColumn
        '
        Me.RATEDataGridViewTextBoxColumn.DataPropertyName = "RATE"
        Me.RATEDataGridViewTextBoxColumn.HeaderText = "RATE"
        Me.RATEDataGridViewTextBoxColumn.Name = "RATEDataGridViewTextBoxColumn"
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1087, 554)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(RATELabel)
        Me.Controls.Add(Me.RATETextBox)
        Me.Controls.Add(MINIMUM_BALANCELabel)
        Me.Controls.Add(Me.MINIMUM_BALANCETextBox)
        Me.Controls.Add(DESCRIPTIONLabel)
        Me.Controls.Add(Me.DESCRIPTIONTextBox)
        Me.Controls.Add(ACCOUNT_TYPELabel)
        Me.Controls.Add(Me.ACCOUNT_TYPETextBox)
        Me.Controls.Add(NAMELabel)
        Me.Controls.Add(Me.NAMETextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TblacctsBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form4"
        Me.Text = "ACCOUNTS"
        CType(Me.TblacctsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblacctsBindingNavigator.ResumeLayout(False)
        Me.TblacctsBindingNavigator.PerformLayout()
        CType(Me.TblacctsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcctsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcctsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblacctsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Shared Function NewMethod1(ACCOUNT_TYPELabel As Forms.Label) As Forms.Label
        ACCOUNT_TYPELabel.BackColor = System.Drawing.Color.Transparent
        Return ACCOUNT_TYPELabel
    End Function

    Private Sub SuspendLayout()
        Throw New System.NotImplementedException()
    End Sub

    Private Sub NewMethod()
        Me.AcctsDataSet = New bank_system.acctsDataSet()
    End Sub

    Friend WithEvents AcctsDataSet As bank_system.acctsDataSet
    Friend WithEvents TblacctsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblacctsTableAdapter As bank_system.acctsDataSetTableAdapters.tblacctsTableAdapter
    Friend WithEvents TableAdapterManager As bank_system.acctsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblacctsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblacctsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcctsDataSet1 As bank_system.acctsDataSet1
    Friend WithEvents TblacctsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblacctsTableAdapter1 As bank_system.acctsDataSet1TableAdapters.tblacctsTableAdapter
    Friend WithEvents TableAdapterManager1 As bank_system.acctsDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACCOUNT_TYPETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPTIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MINIMUM_BALANCETextBox As System.Windows.Forms.TextBox
    Friend WithEvents RATETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ACCOUNTTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MINIMUMBALANCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

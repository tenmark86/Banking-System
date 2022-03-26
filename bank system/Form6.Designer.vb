<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Dim NAMELabel As System.Windows.Forms.Label
        Dim TRANSACTION_IDLabel As System.Windows.Forms.Label
        Dim DATELabel As System.Windows.Forms.Label
        Dim TYPELabel As System.Windows.Forms.Label
        Dim MODELabel As System.Windows.Forms.Label
        Dim FROM_ACCOUNT_NOLabel As System.Windows.Forms.Label
        Dim TO_ACCOUNT_NOLabel As System.Windows.Forms.Label
        Dim CHECK_NUMBERLabel As System.Windows.Forms.Label
        Dim AMOUNTLabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.TbltransBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TbltransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransDataSet = New bank_system.transDataSet()
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
        Me.TbltransBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NAMETextBox = New System.Windows.Forms.TextBox()
        Me.TRANSACTION_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TYPETextBox = New System.Windows.Forms.TextBox()
        Me.MODETextBox = New System.Windows.Forms.TextBox()
        Me.FROM_ACCOUNT_NOTextBox = New System.Windows.Forms.TextBox()
        Me.TO_ACCOUNT_NOTextBox = New System.Windows.Forms.TextBox()
        Me.CHECK_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.AMOUNTTextBox = New System.Windows.Forms.TextBox()
        Me.STATUSTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSACTIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FROMACCOUNTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOACCOUNTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TbltransTableAdapter = New bank_system.transDataSetTableAdapters.tbltransTableAdapter()
        Me.TableAdapterManager = New bank_system.transDataSetTableAdapters.TableAdapterManager()
        NAMELabel = New System.Windows.Forms.Label()
        TRANSACTION_IDLabel = New System.Windows.Forms.Label()
        DATELabel = New System.Windows.Forms.Label()
        TYPELabel = New System.Windows.Forms.Label()
        MODELabel = New System.Windows.Forms.Label()
        FROM_ACCOUNT_NOLabel = New System.Windows.Forms.Label()
        TO_ACCOUNT_NOLabel = New System.Windows.Forms.Label()
        CHECK_NUMBERLabel = New System.Windows.Forms.Label()
        AMOUNTLabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        CType(Me.TbltransBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbltransBindingNavigator.SuspendLayout()
        CType(Me.TbltransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.BackColor = System.Drawing.Color.Transparent
        NAMELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NAMELabel.ForeColor = System.Drawing.Color.Lime
        NAMELabel.Location = New System.Drawing.Point(40, 51)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(66, 20)
        NAMELabel.TabIndex = 1
        NAMELabel.Text = "NAME:"
        '
        'TRANSACTION_IDLabel
        '
        TRANSACTION_IDLabel.AutoSize = True
        TRANSACTION_IDLabel.BackColor = System.Drawing.Color.Transparent
        TRANSACTION_IDLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TRANSACTION_IDLabel.ForeColor = System.Drawing.Color.Lime
        TRANSACTION_IDLabel.Location = New System.Drawing.Point(20, 97)
        TRANSACTION_IDLabel.Name = "TRANSACTION_IDLabel"
        TRANSACTION_IDLabel.Size = New System.Drawing.Size(160, 20)
        TRANSACTION_IDLabel.TabIndex = 3
        TRANSACTION_IDLabel.Text = "TRANSACTION ID:"
        '
        'DATELabel
        '
        DATELabel.AutoSize = True
        DATELabel.BackColor = System.Drawing.Color.Transparent
        DATELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATELabel.ForeColor = System.Drawing.Color.Lime
        DATELabel.Location = New System.Drawing.Point(40, 144)
        DATELabel.Name = "DATELabel"
        DATELabel.Size = New System.Drawing.Size(59, 20)
        DATELabel.TabIndex = 5
        DATELabel.Text = "DATE:"
        '
        'TYPELabel
        '
        TYPELabel.AutoSize = True
        TYPELabel.BackColor = System.Drawing.Color.Transparent
        TYPELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TYPELabel.ForeColor = System.Drawing.Color.Lime
        TYPELabel.Location = New System.Drawing.Point(40, 200)
        TYPELabel.Name = "TYPELabel"
        TYPELabel.Size = New System.Drawing.Size(54, 20)
        TYPELabel.TabIndex = 7
        TYPELabel.Text = "TYPE:"
        AddHandler TYPELabel.Click, AddressOf Me.TYPELabel_Click
        '
        'MODELabel
        '
        MODELabel.AutoSize = True
        MODELabel.BackColor = System.Drawing.Color.Transparent
        MODELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MODELabel.ForeColor = System.Drawing.Color.Lime
        MODELabel.Location = New System.Drawing.Point(40, 247)
        MODELabel.Name = "MODELabel"
        MODELabel.Size = New System.Drawing.Size(64, 20)
        MODELabel.TabIndex = 9
        MODELabel.Text = "MODE:"
        '
        'FROM_ACCOUNT_NOLabel
        '
        FROM_ACCOUNT_NOLabel.AutoSize = True
        FROM_ACCOUNT_NOLabel.BackColor = System.Drawing.Color.Transparent
        FROM_ACCOUNT_NOLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FROM_ACCOUNT_NOLabel.ForeColor = System.Drawing.Color.Lime
        FROM_ACCOUNT_NOLabel.Location = New System.Drawing.Point(3, 280)
        FROM_ACCOUNT_NOLabel.Name = "FROM_ACCOUNT_NOLabel"
        FROM_ACCOUNT_NOLabel.Size = New System.Drawing.Size(184, 20)
        FROM_ACCOUNT_NOLabel.TabIndex = 11
        FROM_ACCOUNT_NOLabel.Text = "FROM ACCOUNT NO:"
        '
        'TO_ACCOUNT_NOLabel
        '
        TO_ACCOUNT_NOLabel.AutoSize = True
        TO_ACCOUNT_NOLabel.BackColor = System.Drawing.Color.Transparent
        TO_ACCOUNT_NOLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TO_ACCOUNT_NOLabel.ForeColor = System.Drawing.Color.Lime
        TO_ACCOUNT_NOLabel.Location = New System.Drawing.Point(22, 331)
        TO_ACCOUNT_NOLabel.Name = "TO_ACCOUNT_NOLabel"
        TO_ACCOUNT_NOLabel.Size = New System.Drawing.Size(159, 20)
        TO_ACCOUNT_NOLabel.TabIndex = 13
        TO_ACCOUNT_NOLabel.Text = "TO ACCOUNT NO:"
        '
        'CHECK_NUMBERLabel
        '
        CHECK_NUMBERLabel.AutoSize = True
        CHECK_NUMBERLabel.BackColor = System.Drawing.Color.Transparent
        CHECK_NUMBERLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CHECK_NUMBERLabel.ForeColor = System.Drawing.Color.Lime
        CHECK_NUMBERLabel.Location = New System.Drawing.Point(26, 383)
        CHECK_NUMBERLabel.Name = "CHECK_NUMBERLabel"
        CHECK_NUMBERLabel.Size = New System.Drawing.Size(149, 20)
        CHECK_NUMBERLabel.TabIndex = 15
        CHECK_NUMBERLabel.Text = "CHECK NUMBER:"
        '
        'AMOUNTLabel
        '
        AMOUNTLabel.AutoSize = True
        AMOUNTLabel.BackColor = System.Drawing.Color.Transparent
        AMOUNTLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AMOUNTLabel.ForeColor = System.Drawing.Color.Lime
        AMOUNTLabel.Location = New System.Drawing.Point(71, 429)
        AMOUNTLabel.Name = "AMOUNTLabel"
        AMOUNTLabel.Size = New System.Drawing.Size(92, 20)
        AMOUNTLabel.TabIndex = 17
        AMOUNTLabel.Text = "AMOUNT:"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.BackColor = System.Drawing.Color.Transparent
        STATUSLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STATUSLabel.ForeColor = System.Drawing.Color.Lime
        STATUSLabel.Location = New System.Drawing.Point(76, 474)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(76, 20)
        STATUSLabel.TabIndex = 19
        STATUSLabel.Text = "STATUS:"
        '
        'TbltransBindingNavigator
        '
        Me.TbltransBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TbltransBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.TbltransBindingNavigator.BindingSource = Me.TbltransBindingSource
        Me.TbltransBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TbltransBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TbltransBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbltransBindingNavigatorSaveItem})
        Me.TbltransBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TbltransBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TbltransBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TbltransBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TbltransBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TbltransBindingNavigator.Name = "TbltransBindingNavigator"
        Me.TbltransBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TbltransBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TbltransBindingNavigator.Size = New System.Drawing.Size(1017, 25)
        Me.TbltransBindingNavigator.TabIndex = 0
        Me.TbltransBindingNavigator.Text = "BindingNavigator1"
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
        'TbltransBindingSource
        '
        Me.TbltransBindingSource.DataMember = "tbltrans"
        Me.TbltransBindingSource.DataSource = Me.TransDataSet
        '
        'TransDataSet
        '
        Me.TransDataSet.DataSetName = "transDataSet"
        Me.TransDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
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
        'TbltransBindingNavigatorSaveItem
        '
        Me.TbltransBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbltransBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbltransBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TbltransBindingNavigatorSaveItem.Name = "TbltransBindingNavigatorSaveItem"
        Me.TbltransBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TbltransBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NAMETextBox
        '
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "NAME", True))
        Me.NAMETextBox.Location = New System.Drawing.Point(186, 49)
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.Size = New System.Drawing.Size(215, 22)
        Me.NAMETextBox.TabIndex = 2
        '
        'TRANSACTION_IDTextBox
        '
        Me.TRANSACTION_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "TRANSACTION ID", True))
        Me.TRANSACTION_IDTextBox.Location = New System.Drawing.Point(186, 95)
        Me.TRANSACTION_IDTextBox.Name = "TRANSACTION_IDTextBox"
        Me.TRANSACTION_IDTextBox.Size = New System.Drawing.Size(116, 22)
        Me.TRANSACTION_IDTextBox.TabIndex = 4
        '
        'DATEDateTimePicker
        '
        Me.DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbltransBindingSource, "DATE", True))
        Me.DATEDateTimePicker.Location = New System.Drawing.Point(186, 142)
        Me.DATEDateTimePicker.Name = "DATEDateTimePicker"
        Me.DATEDateTimePicker.Size = New System.Drawing.Size(233, 22)
        Me.DATEDateTimePicker.TabIndex = 6
        '
        'TYPETextBox
        '
        Me.TYPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "TYPE", True))
        Me.TYPETextBox.Location = New System.Drawing.Point(186, 198)
        Me.TYPETextBox.Name = "TYPETextBox"
        Me.TYPETextBox.Size = New System.Drawing.Size(233, 22)
        Me.TYPETextBox.TabIndex = 8
        '
        'MODETextBox
        '
        Me.MODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "MODE", True))
        Me.MODETextBox.Location = New System.Drawing.Point(186, 245)
        Me.MODETextBox.Name = "MODETextBox"
        Me.MODETextBox.Size = New System.Drawing.Size(116, 22)
        Me.MODETextBox.TabIndex = 10
        '
        'FROM_ACCOUNT_NOTextBox
        '
        Me.FROM_ACCOUNT_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "FROM ACCOUNT NO", True))
        Me.FROM_ACCOUNT_NOTextBox.Location = New System.Drawing.Point(186, 281)
        Me.FROM_ACCOUNT_NOTextBox.Name = "FROM_ACCOUNT_NOTextBox"
        Me.FROM_ACCOUNT_NOTextBox.Size = New System.Drawing.Size(116, 22)
        Me.FROM_ACCOUNT_NOTextBox.TabIndex = 12
        '
        'TO_ACCOUNT_NOTextBox
        '
        Me.TO_ACCOUNT_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "TO ACCOUNT NO", True))
        Me.TO_ACCOUNT_NOTextBox.Location = New System.Drawing.Point(187, 327)
        Me.TO_ACCOUNT_NOTextBox.Name = "TO_ACCOUNT_NOTextBox"
        Me.TO_ACCOUNT_NOTextBox.Size = New System.Drawing.Size(116, 22)
        Me.TO_ACCOUNT_NOTextBox.TabIndex = 14
        '
        'CHECK_NUMBERTextBox
        '
        Me.CHECK_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "CHECK NUMBER", True))
        Me.CHECK_NUMBERTextBox.Location = New System.Drawing.Point(197, 381)
        Me.CHECK_NUMBERTextBox.Name = "CHECK_NUMBERTextBox"
        Me.CHECK_NUMBERTextBox.Size = New System.Drawing.Size(116, 22)
        Me.CHECK_NUMBERTextBox.TabIndex = 16
        '
        'AMOUNTTextBox
        '
        Me.AMOUNTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "AMOUNT", True))
        Me.AMOUNTTextBox.Location = New System.Drawing.Point(187, 422)
        Me.AMOUNTTextBox.Name = "AMOUNTTextBox"
        Me.AMOUNTTextBox.Size = New System.Drawing.Size(116, 22)
        Me.AMOUNTTextBox.TabIndex = 18
        '
        'STATUSTextBox
        '
        Me.STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltransBindingSource, "STATUS", True))
        Me.STATUSTextBox.Location = New System.Drawing.Point(187, 471)
        Me.STATUSTextBox.Name = "STATUSTextBox"
        Me.STATUSTextBox.Size = New System.Drawing.Size(116, 22)
        Me.STATUSTextBox.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAMEDataGridViewTextBoxColumn, Me.TRANSACTIONIDDataGridViewTextBoxColumn, Me.DATEDataGridViewTextBoxColumn, Me.TYPEDataGridViewTextBoxColumn, Me.MODEDataGridViewTextBoxColumn, Me.FROMACCOUNTNODataGridViewTextBoxColumn, Me.TOACCOUNTNODataGridViewTextBoxColumn, Me.CHECKNUMBERDataGridViewTextBoxColumn, Me.AMOUNTDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbltransBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(503, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(491, 173)
        Me.DataGridView1.TabIndex = 21
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        '
        'TRANSACTIONIDDataGridViewTextBoxColumn
        '
        Me.TRANSACTIONIDDataGridViewTextBoxColumn.DataPropertyName = "TRANSACTION ID"
        Me.TRANSACTIONIDDataGridViewTextBoxColumn.HeaderText = "TRANSACTION ID"
        Me.TRANSACTIONIDDataGridViewTextBoxColumn.Name = "TRANSACTIONIDDataGridViewTextBoxColumn"
        '
        'DATEDataGridViewTextBoxColumn
        '
        Me.DATEDataGridViewTextBoxColumn.DataPropertyName = "DATE"
        Me.DATEDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.DATEDataGridViewTextBoxColumn.Name = "DATEDataGridViewTextBoxColumn"
        '
        'TYPEDataGridViewTextBoxColumn
        '
        Me.TYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn.HeaderText = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn.Name = "TYPEDataGridViewTextBoxColumn"
        '
        'MODEDataGridViewTextBoxColumn
        '
        Me.MODEDataGridViewTextBoxColumn.DataPropertyName = "MODE"
        Me.MODEDataGridViewTextBoxColumn.HeaderText = "MODE"
        Me.MODEDataGridViewTextBoxColumn.Name = "MODEDataGridViewTextBoxColumn"
        '
        'FROMACCOUNTNODataGridViewTextBoxColumn
        '
        Me.FROMACCOUNTNODataGridViewTextBoxColumn.DataPropertyName = "FROM ACCOUNT NO"
        Me.FROMACCOUNTNODataGridViewTextBoxColumn.HeaderText = "FROM ACCOUNT NO"
        Me.FROMACCOUNTNODataGridViewTextBoxColumn.Name = "FROMACCOUNTNODataGridViewTextBoxColumn"
        '
        'TOACCOUNTNODataGridViewTextBoxColumn
        '
        Me.TOACCOUNTNODataGridViewTextBoxColumn.DataPropertyName = "TO ACCOUNT NO"
        Me.TOACCOUNTNODataGridViewTextBoxColumn.HeaderText = "TO ACCOUNT NO"
        Me.TOACCOUNTNODataGridViewTextBoxColumn.Name = "TOACCOUNTNODataGridViewTextBoxColumn"
        '
        'CHECKNUMBERDataGridViewTextBoxColumn
        '
        Me.CHECKNUMBERDataGridViewTextBoxColumn.DataPropertyName = "CHECK NUMBER"
        Me.CHECKNUMBERDataGridViewTextBoxColumn.HeaderText = "CHECK NUMBER"
        Me.CHECKNUMBERDataGridViewTextBoxColumn.Name = "CHECKNUMBERDataGridViewTextBoxColumn"
        '
        'AMOUNTDataGridViewTextBoxColumn
        '
        Me.AMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.Name = "AMOUNTDataGridViewTextBoxColumn"
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(540, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 53)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "PREVIOUS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(733, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(499, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "NAME"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(595, 328)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 22)
        Me.TextBox1.TabIndex = 25
        '
        'TbltransTableAdapter
        '
        Me.TbltransTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbltransTableAdapter = Me.TbltransTableAdapter
        Me.TableAdapterManager.UpdateOrder = bank_system.transDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1017, 558)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(STATUSLabel)
        Me.Controls.Add(Me.STATUSTextBox)
        Me.Controls.Add(AMOUNTLabel)
        Me.Controls.Add(Me.AMOUNTTextBox)
        Me.Controls.Add(CHECK_NUMBERLabel)
        Me.Controls.Add(Me.CHECK_NUMBERTextBox)
        Me.Controls.Add(TO_ACCOUNT_NOLabel)
        Me.Controls.Add(Me.TO_ACCOUNT_NOTextBox)
        Me.Controls.Add(FROM_ACCOUNT_NOLabel)
        Me.Controls.Add(Me.FROM_ACCOUNT_NOTextBox)
        Me.Controls.Add(MODELabel)
        Me.Controls.Add(Me.MODETextBox)
        Me.Controls.Add(TYPELabel)
        Me.Controls.Add(Me.TYPETextBox)
        Me.Controls.Add(DATELabel)
        Me.Controls.Add(Me.DATEDateTimePicker)
        Me.Controls.Add(TRANSACTION_IDLabel)
        Me.Controls.Add(Me.TRANSACTION_IDTextBox)
        Me.Controls.Add(NAMELabel)
        Me.Controls.Add(Me.NAMETextBox)
        Me.Controls.Add(Me.TbltransBindingNavigator)
        Me.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form6"
        Me.Text = "TRANSACTION"
        CType(Me.TbltransBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbltransBindingNavigator.ResumeLayout(False)
        Me.TbltransBindingNavigator.PerformLayout()
        CType(Me.TbltransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransDataSet As bank_system.transDataSet
    Friend WithEvents TbltransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbltransTableAdapter As bank_system.transDataSetTableAdapters.tbltransTableAdapter
    Friend WithEvents TableAdapterManager As bank_system.transDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbltransBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TbltransBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRANSACTION_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TYPETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents FROM_ACCOUNT_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TO_ACCOUNT_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CHECK_NUMBERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STATUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRANSACTIONIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FROMACCOUNTNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOACCOUNTNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHECKNUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class

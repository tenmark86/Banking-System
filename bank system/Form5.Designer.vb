<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim CUSTOMER_IDLabel As System.Windows.Forms.Label
        Dim NAMELabel As System.Windows.Forms.Label
        Dim ACCOUNT_NOLabel As System.Windows.Forms.Label
        Dim DATELabel As System.Windows.Forms.Label
        Dim WITHDRAWAL_AMTLabel As System.Windows.Forms.Label
        Dim DEPOSITLabel As System.Windows.Forms.Label
        Dim BALANCELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.TblwithdrawalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblwithdrawalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Withdrawal_DataSet = New bank_system.withdrawal_DataSet()
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
        Me.TblwithdrawalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NAMETextBox = New System.Windows.Forms.TextBox()
        Me.ACCOUNT_NOTextBox = New System.Windows.Forms.TextBox()
        Me.DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WITHDRAWAL_AMTTextBox = New System.Windows.Forms.TextBox()
        Me.DEPOSITTextBox = New System.Windows.Forms.TextBox()
        Me.BALANCETextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CUSTOMERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCOUNTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WITHDRAWALAMTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPOSITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TblwithdrawalTableAdapter = New bank_system.withdrawal_DataSetTableAdapters.tblwithdrawalTableAdapter()
        Me.TableAdapterManager = New bank_system.withdrawal_DataSetTableAdapters.TableAdapterManager()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        NAMELabel = New System.Windows.Forms.Label()
        ACCOUNT_NOLabel = New System.Windows.Forms.Label()
        DATELabel = New System.Windows.Forms.Label()
        WITHDRAWAL_AMTLabel = New System.Windows.Forms.Label()
        DEPOSITLabel = New System.Windows.Forms.Label()
        BALANCELabel = New System.Windows.Forms.Label()
        CType(Me.TblwithdrawalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblwithdrawalBindingNavigator.SuspendLayout()
        CType(Me.TblwithdrawalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Withdrawal_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.BackColor = System.Drawing.Color.Transparent
        CUSTOMER_IDLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CUSTOMER_IDLabel.ForeColor = System.Drawing.Color.Lime
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(62, 59)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(128, 20)
        CUSTOMER_IDLabel.TabIndex = 1
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.BackColor = System.Drawing.Color.Transparent
        NAMELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NAMELabel.ForeColor = System.Drawing.Color.Lime
        NAMELabel.Location = New System.Drawing.Point(66, 106)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(66, 20)
        NAMELabel.TabIndex = 3
        NAMELabel.Text = "NAME:"
        '
        'ACCOUNT_NOLabel
        '
        ACCOUNT_NOLabel.AutoSize = True
        ACCOUNT_NOLabel.BackColor = System.Drawing.Color.Transparent
        ACCOUNT_NOLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ACCOUNT_NOLabel.ForeColor = System.Drawing.Color.Lime
        ACCOUNT_NOLabel.Location = New System.Drawing.Point(66, 157)
        ACCOUNT_NOLabel.Name = "ACCOUNT_NOLabel"
        ACCOUNT_NOLabel.Size = New System.Drawing.Size(131, 20)
        ACCOUNT_NOLabel.TabIndex = 5
        ACCOUNT_NOLabel.Text = "ACCOUNT NO:"
        '
        'DATELabel
        '
        DATELabel.AutoSize = True
        DATELabel.BackColor = System.Drawing.Color.Transparent
        DATELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATELabel.ForeColor = System.Drawing.Color.Lime
        DATELabel.Location = New System.Drawing.Point(66, 210)
        DATELabel.Name = "DATELabel"
        DATELabel.Size = New System.Drawing.Size(59, 20)
        DATELabel.TabIndex = 7
        DATELabel.Text = "DATE:"
        '
        'WITHDRAWAL_AMTLabel
        '
        WITHDRAWAL_AMTLabel.AutoSize = True
        WITHDRAWAL_AMTLabel.BackColor = System.Drawing.Color.Transparent
        WITHDRAWAL_AMTLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WITHDRAWAL_AMTLabel.ForeColor = System.Drawing.Color.Lime
        WITHDRAWAL_AMTLabel.Location = New System.Drawing.Point(62, 248)
        WITHDRAWAL_AMTLabel.Name = "WITHDRAWAL_AMTLabel"
        WITHDRAWAL_AMTLabel.Size = New System.Drawing.Size(178, 20)
        WITHDRAWAL_AMTLabel.TabIndex = 9
        WITHDRAWAL_AMTLabel.Text = "WITHDRAWAL AMT:"
        '
        'DEPOSITLabel
        '
        DEPOSITLabel.AutoSize = True
        DEPOSITLabel.BackColor = System.Drawing.Color.Transparent
        DEPOSITLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DEPOSITLabel.ForeColor = System.Drawing.Color.Lime
        DEPOSITLabel.Location = New System.Drawing.Point(62, 300)
        DEPOSITLabel.Name = "DEPOSITLabel"
        DEPOSITLabel.Size = New System.Drawing.Size(83, 20)
        DEPOSITLabel.TabIndex = 11
        DEPOSITLabel.Text = "DEPOSIT:"
        '
        'BALANCELabel
        '
        BALANCELabel.AutoSize = True
        BALANCELabel.BackColor = System.Drawing.Color.Transparent
        BALANCELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BALANCELabel.ForeColor = System.Drawing.Color.Lime
        BALANCELabel.Location = New System.Drawing.Point(62, 353)
        BALANCELabel.Name = "BALANCELabel"
        BALANCELabel.Size = New System.Drawing.Size(94, 20)
        BALANCELabel.TabIndex = 13
        BALANCELabel.Text = "BALANCE:"
        '
        'TblwithdrawalBindingNavigator
        '
        Me.TblwithdrawalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblwithdrawalBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.TblwithdrawalBindingNavigator.BindingSource = Me.TblwithdrawalBindingSource
        Me.TblwithdrawalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblwithdrawalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblwithdrawalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblwithdrawalBindingNavigatorSaveItem, Me.toolStripSeparator})
        Me.TblwithdrawalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblwithdrawalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblwithdrawalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblwithdrawalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblwithdrawalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblwithdrawalBindingNavigator.Name = "TblwithdrawalBindingNavigator"
        Me.TblwithdrawalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblwithdrawalBindingNavigator.Size = New System.Drawing.Size(1018, 25)
        Me.TblwithdrawalBindingNavigator.TabIndex = 0
        Me.TblwithdrawalBindingNavigator.Text = "BindingNavigator1"
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
        'TblwithdrawalBindingSource
        '
        Me.TblwithdrawalBindingSource.DataMember = "tblwithdrawal"
        Me.TblwithdrawalBindingSource.DataSource = Me.Withdrawal_DataSet
        '
        'Withdrawal_DataSet
        '
        Me.Withdrawal_DataSet.DataSetName = "withdrawal_DataSet"
        Me.Withdrawal_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TblwithdrawalBindingNavigatorSaveItem
        '
        Me.TblwithdrawalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblwithdrawalBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblwithdrawalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblwithdrawalBindingNavigatorSaveItem.Name = "TblwithdrawalBindingNavigatorSaveItem"
        Me.TblwithdrawalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblwithdrawalBindingNavigatorSaveItem.Text = "Save Data"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawalBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(252, 59)
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(227, 22)
        Me.CUSTOMER_IDTextBox.TabIndex = 2
        '
        'NAMETextBox
        '
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawalBindingSource, "NAME", True))
        Me.NAMETextBox.Location = New System.Drawing.Point(252, 106)
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.Size = New System.Drawing.Size(227, 22)
        Me.NAMETextBox.TabIndex = 4
        '
        'ACCOUNT_NOTextBox
        '
        Me.ACCOUNT_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawalBindingSource, "ACCOUNT NO", True))
        Me.ACCOUNT_NOTextBox.Location = New System.Drawing.Point(252, 150)
        Me.ACCOUNT_NOTextBox.Name = "ACCOUNT_NOTextBox"
        Me.ACCOUNT_NOTextBox.Size = New System.Drawing.Size(116, 22)
        Me.ACCOUNT_NOTextBox.TabIndex = 6
        '
        'DATEDateTimePicker
        '
        Me.DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblwithdrawalBindingSource, "DATE", True))
        Me.DATEDateTimePicker.Location = New System.Drawing.Point(252, 208)
        Me.DATEDateTimePicker.Name = "DATEDateTimePicker"
        Me.DATEDateTimePicker.Size = New System.Drawing.Size(233, 22)
        Me.DATEDateTimePicker.TabIndex = 8
        '
        'WITHDRAWAL_AMTTextBox
        '
        Me.WITHDRAWAL_AMTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawalBindingSource, "WITHDRAWAL AMT", True))
        Me.WITHDRAWAL_AMTTextBox.Location = New System.Drawing.Point(252, 248)
        Me.WITHDRAWAL_AMTTextBox.Name = "WITHDRAWAL_AMTTextBox"
        Me.WITHDRAWAL_AMTTextBox.Size = New System.Drawing.Size(116, 22)
        Me.WITHDRAWAL_AMTTextBox.TabIndex = 10
        '
        'DEPOSITTextBox
        '
        Me.DEPOSITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawalBindingSource, "DEPOSIT", True))
        Me.DEPOSITTextBox.Location = New System.Drawing.Point(252, 293)
        Me.DEPOSITTextBox.Name = "DEPOSITTextBox"
        Me.DEPOSITTextBox.Size = New System.Drawing.Size(116, 22)
        Me.DEPOSITTextBox.TabIndex = 12
        '
        'BALANCETextBox
        '
        Me.BALANCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawalBindingSource, "BALANCE", True))
        Me.BALANCETextBox.Location = New System.Drawing.Point(252, 351)
        Me.BALANCETextBox.Name = "BALANCETextBox"
        Me.BALANCETextBox.Size = New System.Drawing.Size(116, 22)
        Me.BALANCETextBox.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.ACCOUNTNODataGridViewTextBoxColumn, Me.DATEDataGridViewTextBoxColumn, Me.WITHDRAWALAMTDataGridViewTextBoxColumn, Me.DEPOSITDataGridViewTextBoxColumn, Me.BALANCEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblwithdrawalBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(505, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 173)
        Me.DataGridView1.TabIndex = 15
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        '
        'ACCOUNTNODataGridViewTextBoxColumn
        '
        Me.ACCOUNTNODataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT NO"
        Me.ACCOUNTNODataGridViewTextBoxColumn.HeaderText = "ACCOUNT NO"
        Me.ACCOUNTNODataGridViewTextBoxColumn.Name = "ACCOUNTNODataGridViewTextBoxColumn"
        '
        'DATEDataGridViewTextBoxColumn
        '
        Me.DATEDataGridViewTextBoxColumn.DataPropertyName = "DATE"
        Me.DATEDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.DATEDataGridViewTextBoxColumn.Name = "DATEDataGridViewTextBoxColumn"
        '
        'WITHDRAWALAMTDataGridViewTextBoxColumn
        '
        Me.WITHDRAWALAMTDataGridViewTextBoxColumn.DataPropertyName = "WITHDRAWAL AMT"
        Me.WITHDRAWALAMTDataGridViewTextBoxColumn.HeaderText = "WITHDRAWAL AMT"
        Me.WITHDRAWALAMTDataGridViewTextBoxColumn.Name = "WITHDRAWALAMTDataGridViewTextBoxColumn"
        '
        'DEPOSITDataGridViewTextBoxColumn
        '
        Me.DEPOSITDataGridViewTextBoxColumn.DataPropertyName = "DEPOSIT"
        Me.DEPOSITDataGridViewTextBoxColumn.HeaderText = "DEPOSIT"
        Me.DEPOSITDataGridViewTextBoxColumn.Name = "DEPOSITDataGridViewTextBoxColumn"
        '
        'BALANCEDataGridViewTextBoxColumn
        '
        Me.BALANCEDataGridViewTextBoxColumn.DataPropertyName = "BALANCE"
        Me.BALANCEDataGridViewTextBoxColumn.HeaderText = "BALANCE"
        Me.BALANCEDataGridViewTextBoxColumn.Name = "BALANCEDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(505, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "PREVIOUS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(720, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "NEXT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TblwithdrawalTableAdapter
        '
        Me.TblwithdrawalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblwithdrawalTableAdapter = Me.TblwithdrawalTableAdapter
        Me.TableAdapterManager.UpdateOrder = bank_system.withdrawal_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1018, 444)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(BALANCELabel)
        Me.Controls.Add(Me.BALANCETextBox)
        Me.Controls.Add(DEPOSITLabel)
        Me.Controls.Add(Me.DEPOSITTextBox)
        Me.Controls.Add(WITHDRAWAL_AMTLabel)
        Me.Controls.Add(Me.WITHDRAWAL_AMTTextBox)
        Me.Controls.Add(DATELabel)
        Me.Controls.Add(Me.DATEDateTimePicker)
        Me.Controls.Add(ACCOUNT_NOLabel)
        Me.Controls.Add(Me.ACCOUNT_NOTextBox)
        Me.Controls.Add(NAMELabel)
        Me.Controls.Add(Me.NAMETextBox)
        Me.Controls.Add(CUSTOMER_IDLabel)
        Me.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.Controls.Add(Me.TblwithdrawalBindingNavigator)
        Me.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form5"
        Me.Text = "WITHDRAWAL"
        Me.TransparencyKey = System.Drawing.SystemColors.GradientActiveCaption
        CType(Me.TblwithdrawalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblwithdrawalBindingNavigator.ResumeLayout(False)
        Me.TblwithdrawalBindingNavigator.PerformLayout()
        CType(Me.TblwithdrawalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Withdrawal_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Withdrawal_DataSet As bank_system.withdrawal_DataSet
    Friend WithEvents TblwithdrawalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblwithdrawalTableAdapter As bank_system.withdrawal_DataSetTableAdapters.tblwithdrawalTableAdapter
    Friend WithEvents TableAdapterManager As bank_system.withdrawal_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblwithdrawalBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblwithdrawalBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CUSTOMER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACCOUNT_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents WITHDRAWAL_AMTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DEPOSITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BALANCETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACCOUNTNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WITHDRAWALAMTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPOSITDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BALANCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

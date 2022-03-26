<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Dim LAST_NAMELabel As System.Windows.Forms.Label
        Dim GENDERLabel As System.Windows.Forms.Label
        Dim ACCOUNT_NUMBERLabel As System.Windows.Forms.Label
        Dim OFFICE_ADDRESSLabel As System.Windows.Forms.Label
        Dim HOME_ADDRESSLabel As System.Windows.Forms.Label
        Dim ACCOUNT_TYPELabel As System.Windows.Forms.Label
        Dim OFFICE_PHONELabel As System.Windows.Forms.Label
        Dim EMAIL_ADDRESSLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ItemsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSDataSet = New bank_system.CUSDataSet()
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
        Me.ItemsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.GENDERTextBox = New System.Windows.Forms.TextBox()
        Me.ACCOUNT_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.OFFICE_ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.HOME_ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.ACCOUNT_TYPETextBox = New System.Windows.Forms.TextBox()
        Me.OFFICE_PHONETextBox = New System.Windows.Forms.TextBox()
        Me.EMAIL_ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCOUNTNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFFICEADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOMEADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCOUNTTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFFICEPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ItemsTableAdapter = New bank_system.CUSDataSetTableAdapters.itemsTableAdapter()
        Me.TableAdapterManager = New bank_system.CUSDataSetTableAdapters.TableAdapterManager()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        LAST_NAMELabel = New System.Windows.Forms.Label()
        GENDERLabel = New System.Windows.Forms.Label()
        ACCOUNT_NUMBERLabel = New System.Windows.Forms.Label()
        OFFICE_ADDRESSLabel = New System.Windows.Forms.Label()
        HOME_ADDRESSLabel = New System.Windows.Forms.Label()
        ACCOUNT_TYPELabel = New System.Windows.Forms.Label()
        OFFICE_PHONELabel = New System.Windows.Forms.Label()
        EMAIL_ADDRESSLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        CType(Me.ItemsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemsBindingNavigator.SuspendLayout()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.BackColor = System.Drawing.Color.Transparent
        FIRST_NAMELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FIRST_NAMELabel.ForeColor = System.Drawing.Color.Lime
        FIRST_NAMELabel.Location = New System.Drawing.Point(40, 36)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(115, 20)
        FIRST_NAMELabel.TabIndex = 1
        FIRST_NAMELabel.Text = "FIRST NAME:"
        AddHandler FIRST_NAMELabel.Click, AddressOf Me.FIRST_NAMELabel_Click
        '
        'LAST_NAMELabel
        '
        LAST_NAMELabel.AutoSize = True
        LAST_NAMELabel.BackColor = System.Drawing.Color.Transparent
        LAST_NAMELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LAST_NAMELabel.ForeColor = System.Drawing.Color.Lime
        LAST_NAMELabel.Location = New System.Drawing.Point(44, 76)
        LAST_NAMELabel.Name = "LAST_NAMELabel"
        LAST_NAMELabel.Size = New System.Drawing.Size(111, 20)
        LAST_NAMELabel.TabIndex = 3
        LAST_NAMELabel.Text = "LAST NAME:"
        AddHandler LAST_NAMELabel.Click, AddressOf Me.LAST_NAMELabel_Click
        '
        'GENDERLabel
        '
        GENDERLabel.AutoSize = True
        GENDERLabel.BackColor = System.Drawing.Color.Transparent
        GENDERLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GENDERLabel.ForeColor = System.Drawing.Color.Lime
        GENDERLabel.Location = New System.Drawing.Point(40, 114)
        GENDERLabel.Name = "GENDERLabel"
        GENDERLabel.Size = New System.Drawing.Size(83, 20)
        GENDERLabel.TabIndex = 5
        GENDERLabel.Text = "GENDER:"
        AddHandler GENDERLabel.Click, AddressOf Me.GENDERLabel_Click
        '
        'ACCOUNT_NUMBERLabel
        '
        ACCOUNT_NUMBERLabel.AutoSize = True
        ACCOUNT_NUMBERLabel.BackColor = System.Drawing.Color.Transparent
        ACCOUNT_NUMBERLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ACCOUNT_NUMBERLabel.ForeColor = System.Drawing.Color.Lime
        ACCOUNT_NUMBERLabel.Location = New System.Drawing.Point(43, 148)
        ACCOUNT_NUMBERLabel.Name = "ACCOUNT_NUMBERLabel"
        ACCOUNT_NUMBERLabel.Size = New System.Drawing.Size(177, 20)
        ACCOUNT_NUMBERLabel.TabIndex = 7
        ACCOUNT_NUMBERLabel.Text = "ACCOUNT NUMBER:"
        '
        'OFFICE_ADDRESSLabel
        '
        OFFICE_ADDRESSLabel.AutoSize = True
        OFFICE_ADDRESSLabel.BackColor = System.Drawing.Color.Transparent
        OFFICE_ADDRESSLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OFFICE_ADDRESSLabel.ForeColor = System.Drawing.Color.Lime
        OFFICE_ADDRESSLabel.Location = New System.Drawing.Point(35, 179)
        OFFICE_ADDRESSLabel.Name = "OFFICE_ADDRESSLabel"
        OFFICE_ADDRESSLabel.Size = New System.Drawing.Size(151, 20)
        OFFICE_ADDRESSLabel.TabIndex = 9
        OFFICE_ADDRESSLabel.Text = "OFFICE ADDRESS:"
        '
        'HOME_ADDRESSLabel
        '
        HOME_ADDRESSLabel.AutoSize = True
        HOME_ADDRESSLabel.BackColor = System.Drawing.Color.Transparent
        HOME_ADDRESSLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HOME_ADDRESSLabel.ForeColor = System.Drawing.Color.Lime
        HOME_ADDRESSLabel.Location = New System.Drawing.Point(40, 207)
        HOME_ADDRESSLabel.Name = "HOME_ADDRESSLabel"
        HOME_ADDRESSLabel.Size = New System.Drawing.Size(144, 20)
        HOME_ADDRESSLabel.TabIndex = 11
        HOME_ADDRESSLabel.Text = "HOME ADDRESS:"
        '
        'ACCOUNT_TYPELabel
        '
        ACCOUNT_TYPELabel.AutoSize = True
        ACCOUNT_TYPELabel.BackColor = System.Drawing.Color.Transparent
        ACCOUNT_TYPELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ACCOUNT_TYPELabel.ForeColor = System.Drawing.Color.Lime
        ACCOUNT_TYPELabel.Location = New System.Drawing.Point(40, 238)
        ACCOUNT_TYPELabel.Name = "ACCOUNT_TYPELabel"
        ACCOUNT_TYPELabel.Size = New System.Drawing.Size(144, 20)
        ACCOUNT_TYPELabel.TabIndex = 13
        ACCOUNT_TYPELabel.Text = "ACCOUNT TYPE:"
        '
        'OFFICE_PHONELabel
        '
        OFFICE_PHONELabel.AutoSize = True
        OFFICE_PHONELabel.BackColor = System.Drawing.Color.Transparent
        OFFICE_PHONELabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OFFICE_PHONELabel.ForeColor = System.Drawing.Color.Lime
        OFFICE_PHONELabel.Location = New System.Drawing.Point(40, 267)
        OFFICE_PHONELabel.Name = "OFFICE_PHONELabel"
        OFFICE_PHONELabel.Size = New System.Drawing.Size(137, 20)
        OFFICE_PHONELabel.TabIndex = 15
        OFFICE_PHONELabel.Text = "OFFICE PHONE:"
        '
        'EMAIL_ADDRESSLabel
        '
        EMAIL_ADDRESSLabel.AutoSize = True
        EMAIL_ADDRESSLabel.BackColor = System.Drawing.Color.Transparent
        EMAIL_ADDRESSLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMAIL_ADDRESSLabel.ForeColor = System.Drawing.Color.Lime
        EMAIL_ADDRESSLabel.Location = New System.Drawing.Point(35, 299)
        EMAIL_ADDRESSLabel.Name = "EMAIL_ADDRESSLabel"
        EMAIL_ADDRESSLabel.Size = New System.Drawing.Size(146, 20)
        EMAIL_ADDRESSLabel.TabIndex = 17
        EMAIL_ADDRESSLabel.Text = "EMAIL ADDRESS:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.BackColor = System.Drawing.Color.Transparent
        CodeLabel.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodeLabel.ForeColor = System.Drawing.Color.Lime
        CodeLabel.Location = New System.Drawing.Point(72, 337)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(55, 20)
        CodeLabel.TabIndex = 19
        CodeLabel.Text = "CODE"
        AddHandler CodeLabel.Click, AddressOf Me.CodeLabel_Click
        '
        'ItemsBindingNavigator
        '
        Me.ItemsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ItemsBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.ItemsBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemsBindingNavigator.BindingSource = Me.ItemsBindingSource
        Me.ItemsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ItemsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ItemsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ItemsBindingNavigatorSaveItem, Me.PrintToolStripButton})
        Me.ItemsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ItemsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ItemsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ItemsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ItemsBindingNavigator.Name = "ItemsBindingNavigator"
        Me.ItemsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ItemsBindingNavigator.Size = New System.Drawing.Size(1119, 25)
        Me.ItemsBindingNavigator.TabIndex = 0
        Me.ItemsBindingNavigator.Text = "BindingNavigator1"
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
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "items"
        Me.ItemsBindingSource.DataSource = Me.CUSDataSet
        '
        'CUSDataSet
        '
        Me.CUSDataSet.DataSetName = "CUSDataSet"
        Me.CUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ItemsBindingNavigatorSaveItem
        '
        Me.ItemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItemsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemsBindingNavigatorSaveItem.Name = "ItemsBindingNavigatorSaveItem"
        Me.ItemsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ItemsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "FIRST NAME", True))
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(261, 36)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(214, 22)
        Me.FIRST_NAMETextBox.TabIndex = 2
        '
        'LAST_NAMETextBox
        '
        Me.LAST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "LAST NAME", True))
        Me.LAST_NAMETextBox.Location = New System.Drawing.Point(261, 73)
        Me.LAST_NAMETextBox.Name = "LAST_NAMETextBox"
        Me.LAST_NAMETextBox.Size = New System.Drawing.Size(214, 22)
        Me.LAST_NAMETextBox.TabIndex = 4
        '
        'GENDERTextBox
        '
        Me.GENDERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "GENDER", True))
        Me.GENDERTextBox.Location = New System.Drawing.Point(261, 114)
        Me.GENDERTextBox.Name = "GENDERTextBox"
        Me.GENDERTextBox.Size = New System.Drawing.Size(214, 22)
        Me.GENDERTextBox.TabIndex = 6
        '
        'ACCOUNT_NUMBERTextBox
        '
        Me.ACCOUNT_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "ACCOUNT NUMBER", True))
        Me.ACCOUNT_NUMBERTextBox.Location = New System.Drawing.Point(261, 144)
        Me.ACCOUNT_NUMBERTextBox.Name = "ACCOUNT_NUMBERTextBox"
        Me.ACCOUNT_NUMBERTextBox.Size = New System.Drawing.Size(167, 22)
        Me.ACCOUNT_NUMBERTextBox.TabIndex = 8
        '
        'OFFICE_ADDRESSTextBox
        '
        Me.OFFICE_ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "OFFICE ADDRESS", True))
        Me.OFFICE_ADDRESSTextBox.Location = New System.Drawing.Point(261, 178)
        Me.OFFICE_ADDRESSTextBox.Name = "OFFICE_ADDRESSTextBox"
        Me.OFFICE_ADDRESSTextBox.Size = New System.Drawing.Size(116, 22)
        Me.OFFICE_ADDRESSTextBox.TabIndex = 10
        '
        'HOME_ADDRESSTextBox
        '
        Me.HOME_ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "HOME ADDRESS", True))
        Me.HOME_ADDRESSTextBox.Location = New System.Drawing.Point(261, 208)
        Me.HOME_ADDRESSTextBox.Name = "HOME_ADDRESSTextBox"
        Me.HOME_ADDRESSTextBox.Size = New System.Drawing.Size(116, 22)
        Me.HOME_ADDRESSTextBox.TabIndex = 12
        '
        'ACCOUNT_TYPETextBox
        '
        Me.ACCOUNT_TYPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "ACCOUNT TYPE", True))
        Me.ACCOUNT_TYPETextBox.Location = New System.Drawing.Point(261, 238)
        Me.ACCOUNT_TYPETextBox.Name = "ACCOUNT_TYPETextBox"
        Me.ACCOUNT_TYPETextBox.Size = New System.Drawing.Size(167, 22)
        Me.ACCOUNT_TYPETextBox.TabIndex = 14
        '
        'OFFICE_PHONETextBox
        '
        Me.OFFICE_PHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "OFFICE PHONE", True))
        Me.OFFICE_PHONETextBox.Location = New System.Drawing.Point(261, 268)
        Me.OFFICE_PHONETextBox.Name = "OFFICE_PHONETextBox"
        Me.OFFICE_PHONETextBox.Size = New System.Drawing.Size(167, 22)
        Me.OFFICE_PHONETextBox.TabIndex = 16
        '
        'EMAIL_ADDRESSTextBox
        '
        Me.EMAIL_ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "EMAIL ADDRESS", True))
        Me.EMAIL_ADDRESSTextBox.Location = New System.Drawing.Point(261, 298)
        Me.EMAIL_ADDRESSTextBox.Name = "EMAIL_ADDRESSTextBox"
        Me.EMAIL_ADDRESSTextBox.Size = New System.Drawing.Size(167, 22)
        Me.EMAIL_ADDRESSTextBox.TabIndex = 18
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(261, 338)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(116, 22)
        Me.CodeTextBox.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.ACCOUNTNUMBERDataGridViewTextBoxColumn, Me.OFFICEADDRESSDataGridViewTextBoxColumn, Me.HOMEADDRESSDataGridViewTextBoxColumn, Me.ACCOUNTTYPEDataGridViewTextBoxColumn, Me.OFFICEPHONEDataGridViewTextBoxColumn, Me.EMAILADDRESSDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(543, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 173)
        Me.DataGridView1.TabIndex = 21
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        '
        'ACCOUNTNUMBERDataGridViewTextBoxColumn
        '
        Me.ACCOUNTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT NUMBER"
        Me.ACCOUNTNUMBERDataGridViewTextBoxColumn.HeaderText = "ACCOUNT NUMBER"
        Me.ACCOUNTNUMBERDataGridViewTextBoxColumn.Name = "ACCOUNTNUMBERDataGridViewTextBoxColumn"
        '
        'OFFICEADDRESSDataGridViewTextBoxColumn
        '
        Me.OFFICEADDRESSDataGridViewTextBoxColumn.DataPropertyName = "OFFICE ADDRESS"
        Me.OFFICEADDRESSDataGridViewTextBoxColumn.HeaderText = "OFFICE ADDRESS"
        Me.OFFICEADDRESSDataGridViewTextBoxColumn.Name = "OFFICEADDRESSDataGridViewTextBoxColumn"
        '
        'HOMEADDRESSDataGridViewTextBoxColumn
        '
        Me.HOMEADDRESSDataGridViewTextBoxColumn.DataPropertyName = "HOME ADDRESS"
        Me.HOMEADDRESSDataGridViewTextBoxColumn.HeaderText = "HOME ADDRESS"
        Me.HOMEADDRESSDataGridViewTextBoxColumn.Name = "HOMEADDRESSDataGridViewTextBoxColumn"
        '
        'ACCOUNTTYPEDataGridViewTextBoxColumn
        '
        Me.ACCOUNTTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT TYPE"
        Me.ACCOUNTTYPEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT TYPE"
        Me.ACCOUNTTYPEDataGridViewTextBoxColumn.Name = "ACCOUNTTYPEDataGridViewTextBoxColumn"
        '
        'OFFICEPHONEDataGridViewTextBoxColumn
        '
        Me.OFFICEPHONEDataGridViewTextBoxColumn.DataPropertyName = "OFFICE PHONE"
        Me.OFFICEPHONEDataGridViewTextBoxColumn.HeaderText = "OFFICE PHONE"
        Me.OFFICEPHONEDataGridViewTextBoxColumn.Name = "OFFICEPHONEDataGridViewTextBoxColumn"
        '
        'EMAILADDRESSDataGridViewTextBoxColumn
        '
        Me.EMAILADDRESSDataGridViewTextBoxColumn.DataPropertyName = "EMAIL ADDRESS"
        Me.EMAILADDRESSDataGridViewTextBoxColumn.HeaderText = "EMAIL ADDRESS"
        Me.EMAILADDRESSDataGridViewTextBoxColumn.Name = "EMAILADDRESSDataGridViewTextBoxColumn"
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(694, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 76)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.itemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = bank_system.CUSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1119, 520)
        Me.Controls.Add(Me.ItemsBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(EMAIL_ADDRESSLabel)
        Me.Controls.Add(Me.EMAIL_ADDRESSTextBox)
        Me.Controls.Add(OFFICE_PHONELabel)
        Me.Controls.Add(Me.OFFICE_PHONETextBox)
        Me.Controls.Add(ACCOUNT_TYPELabel)
        Me.Controls.Add(Me.ACCOUNT_TYPETextBox)
        Me.Controls.Add(HOME_ADDRESSLabel)
        Me.Controls.Add(Me.HOME_ADDRESSTextBox)
        Me.Controls.Add(OFFICE_ADDRESSLabel)
        Me.Controls.Add(Me.OFFICE_ADDRESSTextBox)
        Me.Controls.Add(ACCOUNT_NUMBERLabel)
        Me.Controls.Add(Me.ACCOUNT_NUMBERTextBox)
        Me.Controls.Add(GENDERLabel)
        Me.Controls.Add(Me.GENDERTextBox)
        Me.Controls.Add(LAST_NAMELabel)
        Me.Controls.Add(Me.LAST_NAMETextBox)
        Me.Controls.Add(Me.FIRST_NAMETextBox)
        Me.Controls.Add(FIRST_NAMELabel)
        Me.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form3"
        Me.Text = "CUSTOMER DETAILS"
        CType(Me.ItemsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemsBindingNavigator.ResumeLayout(False)
        Me.ItemsBindingNavigator.PerformLayout()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CUSDataSet As bank_system.CUSDataSet
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As bank_system.CUSDataSetTableAdapters.itemsTableAdapter
    Friend WithEvents TableAdapterManager As bank_system.CUSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ItemsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FIRST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LAST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents GENDERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACCOUNT_NUMBERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OFFICE_ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HOME_ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACCOUNT_TYPETextBox As System.Windows.Forms.TextBox
    Friend WithEvents OFFICE_PHONETextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMAIL_ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACCOUNTNUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OFFICEADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOMEADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACCOUNTTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OFFICEPHONEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

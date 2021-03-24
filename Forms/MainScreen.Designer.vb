<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainScreen
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
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Total_PriceLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim StatusLabel1 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.OMSys_OrdersV2DBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Total_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OMSys_OrdersV2DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OMSys_OrdersDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSys_OrdersDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.TableAdapterManager = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        Me.OMSys_OrdersV2DBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersV2DBTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Customer_NameLabel = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Total_PriceLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        StatusLabel1 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.OMSys_OrdersV2DBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersV2DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(1073, 119)
        Customer_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(124, 19)
        Customer_NameLabel.TabIndex = 69
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Product_NameLabel
        '
        Product_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(1073, 150)
        Product_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(113, 19)
        Product_NameLabel.TabIndex = 71
        Product_NameLabel.Text = "Product Name:"
        '
        'QuantityLabel
        '
        QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(1073, 209)
        QuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(74, 19)
        QuantityLabel.TabIndex = 73
        QuantityLabel.Text = "Quantity:"
        '
        'Total_PriceLabel
        '
        Total_PriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Total_PriceLabel.AutoSize = True
        Total_PriceLabel.Location = New System.Drawing.Point(1074, 240)
        Total_PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_PriceLabel.Name = "Total_PriceLabel"
        Total_PriceLabel.Size = New System.Drawing.Size(82, 19)
        Total_PriceLabel.TabIndex = 75
        Total_PriceLabel.Text = "Total Price:"
        '
        'AddressLabel
        '
        AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(1074, 271)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(65, 19)
        AddressLabel.TabIndex = 77
        AddressLabel.Text = "Address:"
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.Location = New System.Drawing.Point(1073, 302)
        Contact_NumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(130, 19)
        Contact_NumberLabel.TabIndex = 79
        Contact_NumberLabel.Text = "Contact Number:"
        '
        'NotesLabel
        '
        NotesLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(1073, 329)
        NotesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(51, 19)
        NotesLabel.TabIndex = 81
        NotesLabel.Text = "Notes:"
        '
        'IDLabel
        '
        IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(1073, 88)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(69, 19)
        IDLabel.TabIndex = 90
        IDLabel.Text = "Order ID:"
        '
        'StatusLabel1
        '
        StatusLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        StatusLabel1.AutoSize = True
        StatusLabel1.Location = New System.Drawing.Point(1073, 446)
        StatusLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StatusLabel1.Name = "StatusLabel1"
        StatusLabel1.Size = New System.Drawing.Size(54, 19)
        StatusLabel1.TabIndex = 94
        StatusLabel1.Text = "Status:"
        '
        'Label11
        '
        Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(1073, 178)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(46, 19)
        Label11.TabIndex = 101
        Label11.Text = "Price:"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(920, 61)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(113, 43)
        Me.btnAddOrder.TabIndex = 3
        Me.btnAddOrder.Text = "New Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeleteOrder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteOrder.Location = New System.Drawing.Point(1266, 496)
        Me.btnDeleteOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(85, 43)
        Me.btnDeleteOrder.TabIndex = 15
        Me.btnDeleteOrder.Text = "Delete"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUpdateOrder.ForeColor = System.Drawing.Color.White
        Me.btnUpdateOrder.Location = New System.Drawing.Point(1134, 496)
        Me.btnUpdateOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(85, 43)
        Me.btnUpdateOrder.TabIndex = 14
        Me.btnUpdateOrder.Text = "Save"
        Me.btnUpdateOrder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order List"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1137, 649)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 19)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1088, 553)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 96)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "OMSYS"
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_Name", True))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(1229, 115)
        Me.Customer_NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(189, 23)
        Me.Customer_NameTextBox.TabIndex = 5
        '
        'OMSys_OrdersV2DBBindingSource
        '
        Me.OMSys_OrdersV2DBBindingSource.DataMember = "OMSys_OrdersV2DB"
        Me.OMSys_OrdersV2DBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSysOrdersDBDataSet
        '
        Me.OMSysOrdersDBDataSet.DataSetName = "OMSysOrdersDBDataSet"
        Me.OMSysOrdersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Product_Name", True))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(1229, 146)
        Me.Product_NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.Size = New System.Drawing.Size(189, 23)
        Me.Product_NameTextBox.TabIndex = 6
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(1229, 205)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(189, 23)
        Me.QuantityTextBox.TabIndex = 8
        '
        'Total_PriceTextBox
        '
        Me.Total_PriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Total_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Total_Price", True))
        Me.Total_PriceTextBox.Location = New System.Drawing.Point(1229, 236)
        Me.Total_PriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Total_PriceTextBox.Name = "Total_PriceTextBox"
        Me.Total_PriceTextBox.ReadOnly = True
        Me.Total_PriceTextBox.Size = New System.Drawing.Size(189, 23)
        Me.Total_PriceTextBox.TabIndex = 9
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(1229, 267)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(189, 23)
        Me.AddressTextBox.TabIndex = 10
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Contact_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Contact_Number", True))
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(1229, 298)
        Me.Contact_NumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(189, 23)
        Me.Contact_NumberTextBox.TabIndex = 11
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(1229, 329)
        Me.NotesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(189, 105)
        Me.NotesTextBox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(1192, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 19)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(1182, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 19)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(1123, 445)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 19)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "*"
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(1229, 84)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(132, 23)
        Me.IDTextBox.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(1140, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 19)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "*"
        '
        'OMSys_OrdersV2DBDataGridView
        '
        Me.OMSys_OrdersV2DBDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OMSys_OrdersV2DBDataGridView.AutoGenerateColumns = False
        Me.OMSys_OrdersV2DBDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersHeight = 29
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OMSys_OrdersV2DBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.OMSys_OrdersV2DBDataGridView.DataSource = Me.OMSys_OrdersV2DBBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OMSys_OrdersV2DBDataGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.OMSys_OrdersV2DBDataGridView.EnableHeadersVisualStyles = False
        Me.OMSys_OrdersV2DBDataGridView.Location = New System.Drawing.Point(28, 112)
        Me.OMSys_OrdersV2DBDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.OMSys_OrdersV2DBDataGridView.Name = "OMSys_OrdersV2DBDataGridView"
        Me.OMSys_OrdersV2DBDataGridView.ReadOnly = True
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersVisible = False
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersWidth = 51
        Me.OMSys_OrdersV2DBDataGridView.Size = New System.Drawing.Size(1005, 556)
        Me.OMSys_OrdersV2DBDataGridView.TabIndex = 94
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Order ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total_Price"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Price"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Contact_Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 175
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'OMSys_OrdersDBBindingSource
        '
        Me.OMSys_OrdersDBBindingSource.DataMember = "OMSys_OrdersDB"
        Me.OMSys_OrdersDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSys_OrdersDBTableAdapter
        '
        Me.OMSys_OrdersDBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OMSys_OrdersDBTableAdapter = Me.OMSys_OrdersDBTableAdapter
        Me.TableAdapterManager.OMSys_OrdersV2DBTableAdapter = Nothing
        Me.TableAdapterManager.OMSys_StocksDBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OMSys_OrdersV2DBTableAdapter
        '
        Me.OMSys_OrdersV2DBTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(1141, 205)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 19)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "*"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Location = New System.Drawing.Point(304, 74)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(245, 23)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(556, 61)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(113, 43)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewAll.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(677, 61)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(113, 43)
        Me.btnViewAll.TabIndex = 2
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(301, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "(ID, Customer Name, Product Name, Address or Status)"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(1113, 178)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 19)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "*"
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Quantity", True))
        Me.txtPrice.Location = New System.Drawing.Point(1229, 174)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(189, 23)
        Me.txtPrice.TabIndex = 7
        '
        'cboStatus
        '
        Me.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Status", True))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"PENDING", "PAID", "ACCEPTED"})
        Me.cboStatus.Location = New System.Drawing.Point(1229, 442)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(132, 25)
        Me.cboStatus.TabIndex = 13
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1443, 701)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(StatusLabel1)
        Me.Controls.Add(Me.OMSys_OrdersV2DBDataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Customer_NameLabel)
        Me.Controls.Add(Me.Customer_NameTextBox)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.Product_NameTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Total_PriceLabel)
        Me.Controls.Add(Me.Total_PriceTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Contact_NumberLabel)
        Me.Controls.Add(Me.Contact_NumberTextBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnUpdateOrder)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OMSys"
        CType(Me.OMSys_OrdersV2DBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSys_OrdersV2DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OMSysOrdersDBDataSet As OMSysOrdersDBDataSet
    Friend WithEvents OMSys_OrdersDBBindingSource As BindingSource
    Friend WithEvents OMSys_OrdersDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter
    Friend WithEvents TableAdapterManager As OMSysOrdersDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customer_NameTextBox As TextBox
    Friend WithEvents Product_NameTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Total_PriceTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Contact_NumberTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OMSys_OrdersV2DBBindingSource As BindingSource
    Friend WithEvents OMSys_OrdersV2DBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersV2DBTableAdapter
    Friend WithEvents OMSys_OrdersV2DBDataGridView As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnViewAll As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents cboStatus As ComboBox
End Class

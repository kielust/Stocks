<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnAdd
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OMSys_OrdersV2DBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.OMSys_OrdersV2DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Added = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Delivered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OMSys_OrdersDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSys_OrdersDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.TableAdapterManager = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        Me.OMSys_OrdersV2DBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersV2DBTableAdapter()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_OrderID = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_DateAdded = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_ProductName = New System.Windows.Forms.Label()
        Me.txt_ProductName = New System.Windows.Forms.TextBox()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.lbl_MiddleName = New System.Windows.Forms.Label()
        Me.lbl_LastName = New System.Windows.Forms.Label()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.txt_MiddleName = New System.Windows.Forms.TextBox()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.txt_Quantity = New System.Windows.Forms.TextBox()
        Me.lbl_TotalPrice = New System.Windows.Forms.Label()
        Me.txt_TotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ContactNumber = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_DateDelivered = New System.Windows.Forms.Label()
        Me.btnAddOrder1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmb_Status = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.OMSys_OrdersV2DBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersV2DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(1979, 237)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(90, 34)
        Me.btnAddOrder.TabIndex = 3
        Me.btnAddOrder.Text = "New Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order List"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 885)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 794)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 78)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "OMSYS"
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
        'OMSys_OrdersV2DBDataGridView
        '
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToAddRows = False
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToDeleteRows = False
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToResizeColumns = False
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToResizeRows = False
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
        Me.OMSys_OrdersV2DBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Date_Added, Me.DataGridViewTextBoxColumn3, Me.Customer_FirstName, Me.Customer_MiddleName, Me.Customer_LastName, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Date_Delivered})
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
        Me.OMSys_OrdersV2DBDataGridView.Location = New System.Drawing.Point(50, 150)
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
        Me.OMSys_OrdersV2DBDataGridView.Size = New System.Drawing.Size(1680, 445)
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
        'Date_Added
        '
        Me.Date_Added.DataPropertyName = "Date_Added"
        Me.Date_Added.HeaderText = "Date Added"
        Me.Date_Added.Name = "Date_Added"
        Me.Date_Added.ReadOnly = True
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
        'Customer_FirstName
        '
        Me.Customer_FirstName.DataPropertyName = "Customer_FirstName"
        Me.Customer_FirstName.HeaderText = "First Name"
        Me.Customer_FirstName.Name = "Customer_FirstName"
        Me.Customer_FirstName.ReadOnly = True
        '
        'Customer_MiddleName
        '
        Me.Customer_MiddleName.DataPropertyName = "Customer_MiddleName"
        Me.Customer_MiddleName.HeaderText = "Middle Name"
        Me.Customer_MiddleName.Name = "Customer_MiddleName"
        Me.Customer_MiddleName.ReadOnly = True
        '
        'Customer_LastName
        '
        Me.Customer_LastName.DataPropertyName = "Customer_LastName"
        Me.Customer_LastName.HeaderText = "Last Name"
        Me.Customer_LastName.Name = "Customer_LastName"
        Me.Customer_LastName.ReadOnly = True
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
        'Date_Delivered
        '
        Me.Date_Delivered.DataPropertyName = "Date_Delivered"
        Me.Date_Delivered.HeaderText = "Date Delivered"
        Me.Date_Delivered.Name = "Date_Delivered"
        Me.Date_Delivered.ReadOnly = True
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
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Location = New System.Drawing.Point(240, 118)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(197, 20)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(442, 108)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 34)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewAll.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(539, 108)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(90, 34)
        Me.btnViewAll.TabIndex = 2
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(240, 107)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 9)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "(ID, Customer Name, Product Name, Address or Status)"
        '
        'lbl_OrderID
        '
        Me.lbl_OrderID.AutoSize = True
        Me.lbl_OrderID.Location = New System.Drawing.Point(69, 635)
        Me.lbl_OrderID.Name = "lbl_OrderID"
        Me.lbl_OrderID.Size = New System.Drawing.Size(53, 16)
        Me.lbl_OrderID.TabIndex = 101
        Me.lbl_OrderID.Text = "Order ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_ID
        '
        Me.txt_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "ID", True))
        Me.txt_ID.Location = New System.Drawing.Point(128, 631)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(100, 20)
        Me.txt_ID.TabIndex = 102
        '
        'lbl_DateAdded
        '
        Me.lbl_DateAdded.AutoSize = True
        Me.lbl_DateAdded.Location = New System.Drawing.Point(262, 673)
        Me.lbl_DateAdded.Name = "lbl_DateAdded"
        Me.lbl_DateAdded.Size = New System.Drawing.Size(76, 16)
        Me.lbl_DateAdded.TabIndex = 103
        Me.lbl_DateAdded.Text = "Date Added"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Date_Added", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(344, 669)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 104
        '
        'lbl_ProductName
        '
        Me.lbl_ProductName.AutoSize = True
        Me.lbl_ProductName.Location = New System.Drawing.Point(251, 635)
        Me.lbl_ProductName.Name = "lbl_ProductName"
        Me.lbl_ProductName.Size = New System.Drawing.Size(87, 16)
        Me.lbl_ProductName.TabIndex = 105
        Me.lbl_ProductName.Text = "Product Name"
        '
        'txt_ProductName
        '
        Me.txt_ProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Product_Name", True))
        Me.txt_ProductName.Location = New System.Drawing.Point(344, 632)
        Me.txt_ProductName.Name = "txt_ProductName"
        Me.txt_ProductName.Size = New System.Drawing.Size(200, 20)
        Me.txt_ProductName.TabIndex = 106
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Location = New System.Drawing.Point(599, 631)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(62, 16)
        Me.lbl_FirstName.TabIndex = 107
        Me.lbl_FirstName.Text = "First Name"
        '
        'lbl_MiddleName
        '
        Me.lbl_MiddleName.AutoSize = True
        Me.lbl_MiddleName.Location = New System.Drawing.Point(579, 674)
        Me.lbl_MiddleName.Name = "lbl_MiddleName"
        Me.lbl_MiddleName.Size = New System.Drawing.Size(82, 16)
        Me.lbl_MiddleName.TabIndex = 108
        Me.lbl_MiddleName.Text = "Middle Name"
        '
        'lbl_LastName
        '
        Me.lbl_LastName.AutoSize = True
        Me.lbl_LastName.Location = New System.Drawing.Point(596, 711)
        Me.lbl_LastName.Name = "lbl_LastName"
        Me.lbl_LastName.Size = New System.Drawing.Size(65, 16)
        Me.lbl_LastName.TabIndex = 109
        Me.lbl_LastName.Text = "Last Name"
        '
        'txt_FirstName
        '
        Me.txt_FirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_FirstName", True))
        Me.txt_FirstName.Location = New System.Drawing.Point(667, 631)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(120, 20)
        Me.txt_FirstName.TabIndex = 110
        '
        'txt_MiddleName
        '
        Me.txt_MiddleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_MiddleName", True))
        Me.txt_MiddleName.Location = New System.Drawing.Point(667, 669)
        Me.txt_MiddleName.Name = "txt_MiddleName"
        Me.txt_MiddleName.Size = New System.Drawing.Size(120, 20)
        Me.txt_MiddleName.TabIndex = 111
        '
        'txt_LastName
        '
        Me.txt_LastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_LastName", True))
        Me.txt_LastName.Location = New System.Drawing.Point(667, 707)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(120, 20)
        Me.txt_LastName.TabIndex = 112
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Location = New System.Drawing.Point(832, 631)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Quantity.TabIndex = 113
        Me.lbl_Quantity.Text = "Quantity"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Quantity", True))
        Me.txt_Quantity.Location = New System.Drawing.Point(894, 630)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(120, 20)
        Me.txt_Quantity.TabIndex = 114
        '
        'lbl_TotalPrice
        '
        Me.lbl_TotalPrice.AutoSize = True
        Me.lbl_TotalPrice.Location = New System.Drawing.Point(825, 672)
        Me.lbl_TotalPrice.Name = "lbl_TotalPrice"
        Me.lbl_TotalPrice.Size = New System.Drawing.Size(63, 16)
        Me.lbl_TotalPrice.TabIndex = 115
        Me.lbl_TotalPrice.Text = "Total Price"
        '
        'txt_TotalPrice
        '
        Me.txt_TotalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Total_Price", True))
        Me.txt_TotalPrice.Location = New System.Drawing.Point(894, 670)
        Me.txt_TotalPrice.Name = "txt_TotalPrice"
        Me.txt_TotalPrice.Size = New System.Drawing.Size(120, 20)
        Me.txt_TotalPrice.TabIndex = 116
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1102, 632)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Address"
        '
        'txt_Address
        '
        Me.txt_Address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Address", True))
        Me.txt_Address.Location = New System.Drawing.Point(1157, 628)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(200, 20)
        Me.txt_Address.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1051, 673)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Contact Number"
        '
        'txt_ContactNumber
        '
        Me.txt_ContactNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Contact_Number", True))
        Me.txt_ContactNumber.Location = New System.Drawing.Point(1157, 669)
        Me.txt_ContactNumber.Name = "txt_ContactNumber"
        Me.txt_ContactNumber.Size = New System.Drawing.Size(200, 20)
        Me.txt_ContactNumber.TabIndex = 120
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Date_Delivered", True))
        Me.DateTimePicker2.Location = New System.Drawing.Point(344, 706)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 122
        '
        'lbl_DateDelivered
        '
        Me.lbl_DateDelivered.AutoSize = True
        Me.lbl_DateDelivered.Location = New System.Drawing.Point(248, 710)
        Me.lbl_DateDelivered.Name = "lbl_DateDelivered"
        Me.lbl_DateDelivered.Size = New System.Drawing.Size(90, 16)
        Me.lbl_DateDelivered.TabIndex = 121
        Me.lbl_DateDelivered.Text = "Date Delivered"
        '
        'btnAddOrder1
        '
        Me.btnAddOrder1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddOrder1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder1.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder1.Location = New System.Drawing.Point(1640, 106)
        Me.btnAddOrder1.Name = "btnAddOrder1"
        Me.btnAddOrder1.Size = New System.Drawing.Size(90, 34)
        Me.btnAddOrder1.TabIndex = 123
        Me.btnAddOrder1.Text = "New Order"
        Me.btnAddOrder1.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1640, 625)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 34)
        Me.btnSave.TabIndex = 124
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmb_Status
        '
        Me.cmb_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Status", True))
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Items.AddRange(New Object() {"CANCELLED", "PENDING", "PAID", "ACCEPTED"})
        Me.cmb_Status.Location = New System.Drawing.Point(1157, 708)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(121, 23)
        Me.cmb_Status.TabIndex = 125
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(1110, 712)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(41, 16)
        Me.lblStatus.TabIndex = 126
        Me.lblStatus.Text = "Status"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(1640, 681)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 34)
        Me.btnDelete.TabIndex = 127
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(299, 794)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(34, 16)
        Me.lblNotes.TabIndex = 128
        Me.lblNotes.Text = "Note"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Notes", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(344, 776)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(684, 134)
        Me.RichTextBox1.TabIndex = 129
        Me.RichTextBox1.Text = ""
        '
        'btnAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1775, 958)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmb_Status)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddOrder1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lbl_DateDelivered)
        Me.Controls.Add(Me.txt_ContactNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_TotalPrice)
        Me.Controls.Add(Me.lbl_TotalPrice)
        Me.Controls.Add(Me.txt_Quantity)
        Me.Controls.Add(Me.lbl_Quantity)
        Me.Controls.Add(Me.txt_LastName)
        Me.Controls.Add(Me.txt_MiddleName)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.lbl_LastName)
        Me.Controls.Add(Me.lbl_MiddleName)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.txt_ProductName)
        Me.Controls.Add(Me.lbl_ProductName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_DateAdded)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lbl_OrderID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.OMSys_OrdersV2DBDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "btnAdd"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OMSysOrdersDBDataSet As OMSysOrdersDBDataSet
    Friend WithEvents OMSys_OrdersDBBindingSource As BindingSource
    Friend WithEvents OMSys_OrdersDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter
    Friend WithEvents TableAdapterManager As OMSysOrdersDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OMSys_OrdersV2DBBindingSource As BindingSource
    Friend WithEvents OMSys_OrdersV2DBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersV2DBTableAdapter
    Friend WithEvents OMSys_OrdersV2DBDataGridView As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnViewAll As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Date_Added As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Customer_FirstName As DataGridViewTextBoxColumn
    Friend WithEvents Customer_MiddleName As DataGridViewTextBoxColumn
    Friend WithEvents Customer_LastName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Date_Delivered As DataGridViewTextBoxColumn
    Friend WithEvents lbl_OrderID As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lbl_DateAdded As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_ProductName As Label
    Friend WithEvents txt_ProductName As TextBox
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_MiddleName As Label
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents txt_FirstName As TextBox
    Friend WithEvents txt_MiddleName As TextBox
    Friend WithEvents txt_LastName As TextBox
    Friend WithEvents lbl_Quantity As Label
    Friend WithEvents txt_Quantity As TextBox
    Friend WithEvents lbl_TotalPrice As Label
    Friend WithEvents txt_TotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ContactNumber As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lbl_DateDelivered As Label
    Friend WithEvents btnAddOrder1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmb_Status As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblNotes As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class

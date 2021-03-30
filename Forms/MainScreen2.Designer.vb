<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainScreen2
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
        Dim Selling_PriceLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_DateAdded = New System.Windows.Forms.Label()
        Me.txt_StockName = New System.Windows.Forms.TextBox()
        Me.date_added = New System.Windows.Forms.DateTimePicker()
        Me.lbl_StockName = New System.Windows.Forms.Label()
        Me.lbl_Stock = New System.Windows.Forms.Label()
        Me.txt_Stock = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.cmb_Size = New System.Windows.Forms.ComboBox()
        Me.lbl_Color = New System.Windows.Forms.Label()
        Me.txt_Color = New System.Windows.Forms.TextBox()
        Me.lbl_SellingPrice = New System.Windows.Forms.Label()
        Me.txt_SellingPrice = New System.Windows.Forms.TextBox()
        Me.lbl_UnitPrice = New System.Windows.Forms.Label()
        Me.txt_OriginalPrice = New System.Windows.Forms.TextBox()
        Me.OMSysStocksDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OMSys_OrdersDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSys_OrdersDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.TableAdapterManager = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        Me.OMSys_StocksDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter()
        Selling_PriceLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Selling_PriceLabel
        '
        Selling_PriceLabel.Location = New System.Drawing.Point(0, 0)
        Selling_PriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Selling_PriceLabel.Name = "Selling_PriceLabel"
        Selling_PriceLabel.Size = New System.Drawing.Size(80, 18)
        Selling_PriceLabel.TabIndex = 94
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(1064, 40)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(90, 34)
        Me.btnAddOrder.TabIndex = 3
        Me.btnAddOrder.Text = "New Stock"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeleteOrder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteOrder.Location = New System.Drawing.Point(1340, 384)
        Me.btnDeleteOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(68, 34)
        Me.btnDeleteOrder.TabIndex = 11
        Me.btnDeleteOrder.Text = "Delete"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUpdateOrder.ForeColor = System.Drawing.Color.White
        Me.btnUpdateOrder.Location = New System.Drawing.Point(1235, 384)
        Me.btnUpdateOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(68, 34)
        Me.btnUpdateOrder.TabIndex = 10
        Me.btnUpdateOrder.Text = "Save"
        Me.btnUpdateOrder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 45)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Stock List"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1232, 501)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
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
        Me.Label3.Location = New System.Drawing.Point(1192, 420)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 78)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "OMSYS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateAddedDataGridViewTextBoxColumn, Me.MaterialNameDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.Size, Me.Color, Me.SellingPriceDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OMSysStocksDBBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(63, 86)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1091, 429)
        Me.DataGridView1.TabIndex = 85
        '
        'Size
        '
        Me.Size.DataPropertyName = "Size"
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        Me.Size.ReadOnly = True
        '
        'Color
        '
        Me.Color.DataPropertyName = "Color"
        Me.Color.HeaderText = "Color"
        Me.Color.Name = "Color"
        Me.Color.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(289, 41)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 9)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "(ID, Material Name)"
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewAll.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(581, 43)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(90, 34)
        Me.btnViewAll.TabIndex = 2
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(485, 43)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 34)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Location = New System.Drawing.Point(292, 54)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(188, 20)
        Me.txtSearch.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(1232, 56)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(19, 16)
        Me.lblID.TabIndex = 105
        Me.lblID.Text = "ID"
        '
        'txt_ID
        '
        Me.txt_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "ID", True))
        Me.txt_ID.Location = New System.Drawing.Point(1267, 53)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(100, 20)
        Me.txt_ID.TabIndex = 106
        '
        'lbl_DateAdded
        '
        Me.lbl_DateAdded.AutoSize = True
        Me.lbl_DateAdded.Location = New System.Drawing.Point(1175, 91)
        Me.lbl_DateAdded.Name = "lbl_DateAdded"
        Me.lbl_DateAdded.Size = New System.Drawing.Size(76, 16)
        Me.lbl_DateAdded.TabIndex = 107
        Me.lbl_DateAdded.Text = "Date Added"
        '
        'txt_StockName
        '
        Me.txt_StockName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Material_Name", True))
        Me.txt_StockName.Location = New System.Drawing.Point(1267, 132)
        Me.txt_StockName.Name = "txt_StockName"
        Me.txt_StockName.Size = New System.Drawing.Size(100, 20)
        Me.txt_StockName.TabIndex = 108
        '
        'date_added
        '
        Me.date_added.CustomFormat = ""
        Me.date_added.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMSysStocksDBBindingSource, "Date_Added", True))
        Me.date_added.Location = New System.Drawing.Point(1267, 91)
        Me.date_added.Name = "date_added"
        Me.date_added.ShowCheckBox = True
        Me.date_added.Size = New System.Drawing.Size(200, 20)
        Me.date_added.TabIndex = 109
        Me.date_added.Value = New Date(2021, 3, 30, 0, 0, 0, 0)
        '
        'lbl_StockName
        '
        Me.lbl_StockName.AutoSize = True
        Me.lbl_StockName.Location = New System.Drawing.Point(1178, 136)
        Me.lbl_StockName.Name = "lbl_StockName"
        Me.lbl_StockName.Size = New System.Drawing.Size(73, 16)
        Me.lbl_StockName.TabIndex = 110
        Me.lbl_StockName.Text = "Stock Name"
        '
        'lbl_Stock
        '
        Me.lbl_Stock.AutoSize = True
        Me.lbl_Stock.Location = New System.Drawing.Point(1214, 175)
        Me.lbl_Stock.Name = "lbl_Stock"
        Me.lbl_Stock.Size = New System.Drawing.Size(37, 16)
        Me.lbl_Stock.TabIndex = 111
        Me.lbl_Stock.Text = "Stock"
        '
        'txt_Stock
        '
        Me.txt_Stock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Stock", True))
        Me.txt_Stock.Location = New System.Drawing.Point(1267, 171)
        Me.txt_Stock.Name = "txt_Stock"
        Me.txt_Stock.Size = New System.Drawing.Size(36, 20)
        Me.txt_Stock.TabIndex = 112
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(1223, 214)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(28, 16)
        Me.lblSize.TabIndex = 113
        Me.lblSize.Text = "Size"
        '
        'cmb_Size
        '
        Me.cmb_Size.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Size", True))
        Me.cmb_Size.FormattingEnabled = True
        Me.cmb_Size.Items.AddRange(New Object() {"XXS", "XS", "S", "M", "L", "XL", "XXL"})
        Me.cmb_Size.Location = New System.Drawing.Point(1267, 207)
        Me.cmb_Size.Name = "cmb_Size"
        Me.cmb_Size.Size = New System.Drawing.Size(52, 23)
        Me.cmb_Size.TabIndex = 114
        '
        'lbl_Color
        '
        Me.lbl_Color.AutoSize = True
        Me.lbl_Color.Location = New System.Drawing.Point(1215, 254)
        Me.lbl_Color.Name = "lbl_Color"
        Me.lbl_Color.Size = New System.Drawing.Size(36, 16)
        Me.lbl_Color.TabIndex = 115
        Me.lbl_Color.Text = "Color"
        '
        'txt_Color
        '
        Me.txt_Color.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Color", True))
        Me.txt_Color.Location = New System.Drawing.Point(1267, 251)
        Me.txt_Color.Name = "txt_Color"
        Me.txt_Color.Size = New System.Drawing.Size(100, 20)
        Me.txt_Color.TabIndex = 116
        '
        'lbl_SellingPrice
        '
        Me.lbl_SellingPrice.AutoSize = True
        Me.lbl_SellingPrice.Location = New System.Drawing.Point(1181, 295)
        Me.lbl_SellingPrice.Name = "lbl_SellingPrice"
        Me.lbl_SellingPrice.Size = New System.Drawing.Size(70, 16)
        Me.lbl_SellingPrice.TabIndex = 117
        Me.lbl_SellingPrice.Text = "Selling Price"
        '
        'txt_SellingPrice
        '
        Me.txt_SellingPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Selling_Price", True))
        Me.txt_SellingPrice.Location = New System.Drawing.Point(1267, 295)
        Me.txt_SellingPrice.Name = "txt_SellingPrice"
        Me.txt_SellingPrice.Size = New System.Drawing.Size(100, 20)
        Me.txt_SellingPrice.TabIndex = 118
        '
        'lbl_UnitPrice
        '
        Me.lbl_UnitPrice.AutoSize = True
        Me.lbl_UnitPrice.Location = New System.Drawing.Point(1173, 342)
        Me.lbl_UnitPrice.Name = "lbl_UnitPrice"
        Me.lbl_UnitPrice.Size = New System.Drawing.Size(78, 16)
        Me.lbl_UnitPrice.TabIndex = 119
        Me.lbl_UnitPrice.Text = "Original Price"
        '
        'txt_OriginalPrice
        '
        Me.txt_OriginalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Unit_Price", True))
        Me.txt_OriginalPrice.Location = New System.Drawing.Point(1267, 342)
        Me.txt_OriginalPrice.Name = "txt_OriginalPrice"
        Me.txt_OriginalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txt_OriginalPrice.TabIndex = 120
        '
        'OMSysStocksDBBindingSource
        '
        Me.OMSysStocksDBBindingSource.DataMember = "OMSys_StocksDB"
        Me.OMSysStocksDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSysOrdersDBDataSet
        '
        Me.OMSysOrdersDBDataSet.DataSetName = "OMSysOrdersDBDataSet"
        Me.OMSysOrdersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'DateAddedDataGridViewTextBoxColumn
        '
        Me.DateAddedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date_Added"
        Me.DateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateAddedDataGridViewTextBoxColumn.Name = "DateAddedDataGridViewTextBoxColumn"
        Me.DateAddedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialNameDataGridViewTextBoxColumn
        '
        Me.MaterialNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaterialNameDataGridViewTextBoxColumn.DataPropertyName = "Material_Name"
        Me.MaterialNameDataGridViewTextBoxColumn.HeaderText = "Stock Name"
        Me.MaterialNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaterialNameDataGridViewTextBoxColumn.Name = "MaterialNameDataGridViewTextBoxColumn"
        Me.MaterialNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Width = 125
        '
        'SellingPriceDataGridViewTextBoxColumn
        '
        Me.SellingPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling_Price"
        DataGridViewCellStyle26.Format = "C2"
        Me.SellingPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.SellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price"
        Me.SellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SellingPriceDataGridViewTextBoxColumn.Name = "SellingPriceDataGridViewTextBoxColumn"
        Me.SellingPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SellingPriceDataGridViewTextBoxColumn.Width = 93
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price"
        DataGridViewCellStyle27.Format = "C2"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.UnitPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle27
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn.Width = 81
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
        'OMSys_StocksDBTableAdapter
        '
        Me.OMSys_StocksDBTableAdapter.ClearBeforeFill = True
        '
        'frmMainScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1484, 612)
        Me.Controls.Add(Me.txt_OriginalPrice)
        Me.Controls.Add(Me.lbl_UnitPrice)
        Me.Controls.Add(Me.txt_SellingPrice)
        Me.Controls.Add(Me.lbl_SellingPrice)
        Me.Controls.Add(Me.txt_Color)
        Me.Controls.Add(Me.lbl_Color)
        Me.Controls.Add(Me.cmb_Size)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.txt_Stock)
        Me.Controls.Add(Me.lbl_Stock)
        Me.Controls.Add(Me.lbl_StockName)
        Me.Controls.Add(Me.date_added)
        Me.Controls.Add(Me.txt_StockName)
        Me.Controls.Add(Me.lbl_DateAdded)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Selling_PriceLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnUpdateOrder)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMainScreen2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OMSys"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OMSysStocksDBBindingSource As BindingSource
    Friend WithEvents OMSys_StocksDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents Color As DataGridViewTextBoxColumn
    Friend WithEvents SellingPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblID As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lbl_DateAdded As Label
    Friend WithEvents txt_StockName As TextBox
    Friend WithEvents date_added As DateTimePicker
    Friend WithEvents lbl_StockName As Label
    Friend WithEvents lbl_Stock As Label
    Friend WithEvents txt_Stock As TextBox
    Friend WithEvents lblSize As Label
    Friend WithEvents cmb_Size As ComboBox
    Friend WithEvents lbl_Color As Label
    Friend WithEvents txt_Color As TextBox
    Friend WithEvents lbl_SellingPrice As Label
    Friend WithEvents txt_SellingPrice As TextBox
    Friend WithEvents lbl_UnitPrice As Label
    Friend WithEvents txt_OriginalPrice As TextBox
End Class

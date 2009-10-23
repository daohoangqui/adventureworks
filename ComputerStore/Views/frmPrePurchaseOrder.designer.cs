namespace ComputerStore.Views
{
    partial class frmPrePurchaseOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrePurchaseOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrePurchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.txtOrderNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtiOrderDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCustomerID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.ptnSave = new System.Windows.Forms.ToolStripButton();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ProductID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.txtLineTotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbProductID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtUnitPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtQuantity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkSolved = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.PrePurchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiOrderDate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudTotalAmount
            // 
            this.nudTotalAmount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.PrePurchaseOrderBindingSource, "TotalAmount", true));
            this.nudTotalAmount.Location = new System.Drawing.Point(330, 54);
            this.nudTotalAmount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudTotalAmount.Name = "nudTotalAmount";
            this.nudTotalAmount.Size = new System.Drawing.Size(114, 20);
            this.nudTotalAmount.TabIndex = 9;
            // 
            // txtOrderNumber
            // 
            // 
            // 
            // 
            this.txtOrderNumber.Border.Class = "TextBoxBorder";
            this.txtOrderNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrePurchaseOrderBindingSource, "OrderNumber", true));
            this.txtOrderNumber.Location = new System.Drawing.Point(101, 18);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(121, 20);
            this.txtOrderNumber.TabIndex = 13;
            // 
            // dtiOrderDate
            // 
            // 
            // 
            // 
            this.dtiOrderDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiOrderDate.ButtonDropDown.Visible = true;
            this.dtiOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.PrePurchaseOrderBindingSource, "OrderDate", true));
            this.dtiOrderDate.Location = new System.Drawing.Point(330, 16);
            // 
            // 
            // 
            this.dtiOrderDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiOrderDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtiOrderDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiOrderDate.MonthCalendar.DisplayMonth = new System.DateTime(2005, 8, 1, 0, 0, 0, 0);
            this.dtiOrderDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiOrderDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiOrderDate.MonthCalendar.TodayButtonVisible = true;
            this.dtiOrderDate.Name = "dtiOrderDate";
            this.dtiOrderDate.Size = new System.Drawing.Size(114, 20);
            this.dtiOrderDate.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSolved);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.cmbCustomerID);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.labelX7);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.dtiOrderDate);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Controls.Add(this.nudTotalAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 91);
            this.panel1.TabIndex = 1;
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DisplayMember = "Text";
            this.cmbCustomerID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.ItemHeight = 14;
            this.cmbCustomerID.Location = new System.Drawing.Point(101, 55);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(121, 20);
            this.cmbCustomerID.TabIndex = 25;
            this.cmbCustomerID.DataBindings.Add("SelectedValue",PrePurchaseOrderBindingSource,"CustomerID",true);
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(20, 54);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "Khách hàng:";
            // 
            // txtNote
            // 
            // 
            // 
            // 
            this.txtNote.Border.Class = "TextBoxBorder";
            this.txtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrePurchaseOrderBindingSource, "Note", true));
            this.txtNote.Location = new System.Drawing.Point(525, 14);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(238, 36);
            this.txtNote.TabIndex = 23;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(467, 20);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(52, 23);
            this.labelX7.TabIndex = 21;
            this.labelX7.Text = "Ghi chú:";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(249, 54);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "Tổng tiền:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(249, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Ngày hóa đơn:";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(20, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "Số hóa đơn:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.PrePurchaseOrderBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ptnSave});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // ptnSave
            // 
            this.ptnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ptnSave.Image = ((System.Drawing.Image)(resources.GetObject("ptnSave.Image")));
            this.ptnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ptnSave.Name = "ptnSave";
            this.ptnSave.Size = new System.Drawing.Size(23, 22);
            this.ptnSave.Text = "toolStripButton1";
            this.ptnSave.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dataGridViewX1);
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.DrawTitleBox = false;
            this.groupPanel1.Location = new System.Drawing.Point(0, 116);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupPanel1.Size = new System.Drawing.Size(784, 446);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Chi tiết đơn đặt hàng";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Quantity,
            this.UnitPrice,
            this.LineTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 58);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(778, 367);
            this.dataGridViewX1.TabIndex = 6;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.Name = "ProductID";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Đơn giá";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // LineTotal
            // 
            this.LineTotal.HeaderText = "Thành tiền";
            this.LineTotal.Name = "LineTotal";
            this.LineTotal.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX11);
            this.panel2.Controls.Add(this.labelX10);
            this.panel2.Controls.Add(this.labelX9);
            this.panel2.Controls.Add(this.labelX8);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtLineTotal);
            this.panel2.Controls.Add(this.cmbProductID);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 58);
            this.panel2.TabIndex = 5;
            // 
            // labelX11
            // 
            this.labelX11.Location = new System.Drawing.Point(583, 4);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 27;
            this.labelX11.Text = "Thành tiền";
            // 
            // labelX10
            // 
            this.labelX10.Location = new System.Drawing.Point(479, 1);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 26;
            this.labelX10.Text = "Đơn giá";
            // 
            // labelX9
            // 
            this.labelX9.Location = new System.Drawing.Point(380, 4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 25;
            this.labelX9.Text = "Số lượng";
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(42, 2);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 24;
            this.labelX8.Text = "Mã sản phẩm";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(694, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            // 
            // txtLineTotal
            // 
            // 
            // 
            // 
            this.txtLineTotal.Border.Class = "TextBoxBorder";
            this.txtLineTotal.Location = new System.Drawing.Point(577, 30);
            this.txtLineTotal.Name = "txtLineTotal";
            this.txtLineTotal.Size = new System.Drawing.Size(105, 20);
            this.txtLineTotal.TabIndex = 22;
            // 
            // cmbProductID
            // 
            this.cmbProductID.DisplayMember = "Text";
            this.cmbProductID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.ItemHeight = 14;
            this.cmbProductID.Location = new System.Drawing.Point(41, 30);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(337, 20);
            this.cmbProductID.TabIndex = 16;
            // 
            // txtUnitPrice
            // 
            // 
            // 
            // 
            this.txtUnitPrice.Border.Class = "TextBoxBorder";
            this.txtUnitPrice.Location = new System.Drawing.Point(477, 30);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(101, 20);
            this.txtUnitPrice.TabIndex = 20;
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.Border.Class = "TextBoxBorder";
            this.txtQuantity.Location = new System.Drawing.Point(377, 30);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(103, 20);
            this.txtQuantity.TabIndex = 18;
            // 
            // chkSolved
            // 
            this.chkSolved.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.PrePurchaseOrderBindingSource, "Solved", true));
            this.chkSolved.Location = new System.Drawing.Point(553, 56);
            this.chkSolved.Name = "chkSolved";
            this.chkSolved.Size = new System.Drawing.Size(27, 23);
            this.chkSolved.TabIndex = 27;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(467, 57);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 26;
            this.labelX6.Text = "Đã giải quyết:";
            // 
            // frmPrePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "frmPrePurchaseOrder";
            this.Text = "Don Dat Hang";
            this.Load += new System.EventHandler(this.frmPrePurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrePurchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiOrderDate)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTotalAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOrderNumber;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiOrderDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLineTotal;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbProductID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQuantity;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
        private System.Windows.Forms.BindingSource PrePurchaseOrderBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNote;
        private System.Windows.Forms.ToolStripButton ptnSave;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCustomerID;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkSolved;
        private DevComponents.DotNetBar.LabelX labelX6;


    }
}


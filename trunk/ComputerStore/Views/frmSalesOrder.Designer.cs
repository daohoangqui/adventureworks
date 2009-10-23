namespace ComputerStore.Views
{
    partial class frmSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RetailOrdeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.SalesOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.chkActive = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lb = new DevComponents.DotNetBar.LabelX();
            this.cmbEmployeeID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbPrePurchaseOrderHeaderID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtPrePurchaseOrderHeaderID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbCustomerID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.nudSubTotal = new System.Windows.Forms.NumericUpDown();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.dtiOrderDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgChiTietDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHangHoa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLoSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.nudThanhTien = new System.Windows.Forms.NumericUpDown();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cmbLoSX = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbSanPham = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.RetailOrdeBindingNavigator)).BeginInit();
            this.RetailOrdeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietDon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // RetailOrdeBindingNavigator
            // 
            this.RetailOrdeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.RetailOrdeBindingNavigator.BindingSource = this.SalesOrderBindingSource;
            this.RetailOrdeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.RetailOrdeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.RetailOrdeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnSave});
            this.RetailOrdeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.RetailOrdeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.RetailOrdeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.RetailOrdeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.RetailOrdeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.RetailOrdeBindingNavigator.Name = "RetailOrdeBindingNavigator";
            this.RetailOrdeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.RetailOrdeBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.RetailOrdeBindingNavigator.TabIndex = 0;
            this.RetailOrdeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.labelX10);
            this.panel1.Controls.Add(this.chkActive);
            this.panel1.Controls.Add(this.labelX9);
            this.panel1.Controls.Add(this.labelX8);
            this.panel1.Controls.Add(this.labelX7);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Controls.Add(this.cmbEmployeeID);
            this.panel1.Controls.Add(this.cmbPrePurchaseOrderHeaderID);
            this.panel1.Controls.Add(this.txtPrePurchaseOrderHeaderID);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.cmbCustomerID);
            this.panel1.Controls.Add(this.nudSubTotal);
            this.panel1.Controls.Add(this.nudTotal);
            this.panel1.Controls.Add(this.dtiOrderDate);
            this.panel1.Controls.Add(this.nudDiscount);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 146);
            this.panel1.TabIndex = 1;
            // 
            // labelX10
            // 
            this.labelX10.Location = new System.Drawing.Point(535, 54);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(78, 23);
            this.labelX10.TabIndex = 47;
            this.labelX10.Text = "Ngưng theo dõi:";
            // 
            // chkActive
            // 
            this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.SalesOrderBindingSource, "Active", true));
            this.chkActive.Location = new System.Drawing.Point(621, 54);
            this.chkActive.Name = "chkActive";
            this.chkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkActive.Size = new System.Drawing.Size(19, 23);
            this.chkActive.TabIndex = 46;
            // 
            // labelX9
            // 
            this.labelX9.Location = new System.Drawing.Point(508, 16);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(105, 23);
            this.labelX9.TabIndex = 45;
            this.labelX9.Text = "Nhân viên bán hàng:";
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(239, 112);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(73, 23);
            this.labelX8.TabIndex = 44;
            this.labelX8.Text = "Đơn đặt hàng:";
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(239, 70);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(60, 23);
            this.labelX7.TabIndex = 43;
            this.labelX7.Text = "Địa chỉ:";
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(239, 44);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(60, 23);
            this.labelX6.TabIndex = 42;
            this.labelX6.Text = "Điện thoại:";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(239, 18);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(64, 23);
            this.labelX5.TabIndex = 41;
            this.labelX5.Text = "Khách hàng:";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(19, 114);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(60, 23);
            this.labelX4.TabIndex = 40;
            this.labelX4.Text = "Tổng tiền:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(19, 91);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(60, 23);
            this.labelX3.TabIndex = 39;
            this.labelX3.Text = "Chiết khấu:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(19, 66);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 20);
            this.labelX2.TabIndex = 38;
            this.labelX2.Text = "Tiền hàng:";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(19, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 23);
            this.labelX1.TabIndex = 37;
            this.labelX1.Text = "Ngày hóa đơn:";
            // 
            // lb
            // 
            this.lb.Location = new System.Drawing.Point(19, 18);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(60, 23);
            this.lb.TabIndex = 36;
            this.lb.Text = "Số hóa đơn:";
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.SalesOrderBindingSource, "EmployeeID", true));
            this.cmbEmployeeID.DisplayMember = "Text";
            this.cmbEmployeeID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.ItemHeight = 14;
            this.cmbEmployeeID.Location = new System.Drawing.Point(619, 18);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(145, 20);
            this.cmbEmployeeID.TabIndex = 33;
            // 
            // cmbPrePurchaseOrderHeaderID
            // 
            this.cmbPrePurchaseOrderHeaderID.DisplayMember = "Text";
            this.cmbPrePurchaseOrderHeaderID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPrePurchaseOrderHeaderID.FormattingEnabled = true;
            this.cmbPrePurchaseOrderHeaderID.ItemHeight = 14;
            this.cmbPrePurchaseOrderHeaderID.Location = new System.Drawing.Point(382, 115);
            this.cmbPrePurchaseOrderHeaderID.Name = "cmbPrePurchaseOrderHeaderID";
            this.cmbPrePurchaseOrderHeaderID.Size = new System.Drawing.Size(83, 20);
            this.cmbPrePurchaseOrderHeaderID.TabIndex = 31;
            // 
            // txtPrePurchaseOrderHeaderID
            // 
            // 
            // 
            // 
            this.txtPrePurchaseOrderHeaderID.Border.Class = "TextBoxBorder";
            this.txtPrePurchaseOrderHeaderID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrderBindingSource, "PrePurchaseOrderHeaderID", true));
            this.txtPrePurchaseOrderHeaderID.Location = new System.Drawing.Point(318, 115);
            this.txtPrePurchaseOrderHeaderID.Name = "txtPrePurchaseOrderHeaderID";
            this.txtPrePurchaseOrderHeaderID.ReadOnly = true;
            this.txtPrePurchaseOrderHeaderID.Size = new System.Drawing.Size(62, 20);
            this.txtPrePurchaseOrderHeaderID.TabIndex = 30;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Location = new System.Drawing.Point(318, 44);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 20);
            this.txtPhone.TabIndex = 28;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Location = new System.Drawing.Point(318, 70);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 41);
            this.txtAddress.TabIndex = 26;
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.SalesOrderBindingSource, "CustomerID", true));
            this.cmbCustomerID.DisplayMember = "Text";
            this.cmbCustomerID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.ItemHeight = 14;
            this.cmbCustomerID.Location = new System.Drawing.Point(318, 18);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(147, 20);
            this.cmbCustomerID.TabIndex = 22;
            // 
            // nudSubTotal
            // 
            this.nudSubTotal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.SalesOrderBindingSource, "SubTotal", true));
            this.nudSubTotal.Location = new System.Drawing.Point(104, 66);
            this.nudSubTotal.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudSubTotal.Name = "nudSubTotal";
            this.nudSubTotal.Size = new System.Drawing.Size(104, 20);
            this.nudSubTotal.TabIndex = 21;
            // 
            // nudTotal
            // 
            this.nudTotal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.SalesOrderBindingSource, "TotalAmount", true));
            this.nudTotal.Location = new System.Drawing.Point(104, 117);
            this.nudTotal.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(104, 20);
            this.nudTotal.TabIndex = 19;
            // 
            // dtiOrderDate
            // 
            // 
            // 
            // 
            this.dtiOrderDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiOrderDate.ButtonDropDown.Visible = true;
            this.dtiOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.SalesOrderBindingSource, "OrderDate", true));
            this.dtiOrderDate.Location = new System.Drawing.Point(104, 42);
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
            this.dtiOrderDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 10, 1, 0, 0, 0, 0);
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
            this.dtiOrderDate.Size = new System.Drawing.Size(104, 20);
            this.dtiOrderDate.TabIndex = 17;
            // 
            // nudDiscount
            // 
            this.nudDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.SalesOrderBindingSource, "Discount", true));
            this.nudDiscount.Location = new System.Drawing.Point(104, 91);
            this.nudDiscount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(104, 20);
            this.nudDiscount.TabIndex = 14;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrderBindingSource, "OrderNumber", true));
            this.txtOrderNumber.Location = new System.Drawing.Point(104, 18);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(104, 20);
            this.txtOrderNumber.TabIndex = 10;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgChiTietDon);
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 171);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(784, 391);
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
            this.groupPanel1.Text = "Chi tiết đơn";
            // 
            // dgChiTietDon
            // 
            this.dgChiTietDon.AllowUserToAddRows = false;
            this.dgChiTietDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHangHoa,
            this.colLoSX,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChiTietDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgChiTietDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChiTietDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgChiTietDon.Location = new System.Drawing.Point(0, 62);
            this.dgChiTietDon.Name = "dgChiTietDon";
            this.dgChiTietDon.Size = new System.Drawing.Size(778, 308);
            this.dgChiTietDon.TabIndex = 3;
            // 
            // colMaHangHoa
            // 
            this.colMaHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaHangHoa.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaHangHoa.HeaderText = "Sản Phẩm";
            this.colMaHangHoa.Name = "colMaHangHoa";
            this.colMaHangHoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaHangHoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colLoSX
            // 
            this.colLoSX.HeaderText = "Lô sản xuất";
            this.colLoSX.Name = "colLoSX";
            this.colLoSX.ReadOnly = true;
            this.colLoSX.Width = 150;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX15);
            this.panel2.Controls.Add(this.labelX14);
            this.panel2.Controls.Add(this.labelX13);
            this.panel2.Controls.Add(this.labelX12);
            this.panel2.Controls.Add(this.labelX11);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.nudThanhTien);
            this.panel2.Controls.Add(this.nudDonGia);
            this.panel2.Controls.Add(this.nudSoLuong);
            this.panel2.Controls.Add(this.cmbLoSX);
            this.panel2.Controls.Add(this.cmbSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 62);
            this.panel2.TabIndex = 2;
            // 
            // labelX15
            // 
            this.labelX15.Location = new System.Drawing.Point(578, 4);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(105, 23);
            this.labelX15.TabIndex = 52;
            this.labelX15.Text = "Thành tiền";
            // 
            // labelX14
            // 
            this.labelX14.Location = new System.Drawing.Point(478, 4);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(105, 23);
            this.labelX14.TabIndex = 51;
            this.labelX14.Text = "Đơn giá";
            // 
            // labelX13
            // 
            this.labelX13.Location = new System.Drawing.Point(377, 4);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(105, 23);
            this.labelX13.TabIndex = 50;
            this.labelX13.Text = "Số lượng";
            // 
            // labelX12
            // 
            this.labelX12.Location = new System.Drawing.Point(236, 4);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(105, 23);
            this.labelX12.TabIndex = 49;
            this.labelX12.Text = "Lô sản xuất";
            // 
            // labelX11
            // 
            this.labelX11.Location = new System.Drawing.Point(48, 4);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(105, 23);
            this.labelX11.TabIndex = 48;
            this.labelX11.Text = "Sản phẩm";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(694, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            // 
            // nudThanhTien
            // 
            this.nudThanhTien.Location = new System.Drawing.Point(579, 30);
            this.nudThanhTien.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudThanhTien.Name = "nudThanhTien";
            this.nudThanhTien.Size = new System.Drawing.Size(104, 20);
            this.nudThanhTien.TabIndex = 42;
            // 
            // nudDonGia
            // 
            this.nudDonGia.Location = new System.Drawing.Point(478, 30);
            this.nudDonGia.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(100, 20);
            this.nudDonGia.TabIndex = 41;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(377, 30);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(100, 20);
            this.nudSoLuong.TabIndex = 36;
            // 
            // cmbLoSX
            // 
            this.cmbLoSX.DisplayMember = "Text";
            this.cmbLoSX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoSX.FormattingEnabled = true;
            this.cmbLoSX.ItemHeight = 14;
            this.cmbLoSX.Location = new System.Drawing.Point(230, 30);
            this.cmbLoSX.Name = "cmbLoSX";
            this.cmbLoSX.Size = new System.Drawing.Size(147, 20);
            this.cmbLoSX.TabIndex = 36;
            // 
            // cmbSanPham
            // 
            this.cmbSanPham.DisplayMember = "Text";
            this.cmbSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSanPham.FormattingEnabled = true;
            this.cmbSanPham.ItemHeight = 14;
            this.cmbSanPham.Location = new System.Drawing.Point(48, 30);
            this.cmbSanPham.Name = "cmbSanPham";
            this.cmbSanPham.Size = new System.Drawing.Size(181, 20);
            this.cmbSanPham.TabIndex = 36;
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "toolStripButton1";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RetailOrdeBindingNavigator);
            this.Name = "frmSalesOrder";
            this.Text = "Don Ban Hang";
            this.Load += new System.EventHandler(this.frmSalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RetailOrdeBindingNavigator)).EndInit();
            this.RetailOrdeBindingNavigator.ResumeLayout(false);
            this.RetailOrdeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietDon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudThanhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator RetailOrdeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiOrderDate;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.NumericUpDown nudSubTotal;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCustomerID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrePurchaseOrderHeaderID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPrePurchaseOrderHeaderID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbEmployeeID;
        private DevComponents.DotNetBar.LabelX lb;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkActive;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgChiTietDon;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.NumericUpDown nudThanhTien;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLoSX;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSanPham;
        private System.Windows.Forms.BindingSource SalesOrderBindingSource;
        private System.Windows.Forms.ToolStripButton btnSave;

    }
}
namespace ComputerStore.Views
{
    partial class frmTest
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
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label hiredDateLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label departmentIDLabel;
            System.Windows.Forms.Label activeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.computerStoreDataSet = new ComputerStore.Data.ComputerStoreDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ComputerStore.Data.ComputerStoreDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new ComputerStore.Data.ComputerStoreDataSetTableAdapters.TableAdapterManager();
            this.employeeAddressTableAdapter = new ComputerStore.Data.ComputerStoreDataSetTableAdapters.EmployeeAddressTableAdapter();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.hiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.departmentIDTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.employeeAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeAddressDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeIDLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            hiredDateLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            departmentIDLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAddressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(61, 31);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 1;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(61, 57);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(61, 83);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(61, 109);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(61, 135);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(61, 161);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(375, 28);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 13;
            birthDateLabel.Text = "Birth Date:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(375, 53);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 15;
            genderLabel.Text = "Gender:";
            // 
            // hiredDateLabel
            // 
            hiredDateLabel.AutoSize = true;
            hiredDateLabel.Location = new System.Drawing.Point(375, 80);
            hiredDateLabel.Name = "hiredDateLabel";
            hiredDateLabel.Size = new System.Drawing.Size(61, 13);
            hiredDateLabel.TabIndex = 17;
            hiredDateLabel.Text = "Hired Date:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(375, 105);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(39, 13);
            salaryLabel.TabIndex = 19;
            salaryLabel.Text = "Salary:";
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Location = new System.Drawing.Point(375, 131);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(79, 13);
            departmentIDLabel.TabIndex = 21;
            departmentIDLabel.Text = "Department ID:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(375, 159);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(40, 13);
            activeLabel.TabIndex = 23;
            activeLabel.Text = "Active:";
            // 
            // computerStoreDataSet
            // 
            this.computerStoreDataSet.DataSetName = "ComputerStoreDataSet";
            this.computerStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.computerStoreDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.EmployeeAddressTableAdapter = this.employeeAddressTableAdapter;
            this.tableAdapterManager.EmployeeDepartmentHistoryTableAdapter = null;
            this.tableAdapterManager.EmployeePayHistoryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.PrePurchaseOrderDetailTableAdapter = null;
            this.tableAdapterManager.PrePurchaseOrderHeaderTableAdapter = null;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductDescriptionTableAdapter = null;
            this.tableAdapterManager.ProductPhotoTableAdapter = null;
            this.tableAdapterManager.ProductSizeTableAdapter = null;
            this.tableAdapterManager.ProductSubCategoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderDetailTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderHeaderTableAdapter = null;
            this.tableAdapterManager.RetailOrderDetailTableAdapter = null;
            this.tableAdapterManager.RetailOrderHeaderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComputerStore.Data.ComputerStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorAddressTableAdapter = null;
            this.tableAdapterManager.VendorContactTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // employeeAddressTableAdapter
            // 
            this.employeeAddressTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeBindingNavigatorSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(712, 25);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeeBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(146, 28);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.employeeIDTextBox.TabIndex = 2;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(146, 54);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(146, 80);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(146, 106);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(146, 132);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(146, 158);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 12;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(460, 24);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateDateTimePicker.TabIndex = 14;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(460, 50);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 16;
            // 
            // hiredDateDateTimePicker
            // 
            this.hiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "HiredDate", true));
            this.hiredDateDateTimePicker.Location = new System.Drawing.Point(460, 76);
            this.hiredDateDateTimePicker.Name = "hiredDateDateTimePicker";
            this.hiredDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.hiredDateDateTimePicker.TabIndex = 18;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(460, 102);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.salaryTextBox.TabIndex = 20;
            // 
            // departmentIDTextBox
            // 
            this.departmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "DepartmentID", true));
            this.departmentIDTextBox.Location = new System.Drawing.Point(460, 128);
            this.departmentIDTextBox.Name = "departmentIDTextBox";
            this.departmentIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.departmentIDTextBox.TabIndex = 22;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeeBindingSource, "Active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(460, 154);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activeCheckBox.TabIndex = 24;
            this.activeCheckBox.Text = "checkBox1";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // employeeAddressBindingSource
            // 
            this.employeeAddressBindingSource.DataMember = "FK_EmployeeAddress_Employee";
            this.employeeAddressBindingSource.DataSource = this.employeeBindingSource;
            // 
            // employeeAddressDataGridView
            // 
            this.employeeAddressDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeAddressDataGridView.AutoGenerateColumns = false;
            this.employeeAddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeAddressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.employeeAddressDataGridView.DataSource = this.employeeAddressBindingSource;
            this.employeeAddressDataGridView.Location = new System.Drawing.Point(12, 184);
            this.employeeAddressDataGridView.Name = "employeeAddressDataGridView";
            this.employeeAddressDataGridView.Size = new System.Drawing.Size(688, 351);
            this.employeeAddressDataGridView.TabIndex = 25;
            this.employeeAddressDataGridView.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeAdressID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeAdressID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 547);
            this.Controls.Add(this.employeeAddressDataGridView);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(hiredDateLabel);
            this.Controls.Add(this.hiredDateDateTimePicker);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(departmentIDLabel);
            this.Controls.Add(this.departmentIDTextBox);
            this.Controls.Add(activeLabel);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAddressDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComputerStore.Data.ComputerStoreDataSet computerStoreDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ComputerStore.Data.ComputerStoreDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private ComputerStore.Data.ComputerStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private ComputerStore.Data.ComputerStoreDataSetTableAdapters.EmployeeAddressTableAdapter employeeAddressTableAdapter;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.DateTimePicker hiredDateDateTimePicker;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox departmentIDTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.BindingSource employeeAddressBindingSource;
        private System.Windows.Forms.DataGridView employeeAddressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;


    }
}
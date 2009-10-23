using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComputerStore.Controller;

namespace ComputerStore.Views
{
    public partial class frmSalesOrder : DevComponents.DotNetBar.Office2007Form
    {
        SalesOrderController controller = null;
        CustomerController customerController = null;
        EmployeeController employeeController = null;

        public frmSalesOrder()
        {
            InitializeComponent();
            controller = new SalesOrderController();
            customerController = new CustomerController();
            employeeController = new EmployeeController();
            controller.napDuLieu(this.SalesOrderBindingSource);
        }

        private void frmSalesOrder_Load(object sender, EventArgs e)
        {
            customerController.hienThiComboBox(this.cmbCustomerID);
            employeeController.hienThiComboBox(this.cmbEmployeeID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.SalesOrderBindingSource.EndEdit();
            controller.luuThayDoi();
        }
    }
}

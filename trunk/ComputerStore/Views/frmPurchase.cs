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
    public partial class frmPurchase : DevComponents.DotNetBar.Office2007Form
    {
        PurchaseOrderController purchaseController = new PurchaseOrderController();
        VendorController vendorController = new VendorController();
        EmployeeController employeeController = new EmployeeController();
        public frmPurchase()
        {
            InitializeComponent();
            purchaseController.napDuLieu(PurchaseOrderHeaderBindingSource, PurchaseOrderDetailBindingSource);
            vendorController.hienThiComboBox(this.cmbVendor);
            employeeController.hienThiComboBox(this.cmbEmployee);
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerStoreDataSet.PurchaseOrderHeader' table. You can move, or remove it, as needed.
            //this.purchaseOrderHeaderTableAdapter.Fill(this.computerStoreDataSet.PurchaseOrderHeader);

        }
    }
}

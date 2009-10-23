using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Views
{
    public partial class frmProduct : DevComponents.DotNetBar.Office2007Form
    {
        ComputerStore.Controller.ProductController productController = new ComputerStore.Controller.ProductController();
        ComputerStore.Controller.ProductSubCategoryController productSubCategoryController = new ComputerStore.Controller.ProductSubCategoryController();
        ComputerStore.Controller.ProductCategoryController productCategoryController = new ComputerStore.Controller.ProductCategoryController();
        ComputerStore.Controller.VendorController vendorController = new ComputerStore.Controller.VendorController();
        public frmProduct()
        {
            InitializeComponent();
            productController.FillDataIntoBindingSource(this.bdProduct);        
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            this.cmVendorID.SelectedIndexChanged += new EventHandler(cmVendorID_SelectedIndexChanged);
            vendorController.hienThiComboBox(this.cmVendorID);
        }

        void cmVendorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bdVendor == null)
            {
                MessageBox.Show("bdVendor is null");
                return;
            }
        }

     
    }
}

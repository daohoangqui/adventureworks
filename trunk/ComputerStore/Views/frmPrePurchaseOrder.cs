using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComputerStore.Controller;

namespace ComputerStore.Views
{
    public partial class frmPrePurchaseOrder : DevComponents.DotNetBar.Office2007Form
    {
        PrepurchaseOrderController controller = null;
        public frmPrePurchaseOrder()
        {
            InitializeComponent();
            controller = new PrepurchaseOrderController();
            controller.napDuLieu(this.PrePurchaseOrderBindingSource);
        }

        private void frmPrePurchaseOrder_Load(object sender, EventArgs e)
        {
            controller.layKhachHang(this.cmbCustomerID);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.PrePurchaseOrderBindingSource.EndEdit();
            controller.luuThayDoi();
            
        }
    }
}
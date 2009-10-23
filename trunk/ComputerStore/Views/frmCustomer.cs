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
    public partial class frmCustomer : DevComponents.DotNetBar.Office2007Form
    {
        ComputerStore.Controller.CustomerController controller = null;
        public frmCustomer()
        {
            InitializeComponent();
            controller = new ComputerStore.Controller.CustomerController();
            controller.napDuLieu(this.customerBindingSource);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            controller.luuThayDoi();
        }
    }
}

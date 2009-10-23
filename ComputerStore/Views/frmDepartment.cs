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
    public partial class frmDepartment : DevComponents.DotNetBar.Office2007Form
    {
        ComputerStore.Controller.DepartmentController controller = new ComputerStore.Controller.DepartmentController();
        public frmDepartment()
        {
            InitializeComponent();
            controller.napDuLieu(this.DepartmentBindingSource);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.DepartmentBindingSource.EndEdit();
            controller.luuThayDoi();
        }
    }
}

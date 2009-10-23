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
    public partial class frmEmployee : DevComponents.DotNetBar.Office2007Form
    {
        ComputerStore.Controller.EmployeeController EmployeeController = new ComputerStore.Controller.EmployeeController();
        ComputerStore.Controller.DepartmentController DepartmentController = new ComputerStore.Controller.DepartmentController();
        public frmEmployee()
        {
            InitializeComponent();
            EmployeeController.napDuLieu(this.EmployeeBindingSource, this.EmployeeAddressBindingSource, this.EmployeePayHistoryBindingSource, this.EmployeeDepartmentBindingSource);
            DepartmentController.hienThiComboBox(this.cmbPhongBan);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            // them LastName vao 
            string temp = txtHovaTen.Text.Trim();
            string name = temp.Substring((temp.LastIndexOf(" ")) + 1);
            txtLastName.Text = name;
      
            this.EmployeeBindingSource.EndEdit();
            this.EmployeeDepartmentBindingSource.EndEdit();
            this.EmployeePayHistoryBindingSource.EndEdit();
            this.EmployeeAddressBindingSource.EndEdit();
            EmployeeController.luuThayDoi();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}

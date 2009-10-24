using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComputerStore.Data;
namespace ComputerStore.Views
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }


        private void frmTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerStoreDataSet.EmployeeAddress' table. You can move, or remove it, as needed.
            this.employeeAddressTableAdapter.Fill(this.computerStoreDataSet.EmployeeAddress);
            // TODO: This line of code loads data into the 'computerStoreDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.computerStoreDataSet.Employee);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.computerStoreDataSet);
            //return;

            ComputerStoreDataSet.EmployeeAddressDataTable deletedEmployeeAddress = (ComputerStoreDataSet.EmployeeAddressDataTable)computerStoreDataSet.EmployeeAddress.GetChanges(DataRowState.Deleted);
            ComputerStoreDataSet.EmployeeAddressDataTable newEmployeeAddress = (ComputerStoreDataSet.EmployeeAddressDataTable)computerStoreDataSet.EmployeeAddress.GetChanges(DataRowState.Added);
            ComputerStoreDataSet.EmployeeAddressDataTable modifiedEmployeeAddress = (ComputerStoreDataSet.EmployeeAddressDataTable)computerStoreDataSet.EmployeeAddress.GetChanges(DataRowState.Modified);

            ComputerStoreDataSet.EmployeeDataTable deletedEmployee = (ComputerStoreDataSet.EmployeeDataTable)computerStoreDataSet.Employee.GetChanges(DataRowState.Deleted);
            ComputerStoreDataSet.EmployeeDataTable newEmployee = (ComputerStoreDataSet.EmployeeDataTable)computerStoreDataSet.Employee.GetChanges(DataRowState.Added);
            ComputerStoreDataSet.EmployeeDataTable modifiedEmployee = (ComputerStoreDataSet.EmployeeDataTable)computerStoreDataSet.Employee.GetChanges(DataRowState.Modified);

            try
            {
                // Them cac dong trong bang cha
                if (newEmployee != null)
                {
                    employeeTableAdapter.Update(newEmployee);
                }
                // xoa cac dong trong bang con
                if (deletedEmployeeAddress != null)
                {
                    employeeAddressTableAdapter.Update(deletedEmployeeAddress);
                    MessageBox.Show("Da xoa cac dong trong bang con roi do pa");
                }
                this.tableAdapterManager.UpdateAll(computerStoreDataSet);
                // Xoa cac dong trong bang cha
                if (deletedEmployee != null)
                {

                    employeeTableAdapter.Update(deletedEmployee);
                }

                // them dong trong bang con
                if (newEmployeeAddress != null)
                {
                    employeeAddressTableAdapter.Update(newEmployeeAddress);
                }
                // sua bang con
                if (modifiedEmployeeAddress != null)
                {
                    employeeAddressTableAdapter.Update(modifiedEmployeeAddress);
                }
                computerStoreDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("there are an error: " + ex.ToString());
            }
            finally
            {
                if (deletedEmployeeAddress != null)
                {
                    deletedEmployeeAddress.Dispose();
                }
                if (newEmployeeAddress != null)
                {
                    newEmployeeAddress.Dispose();
                }
                if (modifiedEmployeeAddress != null)
                {
                    modifiedEmployeeAddress.Dispose();
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //this.employeeAddressDataGridView.se
        }
    }
}

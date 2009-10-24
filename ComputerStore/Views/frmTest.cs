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

            ComputerStoreDataSet.EmployeeAddressDataTable deletedChildRecords = (ComputerStoreDataSet.EmployeeAddressDataTable)computerStoreDataSet.EmployeeAddress.GetChanges(DataRowState.Deleted);
            ComputerStoreDataSet.EmployeeAddressDataTable newChildRecords = (ComputerStoreDataSet.EmployeeAddressDataTable)computerStoreDataSet.EmployeeAddress.GetChanges(DataRowState.Added);
            ComputerStoreDataSet.EmployeeAddressDataTable modifiedChildRecords = (ComputerStoreDataSet.EmployeeAddressDataTable)computerStoreDataSet.EmployeeAddress.GetChanges(DataRowState.Modified);

            try
            {
                // xoa cac dong trong bang con
                if (deletedChildRecords != null)
                {
                    employeeAddressTableAdapter.Update(deletedChildRecords);
                }
                // update (them xoa sua) bang cha
                employeeTableAdapter.Update(computerStoreDataSet.Employee);
                // them dong trong bang con
                if (newChildRecords != null)
                {
                    employeeAddressTableAdapter.Update(newChildRecords);
                }
                // sua bang con
                if (modifiedChildRecords != null)
                {
                    employeeAddressTableAdapter.Update(modifiedChildRecords);
                }
                computerStoreDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("there are an error: " + ex.ToString());
            }
            finally
            {
                if (deletedChildRecords != null)
                {
                    deletedChildRecords.Dispose();
                }
                if (newChildRecords != null)
                {
                    newChildRecords.Dispose();
                }
                if (modifiedChildRecords != null)
                {
                    modifiedChildRecords.Dispose();
                }
            }
        }
    }
}

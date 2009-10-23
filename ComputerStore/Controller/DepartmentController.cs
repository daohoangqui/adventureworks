using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;

namespace ComputerStore.Controller
{
    class DepartmentController
    {
        ComputerStore.Data.ComputerStoreDataSet dataset = null;
        TableAdapterManager tableAdapterManager = null;
        DepartmentTableAdapter departmentTableAdapter = null;
        public DepartmentController()
        {
            dataset = new ComputerStore.Data.ComputerStoreDataSet();
            tableAdapterManager = new TableAdapterManager();
            departmentTableAdapter = new DepartmentTableAdapter();
            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            this.tableAdapterManager.DepartmentTableAdapter = departmentTableAdapter;
        }
        public void napDuLieu(BindingSource bs)
        {
            bs.DataSource = dataset;
            bs.DataMember = "Department";
            departmentTableAdapter.Fill(dataset.Department);
        }
        public void hienThiComboBox(ComboBox cmb)
        {
            departmentTableAdapter.Fill(dataset.Department);
            cmb.DataSource = dataset.Department;
            cmb.DisplayMember = "DepartmentName";
            cmb.ValueMember = "DepartmentID";
        }

        public void luuThayDoi()
        {
            tableAdapterManager.UpdateAll(this.dataset);
        }
    }
}

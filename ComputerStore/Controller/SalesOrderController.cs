using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComputerStore.Data;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;

namespace ComputerStore.Controller
{
    public class SalesOrderController
    {
        ComputerStoreDataSet dataset = null;
        TableAdapterManager manager = null;
        RetailOrderHeaderTableAdapter salesOrderHeaderAdapter = null;

        public SalesOrderController()
        {
            dataset = new ComputerStore.Data.ComputerStoreDataSet();
            manager = new TableAdapterManager();
            salesOrderHeaderAdapter = new RetailOrderHeaderTableAdapter();
            manager.RetailOrderHeaderTableAdapter = salesOrderHeaderAdapter;
        }
        public void napDuLieu(System.Windows.Forms.BindingSource bs)
        {
            bs.DataSource = dataset;
            bs.DataMember = "RetailOrderHeader";
            salesOrderHeaderAdapter.Fill(dataset.RetailOrderHeader);
        }

        public void luuThayDoi()
        {
            manager.UpdateAll(dataset);
        }

        public void layNhanVienBanHang(DevComponents.DotNetBar.Controls.ComboBoxEx cmb)
        {
            EmployeeTableAdapter temp = new EmployeeTableAdapter();
            temp.Fill(dataset.Employee);
            cmb.DataSource = dataset.Employee;
            cmb.DisplayMember = "FullName";
            cmb.ValueMember = "EmployeeID";
        }
    }
}

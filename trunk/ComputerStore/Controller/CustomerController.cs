using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComputerStore.Data;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;
using System.Windows.Forms;

namespace ComputerStore.Controller
{
    public class CustomerController
    {
        ComputerStoreDataSet dataset = null;
        TableAdapterManager manager = null;
        CustomerTableAdapter customerAdapter = null;

        public CustomerController()
        {
            dataset = new ComputerStore.Data.ComputerStoreDataSet();
            manager = new TableAdapterManager();
            customerAdapter = new CustomerTableAdapter();
            manager.CustomerTableAdapter = customerAdapter;
        }
        public void napDuLieu(System.Windows.Forms.BindingSource bs)
        {
            bs.DataSource = dataset;
            bs.DataMember = "Customer";
            customerAdapter.Fill(dataset.Customer);
        }

        public void luuThayDoi()
        {
            manager.UpdateAll(dataset);
        }

        public void hienThiComboBox(ComboBox cmb)
        {
            customerAdapter.Fill(dataset.Customer);
            cmb.DataSource = dataset.Customer;
            cmb.DisplayMember = "CustomerName";
            cmb.ValueMember = "CustomerID";
        }
    }
}

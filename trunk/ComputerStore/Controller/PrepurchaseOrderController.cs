using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComputerStore.Data;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;

namespace ComputerStore.Controller
{
    public class PrepurchaseOrderController
    {
        ComputerStoreDataSet dataset = null;
        TableAdapterManager manager = null;
        PrePurchaseOrderHeaderTableAdapter headerTableAdapter = null;
        public PrepurchaseOrderController()
        {
            dataset = new ComputerStoreDataSet();
            manager = new TableAdapterManager();
            headerTableAdapter = new PrePurchaseOrderHeaderTableAdapter();
            manager.PrePurchaseOrderHeaderTableAdapter = headerTableAdapter;
        }

        public void napDuLieu(System.Windows.Forms.BindingSource bs)
        {
            bs.DataSource = dataset;
            bs.DataMember = "PrePurchaseOrderHeader";
            headerTableAdapter.Fill(dataset.PrePurchaseOrderHeader);
        }
        public void luuThayDoi()
        {
            manager.UpdateAll(dataset);
        }

        public void layKhachHang(DevComponents.DotNetBar.Controls.ComboBoxEx cmb)
        {
            CustomerTableAdapter temp = new CustomerTableAdapter();
            manager.CustomerTableAdapter = temp;
            temp.Fill(dataset.Customer);
            cmb.DataSource = dataset.Customer;
            cmb.DisplayMember = "CustomerName";
            cmb.ValueMember = "CustomerID";
        }
    }
}

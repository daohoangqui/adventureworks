using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;

namespace ComputerStore.Controller
{
    class PurchaseOrderController
    {
        ComputerStore.Data.ComputerStoreDataSet dataset = null;
        TableAdapterManager tableAdapterManager = null;
        PurchaseOrderHeaderTableAdapter purchaseTableAdapter = null;
        PurchaseOrderDetailTableAdapter purchaseDetailTableAdapter = null;

        public PurchaseOrderController()
        {
            dataset = new ComputerStore.Data.ComputerStoreDataSet();
            tableAdapterManager = new TableAdapterManager();

            purchaseTableAdapter = new PurchaseOrderHeaderTableAdapter();
            purchaseDetailTableAdapter = new PurchaseOrderDetailTableAdapter();

            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            
            this.tableAdapterManager.PurchaseOrderHeaderTableAdapter = purchaseTableAdapter;
            this.tableAdapterManager.PurchaseOrderDetailTableAdapter = purchaseDetailTableAdapter;
        }
        public void napDuLieu(BindingSource purchase, BindingSource purchaseDetail)
        {
            purchase.DataSource = dataset;
            purchase.DataMember = "PurchaseOrderHeader";
            purchaseTableAdapter.Fill(dataset.PurchaseOrderHeader);

            purchaseDetail.DataSource = purchase;
            purchaseDetail.DataMember = "FK_PurchaseOrderDetail_PurchaseOrderHeader";
            purchaseDetailTableAdapter.Fill(dataset.PurchaseOrderDetail);
        }
        public void luuThayDoi()
        {
            tableAdapterManager.UpdateAll(this.dataset);
        }
    }
}

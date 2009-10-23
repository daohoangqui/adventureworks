using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComputerStore.Data;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;
using System.Windows.Forms;

namespace ComputerStore.Controller
{
    class ProductController
    {
        ComputerStoreDataSet computerStoreDataSet = null;
        TableAdapterManager tableAdapterManager = null;
        ProductTableAdapter producTableAdapter = null;
        public ProductController()
        {
            this.computerStoreDataSet = new ComputerStoreDataSet();
            this.tableAdapterManager = new TableAdapterManager();
            this.producTableAdapter = new ProductTableAdapter();

            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            this.tableAdapterManager.ProductTableAdapter = producTableAdapter;
        }

        /// <summary>
        /// Lay du lieu trong bang Product rui Fill vao pdProduct
        /// </summary>
        /// <param name="bs"></param>
        public void FillDataIntoBindingSource(BindingSource bs)
        {
            try
            {
                bs.DataSource = computerStoreDataSet;
                bs.DataMember = "Product";
                producTableAdapter.Fill(computerStoreDataSet.Product);
            }
            catch (ArgumentException ex)
            {
                //this.cmbProductCategoryID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdProduct, "ProductCategoryID", true));
                MessageBox.Show(ex.Message);
            }
        }
    }



}

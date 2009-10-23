using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComputerStore.Data;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;

namespace ComputerStore.Controller
{
    class ProductCategoryController
    {
        ComputerStoreDataSet computerStoreDataSet = null;
        TableAdapterManager tableAdapterManager = null;
        ProductCategoryTableAdapter productCategoryTableAdapter = null;

        public ProductCategoryController()
        {
            this.computerStoreDataSet = new ComputerStoreDataSet();
            this.tableAdapterManager = new TableAdapterManager();
            this.productCategoryTableAdapter = new ProductCategoryTableAdapter();

            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            this.tableAdapterManager.ProductCategoryTableAdapter = productCategoryTableAdapter;
        }

        /// <summary>
        /// Lay du lieu trong bang ProductCategory rui Fill vao pdProductCategory
        /// </summary>
        /// <param name="bs"></param>
        public void FillDataIntoBindingSource(System.Windows.Forms.BindingSource bs)
        {
            try
            {
                bs.DataSource = computerStoreDataSet;
                bs.DataMember = "ProductCategory";
                productCategoryTableAdapter.Fill(computerStoreDataSet.ProductCategory);
            }
            catch (ArgumentException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }
    }
}

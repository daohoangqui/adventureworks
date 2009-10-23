using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComputerStore.Data;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;

namespace ComputerStore.Controller
{
    class ProductSubCategoryController
    {
        ComputerStoreDataSet computerStoreDataSet = null;
        TableAdapterManager tableAdapterManager = null;
        ProductSubCategoryTableAdapter productSubCategoryTableAdapter = null;

        public ProductSubCategoryController()
        {
            this.computerStoreDataSet = new ComputerStoreDataSet();
            this.tableAdapterManager = new TableAdapterManager();
            this.productSubCategoryTableAdapter = new ProductSubCategoryTableAdapter();

            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            this.tableAdapterManager.ProductSubCategoryTableAdapter = productSubCategoryTableAdapter;
        }

        /// <summary>
        /// Lay du lieu trong bang ProductSubCategory rui Fill vao pdProductSubCategory
        /// </summary>
        /// <param name="bs"></param>
        public void FillDataIntoBindingSource(System.Windows.Forms.BindingSource bs)
        {
            bs.DataSource = computerStoreDataSet;
            bs.DataMember = "ProductSubCategory";
            productSubCategoryTableAdapter.Fill(computerStoreDataSet.ProductSubCategory);
        }
    }


}


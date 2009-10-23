using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;

namespace ComputerStore.Controller
{
    class VendorController
    {
        ComputerStore.Data.ComputerStoreDataSet dataset = null;
        TableAdapterManager tableAdapterManager = null;
        VendorTableAdapter vendorTableAdapter = null;
        VendorAddressTableAdapter vendorAddressTableAdapter = null;
        VendorContactTableAdapter vendorContactTableAdapter = null;
        public VendorController()
        {
            dataset = new ComputerStore.Data.ComputerStoreDataSet();
            tableAdapterManager = new TableAdapterManager();
            
            vendorTableAdapter = new VendorTableAdapter();
            vendorAddressTableAdapter = new VendorAddressTableAdapter();
            vendorContactTableAdapter = new VendorContactTableAdapter();

            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;

            this.tableAdapterManager.VendorTableAdapter = vendorTableAdapter;
            this.tableAdapterManager.VendorAddressTableAdapter = vendorAddressTableAdapter;
            this.tableAdapterManager.VendorContactTableAdapter = vendorContactTableAdapter;
        }
        public void napDuLieu(BindingSource vendor, BindingSource vendorAddress, BindingSource vendorContact)
        {
            vendor.DataSource = dataset;
            vendor.DataMember = "Vendor";
            vendorTableAdapter.Fill(dataset.Vendor);

            vendorAddress.DataSource = vendor;
            vendorAddress.DataMember = "FK_VendorAddress_Vendor";
            vendorAddressTableAdapter.Fill(dataset.VendorAddress);

            vendorContact.DataSource = vendor;
            vendorContact.DataMember = "FK_VendorContact_Vendor";
            vendorContactTableAdapter.Fill(dataset.VendorContact);
        }
        public void luuThayDoi()
        {
            tableAdapterManager.UpdateAll(this.dataset);
        }
        public void hienThiComboBox(ComboBox cmb)
        {
            vendorTableAdapter.Fill(dataset.Vendor);
            cmb.DataSource = dataset.Vendor;
            cmb.DisplayMember = "VendorName";
            cmb.ValueMember = "VendorID";
        }
    }
}
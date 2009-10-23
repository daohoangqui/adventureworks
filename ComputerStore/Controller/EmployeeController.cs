using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComputerStore.Data.ComputerStoreDataSetTableAdapters;

namespace ComputerStore.Controller
{
    class EmployeeController
    {
        ComputerStore.Data.ComputerStoreDataSet dataset = null;
        TableAdapterManager tableAdapterManager = null;
        EmployeeTableAdapter employeeTableAdapter = null;
        EmployeeAddressTableAdapter employeeAddressTableAdapter = null;
        EmployeePayHistoryTableAdapter employeePayHistoryTableAdapter = null;
        EmployeeDepartmentHistoryTableAdapter employeeDepartmentHistoryTableAdapter = null;
        

        public EmployeeController()
        {
            dataset = new ComputerStore.Data.ComputerStoreDataSet();
            tableAdapterManager = new TableAdapterManager();
            employeeTableAdapter = new EmployeeTableAdapter();
            employeeAddressTableAdapter = new EmployeeAddressTableAdapter();
            employeePayHistoryTableAdapter = new EmployeePayHistoryTableAdapter();
            employeeDepartmentHistoryTableAdapter = new EmployeeDepartmentHistoryTableAdapter();
            
            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            
            this.tableAdapterManager.EmployeeTableAdapter = employeeTableAdapter;
            this.tableAdapterManager.EmployeeAddressTableAdapter = employeeAddressTableAdapter;
            this.tableAdapterManager.EmployeePayHistoryTableAdapter = employeePayHistoryTableAdapter;
            this.tableAdapterManager.EmployeeDepartmentHistoryTableAdapter = employeeDepartmentHistoryTableAdapter;
        }
        public void napDuLieu(BindingSource employee, BindingSource employeeAddress, BindingSource employeePayHistory, BindingSource employeeDepartmentHistory)
        {
            employee.DataSource = dataset;
            employee.DataMember = "Employee";
            employeeTableAdapter.Fill(dataset.Employee);

            employeeAddress.DataSource = employee;
            employeeAddress.DataMember = "FK_EmployeeAddress_Employee";
            employeeAddressTableAdapter.Fill(dataset.EmployeeAddress);

            employeePayHistory.DataSource = employee;
            employeePayHistory.DataMember = "FK_EmployeePayHistory_Employee";
            employeePayHistoryTableAdapter.Fill(dataset.EmployeePayHistory);

            employeeDepartmentHistory.DataSource = employee;
            employeeDepartmentHistory.DataMember = "FK_EmployeeDepartmentHistory_Employee";
            employeeDepartmentHistoryTableAdapter.Fill(dataset.EmployeeDepartmentHistory);
        }
        public void luuThayDoi()
        {
            
            
            tableAdapterManager.UpdateAll(this.dataset);
        }
        public void hienThiComboBox(ComboBox cmb)
        {
            employeeTableAdapter.Fill(dataset.Employee);
            cmb.DataSource = dataset.Employee;
            cmb.DisplayMember = "FullName";
            cmb.ValueMember = "EmployeeID";
        }
    }
}

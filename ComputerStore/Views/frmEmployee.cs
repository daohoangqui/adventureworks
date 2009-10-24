using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Views
{
    public partial class frmEmployee : DevComponents.DotNetBar.Office2007Form
    {
        ComputerStore.Controller.EmployeeController EmployeeController = new ComputerStore.Controller.EmployeeController();
        ComputerStore.Controller.DepartmentController DepartmentController = new ComputerStore.Controller.DepartmentController();
        public frmEmployee()
        {
            InitializeComponent();
            EmployeeController.napDuLieu(this.EmployeeBindingSource, this.EmployeeAddressBindingSource, this.EmployeePayHistoryBindingSource, this.EmployeeDepartmentBindingSource);
            DepartmentController.hienThiComboBox(this.cmbPhongBan);
        }
        // Ham xu ly nut Save
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.kiemTraForm())
            {
                // them LastName vao 
                string temp = txtHovaTen.Text.Trim();
                string name = temp.Substring((temp.LastIndexOf(" ")) + 1);
                txtLastName.Text = name;
                this.Validate();
                this.EmployeeBindingSource.EndEdit();
                this.EmployeeDepartmentBindingSource.EndEdit();
                this.EmployeePayHistoryBindingSource.EndEdit();
                this.EmployeeAddressBindingSource.EndEdit();
                EmployeeController.luuThayDoi();
            }
        }    
        // Ham xu ly khi form load
        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
        // Ham xu ly nut Add
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorMoveFirstItem.Enabled = false;
            this.bindingNavigatorMoveLastItem.Enabled = false;
            this.bindingNavigatorMoveNextItem.Enabled = false;
            this.bindingNavigatorMovePreviousItem.Enabled = false;
            this.bindingNavigatorPositionItem.Enabled = false;

            this.lamSachForm();
        }

        // Ham clear form khi nhan nut Add
        private void lamSachForm()
        {
            this.txtDiaChi.ResetText();
            this.txtEmail.ResetText();
            this.txtHovaTen.ResetText();
            this.txtLastName.ResetText();
            this.txtSodt.ResetText();

            this.cmbGioiTinh.ResetText();
            this.cmbGioiTinh.SelectedIndex = 0;
            this.cmbPhongBan.ResetText();
            this.cmbPhongBan.SelectedIndex = 0;

            this.dtpNgaySinh.ResetValue();
            this.dtpNgayVaoLam.Value = DateTime.Now;
            //MessageBox.Show(dtpNgaySinh.Text);
            //this.chbActive.ResetText();
            this.chbActive.Checked = true;
            this.nudLuong.Value = 0;
        }

        // Ham kiem tra form truoc khi Save lai
        private bool kiemTraForm()
        {
            if (this.txtHovaTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Họ và tên");
                this.txtHovaTen.Focus();
                return false;
            }
            if (this.txtSodt.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Số điện thoại");
                this.txtSodt.Focus();
                return false;
            }
            if (this.txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ");
                this.txtDiaChi.Focus();
                return false;
            }
            if (this.dtpNgaySinh.Values == null)
            {
                MessageBox.Show("Bạn chưa nhập Ngày sinh");
                this.dtpNgaySinh.Focus();
                return false;
            }
            if (this.cmbGioiTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Giới tính");
                this.cmbGioiTinh.Focus();
                return false;
            }
            if (this.cmbPhongBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Phòng ban");
                this.cmbPhongBan.Focus();
                return false;
            }
            if (this.cmbPhongBan.SelectedIndex == -1)
            {
                MessageBox.Show("Phòng ban không hợp lệ");
                this.cmbPhongBan.Focus();
                return false;
            }
            if (this.dtpNgayVaoLam.Value == null)
            {
                MessageBox.Show("Bạn chưa nhập Ngày vào làm");
                this.dtpNgayVaoLam.Focus();
                return false;
            }
            if (this.nudLuong.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập Lương");
                this.nudLuong.Focus();
                return false;
            }
            if (this.dtpNgayVaoLam.Value < this.dtpNgaySinh.Value)
            {
                MessageBox.Show("Ngày vào làm và Ngày sinh không hợp logic");
                this.dtpNgaySinh.Focus();
                return false;
            }
            if (this.dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                this.dtpNgaySinh.Focus();
                return false;
            }
            return true;
        }
    }
}

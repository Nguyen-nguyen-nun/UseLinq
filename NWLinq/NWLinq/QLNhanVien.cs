using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NWLinq
{
    public partial class QLNhanVien : Form
    {
        BUS_DonHang bus_NV;
        public QLNhanVien()
        {
            InitializeComponent();
            bus_NV = new BUS_DonHang();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            //bus_NV.DSNhanVien(gVNV);
            CapNhat();

        }
        void TaoRong()
        {
            txtMaNV.Text = "";
            txtHo.Text = "";
            txtSoDienThoai.Text = "";
            txtTen.Text = "";
            txtChucVu.Text = "";
            txtThanhPho.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
           

        }
        void CapNhat()
        {
            bus_NV.DSNhanVien(gVNV);
            gVNV.Columns[0].Width = (int)(0.1 * gVNV.Width);
            gVNV.Columns[1].Width = (int)(0.1 * gVNV.Width);
            gVNV.Columns[2].Width = (int)(0.12 * gVNV.Width);
            gVNV.Columns[3].Width = (int)(0.12 * gVNV.Width);
            gVNV.Columns[4].Width = (int)(0.1 * gVNV.Width);
            gVNV.Columns[5].Width = (int)(0.2 * gVNV.Width);
            gVNV.Columns[6].Width = (int)(0.2 * gVNV.Width);

            TaoRong();
        }

        private void menuQLNV_Click(object sender, EventArgs e)
        {
            //QLNhanVien f = new QLNhanVien();
            //f.ShowDialog();
        }

        private void gVNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < gVNV.Rows.Count)
            {
                txtMaNV.Text = gVNV.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtHo.Text = gVNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTen.Text = gVNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Text = gVNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtThanhPho.Text = gVNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtChucVu.Text = gVNV.Rows[e.RowIndex].Cells[5].Value.ToString();
               txtSoDienThoai.Text = gVNV.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
           
            
            Employee nv = new Employee();
            if(txtHo.Text == "" ||txtChucVu.Text =="" || txtTen.Text =="" 
                || txtThanhPho.Text =="" || txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Thông tin chưa đầy đủ!");
            }
            else
            {
                nv.LastName = txtHo.Text;
                nv.FirstName = txtTen.Text;
                nv.BirthDate = dtpNgaySinh.Value;
                nv.City = txtThanhPho.Text;
                nv.Title = txtChucVu.Text;
                nv.HomePhone = txtSoDienThoai.Text;

                bus_NV.themNV(nv);

                gVNV.Columns.Clear();

                CapNhat();
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Employee nv = new Employee();
            if(txtMaNV.Text == "")
            {
                MessageBox.Show("Chọn giá trị cần sửa!");
            }
            else { nv.EmployeeID = int.Parse(txtMaNV.Text); }

            nv.LastName = txtHo.Text;
            nv.FirstName = txtTen.Text;
            nv.BirthDate = dtpNgaySinh.Value;
            nv.City = txtThanhPho.Text;
            nv.Title = txtChucVu.Text;
            nv.HomePhone = txtSoDienThoai.Text;
            bus_NV.suaNV(nv);
            gVNV.Columns.Clear();
            
            CapNhat();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Employee nv = new Employee();
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chọn giá trị cần xóa!");
            }
            else { nv.EmployeeID = int.Parse(txtMaNV.Text); }

            bus_NV.xoaNV(nv);         
            gVNV.Columns.Clear();
            CapNhat();
        }

        private void QLNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr;
            //dr = MessageBox.Show("Bạn có muốn thoát  không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void QLNhanVien_FormClosing(object sender, EventArgs e)
        {
            //QLNhanVien f = new QLNhanVien();
            //f.
        }

        private void menuQLDH_Click(object sender, EventArgs e)
        {
            QLDonHang f = new QLDonHang();
            this.Hide();
            f.ShowDialog();
           
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtThanhPho_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát  không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        private void menuQLSP_Click(object sender, EventArgs e)
        {
            QLSanPham f = new QLSanPham();
            this.Hide();
            f.ShowDialog();
        }
    }
}

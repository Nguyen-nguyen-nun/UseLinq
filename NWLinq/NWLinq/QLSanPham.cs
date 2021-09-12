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
    public partial class QLSanPham : Form
    {
        BUS_DonHang bus_SP;
        public QLSanPham()
        {
            InitializeComponent();
            bus_SP = new BUS_DonHang();
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {
            CapNhat();
        }
        void TaoRong()
        {
            txtMaSP.Text = "";
            cbNCC.Text = "";
            txtDonGia.Text = "";
            cbLoaiSP.Text = "";
            txtTenSP.Text = "";


        }
        void CapNhat()
        {
            bus_SP.DSLoaiSP(cbLoaiSP);
            bus_SP.DSNCC(cbNCC);
          
            bus_SP.DSSP2(gVSP);
            gVSP.Columns[0].Width = (int)(0.1 * gVSP.Width);
            gVSP.Columns[1].Width = (int)(0.4 * gVSP.Width);
            gVSP.Columns[2].Width = (int)(0.12 * gVSP.Width);
            gVSP.Columns[3].Width = (int)(0.12 * gVSP.Width);
            gVSP.Columns[4].Width = (int)(0.15 * gVSP.Width);

            TaoRong();
          
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Product d = new Product();
            // ma SP tự tăng
            if(txtTenSP.Text ==""|| txtDonGia.Text == "")
            {
                MessageBox.Show("Thông tin chưa đầy đủ!");
            }
            else
            {
                d.SupplierID = int.Parse(cbNCC.SelectedValue.ToString());
                d.CategoryID = int.Parse(cbLoaiSP.SelectedValue.ToString());
                d.ProductName = txtTenSP.Text;
                d.UnitPrice = decimal.Parse(txtDonGia.Text);

                bus_SP.ThemSP(d);

                gVSP.Columns.Clear();
                CapNhat();
            }
         
           
        }

        private void gVSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVSP.Rows.Count)//dòng 0 đến dòng số dòng-1
            {
                txtMaSP.Text = gVSP.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtTenSP.Text = gVSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbLoaiSP.Text = gVSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbNCC.Text = gVSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDonGia.Text = gVSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            if(txtMaSP.Text == "")
            {
                MessageBox.Show("Chọn giá trị cần xóa!");
            }
            else { p.ProductID = int.Parse(txtMaSP.Text); }

            bus_SP.xoaSP(p);
            gVSP.Columns.Clear();
            CapNhat();
          
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Chọn giá trị cần sửa !");
            }
            else { p.ProductID = int.Parse(txtMaSP.Text);
                p.CategoryID = int.Parse(cbLoaiSP.SelectedValue.ToString());
                p.SupplierID = int.Parse(cbNCC.SelectedValue.ToString());
                p.UnitPrice = decimal.Parse(txtDonGia.Text);
                p.ProductName = txtTenSP.Text;

                bus_SP.suaSP(p);
                gVSP.Columns.Clear();
                CapNhat();
            }

           
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

        private void menuQLDH_Click(object sender, EventArgs e)
        {
            QLDonHang f = new QLDonHang();
            this.Hide();
            f.ShowDialog();
        }

        private void menuQLNV_Click(object sender, EventArgs e)
        {
            QLNhanVien f = new QLNhanVien();
            this.Hide();
            f.ShowDialog();
        }

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void cbLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

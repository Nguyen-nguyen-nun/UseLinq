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
    public partial class CTDH : Form
    {
        // tạo kết nối
        public int maDH;
        private BUS_DonHang busCTDH;
        public CTDH()
        {
            InitializeComponent();
            busCTDH = new BUS_DonHang();
        }
        public void TaoRong()
        {
            txtMaSP.Text = "";
            txtMaDH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }
        private void CTDH_Load(object sender, EventArgs e)
        {
            CapNhat();

        }
        public void CapNhat()
        {

            txtMaDH.Enabled = false;
            busCTDH.DSCTDH(gVCTDH, maDH);


            gVCTDH.Columns[0].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[1].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[2].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[3].Width = (int)(0.3 * gVCTDH.Width);
            TaoRong();
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count)
            {
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                txtMaSP.Text = gVCTDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = gVCTDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = gVCTDH.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Order_Detail c = new Order_Detail();
            c.OrderID = maDH;
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Chọn giá trị cần xóa!");
            }
            else
            {
                c.ProductID = int.Parse(txtMaSP.Text);
                c.ProductID = int.Parse(txtMaSP.Text);
                c.Quantity = short.Parse(txtSoLuong.Text);
                c.UnitPrice = decimal.Parse(txtDonGia.Text);

                busCTDH.suaCTDH(c);

                gVCTDH.Columns.Clear();
                CapNhat();
            }          
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {


            Order_Detail c = new Order_Detail();
            c.OrderID = maDH;
            //c.ProductID = int.Parse(txtMaSP.Text);
            if (txtMaSP.Text == "") 
            {
                MessageBox.Show("Chọn giá trị cần xóa!");
            }
            else
            {
                c.ProductID = int.Parse(txtMaSP.Text);
            }
          

            busCTDH.xoaCTDH(c);

            gVCTDH.Rows.Clear();
            CapNhat();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

        }
    }
}

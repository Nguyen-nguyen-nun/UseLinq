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
    public partial class QLDonHang : Form
    {
        BUS_DonHang busDonHang;
        public QLDonHang()
        {
            InitializeComponent();
            //Goi doi tuong cua BUS
            busDonHang = new BUS_DonHang();
        }

        private void QLDonHang_Load(object sender, EventArgs e)
        {
            CapNhat();

        }
        void CapNhat()
        {
            busDonHang.DSNV(cbNhanVien);
            busDonHang.DSKH(cbKhachHang);
            busDonHang.DSDonHang(gVDH);// hien ds DonHang
            //thay doi kích thước dg
            //co 4 cot. moi cot 20%
            gVDH.Columns[0].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[1].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[2].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[3].Width = (int)(0.3 * gVDH.Width);
        }

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.RowIndex<gVDH.Rows.Count)//dòng 0 đến dòng số dòng-1
            {
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                dtpNgayDH.Text = gVDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbNhanVien.Text = gVDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbKhachHang.Text = gVDH.Rows[e.RowIndex].Cells[3].Value.ToString(); 
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Order donhang = new Order();
            // Mã đơn hàng tự tăng
            donhang.CustomerID = cbKhachHang.SelectedValue.ToString();
            donhang.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());
            donhang.OrderDate = dtpNgayDH.Value;

            busDonHang.ThemDH(donhang);

            //gVDH.Columns.Clear();
            //CapNhat();
            busDonHang.DSDonHang(gVDH);

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // ma don hang tu tang
            Order d = new Order();
            d.OrderID = int.Parse(txtMaDH.Text);
            

            d.OrderDate = dtpNgayDH.Value;
            d.CustomerID = cbKhachHang.SelectedValue.ToString();
            d.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());

            busDonHang.suaDH(d);

            gVDH.Columns.Clear();
            CapNhat();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Order d = new Order();
            if(txtMaDH.Text != "")
            {
                d.OrderID = int.Parse(txtMaDH.Text);
            }
            else { MessageBox.Show("Chọn giá trị cần xóa!"); }

            busDonHang.xoaDH(d);

            gVDH.Columns.Clear();
            CapNhat();
        }

        private void gVDH_DoubleClick(object sender, EventArgs e)
        {
            CTDH ctDH = new CTDH();
            ctDH.maDH = int.Parse(gVDH.CurrentRow.Cells["OrderID"].Value.ToString());
            ctDH.ShowDialog();
        }

        private void btThemCTDH_Click(object sender, EventArgs e)
        {
            FDatHang fDatHang = new FDatHang();
            fDatHang.maDH = int.Parse(gVDH.CurrentRow.Cells[0].Value.ToString());
            fDatHang.ShowDialog();
        }

        private void menuQLNV_Click(object sender, EventArgs e)
        {
            QLNhanVien f = new QLNhanVien();
            this.Hide();
            f.ShowDialog();
           
           
        }

        private void menuQLSP_Click(object sender, EventArgs e)
        {
            QLSanPham f = new QLSanPham();
            this.Hide();
            f.ShowDialog();
           
        }

        private void cbKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
    }
}

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
    public partial class FDatHang : Form
    {
        BUS_DonHang busDH;

        public FDatHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }
        public int maDH;
        bool co = false;
        DataTable dtSP;
        private void FDatHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDH.ToString();
            busDH.DSSP(cbTenSP);
            co = true;

            // DINH NGHIA CAC COT DU LIEU

            dtSP = new DataTable();

            dtSP.Columns.Add("ProductID");
            dtSP.Columns.Add("UnitPrice");
            dtSP.Columns.Add("Quantity");
            dtSP.Columns.Add("Discount");

            // THEM DATATABLE VAO DATAGRIDVIEW
            gVSP.DataSource = dtSP;
            gVSP.Columns[0].Width = (int)(0.22 * gVSP.Width);
            gVSP.Columns[1].Width = (int)(0.22 * gVSP.Width);
            gVSP.Columns[2].Width = (int)(0.22* gVSP.Width);
            gVSP.Columns[3].Width = (int)(0.22 * gVSP.Width);

        }
        void HienDSSP()
        {
            busDH.DSSP(cbTenSP);
        }
        public void HienThiThongTinSanPham(string maSP)
        {
            int ma = int.Parse(maSP);
            Product p = busDH.HienThongTinSP(ma);
            txtDonGia.Text = p.UnitPrice.ToString();
            txtLoaiSP.Text = p.CategoryID.ToString();
            txtNhaCungCap.Text = p.SupplierID.ToString();
        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co) {
                HienThiThongTinSanPham(cbTenSP.SelectedValue.ToString());
            }
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool kiemTra = true;
            // duyet tung dong de kiem tra MaSP da ton tai hay chua?
            //1. Co, Them so luong
            //0. Them dong moi
            foreach(DataRow  item in dtSP.Rows)
            {
                if(item[0].ToString()== cbTenSP.SelectedValue.ToString())
                {
                    kiemTra = false;
                    item[2] = int.Parse(item[2].ToString()) + int.Parse(SoLuongUpDown.Value.ToString());
                    break;
                }
            }
            if (kiemTra)
            {
                // định nghĩa một dòng mới để thêm
                DataRow r = dtSP.NewRow();
                r[0] = cbTenSP.SelectedValue.ToString();
                r[1] = txtDonGia.Text;
                r[2] = SoLuongUpDown.Value.ToString();
                r[3] = txtDiscount.Text;
                dtSP.Rows.Add(r);
            }
           
        }
        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void cbTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btDatHang_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }
    }
}

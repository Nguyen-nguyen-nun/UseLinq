using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NWLinq
{
    class BUS_DonHang
    {
        DAO_DonHang da;
        DAO_SanPham ds;
        DAO_NhanVien dv;
        public BUS_DonHang()
        {
            //Goi doi tuong cua lop DAO
            da = new DAO_DonHang();
            // tạo liên kết với class DAO_SanPham
            ds = new DAO_SanPham();
            // tạo liên kết với class DAO_NhanVien
            dv = new DAO_NhanVien();
        }
        //1.QUẢN LÝ ĐƠN HÀNG
        public void DSDonHang(DataGridView dg)
        {
            dg.DataSource = da.LayDSDonHang3();
        }
        public void DSKH(ComboBox cb)
        {
            cb.DataSource = da.LayDSKH();
            cb.DisplayMember = "CompanyName";// gia tri hien thi
            cb.ValueMember = "CustomerID";// gia tri lay 
        }



        public void DSNV(ComboBox cb)
        {
            cb.DataSource = da.LayDSNV();
            cb.DisplayMember = "LastName";
            cb.ValueMember = "EmployeeID";
        }
        // Lay DS MaSP


        public void ThemDH(Order donhang)
        {
            try
            {
                da.ThemDH(donhang);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception)
            {

                ;
            }
        }
        public void suaDH(Order d)
        {
            if (da.SuaDH(d))
            {
                MessageBox.Show("Sửa thành công!");
            }
        }
        public void xoaDH(Order d)
        {
            if (da.xoaDH(d))
            {
                MessageBox.Show("Xoá thành công!");
            }
        }
        public void DSCTDH(DataGridView dg, int maDH)
        {
            dg.DataSource = da.LayDSChiTietDH(maDH);
        }
        //2.QUẢN LÝ CHI TIẾT ĐƠN HÀNG
        /// CTDH
        /// 
        public void ThemCTDH(Order_Detail d)
        {
            try
            {
                da.themCTDH(d);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception)
            {

                ;
            }
        }
        public void suaCTDH(Order_Detail d)
        {
            if (da.SuaCTDH(d))
            {
                MessageBox.Show("Sửa thành công!");
            }
        }
        public void xoaCTDH(Order_Detail d)
        {
            if (da.xoaCTDH(d))
            {
                MessageBox.Show("Xoá thành công!");
            }
          
        }

        //3.QUẢN LÝ SẢN PHẨM
        // Lay DSSP de hien trong QLSP
        public void DSSP2(DataGridView dg)
        {
            dg.DataSource = ds.LayDSSP2();
        }
        public void DSNCC(ComboBox cb)
        {
            cb.DataSource = ds.LayDSNCC();
            cb.DisplayMember = "CompanyName";// gia tri hien thi
            cb.ValueMember = "SupplierID";// gia tri lay 
        }
        public void DSLoaiSP(ComboBox cb)
        {
            cb.DataSource = ds.LayDLoaiSP();
            cb.DisplayMember = "CategoryName";// gia tri hien thi
            cb.ValueMember = "CategoryID";// gia tri lay 
        }
        // them SP 
        public void ThemSP(Product sp)
        {
            try
            {
                ds.ThemSP(sp);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception)
            {

                ;
            }
        }
        // xoa SP
        public void xoaSP(Product d)
        {
            if (ds.xoaSP(d))
            {
                MessageBox.Show("Xoá thành công!");
            }
        }
        // sua SP
        public void suaSP(Product d)
        {
            if (ds.suaSP(d))
            {
                MessageBox.Show("Sửa thành công!");
            }
        }

        // Lay DSSP de hien tren Combobox trong FDatHang
        public void DSSP(ComboBox cb)
        {
            cb.DataSource = ds.LayDSSP();
            cb.DisplayMember = "ProductName";// gia tri hien thi
            cb.ValueMember = "ProductID";// gia tri lay 
        }
        // Lấy chi tiết sản phẩm
        public Product HienThongTinSP(int maSP)
        {
            var s = ds.LayThongTinSP(maSP);
            //Product p = new Product();
            //p.ProductID = maSP;
            return s;

        }
        //public ProductModel HienThongTinSP2(int maSP)
        //{
        //  ProductModel sp = d

        //}

        //4. QUẢN LÝ NHÂN VIÊN
        public void DSNhanVien(DataGridView dg)
        {
            dg.DataSource = dv.LayDSNV();
        }
        public void themNV(Employee e)
        {
            dv.themNV(e);
            MessageBox.Show("Thêm thành công!");
        }

        public void suaNV(Employee d)
        {
            if (dv.SuaNV(d))
            {
                MessageBox.Show("Sửa thành công!");
            }
        }
        public void xoaNV(Employee d)
        {
            if (dv.XoaNV(d))
            {
                MessageBox.Show("Xóa thành công!");
            }
        }
    }
}

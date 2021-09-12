using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWLinq
{
    class DAO_DonHang
    {
        //Khai bao doi tuong database,su dung linq

        NWDataContext db;

        public DAO_DonHang()
        {
            //ket noi voi database
            db = new NWDataContext();
        }

        public IEnumerable<Order> LayDSDonHang()//duyet va lay tat ca 
        {//tra ve ds don hang
            IEnumerable<Order> dsDH = db.Orders.Select(s => s);
            return dsDH;
        }
        public List<Order> LayDSDonHang2()
        {//tra ve ds don hang
            //List<Order> dsDH = db.Orders.Select(s => s).ToList();
            List<Order> dsDH = (from i in db.Orders
                                select i).ToList();
            return dsDH;
        }
        //Buoc 2: Xu ly lay duoc tenNv, tenKh, gioi han cot hien thi ra DG
        public dynamic LayDSDonHang3()//return 4 gia tri
        {
            dynamic dsDH = db.Orders.Select(s => new
            {
                s.OrderID,
                s.OrderDate,
                s.Employee.LastName,//thay vì kết bảng=> linq cho lấy thông qua bảng dựa khóa ngoại
                s.Customer.CompanyName
            });
            return dsDH;
        }


        public dynamic LayDSKH()
        {
            var ds = db.Customers.Select(k => new { k.CustomerID, k.CompanyName });
            return ds;
        }
        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(k => new { k.EmployeeID, k.LastName });
            return ds;
        }
        // them Don Hang
        public void ThemDH(Order donhang) {
            //ma don hang tu tang
            db.Orders.InsertOnSubmit(donhang);
            db.SubmitChanges();
        }

        public bool SuaDH(Order donhang)
        {
            bool tinhTrang = false;// Khong cos don hang

            try
            {
                Order d = db.Orders.First(s => s.OrderID == donhang.OrderID);

                d.OrderDate = donhang.OrderDate;
                d.CustomerID = donhang.CustomerID;
                d.EmployeeID = donhang.EmployeeID;

                db.SubmitChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {

                tinhTrang = false;
            }
            return tinhTrang;

        }
        public bool xoaDH(Order donhang)

        {
            bool tinhtrang = false;

            try
            {

                Order d = db.Orders.First(s => s.OrderID == donhang.OrderID);

                db.Orders.DeleteOnSubmit(d);
                db.SubmitChanges();
                tinhtrang = true;
            }
            catch (Exception)
            {

                tinhtrang = false;
            }
            return tinhtrang;
        }
        // CHI TIET DON HANG
        public dynamic LayDSChiTietDH(int maDH)
        {
            // XỬ LÝ KHÔNG CÓ MADH
            dynamic ds = db.Order_Details.Where(s => s.OrderID == maDH).Select(
                s => new { s.OrderID, s.ProductID, s.UnitPrice, s.Quantity });
            return ds;
        }
        public dynamic LayChiTietDH(int maDH)
        {
            // XỬ LÝ KHÔNG CÓ MADH
            dynamic ds = db.Order_Details.Where(s => s.OrderID == maDH).Select(
                s => new { s.OrderID, s.ProductID, s.UnitPrice, s.Quantity });
            return ds;

        }

        public void themCTDH(Order_Detail ctDH)
        {
            try
            {
                db.Order_Details.InsertOnSubmit(ctDH);
                db.SubmitChanges();
            }
            catch (Exception)
            {
              
            }
        }

        public bool SuaCTDH(Order_Detail donhang)
        {
            bool tinhTrang = false;// Khong cos don hang

            try
            {
                Order_Detail d = db.Order_Details.First(s => s.OrderID == donhang.OrderID
                && s.ProductID == donhang.ProductID);
               

                d.ProductID = donhang.ProductID;
                d.Quantity = donhang.Quantity;
                d.UnitPrice = donhang.UnitPrice;

                db.SubmitChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                
                tinhTrang = false;
            }
            return tinhTrang;

        }
        public bool xoaCTDH(Order_Detail donhang)

        {
            bool tinhtrang = false;

            try
            {

                Order_Detail dh = db.Order_Details.First(s => s.OrderID == donhang.OrderID &&
                s.ProductID == donhang.ProductID);

                db.Order_Details.DeleteOnSubmit(dh);
                db.SubmitChanges();
                tinhtrang = true;
            }
            catch (Exception)
            {
               
                tinhtrang = false;
            }
            return tinhtrang;
        }
      
       


    }
}

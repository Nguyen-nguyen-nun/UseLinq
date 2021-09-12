using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWLinq
{
    class DAO_SanPham
    {
        public NWDataContext db;
        public DAO_SanPham()
        {
            db = new NWDataContext();
        }
        // Phuong thuc lay DS

        public dynamic LayDSSP2()
        {
            dynamic ds = db.Products.Select(s => new {
                s.ProductID,
                s.ProductName,
                s.Category.CategoryName,
                s.Supplier.CompanyName,
                s.UnitPrice
            });
            return ds;
        }
        public dynamic LayDSNCC()
        {
            var ds = db.Suppliers.Select(k => new { k.SupplierID, k.CompanyName });
            return ds;
        }
        public dynamic LayDLoaiSP()
        {
            var ds = db.Categories.Select(k => new { k.CategoryID, k.CategoryName });
            return ds;
        }
        // them SP
        public void ThemSP(Product sp)
        {
            db.Products.InsertOnSubmit(sp);
            db.SubmitChanges();
            
        }
        // xoa SP
        public bool xoaSP(Product p)

        {
            bool tinhtrang = false;

            try
            {

               Product d = db.Products.First(s => s.ProductID == p.ProductID);

                db.Products.DeleteOnSubmit(d);
                db.SubmitChanges();
                tinhtrang = true;
            }
            catch (Exception)
            {

                tinhtrang = false;
            }
            return tinhtrang;
        }
        // sửa SP
        public bool suaSP(Product p)

        {
            bool tinhtrang = false;

            try
            {

                Product d = db.Products.First(s => s.ProductID == p.ProductID);

                d.ProductName = p.ProductName;
                d.CategoryID = p.CategoryID;
                d.SupplierID = p.SupplierID;
                d.UnitPrice = p.UnitPrice;

                db.SubmitChanges();
                tinhtrang = true;
            }
            catch (Exception)
            {

                tinhtrang = false;
            }
            return tinhtrang;
        }
        // ds trong fDatHang
        public dynamic LayDSSP()
        {
            dynamic ds = db.Products.Select(s => new { s.ProductID, s.ProductName });
            return ds;
        }
        public Product LayThongTinSP(int maSP)
        {
            var sp = db.Products.FirstOrDefault(s => s.ProductID == maSP);
            return sp;
        }
        public ProductModel LayThongTinSP2(int maSP)
        {
            ProductModel sp = db.Products.Where(s => s.ProductID == maSP).Select(s => new ProductModel()
            {
                ProductID = s.ProductID,
                ProductName = s.ProductName,
                UnitPrice = s.UnitPrice,
                CategoryName = s.Category.CategoryName,
                CompanyName = s.Supplier.CompanyName
            }).FirstOrDefault();    
            return sp;
        }

    }
}
//public class ProducModel
//{
//    private int productID;
//    private string productName;
//    private System.Nullable<decimal> unitPrice;
//    private string categoryName;
//    private string companyName;
//    public int ProductID
//    {
//        get { return productID; }
//        set { productID = value; }    
//    }
 
//    public string ProductName
//    {
//        get { return productName; }
//        set { productName = value; }
//    }
   

//    public decimal? UnitPrice
//    {
//        get { return unitPrice; }
//        set { unitPrice = value; }
//    }

//    public string CategoryName
//    {
//        get { return categoryName; }
//        set {categoryName = value; }
//    }

//    public string CompanyName
//    {
//        get { return companyName; }
//        set { companyName = value; }
//    }

//}

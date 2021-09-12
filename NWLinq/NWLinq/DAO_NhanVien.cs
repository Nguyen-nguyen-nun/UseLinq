using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWLinq
{

    class DAO_NhanVien
    {
        public NWDataContext db;
        public DAO_NhanVien()
        {
            db = new NWDataContext();
        }
        
        public dynamic LayDSNV()
        {
            dynamic ds = db.Employees.Select(s => new
            
            {
                s.EmployeeID,
                s.LastName,
                s.FirstName,
                s.BirthDate,
                s.City,
                s.Title,
                s.HomePhone
            });
            return ds;
        }
        // them NV
        public void themNV(Employee e)
        {
            // mã NV tự tăng
            db.Employees.InsertOnSubmit(e);
            db.SubmitChanges();
        }
        //sửa NV
        public bool SuaNV(Employee nv)
        {
            bool tinhTrang = false;// Khong cos don hang

            try
            {
                Employee e = db.Employees.First(s => s.EmployeeID == nv.EmployeeID);

                e.LastName = nv.LastName;
                e.FirstName = nv.FirstName;
                e.BirthDate = nv.BirthDate;
                e.City = nv.City;
                e.Title = nv.Title;
                e.HomePhone = nv.HomePhone;

                db.SubmitChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {

                tinhTrang = false;
            }
            return tinhTrang;

        }

        // xóa NV
        public bool XoaNV( Employee nv)

        {
            bool tinhtrang = false;

            try
            {

               Employee e = db.Employees.First(s => s.EmployeeID == nv.EmployeeID);

                db.Employees.DeleteOnSubmit(e);
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

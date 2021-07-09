using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinForm_MNM.DAO
{
    public class AccDAO
    {
        private static AccDAO instance;

        public static AccDAO Instance
        {
            get { if (instance == null) instance = new AccDAO(); return instance; }
            private set { instance = value; }
        }

        private AccDAO() { }
        public bool Login(string User, string Pass)
        {
            string str ="SELECT * FROM NhanVien Where MaNV = '"+Pass+"'AND TenNV = N'"+User+"'";
            DataTable result = Dataprovider.Instance.ExcuteQury(str);
            return result.Rows.Count>0;
        }
    }
}

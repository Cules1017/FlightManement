using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinForm_MNM.DAO
{
    class KhachHang
    {
        private static KhachHang instance;

        public static KhachHang Instance
        {
            get { if (instance == null) instance = new KhachHang(); return KhachHang.instance; }
            private set { KhachHang.instance = value; }
        }

        public static int TableWidth = 500;
        public static int TableHeight = 30;

        private KhachHang() { }

        public List<tableKH> LoadTableList()
        {
            List<tableKH> tableList = new List<tableKH>();

            DataTable data = Dataprovider.Instance.ExcuteQury("KH_GET");

            foreach (DataRow item in data.Rows)
            {
                tableKH KH = new tableKH(item);
                tableList.Add(KH);
            }

            return tableList;
        }
    }
}

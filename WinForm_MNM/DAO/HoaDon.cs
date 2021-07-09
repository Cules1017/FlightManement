using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinForm_MNM.DAO
{
    class HoaDon
    {
        private static HoaDon instance;

        public static HoaDon Instance
        {
            get { if (instance == null) instance = new HoaDon(); return HoaDon.instance; }
            private set { HoaDon.instance = value; }
        }

        public static int TableWidth = 500;
        public static int TableHeight = 30;

        private HoaDon() { }

        public List<TableHD> LoadTableList()
        {
            List<TableHD> tableList = new List<TableHD>();

            DataTable data = Dataprovider.Instance.ExcuteQury("HD_GET");

            foreach (DataRow item in data.Rows)
            {
                TableHD HD = new TableHD(item);
                tableList.Add(HD);
            }

            return tableList;
        }
    }
}

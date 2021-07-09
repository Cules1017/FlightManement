using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_MNM.DAO
{
    class ChuyenBay
    {
        private static ChuyenBay instance;

        public static ChuyenBay Instance
        {
            get { if (instance == null) instance = new ChuyenBay(); return ChuyenBay.instance; }
            private set { ChuyenBay.instance = value; }
        }

        public static int TableWidth = 500;
        public static int TableHeight = 30;

        private ChuyenBay() { }

        public List<table> LoadTableList()
        {
            List<table> tableList = new List<table>();

            DataTable data = Dataprovider.Instance.ExcuteQury("CB_GET");

            foreach (DataRow item in data.Rows)
            {
                table CB = new table(item);
                tableList.Add(CB);
            }
            
            return tableList;
        }
    }
}

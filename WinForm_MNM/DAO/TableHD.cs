using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinForm_MNM.DAO
{
    class TableHD
    {
        public  TableHD(string id, int sl, string status, DateTime nGDN = default)
        {
            this.ID = id;
            this.TriGia1 = "";
            
        }

        public TableHD(DataRow row)
        {
            this.ID = row["MaHD"].ToString();
            this.MaNV1 = row["MaNV"].ToString();
            this.MaKH1 = row["MaKH"].ToString();
            this.NGHD1 = (DateTime)row["NGHD"];
            this.TriGia1 = row["TriGia"].ToString();
           

        }

        
        private DateTime NGHD;
        
        private string TriGia;
        private string MaKH;
        private string MaNV;
        public string TriGia1
        {
            get { return TriGia; }
            set { TriGia = value; }
        }

        private string iD;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public DateTime NGHD1 { get => NGHD; set => NGHD = value; }
        
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinForm_MNM.DAO
{
    public class tableKH
    {
        public tableKH(string id, int sl, string status, DateTime nGDN = default)
        {
            this.ID = id;
            
        }

        public tableKH(DataRow row)
        {
            this.ID = row["MaKH"].ToString();
       
            this.TenKH1 = row["TenKH"].ToString();

        }

       
        
        private string TenKH;
        private string iD;



        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

       
        public string TenKH1 { get => TenKH; set => TenKH = value; }
       
    }
}


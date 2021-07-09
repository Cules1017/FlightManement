using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinForm_MNM.DAO
{
     public class table
    {

        public table(string id, int sl, string status, DateTime nGDN = default)
        {
            this.ID = id;
            this.SL = sl;
            this.Status = status;
            NGDN1 = nGDN;
        }

        public table(DataRow row)
            {
                this.ID =row["MaCB"].ToString();
                this.NGKH1 = (DateTime)row["TGKhoihanh"];
                this.NGDN1 = (DateTime)row["TGDen"];
                this.NoiKH1 = row["NoiKH"].ToString();
                this.NoiDen1 = row["NoiDen"].ToString();
                this.SL = (int)row["SL"];
                this.Status = row["TinhTrang"].ToString();
             
            }

            private string status;

            public string Status
            {
                get { return status; }
                set { status = value; }
            }
            private DateTime NGKH;
             private DateTime NGDN;
            private int sl;
        private string NoiKH;
        private string NoiDen;
            public int SL
            {
                get { return sl; }
                set { sl = value; }
            }

            private string iD;

            public string ID
            {
                get { return iD; }
                set { iD = value; }
            }

        public DateTime NGKH1 { get => NGKH; set => NGKH = value; }
        public DateTime NGDN1 { get => NGDN; set => NGDN = value; }
        public string NoiKH1 { get => NoiKH; set => NoiKH = value; }
        public string NoiDen1 { get => NoiDen; set => NoiDen = value; }
    }
   
}


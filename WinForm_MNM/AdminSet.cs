using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForm_MNM.DAO;

namespace WinForm_MNM
{
    public partial class AdminSet : Form
    {
        public AdminSet()
        {
            InitializeComponent();
            label2.Hide();
           // LoadListKH();
        }
       /* void LoadListKH()
        {
            string Str = "EXEC SearchCB @NGKH='7/22/2021 6:00' ,  @NGDN='7/23/2021 8:00' , @NoiKH=N'TP HCM' , @NoiDen=N'Hà Nội'";
          
            
            dataGridViewKH.DataSource=Dataprovider.Instance.ExcuteQury(Str);

        }*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_xemDoanhThu_Click(object sender, EventArgs e)
        {
            
            string a = dateTimedt1.Value.ToString();
            string b = dateTimedt2.Value.ToString();
            string k=string.Format( "EXEC SearchTHU @TUNG='{0}' , @DNNG='{1}' ",a,b);
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
            if (dataTable.Rows.Count < 1)
            {
                label2.Show();
            }
            else
            {
                label2.Hide();
            }
            dataGridView_DT.DataSource = Dataprovider.Instance.ExcuteQury(k);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string k = "SELECT* FROM DuongBay";
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
            if (dataTable.Rows.Count < 1)
            {
                labelDB.Show();
            }
            else
            {
                labelDB.Hide();
            }
            dataGridViewDB.DataSource = Dataprovider.Instance.ExcuteQury(k);
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string k = "SELECT* FROM HoaDon";
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
            if (dataTable.Rows.Count < 1)
            {
                labelHD.Show();
            }
            else
            {
                labelHD.Hide();
            }
           dataGridViewHD.DataSource = Dataprovider.Instance.ExcuteQury(k);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string MaHD = MaHD_HD.Text.ToString();
            string MaKH = MaKH_HD.Text.ToString();
            string MaNV = MaNV_HD.Text.ToString();
            string NGHD = NGHD_HD.Text.ToString();
            string GiaTri = TRIGIA_HD.Text.ToString();
            if (MaHD.Length <=0 ||MaHD.Length!=8 || MaKH.Length <= 0||MaKH.Length!=8||MaNV.Length!=5 || MaNV.Length <= 0 || NGHD.Length <= 0 || GiaTri.Length <= 0)
                MessageBox.Show("Vui Lòng Nhập lại chính xác","Lỗi!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else {
            string k =string.Format("EXEC ADD_HD @MaHD='{0}' , @MaNV='{1}' , @MaKH='{2}' , @NGHD='{3}', @Gia='{4}' " , MaHD,MaNV,MaKH,NGHD,GiaTri);
      
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
            if (dataTable.Rows.Count < 1)
            {
                labelHD.Show();
            }
            else
            {
                labelHD.Hide();
            }
                k = "SELECT* FROM HoaDon WHERE MaHD='" + MaHD + "'";
            dataGridViewHD.DataSource = Dataprovider.Instance.ExcuteQury(k); 

            
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DataTable dataTable;
            string k;
            string MaCB = MaCB_Ve.Text.ToString();
            if(MaCB.Length==0)
            {
                k = "SELECT* FROM Ve";
                dataTable = Dataprovider.Instance.ExcuteQury(k);
                if (dataTable.Rows.Count < 1)
                {
                    labelVe.Show();
                }
                else
                {
                    labelVe.Hide();
                }
                dataGridViewVe.DataSource = Dataprovider.Instance.ExcuteQury(k);
            }
            else if(MaCB.Length==8)
            {
                 k = "SELECT* FROM Ve WHERE MaCB='"+MaCB+"'";
                 dataTable = Dataprovider.Instance.ExcuteQury(k);
                if (dataTable.Rows.Count < 1)
                {
                labelVe.Show();
                 }
                else
                {
                    labelVe.Hide();
                 }
                dataGridViewVe.DataSource = Dataprovider.Instance.ExcuteQury(k);
            }
            else
            {
                
                MessageBox.Show("Vui Lòng Nhập lại chính xác", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

           

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string k = "SELECT* FROM ChuyenBay";
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
            if (dataTable.Rows.Count < 1)
            {
                labelCB.Show();
            }
            else
            {
                labelCB.Hide();
            }
            dataGridViewCB.DataSource = Dataprovider.Instance.ExcuteQury(k);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string MaCB = MaCB_CB.Text.ToString();
            string MaDB = MaDB_CB.Text.ToString();
            string MaMB = MaMB_CB.Text.ToString();
            string NgKH = NGKH_CB.Text.ToString();
            string NgDn = NGDN_CB.Text.ToString();
            string NoiKH = NKH_CB.Text.ToString();
            string Noidn = NDEN_CB.Text.ToString();
            string k = string.Format("INSERT INTO ChuyenBay VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",MaCB,MaMB,MaDB,NgKH,NgDn,NgKH,Noidn);
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
            k = string.Format("SELECT* FROM ChuyenBay WHERE MaCB='{0}'", MaCB);
            dataGridViewCB.DataSource = Dataprovider.Instance.ExcuteQury(k);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string k = "SELECT* FROM KhachHang";
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
            if (dataTable.Rows.Count < 1)
            {
                labelKH.Show();
            }
            else
            {
                labelKH.Hide();
            }
            dataGridViewKH.DataSource = Dataprovider.Instance.ExcuteQury(k);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string k = "SELECT* FROM MayBay";
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
            if (dataTable.Rows.Count < 1)
            {
                labelMB.Show();
            }
            else
            {
                labelMB.Hide();
            }
            dataGridViewMB.DataSource = Dataprovider.Instance.ExcuteQury(k);
        }

        private void dataGridView_DT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}

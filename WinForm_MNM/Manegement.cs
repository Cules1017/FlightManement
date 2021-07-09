using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForm_MNM.DAO;

namespace WinForm_MNM
{
    public partial class Manegement : Form
    {
        public Manegement()
        {
            InitializeComponent();
            LoadCB();
            LoadDD();
            LoadHD();
            LoadKH();
        }
        List<DiaDiem> ListDD1;
        List<DiaDiem> ListDD2;
        List<KH> ListKH;
        List<HD> ListHD;
        bool BoleanKH = false;
        void LoadDD()
        {
            ListDD1=new List<DiaDiem> {
                new DiaDiem{Noi1="TP HCM"},
                new DiaDiem{Noi1="Hà Nội"},
                new DiaDiem{Noi1="Đà Nẵng"},
                new DiaDiem{Noi1="Vinh"},
                new DiaDiem{Noi1="Cần Thơ"},
                new DiaDiem{Noi1="Phú Quốc"},
            };
            ListDD2 = new List<DiaDiem> {
                new DiaDiem{Noi1="Hà Nội"},
                new DiaDiem{Noi1="TP HCM"},
                new DiaDiem{Noi1="Đà Nẵng"},
                new DiaDiem{Noi1="Vinh"},
                new DiaDiem{Noi1="Cần Thơ"},
                new DiaDiem{Noi1="Phú Quốc"},
            };
            comboxNKH.DataSource = ListDD1;
            comboxNKH.DisplayMember = "Noi1";
            comboxEND.DataSource = ListDD2;
            comboxEND.DisplayMember = "Noi1";

        }
        void LoadCB()
        {
            List<table> TableList = ChuyenBay.Instance.LoadTableList();
           
            foreach(table item in TableList)
            {
                string k;
                k = item.NGKH1.ToString();
                string[] cut = k.Split(' ');
            Button a = new Button() {Width = ChuyenBay.TableWidth, Height = ChuyenBay.TableHeight };
                a.Text = "Mã:" + item.ID+" NoiKH:"+item.NoiKH1+" NoiDen:"+item.NoiDen1 + "NG:" + cut[0];
                
                switch (item.Status)
                {
                    case "Còn":
                        a.BackColor = Color.Aqua;
                        break;
                    default:
                        a.BackColor = Color.Red;
                        break;
                }
                flowLayoutPanel1.Controls.Add(a);
                a.Click += A_Click;
            }
        }

        void LoadHD()
        {
            List<TableHD> TableList = HoaDon.Instance.LoadTableList();
            ListHD = new List<HD>{ };
            foreach (TableHD item in TableList)
            {

                ListHD.Add(new HD { MaHD1=item.ID,MaKH1=item.MaKH1 ,TG1=item.TriGia1});

            }
        }
        void LoadKH()
        {
            List<tableKH> TableList = KhachHang.Instance.LoadTableList();
            ListKH = new List<KH> { };
            foreach (tableKH item in TableList)
            {
                ListKH.Add(new KH { ID1 = item.ID, Ten1 = item.TenKH1 });
 
            }
            comboxMaKH.DataSource = ListKH;
            comboxMaKH.DisplayMember = "ID1";
            comboxTenKH.DataSource = ListKH;
            comboxTenKH.DisplayMember = "Ten1";
        }
        /*Xử Lý Vào hôm sau*/
        private void A_Click(object sender, EventArgs e)
        {

            Button a= (Button)sender;
            string c = a.Text.ToString();
            string[] l = c.ToString().Split(':',' ');
            textBoxMACB.Text = l[1];

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Infoaccount a = new Infoaccount();
            this.Hide();
            a.ShowDialog();
            this.Show();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSet a = new AdminSet();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_searchCB_Click(object sender, EventArgs e)
        {
            string a;
            string b;
            DateTime c;
            a = comboxEND.Text.ToString();
            b = comboxNKH.Text.ToString();
            c = dateTimeCB.Value;
            c = c.Date;
           string[] l = c.ToString().Split(' ');
         
            
            if (a == b)
            {
                MessageBox.Show("Hãy Kiểm Tra Lại Nội Dung Bạn Vừa Nhập!!!!", "Lỗi trùng nơi khởi hành", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCB(b,a,l[0]);
            
        }
        void LoadCB(string NKH,string ND, string NG)
        {
            List<table> TableList = ChuyenBay.Instance.LoadTableList();
            flowLayoutPanel1.Controls.Clear();
            foreach (table item in TableList)
            { 
            string k;
                    k = item.NGKH1.ToString();
                    string[] cut = k.Split(' ');
                //MessageBox.Show(item.NoiKH1 + item.NoiDen1 + cut[0]);
                if(item.NoiKH1==NKH && item.NoiDen1==ND && cut[0]==NG)
                {
                   
                    Button a = new Button() { Width = ChuyenBay.TableWidth, Height = ChuyenBay.TableHeight };
                    a.Text = "Mã:" + item.ID + " NoiKH:" + item.NoiKH1 + " NoiDen:" + item.NoiDen1 + "NG:" + cut[0] ;

                switch (item.Status)
                {
                    case "Còn":
                        a.BackColor = Color.Aqua;
                        break;
                    default:
                        a.BackColor = Color.Red;
                        break;
                }
                flowLayoutPanel1.Controls.Add(a); 
                    a.Click+= A_Click;
                }
            }
        }
        public class MaHD
        {
            string Ma;

            public string MaHD1 { get => Ma; set => Ma = value; }
        }

        public class HD
        {
            string MaHD;string MaKH;string MaNV; string TG;

            public string MaHD1 { get => MaHD; set => MaHD = value; }
            public string MaKH1 { get => MaKH; set => MaKH = value; }
            public string MaNV1 { get => MaNV; set => MaNV = value; }
            public string TG1 { get => TG; set => TG = value; }
        }
        public class KH
        {
            string ID;
            string Ten;

            public string Ten1 { get => Ten; set => Ten = value; }
            public string ID1 { get => ID; set => ID = value; }
        }
        public class DiaDiem
        {
            string Noi;

            public string Noi1 { get => Noi; set => Noi = value; }
        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            BoleanKH = true;
            List<MaHD> ListMHD = new List<MaHD> { };
            string a=comboxMaKH.Text.ToString();
            System.Collections.IList list = ListHD;
            for (int i = 0; i < list.Count; i++)
            {
                if(ListHD[i].MaKH1==a)
                {
                    ListMHD.Add(new MaHD { MaHD1 = ListHD[i].MaHD1 });
                }
            }
            comboMAHD.DataSource = ListMHD;
            comboMAHD.DisplayMember = "MaHD1";
            comboBoxMaHD2.DataSource = ListMHD;
            comboBoxMaHD2.DisplayMember = "MaHD1";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check=true;
            string MV = textBoxMV.Text.ToString();
            if(MV.Length!=8)
            {
                check = false;
                MessageBox.Show("Nhap Sai Ma Ve!!! Vui lòng Kiểm tra lại.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string MaHD = comboMAHD.Text.ToString();
            if (MaHD.Length == 0)
            {
                check = false;
                MessageBox.Show("Chưa chọn hóa đơn!!! Vui lòng Kiểm tra lại.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string MaCB = textBoxMACB.Text.ToString();
            if(MaCB.Length==0)
            {
                check = false;
                MessageBox.Show("Chưa chọn chuyến bay!!! Vui lòng Kiểm tra lại.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string Loai = comboBoxLoaiVe.Text.ToString();
            if (Loai.Length == 0)
            {
                check = false;
                MessageBox.Show("Chưa chọn Loai ve!!! Vui lòng Kiểm tra lại.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string cho = textBoxCN.Text.ToString();
            if (cho.Length != 4)
            {
                check = false;
                MessageBox.Show("Nhập Sai Chổ Ngồi!!! Vui lòng Kiểm tra lại.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string Gia=textBoxGia.Text.ToString();
            
            textBoxGia.Text = Gia;
            if(check)
            { 
            string k = string.Format("INSERT INTO Ve VALUES('{0}','{1}','{2}',N'{3}','{4}','{5}')",MV,MaCB,MaHD,cho,Loai,Gia);
            DataTable dataTable = Dataprovider.Instance.ExcuteQury(k);
                MessageBox.Show("TẠO VÉ THÀNH CÔNG.", "THÔNG BÁO", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadHD();
               
            }
            /*if (dataTable.Rows.Count < 1)
            {
                label2.Show();
            }
            else
            {
                label2.Hide();
            }
            dataGridView_DT.DataSource = Dataprovider.Instance.ExcuteQury(k);*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox a = new ComboBox();
            a = (ComboBox)sender;
            if (a.Text.ToString() == "Thường")
            {
                textBoxGia.Text = "2000000";
            }
            else
            {
                textBoxGia.Text = "2500000";
            }
        }

        private void comboBoxMaHD2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox a = new ComboBox();
            a = (ComboBox)sender;
            System.Collections.IList list = ListHD;
            for (int i = 0; i < list.Count; i++)
            {
                if (ListHD[i].MaHD1 == a.Text)
                {
                    labelTriGiaTong.Text = "Tổng Tiền: "+ListHD[i].TG1;
                }
            }
        }
    }
}

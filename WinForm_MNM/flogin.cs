using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_MNM.DAO;

namespace WinForm_MNM
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?","Xác Nhận",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            string User = textBox1.Text.ToString();
            string Pass = textBox2.Text.ToString();

            if(login(User,Pass))
            { 
            Manegement a = new Manegement();
            this.Hide();
            a.ShowDialog();
            this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!!", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        bool login(string User,string Pass)
        {
            return AccDAO.Instance.Login(User,Pass);
        }
    }
}

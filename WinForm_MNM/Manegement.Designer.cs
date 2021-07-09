
namespace WinForm_MNM
{
    partial class Manegement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manegement));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxLoaiVe = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboMAHD = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMV = new System.Windows.Forms.TextBox();
            this.textBoxCN = new System.Windows.Forms.TextBox();
            this.textBoxMACB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTriGiaTong = new System.Windows.Forms.Label();
            this.comboBoxMaHD2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown_GG = new System.Windows.Forms.NumericUpDown();
            this.bTN_Giamgia = new System.Windows.Forms.Button();
            this.btn_TT = new System.Windows.Forms.Button();
            this.comboxNKH = new System.Windows.Forms.ComboBox();
            this.comboxEND = new System.Windows.Forms.ComboBox();
            this.bt_searchCB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeCB = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChonKH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboxTenKH = new System.Windows.Forms.ComboBox();
            this.comboxMaKH = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GG)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxLoaiVe);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBoxGia);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.comboMAHD);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxMV);
            this.panel2.Controls.Add(this.textBoxCN);
            this.panel2.Controls.Add(this.textBoxMACB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(503, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 201);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBoxLoaiVe
            // 
            this.comboBoxLoaiVe.FormattingEnabled = true;
            this.comboBoxLoaiVe.Items.AddRange(new object[] {
            "Thường",
            "Thương Gia"});
            this.comboBoxLoaiVe.Location = new System.Drawing.Point(88, 103);
            this.comboBoxLoaiVe.Name = "comboBoxLoaiVe";
            this.comboBoxLoaiVe.Size = new System.Drawing.Size(217, 28);
            this.comboBoxLoaiVe.TabIndex = 13;
            this.comboBoxLoaiVe.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiVe_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mã CB:";
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(88, 171);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(217, 27);
            this.textBoxGia.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Chổ Ngồi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã HD:";
            // 
            // comboMAHD
            // 
            this.comboMAHD.FormattingEnabled = true;
            this.comboMAHD.Location = new System.Drawing.Point(88, 4);
            this.comboMAHD.Name = "comboMAHD";
            this.comboMAHD.Size = new System.Drawing.Size(217, 28);
            this.comboMAHD.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm vào HD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMV
            // 
            this.textBoxMV.Location = new System.Drawing.Point(88, 71);
            this.textBoxMV.Name = "textBoxMV";
            this.textBoxMV.Size = new System.Drawing.Size(217, 27);
            this.textBoxMV.TabIndex = 5;
            // 
            // textBoxCN
            // 
            this.textBoxCN.Location = new System.Drawing.Point(88, 138);
            this.textBoxCN.Name = "textBoxCN";
            this.textBoxCN.Size = new System.Drawing.Size(217, 27);
            this.textBoxCN.TabIndex = 4;
            this.textBoxCN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxMACB
            // 
            this.textBoxMACB.Location = new System.Drawing.Point(88, 38);
            this.textBoxMACB.Name = "textBoxMACB";
            this.textBoxMACB.Size = new System.Drawing.Size(217, 27);
            this.textBoxMACB.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Giá:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loại Vé:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Vé:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelTriGiaTong);
            this.panel3.Controls.Add(this.comboBoxMaHD2);
            this.panel3.Controls.Add(this.numericUpDown_GG);
            this.panel3.Controls.Add(this.bTN_Giamgia);
            this.panel3.Controls.Add(this.btn_TT);
            this.panel3.Location = new System.Drawing.Point(528, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 64);
            this.panel3.TabIndex = 3;
            // 
            // labelTriGiaTong
            // 
            this.labelTriGiaTong.AutoSize = true;
            this.labelTriGiaTong.Location = new System.Drawing.Point(23, 36);
            this.labelTriGiaTong.Name = "labelTriGiaTong";
            this.labelTriGiaTong.Size = new System.Drawing.Size(75, 20);
            this.labelTriGiaTong.TabIndex = 15;
            this.labelTriGiaTong.Text = "Tổng tiền:";
            // 
            // comboBoxMaHD2
            // 
            this.comboBoxMaHD2.FormattingEnabled = true;
            this.comboBoxMaHD2.Location = new System.Drawing.Point(23, 3);
            this.comboBoxMaHD2.Name = "comboBoxMaHD2";
            this.comboBoxMaHD2.Size = new System.Drawing.Size(217, 28);
            this.comboBoxMaHD2.TabIndex = 14;
            this.comboBoxMaHD2.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaHD2_SelectedIndexChanged);
            // 
            // numericUpDown_GG
            // 
            this.numericUpDown_GG.Location = new System.Drawing.Point(247, 34);
            this.numericUpDown_GG.Name = "numericUpDown_GG";
            this.numericUpDown_GG.Size = new System.Drawing.Size(74, 27);
            this.numericUpDown_GG.TabIndex = 2;
            // 
            // bTN_Giamgia
            // 
            this.bTN_Giamgia.Location = new System.Drawing.Point(247, 3);
            this.bTN_Giamgia.Name = "bTN_Giamgia";
            this.bTN_Giamgia.Size = new System.Drawing.Size(74, 29);
            this.bTN_Giamgia.TabIndex = 1;
            this.bTN_Giamgia.Text = "Giảm giá";
            this.bTN_Giamgia.UseVisualStyleBackColor = true;
            // 
            // btn_TT
            // 
            this.btn_TT.Location = new System.Drawing.Point(328, 3);
            this.btn_TT.Name = "btn_TT";
            this.btn_TT.Size = new System.Drawing.Size(71, 58);
            this.btn_TT.TabIndex = 0;
            this.btn_TT.Text = "Thanh Toán";
            this.btn_TT.UseVisualStyleBackColor = true;
            // 
            // comboxNKH
            // 
            this.comboxNKH.FormattingEnabled = true;
            this.comboxNKH.Location = new System.Drawing.Point(129, 0);
            this.comboxNKH.Name = "comboxNKH";
            this.comboxNKH.Size = new System.Drawing.Size(250, 28);
            this.comboxNKH.TabIndex = 4;
            // 
            // comboxEND
            // 
            this.comboxEND.FormattingEnabled = true;
            this.comboxEND.Location = new System.Drawing.Point(129, 32);
            this.comboxEND.Name = "comboxEND";
            this.comboxEND.Size = new System.Drawing.Size(250, 28);
            this.comboxEND.TabIndex = 5;
            // 
            // bt_searchCB
            // 
            this.bt_searchCB.Location = new System.Drawing.Point(755, 71);
            this.bt_searchCB.Name = "bt_searchCB";
            this.bt_searchCB.Size = new System.Drawing.Size(94, 28);
            this.bt_searchCB.TabIndex = 6;
            this.bt_searchCB.Text = "Tìm";
            this.bt_searchCB.UseVisualStyleBackColor = true;
            this.bt_searchCB.Click += new System.EventHandler(this.bt_searchCB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nơi Khởi Hành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nơi Đến:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dateTimeCB);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboxEND);
            this.panel4.Controls.Add(this.comboxNKH);
            this.panel4.Location = new System.Drawing.Point(12, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 68);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày Đi:";
            // 
            // dateTimeCB
            // 
            this.dateTimeCB.Location = new System.Drawing.Point(474, 3);
            this.dateTimeCB.Name = "dateTimeCB";
            this.dateTimeCB.Size = new System.Drawing.Size(250, 27);
            this.dateTimeCB.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnChonKH);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.comboxTenKH);
            this.panel5.Controls.Add(this.comboxMaKH);
            this.panel5.Location = new System.Drawing.Point(15, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(482, 68);
            this.panel5.TabIndex = 11;
            // 
            // btnChonKH
            // 
            this.btnChonKH.Location = new System.Drawing.Point(382, 30);
            this.btnChonKH.Name = "btnChonKH";
            this.btnChonKH.Size = new System.Drawing.Size(94, 29);
            this.btnChonKH.TabIndex = 9;
            this.btnChonKH.Text = "Chọn";
            this.btnChonKH.UseVisualStyleBackColor = true;
            this.btnChonKH.Click += new System.EventHandler(this.btnChonKH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Khách Hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Họ Tên:";
            // 
            // comboxTenKH
            // 
            this.comboxTenKH.FormattingEnabled = true;
            this.comboxTenKH.Location = new System.Drawing.Point(126, 31);
            this.comboxTenKH.Name = "comboxTenKH";
            this.comboxTenKH.Size = new System.Drawing.Size(250, 28);
            this.comboxTenKH.TabIndex = 5;
            // 
            // comboxMaKH
            // 
            this.comboxMaKH.FormattingEnabled = true;
            this.comboxMaKH.Location = new System.Drawing.Point(126, 0);
            this.comboxMaKH.Name = "comboxMaKH";
            this.comboxMaKH.Size = new System.Drawing.Size(250, 28);
            this.comboxMaKH.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 269);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Danh sách chuyến bay:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(506, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Xuất Vé:";
            // 
            // Manegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 484);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bt_searchCB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manegement";
            this.Text = "Quản Lý Bán Vé Máy Bay";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GG)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboxNKH;
        private System.Windows.Forms.ComboBox comboxEND;
        private System.Windows.Forms.Button bt_searchCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeCB;
        private System.Windows.Forms.NumericUpDown numericUpDown_GG;
        private System.Windows.Forms.Button bTN_Giamgia;
        private System.Windows.Forms.Button btn_TT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboxTenKH;
        private System.Windows.Forms.ComboBox comboxMaKH;
        private System.Windows.Forms.Button btnChonKH;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMV;
        private System.Windows.Forms.TextBox textBoxCN;
        private System.Windows.Forms.TextBox textBoxMACB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboMAHD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxLoaiVe;
        private System.Windows.Forms.ComboBox comboBoxMaHD2;
        private System.Windows.Forms.Label labelTriGiaTong;
    }
}
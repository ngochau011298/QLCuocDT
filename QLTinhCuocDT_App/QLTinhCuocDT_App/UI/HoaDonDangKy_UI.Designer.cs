namespace QLTinhCuocDT_App.UI
{
    partial class HoaDonDangKy_UI
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvHoaDonDK = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.retype = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxChiPhiDK = new System.Windows.Forms.TextBox();
            this.tbxTenKH = new System.Windows.Forms.TextBox();
            this.tbxIDSIM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaHHDK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MaHDDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhiDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHoaDonDK)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDangKyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 353);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.dvHoaDonDK);
            this.groupBox3.Location = new System.Drawing.Point(400, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 239);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dvHoaDonDK
            // 
            this.dvHoaDonDK.AllowUserToAddRows = false;
            this.dvHoaDonDK.AllowUserToDeleteRows = false;
            this.dvHoaDonDK.AutoGenerateColumns = false;
            this.dvHoaDonDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvHoaDonDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDDK,
            this.IDSIM,
            this.ChiPhiDangKy,
            this.TenKH});
            this.dvHoaDonDK.DataSource = this.hoaDonDangKyBindingSource;
            this.dvHoaDonDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHoaDonDK.Location = new System.Drawing.Point(3, 16);
            this.dvHoaDonDK.Name = "dvHoaDonDK";
            this.dvHoaDonDK.ReadOnly = true;
            this.dvHoaDonDK.Size = new System.Drawing.Size(430, 220);
            this.dvHoaDonDK.TabIndex = 0;
            this.dvHoaDonDK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvHoaDonDK_CellClick);
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox4.Controls.Add(this.tbxsearch);
            this.groupBox4.Controls.Add(this.retype);
            this.groupBox4.Controls.Add(this.tim);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(0, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 108);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(147, 20);
            this.tbxsearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(234, 20);
            this.tbxsearch.TabIndex = 4;
            // 
            // retype
            // 
            this.retype.BackColor = System.Drawing.Color.Orange;
            this.retype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.retype.Location = new System.Drawing.Point(272, 59);
            this.retype.Margin = new System.Windows.Forms.Padding(4);
            this.retype.Name = "retype";
            this.retype.Size = new System.Drawing.Size(109, 33);
            this.retype.TabIndex = 6;
            this.retype.Text = "Làm mới";
            this.retype.UseVisualStyleBackColor = false;
            this.retype.Click += new System.EventHandler(this.retype_Click);
            // 
            // tim
            // 
            this.tim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tim.Location = new System.Drawing.Point(147, 59);
            this.tim.Margin = new System.Windows.Forms.Padding(4);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(109, 33);
            this.tim.TabIndex = 5;
            this.tim.Text = "Tìm kiếm";
            this.tim.UseVisualStyleBackColor = false;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nhập thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Location = new System.Drawing.Point(400, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.Salmon;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.Location = new System.Drawing.Point(167, 18);
            this.xoa.Margin = new System.Windows.Forms.Padding(4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(116, 33);
            this.xoa.TabIndex = 7;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.tbxChiPhiDK);
            this.groupBox1.Controls.Add(this.tbxTenKH);
            this.groupBox1.Controls.Add(this.tbxIDSIM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxMaHHDK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // tbxChiPhiDK
            // 
            this.tbxChiPhiDK.BackColor = System.Drawing.Color.White;
            this.tbxChiPhiDK.Location = new System.Drawing.Point(147, 119);
            this.tbxChiPhiDK.Margin = new System.Windows.Forms.Padding(4);
            this.tbxChiPhiDK.Name = "tbxChiPhiDK";
            this.tbxChiPhiDK.ReadOnly = true;
            this.tbxChiPhiDK.Size = new System.Drawing.Size(234, 22);
            this.tbxChiPhiDK.TabIndex = 3;
            // 
            // tbxTenKH
            // 
            this.tbxTenKH.BackColor = System.Drawing.Color.White;
            this.tbxTenKH.Location = new System.Drawing.Point(147, 59);
            this.tbxTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTenKH.Name = "tbxTenKH";
            this.tbxTenKH.ReadOnly = true;
            this.tbxTenKH.Size = new System.Drawing.Size(234, 22);
            this.tbxTenKH.TabIndex = 1;
            // 
            // tbxIDSIM
            // 
            this.tbxIDSIM.BackColor = System.Drawing.Color.White;
            this.tbxIDSIM.Location = new System.Drawing.Point(147, 89);
            this.tbxIDSIM.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIDSIM.Name = "tbxIDSIM";
            this.tbxIDSIM.ReadOnly = true;
            this.tbxIDSIM.Size = new System.Drawing.Size(234, 22);
            this.tbxIDSIM.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chi phí đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "IDSIM";
            // 
            // tbxMaHHDK
            // 
            this.tbxMaHHDK.Location = new System.Drawing.Point(147, 29);
            this.tbxMaHHDK.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaHHDK.Name = "tbxMaHHDK";
            this.tbxMaHHDK.ReadOnly = true;
            this.tbxMaHHDK.Size = new System.Drawing.Size(234, 22);
            this.tbxMaHHDK.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn đăng ký";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 42);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "HÓA ĐƠN ĐĂNG KÝ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Trở về danh mục";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaHDDK
            // 
            this.MaHDDK.DataPropertyName = "MaHDDK";
            this.MaHDDK.HeaderText = "Mã hóa đơn đăng ký";
            this.MaHDDK.Name = "MaHDDK";
            this.MaHDDK.ReadOnly = true;
            // 
            // IDSIM
            // 
            this.IDSIM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDSIM.DataPropertyName = "IDSIM";
            this.IDSIM.HeaderText = "IDSIM";
            this.IDSIM.Name = "IDSIM";
            this.IDSIM.ReadOnly = true;
            // 
            // ChiPhiDangKy
            // 
            this.ChiPhiDangKy.DataPropertyName = "ChiPhiDangKy";
            this.ChiPhiDangKy.HeaderText = "Chi phí đăng ký";
            this.ChiPhiDangKy.Name = "ChiPhiDangKy";
            this.ChiPhiDangKy.ReadOnly = true;
            // 
            // hoaDonDangKyBindingSource
            // 
            this.hoaDonDangKyBindingSource.DataSource = typeof(QLTinhCuocDT_App.Entity.HoaDonDangKy);
            // 
            // HoaDonDangKy_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(836, 353);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDonDangKy_UI";
            this.Text = "Quản lý hóa đơn đăng ký";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDonDangKy_UI_FormClosing);
            this.Load += new System.EventHandler(this.HoaDonDangKy_UI_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHoaDonDK)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDangKyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dvHoaDonDK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button retype;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxChiPhiDK;
        private System.Windows.Forms.TextBox tbxTenKH;
        private System.Windows.Forms.TextBox tbxIDSIM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMaHHDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhiDangKy;
        private System.Windows.Forms.BindingSource hoaDonDangKyBindingSource;
    }
}
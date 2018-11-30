namespace QLTinhCuocDT_App.UI
{
    partial class ThongTinSim_UI
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
            this.xoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.retype = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvThongTinSim = new System.Windows.Forms.DataGridView();
            this.IDSIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongTinSIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTenKH = new System.Windows.Forms.TextBox();
            this.tbxIDSIM = new System.Windows.Forms.TextBox();
            this.tbxNgayDangKy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTinSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinSIMBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.Salmon;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.Location = new System.Drawing.Point(685, 20);
            this.xoa.Margin = new System.Windows.Forms.Padding(4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(109, 33);
            this.xoa.TabIndex = 7;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.SpringGreen;
            this.them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(131, 20);
            this.them.Margin = new System.Windows.Forms.Padding(4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(109, 33);
            this.them.TabIndex = 5;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(131, 20);
            this.tbxsearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(442, 20);
            this.tbxsearch.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nhập thông tin";
            // 
            // retype
            // 
            this.retype.BackColor = System.Drawing.Color.Orange;
            this.retype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.retype.Location = new System.Drawing.Point(760, 12);
            this.retype.Margin = new System.Windows.Forms.Padding(4);
            this.retype.Name = "retype";
            this.retype.Size = new System.Drawing.Size(109, 33);
            this.retype.TabIndex = 8;
            this.retype.Text = "Làm mới";
            this.retype.UseVisualStyleBackColor = false;
            this.retype.Click += new System.EventHandler(this.retype_Click);
            // 
            // tim
            // 
            this.tim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tim.Location = new System.Drawing.Point(598, 12);
            this.tim.Margin = new System.Windows.Forms.Padding(4);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(109, 33);
            this.tim.TabIndex = 9;
            this.tim.Text = "Tìm kiếm";
            this.tim.UseVisualStyleBackColor = false;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua.Location = new System.Drawing.Point(404, 20);
            this.sua.Margin = new System.Windows.Forms.Padding(4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(109, 33);
            this.sua.TabIndex = 6;
            this.sua.Text = "Cập nhật";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.dvThongTinSim);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 262);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dvThongTinSim
            // 
            this.dvThongTinSim.AllowUserToAddRows = false;
            this.dvThongTinSim.AllowUserToDeleteRows = false;
            this.dvThongTinSim.AutoGenerateColumns = false;
            this.dvThongTinSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTinSim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSIM,
            this.TenKH,
            this.NgayDangKy,
            this.NgayHetHan});
            this.dvThongTinSim.DataSource = this.thongTinSIMBindingSource;
            this.dvThongTinSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvThongTinSim.Location = new System.Drawing.Point(3, 16);
            this.dvThongTinSim.Name = "dvThongTinSim";
            this.dvThongTinSim.ReadOnly = true;
            this.dvThongTinSim.Size = new System.Drawing.Size(916, 243);
            this.dvThongTinSim.TabIndex = 0;
            this.dvThongTinSim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvThongTinSim_CellClick);
            // 
            // IDSIM
            // 
            this.IDSIM.DataPropertyName = "IDSIM";
            this.IDSIM.HeaderText = "IDSIM";
            this.IDSIM.Name = "IDSIM";
            this.IDSIM.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.HeaderText = "Chủ sở hữu";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDangKy.DataPropertyName = "NgayDangKy";
            this.NgayDangKy.HeaderText = "Ngày đăng ký";
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            // 
            // thongTinSIMBindingSource
            // 
            this.thongTinSIMBindingSource.DataSource = typeof(QLTinhCuocDT_App.Entity.ThongTinSIM);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.tbxsearch);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.retype);
            this.groupBox4.Controls.Add(this.tim);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(922, 53);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
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
            this.panel1.Size = new System.Drawing.Size(922, 618);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(922, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.dtpNgayHetHan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxTenKH);
            this.groupBox1.Controls.Add(this.tbxIDSIM);
            this.groupBox1.Controls.Add(this.tbxNgayDangKy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(598, 115);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(213, 22);
            this.dtpNgayHetHan.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ngày hết hạn";
            // 
            // tbxTenKH
            // 
            this.tbxTenKH.BackColor = System.Drawing.Color.White;
            this.tbxTenKH.Location = new System.Drawing.Point(598, 43);
            this.tbxTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTenKH.Name = "tbxTenKH";
            this.tbxTenKH.ReadOnly = true;
            this.tbxTenKH.Size = new System.Drawing.Size(213, 22);
            this.tbxTenKH.TabIndex = 20;
            // 
            // tbxIDSIM
            // 
            this.tbxIDSIM.BackColor = System.Drawing.Color.White;
            this.tbxIDSIM.Location = new System.Drawing.Point(193, 43);
            this.tbxIDSIM.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIDSIM.Name = "tbxIDSIM";
            this.tbxIDSIM.ReadOnly = true;
            this.tbxIDSIM.Size = new System.Drawing.Size(213, 22);
            this.tbxIDSIM.TabIndex = 18;
            // 
            // tbxNgayDangKy
            // 
            this.tbxNgayDangKy.BackColor = System.Drawing.Color.White;
            this.tbxNgayDangKy.Location = new System.Drawing.Point(193, 115);
            this.tbxNgayDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNgayDangKy.Name = "tbxNgayDangKy";
            this.tbxNgayDangKy.ReadOnly = true;
            this.tbxNgayDangKy.Size = new System.Drawing.Size(213, 22);
            this.tbxNgayDangKy.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chủ sở hữu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày đăng ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "IDSIM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 42);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "THÔNG TIN SIM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Trở về danh mục";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongTinSim_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 618);
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinSim_UI";
            this.Text = "Quản lý thông tin SIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongTinSim_UI_FormClosing);
            this.Load += new System.EventHandler(this.ThongTinSim_UI_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTinSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinSIMBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button retype;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dvThongTinSim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxTenKH;
        private System.Windows.Forms.TextBox tbxIDSIM;
        private System.Windows.Forms.TextBox tbxNgayDangKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource thongTinSIMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
    }
}
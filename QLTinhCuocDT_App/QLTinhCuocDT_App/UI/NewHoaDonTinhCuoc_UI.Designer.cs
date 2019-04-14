namespace QLTinhCuocDT_App.UI
{
    partial class NewHoaDonTinhCuoc_UI
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvThongTinSIM = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIDSIM = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numPhiThueBao = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.IDSIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongTinSIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTinSIM)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiThueBao)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinSIMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 61);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "LẬP HÓA ĐƠN TÍNH CƯỚC";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 231);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn SIM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dvThongTinSIM);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 161);
            this.panel3.TabIndex = 21;
            // 
            // dvThongTinSIM
            // 
            this.dvThongTinSIM.AllowUserToAddRows = false;
            this.dvThongTinSIM.AllowUserToDeleteRows = false;
            this.dvThongTinSIM.AutoGenerateColumns = false;
            this.dvThongTinSIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTinSIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSIM,
            this.TenKH,
            this.NgayDangKy,
            this.NgayHetHan});
            this.dvThongTinSIM.DataSource = this.thongTinSIMBindingSource;
            this.dvThongTinSIM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvThongTinSIM.Location = new System.Drawing.Point(0, 0);
            this.dvThongTinSIM.Name = "dvThongTinSIM";
            this.dvThongTinSIM.ReadOnly = true;
            this.dvThongTinSIM.Size = new System.Drawing.Size(427, 161);
            this.dvThongTinSIM.TabIndex = 0;
            this.dvThongTinSIM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvThongTinSIM_CellClick);
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.HeaderText = "Chủ sở hữu";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbxIDSIM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 49);
            this.panel2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "IDSIM";
            // 
            // tbxIDSIM
            // 
            this.tbxIDSIM.BackColor = System.Drawing.Color.White;
            this.tbxIDSIM.Location = new System.Drawing.Point(130, 15);
            this.tbxIDSIM.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIDSIM.Name = "tbxIDSIM";
            this.tbxIDSIM.ReadOnly = true;
            this.tbxIDSIM.Size = new System.Drawing.Size(234, 22);
            this.tbxIDSIM.TabIndex = 19;
            this.tbxIDSIM.TextChanged += new System.EventHandler(this.tbxIDSIM_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.numPhiThueBao);
            this.groupBox2.Controls.Add(this.dtpNgayLapHD);
            this.groupBox2.Controls.Add(this.tbxTongTien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 162);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // numPhiThueBao
            // 
            this.numPhiThueBao.BackColor = System.Drawing.Color.White;
            this.numPhiThueBao.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPhiThueBao.Location = new System.Drawing.Point(134, 68);
            this.numPhiThueBao.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numPhiThueBao.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numPhiThueBao.Name = "numPhiThueBao";
            this.numPhiThueBao.ReadOnly = true;
            this.numPhiThueBao.Size = new System.Drawing.Size(234, 22);
            this.numPhiThueBao.TabIndex = 24;
            this.numPhiThueBao.ThousandsSeparator = true;
            this.numPhiThueBao.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numPhiThueBao.ValueChanged += new System.EventHandler(this.numPhiThueBao_ValueChanged);
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLapHD.Location = new System.Drawing.Point(134, 34);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(234, 22);
            this.dtpNgayLapHD.TabIndex = 18;
            this.dtpNgayLapHD.ValueChanged += new System.EventHandler(this.dtpNgayLapHD_ValueChanged);
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxTongTien.Location = new System.Drawing.Point(134, 97);
            this.tbxTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.ReadOnly = true;
            this.tbxTongTien.Size = new System.Drawing.Size(234, 22);
            this.tbxTongTien.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày lập hóa đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phí thuê bao";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cancel);
            this.panel4.Controls.Add(this.save);
            this.panel4.Location = new System.Drawing.Point(2, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 69);
            this.panel4.TabIndex = 7;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Salmon;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cancel.Location = new System.Drawing.Point(259, 16);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(109, 33);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Hủy bỏ";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.SpringGreen;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.save.Location = new System.Drawing.Point(134, 16);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(109, 33);
            this.save.TabIndex = 6;
            this.save.Text = "Lưu hóa đơn";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // IDSIM
            // 
            this.IDSIM.DataPropertyName = "IDSIM";
            this.IDSIM.HeaderText = "Thông tin SIM";
            this.IDSIM.Name = "IDSIM";
            this.IDSIM.ReadOnly = true;
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
            // NewHoaDonTinhCuoc_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 295);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "NewHoaDonTinhCuoc_UI";
            this.Text = "Lập hóa đơn mới";
            this.Load += new System.EventHandler(this.NewHoaDonTinhCuoc_UI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTinSIM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiThueBao)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thongTinSIMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxIDSIM;
        private System.Windows.Forms.DataGridView dvThongTinSIM;
        private System.Windows.Forms.BindingSource thongTinSIMBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.NumericUpDown numPhiThueBao;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
namespace QLTinhCuocDT_App.UI
{
    partial class GiaCuoc_UI
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaGiaCuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numGiaTien = new System.Windows.Forms.NumericUpDown();
            this.dtpTGKT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTGBD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvGiaCuoc = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.retype = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.them = new System.Windows.Forms.Button();
            this.MaGiaCuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaCuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGiaCuoc)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaCuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.Salmon;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.Location = new System.Drawing.Point(296, 24);
            this.xoa.Margin = new System.Windows.Forms.Padding(4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(109, 33);
            this.xoa.TabIndex = 6;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá tiền";
            // 
            // tbxMaGiaCuoc
            // 
            this.tbxMaGiaCuoc.Location = new System.Drawing.Point(132, 30);
            this.tbxMaGiaCuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaGiaCuoc.Name = "tbxMaGiaCuoc";
            this.tbxMaGiaCuoc.ReadOnly = true;
            this.tbxMaGiaCuoc.Size = new System.Drawing.Size(244, 22);
            this.tbxMaGiaCuoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã giá cước";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.numGiaTien);
            this.groupBox1.Controls.Add(this.dtpTGKT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpTGBD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxMaGiaCuoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 263);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // numGiaTien
            // 
            this.numGiaTien.BackColor = System.Drawing.Color.White;
            this.numGiaTien.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numGiaTien.Location = new System.Drawing.Point(132, 87);
            this.numGiaTien.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGiaTien.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numGiaTien.Name = "numGiaTien";
            this.numGiaTien.ReadOnly = true;
            this.numGiaTien.Size = new System.Drawing.Size(244, 22);
            this.numGiaTien.TabIndex = 2;
            this.numGiaTien.ThousandsSeparator = true;
            this.numGiaTien.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dtpTGKT
            // 
            this.dtpTGKT.CustomFormat = "HH : mm : ss";
            this.dtpTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGKT.Location = new System.Drawing.Point(132, 115);
            this.dtpTGKT.Name = "dtpTGKT";
            this.dtpTGKT.ShowUpDown = true;
            this.dtpTGKT.Size = new System.Drawing.Size(244, 22);
            this.dtpTGKT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // dtpTGBD
            // 
            this.dtpTGBD.CustomFormat = "HH : mm : ss";
            this.dtpTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGBD.Location = new System.Drawing.Point(132, 59);
            this.dtpTGBD.Name = "dtpTGBD";
            this.dtpTGBD.ShowUpDown = true;
            this.dtpTGBD.Size = new System.Drawing.Size(244, 22);
            this.dtpTGBD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thời gian bắt đầu";
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
            this.label8.Size = new System.Drawing.Size(229, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "QUẢN LÝ GIÁ CƯỚC";
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
            this.button1.TabIndex = 10;
            this.button1.Text = "Trở về danh mục";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua.Location = new System.Drawing.Point(166, 24);
            this.sua.Margin = new System.Windows.Forms.Padding(4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(109, 33);
            this.sua.TabIndex = 5;
            this.sua.Text = "Cập nhật";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
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
            this.panel1.Size = new System.Drawing.Size(836, 305);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.dvGiaCuoc);
            this.groupBox3.Location = new System.Drawing.Point(400, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 189);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dvGiaCuoc
            // 
            this.dvGiaCuoc.AllowUserToAddRows = false;
            this.dvGiaCuoc.AllowUserToDeleteRows = false;
            this.dvGiaCuoc.AutoGenerateColumns = false;
            this.dvGiaCuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvGiaCuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaCuoc,
            this.TGBD,
            this.TGKT,
            this.Gia});
            this.dvGiaCuoc.DataSource = this.giaCuocBindingSource;
            this.dvGiaCuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGiaCuoc.Location = new System.Drawing.Point(3, 16);
            this.dvGiaCuoc.Name = "dvGiaCuoc";
            this.dvGiaCuoc.ReadOnly = true;
            this.dvGiaCuoc.Size = new System.Drawing.Size(427, 170);
            this.dvGiaCuoc.TabIndex = 0;
            this.dvGiaCuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvGiaCuoc_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox4.Controls.Add(this.tbxsearch);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.retype);
            this.groupBox4.Controls.Add(this.tim);
            this.groupBox4.Location = new System.Drawing.Point(0, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 106);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(131, 20);
            this.tbxsearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(245, 20);
            this.tbxsearch.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nhập giá cước";
            // 
            // retype
            // 
            this.retype.BackColor = System.Drawing.Color.Orange;
            this.retype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.retype.Location = new System.Drawing.Point(267, 60);
            this.retype.Margin = new System.Windows.Forms.Padding(4);
            this.retype.Name = "retype";
            this.retype.Size = new System.Drawing.Size(109, 33);
            this.retype.TabIndex = 9;
            this.retype.Text = "Làm mới";
            this.retype.UseVisualStyleBackColor = false;
            this.retype.Click += new System.EventHandler(this.retype_Click);
            // 
            // tim
            // 
            this.tim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tim.Location = new System.Drawing.Point(131, 60);
            this.tim.Margin = new System.Windows.Forms.Padding(4);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(109, 33);
            this.tim.TabIndex = 8;
            this.tim.Text = "Tìm kiếm";
            this.tim.UseVisualStyleBackColor = false;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Location = new System.Drawing.Point(400, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.SpringGreen;
            this.them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(33, 24);
            this.them.Margin = new System.Windows.Forms.Padding(4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(109, 33);
            this.them.TabIndex = 4;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // MaGiaCuoc
            // 
            this.MaGiaCuoc.DataPropertyName = "MaGiaCuoc";
            this.MaGiaCuoc.HeaderText = "Mã giá cước";
            this.MaGiaCuoc.Name = "MaGiaCuoc";
            this.MaGiaCuoc.ReadOnly = true;
            // 
            // TGBD
            // 
            this.TGBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TGBD.DataPropertyName = "TGBD";
            this.TGBD.HeaderText = "Thời gian bắt đầu";
            this.TGBD.Name = "TGBD";
            this.TGBD.ReadOnly = true;
            // 
            // TGKT
            // 
            this.TGKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TGKT.DataPropertyName = "TGKT";
            this.TGKT.HeaderText = "Thời gian kết thúc";
            this.TGKT.Name = "TGKT";
            this.TGKT.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá tiền";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // giaCuocBindingSource
            // 
            this.giaCuocBindingSource.DataSource = typeof(QLTinhCuocDT_App.Entity.GiaCuoc);
            // 
            // GiaCuoc_UI
            // 
            this.AcceptButton = this.them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(836, 305);
            this.Controls.Add(this.panel1);
            this.Name = "GiaCuoc_UI";
            this.Text = "Quản lý giá cước";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiaCuoc_UI_FormClosing);
            this.Load += new System.EventHandler(this.GiaCuoc_UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGiaCuoc)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giaCuocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMaGiaCuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dvGiaCuoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button retype;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaCuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.BindingSource giaCuocBindingSource;
        private System.Windows.Forms.DateTimePicker dtpTGKT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTGBD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numGiaTien;
    }
}
namespace Random_File
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dvLog = new System.Windows.Forms.DataGridView();
            this.IDSIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRÌNH TẠO FILE LOG";
            // 
            // dvLog
            // 
            this.dvLog.AllowUserToAddRows = false;
            this.dvLog.AllowUserToDeleteRows = false;
            this.dvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSIM,
            this.TGBD,
            this.TGKT});
            this.dvLog.Location = new System.Drawing.Point(3, 114);
            this.dvLog.Name = "dvLog";
            this.dvLog.ReadOnly = true;
            this.dvLog.Size = new System.Drawing.Size(960, 333);
            this.dvLog.TabIndex = 1;
            // 
            // IDSIM
            // 
            this.IDSIM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDSIM.HeaderText = "IDSIM";
            this.IDSIM.Name = "IDSIM";
            this.IDSIM.ReadOnly = true;
            // 
            // TGBD
            // 
            this.TGBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TGBD.HeaderText = "TGBD";
            this.TGBD.Name = "TGBD";
            this.TGBD.ReadOnly = true;
            // 
            // TGKT
            // 
            this.TGKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TGKT.HeaderText = "TGKT";
            this.TGKT.Name = "TGKT";
            this.TGKT.ReadOnly = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(463, 64);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(90, 35);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Tạo dữ liệu";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(463, 461);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 35);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Xuất file log";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(864, 461);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 35);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Nhập file log";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Insert);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnRandom);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.dvLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 508);
            this.panel1.TabIndex = 5;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(864, 64);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(90, 35);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Lưu vào CSDL";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 508);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvLog;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGKT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Insert;
    }
}


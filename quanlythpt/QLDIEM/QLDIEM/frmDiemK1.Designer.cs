namespace QLDIEM
{
    partial class frmDiemKyI
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
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.gridDiem = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D451 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D452 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDTBM = new System.Windows.Forms.TextBox();
            this.cmbMH = new System.Windows.Forms.ComboBox();
            this.txtThi = new System.Windows.Forms.TextBox();
            this.txt1Tiet2 = new System.Windows.Forms.TextBox();
            this.txt1Tiet1 = new System.Windows.Forms.TextBox();
            this.txt15p = new System.Windows.Forms.TextBox();
            this.txtMieng = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDSHS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(480, 23);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(155, 21);
            this.cmbLop.TabIndex = 0;
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbMaMH_SelectedIndexChanged);
            this.cmbLop.SelectedValueChanged += new System.EventHandler(this.cmbLop_SelectedValueChanged);
            this.cmbLop.Click += new System.EventHandler(this.cmbMaMH_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimKiem.Location = new System.Drawing.Point(77, 32);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(49, 13);
            this.lblTimKiem.TabIndex = 16;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // gridDiem
            // 
            this.gridDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.DiemMieng,
            this.D15,
            this.D451,
            this.D452,
            this.DT,
            this.Column1});
            this.gridDiem.Location = new System.Drawing.Point(33, 329);
            this.gridDiem.Name = "gridDiem";
            this.gridDiem.ReadOnly = true;
            this.gridDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiem.Size = new System.Drawing.Size(758, 168);
            this.gridDiem.TabIndex = 4;
            this.gridDiem.SelectionChanged += new System.EventHandler(this.gridDiem_SelectionChanged);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            // 
            // DiemMieng
            // 
            this.DiemMieng.DataPropertyName = "DMK1";
            this.DiemMieng.HeaderText = "Điểm miệng";
            this.DiemMieng.Name = "DiemMieng";
            this.DiemMieng.ReadOnly = true;
            // 
            // D15
            // 
            this.D15.DataPropertyName = "D15K1";
            this.D15.HeaderText = "Điểm 15 phút";
            this.D15.Name = "D15";
            this.D15.ReadOnly = true;
            // 
            // D451
            // 
            this.D451.DataPropertyName = "D45K11";
            this.D451.HeaderText = "Điểm 45 phút/L1";
            this.D451.Name = "D451";
            this.D451.ReadOnly = true;
            // 
            // D452
            // 
            this.D452.DataPropertyName = "D45K12";
            this.D452.HeaderText = "Điểm 45 phút/L2";
            this.D452.Name = "D452";
            this.D452.ReadOnly = true;
            // 
            // DT
            // 
            this.DT.DataPropertyName = "DTK1";
            this.DT.HeaderText = "Điểm thi";
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DTBMK1";
            this.Column1.HeaderText = "Điểm TBM";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(656, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Image = global::QLDIEM.Properties.Resources.Exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(28, 196);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = global::QLDIEM.Properties.Resources.Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(28, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = global::QLDIEM.Properties.Resources.Save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(28, 152);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = global::QLDIEM.Properties.Resources.Modify;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(28, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = global::QLDIEM.Properties.Resources.Delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(28, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDTBM);
            this.groupBox1.Controls.Add(this.cmbMH);
            this.groupBox1.Controls.Add(this.txtThi);
            this.groupBox1.Controls.Add(this.txt1Tiet2);
            this.groupBox1.Controls.Add(this.txt1Tiet1);
            this.groupBox1.Controls.Add(this.txt15p);
            this.groupBox1.Controls.Add(this.txtMieng);
            this.groupBox1.Controls.Add(this.txtMaHS);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.txtTenHS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 239);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtDTBM
            // 
            this.txtDTBM.Location = new System.Drawing.Point(138, 205);
            this.txtDTBM.Name = "txtDTBM";
            this.txtDTBM.Size = new System.Drawing.Size(164, 20);
            this.txtDTBM.TabIndex = 9;
            // 
            // cmbMH
            // 
            this.cmbMH.FormattingEnabled = true;
            this.cmbMH.Location = new System.Drawing.Point(138, 120);
            this.cmbMH.Name = "cmbMH";
            this.cmbMH.Size = new System.Drawing.Size(164, 21);
            this.cmbMH.TabIndex = 2;
            this.cmbMH.SelectedIndexChanged += new System.EventHandler(this.cmbMaMH_SelectedIndexChanged);
            this.cmbMH.SelectionChangeCommitted += new System.EventHandler(this.cmbMH_SelectionChangeCommitted);
            this.cmbMH.Click += new System.EventHandler(this.cmbMaMH_Click);
            // 
            // txtThi
            // 
            this.txtThi.Location = new System.Drawing.Point(474, 208);
            this.txtThi.Name = "txtThi";
            this.txtThi.Size = new System.Drawing.Size(76, 20);
            this.txtThi.TabIndex = 8;
            // 
            // txt1Tiet2
            // 
            this.txt1Tiet2.Location = new System.Drawing.Point(474, 163);
            this.txt1Tiet2.Name = "txt1Tiet2";
            this.txt1Tiet2.Size = new System.Drawing.Size(76, 20);
            this.txt1Tiet2.TabIndex = 7;
            // 
            // txt1Tiet1
            // 
            this.txt1Tiet1.Location = new System.Drawing.Point(474, 118);
            this.txt1Tiet1.Name = "txt1Tiet1";
            this.txt1Tiet1.Size = new System.Drawing.Size(76, 20);
            this.txt1Tiet1.TabIndex = 6;
            // 
            // txt15p
            // 
            this.txt15p.Location = new System.Drawing.Point(474, 72);
            this.txt15p.Name = "txt15p";
            this.txt15p.Size = new System.Drawing.Size(76, 20);
            this.txt15p.TabIndex = 5;
            // 
            // txtMieng
            // 
            this.txtMieng.Location = new System.Drawing.Point(474, 26);
            this.txtMieng.Name = "txtMieng";
            this.txtMieng.Size = new System.Drawing.Size(76, 20);
            this.txtMieng.TabIndex = 4;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(138, 26);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(164, 20);
            this.txtMaHS.TabIndex = 0;
            this.txtMaHS.TextChanged += new System.EventHandler(this.txtMaHS_TextChanged);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(138, 164);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(164, 20);
            this.txtMaMH.TabIndex = 3;
            this.txtMaMH.TextChanged += new System.EventHandler(this.txtTenHS_TextChanged);
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(138, 72);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(164, 20);
            this.txtTenHS.TabIndex = 1;
            this.txtTenHS.TextChanged += new System.EventHandler(this.txtTenHS_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm 1 tiết/L2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm thi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm 1 tiết/L1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm 15 phút:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm miệng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã học sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Điểm TB";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Môn Học";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên môn học";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên học sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbDSHS
            // 
            this.cmbDSHS.FormattingEnabled = true;
            this.cmbDSHS.Location = new System.Drawing.Point(171, 24);
            this.cmbDSHS.Name = "cmbDSHS";
            this.cmbDSHS.Size = new System.Drawing.Size(293, 21);
            this.cmbDSHS.TabIndex = 2;
            this.cmbDSHS.SelectedIndexChanged += new System.EventHandler(this.cmbMaMH_SelectedIndexChanged);
            this.cmbDSHS.SelectedValueChanged += new System.EventHandler(this.cmbDSHS_SelectedValueChanged);
            this.cmbDSHS.Click += new System.EventHandler(this.cmbMaMH_Click);
            // 
            // frmDiemKyI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(829, 508);
            this.Controls.Add(this.cmbDSHS);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.gridDiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmDiemKyI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin điểm kỳ I";
            this.Load += new System.EventHandler(this.frmDiemK1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView gridDiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThi;
        private System.Windows.Forms.TextBox txt1Tiet2;
        private System.Windows.Forms.TextBox txt1Tiet1;
        private System.Windows.Forms.TextBox txt15p;
        private System.Windows.Forms.TextBox txtMieng;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMH;
        private System.Windows.Forms.ComboBox cmbDSHS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn D15;
        private System.Windows.Forms.DataGridViewTextBoxColumn D451;
        private System.Windows.Forms.DataGridViewTextBoxColumn D452;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtDTBM;
        private System.Windows.Forms.Label label10;
    }
}
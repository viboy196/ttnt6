namespace TTN_QLTV
{
    partial class NhanVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvnhanvien = new System.Windows.Forms.DataGridView();
            this.Column1MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.bthoat = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvnhanvien);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhân Viên";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtgvnhanvien
            // 
            this.dtgvnhanvien.AllowUserToAddRows = false;
            this.dtgvnhanvien.AllowUserToDeleteRows = false;
            this.dtgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1MaNV,
            this.Column1TenNV,
            this.Column1NgaySinh,
            this.Column1GioiTinh,
            this.Column1DiaChi,
            this.Column1SDT,
            this.Column1Luong});
            this.dtgvnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvnhanvien.Location = new System.Drawing.Point(3, 16);
            this.dtgvnhanvien.Name = "dtgvnhanvien";
            this.dtgvnhanvien.ReadOnly = true;
            this.dtgvnhanvien.Size = new System.Drawing.Size(846, 165);
            this.dtgvnhanvien.TabIndex = 0;
            // 
            // Column1MaNV
            // 
            this.Column1MaNV.DataPropertyName = "MaNV";
            this.Column1MaNV.HeaderText = "Mã Nhân Viên";
            this.Column1MaNV.Name = "Column1MaNV";
            this.Column1MaNV.ReadOnly = true;
            this.Column1MaNV.Width = 50;
            // 
            // Column1TenNV
            // 
            this.Column1TenNV.DataPropertyName = "TenNV";
            this.Column1TenNV.HeaderText = "Tên Nhân Viên";
            this.Column1TenNV.Name = "Column1TenNV";
            this.Column1TenNV.ReadOnly = true;
            this.Column1TenNV.Width = 200;
            // 
            // Column1NgaySinh
            // 
            this.Column1NgaySinh.DataPropertyName = "NgaySinh";
            this.Column1NgaySinh.HeaderText = "Ngày Sinh";
            this.Column1NgaySinh.Name = "Column1NgaySinh";
            this.Column1NgaySinh.ReadOnly = true;
            // 
            // Column1GioiTinh
            // 
            this.Column1GioiTinh.DataPropertyName = "GioiTinh";
            this.Column1GioiTinh.HeaderText = "Giới Tính";
            this.Column1GioiTinh.Name = "Column1GioiTinh";
            this.Column1GioiTinh.ReadOnly = true;
            this.Column1GioiTinh.Width = 50;
            // 
            // Column1DiaChi
            // 
            this.Column1DiaChi.DataPropertyName = "DiaChi";
            this.Column1DiaChi.HeaderText = "Địa Chỉ";
            this.Column1DiaChi.Name = "Column1DiaChi";
            this.Column1DiaChi.ReadOnly = true;
            this.Column1DiaChi.Width = 200;
            // 
            // Column1SDT
            // 
            this.Column1SDT.DataPropertyName = "SDT";
            this.Column1SDT.HeaderText = "SĐT";
            this.Column1SDT.Name = "Column1SDT";
            this.Column1SDT.ReadOnly = true;
            // 
            // Column1Luong
            // 
            this.Column1Luong.DataPropertyName = "Luong";
            this.Column1Luong.HeaderText = "Lương";
            this.Column1Luong.Name = "Column1Luong";
            this.Column1Luong.ReadOnly = true;
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(239, 228);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(190, 20);
            this.txttim.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "SDT";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(504, 99);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(209, 46);
            this.txtdiachi.TabIndex = 8;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(504, 65);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(130, 20);
            this.txtluong.TabIndex = 9;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(504, 33);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(209, 20);
            this.txtsdt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(124, 133);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(100, 20);
            this.txtgioitinh.TabIndex = 11;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(124, 69);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(203, 20);
            this.txtten.TabIndex = 12;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(124, 33);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngaysinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtgioitinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtluong);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(124, 99);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(100, 20);
            this.dtngaysinh.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lương";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(18, 177);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 40);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Thêm Nhân Viên";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(122, 177);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 40);
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(538, 177);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 40);
            this.btLuu.TabIndex = 17;
            this.btLuu.Text = "Lưu Thao Tác";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(227, 177);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 40);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa Nhân Viên";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(650, 177);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 40);
            this.btHuy.TabIndex = 19;
            this.btHuy.Text = "Hủy Thao Tác";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // bthoat
            // 
            this.bthoat.Location = new System.Drawing.Point(762, 177);
            this.bthoat.Name = "bthoat";
            this.bthoat.Size = new System.Drawing.Size(75, 40);
            this.bthoat.TabIndex = 20;
            this.bthoat.Text = "Thoát";
            this.bthoat.UseVisualStyleBackColor = true;
            this.bthoat.Click += new System.EventHandler(this.bthoat_Click);
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(447, 225);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 23);
            this.bttim.TabIndex = 21;
            this.bttim.Text = "Tìm Kiếm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.bthoat);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvnhanvien;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button bthoat;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Luong;
    }
}
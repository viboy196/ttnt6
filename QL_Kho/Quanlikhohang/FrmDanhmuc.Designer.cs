namespace Quanlikhohang
{
    partial class FrmDanhmuc
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
            this.btnChucnang = new System.Windows.Forms.Button();
            this.cmdTimkiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.btnDanhMucKhoHang = new System.Windows.Forms.Label();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_stt = new System.Windows.Forms.Label();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_loai = new System.Windows.Forms.TextBox();
            this.tb_nguyenlieu = new System.Windows.Forms.TextBox();
            this.tb_donvi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bn_quaylai = new System.Windows.Forms.Button();
            this.btn_NghiepVu = new System.Windows.Forms.Button();
            this.bt_nhacc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChucnang
            // 
            this.btnChucnang.Location = new System.Drawing.Point(53, 119);
            this.btnChucnang.Margin = new System.Windows.Forms.Padding(4);
            this.btnChucnang.Name = "btnChucnang";
            this.btnChucnang.Size = new System.Drawing.Size(185, 50);
            this.btnChucnang.TabIndex = 0;
            this.btnChucnang.Text = "Chức năng";
            this.btnChucnang.UseVisualStyleBackColor = true;
            this.btnChucnang.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmdTimkiem
            // 
            this.cmdTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmdTimkiem.Location = new System.Drawing.Point(53, 241);
            this.cmdTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTimkiem.Name = "cmdTimkiem";
            this.cmdTimkiem.Size = new System.Drawing.Size(185, 46);
            this.cmdTimkiem.TabIndex = 3;
            this.cmdTimkiem.Text = "Tìm kiếm";
            this.cmdTimkiem.UseVisualStyleBackColor = true;
            this.cmdTimkiem.Click += new System.EventHandler(this.cmdTimkiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.Location = new System.Drawing.Point(53, 379);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(957, 350);
            this.dataGridView1.TabIndex = 4;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(264, 241);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.tb_timkiem.Multiline = true;
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(354, 46);
            this.tb_timkiem.TabIndex = 5;
            // 
            // btnDanhMucKhoHang
            // 
            this.btnDanhMucKhoHang.AutoSize = true;
            this.btnDanhMucKhoHang.Font = new System.Drawing.Font("Times New Roman", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMucKhoHang.ForeColor = System.Drawing.Color.Red;
            this.btnDanhMucKhoHang.Location = new System.Drawing.Point(433, 11);
            this.btnDanhMucKhoHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnDanhMucKhoHang.Name = "btnDanhMucKhoHang";
            this.btnDanhMucKhoHang.Size = new System.Drawing.Size(200, 26);
            this.btnDanhMucKhoHang.TabIndex = 6;
            this.btnDanhMucKhoHang.Text = "Quản Lý Kho Hàng";
            this.btnDanhMucKhoHang.Click += new System.EventHandler(this.btnDanhMucKhoHang_Click);
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_thongtin.Location = new System.Drawing.Point(59, 355);
            this.lb_thongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(153, 17);
            this.lb_thongtin.TabIndex = 7;
            this.lb_thongtin.Text = "Danh sách nguyên liệu";
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Location = new System.Drawing.Point(57, 270);
            this.lb_ghichu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(41, 15);
            this.lb_ghichu.TabIndex = 20;
            this.lb_ghichu.Text = "Đơn vị";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(57, 207);
            this.lb_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(56, 15);
            this.lb_sdt.TabIndex = 19;
            this.lb_sdt.Text = "Số lượng";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Location = new System.Drawing.Point(57, 145);
            this.lb_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(49, 15);
            this.lb_diachi.TabIndex = 18;
            this.lb_diachi.Text = "Giá tiền";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Location = new System.Drawing.Point(57, 91);
            this.lb_ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(77, 15);
            this.lb_ten.TabIndex = 17;
            this.lb_ten.Text = "Loại tươi khô";
            // 
            // lb_stt
            // 
            this.lb_stt.AutoSize = true;
            this.lb_stt.Location = new System.Drawing.Point(57, 41);
            this.lb_stt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_stt.Name = "lb_stt";
            this.lb_stt.Size = new System.Drawing.Size(94, 15);
            this.lb_stt.TabIndex = 16;
            this.lb_stt.Text = "Tên nguyên liệu";
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(175, 211);
            this.tb_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(147, 21);
            this.tb_soluong.TabIndex = 15;
            // 
            // tb_gia
            // 
            this.tb_gia.Location = new System.Drawing.Point(175, 149);
            this.tb_gia.Margin = new System.Windows.Forms.Padding(4);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(147, 21);
            this.tb_gia.TabIndex = 14;
            // 
            // tb_loai
            // 
            this.tb_loai.Location = new System.Drawing.Point(175, 88);
            this.tb_loai.Margin = new System.Windows.Forms.Padding(4);
            this.tb_loai.Name = "tb_loai";
            this.tb_loai.Size = new System.Drawing.Size(147, 21);
            this.tb_loai.TabIndex = 13;
            // 
            // tb_nguyenlieu
            // 
            this.tb_nguyenlieu.Location = new System.Drawing.Point(175, 41);
            this.tb_nguyenlieu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nguyenlieu.Name = "tb_nguyenlieu";
            this.tb_nguyenlieu.Size = new System.Drawing.Size(147, 21);
            this.tb_nguyenlieu.TabIndex = 12;
            // 
            // tb_donvi
            // 
            this.tb_donvi.Location = new System.Drawing.Point(175, 270);
            this.tb_donvi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_donvi.Name = "tb_donvi";
            this.tb_donvi.Size = new System.Drawing.Size(147, 21);
            this.tb_donvi.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_stt);
            this.groupBox1.Controls.Add(this.tb_donvi);
            this.groupBox1.Controls.Add(this.tb_nguyenlieu);
            this.groupBox1.Controls.Add(this.lb_ghichu);
            this.groupBox1.Controls.Add(this.tb_loai);
            this.groupBox1.Controls.Add(this.lb_sdt);
            this.groupBox1.Controls.Add(this.tb_gia);
            this.groupBox1.Controls.Add(this.lb_diachi);
            this.groupBox1.Controls.Add(this.tb_soluong);
            this.groupBox1.Controls.Add(this.lb_ten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(683, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 315);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết nguyên liệu";
            // 
            // bn_quaylai
            // 
            this.bn_quaylai.Location = new System.Drawing.Point(507, 302);
            this.bn_quaylai.Margin = new System.Windows.Forms.Padding(4);
            this.bn_quaylai.Name = "bn_quaylai";
            this.bn_quaylai.Size = new System.Drawing.Size(143, 38);
            this.bn_quaylai.TabIndex = 23;
            this.bn_quaylai.Text = "Quay lại";
            this.bn_quaylai.UseVisualStyleBackColor = true;
            this.bn_quaylai.Click += new System.EventHandler(this.bn_quaylai_Click);
            // 
            // btn_NghiepVu
            // 
            this.btn_NghiepVu.Location = new System.Drawing.Point(264, 119);
            this.btn_NghiepVu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NghiepVu.Name = "btn_NghiepVu";
            this.btn_NghiepVu.Size = new System.Drawing.Size(185, 50);
            this.btn_NghiepVu.TabIndex = 24;
            this.btn_NghiepVu.Text = "Nghiệp vụ";
            this.btn_NghiepVu.UseVisualStyleBackColor = true;
            this.btn_NghiepVu.Click += new System.EventHandler(this.btn_NghiepVu_Click);
            // 
            // bt_nhacc
            // 
            this.bt_nhacc.Location = new System.Drawing.Point(53, 177);
            this.bt_nhacc.Margin = new System.Windows.Forms.Padding(4);
            this.bt_nhacc.Name = "bt_nhacc";
            this.bt_nhacc.Size = new System.Drawing.Size(185, 56);
            this.bt_nhacc.TabIndex = 25;
            this.bt_nhacc.Text = "Nhà cung cấp";
            this.bt_nhacc.UseVisualStyleBackColor = true;
            this.bt_nhacc.Click += new System.EventHandler(this.bt_nhacc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 56);
            this.button1.TabIndex = 26;
            this.button1.Text = "Nhân viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 746);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_nhacc);
            this.Controls.Add(this.btn_NghiepVu);
            this.Controls.Add(this.bn_quaylai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_thongtin);
            this.Controls.Add(this.btnDanhMucKhoHang);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdTimkiem);
            this.Controls.Add(this.btnChucnang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDanhmuc";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChucnang;
        private System.Windows.Forms.Button cmdTimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label btnDanhMucKhoHang;
        private System.Windows.Forms.Label lb_thongtin;
        private System.Windows.Forms.Label lb_ghichu;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_stt;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.TextBox tb_loai;
        private System.Windows.Forms.TextBox tb_nguyenlieu;
        private System.Windows.Forms.TextBox tb_donvi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bn_quaylai;
        private System.Windows.Forms.Button btn_NghiepVu;
        private System.Windows.Forms.Button bt_nhacc;
        private System.Windows.Forms.Button button1;
    }
}


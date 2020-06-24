namespace Quanlikhohang
{
    partial class ThemNL
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
            this.tb_loai = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.cb_donvi = new System.Windows.Forms.ComboBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.cb_suadonvi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_soluongsua = new System.Windows.Forms.TextBox();
            this.tb_loaisua = new System.Windows.Forms.TextBox();
            this.tb_giasua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nguyenlieu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.cb_maxoa = new System.Windows.Forms.ComboBox();
            this.bn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_loai
            // 
            this.tb_loai.Location = new System.Drawing.Point(143, 89);
            this.tb_loai.Name = "tb_loai";
            this.tb_loai.Size = new System.Drawing.Size(211, 22);
            this.tb_loai.TabIndex = 1;
            // 
            // tb_gia
            // 
            this.tb_gia.Location = new System.Drawing.Point(143, 138);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(211, 22);
            this.tb_gia.TabIndex = 2;
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(143, 188);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(211, 22);
            this.tb_soluong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên nguyên liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại tươi khô";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn vị";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(325, 285);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 10;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // cb_donvi
            // 
            this.cb_donvi.FormattingEnabled = true;
            this.cb_donvi.Items.AddRange(new object[] {
            "Cân",
            "Lạng",
            "m3",
            "hộp",
            "thùng",
            "khối",
            "lít"});
            this.cb_donvi.Location = new System.Drawing.Point(143, 236);
            this.cb_donvi.Name = "cb_donvi";
            this.cb_donvi.Size = new System.Drawing.Size(211, 24);
            this.cb_donvi.TabIndex = 11;
            this.cb_donvi.SelectedIndexChanged += new System.EventHandler(this.cb_donvi_SelectedIndexChanged);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(335, 285);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(74, 23);
            this.bt_sua.TabIndex = 12;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.cb_suadonvi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_soluongsua);
            this.groupBox1.Controls.Add(this.tb_loaisua);
            this.groupBox1.Controls.Add(this.tb_giasua);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 336);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nguyên liệu cần sửa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_luachon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 51);
            this.panel1.TabIndex = 14;
            // 
            // cb_luachon
            // 
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Location = new System.Drawing.Point(135, 8);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.Size = new System.Drawing.Size(211, 24);
            this.cb_luachon.TabIndex = 13;
            this.cb_luachon.Text = "(chọn nguyên liệu cần sửa)";
            this.cb_luachon.SelectedIndexChanged += new System.EventHandler(this.cb_luachon_SelectedIndexChanged);
            // 
            // cb_suadonvi
            // 
            this.cb_suadonvi.FormattingEnabled = true;
            this.cb_suadonvi.Items.AddRange(new object[] {
            "Cân",
            "Lạng",
            "m3",
            "hộp",
            "thùng",
            "khối",
            "lít"});
            this.cb_suadonvi.Location = new System.Drawing.Point(143, 239);
            this.cb_suadonvi.Name = "cb_suadonvi";
            this.cb_suadonvi.Size = new System.Drawing.Size(209, 24);
            this.cb_suadonvi.TabIndex = 11;
            this.cb_suadonvi.Text = "(lựa chọn đơn vị)";
            this.cb_suadonvi.SelectedIndexChanged += new System.EventHandler(this.cb_suadonvi_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Loại tươi khô";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn vị";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Giá tiền";
            // 
            // tb_soluongsua
            // 
            this.tb_soluongsua.Location = new System.Drawing.Point(143, 188);
            this.tb_soluongsua.Name = "tb_soluongsua";
            this.tb_soluongsua.Size = new System.Drawing.Size(209, 22);
            this.tb_soluongsua.TabIndex = 3;
            // 
            // tb_loaisua
            // 
            this.tb_loaisua.Location = new System.Drawing.Point(143, 89);
            this.tb_loaisua.Name = "tb_loaisua";
            this.tb_loaisua.Size = new System.Drawing.Size(209, 22);
            this.tb_loaisua.TabIndex = 1;
            // 
            // tb_giasua
            // 
            this.tb_giasua.Location = new System.Drawing.Point(143, 138);
            this.tb_giasua.Name = "tb_giasua";
            this.tb_giasua.Size = new System.Drawing.Size(209, 22);
            this.tb_giasua.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số lượng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_nguyenlieu);
            this.groupBox2.Controls.Add(this.cb_donvi);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.tb_loai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_gia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_soluong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 326);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin nguyên liệu cần thêm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên nguyên liệu";
            // 
            // tb_nguyenlieu
            // 
            this.tb_nguyenlieu.Location = new System.Drawing.Point(143, 42);
            this.tb_nguyenlieu.Name = "tb_nguyenlieu";
            this.tb_nguyenlieu.Size = new System.Drawing.Size(211, 22);
            this.tb_nguyenlieu.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.bt_Xoa);
            this.groupBox3.Controls.Add(this.cb_maxoa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 686);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 159);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin mã nguyên liệu cần xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tên nguyên liệu";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(325, 109);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(75, 24);
            this.bt_Xoa.TabIndex = 19;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // cb_maxoa
            // 
            this.cb_maxoa.FormattingEnabled = true;
            this.cb_maxoa.Location = new System.Drawing.Point(175, 55);
            this.cb_maxoa.Name = "cb_maxoa";
            this.cb_maxoa.Size = new System.Drawing.Size(195, 24);
            this.cb_maxoa.TabIndex = 17;
            this.cb_maxoa.Text = "(lựa chọn tên cần xóa)";
            this.cb_maxoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bn_Thoat
            // 
            this.bn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Thoat.Location = new System.Drawing.Point(335, 850);
            this.bn_Thoat.Name = "bn_Thoat";
            this.bn_Thoat.Size = new System.Drawing.Size(120, 35);
            this.bn_Thoat.TabIndex = 20;
            this.bn_Thoat.Text = "Thoát";
            this.bn_Thoat.UseVisualStyleBackColor = true;
            this.bn_Thoat.Click += new System.EventHandler(this.bn_Thoat_Click);
            // 
            // ThemNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(494, 906);
            this.Controls.Add(this.bn_Thoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ThemNL";
            this.Text = "ThemNL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_loai;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ComboBox cb_donvi;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nguyenlieu;
        private System.Windows.Forms.ComboBox cb_suadonvi;
        private System.Windows.Forms.TextBox tb_loaisua;
        private System.Windows.Forms.TextBox tb_giasua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_soluongsua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.ComboBox cb_maxoa;
        private System.Windows.Forms.Button bn_Thoat;
        private System.Windows.Forms.Label label11;
    }
}
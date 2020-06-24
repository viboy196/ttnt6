namespace Quanlikhohang
{
    partial class Themncc
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.cb_maxoa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nhacc = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_diachisua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sdtsua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bn_Thoat = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.bt_Xoa);
            this.groupBox3.Controls.Add(this.cb_maxoa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(34, 526);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 141);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tên nhà cung cấp cần xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tên nhà cung cấp";
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
            this.cb_maxoa.Location = new System.Drawing.Point(159, 55);
            this.cb_maxoa.Name = "cb_maxoa";
            this.cb_maxoa.Size = new System.Drawing.Size(229, 24);
            this.cb_maxoa.TabIndex = 17;
            this.cb_maxoa.Text = "(lựa chọn tên cần xóa)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_nhacc);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.tb_diachi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_sdt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 231);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin nhà cung cấp cần thêm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên nhà cung cấp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_nhacc
            // 
            this.tb_nhacc.Location = new System.Drawing.Point(159, 42);
            this.tb_nhacc.Name = "tb_nhacc";
            this.tb_nhacc.Size = new System.Drawing.Size(211, 22);
            this.tb_nhacc.TabIndex = 0;
            this.tb_nhacc.TextChanged += new System.EventHandler(this.tb_nhacc_TextChanged);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(317, 184);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 10;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(159, 93);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(211, 22);
            this.tb_diachi.TabIndex = 1;
            this.tb_diachi.TextChanged += new System.EventHandler(this.tb_diachi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa chỉ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(159, 140);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(211, 22);
            this.tb_sdt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_diachisua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_sdtsua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 229);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp cần sửa";
            // 
            // tb_diachisua
            // 
            this.tb_diachisua.Location = new System.Drawing.Point(159, 93);
            this.tb_diachisua.Name = "tb_diachisua";
            this.tb_diachisua.Size = new System.Drawing.Size(229, 22);
            this.tb_diachisua.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Địa chỉ";
            // 
            // tb_sdtsua
            // 
            this.tb_sdtsua.Location = new System.Drawing.Point(159, 145);
            this.tb_sdtsua.Name = "tb_sdtsua";
            this.tb_sdtsua.Size = new System.Drawing.Size(229, 22);
            this.tb_sdtsua.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số điện thoại";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_luachon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 51);
            this.panel1.TabIndex = 14;
            // 
            // cb_luachon
            // 
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Location = new System.Drawing.Point(153, 8);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.Size = new System.Drawing.Size(229, 24);
            this.cb_luachon.TabIndex = 13;
            this.cb_luachon.Text = "(chọn nhà cung cấp cần sửa)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(325, 194);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(74, 23);
            this.bt_sua.TabIndex = 12;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bn_Thoat
            // 
            this.bn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Thoat.Location = new System.Drawing.Point(363, 682);
            this.bn_Thoat.Name = "bn_Thoat";
            this.bn_Thoat.Size = new System.Drawing.Size(120, 35);
            this.bn_Thoat.TabIndex = 21;
            this.bn_Thoat.Text = "Thoát";
            this.bn_Thoat.UseVisualStyleBackColor = true;
            this.bn_Thoat.Click += new System.EventHandler(this.bn_Thoat_Click);
            // 
            // Themncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 729);
            this.Controls.Add(this.bn_Thoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Themncc";
            this.Text = "Themncc";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.ComboBox cb_maxoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nhacc;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_diachisua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sdtsua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bn_Thoat;
    }
}
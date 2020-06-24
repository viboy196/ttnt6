namespace QLDIEM
{
    partial class BCKyI
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
            this.cmbDSHS = new System.Windows.Forms.ComboBox();
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
            this.btnBC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMHS = new System.Windows.Forms.Label();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblHL = new System.Windows.Forms.Label();
            this.btnLuuBC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDSHS
            // 
            this.cmbDSHS.FormattingEnabled = true;
            this.cmbDSHS.Location = new System.Drawing.Point(183, 32);
            this.cmbDSHS.Name = "cmbDSHS";
            this.cmbDSHS.Size = new System.Drawing.Size(293, 21);
            this.cmbDSHS.TabIndex = 1;
            this.cmbDSHS.SelectedValueChanged += new System.EventHandler(this.cmbDSHS_SelectedValueChanged);
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(492, 31);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(155, 21);
            this.cmbLop.TabIndex = 0;
            this.cmbLop.SelectedValueChanged += new System.EventHandler(this.cmbLop_SelectedValueChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(89, 40);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(52, 13);
            this.lblTimKiem.TabIndex = 20;
            this.lblTimKiem.Text = "Tìm kiếm:";
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
            this.gridDiem.Location = new System.Drawing.Point(21, 78);
            this.gridDiem.Name = "gridDiem";
            this.gridDiem.ReadOnly = true;
            this.gridDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiem.Size = new System.Drawing.Size(758, 168);
            this.gridDiem.TabIndex = 23;
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
            // btnBC
            // 
            this.btnBC.Location = new System.Drawing.Point(195, 262);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(173, 23);
            this.btnBC.TabIndex = 2;
            this.btnBC.Text = "Điểm TB học kỳ I";
            this.btnBC.UseVisualStyleBackColor = true;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã học sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên học sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Điểm TBHK I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Học lực ky I:";
            // 
            // lblMHS
            // 
            this.lblMHS.AutoSize = true;
            this.lblMHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMHS.Location = new System.Drawing.Point(164, 306);
            this.lblMHS.Name = "lblMHS";
            this.lblMHS.Size = new System.Drawing.Size(12, 18);
            this.lblMHS.TabIndex = 26;
            this.lblMHS.Text = ".";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHS.Location = new System.Drawing.Point(164, 332);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(12, 18);
            this.lblTenHS.TabIndex = 26;
            this.lblTenHS.Text = ".";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTB.Location = new System.Drawing.Point(164, 363);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(12, 18);
            this.lblDTB.TabIndex = 26;
            this.lblDTB.Text = ".";
            this.lblDTB.Click += new System.EventHandler(this.lblDTB_Click);
            // 
            // lblHL
            // 
            this.lblHL.AutoSize = true;
            this.lblHL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHL.Location = new System.Drawing.Point(164, 393);
            this.lblHL.Name = "lblHL";
            this.lblHL.Size = new System.Drawing.Size(12, 18);
            this.lblHL.TabIndex = 26;
            this.lblHL.Text = ".";
            // 
            // btnLuuBC
            // 
            this.btnLuuBC.Location = new System.Drawing.Point(423, 262);
            this.btnLuuBC.Name = "btnLuuBC";
            this.btnLuuBC.Size = new System.Drawing.Size(161, 23);
            this.btnLuuBC.TabIndex = 3;
            this.btnLuuBC.Text = "Lưu báo cáo";
            this.btnLuuBC.UseVisualStyleBackColor = true;
            this.btnLuuBC.Click += new System.EventHandler(this.btnLuuBC_Click);
            // 
            // BCKyI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(806, 452);
            this.Controls.Add(this.btnLuuBC);
            this.Controls.Add(this.lblHL);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.lblTenHS);
            this.Controls.Add(this.lblMHS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.gridDiem);
            this.Controls.Add(this.cmbDSHS);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.lblTimKiem);
            this.MaximizeBox = false;
            this.Name = "BCKyI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo điểm kỳ I";
            this.Load += new System.EventHandler(this.BCKyI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDSHS;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView gridDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn D15;
        private System.Windows.Forms.DataGridViewTextBoxColumn D451;
        private System.Windows.Forms.DataGridViewTextBoxColumn D452;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMHS;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblHL;
        private System.Windows.Forms.Button btnLuuBC;
    }
}
namespace A.GiaoDien
{
    partial class NhapDiem
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbKetQuaHocTap = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.btChinhSua_QLD = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btXacNhan_QLD = new System.Windows.Forms.Button();
            this.txtDiemQuaTrinh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brCuoi = new System.Windows.Forms.Button();
            this.btSau = new System.Windows.Forms.Button();
            this.btTruoc = new System.Windows.Forms.Button();
            this.btDau = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketluan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKetQuaHocTap)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbKetQuaHocTap);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(15, 297);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1128, 380);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kết Quả Học Tập Trong Kỳ.";
            // 
            // tbKetQuaHocTap
            // 
            this.tbKetQuaHocTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbKetQuaHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbKetQuaHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.ketluan});
            this.tbKetQuaHocTap.Location = new System.Drawing.Point(7, 20);
            this.tbKetQuaHocTap.Name = "tbKetQuaHocTap";
            this.tbKetQuaHocTap.Size = new System.Drawing.Size(1115, 354);
            this.tbKetQuaHocTap.TabIndex = 0;
            this.tbKetQuaHocTap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbKetQuaHocTap_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btXoa);
            this.groupBox4.Controls.Add(this.txtDiemThi);
            this.groupBox4.Controls.Add(this.btChinhSua_QLD);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btXacNhan_QLD);
            this.groupBox4.Controls.Add(this.txtDiemQuaTrinh);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1128, 94);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Điểm Quá Trình Và Điểm Thi.";
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btXoa.Image = global::A.GiaoDien.Properties.Resources.xoa;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(690, 54);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(85, 36);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(692, 21);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(98, 26);
            this.txtDiemThi.TabIndex = 2;
            this.txtDiemThi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterDiemThi);
            // 
            // btChinhSua_QLD
            // 
            this.btChinhSua_QLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChinhSua_QLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btChinhSua_QLD.Image = global::A.GiaoDien.Properties.Resources.sua;
            this.btChinhSua_QLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChinhSua_QLD.Location = new System.Drawing.Point(542, 54);
            this.btChinhSua_QLD.Name = "btChinhSua_QLD";
            this.btChinhSua_QLD.Size = new System.Drawing.Size(135, 34);
            this.btChinhSua_QLD.TabIndex = 4;
            this.btChinhSua_QLD.Text = "chỉnh sửa";
            this.btChinhSua_QLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btChinhSua_QLD.UseVisualStyleBackColor = true;
            this.btChinhSua_QLD.Click += new System.EventHandler(this.btChinhSua_QLD_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(586, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Điểm Thi:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btXacNhan_QLD
            // 
            this.btXacNhan_QLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan_QLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btXacNhan_QLD.Image = global::A.GiaoDien.Properties.Resources.check;
            this.btXacNhan_QLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXacNhan_QLD.Location = new System.Drawing.Point(403, 53);
            this.btXacNhan_QLD.Name = "btXacNhan_QLD";
            this.btXacNhan_QLD.Size = new System.Drawing.Size(117, 35);
            this.btXacNhan_QLD.TabIndex = 3;
            this.btXacNhan_QLD.Text = "xác nhận";
            this.btXacNhan_QLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXacNhan_QLD.UseVisualStyleBackColor = true;
            this.btXacNhan_QLD.Click += new System.EventHandler(this.btXacNhan_QLD_Click);
            // 
            // txtDiemQuaTrinh
            // 
            this.txtDiemQuaTrinh.Location = new System.Drawing.Point(477, 24);
            this.txtDiemQuaTrinh.Name = "txtDiemQuaTrinh";
            this.txtDiemQuaTrinh.Size = new System.Drawing.Size(83, 26);
            this.txtDiemQuaTrinh.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(327, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Điểm Quá Trình:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbHocKy);
            this.groupBox3.Controls.Add(this.cbMonHoc);
            this.groupBox3.Controls.Add(this.txtTenSinhVien);
            this.groupBox3.Controls.Add(this.txtMaSinhVien);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1128, 98);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điền Và Chọn Những Thông Tin Cần Thiết.";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(358, 55);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(198, 28);
            this.cbHocKy.TabIndex = 3;
            this.cbHocKy.SelectedValueChanged += new System.EventHandler(this.ChonKyHocDeXemDiemCuaSinhVien);
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(698, 55);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(257, 28);
            this.cbMonHoc.TabIndex = 4;
            this.cbMonHoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TimKiemMonHoc);
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSinhVien.ForeColor = System.Drawing.Color.Green;
            this.txtTenSinhVien.Location = new System.Drawing.Point(698, 19);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(257, 26);
            this.txtTenSinhVien.TabIndex = 2;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(406, 19);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(150, 26);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(284, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Học Kỳ:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(569, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Môn Học:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(263, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Sinh Viên:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(569, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Sinh Viên:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-2, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1158, 51);
            this.label4.TabIndex = 54;
            this.label4.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brCuoi
            // 
            this.brCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brCuoi.Image = global::A.GiaoDien.Properties.Resources.vecuoi;
            this.brCuoi.Location = new System.Drawing.Point(650, 259);
            this.brCuoi.Name = "brCuoi";
            this.brCuoi.Size = new System.Drawing.Size(42, 39);
            this.brCuoi.TabIndex = 4;
            this.brCuoi.Text = ".";
            this.brCuoi.UseVisualStyleBackColor = true;
            this.brCuoi.Click += new System.EventHandler(this.brCuoi_Click);
            // 
            // btSau
            // 
            this.btSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSau.Image = global::A.GiaoDien.Properties.Resources.vesau;
            this.btSau.Location = new System.Drawing.Point(605, 259);
            this.btSau.Name = "btSau";
            this.btSau.Size = new System.Drawing.Size(39, 39);
            this.btSau.TabIndex = 3;
            this.btSau.Text = ".";
            this.btSau.UseVisualStyleBackColor = true;
            this.btSau.Click += new System.EventHandler(this.btSau_Click);
            // 
            // btTruoc
            // 
            this.btTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTruoc.Image = global::A.GiaoDien.Properties.Resources.vetruoc;
            this.btTruoc.Location = new System.Drawing.Point(557, 259);
            this.btTruoc.Name = "btTruoc";
            this.btTruoc.Size = new System.Drawing.Size(42, 39);
            this.btTruoc.TabIndex = 2;
            this.btTruoc.Text = ".";
            this.btTruoc.UseVisualStyleBackColor = true;
            this.btTruoc.Click += new System.EventHandler(this.btTruoc_Click);
            // 
            // btDau
            // 
            this.btDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDau.Image = global::A.GiaoDien.Properties.Resources.vedau;
            this.btDau.Location = new System.Drawing.Point(510, 259);
            this.btDau.Name = "btDau";
            this.btDau.Size = new System.Drawing.Size(41, 39);
            this.btDau.TabIndex = 1;
            this.btDau.Text = ".";
            this.btDau.UseVisualStyleBackColor = true;
            this.btDau.Click += new System.EventHandler(this.btDau_Click);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "STT";
            this.Column8.HeaderText = "STT";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaHocKy";
            this.Column9.HeaderText = "Mã Học Kỳ";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MaMonHoc";
            this.Column10.HeaderText = "Mã Môn Học";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TenMonHoc";
            this.Column11.HeaderText = "Tên Môn Học";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SoTinChi";
            this.Column12.HeaderText = "Số Tín Chỉ";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "DiemQuaTrinh";
            this.Column13.HeaderText = "Điểm Quá Trình";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "DiemThi";
            this.Column14.HeaderText = "Điểm Thi";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Diem Tong Ket";
            this.Column15.HeaderText = "Điểm Tổng Kết";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Diem Chu";
            this.Column16.HeaderText = "Điểm Chữ";
            this.Column16.Name = "Column16";
            // 
            // ketluan
            // 
            this.ketluan.DataPropertyName = "KetLuan";
            this.ketluan.HeaderText = "Kết Luận";
            this.ketluan.Name = "ketluan";
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brCuoi);
            this.Controls.Add(this.btSau);
            this.Controls.Add(this.btTruoc);
            this.Controls.Add(this.btDau);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "NhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbKetQuaHocTap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brCuoi;
        private System.Windows.Forms.Button btSau;
        private System.Windows.Forms.Button btTruoc;
        private System.Windows.Forms.Button btDau;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView tbKetQuaHocTap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Button btChinhSua_QLD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btXacNhan_QLD;
        private System.Windows.Forms.TextBox txtDiemQuaTrinh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketluan;
    }
}
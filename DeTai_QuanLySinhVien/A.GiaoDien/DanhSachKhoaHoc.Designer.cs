﻿namespace A.GiaoDien
{
    partial class DanhSachKhoaHoc
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lbTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbKhoaHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btThem,
            this.toolStripLabel2,
            this.btSua,
            this.toolStripLabel4,
            this.btXoa,
            this.toolStripLabel5,
            this.lbTimKiem,
            this.txtTimKiem});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(857, 32);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 29);
            this.toolStripLabel3.Text = "(F9)>";
            // 
            // btThem
            // 
            this.btThem.Image = global::A.GiaoDien.Properties.Resources.them;
            this.btThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(158, 29);
            this.btThem.Text = "Thêm Khóa Học";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 29);
            this.toolStripLabel2.Text = "(F10)>";
            // 
            // btSua
            // 
            this.btSua.Image = global::A.GiaoDien.Properties.Resources.sua;
            this.btSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(146, 29);
            this.btSua.Text = "Sửa Thông Tin";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLabel4.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(41, 29);
            this.toolStripLabel4.Text = "(F11)>";
            // 
            // btXoa
            // 
            this.btXoa.Image = global::A.GiaoDien.Properties.Resources.xoa;
            this.btXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(145, 29);
            this.btXoa.Text = "Xóa Khóa Học";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLabel5.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(41, 29);
            this.toolStripLabel5.Text = "(F12)>";
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.Image = global::A.GiaoDien.Properties.Resources.timkiem;
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(101, 29);
            this.lbTimKiem.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(150, 23);
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhiAnOTimKiem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbKhoaHoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 559);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách - Thông Tin Khóa Học";
            // 
            // tbKhoaHoc
            // 
            this.tbKhoaHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tbKhoaHoc.Location = new System.Drawing.Point(6, 19);
            this.tbKhoaHoc.Name = "tbKhoaHoc";
            this.tbKhoaHoc.Size = new System.Drawing.Size(845, 533);
            this.tbKhoaHoc.TabIndex = 0;
            this.tbKhoaHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbKhoaHoc_CellClick);
            this.tbKhoaHoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.KhiKichDupChuot);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKhoaHoc";
            this.Column1.HeaderText = "Mã Khóa Học";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayBatDau";
            this.Column2.HeaderText = "Ngày Bắt Đầu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayKetThuc";
            this.Column3.HeaderText = "Ngày Kết Thúc";
            this.Column3.Name = "Column3";
            // 
            // DanhSachKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachKhoaHoc";
            this.Text = "DanhSachKhoaHoc";
            this.Load += new System.EventHandler(this.DanhSachKhoaHoc_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbKhoaHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btThem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btSua;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lbTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tbKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
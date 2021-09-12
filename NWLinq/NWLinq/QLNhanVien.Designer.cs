namespace NWLinq
{
    partial class QLNhanVien
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
            this.TenLabel = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.NgaySinhLabel = new System.Windows.Forms.Label();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.SoDienThoaiLabel = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.MaDHLabel = new System.Windows.Forms.Label();
            this.MaNVLabel = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.NhaCungCapLabel = new System.Windows.Forms.Label();
            this.LoaiSPLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLDH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gVNV = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TenLabel);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.txtChucVu);
            this.groupBox2.Controls.Add(this.NgaySinhLabel);
            this.groupBox2.Controls.Add(this.txtThanhPho);
            this.groupBox2.Controls.Add(this.SoDienThoaiLabel);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.MaDHLabel);
            this.groupBox2.Controls.Add(this.MaNVLabel);
            this.groupBox2.Controls.Add(this.txtHo);
            this.groupBox2.Controls.Add(this.NhaCungCapLabel);
            this.groupBox2.Controls.Add(this.LoaiSPLabel);
            this.groupBox2.Location = new System.Drawing.Point(29, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(958, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // TenLabel
            // 
            this.TenLabel.AutoSize = true;
            this.TenLabel.Location = new System.Drawing.Point(690, 23);
            this.TenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TenLabel.Name = "TenLabel";
            this.TenLabel.Size = new System.Drawing.Size(37, 17);
            this.TenLabel.TabIndex = 15;
            this.TenLabel.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(770, 19);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(153, 22);
            this.txtTen.TabIndex = 15;
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(153, 70);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(254, 22);
            this.dtpNgaySinh.TabIndex = 19;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(153, 115);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(254, 22);
            this.txtChucVu.TabIndex = 15;
            this.txtChucVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChucVu_KeyPress);
            // 
            // NgaySinhLabel
            // 
            this.NgaySinhLabel.AutoSize = true;
            this.NgaySinhLabel.Location = new System.Drawing.Point(25, 70);
            this.NgaySinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NgaySinhLabel.Name = "NgaySinhLabel";
            this.NgaySinhLabel.Size = new System.Drawing.Size(77, 17);
            this.NgaySinhLabel.TabIndex = 18;
            this.NgaySinhLabel.Text = "Ngày Sinh:";
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Location = new System.Drawing.Point(607, 67);
            this.txtThanhPho.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(275, 22);
            this.txtThanhPho.TabIndex = 17;
            this.txtThanhPho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThanhPho_KeyPress);
            // 
            // SoDienThoaiLabel
            // 
            this.SoDienThoaiLabel.AutoSize = true;
            this.SoDienThoaiLabel.Location = new System.Drawing.Point(471, 115);
            this.SoDienThoaiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoDienThoaiLabel.Name = "SoDienThoaiLabel";
            this.SoDienThoaiLabel.Size = new System.Drawing.Size(102, 17);
            this.SoDienThoaiLabel.TabIndex = 8;
            this.SoDienThoaiLabel.Text = "Số Điện Thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(607, 110);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(275, 22);
            this.txtSoDienThoai.TabIndex = 14;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(153, 20);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(254, 22);
            this.txtMaNV.TabIndex = 15;
            // 
            // MaDHLabel
            // 
            this.MaDHLabel.AutoSize = true;
            this.MaDHLabel.Location = new System.Drawing.Point(25, 115);
            this.MaDHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaDHLabel.Name = "MaDHLabel";
            this.MaDHLabel.Size = new System.Drawing.Size(63, 17);
            this.MaDHLabel.TabIndex = 13;
            this.MaDHLabel.Text = "Chức vụ:";
            // 
            // MaNVLabel
            // 
            this.MaNVLabel.AutoSize = true;
            this.MaNVLabel.Location = new System.Drawing.Point(25, 25);
            this.MaNVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaNVLabel.Name = "MaNVLabel";
            this.MaNVLabel.Size = new System.Drawing.Size(97, 17);
            this.MaNVLabel.TabIndex = 2;
            this.MaNVLabel.Text = "Mã nhân viên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(530, 19);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(144, 22);
            this.txtHo.TabIndex = 3;
            this.txtHo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHo_KeyPress);
            // 
            // NhaCungCapLabel
            // 
            this.NhaCungCapLabel.AutoSize = true;
            this.NhaCungCapLabel.Location = new System.Drawing.Point(471, 67);
            this.NhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NhaCungCapLabel.Name = "NhaCungCapLabel";
            this.NhaCungCapLabel.Size = new System.Drawing.Size(82, 17);
            this.NhaCungCapLabel.TabIndex = 6;
            this.NhaCungCapLabel.Text = "Thành Phố:";
            // 
            // LoaiSPLabel
            // 
            this.LoaiSPLabel.AutoSize = true;
            this.LoaiSPLabel.Location = new System.Drawing.Point(471, 20);
            this.LoaiSPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoaiSPLabel.Name = "LoaiSPLabel";
            this.LoaiSPLabel.Size = new System.Drawing.Size(30, 17);
            this.LoaiSPLabel.TabIndex = 4;
            this.LoaiSPLabel.Text = "Họ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Location = new System.Drawing.Point(421, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(566, 102);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(450, 23);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 71);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(322, 23);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 71);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(187, 23);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 71);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(48, 23);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 71);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(397, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLSP,
            this.menuQLDH,
            this.menuQLNV});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 36);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQLSP
            // 
            this.menuQLSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuQLSP.ForeColor = System.Drawing.Color.Blue;
            this.menuQLSP.Name = "menuQLSP";
            this.menuQLSP.Size = new System.Drawing.Size(194, 32);
            this.menuQLSP.Text = "Quản lý sản phẩm";
            this.menuQLSP.Click += new System.EventHandler(this.menuQLSP_Click);
            // 
            // menuQLDH
            // 
            this.menuQLDH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuQLDH.ForeColor = System.Drawing.Color.Blue;
            this.menuQLDH.Name = "menuQLDH";
            this.menuQLDH.Size = new System.Drawing.Size(194, 32);
            this.menuQLDH.Text = "Quản lý đơn hàng";
            this.menuQLDH.Click += new System.EventHandler(this.menuQLDH_Click);
            // 
            // menuQLNV
            // 
            this.menuQLNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuQLNV.ForeColor = System.Drawing.Color.Blue;
            this.menuQLNV.Name = "menuQLNV";
            this.menuQLNV.Size = new System.Drawing.Size(196, 32);
            this.menuQLNV.Text = "Quản lý nhân viên";
            this.menuQLNV.Click += new System.EventHandler(this.menuQLNV_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gVNV);
            this.groupBox3.Location = new System.Drawing.Point(46, 404);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(892, 370);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết đơn hàng";
            // 
            // gVNV
            // 
            this.gVNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVNV.Location = new System.Drawing.Point(12, 22);
            this.gVNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gVNV.Name = "gVNV";
            this.gVNV.RowHeadersWidth = 62;
            this.gVNV.RowTemplate.Height = 28;
            this.gVNV.Size = new System.Drawing.Size(867, 331);
            this.gVNV.TabIndex = 0;
            this.gVNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVNV_CellClick);
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 794);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NgaySinhLabel;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label MaDHLabel;
        private System.Windows.Forms.Label MaNVLabel;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label LoaiSPLabel;
        private System.Windows.Forms.Label NhaCungCapLabel;
        private System.Windows.Forms.Label SoDienThoaiLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQLSP;
        private System.Windows.Forms.ToolStripMenuItem menuQLDH;
        private System.Windows.Forms.ToolStripMenuItem menuQLNV;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label TenLabel;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gVNV;
    }
}
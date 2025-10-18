namespace test
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupTim;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupThongTinXN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoLanXN;
        private System.Windows.Forms.RadioButton rdoAmTinh;
        private System.Windows.Forms.RadioButton rdoDuongTinh;
        private System.Windows.Forms.ComboBox cboCongTy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSoLanXN;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblCongTy;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuNVDuongTinh;
        private System.Windows.Forms.ToolStripMenuItem mnuCtyDaTest;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatBaoCao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupTim = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupThongTinXN = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSoLanXN = new System.Windows.Forms.Label();
            this.txtSoLanXN = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.rdoAmTinh = new System.Windows.Forms.RadioButton();
            this.rdoDuongTinh = new System.Windows.Forms.RadioButton();
            this.lblCongTy = new System.Windows.Forms.Label();
            this.cboCongTy = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNVDuongTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCtyDaTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXuatBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupTim.SuspendLayout();
            this.groupThongTinXN.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(200, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin xét nghiệm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(300, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupTim
            // 
            this.groupTim.Controls.Add(this.label1);
            this.groupTim.Controls.Add(this.txtCCCD);
            this.groupTim.Controls.Add(this.btnTim);
            this.groupTim.Location = new System.Drawing.Point(20, 90);
            this.groupTim.Name = "groupTim";
            this.groupTim.Size = new System.Drawing.Size(260, 80);
            this.groupTim.TabIndex = 2;
            this.groupTim.TabStop = false;
            this.groupTim.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CCCD/CMND";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(9, 44);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(171, 20);
            this.txtCCCD.TabIndex = 0;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(186, 44);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(60, 25);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupThongTinXN
            // 
            this.groupThongTinXN.Controls.Add(this.lblHoTen);
            this.groupThongTinXN.Controls.Add(this.txtHoTen);
            this.groupThongTinXN.Controls.Add(this.lblSoLanXN);
            this.groupThongTinXN.Controls.Add(this.txtSoLanXN);
            this.groupThongTinXN.Controls.Add(this.lblKetQua);
            this.groupThongTinXN.Controls.Add(this.rdoAmTinh);
            this.groupThongTinXN.Controls.Add(this.rdoDuongTinh);
            this.groupThongTinXN.Controls.Add(this.lblCongTy);
            this.groupThongTinXN.Controls.Add(this.cboCongTy);
            this.groupThongTinXN.Controls.Add(this.btnCapNhat);
            this.groupThongTinXN.Location = new System.Drawing.Point(20, 180);
            this.groupThongTinXN.Name = "groupThongTinXN";
            this.groupThongTinXN.Size = new System.Drawing.Size(260, 210);
            this.groupThongTinXN.TabIndex = 3;
            this.groupThongTinXN.TabStop = false;
            this.groupThongTinXN.Text = "Thông tin xét nghiệm";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(20, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 23);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(80, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(160, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblSoLanXN
            // 
            this.lblSoLanXN.Location = new System.Drawing.Point(20, 60);
            this.lblSoLanXN.Name = "lblSoLanXN";
            this.lblSoLanXN.Size = new System.Drawing.Size(54, 23);
            this.lblSoLanXN.TabIndex = 2;
            this.lblSoLanXN.Text = "SLXN:";
            // 
            // txtSoLanXN
            // 
            this.txtSoLanXN.Location = new System.Drawing.Point(80, 57);
            this.txtSoLanXN.Name = "txtSoLanXN";
            this.txtSoLanXN.Size = new System.Drawing.Size(40, 20);
            this.txtSoLanXN.TabIndex = 3;
            // 
            // lblKetQua
            // 
            this.lblKetQua.Location = new System.Drawing.Point(20, 90);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(34, 23);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "KQ:";
            // 
            // rdoAmTinh
            // 
            this.rdoAmTinh.Location = new System.Drawing.Point(80, 90);
            this.rdoAmTinh.Name = "rdoAmTinh";
            this.rdoAmTinh.Size = new System.Drawing.Size(74, 24);
            this.rdoAmTinh.TabIndex = 5;
            this.rdoAmTinh.Text = "Âm Tính";
            // 
            // rdoDuongTinh
            // 
            this.rdoDuongTinh.Location = new System.Drawing.Point(160, 90);
            this.rdoDuongTinh.Name = "rdoDuongTinh";
            this.rdoDuongTinh.Size = new System.Drawing.Size(104, 24);
            this.rdoDuongTinh.TabIndex = 6;
            this.rdoDuongTinh.Text = "Dương Tính";
            // 
            // lblCongTy
            // 
            this.lblCongTy.Location = new System.Drawing.Point(20, 120);
            this.lblCongTy.Name = "lblCongTy";
            this.lblCongTy.Size = new System.Drawing.Size(54, 23);
            this.lblCongTy.TabIndex = 7;
            this.lblCongTy.Text = "Công ty:";
            // 
            // cboCongTy
            // 
            this.cboCongTy.Location = new System.Drawing.Point(80, 117);
            this.cboCongTy.Name = "cboCongTy";
            this.cboCongTy.Size = new System.Drawing.Size(160, 21);
            this.cboCongTy.TabIndex = 8;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(80, 160);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 30);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNVDuongTinh,
            this.mnuCtyDaTest,
            this.mnuXuatBaoCao});
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(77, 20);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuNVDuongTinh
            // 
            this.mnuNVDuongTinh.Name = "mnuNVDuongTinh";
            this.mnuNVDuongTinh.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuNVDuongTinh.Size = new System.Drawing.Size(259, 22);
            this.mnuNVDuongTinh.Text = "Danh Sách NV Dương Tính";
            this.mnuNVDuongTinh.Click += new System.EventHandler(this.mnuNVDuongTinh_Click);
            // 
            // mnuCtyDaTest
            // 
            this.mnuCtyDaTest.Name = "mnuCtyDaTest";
            this.mnuCtyDaTest.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuCtyDaTest.Size = new System.Drawing.Size(259, 22);
            this.mnuCtyDaTest.Text = "Danh Sách Cty đã Test theo Y/C";
            this.mnuCtyDaTest.Click += new System.EventHandler(this.mnuCtyDaTest_Click);
            // 
            // mnuXuatBaoCao
            // 
            this.mnuXuatBaoCao.Name = "mnuXuatBaoCao";
            this.mnuXuatBaoCao.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuXuatBaoCao.Size = new System.Drawing.Size(259, 22);
            this.mnuXuatBaoCao.Text = "Xuất Báo cáo";
            this.mnuXuatBaoCao.Click += new System.EventHandler(this.mnuXuatBaoCao_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupTim);
            this.Controls.Add(this.groupThongTinXN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý xét nghiệm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupTim.ResumeLayout(false);
            this.groupTim.PerformLayout();
            this.groupThongTinXN.ResumeLayout(false);
            this.groupThongTinXN.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
namespace QLDSV_sr
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnInDSSV = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongHP = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapGV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnInDSSV)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInDSSV
            // 
            this.btnInDSSV.ExpandCollapseItem.Id = 0;
            this.btnInDSSV.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInDSSV.ExpandCollapseItem,
            this.btnDNhap,
            this.btnNhapLop,
            this.btnNhapSV,
            this.btnNhapMH,
            this.btnNhapDiem,
            this.btnDongHP,
            this.btnTaoTK,
            this.btnNhapGV,
            this.barButtonItem1});
            this.btnInDSSV.Location = new System.Drawing.Point(0, 0);
            this.btnInDSSV.MaxItemId = 11;
            this.btnInDSSV.Name = "btnInDSSV";
            this.btnInDSSV.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.btnInDSSV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.btnInDSSV.Size = new System.Drawing.Size(758, 143);
            // 
            // btnDNhap
            // 
            this.btnDNhap.Caption = "Đăng nhập";
            this.btnDNhap.Id = 1;
            this.btnDNhap.Name = "btnDNhap";
            this.btnDNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDNhap_ItemClick);
            // 
            // btnNhapLop
            // 
            this.btnNhapLop.Caption = "Nhập lớp";
            this.btnNhapLop.Id = 2;
            this.btnNhapLop.Name = "btnNhapLop";
            this.btnNhapLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapLop_ItemClick);
            // 
            // btnNhapSV
            // 
            this.btnNhapSV.Caption = "Nhập sinh viên";
            this.btnNhapSV.Id = 3;
            this.btnNhapSV.Name = "btnNhapSV";
            this.btnNhapSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapSV_ItemClick);
            // 
            // btnNhapMH
            // 
            this.btnNhapMH.Caption = "Nhập môn học";
            this.btnNhapMH.Id = 5;
            this.btnNhapMH.Name = "btnNhapMH";
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Caption = "Nhập điểm";
            this.btnNhapDiem.Id = 6;
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapDiem_ItemClick);
            // 
            // btnDongHP
            // 
            this.btnDongHP.Caption = "Đóng học phí";
            this.btnDongHP.Id = 7;
            this.btnDongHP.Name = "btnDongHP";
            this.btnDongHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongHP_ItemClick);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tạo tài khoản";
            this.btnTaoTK.Id = 8;
            this.btnTaoTK.Name = "btnTaoTK";
            // 
            // btnNhapGV
            // 
            this.btnNhapGV.Caption = "Nhập giảng viên";
            this.btnNhapGV.Id = 9;
            this.btnNhapGV.Name = "btnNhapGV";
            this.btnNhapGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapGV_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In danh sách sinh viên";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nhập liệu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapLop);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapSV);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapMH);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapDiem);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDongHP);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapGV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "In ấn";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAGV
            // 
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(41, 17);
            this.MAGV.Text = "MAGV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(46, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 17);
            this.NHOM.Text = "NHOM";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnInDSSV);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.btnInDSSV;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnInDSSV)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl btnInDSSV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MAGV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnDNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnNhapLop;
        private DevExpress.XtraBars.BarButtonItem btnNhapSV;
        private DevExpress.XtraBars.BarButtonItem btnNhapMH;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiem;
        private DevExpress.XtraBars.BarButtonItem btnDongHP;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnNhapGV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}


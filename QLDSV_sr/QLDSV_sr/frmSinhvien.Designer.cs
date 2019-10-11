namespace QLDSV_sr
{
    partial class frmSinhvien
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label nOISINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label gHICHULabel;
            System.Windows.Forms.Label nGHIHOCLabel;
            this.bdsDiem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PM1 = new QLDSV_sr.DS_PM1();
            this.lOPTableAdapter = new QLDSV_sr.DS_PM1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_sr.DS_PM1TableAdapters.TableAdapterManager();
            this.mALOPComboBox = new System.Windows.Forms.ComboBox();
            this.sINHVIENTableAdapter = new QLDSV_sr.DS_PM1TableAdapters.SINHVIENTableAdapter();
            this.gctrSV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTenKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbSV = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.pHAICheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.nOISINHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gHICHUTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGHIHOCCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hOCPHITableAdapter = new QLDSV_sr.DS_PM1TableAdapters.HOCPHITableAdapter();
            this.dIEMTableAdapter = new QLDSV_sr.DS_PM1TableAdapters.DIEMTableAdapter();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            mALOPLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            nOISINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            nGHIHOCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctrSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHAICheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOISINHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHICHUTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHIHOCCheckEdit.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(371, 11);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(25, 13);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "Lớp";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(12, 22);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(40, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(226, 22);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(428, 22);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(32, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(667, 23);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(35, 13);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHAI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(835, 22);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(66, 13);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // nOISINHLabel
            // 
            nOISINHLabel.AutoSize = true;
            nOISINHLabel.Location = new System.Drawing.Point(12, 68);
            nOISINHLabel.Name = "nOISINHLabel";
            nOISINHLabel.Size = new System.Drawing.Size(55, 13);
            nOISINHLabel.TabIndex = 12;
            nOISINHLabel.Text = "NOISINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDiem, "MASV", true));
            dIACHILabel.Location = new System.Drawing.Point(428, 68);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(46, 13);
            dIACHILabel.TabIndex = 14;
            dIACHILabel.Text = "DIACHI:";
            // 
            // bdsDiem
            // 
            this.bdsDiem.DataMember = "FK_DIEM_SINHVIEN";
            this.bdsDiem.DataSource = this.bdsSV;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLop;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS_PM1;
            // 
            // dS_PM1
            // 
            this.dS_PM1.DataSetName = "DS_PM1";
            this.dS_PM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Location = new System.Drawing.Point(835, 68);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(52, 13);
            gHICHULabel.TabIndex = 16;
            gHICHULabel.Text = "GHICHU:";
            // 
            // nGHIHOCLabel
            // 
            nGHIHOCLabel.AutoSize = true;
            nGHIHOCLabel.Location = new System.Drawing.Point(18, 119);
            nGHIHOCLabel.Name = "nGHIHOCLabel";
            nGHIHOCLabel.Size = new System.Drawing.Size(60, 13);
            nGHIHOCLabel.TabIndex = 18;
            nGHIHOCLabel.Text = "NGHIHOC:";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_sr.DS_PM1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mALOPComboBox
            // 
            this.mALOPComboBox.DataSource = this.bdsLop;
            this.mALOPComboBox.DisplayMember = "TENLOP";
            this.mALOPComboBox.FormattingEnabled = true;
            this.mALOPComboBox.Location = new System.Drawing.Point(402, 8);
            this.mALOPComboBox.Name = "mALOPComboBox";
            this.mALOPComboBox.Size = new System.Drawing.Size(358, 21);
            this.mALOPComboBox.TabIndex = 2;
            this.mALOPComboBox.ValueMember = "MALOP";
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gctrSV
            // 
            this.gctrSV.DataSource = this.bdsSV;
            this.gctrSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctrSV.Location = new System.Drawing.Point(0, 0);
            this.gctrSV.MainView = this.gridView1;
            this.gctrSV.Name = "gctrSV";
            this.gctrSV.Size = new System.Drawing.Size(1246, 302);
            this.gctrSV.TabIndex = 2;
            this.gctrSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView1.GridControl = this.gctrSV;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã SV";
            this.gridColumn1.FieldName = "MASV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ";
            this.gridColumn2.FieldName = "HO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên";
            this.gridColumn3.FieldName = "TEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã lớp";
            this.gridColumn4.FieldName = "MALOP";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Phái";
            this.gridColumn5.FieldName = "PHAI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày sinh";
            this.gridColumn6.FieldName = "NGAYSINH";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nơi sinh";
            this.gridColumn7.FieldName = "NOISINH";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Dịa chỉ";
            this.gridColumn8.FieldName = "DIACHI";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Ghi chú";
            this.gridColumn9.FieldName = "GHICHU";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Nghỉ học";
            this.gridColumn10.FieldName = "NGHIHOC";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::QLDSV_sr.Properties.Resources.Actions_list_add_user_icon_24;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::QLDSV_sr.Properties.Resources.Text_Edit_icon_24;
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QLDSV_sr.Properties.Resources.Delete_2_icon_24;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = global::QLDSV_sr.Properties.Resources.Save_icon_24;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = global::QLDSV_sr.Properties.Resources.Undo_icon_24;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = global::QLDSV_sr.Properties.Resources.Button_Refresh_icon_24;
            this.btnRefresh.Name = "btnRefresh";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = global::QLDSV_sr.Properties.Resources.Exit_24_icon;
            this.btnThoat.Name = "btnThoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1246, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 528);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1246, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 496);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1246, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 496);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTenKhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mALOPComboBox);
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 39);
            this.panel1.TabIndex = 7;
            // 
            // cbTenKhoa
            // 
            this.cbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenKhoa.FormattingEnabled = true;
            this.cbTenKhoa.Location = new System.Drawing.Point(94, 8);
            this.cbTenKhoa.Name = "cbTenKhoa";
            this.cbTenKhoa.Size = new System.Drawing.Size(242, 21);
            this.cbTenKhoa.TabIndex = 7;
            this.cbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbTenKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên khoa";
            // 
            // grbSV
            // 
            this.grbSV.Controls.Add(mASVLabel);
            this.grbSV.Controls.Add(this.txtMaSV);
            this.grbSV.Controls.Add(hOLabel);
            this.grbSV.Controls.Add(this.txtHo);
            this.grbSV.Controls.Add(tENLabel);
            this.grbSV.Controls.Add(this.txtTen);
            this.grbSV.Controls.Add(pHAILabel);
            this.grbSV.Controls.Add(this.pHAICheckEdit);
            this.grbSV.Controls.Add(nGAYSINHLabel);
            this.grbSV.Controls.Add(this.nGAYSINHDateEdit);
            this.grbSV.Controls.Add(nOISINHLabel);
            this.grbSV.Controls.Add(this.nOISINHTextEdit);
            this.grbSV.Controls.Add(dIACHILabel);
            this.grbSV.Controls.Add(this.dIACHITextEdit);
            this.grbSV.Controls.Add(gHICHULabel);
            this.grbSV.Controls.Add(this.gHICHUTextEdit);
            this.grbSV.Controls.Add(nGHIHOCLabel);
            this.grbSV.Controls.Add(this.nGHIHOCCheckEdit);
            this.grbSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSV.Location = new System.Drawing.Point(0, 71);
            this.grbSV.Name = "grbSV";
            this.grbSV.Size = new System.Drawing.Size(1246, 155);
            this.grbSV.TabIndex = 8;
            this.grbSV.TabStop = false;
            this.grbSV.Text = "Thông tin";
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(84, 19);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(121, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(298, 19);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(121, 20);
            this.txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(500, 19);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(121, 20);
            this.txtTen.TabIndex = 5;
            // 
            // pHAICheckEdit
            // 
            this.pHAICheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "PHAI", true));
            this.pHAICheckEdit.Location = new System.Drawing.Point(708, 19);
            this.pHAICheckEdit.MenuManager = this.barManager1;
            this.pHAICheckEdit.Name = "pHAICheckEdit";
            this.pHAICheckEdit.Properties.Caption = "checkEdit1";
            this.pHAICheckEdit.Size = new System.Drawing.Size(121, 19);
            this.pHAICheckEdit.TabIndex = 9;
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.nGAYSINHDateEdit.EditValue = null;
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(907, 19);
            this.nGAYSINHDateEdit.MenuManager = this.barManager1;
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(121, 20);
            this.nGAYSINHDateEdit.TabIndex = 11;
            // 
            // nOISINHTextEdit
            // 
            this.nOISINHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NOISINH", true));
            this.nOISINHTextEdit.Location = new System.Drawing.Point(84, 65);
            this.nOISINHTextEdit.MenuManager = this.barManager1;
            this.nOISINHTextEdit.Name = "nOISINHTextEdit";
            this.nOISINHTextEdit.Size = new System.Drawing.Size(335, 20);
            this.nOISINHTextEdit.TabIndex = 13;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(500, 65);
            this.dIACHITextEdit.MenuManager = this.barManager1;
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(280, 20);
            this.dIACHITextEdit.TabIndex = 15;
            // 
            // gHICHUTextEdit
            // 
            this.gHICHUTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "GHICHU", true));
            this.gHICHUTextEdit.Location = new System.Drawing.Point(907, 65);
            this.gHICHUTextEdit.MenuManager = this.barManager1;
            this.gHICHUTextEdit.Name = "gHICHUTextEdit";
            this.gHICHUTextEdit.Size = new System.Drawing.Size(121, 20);
            this.gHICHUTextEdit.TabIndex = 17;
            // 
            // nGHIHOCCheckEdit
            // 
            this.nGHIHOCCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGHIHOC", true));
            this.nGHIHOCCheckEdit.Location = new System.Drawing.Point(84, 116);
            this.nGHIHOCCheckEdit.MenuManager = this.barManager1;
            this.nGHIHOCCheckEdit.Name = "nGHIHOCCheckEdit";
            this.nGHIHOCCheckEdit.Properties.Caption = "checkEdit1";
            this.nGHIHOCCheckEdit.Size = new System.Drawing.Size(121, 19);
            this.nGHIHOCCheckEdit.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctrSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 302);
            this.panel2.TabIndex = 9;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.DataMember = "FK_HOCPHI_SINHVIEN";
            this.bdsHocPhi.DataSource = this.bdsSV;
            // 
            // frmSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grbSV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSinhvien";
            this.Text = "frmSinhvien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctrSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbSV.ResumeLayout(false);
            this.grbSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHAICheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOISINHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHICHUTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHIHOCCheckEdit.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_PM1 dS_PM1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS_PM1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private DS_PM1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mALOPComboBox;
        private System.Windows.Forms.BindingSource bdsSV;
        private DS_PM1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gctrSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbSV;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cbTenKhoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.CheckEdit pHAICheckEdit;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private DevExpress.XtraEditors.TextEdit nOISINHTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit gHICHUTextEdit;
        private DevExpress.XtraEditors.CheckEdit nGHIHOCCheckEdit;
        private DS_PM1TableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private System.Windows.Forms.BindingSource bdsDiem;
        private DS_PM1TableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsHocPhi;
    }
}
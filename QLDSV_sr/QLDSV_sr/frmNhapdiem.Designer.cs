namespace QLDSV_sr
{
    partial class frmNhapdiem
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label Lan;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTenKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.cbLan = new System.Windows.Forms.ComboBox();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PM1 = new QLDSV_sr.DS_PM1();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_sr.DS_PM1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_sr.DS_PM1TableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV_sr.DS_PM1TableAdapters.MONHOCTableAdapter();
            this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter = new QLDSV_sr.DS_PM1TableAdapters.SP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgDiem = new System.Windows.Forms.DataGridView();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            Lan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(12, 16);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 13);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(430, 16);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(43, 13);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MAMH:";
            // 
            // Lan
            // 
            Lan.AutoSize = true;
            Lan.Location = new System.Drawing.Point(12, 67);
            Lan.Name = "Lan";
            Lan.Size = new System.Drawing.Size(47, 13);
            Lan.TabIndex = 5;
            Lan.Text = "MALOP:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTenKhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            // 
            // cbTenKhoa
            // 
            this.cbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenKhoa.FormattingEnabled = true;
            this.cbTenKhoa.Location = new System.Drawing.Point(285, 17);
            this.cbTenKhoa.Name = "cbTenKhoa";
            this.cbTenKhoa.Size = new System.Drawing.Size(290, 21);
            this.cbTenKhoa.TabIndex = 7;
            this.cbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbTenKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên khoa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnGhi);
            this.panel2.Controls.Add(this.btnNhap);
            this.panel2.Controls.Add(Lan);
            this.panel2.Controls.Add(this.cbLan);
            this.panel2.Controls.Add(mAMHLabel);
            this.panel2.Controls.Add(this.cbMaMH);
            this.panel2.Controls.Add(mALOPLabel);
            this.panel2.Controls.Add(this.cbMaLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 108);
            this.panel2.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(541, 57);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(415, 57);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(75, 23);
            this.btnGhi.TabIndex = 7;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(289, 59);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 6;
            this.btnNhap.Text = "Nhap";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // cbLan
            // 
            this.cbLan.FormattingEnabled = true;
            this.cbLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLan.Location = new System.Drawing.Point(65, 59);
            this.cbLan.Name = "cbLan";
            this.cbLan.Size = new System.Drawing.Size(94, 21);
            this.cbLan.TabIndex = 4;
            // 
            // cbMaMH
            // 
            this.cbMaMH.DataSource = this.mONHOCBindingSource;
            this.cbMaMH.DisplayMember = "TENMH";
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(479, 13);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(279, 21);
            this.cbMaMH.TabIndex = 3;
            this.cbMaMH.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS_PM1;
            // 
            // dS_PM1
            // 
            this.dS_PM1.DataSetName = "DS_PM1";
            this.dS_PM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMaLop
            // 
            this.cbMaLop.DataSource = this.lOPBindingSource;
            this.cbMaLop.DisplayMember = "TENLOP";
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(65, 13);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(299, 21);
            this.cbMaLop.TabIndex = 1;
            this.cbMaLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS_PM1;
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
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_sr.DS_PM1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource
            // 
            this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource.DataMember = "SP_HIEN_THI_DANH_SACH_SV_NHAP_DIEM";
            this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource.DataSource = this.dS_PM1;
            // 
            // sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter
            // 
            this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgDiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 301);
            this.panel3.TabIndex = 2;
            // 
            // dgDiem
            // 
            this.dgDiem.AutoGenerateColumns = false;
            this.dgDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.dIEMDataGridViewTextBoxColumn});
            this.dgDiem.DataSource = this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource;
            this.dgDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDiem.Location = new System.Drawing.Point(0, 0);
            this.dgDiem.Name = "dgDiem";
            this.dgDiem.Size = new System.Drawing.Size(800, 301);
            this.dgDiem.TabIndex = 0;
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "Mã SV";
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIEMDataGridViewTextBoxColumn
            // 
            this.dIEMDataGridViewTextBoxColumn.DataPropertyName = "DIEM";
            this.dIEMDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.dIEMDataGridViewTextBoxColumn.Name = "dIEMDataGridViewTextBoxColumn";
            // 
            // frmNhapdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapdiem";
            this.Text = "frmNhapdiem";
            this.Load += new System.EventHandler(this.frmNhapdiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DS_PM1 dS_PM1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DS_PM1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private DS_PM1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbMaLop;
        private DS_PM1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.ComboBox cbLan;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnNhap;
        public System.Windows.Forms.ComboBox cbTenKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource;
        private DS_PM1TableAdapters.SP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgDiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMDataGridViewTextBoxColumn;
    }
}
namespace QLDSV_sr
{
    partial class frmInDSSV
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
            this.dS_PM1 = new QLDSV_sr.DS_PM1();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_sr.DS_PM1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_sr.DS_PM1TableAdapters.TableAdapterManager();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbTenKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(59, 85);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 13);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "MALOP:";
            // 
            // dS_PM1
            // 
            this.dS_PM1.DataSetName = "DS_PM1";
            this.dS_PM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS_PM1;
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
            // cbLop
            // 
            this.cbLop.DataSource = this.bdsLop;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(112, 82);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(200, 21);
            this.cbLop.TabIndex = 2;
            this.cbLop.ValueMember = "MALOP";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(340, 79);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(474, 79);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // cbTenKhoa
            // 
            this.cbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenKhoa.FormattingEnabled = true;
            this.cbTenKhoa.Location = new System.Drawing.Point(244, 25);
            this.cbTenKhoa.Name = "cbTenKhoa";
            this.cbTenKhoa.Size = new System.Drawing.Size(290, 21);
            this.cbTenKhoa.TabIndex = 7;
            this.cbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbTenKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên khoa";
            // 
            // frmInDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTenKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.cbLop);
            this.Name = "frmInDSSV";
            this.Text = "frmInDSSV";
            this.Load += new System.EventHandler(this.frmInDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_PM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_PM1 dS_PM1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS_PM1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private DS_PM1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.ComboBox cbTenKhoa;
        private System.Windows.Forms.Label label1;
    }
}
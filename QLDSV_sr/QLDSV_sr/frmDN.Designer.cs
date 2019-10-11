namespace QLDSV_sr
{
    partial class frmDN
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
            System.Windows.Forms.Label tENPMLabel;
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dS_QLDSV = new QLDSV_sr.DS_QLDSV();
            this.bds_SERVER = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLDSV_sr.DS_QLDSVTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager = new QLDSV_sr.DS_QLDSVTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cbSVName = new System.Windows.Forms.ComboBox();
            tENPMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SERVER)).BeginInit();
            this.SuspendLayout();
            // 
            // tENPMLabel
            // 
            tENPMLabel.AutoSize = true;
            tENPMLabel.Location = new System.Drawing.Point(26, 19);
            tENPMLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENPMLabel.Name = "tENPMLabel";
            tENPMLabel.Size = new System.Drawing.Size(60, 13);
            tENPMLabel.TabIndex = 15;
            tENPMLabel.Text = "Tên Server";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(90, 117);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(90, 25);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(186, 117);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 25);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dS_QLDSV
            // 
            this.dS_QLDSV.DataSetName = "DS_QLDSV";
            this.dS_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_SERVER
            // 
            this.bds_SERVER.DataMember = "V_DSPM";
            this.bds_SERVER.DataSource = this.dS_QLDSV;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_sr.DS_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(90, 48);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(186, 20);
            this.txtTaiKhoan.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(90, 84);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(186, 20);
            this.txtMatKhau.TabIndex = 14;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // cbSVName
            // 
            this.cbSVName.DataSource = this.bds_SERVER;
            this.cbSVName.DisplayMember = "TENPM";
            this.cbSVName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSVName.FormattingEnabled = true;
            this.cbSVName.Location = new System.Drawing.Point(90, 11);
            this.cbSVName.Margin = new System.Windows.Forms.Padding(2);
            this.cbSVName.Name = "cbSVName";
            this.cbSVName.Size = new System.Drawing.Size(186, 21);
            this.cbSVName.TabIndex = 16;
            this.cbSVName.ValueMember = "TENSERVER";
            this.cbSVName.SelectedIndexChanged += new System.EventHandler(this.tENPMComboBox_SelectedIndexChanged);
            // 
            // frmDN
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(335, 172);
            this.Controls.Add(tENPMLabel);
            this.Controls.Add(this.cbSVName);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDN";
            this.Load += new System.EventHandler(this.frmDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SERVER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private DS_QLDSV dS_QLDSV;
        private System.Windows.Forms.BindingSource bds_SERVER;
        private DS_QLDSVTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DS_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ComboBox cbSVName;
    }
}
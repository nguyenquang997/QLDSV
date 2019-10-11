using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_sr
{
    public partial class frmSinhvien : Form
    {
        
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_PM1);

        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            dS_PM1.EnforceConstraints = false;
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_PM1.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.dS_PM1.DIEM);

            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;// TODO: This line of code loads data into the 'dS_PM1.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Fill(this.dS_PM1.HOCPHI);
            
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_PM1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS_PM1.LOP);
         
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_PM1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.dS_PM1.SINHVIEN);
            cbTenKhoa.DataSource = Program.bds_dspm;
            cbTenKhoa.DisplayMember = "TENPM";
            cbTenKhoa.ValueMember = "TENSERVER";
            cbTenKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
            {
                cbTenKhoa.Enabled = true;
            }
            else
            {
                cbTenKhoa.Enabled = false;

            }
          

        }

        private void cbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (cbTenKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cbTenKhoa.SelectedValue.ToString();
                if (cbTenKhoa.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0) return;
                else
                {
                    this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dS_PM1.DIEM' table. You can move, or remove it, as needed.
                    this.dIEMTableAdapter.Fill(this.dS_PM1.DIEM);

                    this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;// TODO: This line of code loads data into the 'dS_PM1.HOCPHI' table. You can move, or remove it, as needed.
                    this.hOCPHITableAdapter.Fill(this.dS_PM1.HOCPHI);

                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS_PM1.LOP);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dS_PM1.GIANGVIEN' table. You can move, or remove it, as needed.
                    this.sINHVIENTableAdapter.Fill(this.dS_PM1.SINHVIEN);
                   
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grbSV.Enabled = true; btnGhi.Enabled = true; btnXoa.Enabled = false; cbTenKhoa.Enabled = false; btnThem.Enabled = false;
            btnSua.Enabled = false; gctrSV.Enabled = false;
            bdsSV.AddNew();
            txtMaSV.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Ma sinh vien khong duoc bo trong", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Ho không được rỗng", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Ten khong duoc rong ", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.SP_KTMASV";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = txtMaSV.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

            if (Ret == "1")
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
                bdsSV.RemoveCurrent();
                bdsSV.AddNew();
                txtMaSV.Focus();
                return;

            }
            if (Ret == "2")
            {
                MessageBox.Show("Mã sinh viên đã tồn tại ở khoa khác");
                bdsSV.RemoveCurrent();
                bdsSV.AddNew();
                txtMaSV.Focus();
                return;
            }
            else
            {

                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS_PM1.SINHVIEN);
                    grbSV.Enabled = false; btnGhi.Enabled = false; btnXoa.Enabled = true; cbTenKhoa.Enabled = true; btnThem.Enabled = true;
                    btnSua.Enabled = true; gctrSV.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi ghi giảng viên . " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsHocPhi.Count > 0 )
            {
                MessageBox.Show("Khong the xoa, ma sinh vien da ton tai trong danh sach dong hoc phi");
                return;
            }
            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("Khong the xoa, ma sinh vien dang ton tai trong bang diem");
                    return;

            }
            DialogResult tb = MessageBox.Show("Ban co that su muon xoa nhan vien ma " + txtMaSV.Text, "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                bdsSV.RemoveCurrent();
                this.sINHVIENTableAdapter.Update(this.dS_PM1.SINHVIEN);
            }
             
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            grbSV.Enabled = false; btnGhi.Enabled = false; btnXoa.Enabled = true; cbTenKhoa.Enabled = true; btnThem.Enabled = true;
            btnSua.Enabled = true; gctrSV.Enabled = true;
            this.bdsSV.CancelEdit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLDSV_sr
{
    public partial class frmNhanvien : Form
    {
        string makhoa = "";
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_PM1);

        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_PM1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dS_PM1.KHOA);

            dS_PM1.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_PM1.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.dS_PM1.GIANGVIEN);
            makhoa = txtmaKH.Text;
           // makhoa = ((DataRowView)bdsGV[0])["MAKH"].ToString();
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
            btnGhi.Enabled = false; grbNhanvien.Enabled = false;

        }

        private void cbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
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
                    this.kHOATableAdapter.Fill(this.dS_PM1.KHOA);
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dS_PM1.GIANGVIEN' table. You can move, or remove it, as needed.
                    this.gIANGVIENTableAdapter.Fill(this.dS_PM1.GIANGVIEN);
                    makhoa = txtmaKH.Text;
                   // makhoa = ((DataRowView)bdsGV[0])["MAKH"].ToString();
                }
            }
            catch(Exception)
            {
                return;
            }
           
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grbNhanvien.Enabled = true; btnGhi.Enabled = true; btnXoa.Enabled = false; cbTenKhoa.Enabled = false; btnThem.Enabled = false;
            btnSua.Enabled = false; gctrGV.Enabled = false;
            bdsGV.AddNew();
            txtmaKH.Text = makhoa;
            txtMaGV.Focus(); 
        }
        
            private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tài tên khoản", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được rỗng", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tài tên khoản", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.SP_KiemTraMaGiangVien";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MAGV", SqlDbType.NChar).Value = txtMaGV.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

            if (Ret=="1" )
            {
                MessageBox.Show("Mã giảng viên đã tồn tại");
                bdsGV.RemoveCurrent();
                bdsGV.AddNew();
                txtmaKH.Text = makhoa;
                txtMaGV.Focus();
                return;

            }
            if (Ret == "2")
            {
                MessageBox.Show("Mã giảng viên đã tồn tại ở khoa khác");
                bdsGV.RemoveCurrent();
                bdsGV.AddNew();
                txtmaKH.Text = makhoa;
                txtMaGV.Focus();
                return;
            }
            else
            {

                try
                {
                    bdsGV.EndEdit();
                    bdsGV.ResetCurrentItem();
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Update(this.dS_PM1.GIANGVIEN);
                    grbNhanvien.Enabled = false; btnGhi.Enabled = false; btnXoa.Enabled = true; cbTenKhoa.Enabled = true; btnThem.Enabled = true;
                    btnSua.Enabled = true; gctrGV.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi ghi giảng viên . " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           DialogResult tb= MessageBox.Show("Ban co that su muon xoa nhan vien ma " + txtMaGV.Text,"Thong bao",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                bdsGV.RemoveCurrent();
                this.gIANGVIENTableAdapter.Update(this.dS_PM1.GIANGVIEN);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIANGVIENTableAdapter.Update(this.dS_PM1.GIANGVIEN);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grbNhanvien.Enabled = true; btnGhi.Enabled = true; btnXoa.Enabled = false; cbTenKhoa.Enabled = false; btnThem.Enabled = false;
            btnSua.Enabled = false; gctrGV.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

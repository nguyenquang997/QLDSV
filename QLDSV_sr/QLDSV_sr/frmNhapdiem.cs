using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_sr
{
    public partial class frmNhapdiem : Form
    {
        public frmNhapdiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_PM1);

        }

        private void frmNhapdiem_Load(object sender, EventArgs e)
        {
            dS_PM1.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_PM1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS_PM1.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_PM1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS_PM1.LOP);
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
            cbLan.SelectedIndex = 0;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            btnNhap.Enabled = false;


            if (cbLan.Text.Trim() == "2")
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_KTDIEM";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = cbMaLop.SelectedValue;
                Program.sqlcmd.Parameters.Add("@MAMON", SqlDbType.NChar).Value = cbMaMH.SelectedValue;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

                if (Ret == "0")
                {
                    MessageBox.Show("Lop ban vua chon chua thi mon" + cbMaMH.Text);
                    btnNhap.Enabled = true;
                    return;
                }

            }

            this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter.Fill(this.dS_PM1.SP_HIEN_THI_DANH_SACH_SV_NHAP_DIEM,
            cbMaLop.SelectedValue.ToString(), cbMaMH.SelectedValue.ToString(), int.Parse(cbLan.Text));
            dgDiem.DataSource = dS_PM1;
            dgDiem.DataMember = sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource.DataMember;
            btnHuy.Enabled = true;
            btnNhap.Enabled = false;
            btnGhi.Enabled = true;
            cbTenKhoa.Enabled = false;
            cbMaLop.Enabled = false;
            cbMaMH.Enabled = false;
            cbLan.Enabled = false;
            dgDiem.Enabled = true;
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
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS_PM1.LOP);
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dS_PM1.GIANGVIEN' table. You can move, or remove it, as needed.
                    this.mONHOCTableAdapter.Fill(this.dS_PM1.MONHOC);

                    // makhoa = ((DataRowView)bdsGV[0])["MAKH"].ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i <= sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource.Count - 1; i++)
            {
                bool ckeckdiem = float.TryParse(dgDiem.Rows[i].Cells[2].Value.ToString(), out float diem);
                if (dgDiem.Rows[i].Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show("Ban chua nhap diem cho sinh vien" + dgDiem.Rows[i].Cells[1].Value.ToString());
                    return;
                }
                
                if (float.Parse( dgDiem.Rows[i].Cells[2].Value.ToString() )> 10)
                {
                    MessageBox.Show("Diem sinh vien" + dgDiem.Rows[i].Cells[1].Value.ToString() + "khong duoc lon hon 10");
                    return;
                }
            
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.sp_ktnhapdiem";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.Char).Value = dgDiem.Rows[i].Cells[0].Value.ToString();
                Program.sqlcmd.Parameters.Add("@mamh", SqlDbType.Char).Value = cbMaMH.SelectedValue.ToString();
                Program.sqlcmd.Parameters.Add("@lan", SqlDbType.Int).Value = int.Parse(cbLan.Text);
                Program.sqlcmd.Parameters.Add("@diem", SqlDbType.Float).Value = float.Parse(dgDiem.Rows[i].Cells[2].Value.ToString()) ;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret == "1")
                {
                    MessageBox.Show("Sinh vien " + dgDiem.Rows[i].Cells[1].Value.ToString() + " da co diem thi lan 2, diem khong duoc lon hon 4");
                    this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMTableAdapter.Fill(this.dS_PM1.SP_HIEN_THI_DANH_SACH_SV_NHAP_DIEM,
                    cbMaLop.SelectedValue.ToString(), cbMaMH.SelectedValue.ToString(), int.Parse(cbLan.Text));
                    return;
                }


            }
            if (i == sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource.Count)
            {
                MessageBox.Show("Ghi điểm thành công!!!", "THÔNG BÁO", MessageBoxButtons.OK);
                btnNhap.Enabled = true;
                btnGhi.Enabled = false;
                cbTenKhoa.Enabled = true;
                cbMaLop.Enabled = true;
                cbMaMH.Enabled = true;
                cbLan.Enabled = true;
                dgDiem.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ghi điểm thất bại!!!", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgDiem.Enabled = false;
            btnHuy.Enabled = false;
            btnNhap.Enabled = true;
            btnGhi.Enabled = false;
            cbTenKhoa.Enabled = true;
            cbMaLop.Enabled = true;
            cbMaMH.Enabled = true;
            cbLan.Enabled = true;
            this.sP_HIEN_THI_DANH_SACH_SV_NHAP_DIEMBindingSource.CancelEdit();
        }
    }
    }


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
    
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
            txtTaiKhoan.Focus();
            
        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLDSV.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_QLDSV.V_DSPM);
            cbSVName.SelectedIndex = 1;
            cbSVName.SelectedIndex = 0;
        }

        private void tENPMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSVName.SelectedValue!=null)
            Program.servername = cbSVName.SelectedValue.ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)


         {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không  được bỏ trống");
                txtTaiKhoan.Focus();
                return;
             
            }
            
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không  được bỏ trống");
                txtMatKhau.Focus();
                return;

            }
            
            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0) return;
                //MessageBox.Show("Kết nối thành công");
                
            Program.mKhoa = cbSVName.SelectedIndex;
            Program.bds_dspm = bds_SERVER;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            
            SqlDataReader myReader;
            string strlenh = "exec SP_DANGNHAP'" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            myReader.Read();
            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản đang nhập của bạn không có quyền truy cập dữ liệu");
            }
            Program.mGroup = myReader.GetString(1);
            Program.mHoten = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MAGV.Text ="Mã giảng viên: "+ Program.username;
            Program.frmChinh.HOTEN.Text ="Họ tên: "+ Program.mHoten;
            Program.frmChinh.NHOM.Text ="Nhóm: "+ Program.mGroup;
            this.Hide();
            Program.frmChinh.ShowDialog();
            this.Show();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát chương trinh không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

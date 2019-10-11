using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLDSV_sr
{
    public partial class frmInDSSV : Form
    {
        public frmInDSSV()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_PM1);

        }

        private void frmInDSSV_Load(object sender, EventArgs e)
        {
            dS_PM1.EnforceConstraints = false;
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
           

        }



        private void btnPreview_Click(object sender, EventArgs e)
        {
            xtr_InDSSV rpt = new xtr_InDSSV(cbLop.SelectedValue.ToString());
            rpt.lblLop.Text = cbLop.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
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
                   
                 
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}

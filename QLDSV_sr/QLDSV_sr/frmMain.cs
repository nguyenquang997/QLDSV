using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_sr
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnNhapGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmNhanvien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanvien f = new frmNhanvien();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnDNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(Form frm in this.MdiChildren)
            
                frm.Close();
            this.Close();
            
            
        }

        private void btnNhapLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
                Activate;
            }
        }

        private void btnNhapSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhvien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhvien f = new frmSinhvien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapdiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapdiem f = new frmNhapdiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInDSSV));
            if (frm != null) frm.Activate();
            else
            {
                frmInDSSV f = new frmInDSSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDongHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocphi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocphi f = new frmHocphi();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
    
}

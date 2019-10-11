using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_sr
{
    public partial class xtr_InDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public xtr_InDSSV(string malop)
        {
            InitializeComponent();
            dS_PM11.EnforceConstraints = false;
            this.sp_dssinhvientheolopTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sp_dssinhvientheolopTableAdapter1.Fill(dS_PM11.sp_dssinhvientheolop, malop);
        }

    }
}

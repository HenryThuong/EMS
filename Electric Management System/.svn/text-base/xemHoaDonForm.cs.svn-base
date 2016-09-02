using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.App_Code;
using Electric_Management_System.Reports;

namespace Electric_Management_System
{
    public partial class xemHoaDonForm : Form
    {
        ViewInvoice xemHD;
        ViewInvoiceSX3 xemHDSX3;

        public string hoaDonID;
        public bool hoaDonSX3;

        public xemHoaDonForm()
        {
            InitializeComponent();
        }

        private void xemHoaDonForm_Load(object sender, EventArgs e)
        {
            if (hoaDonSX3 == true)
            {
                xemHDSX3 = new ViewInvoiceSX3();
                xemHDSX3.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;
                xemHDSX3.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                Program.fillViewHDSX3(hoaDonID, xemHDSX3);
                crystalReportViewer1.ReportSource = xemHDSX3;
            }
            else
            {
                xemHD = new ViewInvoice();
                xemHD.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;
                xemHD.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                Program.fillViewHD(hoaDonID, xemHD);
                crystalReportViewer1.ReportSource = xemHD;
            }
        }

        private void xemHoaDonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hoaDonSX3 == true)
            {
                xemHDSX3.Dispose();
            }
            else
            {
                xemHD.Dispose();
            }
        }
    }
}
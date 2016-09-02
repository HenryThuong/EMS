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
    public partial class xemDanhSachKHForm : Form
    {
        DanhSachKhachHang dskh;

        public string StationID;
        public string tenTram;

        public xemDanhSachKHForm()
        {
            InitializeComponent();
        }

        private void danhSachKHForm_Load(object sender, EventArgs e)
        {
            this.Text = "EMS - Danh Sách Khách Hàng " + tenTram;
            dskh = new DanhSachKhachHang();
            dskh.SetDataSource(DataTier.getCustomer(StationID));
            dskh.SetParameterValue("tenTram", tenTram);
            crystalReportViewer1.ReportSource = dskh;
        }

        private void xemDanhSachKHForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dskh.Dispose();
        }
    }
}

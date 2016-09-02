using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.Reports;

namespace Electric_Management_System
{
    public partial class InHoaDonForm : Form
    {
        public InHoaDonForm()
        {
            InitializeComponent();
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            HoaDonGiayTrang hd;
            for (int i = int.Parse(txtNumber.Text); i <= (int.Parse(txtNumber.Text) + int.Parse(txtQuantity.Text) -1); i++)
            {
                hd = new HoaDonGiayTrang();
                hd.SetParameterValue("InvoiceNumber", i.ToString());
                hd.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                hd.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                hd.PrintToPrinter(1, false, 1, 1);
                hd.Dispose();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electric_Management_System
{
    public partial class ghiSoDienDSForm : Form
    {
        public ghiSoDienDSForm()
        {
            InitializeComponent();
        }

        private void ghiSoDienDSForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDBDataSet.DSChotSo' table. You can move, or remove it, as needed.
            // this.dSChotSoTableAdapter.Fill(this.eMSDBDataSet.DSChotSo);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.App_Code;
using Electric_Management_System.App_Data;
using Electric_Management_System.Reports;

namespace Electric_Management_System
{
    public partial class theoDoiGTGTForm : Form
    {
        private enum ActionMode : int { Add = 1, Edit = 2 };

        private ActionMode actionMode = ActionMode.Add;

        Guid gtgtID;

        public theoDoiGTGTForm()
        {
            InitializeComponent();
        }

        private void theoDoiGTGTForm_Load(object sender, EventArgs e)
        {
            this.cboYear.Text = DateTime.Today.Year.ToString();
            this.tbl_TheoDoiGTGTTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiGTGT, int.Parse(cboYear.Text));
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearForm();
            this.tbl_TheoDoiGTGTTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiGTGT, int.Parse(cboYear.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string soChungTu = this.CheckRequiredField(txtSoChungTu);
            string dienGiai = this.CheckRequiredField(txtDescription);
            decimal dauRa = this.CheckMoney(txtDauRa);
            decimal dauVao = this.CheckMoney(txtDauVao);
            decimal phaiNop = this.CheckMoney(txtPhaiNop);
            decimal daNop = this.CheckMoney(txtDaNop);
            decimal conPhaiNop = this.CheckMoney(txtConPhaiNop);
            decimal nopThua = this.CheckMoney(txtNopThua);

            if (!this.HasError())
            {
                int result = 0;
                if (actionMode == ActionMode.Add)
                {
                    gtgtID = Guid.NewGuid();
                    result = this.tbl_TheoDoiGTGTTableAdapter.Insert(
                        dtpNgayGhiSo.Value,
                        soChungTu,
                        dtpNgayChungTu.Value,
                        dauRa,
                        dauVao,
                        phaiNop,
                        daNop,
                        conPhaiNop,
                        nopThua,
                        dienGiai);
                }
                else if (actionMode == ActionMode.Edit)
                {
                    result = DataTier.UpdateGTGT(
                        gtgtID,
                        soChungTu,
                        dtpNgayChungTu.Value,
                        dtpNgayGhiSo.Value,
                        dauRa,
                        dauVao,
                        phaiNop,
                        daNop,
                        conPhaiNop,
                        nopThua,
                        dienGiai) ? 1 : 0;
                }

                if (result > 0)
                {
                    this.ClearForm();
                    this.tbl_TheoDoiGTGTTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiGTGT, int.Parse(cboYear.Text));
                    this.SelectRowByID(gtgtID.ToString());
                    this.dgvGTGT.Enabled = true;
                    this.btnCancel.Visible = false;
                    actionMode = ActionMode.Add;
                }
                else
                {
                    MessageBox.Show(
                        "Lưu dữ liệu không thành công, bạn hãy thử lại sau.",
                        "Lưu dữ liệu không thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.dgvGTGT.Enabled = true;
            this.btnCancel.Visible = false;
            actionMode = ActionMode.Add;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            xemBaoCaoForm xemBaoCao = new xemBaoCaoForm();
            xemBaoCao.reportType = "theoDoiGTGT";
            xemBaoCao.DataSource = this.eMSDBDataSet.tbl_TheoDoiGTGT;
            xemBaoCao.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            TheoDoiGTGT gtgtReport = new TheoDoiGTGT();
            gtgtReport.SetDataSource(eMSDBDataSet);
            gtgtReport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            gtgtReport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            gtgtReport.PrintToPrinter(1, false, 1, 1);
            gtgtReport.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbl_TheoDoiGTGTTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiGTGT, int.Parse(cboYear.Text));
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGTGT.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvGTGT.SelectedRows[0].Cells[0].Value.ToString()))
            {
                dgvGTGT.Enabled = false;
                gtgtID = Guid.Parse(dgvGTGT.SelectedRows[0].Cells[0].Value.ToString());
                dtpNgayGhiSo.Value = DateTime.Parse(dgvGTGT.SelectedRows[0].Cells[1].Value.ToString());
                txtSoChungTu.Text = dgvGTGT.SelectedRows[0].Cells[2].Value.ToString();
                dtpNgayChungTu.Value = DateTime.Parse(dgvGTGT.SelectedRows[0].Cells[3].Value.ToString());
                txtDauRa.Text = dgvGTGT.SelectedRows[0].Cells[4].Value.ToString();
                txtDauVao.Text = dgvGTGT.SelectedRows[0].Cells[5].Value.ToString();
                txtPhaiNop.Text = dgvGTGT.SelectedRows[0].Cells[6].Value.ToString();
                txtDaNop.Text = dgvGTGT.SelectedRows[0].Cells[7].Value.ToString();
                txtConPhaiNop.Text = dgvGTGT.SelectedRows[0].Cells[8].Value.ToString();
                txtNopThua.Text = dgvGTGT.SelectedRows[0].Cells[9].Value.ToString();
                txtDescription.Text = dgvGTGT.SelectedRows[0].Cells[11].Value.ToString();
                actionMode = ActionMode.Edit;
                btnCancel.Visible = true;
                dtpNgayGhiSo.Focus();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGTGT.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvGTGT.SelectedRows[0].Cells[0].Value.ToString()))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa dòng này không?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.tbl_TheoDoiGTGTTableAdapter.Delete(Guid.Parse(dgvGTGT.SelectedRows[0].Cells[0].Value.ToString())) > 0)
                    {
                        this.tbl_TheoDoiGTGTTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiGTGT, int.Parse(cboYear.Text));
                    }
                    else
                    {
                        MessageBox.Show(
                        "Xóa dữ liệu không thành công, bạn hãy thử lại sau.",
                        "Xóa dữ liệu không thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvGTGT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dgvGTGT.Rows[e.RowIndex].Selected = true;
                Rectangle r = dgvGTGT.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                this.contextMenuStrip.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            }
        }

        private void SelectRowByID(string gtgtID)
        {
            foreach (DataGridViewRow row in this.dgvGTGT.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(gtgtID))
                {
                    dgvGTGT.Rows[row.Index].Selected = true;
                }
            }
        }

        private void ClearForm()
        {
            this.dtpNgayGhiSo.Value = DateTime.Today;
            this.txtSoChungTu.Clear();
            this.dtpNgayChungTu.Value = DateTime.Today;
            this.txtDescription.Clear();
            this.txtDauRa.Clear();
            this.txtDauVao.Clear();
            this.txtPhaiNop.Clear();
            this.txtDaNop.Clear();
            this.txtConPhaiNop.Clear();
            this.txtNopThua.Clear();
        }

        private decimal CheckMoney(TextBox textBox)
        {
            decimal result = 0;
            bool isMoney = decimal.TryParse(textBox.Text, out result);
            if (!isMoney || result < 0)
            {
                errorProvider.SetError(textBox, "Bạn phải nhập số tiền có dạng số lớn hơn hoặc bằng 0");
                return -1;
            }
            errorProvider.SetError(textBox, string.Empty);
            return result;
        }

        private string CheckRequiredField(TextBox textBox)
        {
            string result = textBox.Text;
            if (string.IsNullOrEmpty(result))
            {
                errorProvider.SetError(textBox, "Bạn không thể bỏ trống trường này");
                return null;
            }
            errorProvider.SetError(textBox, string.Empty);
            return result;
        }

        private bool HasError()
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control ctrl in control.Controls)
                    {
                        if (errorProvider.GetError(ctrl) != string.Empty)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    if (errorProvider.GetError(control) != string.Empty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

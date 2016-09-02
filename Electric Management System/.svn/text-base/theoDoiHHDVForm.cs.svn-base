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
    public partial class theoDoiHHDVForm : Form
    {
        private enum ActionMode : int { Add = 1, Edit = 2 };

        private ActionMode actionMode = ActionMode.Add;

        Guid hhdvID;

        public theoDoiHHDVForm()
        {
            InitializeComponent();
        }

        private void theoDoiHHDVForm_Load(object sender, EventArgs e)
        {
            this.cboYear.Text = DateTime.Today.Year.ToString();
            this.tbl_TheoDoiHHDVTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiHHDV, int.Parse(cboYear.Text));
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearForm();
            this.tbl_TheoDoiHHDVTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiHHDV, int.Parse(cboYear.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int soDienMua = this.CheckNumber(txtSoDienMua);
            decimal tienMua = this.CheckMoney(txtTienMua);
            decimal thueMua = this.CheckMoney(txtThueMua);
            int soDienBan = this.CheckNumber(txtSoDienBan);
            decimal tienBan = this.CheckMoney(txtTienBan);
            decimal thueBan = this.CheckMoney(txtThueBan);
            decimal thuePhaiNop = this.CheckMoney(txtThuePhaiNop);
            decimal thueDaNop = this.CheckMoney(txtThueDaNop);
            decimal thueTNDN = this.CheckMoney(txtThueTNDN);

            if (!this.HasError())
            {
                int result = 0;
                if (actionMode == ActionMode.Add)
                {
                    hhdvID = Guid.NewGuid();
                    result = this.tbl_TheoDoiHHDVTableAdapter.Insert(
                        dtpNgayGhiSo.Value,
                        soDienMua,
                        tienMua,
                        thueMua,
                        soDienBan,
                        tienBan,
                        thueBan,
                        thuePhaiNop,
                        thueDaNop,
                        thueTNDN,
                        string.Empty);
                }
                else if (actionMode == ActionMode.Edit)
                {
                    result = DataTier.UpdateHHDV(
                        hhdvID,
                        dtpNgayGhiSo.Value,
                        soDienMua,
                        tienMua,
                        thueMua,
                        soDienBan,
                        tienBan,
                        thueBan,
                        thuePhaiNop,
                        thueDaNop,
                        thueTNDN) ? 1 : 0;
                }

                if (result > 0)
                {
                    this.ClearForm();
                    this.tbl_TheoDoiHHDVTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiHHDV, int.Parse(cboYear.Text));
                    this.SelectRowByID(hhdvID.ToString());
                    this.dgvHHDV.Enabled = true;
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
            this.dgvHHDV.Enabled = true;
            this.btnCancel.Visible = false;
            actionMode = ActionMode.Add;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            xemBaoCaoForm xemBaoCao = new xemBaoCaoForm();
            xemBaoCao.reportType = "theoDoiHHDV";
            xemBaoCao.DataSource = this.eMSDBDataSet.tbl_TheoDoiHHDV;
            xemBaoCao.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            TheoDoiHHDV hhdvReport = new TheoDoiHHDV();
            hhdvReport.SetDataSource(eMSDBDataSet);
            hhdvReport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            hhdvReport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            hhdvReport.PrintToPrinter(1, false, 1, 1);
            hhdvReport.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbl_TheoDoiHHDVTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiHHDV, int.Parse(cboYear.Text));
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvHHDV.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvHHDV.SelectedRows[0].Cells[0].Value.ToString()))
            {
                dgvHHDV.Enabled = false;
                hhdvID = Guid.Parse(dgvHHDV.SelectedRows[0].Cells[0].Value.ToString());
                dtpNgayGhiSo.Value = DateTime.Parse(dgvHHDV.SelectedRows[0].Cells[1].Value.ToString());
                txtSoDienMua.Text = dgvHHDV.SelectedRows[0].Cells[2].Value.ToString();
                txtTienMua.Text = dgvHHDV.SelectedRows[0].Cells[3].Value.ToString();
                txtThueMua.Text = dgvHHDV.SelectedRows[0].Cells[4].Value.ToString();
                txtSoDienBan.Text = dgvHHDV.SelectedRows[0].Cells[5].Value.ToString();
                txtTienBan.Text = dgvHHDV.SelectedRows[0].Cells[6].Value.ToString();
                txtThueBan.Text = dgvHHDV.SelectedRows[0].Cells[7].Value.ToString();
                txtThuePhaiNop.Text = dgvHHDV.SelectedRows[0].Cells[8].Value.ToString();
                txtThueDaNop.Text = dgvHHDV.SelectedRows[0].Cells[9].Value.ToString();
                txtThueTNDN.Text = dgvHHDV.SelectedRows[0].Cells[10].Value.ToString();
                actionMode = ActionMode.Edit;
                btnCancel.Visible = true;
                dtpNgayGhiSo.Focus();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvHHDV.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvHHDV.SelectedRows[0].Cells[0].Value.ToString()))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa dòng này không?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.tbl_TheoDoiHHDVTableAdapter.Delete(Guid.Parse(dgvHHDV.SelectedRows[0].Cells[0].Value.ToString())) > 0)
                    {
                        this.tbl_TheoDoiHHDVTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiHHDV, int.Parse(cboYear.Text));
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

        private void dgvHHDV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dgvHHDV.Rows[e.RowIndex].Selected = true;
                Rectangle r = dgvHHDV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                this.contextMenuStrip.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            }
        }

        private void ClearForm()
        {
            this.dtpNgayGhiSo.Value = DateTime.Today;
            this.txtSoDienMua.Clear();
            this.txtTienMua.Clear();
            this.txtThueMua.Clear();
            this.txtSoDienBan.Clear();
            this.txtTienBan.Clear();
            this.txtThueBan.Clear();
            this.txtThuePhaiNop.Clear();
            this.txtThueDaNop.Clear();
            this.txtThueTNDN.Clear();
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

        private int CheckNumber(TextBox textBox)
        {
            int result = 0;
            bool isNumber = int.TryParse(textBox.Text, out result);
            if (!isNumber || result < 0)
            {
                errorProvider.SetError(textBox, "Bạn phải nhập số điện có dạng số lớn hơn hoặc bằng 0");
                return -1;
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

        private void SelectRowByID(string hhdvID)
        {
            foreach (DataGridViewRow row in this.dgvHHDV.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(hhdvID))
                {
                    dgvHHDV.Rows[row.Index].Selected = true;
                }
            }
        }
    }
}
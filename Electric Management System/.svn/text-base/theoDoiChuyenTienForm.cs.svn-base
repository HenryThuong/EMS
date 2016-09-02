using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.Reports;

namespace Electric_Management_System
{
    public partial class theoDoiChuyenTienForm : Form
    {
        private enum ActionMode : int { Add = 1, Edit = 2 };

        private ActionMode actionMode = ActionMode.Add;

        Guid chuyenTienID;

        public theoDoiChuyenTienForm()
        {
            InitializeComponent();
        }

        private void theoDoiChuyenTienForm_Load(object sender, EventArgs e)
        {
            this.cboYear.Text = DateTime.Today.Year.ToString();
            this.tbl_TheoDoiChuyenTienTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiChuyenTien, int.Parse(cboYear.Text));
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearForm();
            this.tbl_TheoDoiChuyenTienTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiChuyenTien, int.Parse(cboYear.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal soDuThangTruoc = this.CheckMoney(txtSoDuThangTruoc);
            decimal tienDienNganHang = this.CheckMoney(txtTienDienNganHang);
            decimal nopMoi = this.CheckMoney(txtNopMoi);
            decimal tongCoTK = this.CheckMoney(txtTongCoTK);
            decimal traCtyDien = this.CheckMoney(txtTraCtyDien);
            decimal lePhiChuyenTien = this.CheckMoney(txtLePhiChuyenTien);
            decimal traSoTaiChinh = this.CheckMoney(txtTraSoTaiChinh);
            decimal conDu = this.CheckMoney(txtConDu);

            if (!this.HasError())
            {
                int result = 0;
                if (actionMode == ActionMode.Add)
                {
                    chuyenTienID = Guid.NewGuid();
                    result = this.tbl_TheoDoiChuyenTienTableAdapter.Insert(
                        chuyenTienID,
                        dtpNgayChuyenTien.Value,
                        soDuThangTruoc,
                        tienDienNganHang,
                        nopMoi,
                        tongCoTK,
                        traCtyDien,
                        lePhiChuyenTien,
                        traSoTaiChinh,
                        conDu,
                        true,
                        null);
                }
                else if (actionMode == ActionMode.Edit)
                {
                    result = this.tbl_TheoDoiChuyenTienTableAdapter.Update(
                        chuyenTienID,
                        dtpNgayChuyenTien.Value,
                        soDuThangTruoc,
                        tienDienNganHang,
                        nopMoi,
                        tongCoTK,
                        traCtyDien,
                        lePhiChuyenTien,
                        traSoTaiChinh,
                        conDu);
                }

                if (result > 0)
                {
                    this.ClearForm();
                    this.tbl_TheoDoiChuyenTienTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiChuyenTien, int.Parse(cboYear.Text));
                    this.SelectRowByID(chuyenTienID.ToString());
                    this.dgvTheoDoiChuyenTien.Enabled = true;
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
            this.dgvTheoDoiChuyenTien.Enabled = true;
            this.btnCancel.Visible = false;
            actionMode = ActionMode.Add;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            xemBaoCaoForm xemBaoCao = new xemBaoCaoForm();
            xemBaoCao.reportType = "theoDoiChuyenTien";
            xemBaoCao.DataSource = this.eMSDBDataSet.tbl_TheoDoiChuyenTien;
            xemBaoCao.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            TheoDoiChuyenTien chuyenTienReport = new TheoDoiChuyenTien();
            chuyenTienReport.SetDataSource(eMSDBDataSet);
            chuyenTienReport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            chuyenTienReport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            chuyenTienReport.PrintToPrinter(1, false, 1, 1);
            chuyenTienReport.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbl_TheoDoiChuyenTienTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiChuyenTien, int.Parse(cboYear.Text));
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTheoDoiChuyenTien.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvTheoDoiChuyenTien.SelectedRows[0].Cells[0].Value.ToString()))
            {
                dgvTheoDoiChuyenTien.Enabled = false;
                chuyenTienID = Guid.Parse(dgvTheoDoiChuyenTien.SelectedRows[0].Cells[0].Value.ToString());
                dtpNgayChuyenTien.Value = DateTime.Parse(dgvTheoDoiChuyenTien.SelectedRows[0].Cells[1].Value.ToString());
                txtSoDuThangTruoc.Text = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[2].Value.ToString();
                txtTienDienNganHang.Text = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[3].Value.ToString();
                txtNopMoi.Text = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[4].Value.ToString();
                txtTongCoTK.Text = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[5].Value.ToString();
                txtTraCtyDien.Text = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[6].Value.ToString();
                txtLePhiChuyenTien.Text = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[7].Value.ToString();
                txtTraSoTaiChinh.Text = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[8].Value.ToString();
                txtConDu.Text = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[9].Value.ToString();
                actionMode = ActionMode.Edit;
                btnCancel.Visible = true;
                dtpNgayChuyenTien.Focus();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTheoDoiChuyenTien.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvTheoDoiChuyenTien.SelectedRows[0].Cells[0].Value.ToString()))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa dòng này không?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.tbl_TheoDoiChuyenTienTableAdapter.Delete(
                        Guid.Parse(dgvTheoDoiChuyenTien.SelectedRows[0].Cells[0].Value.ToString())) > 0)
                    {
                        this.tbl_TheoDoiChuyenTienTableAdapter.Fill(this.eMSDBDataSet.tbl_TheoDoiChuyenTien, int.Parse(cboYear.Text));
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

        private void dgvTheoDoiChuyenTien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dgvTheoDoiChuyenTien.Rows[e.RowIndex].Selected = true;
                Rectangle r = dgvTheoDoiChuyenTien.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                this.contextMenuStrip.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            }
        }

        private void SelectRowByID(string chuyenTienID)
        {
            foreach (DataGridViewRow row in this.dgvTheoDoiChuyenTien.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(chuyenTienID))
                {
                    dgvTheoDoiChuyenTien.Rows[row.Index].Selected = true;
                }
            }
        }

        private void ClearForm()
        {
            this.dtpNgayChuyenTien.Value = DateTime.Today;
            this.txtSoDuThangTruoc.Clear();
            this.txtTienDienNganHang.Clear();
            this.txtNopMoi.Clear();
            this.txtTongCoTK.Clear();
            this.txtTraCtyDien.Clear();
            this.txtLePhiChuyenTien.Clear();
            this.txtTraSoTaiChinh.Clear();
            this.txtConDu.Clear();
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

        private bool HasError()
        {
            foreach (Control control in this.Controls)
            {
                if (errorProvider.GetError(control) != string.Empty)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

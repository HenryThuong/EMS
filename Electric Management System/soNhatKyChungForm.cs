using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.App_Data;
using Electric_Management_System.App_Code;
using Electric_Management_System.Reports;

namespace Electric_Management_System
{
    public partial class soNhatKyChungForm : Form
    {
        private enum ActionMode : int { Add = 1, Edit = 2 };

        private ActionMode actionMode = ActionMode.Add;

        Guid nhatKyID;

        SoCai soCaiReport;

        public soNhatKyChungForm()
        {
            InitializeComponent();
        }

        private void soNhatKyChungForm_Load(object sender, EventArgs e)
        {
            this.cboYear.Text = DateTime.Today.Year.ToString();
            this.cboYearSoCai.Text = DateTime.Today.Year.ToString();
            this.tbl_NhatKyChungTableAdapter.Fill(this.eMSDBDataSet.tbl_NhatKyChung, int.Parse(cboYear.Text));
            this.txtSTT.Text = DataTier.getLastestSTTNhatKyChung(cboYear.Text);
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearForm();
            this.tbl_NhatKyChungTableAdapter.Fill(this.eMSDBDataSet.tbl_NhatKyChung, int.Parse(cboYear.Text));
            this.txtSTT.Text = DataTier.getLastestSTTNhatKyChung(cboYear.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stt = this.CheckNumber(txtSTT);
            if (actionMode == ActionMode.Add)
            {
                if (DataTier.sttNhatKyChungExisted(this.cboYear.Text, stt.ToString()))
                {
                    MessageBox.Show(
                        "Số thứ tự này đã tồn tại trong cơ sở dữ liệu, mời bạn chọn số thứ tự khác.",
                        "Số thứ tự bị trùng",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtSTT.Focus();
                    return;
                }
            }
            string soChungTu = this.CheckRequiredField(txtSoChungTu);
            string description = this.CheckRequiredField(txtDescription);
            string soTKDUNo = this.CheckRequiredField(txtSoTKDUNo);
            decimal tienNo = this.CheckMoney(txtTienNo);

            string soTKDUThue = null;
            decimal tienThue = 0;
            if (cbxThueGTGT.Checked)
            {
                soTKDUThue = this.CheckRequiredField(txtSoTKDUGTGT);
                tienThue = this.CheckMoney(txtTienNoGTGT);
            }

            string soTKDUCo = this.CheckRequiredField(txtSoTKDUCo);
            decimal tienCo = this.CheckMoney(txtTienCo);

            if (!this.HasError())
            {
                int result = 0;
                if (actionMode == ActionMode.Add)
                {
                    result = this.tbl_NhatKyChungTableAdapter.Insert(
                        stt,
                        dtpNgayGhiSo.Value,
                        soChungTu,
                        dtpNgayChungTu.Value,
                        soTKDUNo,
                        tienNo,
                        soTKDUThue,
                        tienThue,
                        soTKDUCo,
                        tienCo,
                        description);
                }
                else if (actionMode == ActionMode.Edit)
                {
                    result = this.tbl_NhatKyChungTableAdapter.Update(
                        stt,
                        dtpNgayGhiSo.Value,
                        soChungTu,
                        dtpNgayChungTu.Value,
                        soTKDUNo,
                        tienNo,
                        soTKDUThue,
                        tienThue,
                        soTKDUCo,
                        tienCo,
                        description);
                }

                if (result > 0)
                {
                    this.ClearForm();
                    this.tbl_NhatKyChungTableAdapter.Fill(this.eMSDBDataSet.tbl_NhatKyChung, int.Parse(cboYear.Text));
                    this.SelectRowByID(nhatKyID.ToString());
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
            xemBaoCao.reportType = "nhatKyChung";
            xemBaoCao.DataSource = this.eMSDBDataSet.tbl_NhatKyChung;
            xemBaoCao.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SoCai soCaiReport = new SoCai();
            soCaiReport.SetDataSource(eMSDBDataSet);
            soCaiReport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            soCaiReport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            soCaiReport.PrintToPrinter(1, false, 1, 1);
            soCaiReport.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxThueGTGT_CheckedChanged(object sender, EventArgs e)
        {
            bool thueChecked = this.cbxThueGTGT.Checked;
            this.txtSoTKDUGTGT.Enabled = thueChecked;
            this.txtTienNoGTGT.Enabled = thueChecked;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbl_NhatKyChungTableAdapter.Fill(this.eMSDBDataSet.tbl_NhatKyChung, int.Parse(cboYear.Text));
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTheoDoiChuyenTien.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvTheoDoiChuyenTien.SelectedRows[0].Cells[0].Value.ToString()))
            {
                dgvTheoDoiChuyenTien.Enabled = false;
                string stt = dgvTheoDoiChuyenTien.SelectedRows[0].Cells[2].Value.ToString();

                EMSDBDataSet.tbl_NhatKyChungRow nhatKyNo = (from nkc in eMSDBDataSet.tbl_NhatKyChung
                                                            where nkc.STT == int.Parse(stt)
                                                            select nkc).FirstOrDefault();
                txtSTT.Text = stt;
                nhatKyID = nhatKyNo.NhatKyID;
                dtpNgayGhiSo.Value = nhatKyNo.NgayGhiSo;
                txtSoChungTu.Text = nhatKyNo.SoChungTu;
                dtpNgayChungTu.Value = nhatKyNo.ChungTuDate;
                txtDescription.Text = nhatKyNo.Description;
                txtSoTKDUNo.Text = nhatKyNo.SoTKDU;
                txtTienNo.Text = nhatKyNo.SoNoPhatSinh.ToString();

                bool hasThueGTGT = (from nkc in eMSDBDataSet.tbl_NhatKyChung
                                    where nkc.STT2 == int.Parse(stt)
                                    select nkc).Count() == 3;
                cbxThueGTGT.Checked = hasThueGTGT;
                txtSoTKDUGTGT.Enabled = hasThueGTGT;
                txtTienNoGTGT.Enabled = hasThueGTGT;
                txtSoTKDUGTGT.Clear();
                txtTienNoGTGT.Clear();
                if (hasThueGTGT)
                {
                    EMSDBDataSet.tbl_NhatKyChungRow nhatKyThue = (from nkc in eMSDBDataSet.tbl_NhatKyChung
                                                                  where nkc.STT2 == int.Parse(stt)
                                                                  orderby nkc.STT ascending, nkc.SoCoPhatSinh ascending
                                                                  select nkc).FirstOrDefault();
                    txtSoTKDUGTGT.Text = nhatKyThue.SoTKDU;
                    txtTienNoGTGT.Text = nhatKyThue.SoNoPhatSinh.ToString();
                }

                EMSDBDataSet.tbl_NhatKyChungRow nhatKyCo = (from nkc in eMSDBDataSet.tbl_NhatKyChung
                                                            where nkc.STT2 == int.Parse(stt)
                                                            orderby nkc.STT ascending, nkc.SoCoPhatSinh descending
                                                            select nkc).FirstOrDefault();
                txtSoTKDUCo.Text = nhatKyCo.SoTKDU;
                txtTienCo.Text = nhatKyCo.SoCoPhatSinh.ToString();


                actionMode = ActionMode.Edit;
                btnCancel.Visible = true;
                txtSTT.Focus();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTheoDoiChuyenTien.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvTheoDoiChuyenTien.SelectedRows[0].Cells[0].Value.ToString()))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa chứng từ này không?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.tbl_NhatKyChungTableAdapter.Delete(
                        int.Parse(dgvTheoDoiChuyenTien.SelectedRows[0].Cells[2].Value.ToString())) > 0)
                    {
                        this.tbl_NhatKyChungTableAdapter.Fill(this.eMSDBDataSet.tbl_NhatKyChung, int.Parse(cboYear.Text));
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

        private void tabNhatKyChung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabNhatKyChung.SelectedIndex == 1)
            {
                this.getTKSoCaiList();
            }else
            {
                if (soCaiReport != null)
                {
                    soCaiReport.Dispose();
                }
            }
        }

        private void btnViewSoCai_Click(object sender, EventArgs e)
        {
            DataTable nkcTable = this.eMSDBDataSet.tbl_NhatKyChung.Where(n => n.NgayGhiSo.Year == int.Parse(cboYearSoCai.Text) && n.SoTKDU == cboTKSoCai.Text).Select(n => n).CopyToDataTable();
            soCaiReport = new SoCai();
            soCaiReport.SetDataSource(nkcTable);
            crvReport.ReportSource = soCaiReport;
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
            this.txtSTT.Text = DataTier.getLastestSTTNhatKyChung(cboYear.Text);
            this.dtpNgayGhiSo.Value = DateTime.Today;
            this.txtSoChungTu.Clear();
            this.dtpNgayChungTu.Value = DateTime.Today;
            this.txtDescription.Clear();
            this.txtSoTKDUNo.Clear();
            this.txtTienNo.Clear();
            this.cbxThueGTGT.Checked = false;
            this.txtSoTKDUGTGT.Enabled = false;
            this.txtTienNoGTGT.Enabled = false;
            this.txtSoTKDUGTGT.Clear();
            this.txtTienNoGTGT.Clear();
            this.txtSoTKDUCo.Clear();
            this.txtTienCo.Clear();
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
            bool isMoney = int.TryParse(textBox.Text, out result);
            if (!isMoney || result < 0)
            {
                errorProvider.SetError(textBox, "Bạn phải nhập số lớn hơn hoặc bằng 0");
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

        private void getTKSoCaiList()
        {
            var tkSoCaiList = this.eMSDBDataSet.tbl_NhatKyChung.Where(n => n.STT != null && n.NgayGhiSo.Year == int.Parse(cboYearSoCai.Text)).Select(n => n.SoTKDU).ToList();
            if (tkSoCaiList.Count > 0)
            {
                this.cboTKSoCai.DataSource = tkSoCaiList;
                this.cboTKSoCai.SelectedIndex = 0;
            }
        }
    }
}

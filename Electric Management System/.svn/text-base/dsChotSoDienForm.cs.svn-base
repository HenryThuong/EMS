using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.App_Data;
using Electric_Management_System.App_Code;

namespace Electric_Management_System
{
    public partial class dsChotSoDienForm : Form
    {
        BindingSource bsCustomer = new BindingSource();

        private enum ActionMode : int { Add = 1, Edit = 2 };

        private ActionMode actionMode = ActionMode.Add;

        Guid chotSoID;

        public dsChotSoDienForm()
        {
            InitializeComponent();
        }

        private void ghiSoDienDSForm_Load(object sender, EventArgs e)
        {
            this.LoadStationList();
            this.LoadData();
        }

        private void cboTramDien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.LoadData();
            this.LoadCustomerList();
        }

        private void cboMaSoKH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMaSoKH.Text))
            {
                txtHoTen.Clear();
            }
        }

        private void btnNewLine_Click(object sender, EventArgs e)
        {
            this.tbl_DSChotSoTableAdapter.Insert(
                Guid.NewGuid(),
                null,
                Guid.Parse(cboTramDien.SelectedValue.ToString()),
                null,
                null);
            this.LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Guid customerID = Guid.Parse(this.CheckRequiredField(cboMaSoKH));
            string soHieuCongTo = this.CheckRequiredField(txtSoHieuCongTo);
            Guid stationID = Guid.Parse(this.CheckRequiredField(cboTramDien));
            int stt;

            if (!this.HasError())
            {
                int result = 0;
                if (actionMode == ActionMode.Add)
                {
                    stt = this.GetLastestSTT() + 1;
                    chotSoID = Guid.NewGuid();
                    result = this.tbl_DSChotSoTableAdapter.Insert(
                        chotSoID,
                        stt,
                        stationID,
                        customerID,
                        soHieuCongTo);
                }
                else if (actionMode == ActionMode.Edit)
                {
                    result = this.tbl_DSChotSoTableAdapter.Update(
                        chotSoID,
                        customerID,
                        soHieuCongTo);
                }

                if (result > 0)
                {
                    this.ClearForm();
                    this.LoadData();
                    this.SelectRowByID(chotSoID.ToString());
                    this.dgvDsChotSo.Enabled = true;
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
            this.dgvDsChotSo.Enabled = true;
            this.btnCancel.Visible = false;
            actionMode = ActionMode.Add;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDsChotSo.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvDsChotSo.SelectedRows[0].Cells[0].Value.ToString()))
            {
                dgvDsChotSo.Enabled = false;
                chotSoID = Guid.Parse(dgvDsChotSo.SelectedRows[0].Cells[0].Value.ToString());
                cboMaSoKH.SelectedValue = dgvDsChotSo.SelectedRows[0].Cells[4].Value.ToString();
                txtSoHieuCongTo.Text = dgvDsChotSo.SelectedRows[0].Cells[5].Value.ToString();
                actionMode = ActionMode.Edit;
                btnCancel.Visible = true;
                cboMaSoKH.Focus();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDsChotSo.SelectedRows.Count > 0 && !String.IsNullOrEmpty(dgvDsChotSo.SelectedRows[0].Cells[0].Value.ToString()))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa dòng này không?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.tbl_DSChotSoTableAdapter.Delete(Guid.Parse(dgvDsChotSo.SelectedRows[0].Cells[0].Value.ToString())) > 0)
                    {
                        this.LoadData();
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

        private void dgvDsChotSo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dgvDsChotSo.Rows[e.RowIndex].Selected = true;
                Rectangle r = dgvDsChotSo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                this.contextMenuStrip.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            }
        }

        private void LoadData()
        {
            this.tbl_DSChotSoTableAdapter.Fill(this.eMSDBDataSet.tbl_DSChotSo, Guid.Parse(cboTramDien.SelectedValue.ToString()));
        }

        private void LoadStationList()
        {
            cboTramDien.DataSource = DataTier.getStation();
            cboTramDien.DisplayMember = "Name";
            cboTramDien.ValueMember = "StationID";
            if (cboTramDien.Items.Count > 0)
            {
                cboTramDien.SelectedIndex = 0;
                LoadCustomerList();
            }
            else
            {
                cboMaSoKH.DataSource = null;
                cboMaSoKH.Items.Clear();
            }
        }

        private void LoadCustomerList()
        {
            bsCustomer.DataSource = DataTier.getCustomerList(cboTramDien.SelectedValue.ToString());
            cboMaSoKH.DataSource = bsCustomer;
            cboMaSoKH.DisplayMember = "CustomerNumber";
            cboMaSoKH.ValueMember = "CustomerID";
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bsCustomer, "Name");
        }

        private void SelectRowByID(string chotSoID)
        {
            foreach (DataGridViewRow row in this.dgvDsChotSo.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(chotSoID))
                {
                    dgvDsChotSo.Rows[row.Index].Selected = true;
                }
            }
        }

        private void ClearForm()
        {
            this.cboTramDien.SelectedIndex = 0;
            this.cboMaSoKH.SelectedIndex = 0;
            this.txtSoHieuCongTo.Clear();
        }

        private string CheckRequiredField(Control control)
        {
            string result = control.Text;
            if (control is ComboBox)
            {
                ComboBox cbo = (ComboBox)control;
                result = cbo.SelectedValue.ToString();
                if (string.IsNullOrEmpty(result))
                {
                    errorProvider.SetError(control, "Bạn không thể bỏ trống trường này");
                    return null;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(result))
                {
                    errorProvider.SetError(control, "Bạn không thể bỏ trống trường này");
                    return null;
                }
            }
            errorProvider.SetError(control, string.Empty);
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

        private int GetLastestSTT()
        {
            int rowCount = dgvDsChotSo.RowCount;

            if (rowCount > 0)
            {
                return int.Parse(dgvDsChotSo.Rows[rowCount - 1].Cells[1].Value.ToString());
            }

            return 1;
        }
    }
}

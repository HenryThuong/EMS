using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.App_Code;

namespace Electric_Management_System
{
    public partial class suaTenTramForm : Form
    {
        public string tenCu;
        public string tramID;

        public suaTenTramForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suaTenTramForm_Load(object sender, EventArgs e)
        {
            tenCuTextBox.Text = tenCu;
            tenMoiTextBox.Focus();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (tenMoiTextBox.Text != string.Empty)
            {
                try
                {
                    Station tram = new Station(tramID, tenMoiTextBox.Text);
                    bool tenTramExisted = tram.CheckName();
                    if (tenTramExisted)
                    {
                        //MessageBox.Show("Tên trạm này đã tồn tại, bạn hãy chọn tên khác!", "Sửa tên trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        errorProvider.SetError(tenMoiTextBox, "Tên trạm này đã tồn tại, bạn hãy chọn tên khác!");
                    }
                    else
                    {
                        bool edited = tram.editName();
                        if (edited)
                        {
                            //MessageBox.Show("\"" + tramComboBox.Text + "\" đã được sửa thành \"" + tram.TenTram + "\"", "Sửa tên trạm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        else
                        {
                            //MessageBox.Show("Dữ liệu nhập vào không đúng!", "Sửa tên trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            errorProvider.SetError(tenMoiTextBox, "Dữ liệu nhập vào không đúng!");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi không xác định, nếu lỗi này lặp lại, bạn hãy thử khởi động lại chương trình!", "Sửa tên trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                //MessageBox.Show("Tên trạm không thể để trống, mời bạn nhập lại!", "Sửa tên trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                errorProvider.SetError(tenMoiTextBox, "Tên trạm không thể để trống, mời bạn nhập lại!");
            }
        }

        private void tramComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void tenTramTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}

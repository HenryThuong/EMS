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
    public partial class themTramForm : Form
    {
        public themTramForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (tenTramTextBox.Text == string.Empty)
            {
                //MessageBox.Show("Tên trạm không thể để trống, mời bạn nhập lại!", "Thêm trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                errorProvider.SetError(tenTramTextBox, "Tên trạm không thể để trống, mời bạn nhập lại!");
            }
            else if (soTramTextBox.Text == string.Empty)
            {
                //MessageBox.Show("Tên trạm không thể để trống, mời bạn nhập lại!", "Thêm trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                errorProvider.SetError(soTramTextBox, "Số trạm không thể để trống, mời bạn nhập lại!");
            }
            else
            {
                try
                {
                    Station tram = new Station(tenTramTextBox.Text, int.Parse(soTramTextBox.Text));
                    bool tenTramExisted = tram.CheckName();
                    bool soTramExisted = tram.CheckNumber();
                    if (tenTramExisted)
                    {
                        //MessageBox.Show("Tên trạm này đã tồn tại, bạn hãy chọn tên khác!", "Thêm trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        errorProvider.SetError(tenTramTextBox, "Tên trạm này đã tồn tại, bạn hãy chọn tên khác!");
                    }
                    else if (soTramExisted)
                    {
                        //MessageBox.Show("Tên trạm này đã tồn tại, bạn hãy chọn tên khác!", "Thêm trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        errorProvider.SetError(soTramTextBox, "Số trạm này đã tồn tại, bạn hãy chọn số khác!");
                    }
                    else
                    {
                        bool added = tram.add();
                        if (added)
                        {
                            //MessageBox.Show("Trạm mới \"" + tram.TenTram + "\" đã được tạo mới thành công!", "Thêm trạm mới thành công", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        else
                        {
                            //MessageBox.Show("Dữ liệu nhập vào không đúng!", "Thêm trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            errorProvider.SetError(tenTramTextBox, "Dữ liệu nhập vào không đúng!");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu nhập vào không đúng! Mời bạn nhập lại", "Thêm trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
                
        }
    }
}

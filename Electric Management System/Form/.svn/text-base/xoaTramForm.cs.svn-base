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
    public partial class xoaTramForm : Form
    {
        public xoaTramForm()
        {
            InitializeComponent();
        }

        private void xoaTramForm_Load(object sender, EventArgs e)
        {
            tramComboBox.DataSource = DataTier.getStation();
            tramComboBox.DisplayMember = "tenTram";
            tramComboBox.ValueMember = "tramID";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tramComboBox.Items.Count <= 0)
            {
                //MessageBox.Show("Hiện tại chưa có trạm nào trong cơ sở dữ liệu, bạn hãy thêm trạm trước!", "Sửa tên trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                errorProvider.SetError(tramComboBox, "Hiện tại chưa có trạm nào trong cơ sở dữ liệu!");
            }
            else
            {
                try
                {
                    string tenTram = tramComboBox.Text;
                    DialogResult messageResult = new DialogResult();
                    messageResult = MessageBox.Show("Bạn có thật sự muốn xóa \"" + tenTram + "\" khỏi danh sách không?", "Xóa trạm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (messageResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        Station tram = new Station(tramComboBox.SelectedValue.ToString());
                        bool deleted = tram.delete();
                        if (deleted)
                        {
                            //MessageBox.Show("\"" + tenTram + "\" đã được xóa khỏi cơ sở dữ liệu!", "Xóa trạm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        else
                        {
                            //MessageBox.Show("Dữ liệu nhập vào không đúng!", "Xóa trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            errorProvider.SetError(tramComboBox, "Dữ liệu nhập vào không đúng!");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi không xác định, nếu lỗi này lặp lại, bạn hãy thử khởi động lại chương trình!", "Xóa trạm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}

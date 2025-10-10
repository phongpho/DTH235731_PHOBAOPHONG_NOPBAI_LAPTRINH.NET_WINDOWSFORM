using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_Bai_3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                lstBox.Items.Add(txtInput.Text);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên trước khi thêm!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstBox.SelectedItem != null)
            {
                lstBox.Items.Remove(lstBox.SelectedItem);
                txtOutput.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tên cần xóa!", "Thông báo");
            }
        }

        private void btnChonMauChu_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutput.ForeColor = colorDialog1.Color;
            }
        }

        private void btnChonMauNen_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutput.BackColor = colorDialog1.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Font = fontDialog1.Font;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox.SelectedItem != null)
            {
                txtOutput.Text = lstBox.SelectedItem.ToString();
            }
        }
    }
}

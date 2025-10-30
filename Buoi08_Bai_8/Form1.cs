using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi08_Bai_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb1.Checked = true;
            rb1_CheckedChanged(sender, e);
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                // Xóa dữ liệu
                txtCanh.Clear();
                txtDai.Clear();
                txtRong.Clear();
                txtBankinh.Clear();

                // Bật/Tắt các TextBox
                txtCanh.Enabled = true;
                txtDai.Enabled = false;
                txtRong.Enabled = false;
                txtBankinh.Enabled = false;

                // Đặt con trỏ
                txtCanh.Focus();
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                // Xóa dữ liệu
                txtCanh.Clear();
                txtDai.Clear();
                txtRong.Clear();
                txtBankinh.Clear();

                // Bật/Tắt các TextBox
                txtCanh.Enabled = false;
                txtDai.Enabled = true;
                txtRong.Enabled = true;
                txtBankinh.Enabled = false;

                // Đặt con trỏ
                txtDai.Focus();
            }
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                // Xóa dữ liệu
                txtCanh.Clear();
                txtDai.Clear();
                txtRong.Clear();
                txtBankinh.Clear();

                // Bật/Tắt các TextBox
                txtCanh.Enabled = false;
                txtDai.Enabled = false;
                txtRong.Enabled = false;
                txtBankinh.Enabled = true;

                // Đặt con trỏ
                txtBankinh.Focus();
            }
        }

        private void ThucHienTinhToan()
        {
            // Trường hợp 1: Hình Vuông
            if (rb1.Checked)
            {
                // Kiểm tra dữ liệu (Validation)
                if (string.IsNullOrWhiteSpace(txtCanh.Text))
                {
                    MessageBox.Show("Hãy nhập vào chiều dài cạnh", "Thông báo");
                    txtCanh.Focus();
                    return; // Dừng lại
                }

                double canh;
                if (!double.TryParse(txtCanh.Text, out canh))
                {
                    MessageBox.Show("Cạnh phải là một con số!", "Lỗi");
                    txtCanh.Focus();
                    return;
                }

                // Mở Form2 và truyền dữ liệu
                Form2 f2 = new Form2();
                f2.canha = canh; // Gán giá trị 'canh' cho biến public 'canha' của Form2
                f2.ShowDialog(); // Hiển thị Form2
            }

            // Trường hợp 2: Hình Chữ Nhật
            else if (rb2.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDai.Text) || string.IsNullOrWhiteSpace(txtRong.Text))
                {
                    MessageBox.Show("Hãy nhập vào chiều dài và chiều rộng", "Thông báo");
                    txtDai.Focus();
                    return;
                }

                double dai, rong;
                if (!double.TryParse(txtDai.Text, out dai) || !double.TryParse(txtRong.Text, out rong))
                {
                    MessageBox.Show("Chiều dài và rộng phải là con số!", "Lỗi");
                    txtDai.Focus();
                    return;
                }

                // Mở Form3 và truyền dữ liệu
                Form3 f3 = new Form3();
                f3.dai = dai;
                f3.rong = rong;
                f3.ShowDialog();
            }

            // Trường hợp 3: Hình Tròn
            else if (rb3.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtBankinh.Text))
                {
                    MessageBox.Show("Hãy nhập vào bán kính", "Thông báo");
                    txtBankinh.Focus();
                    return;
                }

                double bankinh;
                if (!double.TryParse(txtBankinh.Text, out bankinh))
                {
                    MessageBox.Show("Bán kính phải là một con số!", "Lỗi");
                    txtBankinh.Focus();
                    return;
                }

                // Mở Form4 và truyền dữ liệu
                Form4 f4 = new Form4();
                f4.bankinh = bankinh;
                f4.ShowDialog();
            }
        }

        private void ThoatChuongTrinh()
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có thật sự muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            // Nếu người dùng chọn OK
            if (result == DialogResult.OK)
            {
                this.Close(); // Đóng Form1, chương trình sẽ kết thúc
            }
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            ThucHienTinhToan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThoatChuongTrinh();
        }
    }
}

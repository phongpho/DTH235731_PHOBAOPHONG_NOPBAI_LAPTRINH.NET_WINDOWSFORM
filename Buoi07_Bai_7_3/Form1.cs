using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_Bai_7_3
{
    public partial class Form1 : Form
    {
        List<string> danhSachAnh = new List<string>();
        int chiSoHienTai = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn các hình ảnh";
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                danhSachAnh.Clear();
                danhSachAnh.AddRange(dlg.FileNames);
                chiSoHienTai = 0;
                HienThiAnh();
            }
        }
        private void HienThiAnh()
        {
            if (danhSachAnh.Count == 0) return;

            try
            {
                picHinh.Image = Image.FromFile(danhSachAnh[chiSoHienTai]);
            }
            catch
            {
                MessageBox.Show("Không thể mở hình này!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {

            if (danhSachAnh.Count == 0) return;

            chiSoHienTai--;
            if (chiSoHienTai < 0)
                chiSoHienTai = danhSachAnh.Count - 1;

            HienThiAnh();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (danhSachAnh.Count == 0) return;

            chiSoHienTai++;
            if (chiSoHienTai >= danhSachAnh.Count)
                chiSoHienTai = 0;

            HienThiAnh();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (danhSachAnh.Count == 0)
            {
                MessageBox.Show("Chưa có hình để trình chiếu!", "Thông báo");
                return;
            }

            timer1.Enabled = !timer1.Enabled;
            btnBatDau.Text = timer1.Enabled ? "Dừng" : "Bắt đầu";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnSau_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

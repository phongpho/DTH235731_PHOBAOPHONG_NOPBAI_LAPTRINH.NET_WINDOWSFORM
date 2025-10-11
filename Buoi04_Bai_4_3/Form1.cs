using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_Bai_4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a;
        int n;

        public void TaoMang(int n)
        {
            a = new int[n];
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }
        }
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        private void btnTaomang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "Thông báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    MessageBox.Show("Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong");
                    btnSum.Enabled = true;
                    btnMax.Enabled = true;

                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Các phần tử của mảng: " + InMang() + "\n\nBạn có muốn tính tổng mảng không?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Form2 f2 = new Form2(a);
                f2.ShowDialog();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Các phần tử của mảng: " + InMang() + "\n\nBạn có muốn tìm phần tử lớn nhất trong mảng không?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Form3 f3 = new Form3(a);
                f3.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

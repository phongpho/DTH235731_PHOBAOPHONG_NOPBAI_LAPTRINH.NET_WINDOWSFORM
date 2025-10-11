using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        // Hàm rút gọn phân số
        private void RutGon(ref int tu, ref int mau)
        {
            if (tu == 0)
            {
                mau = 1;   // 0/x = 0/1
                return;
            }

            int ucln = UCLN(tu, mau);
            tu /= ucln;
            mau /= ucln;

            if (mau < 0) // Đưa dấu âm lên tử số
            {
                tu = -tu;
                mau = -mau;
            }
        }

        // Lấy dữ liệu nhập từ textbox
        private void LayDuLieu(out int tu1, out int mau1, out int tu2, out int mau2)
        {
            tu1 = int.Parse(txtTu1.Text);
            mau1 = int.Parse(txtMau1.Text);
            tu2 = int.Parse(txtTu2.Text);
            mau2 = int.Parse(txtMau2.Text);
        }

        // Hiển thị kết quả ra textbox
        private void HienThiKetQua(int tu, int mau)
        {
            RutGon(ref tu, ref mau);
            txtTukq.Text = tu.ToString();
            txtMaukq.Text = mau.ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LayDuLieu(out int tu1, out int mau1, out int tu2, out int mau2);
            int tu = tu1 * mau2 - tu2 * mau1;
            int mau = mau1 * mau2;
            HienThiKetQua(tu, mau);
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            LayDuLieu(out int tu1, out int mau1, out int tu2, out int mau2);
            int tu = tu1 * mau2 + tu2 * mau1;
            int mau = mau1 * mau2;
            HienThiKetQua(tu, mau);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            LayDuLieu(out int tu1, out int mau1, out int tu2, out int mau2);
            int tu = tu1 * tu2;
            int mau = mau1 * mau2;
            HienThiKetQua(tu, mau);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            LayDuLieu(out int tu1, out int mau1, out int tu2, out int mau2);
            int tu = tu1 * mau2;
            int mau = mau1 * tu2;
            HienThiKetQua(tu, mau);
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTu1.Clear();
            txtMau1.Clear();
            txtTu2.Clear();
            txtMau2.Clear();
            txtTukq.Clear();
            txtMaukq.Clear();
            txtTu1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

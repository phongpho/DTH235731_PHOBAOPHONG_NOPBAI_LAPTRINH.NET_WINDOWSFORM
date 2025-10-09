using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi02_Bai_2_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                int tong = a + b;
                txtKq.Text = tong.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                int thuong = a / b;
                txtKq.Text = thuong.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                int tich = a * b;
                txtKq.Text = tich.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                int hieu = a - b;
                txtKq.Text = hieu.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi02_Bai_2_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                int chuVi = 2 * (a + b);
                txtKq.Text = chuVi.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                double duongCheo = Math.Sqrt(a * a + b * b);
                txtKq.Text = duongCheo.ToString("0.##"); // hiện 2 số lẻ
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                int dienTich = a * b;
                txtKq.Text = dienTich.ToString();
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

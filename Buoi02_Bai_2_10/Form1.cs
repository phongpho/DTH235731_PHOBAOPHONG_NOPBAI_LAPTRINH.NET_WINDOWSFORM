using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi02_Bai_2_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int chuVi = 2 * (a + b);
            MessageBox.Show("Chu vi: " + chuVi.ToString());
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
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            double duongCheo = Math.Sqrt(a * a + b * b);
            MessageBox.Show("Chu vi: " + duongCheo.ToString());
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int dienTich = a * b;
            MessageBox.Show("Chu vi: " + dienTich.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

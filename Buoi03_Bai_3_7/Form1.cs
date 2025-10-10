using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_Bai_3_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKQ.Text = (a + b).ToString();
        }

        private void hieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKQ.Text = (a - b).ToString();
        }

        private void tichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKQ.Text = (a * b).ToString();
        }

        private void thuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            if (b != 0)
                txtKQ.Text = (a / b).ToString();
            else
                MessageBox.Show("Không thể chia cho 0!", "Lỗi");
        }
    }
}

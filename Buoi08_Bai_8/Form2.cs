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
    public partial class Form2 : Form
    {
        public double canha;
        public Form2()
        {
            InitializeComponent();
        }
        public double TinhDienTich() { return canha * canha; }
        public double TinhChuVi() { return canha * 4; }
        private void Form2_Load(object sender, EventArgs e)
        {
            txtDientich.Text = TinhDienTich().ToString();
            txtChuvi.Text = TinhChuVi().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form4 : Form
    {
        public double bankinh;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtDientich.Text = TinhDienTich().ToString("F2"); // F2 = làm tròn 2 số lẻ
            txtChuvi.Text = TinhChuVi().ToString("F2");
        }
        public double TinhDienTich() { return Math.PI * bankinh * bankinh; }
        public double TinhChuVi() { return 2 * Math.PI * bankinh; }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

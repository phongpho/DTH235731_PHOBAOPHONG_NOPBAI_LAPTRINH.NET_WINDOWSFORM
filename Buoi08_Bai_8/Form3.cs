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
    public partial class Form3 : Form
    {
        public double dai;
        public double rong;
        public Form3()
        {
            InitializeComponent();
        }
        public double TinhDienTich() { return dai * rong; }
        public double TinhChuVi() { return (dai + rong) * 2; }
        private void Form3_Load(object sender, EventArgs e)
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

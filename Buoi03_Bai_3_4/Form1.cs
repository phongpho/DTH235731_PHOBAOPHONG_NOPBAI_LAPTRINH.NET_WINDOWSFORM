using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_Bai_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtKq.Clear();
            this.txtHoTen.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoTen.Focus();
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rdoChuthuong.Checked == true)
                {
                    this.txtKq.Text = hoten.ToLower();
                }
                if (this.rdoChuhoa.Checked == true)
                {
                    this.txtKq.Text = hoten.ToUpper();
                }
            }
        }
    }
}

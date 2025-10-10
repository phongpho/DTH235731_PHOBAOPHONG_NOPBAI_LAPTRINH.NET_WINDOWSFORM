using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_Bai_3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int TimMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public string TimUocChung(int a, int b)
        {
            int max = TimMax(a, b);
            string chuoi = "";
            for (int i = 1; i <= max; i++)
                if ((a % i == 0) && (b % i == 0))
                    chuoi += i.ToString() + ", ";
            return chuoi.TrimEnd(',', ' ');
        }
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(this.txtN.Text);
            b = int.Parse(this.txtM.Text);
            if (this.rdo1.Checked == true)
                this.txtKq.Text = TimUocChung(a, b);
            if (this.rdo2.Checked == true)
                this.txtKq.Text = timUCLN(a, b).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtKq.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}

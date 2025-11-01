using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi09_Bai_9
{
    public partial class Form2 : Form
    {
        public int N;
        public Form2()
        {
            InitializeComponent();
        }

        private bool KiemTraSoHoanHao(int n)
        {
            if (n <= 1) return false;

            int tongUoc = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tongUoc += i; 
                }
            }

            return (tongUoc == n);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (KiemTraSoHoanHao(N))
            {
                lblKetQua.Text = $"{N} là số hoàn hảo";
            }
            else
            {
                lblKetQua.Text = $"{N} không phải là số hoàn hảo";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

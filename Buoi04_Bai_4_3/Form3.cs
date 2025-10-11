using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_Bai_4_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private int[] c;
        public Form3(int[] mang)
        {
            InitializeComponent();
            c = new int[mang.Length];
            Array.Copy(mang, c, mang.Length);
        }
        private int timMax(int[] c)
        {
            int max = c[0];
            foreach (int num in c)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        private void btnCancelf3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int max = timMax(c);
            lbF3.Text = "Phần tử lớn nhất trong mảng: " + max.ToString();
        }
    }
}

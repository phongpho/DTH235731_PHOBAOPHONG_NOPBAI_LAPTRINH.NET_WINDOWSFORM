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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int[] b;
        public Form2(int[] mang)
        {
            InitializeComponent();
            b = new int[mang.Length];
            Array.Copy(mang, b, mang.Length);
        }
        private int TinhTongMang(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int tong = TinhTongMang(b);
            lbF2.Text = "Tổng các phần tử trong mảng: " + tong.ToString();
        }
    }
}

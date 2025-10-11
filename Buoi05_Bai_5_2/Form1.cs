using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool LaSoHoanHao(int n)
        {
            if (n < 1) return false;
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum == n;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(txtNhap.Text, out int n))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNhap.Clear();
                    return;
                }

                if (LaSoHoanHao(n))
                    MessageBox.Show($"{n} là số hoàn hảo.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"{n} không phải là số hoàn hảo.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

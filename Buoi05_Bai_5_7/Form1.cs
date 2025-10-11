using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5_7
{
    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            try
            {
                arr = txtInput.Text
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                txtOutput.Text = string.Join(" ", arr);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập mảng số nguyên cách nhau bởi dấu cách hoặc dấu phẩy!");
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            txtTongMang.Text = arr.Sum().ToString();
            txtTongChan.Text = arr.Where(x => x % 2 == 0).Sum().ToString();
            txtTongLe.Text = arr.Where(x => x % 2 != 0).Sum().ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            txtMax.Text = arr.Max().ToString();
            txtMin.Text = arr.Min().ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);

            if (rdoTang.Checked)
                txtOutput.Text = string.Join(" ", arr);
            else if (rdoGiam.Checked)
            {
                Array.Reverse(arr);
                txtOutput.Text = string.Join(" ", arr);
            }
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            try
            {
                int index = int.Parse(txtViTri.Text);
                int value = int.Parse(txtSoThayThe.Text);

                if (index >= 0 && index < arr.Length)
                {
                    arr[index] = value;
                    txtOutput.Text = string.Join(" ", arr);
                }
                else
                {
                    MessageBox.Show("Vị trí không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai vị trí hoặc giá trị thay thế!");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();

            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtMax.Clear();
            txtMin.Clear();

            txtViTri.Clear();
            txtSoThayThe.Clear();

            arr = null;
        }
    }
}

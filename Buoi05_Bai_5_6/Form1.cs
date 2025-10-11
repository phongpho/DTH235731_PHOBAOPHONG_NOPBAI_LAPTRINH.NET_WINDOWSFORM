using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5_6
{
    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }
        private bool LayMangTuTextBox()
        {
            try
            {
                arr = txtInput.Text
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (arr.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập ít nhất một số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ! (Chỉ nhập số, cách nhau bằng dấu cách)",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdoMin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMin.Checked)
            {
                if (!LayMangTuTextBox()) return;
                txtOutput.Text = "Giá trị nhỏ nhất = " + arr.Min();
            }
        }

        private void rdoEvenNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEvenNumbers.Checked)
            {
                if (!LayMangTuTextBox()) return;
                var evens = arr.Where(x => x % 2 == 0);
                txtOutput.Text = "Các số chẵn: " + string.Join(" ", evens);
            }
        }

        private void rdoLastEven_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLastEven.Checked)
            {
                if (!LayMangTuTextBox()) return;
                int lastEven = arr.LastOrDefault(x => x % 2 == 0);
                txtOutput.Text = "Số chẵn cuối cùng = " + lastEven;
            }
        }

        private void rdoSumOdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSumOdd.Checked)
            {
                if (!LayMangTuTextBox()) return;
                int sumOdd = arr.Where(x => x % 2 != 0).Sum();
                txtOutput.Text = "Tổng các số lẻ = " + sumOdd;
            }
        }

        private void rdoSumEven_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSumEven.Checked)
            {
                if (!LayMangTuTextBox()) return;
                int sumEven = arr.Where(x => x % 2 == 0).Sum();
                txtOutput.Text = "Tổng các số chẵn = " + sumEven;
            }
        }

        private void rdoCountEven_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCountEven.Checked)
            {
                if (!LayMangTuTextBox()) return;
                int countEven = arr.Count(x => x % 2 == 0);
                txtOutput.Text = "Số lượng số chẵn = " + countEven;
            }
        }

        private void rdoCountOdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCountOdd.Checked)
            {
                if (!LayMangTuTextBox()) return;
                int countOdd = arr.Count(x => x % 2 != 0);
                txtOutput.Text = "Số lượng số lẻ = " + countOdd;
            }
        }
    }
}

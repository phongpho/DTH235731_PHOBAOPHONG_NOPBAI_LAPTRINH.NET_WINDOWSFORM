using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arr;
        Random rand = new Random();
        private void btnRandomArray_Click(object sender, EventArgs e)
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 100);
            txtInput.Text = string.Join(" ", arr);
        }

        private void btnSumArray_Click(object sender, EventArgs e)
        {
            int sum = arr.Sum();
            txtOutput.Text = "Tổng mảng = " + sum;
        }

        private void btnOddNumber_Click(object sender, EventArgs e)
        {
            var odds = arr.Where(x => x % 2 != 0);
            txtOutput.Text = "Số lẻ: " + string.Join(" ", odds);
        }

        private void btnSumOddNumber_Click(object sender, EventArgs e)
        {
            int sumOdd = arr.Where(x => x % 2 != 0).Sum();
            txtOutput.Text = "Tổng số lẻ = " + sumOdd;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = arr.Min();
            txtOutput.Text = "Min = " + min;
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            arr = arr.Select(x => x + 2).ToArray();
            txtInput.Text = string.Join(" ", arr);
            txtOutput.Text = "Đã tăng mỗi phần tử lên 2";
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            txtInput.Text = string.Join(" ", arr);
            txtOutput.Text = "Mảng đã sắp xếp tăng dần";
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            txtInput.Text = string.Join(" ", arr);
            txtOutput.Text = "Mảng đã sắp xếp giảm dần";
        }
    }
}

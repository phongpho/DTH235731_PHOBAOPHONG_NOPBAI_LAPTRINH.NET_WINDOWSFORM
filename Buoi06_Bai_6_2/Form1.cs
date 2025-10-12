using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_Bai_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdoLopA.Checked)
                lstLopA.Items.Add(ten);
            else if (rdoLopB.Checked)
                lstLopB.Items.Add(ten);
            else
            {
                MessageBox.Show("Vui lòng chọn lớp (A hoặc B)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtInput.Clear();
            txtInput.Focus();
            rdoLopA.Checked = false;
            rdoLopB.Checked = false;
        }

        private void btnSumSV_Click(object sender, EventArgs e)
        {
            int tong = lstLopA.Items.Count + lstLopB.Items.Count;
            MessageBox.Show(
                $"Tổng số sinh viên: {tong}\nLớp A: {lstLopA.Items.Count}\nLớp B: {lstLopB.Items.Count}",
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnSangB_Click(object sender, EventArgs e)
        {
            var selected = lstLopA.SelectedItems.Cast<string>().ToList();
            foreach (var sv in selected)
            {
                lstLopB.Items.Add(sv);
            }
            foreach (var sv in selected)
            {
                lstLopA.Items.Remove(sv);
            }
        }

        private void btnSangA_Click(object sender, EventArgs e)
        {
            var selected = lstLopB.SelectedItems.Cast<string>().ToList();
            foreach (var sv in selected)
            {
                lstLopA.Items.Add(sv);
            }
            foreach (var sv in selected)
            {
                lstLopB.Items.Remove(sv);
            }
        }

        private void btnAllSangB_Click(object sender, EventArgs e)
        {
            foreach (var sv in lstLopA.Items.Cast<string>().ToList())
            {
                lstLopB.Items.Add(sv);
            }
            lstLopA.Items.Clear();
        }

        private void btnAllSangA_Click(object sender, EventArgs e)
        {
            foreach (var sv in lstLopB.Items.Cast<string>().ToList())
            {
                lstLopA.Items.Add(sv);
            }
            lstLopB.Items.Clear();
        }
    }
}

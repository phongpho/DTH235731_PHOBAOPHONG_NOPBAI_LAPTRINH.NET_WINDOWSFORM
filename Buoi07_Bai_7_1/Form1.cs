using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_Bai_7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                treeView1.Nodes.Add(c.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();

            if (string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ và Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char firstChar = char.ToUpper(ten[0]);


            TreeNode node = null;
            foreach (TreeNode n in treeView1.Nodes)
            {
                if (n.Text == firstChar.ToString())
                {
                    node = n;
                    break;
                }
            }

            if (node != null)
            {
                string hoTen = $"{ten}, {ho}";
                node.Nodes.Add(hoTen);
                node.Expand();
            }

            txtHo.Clear();
            txtTen.Clear();
            txtTen.Focus();
        }
    }
}

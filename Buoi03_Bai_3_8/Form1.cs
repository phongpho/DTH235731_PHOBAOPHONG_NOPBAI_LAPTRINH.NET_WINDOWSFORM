using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_Bai_3_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            if (cboHoTen.SelectedItem != null)
            {
                string ten = cboHoTen.SelectedItem.ToString();
                MessageBox.Show("Xin chào " + ten + " chúc ông một ngày vui!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn họ tên trước!", "Thông báo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboHoTen.Items.Add("Phó Bảo Phong");
            cboHoTen.Items.Add("Tống Nhựt Nam");
            cboHoTen.Items.Add("Huỳnh Minh Thuận");
            cboHoTen.Items.Add("Tèo");
            cboHoTen.SelectedIndex = 0;
        }
    }
}

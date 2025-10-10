using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_Bai_3_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txtKq.Text = "Bạn chọn web ";
            this.txtKq.Text += this.cboWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cboWeb.SelectedItem = "VNExpress"; this.txtKq.Clear();
        }
    }
}

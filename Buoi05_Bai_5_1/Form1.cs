using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool KiemTraSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private string LietKeSoNguyenToNhoHon(int n)
        {
            string kq = "";
            for (int i = 2; i < n; i++)
                if (KiemTraSNT(i))
                    kq += i.ToString() + " ";
            return kq.Trim();
        }
        private void txtSNT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtSNT.Clear();
            this.txtNhap.Clear();
            this.txtLessSNT.Clear();

            this.txtNhap.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtNhap.Text, out n))
            {
                txtSNT.Text = "Vui lòng nhập số nguyên hợp lệ";
                txtLessSNT.Clear();
                return;
            }

            if (KiemTraSNT(n))
                txtSNT.Text = $"{n} là số nguyên tố";
            else
                txtSNT.Text = $"{n} không phải là số nguyên tố";

            txtLessSNT.Text = LietKeSoNguyenToNhoHon(n);
        }
    }
}

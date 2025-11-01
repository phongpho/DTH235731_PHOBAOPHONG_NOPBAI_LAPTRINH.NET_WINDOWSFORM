using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi09_Bai_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLamLai.Enabled = false;
        }

        private void MoFormKiemTra()
        {
            int n;
            if (!int.TryParse(txtN.Text, out n))
            {
                MessageBox.Show("Vui lòng nhập số N hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }


            Form2 f2 = new Form2();
            f2.N = n; 
            f2.ShowDialog(); 

            btnLamLai.Enabled = true;
        }

        private void MoFormTaoMang()
        {
            int n;
            if (!int.TryParse(txtN.Text, out n))
            {
                MessageBox.Show("Vui lòng nhập số N hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }
            if (n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số N > 0 để tạo mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }

            Form3 f3 = new Form3();
            f3.N = n; // Gán giá trị 'n' cho biến public 'N' của Form3
            f3.ShowDialog(); // Hiển thị Form3

            // Sau khi Form3 đóng, bật nút Làm lại
            btnLamLai.Enabled = true;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            MoFormKiemTra();
        }

        private void menuKiemTra_Click(object sender, EventArgs e)
        {
            MoFormKiemTra();
        }

        private void menuTaoMang_Click(object sender, EventArgs e)
        {
            MoFormTaoMang();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            MoFormTaoMang();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

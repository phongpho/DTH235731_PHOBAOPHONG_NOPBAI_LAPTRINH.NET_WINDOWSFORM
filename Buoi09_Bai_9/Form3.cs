using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Buoi09_Bai_9
{
    public partial class Form3 : Form
    {
        public int N;
        private Random rand = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int[] mang = new int[N];

            // Dùng StringBuilder để nối chuỗi hiệu quả
            StringBuilder sbMang = new StringBuilder();
            StringBuilder sbSoChan = new StringBuilder();

            // Phát sinh ngẫu nhiên
            for (int i = 0; i < N; i++)
            {
                // giá trị các phần tử của mảng được phát sinh ngẫu nhiên trong khoảng từ N đến N+12.
                // (Hàm Next có tham số max ĐỘC QUYỀN (exclusive), nên N+12 phải là N+13)
                int soNgauNhien = rand.Next(N, N + 13);

                mang[i] = soNgauNhien;

                // Thêm vào chuỗi "Các phần tử"
                sbMang.Append(soNgauNhien + " ");

                // Kiểm tra nếu là số chẵn
                if (soNgauNhien % 2 == 0)
                {
                    // Hiển thị các số chẵn của mảng vừa tạo
                    sbSoChan.Append(soNgauNhien + " ");
                }
            }

            // Hiển thị kết quả lên TextBox
            // Dùng Trim() để xóa dấu cách thừa ở cuối
            txtMang.Text = sbMang.ToString().Trim();
            txtSoChan.Text = sbSoChan.ToString().Trim();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

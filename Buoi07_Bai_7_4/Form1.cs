using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_Bai_7_4
{
    public partial class Form1 : Form
    {
        private List<Label> listGhe = new List<Label>();

        // Định nghĩa các hằng số cho dễ quản lý
        const int GIA_VE = 100000;
        const int TONG_SO_GHE = 30;
        const int SO_GHE_MOT_HANG = 9; // Số ghế trên 1 hàng (như trong hình)

        // Màu sắc
        Color MAU_TRONG = Color.White;
        Color MAU_DANG_CHON = Color.Blue;
        Color MAU_DA_BAN = Color.Yellow;
        Color MAU_CHU = Color.Black;
        Color MAU_CHU_KHI_CHON = Color.White;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kích thước và khoảng cách của mỗi ghế
            int chieuRong = 50;
            int chieuCao = 50;
            int khoangCachX = 10;
            int khoangCachY = 10;
            int batDauX = 30; // Vị trí bắt đầu vẽ ghế (trục X)
            int batDauY = 30; // Vị trí bắt đầu vẽ ghế (trục Y)

            for (int i = 0; i < TONG_SO_GHE; i++)
            {
                Label ghe = new Label();

                // 1. Tính toán vị trí (Hàng & Cột)
                int cot = i % SO_GHE_MOT_HANG;
                int hang = i / SO_GHE_MOT_HANG;

                int viTriX = batDauX + cot * (chieuRong + khoangCachX);
                int viTriY = batDauY + hang * (chieuCao + khoangCachY);

                // 2. Thiết lập thuộc tính cho ghế (Label)
                ghe.Text = (i + 1).ToString();
                ghe.Size = new Size(chieuRong, chieuCao);
                ghe.Location = new Point(viTriX, viTriY);
                ghe.BackColor = MAU_TRONG;
                ghe.ForeColor = MAU_CHU;
                ghe.BorderStyle = BorderStyle.FixedSingle;
                ghe.TextAlign = ContentAlignment.MiddleCenter;
                ghe.Font = new Font("Arial", 10F, FontStyle.Bold);

                // 3. Quan trọng: Lưu trạng thái vào Tag
                // Giả lập một số ghế đã bán (giống hình)
                if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4)
                {
                    ghe.Tag = "sold"; // "available", "selecting", "sold"
                    ghe.BackColor = MAU_DA_BAN;
                }
                else
                {
                    ghe.Tag = "available";
                }

                // 4. Quan trọng: Gán sự kiện Click cho từng ghế (BUOC 3)
                ghe.Click += Ghe_Click;

                // 5. Thêm ghế vào Form và vào danh sách
                this.Controls.Add(ghe);
                listGhe.Add(ghe);
            }
        }
        private void Ghe_Click(object sender, EventArgs e)
        {
            // Lấy Label (ghế) đã được click
            Label ghe = (Label)sender;

            // Đọc trạng thái từ Tag
            string trangThai = ghe.Tag.ToString();

            switch (trangThai)
            {
                case "available": // Nếu là ghế trắng (chưa bán)
                    ghe.Tag = "selecting";
                    ghe.BackColor = MAU_DANG_CHON;
                    ghe.ForeColor = MAU_CHU_KHI_CHON;
                    break;

                case "selecting": // Nếu là ghế xanh (đang chọn)
                    ghe.Tag = "available";
                    ghe.BackColor = MAU_TRONG;
                    ghe.ForeColor = MAU_CHU;
                    break;

                case "sold": // Nếu là ghế vàng (đã bán)
                    MessageBox.Show("Ghế " + ghe.Text + " đã được bán. Vui lòng chọn ghế khác!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            // Cập nhật lại tổng tiền sau mỗi lần click (BUOC 5)
            CapNhatThanhTien();
        }
        private void CapNhatThanhTien()
        {
            int soGheDangChon = 0;

            // Duyệt qua tất cả ghế trong danh sách
            foreach (Label ghe in listGhe)
            {
                if (ghe.Tag.ToString() == "selecting")
                {
                    soGheDangChon++;
                }
            }

            long tongTien = soGheDangChon * GIA_VE;

            // Dùng "N0" để định dạng số (vd: 1,000,000)
            // Dùng CultureInfo.InvariantCulture để đảm bảo dấu phẩy là phân cách hàng ngàn
            lblThanhTien.Text = tongTien.ToString("N0", CultureInfo.InvariantCulture) + " VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int soGheDaChon = 0;
            // Duyệt qua tất cả ghế
            foreach (Label ghe in listGhe)
            {
                // Nếu ghế đang chọn (màu xanh)
                if (ghe.Tag.ToString() == "selecting")
                {
                    // Đổi sang đã bán (màu vàng)
                    ghe.Tag = "sold";
                    ghe.BackColor = MAU_DA_BAN;
                    ghe.ForeColor = MAU_CHU;
                    soGheDaChon++;
                }
            }

            if (soGheDaChon > 0)
            {
                MessageBox.Show($"Bạn đã chọn thành công {soGheDaChon} vé.",
                                "Đã xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cập nhật lại tiền (sẽ về 0 vì không còn ghế nào "selecting")
            CapNhatThanhTien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả ghế
            foreach (Label ghe in listGhe)
            {
                // Nếu ghế đang chọn (màu xanh)
                if (ghe.Tag.ToString() == "selecting")
                {
                    // Đổi về chưa bán (màu trắng)
                    ghe.Tag = "available";
                    ghe.BackColor = MAU_TRONG;
                    ghe.ForeColor = MAU_CHU;
                }
            }

            // Cập nhật lại tiền (về 0)
            CapNhatThanhTien();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_Bai_7_5
{
    public partial class Form1 : Form
    {
        // Biến lưu trữ trạng thái vẽ
        private Point diemDau, diemCuoi;
        private Rectangle hinhVe = Rectangle.Empty; // Hình chữ nhật bao quanh
        private bool dangVe = false; // Trạng thái đang nhấn giữ chuột

        // Biến lưu trữ thuộc tính
        private Color mauVien = Color.Blue;
        private Color mauNen = Color.Red;
        private int kichThuocVien = 4;
        private string kieuHinh = "Filled Ellipse";
        public Form1()
        {
            InitializeComponent();
        }

        private void panelVe_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;
                diemDau = e.Location;
                diemCuoi = e.Location; // Khởi tạo
            }
        }

        private void panelVe_MouseMove(object sender, MouseEventArgs e)
        {
            if (dangVe)
            {
                diemCuoi = e.Location;
                // Tính toán lại hình chữ nhật
                hinhVe = TinhToanHinhChuNhat(diemDau, diemCuoi);
                // Yêu cầu vẽ lại (gọi hàm Paint)
                panelVe.Invalidate();
            }
        }

        private void panelVe_MouseUp(object sender, MouseEventArgs e)
        {
            if (dangVe)
            {
                dangVe = false;
                diemCuoi = e.Location;
                // Tính toán hình chữ nhật lần cuối
                hinhVe = TinhToanHinhChuNhat(diemDau, diemCuoi);
                panelVe.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboHinhVe.Items.Add("Filled Ellipse");
            cboHinhVe.Items.Add("Filled Rectangle");
            cboHinhVe.Items.Add("Ellipse");
            cboHinhVe.Items.Add("Rectangle");
            cboHinhVe.SelectedItem = kieuHinh; // Chọn "Filled Ellipse" làm mặc định

            // Cập nhật màu sắc ban đầu
            pnlMauVien.BackColor = mauVien;
            pnlMauNen.BackColor = mauNen;
            numKichThuoc.Value = kichThuocVien;
        }

        private void panelVe_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng Graphics
            Graphics g = e.Graphics;
            // Tăng chất lượng hình vẽ (chống răng cưa)
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Tạo Pen (bút vẽ viền) và Brush (cọ tô nền)
            using (Pen pen = new Pen(mauVien, kichThuocVien))
            using (Brush brush = new SolidBrush(mauNen))
            {
                // Chỉ vẽ nếu hình chữ nhật có kích thước
                if (hinhVe.Width > 0 && hinhVe.Height > 0)
                {
                    switch (kieuHinh)
                    {
                        case "Filled Ellipse":
                            g.FillEllipse(brush, hinhVe);
                            g.DrawEllipse(pen, hinhVe);
                            break;
                        case "Filled Rectangle":
                            g.FillRectangle(brush, hinhVe);
                            g.DrawRectangle(pen, hinhVe);
                            break;
                        case "Ellipse":
                            g.DrawEllipse(pen, hinhVe);
                            break;
                        case "Rectangle":
                            g.DrawRectangle(pen, hinhVe);
                            break;
                    }
                }
            } // Pen và Brush tự động được dọn dẹp (Dispose) ở đây
        }

        private void pnlMauNen_Paint(object sender, PaintEventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = mauNen; // Mở dialog với màu hiện tại

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                mauNen = colorDlg.Color;
                pnlMauNen.BackColor = mauNen;
                panelVe.Invalidate(); // Vẽ lại với màu nền mới
            }
        }

        private void pnlMauVien_Paint(object sender, PaintEventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = mauVien; // Mở dialog với màu hiện tại

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                mauVien = colorDlg.Color;
                pnlMauVien.BackColor = mauVien;
                panelVe.Invalidate(); // Vẽ lại với màu viền mới
            }
        }

        private void numKichThuoc_ValueChanged(object sender, EventArgs e)
        {
            kichThuocVien = (int)numKichThuoc.Value;
            panelVe.Invalidate(); // Vẽ lại với kích thước viền mới
        }

        private void cboHinhVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            kieuHinh = cboHinhVe.SelectedItem.ToString();
            panelVe.Invalidate(); // Vẽ lại với kiểu hình mới
        }

        private Rectangle TinhToanHinhChuNhat(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }
    }
}

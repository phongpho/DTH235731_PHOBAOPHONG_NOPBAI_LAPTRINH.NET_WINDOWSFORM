using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_Bai_3_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ten = txtName.Text;
            string ngaySinh = txtDay.Text;
            string diaChi = txtAdress.Text;
            string soDT = txtPhone.Text;
            string email = txtEmail.Text;

            // Giới tính
            string gioiTinh = "";
            if (btnNam.Checked)
                gioiTinh = "Nam";
            else if (btnNu.Checked)
                gioiTinh = "Nữ";

            // Trạng thái
            string trangThai = "";
            if (chkDangdihoc.Checked)
                trangThai += "Đang đi học ";
            if (chkDangdilam.Checked)
                trangThai += "Đang đi làm";

            // Gộp thông tin
            string thongtin = "Họ tên: " + Ten +
                              "\nNgày sinh: " + ngaySinh +
                              "\nGiới tính: " + gioiTinh +
                              "\nĐịa chỉ: " + diaChi +
                              "\nĐiện thoại: " + soDT +
                              "\nEmail: " + email +
                              "\nTrạng thái: " + trangThai;

            // Hiển thị ra MessageBox
            MessageBox.Show(thongtin, "Thông tin cá nhân");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}

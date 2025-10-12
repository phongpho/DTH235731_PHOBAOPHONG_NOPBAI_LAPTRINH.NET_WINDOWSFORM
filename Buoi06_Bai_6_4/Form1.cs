using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_Bai_6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;

            lvSinhVien.Columns.Add("Mã SV", 176);
            lvSinhVien.Columns.Add("Họ Tên", 176);
            lvSinhVien.Columns.Add("Ngày Sinh", 176);
            lvSinhVien.Columns.Add("Phái", 176);
            lvSinhVien.Columns.Add("Điện Thoại", 176);
            lvSinhVien.Columns.Add("Quê Quán", 176);


            cboQueQuan.Items.AddRange(new string[]
            {
                "TP. Hồ Chí Minh",
                "Hà Nội",
                "Đà Nẵng",
                "Huế",
                "Cần Thơ",
                "Bình Dương"
            });
            cboQueQuan.SelectedIndex = 0;

            // Mặc định giới tính
            rdoNam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SV!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên sinh viên!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string phai = rdoNam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");

            // Thêm vào ListView
            ListViewItem item = new ListViewItem(txtMaSV.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(ngaySinh);
            item.SubItems.Add(phai);
            item.SubItems.Add(txtDienThoai.Text);
            item.SubItems.Add(cboQueQuan.Text);

            lvSinhVien.Items.Add(item);
            ClearInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.Text = txtMaSV.Text;
            item.SubItems[1].Text = txtHoTen.Text;
            item.SubItems[2].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            item.SubItems[3].Text = rdoNam.Checked ? "Nam" : "Nữ";
            item.SubItems[4].Text = txtDienThoai.Text;
            item.SubItems[5].Text = cboQueQuan.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ClearInput()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            rdoNam.Checked = true;
            cboQueQuan.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

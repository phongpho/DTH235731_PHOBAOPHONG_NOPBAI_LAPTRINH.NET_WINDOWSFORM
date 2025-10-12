using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_Bai_6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm vào DataGridView
            dgvSinhVien.Rows.Add(
                txtMaSV.Text,
                txtHoTen.Text,
                txtDiaChi.Text,
                dtpNgaySinh.Value.ToShortDateString(),
                cboLop.Text
            );

            // Xóa trắng các ô nhập
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cboLop.SelectedIndex = -1;
            txtMaSV.Focus();
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSinhVien.SelectedRows)
                {
                    dgvSinhVien.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");
            cboLop.Items.Add("Lớp C");
            cboLop.Items.Add("Lớp D");
            cboLop.SelectedIndex = 0;
            
            dgvSinhVien.ColumnCount = 5;
            dgvSinhVien.Columns[0].Name = "Mã SV";
            dgvSinhVien.Columns[1].Name = "Họ Tên SV";
            dgvSinhVien.Columns[2].Name = "Địa Chỉ";
            dgvSinhVien.Columns[3].Name = "Ngày Sinh";
            dgvSinhVien.Columns[4].Name = "Lớp";

            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = true;
            dgvSinhVien.AllowUserToAddRows = false;
        }
    }
}

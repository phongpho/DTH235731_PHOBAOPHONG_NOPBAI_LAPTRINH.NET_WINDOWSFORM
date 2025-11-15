using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi10_Bai_1_SQLsever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-TKVQ97S;Initial Catalog=QLNV;Integrated Security=True";

            // Dữ liệu combobox Chức vụ 
            string sQueryChucVu = @"select * from chucvu";
            daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
            daChucVu.Fill(ds, "tblChucVu");
            cboChucVu.DataSource = ds.Tables["tblChucVu"];
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";

            // Dữ liệu datagrid Danh sách nhân viên 
            string sQueryNhanVien = @"
                                    SELECT n.*, c.tencv 
                                    FROM nhanvien n 
                                    INNER JOIN chucvu c ON n.macv = c.macv";

            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");

            // Gán nguồn dữ liệu cho DataGridView
            dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];

            // ===== Tùy chỉnh tiêu đề và độ rộng các cột =====
            dgDSNhanVien.Columns["manv"].HeaderText = "Mã số";
            dgDSNhanVien.Columns["manv"].Width = 80;

            dgDSNhanVien.Columns["holot"].HeaderText = "Họ và lót";
            dgDSNhanVien.Columns["holot"].Width = 160;

            dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgDSNhanVien.Columns["tennv"].Width = 100;

            dgDSNhanVien.Columns["phai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["phai"].Width = 70;

            dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["ngaysinh"].Width = 120;
            dgDSNhanVien.Columns["ngaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Định dạng ngày

            dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
            dgDSNhanVien.Columns["tencv"].Width = 180;

            // Ẩn cột mã chức vụ (khóa ngoại)
            dgDSNhanVien.Columns["macv"].Visible = false;

            // ===== Tùy chỉnh giao diện hiển thị =====
            dgDSNhanVien.EnableHeadersVisualStyles = false;
            dgDSNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgDSNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgDSNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            dgDSNhanVien.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgDSNhanVien.DefaultCellStyle.BackColor = Color.White;
            dgDSNhanVien.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgDSNhanVien.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgDSNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDSNhanVien.RowHeadersVisible = false;
            dgDSNhanVien.MultiSelect = false;

            string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @MaCV)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10,
            "ngaysinh");
            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");

            daNhanVien.InsertCommand = cmThemNV;

            string sSuaNV = @"UPDATE nhanvien 
                            SET holot=@HoLot, tennv=@TenNV, phai=@Phai, ngaysinh=@NgaySinh, macv=@MaCV
                            WHERE manv=@MaNV";
            SqlCommand cmSuaNV = new SqlCommand(sSuaNV, conn);
            cmSuaNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmSuaNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmSuaNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmSuaNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
            cmSuaNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            cmSuaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            daNhanVien.UpdateCommand = cmSuaNV;


            string sXoaNV = @"DELETE FROM nhanvien WHERE manv=@MaNV";
            SqlCommand cmXoaNV = new SqlCommand(sXoaNV, conn);
            cmXoaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            daNhanVien.DeleteCommand = cmXoaNV;
        }
        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
            txtMaNV.Text = dr.Cells["manv"].Value.ToString();
            txtHoLot.Text = dr.Cells["holot"].Value.ToString();
            txtTen.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["phai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            cboChucVu.SelectedValue = dr.Cells["macv"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kiểm tra trùng mã NV
            foreach (DataRow r in ds.Tables["tblDSNhanVien"].Rows)
            {
                if (r["manv"].ToString() == txtMaNV.Text)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                    return;
                }
            }

            // Tạo dòng mới
            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["manv"] = txtMaNV.Text;
            row["holot"] = txtHoLot.Text;
            row["tennv"] = txtTen.Text;
            row["phai"] = radNu.Checked ? "Nữ" : "Nam";
            row["ngaysinh"] = dtpNgaySinh.Value;
            row["macv"] = cboChucVu.SelectedValue;
            row["tencv"] = cboChucVu.Text;

            ds.Tables["tblDSNhanVien"].Rows.Add(row);

            // Cập nhật xuống CSDL
            daNhanVien.Update(ds, "tblDSNhanVien");

            MessageBox.Show("Thêm nhân viên thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
            string maNV = dr.Cells["manv"].Value.ToString();

            // Tìm dòng trong DataSet
            DataRow row = ds.Tables["tblDSNhanVien"].Rows
                .Cast<DataRow>()
                .FirstOrDefault(r => r["manv"].ToString() == maNV);

            if (row != null)
            {
                row["holot"] = txtHoLot.Text;
                row["tennv"] = txtTen.Text;
                row["phai"] = radNu.Checked ? "Nữ" : "Nam";
                row["ngaysinh"] = dtpNgaySinh.Value;
                row["macv"] = cboChucVu.SelectedValue;
                row["tencv"] = cboChucVu.Text;
                MessageBox.Show("Đã cập nhật thông tin nhân viên trong bảng!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
                string maNV = dr.Cells["manv"].Value.ToString();

                // Tìm dòng tương ứng trong DataSet
                DataRow row = ds.Tables["tblDSNhanVien"].Rows
                    .Cast<DataRow>()
                    .FirstOrDefault(r => r["manv"].ToString() == maNV);

                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Đã xóa nhân viên khỏi bảng!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {      
                daNhanVien.Update(ds, "tblDSNhanVien");
                MessageBox.Show("Lưu dữ liệu thành công xuống CSDL!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();
            MessageBox.Show("Đã hủy các thay đổi chưa lưu!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

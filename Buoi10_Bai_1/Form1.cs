using System;
using System.Data;
// 1. THAY ĐỔI THƯ VIỆN: Từ SqlClient -> MySqlClient
using MySql.Data.MySqlClient;
using System.Windows.Forms;

// 2. NAMESPACE (khớp với file Designer của bạn)
namespace Buoi10_Bai_1
{
    public partial class Form1 : Form
    {
        // 3. THAY ĐỔI ĐỐI TƯỢNG: Từ Sql... -> MySql...
        MySqlConnection conn;
        MySqlDataAdapter daNhanVien;
        MySqlDataAdapter daChucVu;
        DataTable dtNhanVien;
        DataTable dtChucVu;

        // Biến lưu trữ trạng thái (Thêm hay Sửa)
        bool isAdding = false;

        public Form1()
        {
            InitializeComponent();
        }

        // --- SỰ KIỆN LOAD FORM ---
        // (Hàm này file Designer của bạn đang tìm)
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 4. THAY ĐỔI CHUỖI KẾT NỐI (RẤT QUAN TRỌNG)
                // Sửa lại Server, Uid (User) và Pwd (Password) cho đúng
                string connectionString = @"Server=localhost;Database=qlnv;Uid=root;Pwd=123456;";

                conn = new MySqlConnection(connectionString);
                conn.Open();

                // 5. Tải dữ liệu ComboBox Chức Vụ (Bảng CHUCVU)
                daChucVu = new MySqlDataAdapter("SELECT * FROM chucvu", conn);
                dtChucVu = new DataTable();
                daChucVu.Fill(dtChucVu);

                cboChucVu.DataSource = dtChucVu;
                cboChucVu.DisplayMember = "tencv";
                cboChucVu.ValueMember = "macv";

                // 6. Tải dữ liệu DataGridView (Bảng NHANVIEN + CHUCVU)
                string sqlNhanVien = "SELECT manv, holot, tennv, phai, ngaysinh, n.macv, tencv " +
                                      "FROM nhanvien n, chucvu c " +
                                      "WHERE n.macv = c.macv";
                daNhanVien = new MySqlDataAdapter(sqlNhanVien, conn);
                dtNhanVien = new DataTable();
                daNhanVien.Fill(dtNhanVien);

                dgvNhanVien.DataSource = dtNhanVien;

                // 7. Cài đặt các lệnh (Command) cho DataAdapter
                SetupCommands();

                // 8. Data Binding (Liên kết dữ liệu từ GridView lên TextBox)
                SetupDataBinding();

                // 9. Cập nhật trạng thái nút
                SetButtonState(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc tải dữ liệu: " + ex.Message +
                                "\n\nKiểm tra lại chuỗi kết nối (connection string) hoặc thư viện MySql.Data đã được cài đặt chưa.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // --- CÀI ĐẶT CÁC LỆNH (THEM/XOA/SUA) ---
        private void SetupCommands()
        {
            // --- Lệnh INSERT ---
            string sThemNV = @"INSERT INTO nhanvien(manv, holot, tennv, phai, ngaysinh, macv) 
                               VALUES(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @MaCV)";
            MySqlCommand cmThemNV = new MySqlCommand(sThemNV, conn);

            cmThemNV.Parameters.Add("@MaNV", MySqlDbType.VarChar, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", MySqlDbType.VarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", MySqlDbType.VarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", MySqlDbType.VarChar, 3, "phai");
            cmThemNV.Parameters.Add("@NgaySinh", MySqlDbType.Date, 10, "ngaysinh");
            cmThemNV.Parameters.Add("@MaCV", MySqlDbType.VarChar, 5, "macv");

            daNhanVien.InsertCommand = cmThemNV;

            // --- Lệnh UPDATE ---
            string sSuaNV = @"UPDATE nhanvien 
                              SET holot = @HoLot, tennv = @TenNV, phai = @Phai, 
                                  ngaysinh = @NgaySinh, macv = @MaCV 
                              WHERE manv = @MaNV";
            MySqlCommand cmSuaNV = new MySqlCommand(sSuaNV, conn);
            cmSuaNV.Parameters.Add("@HoLot", MySqlDbType.VarChar, 50, "holot");
            cmSuaNV.Parameters.Add("@TenNV", MySqlDbType.VarChar, 10, "tennv");
            cmSuaNV.Parameters.Add("@Phai", MySqlDbType.VarChar, 3, "phai");
            cmSuaNV.Parameters.Add("@NgaySinh", MySqlDbType.Date, 10, "ngaysinh");
            cmSuaNV.Parameters.Add("@MaCV", MySqlDbType.VarChar, 5, "macv");
            cmSuaNV.Parameters.Add("@MaNV", MySqlDbType.VarChar, 5, "manv").SourceVersion = DataRowVersion.Original;

            daNhanVien.UpdateCommand = cmSuaNV;

            // --- Lệnh DELETE ---
            string sXoaNV = @"DELETE FROM nhanvien WHERE manv = @MaNV";
            MySqlCommand cmXoaNV = new MySqlCommand(sXoaNV, conn);
            cmXoaNV.Parameters.Add("@MaNV", MySqlDbType.VarChar, 5, "manv").SourceVersion = DataRowVersion.Original;

            daNhanVien.DeleteCommand = cmXoaNV;
        }

        // --- LIÊN KẾT DỮ LIỆU (DATA BINDING) ---
        private void SetupDataBinding()
        {
            // Xóa binding cũ (nếu có)
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                    c.DataBindings.Clear();
            }

            // Tạo binding mới
            txtMaNV.DataBindings.Add("Text", dtNhanVien, "manv");
            txtHoLot.DataBindings.Add("Text", dtNhanVien, "holot");
            txtTen.DataBindings.Add("Text", dtNhanVien, "tennv");
            dtpNgaySinh.DataBindings.Add("Text", dtNhanVien, "ngaysinh");
            cboChucVu.DataBindings.Add("SelectedValue", dtNhanVien, "macv");

            // Xử lý RadioButton (phái)
            if (this.BindingContext[dtNhanVien] != null)
            {
                // Gỡ sự kiện cũ trước khi gán mới
                this.BindingContext[dtNhanVien].PositionChanged -= BindingContext_PositionChanged;
                this.BindingContext[dtNhanVien].PositionChanged += BindingContext_PositionChanged;
            }

            BindingContext_PositionChanged(null, null); // Cập nhật lần đầu
        }

        // Sự kiện xảy ra khi di chuyển (click) trên DataGridView
        private void BindingContext_PositionChanged(object sender, EventArgs e)
        {
            // Kiểm tra an toàn trước khi truy cập
            if (this.BindingContext[dtNhanVien] != null && this.BindingContext[dtNhanVien].Current != null)
            {
                DataRowView drv = (DataRowView)this.BindingContext[dtNhanVien].Current;
                string phai = drv["phai"].ToString();
                if (phai == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
            }
        }

        // --- XỬ LÝ CÁC NÚT BẤM (Hàm sự kiện bắt buộc) ---

        // (Hàm này file Designer của bạn đang tìm)
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetButtonState(false); // Mở khóa các ô

            // Xóa binding để nhập liệu
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                    c.DataBindings.Clear();
            }

            // Dọn dẹp các ô
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            cboChucVu.SelectedIndex = 0;

            txtMaNV.Focus();
        }

        // (Hàm này file Designer của bạn đang tìm)
        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdding = false;
            SetButtonState(false); // Mở khóa các ô
            txtMaNV.Enabled = false; // Không cho sửa Mã NV (Khóa chính)
            txtHoLot.Focus();
        }

        // (Hàm này file Designer của bạn đang tìm)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + txtMaNV.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // Lấy dòng hiện tại từ BindingContext
                    if (this.BindingContext[dtNhanVien].Current != null)
                    {
                        DataRowView drv = (DataRowView)this.BindingContext[dtNhanVien].Current;
                        drv.Delete(); // Đánh dấu xóa trên DataTable

                        // Cập nhật xuống Database
                        daNhanVien.Update(dtNhanVien);
                        dtNhanVien.AcceptChanges(); // Xác nhận thay đổi
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtNhanVien.RejectChanges(); // Hủy thay đổi nếu lỗi
                }
            }
        }

        // (Hàm này file Designer của bạn đang tìm)
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu (Validation)
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                string.IsNullOrWhiteSpace(txtHoLot.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Mã NV, Họ lót và Tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isAdding) // Nếu đang Thêm -> Thực hiện INSERT
                {
                    // Tạo dòng mới
                    DataRow newRow = dtNhanVien.NewRow();
                    newRow["manv"] = txtMaNV.Text;
                    newRow["holot"] = txtHoLot.Text;
                    newRow["tennv"] = txtTen.Text;
                    newRow["phai"] = (radNam.Checked) ? "Nam" : "Nữ";
                    newRow["ngaysinh"] = dtpNgaySinh.Value;
                    newRow["macv"] = cboChucVu.SelectedValue;

                    dtNhanVien.Rows.Add(newRow); // Thêm vào DataTable

                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                }
                else // Nếu đang Sửa -> Thực hiện UPDATE
                {
                    // Lấy dòng hiện tại
                    DataRowView drv = (DataRowView)this.BindingContext[dtNhanVien].Current;
                    drv.BeginEdit();
                    drv["holot"] = txtHoLot.Text;
                    drv["tennv"] = txtTen.Text;
                    drv["phai"] = (radNam.Checked) ? "Nam" : "Nữ";
                    drv["ngaysinh"] = dtpNgaySinh.Value;
                    drv["macv"] = cboChucVu.SelectedValue;
                    drv.EndEdit();

                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }

                // 2. Cập nhật Database
                daNhanVien.Update(dtNhanVien);
                dtNhanVien.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi");
                dtNhanVien.RejectChanges(); // Hủy bỏ thay đổi nếu có lỗi
            }
            finally
            {
                // 3. Reset lại trạng thái
                SetButtonState(true);
                isAdding = false;
                SetupDataBinding(); // Gắn lại DataBinding
            }
        }

        // (Hàm này file Designer của bạn đang tìm)
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng kết nối an toàn (chuyển từ FormClosing)
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            this.Close();
        }

        // --- QUẢN LÝ TRẠNG THÁI NÚT ---
        private void SetButtonState(bool normal)
        {
            // Bật/tắt các nút chính
            btnThem.Enabled = normal;
            btnSua.Enabled = normal;
            btnXoa.Enabled = normal;
            btnThoat.Enabled = normal;

            btnHuy.Enabled = !normal; // Nút Hủy/Lưu chỉ bật khi Thêm/Sửa

            // Bật/tắt các ô nhập liệu
            // Khi Thêm, cho phép nhập MaNV
            // Khi Sửa, không cho phép nhập MaNV
            txtMaNV.Enabled = !normal && isAdding;
            txtHoLot.Enabled = !normal;
            txtTen.Enabled = !normal;
            radNam.Enabled = !normal;
            radNu.Enabled = !normal;
            dtpNgaySinh.Enabled = !normal;
            cboChucVu.Enabled = !normal;

            // Khóa DataGridView khi đang Thêm/Sửa
            dgvNhanVien.Enabled = normal;
        }

        // --- SỰ KIỆN ĐÓNG FORM (Hàm sự kiện bắt buộc) ---
        // (File Designer của bạn không có sự kiện FormClosing,
        // nên ta xử lý đóng kết nối trong btnThoat_Click)
        // private void Form1_FormClosing(...) // Bị xóa
    }
}
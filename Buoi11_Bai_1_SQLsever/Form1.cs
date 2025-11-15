using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi11_Bai_1_SQLsever
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-TKVQ97S;Initial Catalog=QLHS;Integrated Security=True";
        bool isAdding = false;
        string selectedMaHS = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGridView();
            
        }
        public void LoadComboBox()
        {
            try
            {
                string sql = "select maqq, tenqq from quequan";
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    try
                    {     
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }

                }

                cboQueQuan.DataSource = dt;
                cboQueQuan.DisplayMember = "tenqq";
                cboQueQuan.ValueMember = "maqq";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void LoadDataGridView()
        {
            try
            {

                string sql = "SELECT hocsinh.mahs, hocsinh.holot, hocsinh.tenhs, hocsinh.phai, hocsinh.ngaysinh, quequan.tenqq " +
                             "FROM hocsinh " +
                             "LEFT JOIN quequan ON hocsinh.maqq = quequan.maqq";
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }
                }
                dgvHocSinh.DataSource = dt;

                dgvHocSinh.Columns[0].HeaderText = "Mã học sinh";
                dgvHocSinh.Columns[1].HeaderText = "Họ lót";
                dgvHocSinh.Columns[2].HeaderText = "Tên học sinh";
                dgvHocSinh.Columns[3].HeaderText = "Phái";
                dgvHocSinh.Columns[4].HeaderText = "Ngày sinh";
                dgvHocSinh.Columns[5].HeaderText = "Quê quán";

                dgvHocSinh.Columns[0].FillWeight = 60;  
                dgvHocSinh.Columns[1].FillWeight = 120; 
                dgvHocSinh.Columns[2].FillWeight = 90; 
                dgvHocSinh.Columns[3].FillWeight = 60;  
                dgvHocSinh.Columns[4].FillWeight = 120;
                dgvHocSinh.Columns[5].FillWeight = 150; 

                dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHocSinh.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvHocSinh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvHocSinh.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvHocSinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            txtMaSo.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            cboQueQuan.SelectedIndex = 0;

            txtMaSo.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaHS == "")
            {
                MessageBox.Show("Chưa chọn học sinh!");
                return;
            }

            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM hocsinh WHERE mahs = @mahs";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@mahs", selectedMaHS);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đã xóa!");
                LoadDataGridView();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            isAdding = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];
                selectedMaHS = row.Cells[0].Value.ToString();
                txtMaSo.Text = row.Cells[0].Value.ToString();
                txtHoLot.Text = row.Cells[1].Value.ToString();
                txtTen.Text = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value.ToString() == "Nam") radNam.Checked = true;
                else rdoNu.Checked = true;

                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                cboQueQuan.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                string phai = radNam.Checked ? "Nam" : "Nữ";
                string maqq = cboQueQuan.SelectedValue.ToString();

                if (isAdding)
                {
                    sql = "INSERT INTO hocsinh VALUES (@mahs, @holot, @tenhs, @phai, @ngaysinh, @maqq)";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@mahs", txtMaSo.Text);
                }
                else
                {
                    sql = @"UPDATE hocsinh 
                    SET holot=@holot, tenhs=@tenhs, phai=@phai,
                        ngaysinh=@ngaysinh, maqq=@maqq 
                    WHERE mahs=@mahs";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@mahs", selectedMaHS);
                }

                cmd.Parameters.AddWithValue("@holot", txtHoLot.Text);
                cmd.Parameters.AddWithValue("@tenhs", txtTen.Text);
                cmd.Parameters.AddWithValue("@phai", phai);
                cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@maqq", maqq);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Lưu thành công!");
            LoadDataGridView();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void HideAllGroups()
        {
            grbTron.Visible = false;
            grbVuong.Visible = false;
            grbChuNhat.Visible = false;
            grbTamGiac.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HideAllGroups();
        }

        private void rdbTron_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTron.Checked)
            {
                HideAllGroups();
                grbTron.Visible = true;
            }
        }

        private void rdoTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTamGiac.Checked)
            {
                HideAllGroups();
                grbTamGiac.Visible = true;
            }
        }

        private void rdoVuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVuong.Checked)
            {
                HideAllGroups();
                grbVuong.Visible = true;
            }
        }

        private void rdoChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChuNhat.Checked)
            {
                HideAllGroups();
                grbChuNhat.Visible = true;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoTron.Checked)
                {
                    double r = double.Parse(txtNhapTron.Text);
                    txtChuViTron.Text = (2 * Math.PI * r).ToString("0.##");
                    txtDienTichTron.Text = (Math.PI * r * r).ToString("0.##");
                }
                else if (rdoVuong.Checked)
                {
                    double canh = double.Parse(txtNhapVuong.Text);
                    txtChuViVuong.Text = (4 * canh).ToString("0.##");
                    txtDienTichVuong.Text = (canh * canh).ToString("0.##");
                }
                else if (rdoChuNhat.Checked)
                {
                    double dai = double.Parse(txtChieuDai.Text);
                    double rong = double.Parse(txtChieuRong.Text);
                    if (dai > 0 && rong > 0)
                    {
                        txtChuViCN.Text = (2 * (dai + rong)).ToString("0.##");
                        txtDienTichCN.Text = (dai * rong).ToString("0.##");
                    }
                    else
                    {
                        MessageBox.Show("Chiều dài và chiều rộng phải > 0!", "Lỗi");
                    }
                }
                else if (rdoTamGiac.Checked)
                {
                    double a = double.Parse(txtCanhA.Text);
                    double b = double.Parse(txtCanhB.Text);
                    double c = double.Parse(txtCanhC.Text);

                    if (a + b > c && a + c > b && b + c > a)
                    {
                        double chuVi = a + b + c;
                        txtChuViTG.Text = chuVi.ToString("0.##");

                        double p = chuVi / 2;
                        double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        txtDienTichTG.Text = dienTich.ToString("0.##");

                        string loai = "Tam giác thường";
                        if (a == b && b == c) loai = "Tam giác đều";
                        else if (a == b || b == c || a == c) loai = "Tam giác cân";

                        double[] canh = { a, b, c };
                        Array.Sort(canh);
                        if (Math.Abs(canh[0] * canh[0] + canh[1] * canh[1] - canh[2] * canh[2]) < 1e-6)
                        {
                            if (loai == "Tam giác cân")
                                loai = "Tam giác vuông cân";
                            else
                                loai = "Tam giác vuông";
                        }

                        MessageBox.Show("Loại tam giác: " + loai, "Kết quả");
                    }
                    else
                    {
                        MessageBox.Show("Ba cạnh không tạo thành tam giác!", "Lỗi");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control gr in this.Controls)
            {
                if (gr is GroupBox)
                {
                    foreach (Control ctl in gr.Controls)
                    {
                        if (ctl is TextBox)
                            ((TextBox)ctl).Clear();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

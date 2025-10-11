using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_Bai_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //khai bao báo biến
        int[] a = new int[10];
        int sopt = 0;
        //CAC PHUONG THUC
        //phuong thuc in mang
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        //phuong thuc tim max
        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }

        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }
        //phuong thuc tinh trung binh
        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }
        //phuong thuc sap xep tang
        public void SapXepTang()
        {
            Array.Sort(a, 0, sopt);
        }

        public void SapXepGiam()
        {
            Array.Sort(a, 0, sopt);
            Array.Reverse(a, 0, sopt);
        }
        //phuong thuc tim UCLN cua 2 so
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        //phuong thuc kiem tra so nguyen to
        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }
        //phuong thuc dem SNT
        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }
        //phuong thuc in SNT
        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }

        public int Tong()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            return sum;
        }

        public Boolean kiemTraChanLe(int so)
        {
            if (so % 2 == 0)
                return true;
            else
                return false;
        }

        public int DemChan()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraChanLe(a[i]))
                    dem++;
            }
            return dem;
        }

        public int DemLe()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (!kiemTraChanLe(a[i]))
                    dem++;
            }
            return dem;
        }

        public String InChan()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraChanLe(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }

        public String InLe()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (!kiemTraChanLe(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }


        public bool SHH(int n)
        {
            if (n <= 1)
                return false;

            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }

            return sum == n;
        }
        public int DemSHH()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (SHH(a[i]))
                    dem++;
            }
            return dem;
        }

        public String InSHH()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (SHH(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (this.sopt == a.Length)
            {
                this.txtNhap.Text = "";
                MessageBox.Show("Mảng đầy", "Thông báo");
            }
            else
            {
                if (this.txtNhap.Text == "")
                    MessageBox.Show("Hãy nhập phần tử nảng", "Thông báo");
                else
                {
                    a[sopt] = int.Parse(this.txtNhap.Text);
                    sopt++;
                    this.txtKq.Text += this.txtNhap.Text + " ";
                    this.txtNhap.Clear();
                    this.txtNhap.Focus();
                    if (sopt > 0)
                        this.btnIn.Enabled = true;
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //xuat cac phan tu co trong mnag
            if (sopt == 0)
                txtKq.Text = "Mảng rỗng!";
            else
                txtKq.Text = "Các phần tử trong mảng là: \n\r" + InMang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKq.Clear();
            sopt = 0;
            a = new int[10];
            txtNhap.Focus();
            btnIn.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "Mảng rỗng!";
            else
            {
                SapXepGiam();
                this.txtKq.Text = "Đã sắp xếp mảng giảm dần";
                txtKq.Text += "\n\r" + InMang();
            }
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                this.txtKq.Text = "Đã sắp xếp mảng tăng dần";
                txtKq.Text += "\n\r" + InMang();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            txtKq.Text = "Tổng các phần tử trong mảng là: " + Tong().ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            txtKq.Text = "Phần tử lớn nhất trong mảng là: " + TimMax().ToString();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            txtKq.Text = "Số bé nhất trong mảng là: " + TimMin().ToString();
        }

        private void btnSHH_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "Mảng rỗng!";
            else
            {
                txtKq.Text = "Mảng có " + DemSHH().ToString() + " số hoàn hảo là: " + InSHH();
            }
        }

        private void btnSNT_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "Mảng rỗng!";
            else
                txtKq.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là: " + inSNT();
        }

        private void btnTBM_Click(object sender, EventArgs e)
        {
            txtKq.Text = "Trung bình cộng các phần tử trong mảng là: " + TrungBinhMang().ToString();
        }

        private void btnDemSole_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "Mảng rỗng!";
            else
            {
                txtKq.Text = "Mảng có " + DemLe().ToString() + " số lẻ là: " + InLe();
            }
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            txtKq.Text = "Ước chung lớn nhất 2 phần tử đầu " + a[0] + " và " + a[1] + " là " +
            timUCLN(a[0], a[1]).ToString();
        }

        private void btnDemSochan_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "Mảng rỗng!";
            else
            {
                txtKq.Text = "Mảng có " + DemChan().ToString() + " số chẵn là: " + InChan();
            }
        }
    }
}

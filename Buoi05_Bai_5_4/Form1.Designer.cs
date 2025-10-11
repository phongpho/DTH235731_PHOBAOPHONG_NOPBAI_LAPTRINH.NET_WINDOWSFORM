namespace Buoi05_Bai_5_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTron = new System.Windows.Forms.RadioButton();
            this.rdoVuong = new System.Windows.Forms.RadioButton();
            this.rdoTamGiac = new System.Windows.Forms.RadioButton();
            this.rdoChuNhat = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbVuong = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhapVuong = new System.Windows.Forms.TextBox();
            this.txtChuViVuong = new System.Windows.Forms.TextBox();
            this.txtDienTichVuong = new System.Windows.Forms.TextBox();
            this.grbTron = new System.Windows.Forms.GroupBox();
            this.txtDienTichTron = new System.Windows.Forms.TextBox();
            this.txtChuViTron = new System.Windows.Forms.TextBox();
            this.txtNhapTron = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbTamGiac = new System.Windows.Forms.GroupBox();
            this.txtDienTichTG = new System.Windows.Forms.TextBox();
            this.txtChuViTG = new System.Windows.Forms.TextBox();
            this.txtCanhA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grbChuNhat = new System.Windows.Forms.GroupBox();
            this.txtDienTichCN = new System.Windows.Forms.TextBox();
            this.txtChuViCN = new System.Windows.Forms.TextBox();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCanhB = new System.Windows.Forms.TextBox();
            this.txtCanhC = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grbVuong.SuspendLayout();
            this.grbTron.SuspendLayout();
            this.grbTamGiac.SuspendLayout();
            this.grbChuNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Chu Vi và Diện Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(370, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình Tròn - Hình Vuông";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(337, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình Tam Giác - Hình Chữ Nhật";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChuNhat);
            this.groupBox1.Controls.Add(this.rdoTamGiac);
            this.groupBox1.Controls.Add(this.rdoVuong);
            this.groupBox1.Controls.Add(this.rdoTron);
            this.groupBox1.Location = new System.Drawing.Point(266, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdoTron
            // 
            this.rdoTron.AutoSize = true;
            this.rdoTron.Location = new System.Drawing.Point(19, 29);
            this.rdoTron.Name = "rdoTron";
            this.rdoTron.Size = new System.Drawing.Size(111, 26);
            this.rdoTron.TabIndex = 0;
            this.rdoTron.TabStop = true;
            this.rdoTron.Text = "Hình Tròn";
            this.rdoTron.UseVisualStyleBackColor = true;
            this.rdoTron.CheckedChanged += new System.EventHandler(this.rdbTron_CheckedChanged);
            // 
            // rdoVuong
            // 
            this.rdoVuong.AutoSize = true;
            this.rdoVuong.Location = new System.Drawing.Point(19, 80);
            this.rdoVuong.Name = "rdoVuong";
            this.rdoVuong.Size = new System.Drawing.Size(123, 26);
            this.rdoVuong.TabIndex = 1;
            this.rdoVuong.TabStop = true;
            this.rdoVuong.Text = "Hình Vuông";
            this.rdoVuong.UseVisualStyleBackColor = true;
            this.rdoVuong.CheckedChanged += new System.EventHandler(this.rdoVuong_CheckedChanged);
            // 
            // rdoTamGiac
            // 
            this.rdoTamGiac.AutoSize = true;
            this.rdoTamGiac.Location = new System.Drawing.Point(224, 29);
            this.rdoTamGiac.Name = "rdoTamGiac";
            this.rdoTamGiac.Size = new System.Drawing.Size(151, 26);
            this.rdoTamGiac.TabIndex = 2;
            this.rdoTamGiac.TabStop = true;
            this.rdoTamGiac.Text = "Hình Tam Giác";
            this.rdoTamGiac.UseVisualStyleBackColor = true;
            this.rdoTamGiac.CheckedChanged += new System.EventHandler(this.rdoTamGiac_CheckedChanged);
            // 
            // rdoChuNhat
            // 
            this.rdoChuNhat.AutoSize = true;
            this.rdoChuNhat.Location = new System.Drawing.Point(224, 80);
            this.rdoChuNhat.Name = "rdoChuNhat";
            this.rdoChuNhat.Size = new System.Drawing.Size(149, 26);
            this.rdoChuNhat.TabIndex = 3;
            this.rdoChuNhat.TabStop = true;
            this.rdoChuNhat.Text = "Hình Chữ Nhật";
            this.rdoChuNhat.UseVisualStyleBackColor = true;
            this.rdoChuNhat.CheckedChanged += new System.EventHandler(this.rdoChuNhat_CheckedChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(119, 308);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(152, 56);
            this.btnThucHien.TabIndex = 4;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(393, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 56);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(667, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 56);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbVuong
            // 
            this.grbVuong.Controls.Add(this.txtDienTichVuong);
            this.grbVuong.Controls.Add(this.txtChuViVuong);
            this.grbVuong.Controls.Add(this.txtNhapVuong);
            this.grbVuong.Controls.Add(this.label6);
            this.grbVuong.Controls.Add(this.label5);
            this.grbVuong.Controls.Add(this.label4);
            this.grbVuong.Location = new System.Drawing.Point(87, 381);
            this.grbVuong.Name = "grbVuong";
            this.grbVuong.Size = new System.Drawing.Size(341, 182);
            this.grbVuong.TabIndex = 7;
            this.grbVuong.TabStop = false;
            this.grbVuong.Text = "Hình Vuông";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập cạnh A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chu Vi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Diện Tích:";
            // 
            // txtNhapVuong
            // 
            this.txtNhapVuong.Location = new System.Drawing.Point(150, 46);
            this.txtNhapVuong.Name = "txtNhapVuong";
            this.txtNhapVuong.Size = new System.Drawing.Size(162, 30);
            this.txtNhapVuong.TabIndex = 3;
            // 
            // txtChuViVuong
            // 
            this.txtChuViVuong.Location = new System.Drawing.Point(150, 86);
            this.txtChuViVuong.Name = "txtChuViVuong";
            this.txtChuViVuong.Size = new System.Drawing.Size(162, 30);
            this.txtChuViVuong.TabIndex = 4;
            // 
            // txtDienTichVuong
            // 
            this.txtDienTichVuong.Location = new System.Drawing.Point(150, 126);
            this.txtDienTichVuong.Name = "txtDienTichVuong";
            this.txtDienTichVuong.Size = new System.Drawing.Size(162, 30);
            this.txtDienTichVuong.TabIndex = 5;
            // 
            // grbTron
            // 
            this.grbTron.Controls.Add(this.txtDienTichTron);
            this.grbTron.Controls.Add(this.txtChuViTron);
            this.grbTron.Controls.Add(this.txtNhapTron);
            this.grbTron.Controls.Add(this.label7);
            this.grbTron.Controls.Add(this.label8);
            this.grbTron.Controls.Add(this.label9);
            this.grbTron.Location = new System.Drawing.Point(511, 381);
            this.grbTron.Name = "grbTron";
            this.grbTron.Size = new System.Drawing.Size(341, 182);
            this.grbTron.TabIndex = 8;
            this.grbTron.TabStop = false;
            this.grbTron.Text = "Hình Tròn";
            // 
            // txtDienTichTron
            // 
            this.txtDienTichTron.Location = new System.Drawing.Point(150, 126);
            this.txtDienTichTron.Name = "txtDienTichTron";
            this.txtDienTichTron.Size = new System.Drawing.Size(162, 30);
            this.txtDienTichTron.TabIndex = 5;
            // 
            // txtChuViTron
            // 
            this.txtChuViTron.Location = new System.Drawing.Point(150, 86);
            this.txtChuViTron.Name = "txtChuViTron";
            this.txtChuViTron.Size = new System.Drawing.Size(162, 30);
            this.txtChuViTron.TabIndex = 4;
            // 
            // txtNhapTron
            // 
            this.txtNhapTron.Location = new System.Drawing.Point(150, 46);
            this.txtNhapTron.Name = "txtNhapTron";
            this.txtNhapTron.Size = new System.Drawing.Size(162, 30);
            this.txtNhapTron.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Diện Tích:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chu Vi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhập Bán Kính:";
            // 
            // grbTamGiac
            // 
            this.grbTamGiac.Controls.Add(this.txtCanhC);
            this.grbTamGiac.Controls.Add(this.txtCanhB);
            this.grbTamGiac.Controls.Add(this.txtDienTichTG);
            this.grbTamGiac.Controls.Add(this.txtChuViTG);
            this.grbTamGiac.Controls.Add(this.txtCanhA);
            this.grbTamGiac.Controls.Add(this.label10);
            this.grbTamGiac.Controls.Add(this.label11);
            this.grbTamGiac.Controls.Add(this.label12);
            this.grbTamGiac.Location = new System.Drawing.Point(87, 586);
            this.grbTamGiac.Name = "grbTamGiac";
            this.grbTamGiac.Size = new System.Drawing.Size(341, 182);
            this.grbTamGiac.TabIndex = 8;
            this.grbTamGiac.TabStop = false;
            this.grbTamGiac.Text = "Hình Tam Giác";
            // 
            // txtDienTichTG
            // 
            this.txtDienTichTG.Location = new System.Drawing.Point(150, 126);
            this.txtDienTichTG.Name = "txtDienTichTG";
            this.txtDienTichTG.Size = new System.Drawing.Size(162, 30);
            this.txtDienTichTG.TabIndex = 5;
            // 
            // txtChuViTG
            // 
            this.txtChuViTG.Location = new System.Drawing.Point(150, 86);
            this.txtChuViTG.Name = "txtChuViTG";
            this.txtChuViTG.Size = new System.Drawing.Size(162, 30);
            this.txtChuViTG.TabIndex = 4;
            // 
            // txtCanhA
            // 
            this.txtCanhA.Location = new System.Drawing.Point(150, 46);
            this.txtCanhA.Name = "txtCanhA";
            this.txtCanhA.Size = new System.Drawing.Size(34, 30);
            this.txtCanhA.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Diện Tích:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Chu Vi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nhập ba cạnh:";
            // 
            // grbChuNhat
            // 
            this.grbChuNhat.Controls.Add(this.txtChieuRong);
            this.grbChuNhat.Controls.Add(this.txtDienTichCN);
            this.grbChuNhat.Controls.Add(this.txtChuViCN);
            this.grbChuNhat.Controls.Add(this.txtChieuDai);
            this.grbChuNhat.Controls.Add(this.label13);
            this.grbChuNhat.Controls.Add(this.label14);
            this.grbChuNhat.Controls.Add(this.label15);
            this.grbChuNhat.Location = new System.Drawing.Point(511, 586);
            this.grbChuNhat.Name = "grbChuNhat";
            this.grbChuNhat.Size = new System.Drawing.Size(341, 182);
            this.grbChuNhat.TabIndex = 8;
            this.grbChuNhat.TabStop = false;
            this.grbChuNhat.Text = "Hình Chữ Nhật";
            // 
            // txtDienTichCN
            // 
            this.txtDienTichCN.Location = new System.Drawing.Point(150, 126);
            this.txtDienTichCN.Name = "txtDienTichCN";
            this.txtDienTichCN.Size = new System.Drawing.Size(162, 30);
            this.txtDienTichCN.TabIndex = 5;
            // 
            // txtChuViCN
            // 
            this.txtChuViCN.Location = new System.Drawing.Point(150, 86);
            this.txtChuViCN.Name = "txtChuViCN";
            this.txtChuViCN.Size = new System.Drawing.Size(162, 30);
            this.txtChuViCN.TabIndex = 4;
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(150, 46);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(69, 30);
            this.txtChieuDai.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Diện Tích:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "Chu Vi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nhập cd và cr:";
            // 
            // txtCanhB
            // 
            this.txtCanhB.Location = new System.Drawing.Point(217, 46);
            this.txtCanhB.Name = "txtCanhB";
            this.txtCanhB.Size = new System.Drawing.Size(34, 30);
            this.txtCanhB.TabIndex = 6;
            // 
            // txtCanhC
            // 
            this.txtCanhC.Location = new System.Drawing.Point(278, 46);
            this.txtCanhC.Name = "txtCanhC";
            this.txtCanhC.Size = new System.Drawing.Size(34, 30);
            this.txtCanhC.TabIndex = 7;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(243, 46);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(69, 30);
            this.txtChieuRong.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 796);
            this.Controls.Add(this.grbChuNhat);
            this.Controls.Add(this.grbTamGiac);
            this.Controls.Add(this.grbTron);
            this.Controls.Add(this.grbVuong);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbVuong.ResumeLayout(false);
            this.grbVuong.PerformLayout();
            this.grbTron.ResumeLayout(false);
            this.grbTron.PerformLayout();
            this.grbTamGiac.ResumeLayout(false);
            this.grbTamGiac.PerformLayout();
            this.grbChuNhat.ResumeLayout(false);
            this.grbChuNhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChuNhat;
        private System.Windows.Forms.RadioButton rdoTamGiac;
        private System.Windows.Forms.RadioButton rdoVuong;
        private System.Windows.Forms.RadioButton rdoTron;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbVuong;
        private System.Windows.Forms.TextBox txtDienTichVuong;
        private System.Windows.Forms.TextBox txtChuViVuong;
        private System.Windows.Forms.TextBox txtNhapVuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbTron;
        private System.Windows.Forms.TextBox txtDienTichTron;
        private System.Windows.Forms.TextBox txtChuViTron;
        private System.Windows.Forms.TextBox txtNhapTron;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbTamGiac;
        private System.Windows.Forms.TextBox txtDienTichTG;
        private System.Windows.Forms.TextBox txtChuViTG;
        private System.Windows.Forms.TextBox txtCanhA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbChuNhat;
        private System.Windows.Forms.TextBox txtDienTichCN;
        private System.Windows.Forms.TextBox txtChuViCN;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCanhC;
        private System.Windows.Forms.TextBox txtCanhB;
        private System.Windows.Forms.TextBox txtChieuRong;
    }
}


namespace Buoi05_Bai_5_7
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
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongMang = new System.Windows.Forms.TextBox();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoTang = new System.Windows.Forms.RadioButton();
            this.rdoGiam = new System.Windows.Forms.RadioButton();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThayThe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtSoThayThe = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.Location = new System.Drawing.Point(710, 58);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(143, 69);
            this.btnXuatMang.TabIndex = 6;
            this.btnXuatMang.Text = "Xuất Mảng";
            this.btnXuatMang.UseVisualStyleBackColor = true;
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(710, 145);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(143, 69);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập mảng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kết quả:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(136, 58);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(519, 30);
            this.txtInput.TabIndex = 10;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(136, 145);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(519, 30);
            this.txtOutput.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Controls.Add(this.txtTongLe);
            this.groupBox1.Controls.Add(this.txtTongChan);
            this.groupBox1.Controls.Add(this.txtTongMang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 214);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSapXep);
            this.groupBox3.Controls.Add(this.rdoGiam);
            this.groupBox3.Controls.Add(this.rdoTang);
            this.groupBox3.Location = new System.Drawing.Point(17, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 148);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sắp xếp";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSoThayThe);
            this.groupBox4.Controls.Add(this.txtViTri);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnThayThe);
            this.groupBox4.Location = new System.Drawing.Point(450, 451);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 148);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thay Thế";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 625);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 75);
            this.button3.TabIndex = 17;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Mảng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng Chẳn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng Lẻ:";
            // 
            // txtTongMang
            // 
            this.txtTongMang.Location = new System.Drawing.Point(165, 49);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.Size = new System.Drawing.Size(82, 30);
            this.txtTongMang.TabIndex = 3;
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(165, 99);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(82, 30);
            this.txtTongChan.TabIndex = 4;
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(165, 147);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(82, 30);
            this.txtTongLe.TabIndex = 5;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(286, 49);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(79, 128);
            this.btnTong.TabIndex = 6;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtMin);
            this.groupBox2.Controls.Add(this.txtMax);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(450, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 214);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Max Min";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(286, 49);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 128);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(168, 99);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(82, 30);
            this.txtMin.TabIndex = 4;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(168, 46);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(82, 30);
            this.txtMax.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Min:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Max:";
            // 
            // rdoTang
            // 
            this.rdoTang.AutoSize = true;
            this.rdoTang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTang.Location = new System.Drawing.Point(29, 42);
            this.rdoTang.Name = "rdoTang";
            this.rdoTang.Size = new System.Drawing.Size(165, 30);
            this.rdoTang.TabIndex = 0;
            this.rdoTang.TabStop = true;
            this.rdoTang.Text = "Sắp Xếp Tăng";
            this.rdoTang.UseVisualStyleBackColor = true;
            // 
            // rdoGiam
            // 
            this.rdoGiam.AutoSize = true;
            this.rdoGiam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGiam.Location = new System.Drawing.Point(29, 90);
            this.rdoGiam.Name = "rdoGiam";
            this.rdoGiam.Size = new System.Drawing.Size(168, 30);
            this.rdoGiam.TabIndex = 1;
            this.rdoGiam.TabStop = true;
            this.rdoGiam.Text = "Sắp Xếp Giảm";
            this.rdoGiam.UseVisualStyleBackColor = true;
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(286, 30);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(79, 86);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThayThe
            // 
            this.btnThayThe.Location = new System.Drawing.Point(286, 30);
            this.btnThayThe.Name = "btnThayThe";
            this.btnThayThe.Size = new System.Drawing.Size(79, 86);
            this.btnThayThe.TabIndex = 0;
            this.btnThayThe.Text = "Thay Thế";
            this.btnThayThe.UseVisualStyleBackColor = true;
            this.btnThayThe.Click += new System.EventHandler(this.btnThayThe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vị Trí Thay Thế";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số Thay Thế";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(168, 42);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(82, 30);
            this.txtViTri.TabIndex = 7;
            // 
            // txtSoThayThe
            // 
            this.txtSoThayThe.Location = new System.Drawing.Point(168, 87);
            this.txtSoThayThe.Name = "txtSoThayThe";
            this.txtSoThayThe.Size = new System.Drawing.Size(82, 30);
            this.txtSoThayThe.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXuatMang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.TextBox txtTongMang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.RadioButton rdoGiam;
        private System.Windows.Forms.RadioButton rdoTang;
        private System.Windows.Forms.Button btnThayThe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoThayThe;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}


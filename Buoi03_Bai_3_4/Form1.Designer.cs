namespace Buoi03_Bai_3_4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChuhoa = new System.Windows.Forms.RadioButton();
            this.rdoChuthuong = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnKQ = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChuhoa);
            this.groupBox1.Controls.Add(this.rdoChuthuong);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu chữ";
            // 
            // rdoChuhoa
            // 
            this.rdoChuhoa.AutoSize = true;
            this.rdoChuhoa.Location = new System.Drawing.Point(7, 99);
            this.rdoChuhoa.Name = "rdoChuhoa";
            this.rdoChuhoa.Size = new System.Drawing.Size(146, 26);
            this.rdoChuhoa.TabIndex = 1;
            this.rdoChuhoa.TabStop = true;
            this.rdoChuhoa.Text = "CHỮ IN HOA";
            this.rdoChuhoa.UseVisualStyleBackColor = true;
            // 
            // rdoChuthuong
            // 
            this.rdoChuthuong.AutoSize = true;
            this.rdoChuthuong.Location = new System.Drawing.Point(7, 50);
            this.rdoChuthuong.Name = "rdoChuthuong";
            this.rdoChuthuong.Size = new System.Drawing.Size(123, 26);
            this.rdoChuthuong.TabIndex = 0;
            this.rdoChuthuong.TabStop = true;
            this.rdoChuthuong.Text = "Chữ thường";
            this.rdoChuthuong.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(129, 13);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(323, 30);
            this.txtHoTen.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập họ tên: ";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(129, 262);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(323, 30);
            this.txtKq.TabIndex = 13;
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(12, 223);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(111, 69);
            this.btnKQ.TabIndex = 12;
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(348, 154);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 63);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(348, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 64);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChuhoa;
        private System.Windows.Forms.RadioButton rdoChuthuong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}


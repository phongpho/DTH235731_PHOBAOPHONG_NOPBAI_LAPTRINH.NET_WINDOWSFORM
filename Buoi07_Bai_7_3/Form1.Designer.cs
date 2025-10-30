namespace Buoi07_Bai_7_3
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
            this.components = new System.ComponentModel.Container();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnMo = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(13, 13);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(1075, 528);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinh.TabIndex = 0;
            this.picHinh.TabStop = false;
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(161, 565);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(139, 60);
            this.btnTruoc.TabIndex = 1;
            this.btnTruoc.Text = "<< Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(419, 565);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(262, 60);
            this.btnMo.TabIndex = 2;
            this.btnMo.Text = "Mở danh sách hình";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(800, 565);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(139, 60);
            this.btnSau.TabIndex = 3;
            this.btnSau.Text = "Sau >>";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(357, 651);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(139, 60);
            this.btnBatDau.TabIndex = 4;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(604, 651);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 60);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 723);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.picHinh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Timer timer1;
    }
}


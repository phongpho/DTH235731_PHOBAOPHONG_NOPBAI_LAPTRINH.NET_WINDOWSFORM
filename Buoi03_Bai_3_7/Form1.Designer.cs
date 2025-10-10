namespace Buoi03_Bai_3_7
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
            this.menuTinhToan = new System.Windows.Forms.MenuStrip();
            this.tínhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuTinhToan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTinhToan
            // 
            this.menuTinhToan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTinhToan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhToánToolStripMenuItem});
            this.menuTinhToan.Location = new System.Drawing.Point(0, 0);
            this.menuTinhToan.Name = "menuTinhToan";
            this.menuTinhToan.Size = new System.Drawing.Size(1100, 28);
            this.menuTinhToan.TabIndex = 5;
            this.menuTinhToan.Text = "Tính toán";
            // 
            // tínhToánToolStripMenuItem
            // 
            this.tínhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tongToolStripMenuItem,
            this.hieuToolStripMenuItem,
            this.tichToolStripMenuItem,
            this.thuongToolStripMenuItem});
            this.tínhToánToolStripMenuItem.Name = "tínhToánToolStripMenuItem";
            this.tínhToánToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tínhToánToolStripMenuItem.Text = "Tính toán";
            // 
            // tongToolStripMenuItem
            // 
            this.tongToolStripMenuItem.Name = "tongToolStripMenuItem";
            this.tongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tongToolStripMenuItem.Text = "Tổng ";
            this.tongToolStripMenuItem.Click += new System.EventHandler(this.tongToolStripMenuItem_Click);
            // 
            // hieuToolStripMenuItem
            // 
            this.hieuToolStripMenuItem.Name = "hieuToolStripMenuItem";
            this.hieuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hieuToolStripMenuItem.Text = "Hiệu ";
            this.hieuToolStripMenuItem.Click += new System.EventHandler(this.hieuToolStripMenuItem_Click);
            // 
            // tichToolStripMenuItem
            // 
            this.tichToolStripMenuItem.Name = "tichToolStripMenuItem";
            this.tichToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tichToolStripMenuItem.Text = "Tích ";
            this.tichToolStripMenuItem.Click += new System.EventHandler(this.tichToolStripMenuItem_Click);
            // 
            // thuongToolStripMenuItem
            // 
            this.thuongToolStripMenuItem.Name = "thuongToolStripMenuItem";
            this.thuongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thuongToolStripMenuItem.Text = "Thương";
            this.thuongToolStripMenuItem.Click += new System.EventHandler(this.thuongToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(339, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 288);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(107, 148);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(274, 30);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(107, 67);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(274, 30);
            this.txtA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "PHÉP TOÁN ĐƠN GIẢN";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(446, 537);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(274, 30);
            this.txtKQ.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.menuTinhToan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuTinhToan.ResumeLayout(false);
            this.menuTinhToan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTinhToan;
        private System.Windows.Forms.ToolStripMenuItem tínhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuongToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label4;
    }
}


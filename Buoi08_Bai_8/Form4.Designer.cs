namespace Buoi08_Bai_8
{
    partial class Form4
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
            this.btnDong = new System.Windows.Forms.Button();
            this.txtChuvi = new System.Windows.Forms.RichTextBox();
            this.txtDientich = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(196, 225);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(126, 50);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtChuvi
            // 
            this.txtChuvi.Enabled = false;
            this.txtChuvi.ForeColor = System.Drawing.Color.Black;
            this.txtChuvi.Location = new System.Drawing.Point(268, 155);
            this.txtChuvi.Name = "txtChuvi";
            this.txtChuvi.Size = new System.Drawing.Size(132, 34);
            this.txtChuvi.TabIndex = 17;
            this.txtChuvi.Text = "";
            // 
            // txtDientich
            // 
            this.txtDientich.Enabled = false;
            this.txtDientich.ForeColor = System.Drawing.Color.Black;
            this.txtDientich.Location = new System.Drawing.Point(268, 85);
            this.txtDientich.Name = "txtDientich";
            this.txtDientich.Size = new System.Drawing.Size(132, 34);
            this.txtDientich.TabIndex = 16;
            this.txtDientich.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(118, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chu Vi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(118, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Diện Tích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Diện Tích Chu Vi Hình Tròn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 292);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtChuvi);
            this.Controls.Add(this.txtDientich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.RichTextBox txtChuvi;
        private System.Windows.Forms.RichTextBox txtDientich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
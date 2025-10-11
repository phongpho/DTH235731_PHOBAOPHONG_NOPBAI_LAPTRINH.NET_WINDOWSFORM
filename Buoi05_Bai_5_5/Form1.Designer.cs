namespace Buoi05_Bai_5_5
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandomArray = new System.Windows.Forms.Button();
            this.btnSumArray = new System.Windows.Forms.Button();
            this.btnOddNumber = new System.Windows.Forms.Button();
            this.btnSumOddNumber = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng Gốc";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(18, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(708, 30);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(18, 30);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(708, 30);
            this.txtOutput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // btnRandomArray
            // 
            this.btnRandomArray.Location = new System.Drawing.Point(13, 206);
            this.btnRandomArray.Name = "btnRandomArray";
            this.btnRandomArray.Size = new System.Drawing.Size(367, 46);
            this.btnRandomArray.TabIndex = 2;
            this.btnRandomArray.Text = "Xuất mảng ngẫu nhiên";
            this.btnRandomArray.UseVisualStyleBackColor = true;
            this.btnRandomArray.Click += new System.EventHandler(this.btnRandomArray_Click);
            // 
            // btnSumArray
            // 
            this.btnSumArray.Location = new System.Drawing.Point(12, 266);
            this.btnSumArray.Name = "btnSumArray";
            this.btnSumArray.Size = new System.Drawing.Size(367, 46);
            this.btnSumArray.TabIndex = 3;
            this.btnSumArray.Text = "Tính tổng giá trị mảng";
            this.btnSumArray.UseVisualStyleBackColor = true;
            this.btnSumArray.Click += new System.EventHandler(this.btnSumArray_Click);
            // 
            // btnOddNumber
            // 
            this.btnOddNumber.Location = new System.Drawing.Point(13, 326);
            this.btnOddNumber.Name = "btnOddNumber";
            this.btnOddNumber.Size = new System.Drawing.Size(367, 46);
            this.btnOddNumber.TabIndex = 4;
            this.btnOddNumber.Text = "Đếm số phần tử lẻ";
            this.btnOddNumber.UseVisualStyleBackColor = true;
            this.btnOddNumber.Click += new System.EventHandler(this.btnOddNumber_Click);
            // 
            // btnSumOddNumber
            // 
            this.btnSumOddNumber.Location = new System.Drawing.Point(12, 386);
            this.btnSumOddNumber.Name = "btnSumOddNumber";
            this.btnSumOddNumber.Size = new System.Drawing.Size(367, 46);
            this.btnSumOddNumber.TabIndex = 5;
            this.btnSumOddNumber.Text = "Tổng giá trị phần tử lẻ";
            this.btnSumOddNumber.UseVisualStyleBackColor = true;
            this.btnSumOddNumber.Click += new System.EventHandler(this.btnSumOddNumber_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(385, 386);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(367, 46);
            this.btnGiam.TabIndex = 9;
            this.btnGiam.Text = "Sắp mảng giảm";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(386, 326);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(367, 46);
            this.btnTang.TabIndex = 8;
            this.btnTang.Text = "Sắp mảng tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(385, 266);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(367, 46);
            this.btnUp2.TabIndex = 7;
            this.btnUp2.Text = "Tăng mỗi Ptử mảng lên 2";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(386, 206);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(367, 46);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "Tìm phần tử nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 455);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSumOddNumber);
            this.Controls.Add(this.btnOddNumber);
            this.Controls.Add(this.btnSumArray);
            this.Controls.Add(this.btnRandomArray);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandomArray;
        private System.Windows.Forms.Button btnSumArray;
        private System.Windows.Forms.Button btnOddNumber;
        private System.Windows.Forms.Button btnSumOddNumber;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Button btnMin;
    }
}


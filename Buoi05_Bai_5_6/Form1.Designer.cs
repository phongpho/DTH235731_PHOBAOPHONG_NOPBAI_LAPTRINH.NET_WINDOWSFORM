namespace Buoi05_Bai_5_6
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rdoMin = new System.Windows.Forms.RadioButton();
            this.rdoEvenNumbers = new System.Windows.Forms.RadioButton();
            this.rdoLastEven = new System.Windows.Forms.RadioButton();
            this.rdoSumOdd = new System.Windows.Forms.RadioButton();
            this.rdoSumEven = new System.Windows.Forms.RadioButton();
            this.rdoCountEven = new System.Windows.Forms.RadioButton();
            this.rdoCountOdd = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(18, 30);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(708, 30);
            this.txtOutput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 83);
            this.groupBox1.TabIndex = 2;
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
            // rdoMin
            // 
            this.rdoMin.AutoSize = true;
            this.rdoMin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMin.Location = new System.Drawing.Point(13, 205);
            this.rdoMin.Name = "rdoMin";
            this.rdoMin.Size = new System.Drawing.Size(395, 38);
            this.rdoMin.TabIndex = 4;
            this.rdoMin.TabStop = true;
            this.rdoMin.Text = "Tìm giá trị nhỏ nhất của mảng";
            this.rdoMin.UseVisualStyleBackColor = true;
            this.rdoMin.CheckedChanged += new System.EventHandler(this.rdoMin_CheckedChanged);
            // 
            // rdoEvenNumbers
            // 
            this.rdoEvenNumbers.AutoSize = true;
            this.rdoEvenNumbers.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEvenNumbers.Location = new System.Drawing.Point(13, 258);
            this.rdoEvenNumbers.Name = "rdoEvenNumbers";
            this.rdoEvenNumbers.Size = new System.Drawing.Size(446, 38);
            this.rdoEvenNumbers.TabIndex = 5;
            this.rdoEvenNumbers.TabStop = true;
            this.rdoEvenNumbers.Text = "Liệt kê các giá trị chẵn trong mảng";
            this.rdoEvenNumbers.UseVisualStyleBackColor = true;
            this.rdoEvenNumbers.CheckedChanged += new System.EventHandler(this.rdoEvenNumbers_CheckedChanged);
            // 
            // rdoLastEven
            // 
            this.rdoLastEven.AutoSize = true;
            this.rdoLastEven.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLastEven.Location = new System.Drawing.Point(12, 310);
            this.rdoLastEven.Name = "rdoLastEven";
            this.rdoLastEven.Size = new System.Drawing.Size(450, 38);
            this.rdoLastEven.TabIndex = 6;
            this.rdoLastEven.TabStop = true;
            this.rdoLastEven.Text = "Tìm số chẵn cuối cùng trong mảng";
            this.rdoLastEven.UseVisualStyleBackColor = true;
            this.rdoLastEven.CheckedChanged += new System.EventHandler(this.rdoLastEven_CheckedChanged);
            // 
            // rdoSumOdd
            // 
            this.rdoSumOdd.AutoSize = true;
            this.rdoSumOdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSumOdd.Location = new System.Drawing.Point(12, 362);
            this.rdoSumOdd.Name = "rdoSumOdd";
            this.rdoSumOdd.Size = new System.Drawing.Size(446, 38);
            this.rdoSumOdd.TabIndex = 7;
            this.rdoSumOdd.TabStop = true;
            this.rdoSumOdd.Text = "Tính tổng các giá trị lẻ trong mảng";
            this.rdoSumOdd.UseVisualStyleBackColor = true;
            this.rdoSumOdd.CheckedChanged += new System.EventHandler(this.rdoSumOdd_CheckedChanged);
            // 
            // rdoSumEven
            // 
            this.rdoSumEven.AutoSize = true;
            this.rdoSumEven.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSumEven.Location = new System.Drawing.Point(13, 414);
            this.rdoSumEven.Name = "rdoSumEven";
            this.rdoSumEven.Size = new System.Drawing.Size(482, 38);
            this.rdoSumEven.TabIndex = 8;
            this.rdoSumEven.TabStop = true;
            this.rdoSumEven.Text = "Tính tổng các giá trị chẵn trong mảng";
            this.rdoSumEven.UseVisualStyleBackColor = true;
            this.rdoSumEven.CheckedChanged += new System.EventHandler(this.rdoSumEven_CheckedChanged);
            // 
            // rdoCountEven
            // 
            this.rdoCountEven.AutoSize = true;
            this.rdoCountEven.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCountEven.Location = new System.Drawing.Point(12, 462);
            this.rdoCountEven.Name = "rdoCountEven";
            this.rdoCountEven.Size = new System.Drawing.Size(533, 38);
            this.rdoCountEven.TabIndex = 9;
            this.rdoCountEven.TabStop = true;
            this.rdoCountEven.Text = "Đếm số lượng các giá trị chẵn trong mảng";
            this.rdoCountEven.UseVisualStyleBackColor = true;
            this.rdoCountEven.CheckedChanged += new System.EventHandler(this.rdoCountEven_CheckedChanged);
            // 
            // rdoCountOdd
            // 
            this.rdoCountOdd.AutoSize = true;
            this.rdoCountOdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCountOdd.Location = new System.Drawing.Point(12, 510);
            this.rdoCountOdd.Name = "rdoCountOdd";
            this.rdoCountOdd.Size = new System.Drawing.Size(497, 38);
            this.rdoCountOdd.TabIndex = 10;
            this.rdoCountOdd.TabStop = true;
            this.rdoCountOdd.Text = "Đếm số lượng các giá trị lẻ trong mảng";
            this.rdoCountOdd.UseVisualStyleBackColor = true;
            this.rdoCountOdd.CheckedChanged += new System.EventHandler(this.rdoCountOdd_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 572);
            this.Controls.Add(this.rdoCountOdd);
            this.Controls.Add(this.rdoCountEven);
            this.Controls.Add(this.rdoSumEven);
            this.Controls.Add(this.rdoSumOdd);
            this.Controls.Add(this.rdoLastEven);
            this.Controls.Add(this.rdoEvenNumbers);
            this.Controls.Add(this.rdoMin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rdoMin;
        private System.Windows.Forms.RadioButton rdoEvenNumbers;
        private System.Windows.Forms.RadioButton rdoLastEven;
        private System.Windows.Forms.RadioButton rdoSumOdd;
        private System.Windows.Forms.RadioButton rdoSumEven;
        private System.Windows.Forms.RadioButton rdoCountEven;
        private System.Windows.Forms.RadioButton rdoCountOdd;
    }
}


namespace Buoi06_Bai_6_2
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSangB = new System.Windows.Forms.Button();
            this.btnSangA = new System.Windows.Forms.Button();
            this.btnAllSangB = new System.Windows.Forms.Button();
            this.btnAllSangA = new System.Windows.Forms.Button();
            this.btnSumSV = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdoLopA = new System.Windows.Forms.RadioButton();
            this.rdoLopB = new System.Windows.Forms.RadioButton();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(97, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(542, 30);
            this.txtInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLopB);
            this.groupBox1.Controls.Add(this.rdoLopA);
            this.groupBox1.Location = new System.Drawing.Point(270, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopA);
            this.groupBox2.Location = new System.Drawing.Point(21, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 348);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstLopB);
            this.groupBox3.Location = new System.Drawing.Point(503, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 348);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // btnSangB
            // 
            this.btnSangB.Location = new System.Drawing.Point(368, 246);
            this.btnSangB.Name = "btnSangB";
            this.btnSangB.Size = new System.Drawing.Size(102, 61);
            this.btnSangB.TabIndex = 6;
            this.btnSangB.Text = ">";
            this.btnSangB.UseVisualStyleBackColor = true;
            this.btnSangB.Click += new System.EventHandler(this.btnSangB_Click);
            // 
            // btnSangA
            // 
            this.btnSangA.Location = new System.Drawing.Point(368, 322);
            this.btnSangA.Name = "btnSangA";
            this.btnSangA.Size = new System.Drawing.Size(102, 61);
            this.btnSangA.TabIndex = 7;
            this.btnSangA.Text = "<";
            this.btnSangA.UseVisualStyleBackColor = true;
            this.btnSangA.Click += new System.EventHandler(this.btnSangA_Click);
            // 
            // btnAllSangB
            // 
            this.btnAllSangB.Location = new System.Drawing.Point(368, 398);
            this.btnAllSangB.Name = "btnAllSangB";
            this.btnAllSangB.Size = new System.Drawing.Size(102, 61);
            this.btnAllSangB.TabIndex = 8;
            this.btnAllSangB.Text = ">>";
            this.btnAllSangB.UseVisualStyleBackColor = true;
            this.btnAllSangB.Click += new System.EventHandler(this.btnAllSangB_Click);
            // 
            // btnAllSangA
            // 
            this.btnAllSangA.Location = new System.Drawing.Point(368, 474);
            this.btnAllSangA.Name = "btnAllSangA";
            this.btnAllSangA.Size = new System.Drawing.Size(102, 61);
            this.btnAllSangA.TabIndex = 9;
            this.btnAllSangA.Text = "<<";
            this.btnAllSangA.UseVisualStyleBackColor = true;
            this.btnAllSangA.Click += new System.EventHandler(this.btnAllSangA_Click);
            // 
            // btnSumSV
            // 
            this.btnSumSV.Location = new System.Drawing.Point(208, 610);
            this.btnSumSV.Name = "btnSumSV";
            this.btnSumSV.Size = new System.Drawing.Size(221, 46);
            this.btnSumSV.TabIndex = 10;
            this.btnSumSV.Text = "Tổng số sinh viên";
            this.btnSumSV.UseVisualStyleBackColor = true;
            this.btnSumSV.Click += new System.EventHandler(this.btnSumSV_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(502, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 46);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdoLopA
            // 
            this.rdoLopA.AutoSize = true;
            this.rdoLopA.Location = new System.Drawing.Point(40, 44);
            this.rdoLopA.Name = "rdoLopA";
            this.rdoLopA.Size = new System.Drawing.Size(81, 26);
            this.rdoLopA.TabIndex = 0;
            this.rdoLopA.TabStop = true;
            this.rdoLopA.Text = "Lớp A";
            this.rdoLopA.UseVisualStyleBackColor = true;
            // 
            // rdoLopB
            // 
            this.rdoLopB.AutoSize = true;
            this.rdoLopB.Location = new System.Drawing.Point(175, 44);
            this.rdoLopB.Name = "rdoLopB";
            this.rdoLopB.Size = new System.Drawing.Size(81, 26);
            this.rdoLopB.TabIndex = 1;
            this.rdoLopB.TabStop = true;
            this.rdoLopB.Text = "Lớp B";
            this.rdoLopB.UseVisualStyleBackColor = true;
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 22;
            this.lstLopA.Location = new System.Drawing.Point(7, 30);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.Size = new System.Drawing.Size(306, 290);
            this.lstLopA.TabIndex = 0;
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 22;
            this.lstLopB.Location = new System.Drawing.Point(13, 30);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.Size = new System.Drawing.Size(300, 290);
            this.lstLopB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 689);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSumSV);
            this.Controls.Add(this.btnAllSangA);
            this.Controls.Add(this.btnAllSangB);
            this.Controls.Add(this.btnSangA);
            this.Controls.Add(this.btnSangB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoLopB;
        private System.Windows.Forms.RadioButton rdoLopA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSangB;
        private System.Windows.Forms.Button btnSangA;
        private System.Windows.Forms.Button btnAllSangB;
        private System.Windows.Forms.Button btnAllSangA;
        private System.Windows.Forms.Button btnSumSV;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
    }
}


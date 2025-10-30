namespace Buoi07_Bai_7_5
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
            this.numKichThuoc = new System.Windows.Forms.NumericUpDown();
            this.pnlMauVien = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMauNen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHinhVe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelVe = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKichThuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numKichThuoc);
            this.groupBox1.Controls.Add(this.pnlMauVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border";
            // 
            // numKichThuoc
            // 
            this.numKichThuoc.Location = new System.Drawing.Point(102, 132);
            this.numKichThuoc.Name = "numKichThuoc";
            this.numKichThuoc.Size = new System.Drawing.Size(223, 30);
            this.numKichThuoc.TabIndex = 3;
            this.numKichThuoc.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numKichThuoc.ValueChanged += new System.EventHandler(this.numKichThuoc_ValueChanged);
            // 
            // pnlMauVien
            // 
            this.pnlMauVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlMauVien.Location = new System.Drawing.Point(102, 29);
            this.pnlMauVien.Name = "pnlMauVien";
            this.pnlMauVien.Size = new System.Drawing.Size(223, 39);
            this.pnlMauVien.TabIndex = 2;
            this.pnlMauVien.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMauVien_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlMauNen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(41, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill";
            // 
            // pnlMauNen
            // 
            this.pnlMauNen.BackColor = System.Drawing.Color.Red;
            this.pnlMauNen.Location = new System.Drawing.Point(102, 29);
            this.pnlMauNen.Name = "pnlMauNen";
            this.pnlMauNen.Size = new System.Drawing.Size(223, 39);
            this.pnlMauNen.TabIndex = 1;
            this.pnlMauNen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMauNen_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color";
            // 
            // cboHinhVe
            // 
            this.cboHinhVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhVe.FormattingEnabled = true;
            this.cboHinhVe.Location = new System.Drawing.Point(107, 120);
            this.cboHinhVe.Name = "cboHinhVe";
            this.cboHinhVe.Size = new System.Drawing.Size(225, 30);
            this.cboHinhVe.TabIndex = 2;
            this.cboHinhVe.SelectedIndexChanged += new System.EventHandler(this.cboHinhVe_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(102, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn hình vẽ";
            // 
            // panelVe
            // 
            this.panelVe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVe.Location = new System.Drawing.Point(452, 52);
            this.panelVe.Name = "panelVe";
            this.panelVe.Size = new System.Drawing.Size(476, 517);
            this.panelVe.TabIndex = 4;
            this.panelVe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVe_Paint);
            this.panelVe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVe_MouseDown);
            this.panelVe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVe_MouseMove);
            this.panelVe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVe_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 581);
            this.Controls.Add(this.panelVe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboHinhVe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKichThuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numKichThuoc;
        private System.Windows.Forms.Panel pnlMauVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlMauNen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboHinhVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelVe;
    }
}


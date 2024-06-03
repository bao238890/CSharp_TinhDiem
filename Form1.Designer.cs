namespace CSharp_TinhDiem
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
            this.lblTen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblToan = new System.Windows.Forms.Label();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.lblVan = new System.Windows.Forms.Label();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.lblTrungbinh = new System.Windows.Forms.Label();
            this.txtTrungbinh = new System.Windows.Forms.TextBox();
            this.lblXeploai = new System.Windows.Forms.Label();
            this.txtXeploai = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(85, 66);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(88, 269);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblToan
            // 
            this.lblToan.AutoSize = true;
            this.lblToan.Location = new System.Drawing.Point(85, 101);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(32, 13);
            this.lblToan.TabIndex = 0;
            this.lblToan.Text = "Toán";
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(182, 97);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(100, 20);
            this.txtToan.TabIndex = 1;
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(85, 140);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(26, 13);
            this.lblVan.TabIndex = 0;
            this.lblVan.Text = "Văn";
            // 
            // txtVan
            // 
            this.txtVan.Location = new System.Drawing.Point(182, 136);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(100, 20);
            this.txtVan.TabIndex = 1;
            // 
            // lblTrungbinh
            // 
            this.lblTrungbinh.AutoSize = true;
            this.lblTrungbinh.Location = new System.Drawing.Point(85, 185);
            this.lblTrungbinh.Name = "lblTrungbinh";
            this.lblTrungbinh.Size = new System.Drawing.Size(58, 13);
            this.lblTrungbinh.TabIndex = 0;
            this.lblTrungbinh.Text = "Trung bình";
            // 
            // txtTrungbinh
            // 
            this.txtTrungbinh.Location = new System.Drawing.Point(182, 181);
            this.txtTrungbinh.Name = "txtTrungbinh";
            this.txtTrungbinh.Size = new System.Drawing.Size(100, 20);
            this.txtTrungbinh.TabIndex = 1;
            // 
            // lblXeploai
            // 
            this.lblXeploai.AutoSize = true;
            this.lblXeploai.Location = new System.Drawing.Point(85, 231);
            this.lblXeploai.Name = "lblXeploai";
            this.lblXeploai.Size = new System.Drawing.Size(45, 13);
            this.lblXeploai.TabIndex = 0;
            this.lblXeploai.Text = "Xếp loại";
            // 
            // txtXeploai
            // 
            this.txtXeploai.Location = new System.Drawing.Point(182, 224);
            this.txtXeploai.Name = "txtXeploai";
            this.txtXeploai.Size = new System.Drawing.Size(100, 20);
            this.txtXeploai.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(254, 269);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtXeploai);
            this.Controls.Add(this.lblXeploai);
            this.Controls.Add(this.txtTrungbinh);
            this.Controls.Add(this.lblTrungbinh);
            this.Controls.Add(this.txtVan);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.lblToan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.Label lblTrungbinh;
        private System.Windows.Forms.TextBox txtTrungbinh;
        private System.Windows.Forms.Label lblXeploai;
        private System.Windows.Forms.TextBox txtXeploai;
        private System.Windows.Forms.Button btnThoat;
    }
}


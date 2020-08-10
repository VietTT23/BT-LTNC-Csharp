namespace Giai_phuong_trinh_bac_nhat
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtNghiem = new System.Windows.Forms.TextBox();
			this.btnGiai = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(36, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(405, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT AX + B = 0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(125, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nhập A";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(125, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nhập B";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nghiệm phương trình";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(191, 64);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(205, 25);
			this.txtA.TabIndex = 4;
			this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(191, 112);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(205, 25);
			this.txtB.TabIndex = 5;
			this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
			// 
			// txtNghiem
			// 
			this.txtNghiem.Location = new System.Drawing.Point(191, 157);
			this.txtNghiem.Name = "txtNghiem";
			this.txtNghiem.ReadOnly = true;
			this.txtNghiem.Size = new System.Drawing.Size(205, 25);
			this.txtNghiem.TabIndex = 6;
			// 
			// btnGiai
			// 
			this.btnGiai.Location = new System.Drawing.Point(70, 215);
			this.btnGiai.Name = "btnGiai";
			this.btnGiai.Size = new System.Drawing.Size(75, 26);
			this.btnGiai.TabIndex = 7;
			this.btnGiai.Text = "&Giải";
			this.btnGiai.UseVisualStyleBackColor = true;
			this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(200, 215);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 26);
			this.btnXoa.TabIndex = 8;
			this.btnXoa.Text = "&Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(321, 215);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 26);
			this.btnThoat.TabIndex = 9;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 268);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnGiai);
			this.Controls.Add(this.txtNghiem);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Giải phương trình bậc nhất";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtNghiem;
		private System.Windows.Forms.Button btnGiai;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThoat;
	}
}


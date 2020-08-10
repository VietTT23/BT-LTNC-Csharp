namespace Combobox
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnTong = new System.Windows.Forms.Button();
			this.btnSl_uocchan = new System.Windows.Forms.Button();
			this.btnSl_uoccnguyento = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnCapnhat = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.btnCapnhat);
			this.groupBox1.Location = new System.Drawing.Point(40, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(294, 173);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập số";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listBox1);
			this.groupBox2.Location = new System.Drawing.Point(340, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(314, 173);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách các ước số";
			// 
			// btnTong
			// 
			this.btnTong.Location = new System.Drawing.Point(340, 207);
			this.btnTong.Name = "btnTong";
			this.btnTong.Size = new System.Drawing.Size(314, 29);
			this.btnTong.TabIndex = 0;
			this.btnTong.Text = "&Tổng các ước số";
			this.btnTong.UseVisualStyleBackColor = true;
			this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
			// 
			// btnSl_uocchan
			// 
			this.btnSl_uocchan.Location = new System.Drawing.Point(340, 261);
			this.btnSl_uocchan.Name = "btnSl_uocchan";
			this.btnSl_uocchan.Size = new System.Drawing.Size(314, 29);
			this.btnSl_uocchan.TabIndex = 1;
			this.btnSl_uocchan.Text = "&Số lượng các ước số chẵn";
			this.btnSl_uocchan.UseVisualStyleBackColor = true;
			this.btnSl_uocchan.Click += new System.EventHandler(this.btnSl_uocchan_Click);
			// 
			// btnSl_uoccnguyento
			// 
			this.btnSl_uoccnguyento.Location = new System.Drawing.Point(340, 311);
			this.btnSl_uoccnguyento.Name = "btnSl_uoccnguyento";
			this.btnSl_uoccnguyento.Size = new System.Drawing.Size(314, 29);
			this.btnSl_uoccnguyento.TabIndex = 2;
			this.btnSl_uoccnguyento.Text = "&Số lượng các ước số nguyên tố";
			this.btnSl_uoccnguyento.UseVisualStyleBackColor = true;
			this.btnSl_uoccnguyento.Click += new System.EventHandler(this.btnSl_uoccnguyento_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(228, 313);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 27);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "Th&oát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnCapnhat
			// 
			this.btnCapnhat.Location = new System.Drawing.Point(188, 41);
			this.btnCapnhat.Name = "btnCapnhat";
			this.btnCapnhat.Size = new System.Drawing.Size(75, 36);
			this.btnCapnhat.TabIndex = 0;
			this.btnCapnhat.Text = "&Cập nhật";
			this.btnCapnhat.UseVisualStyleBackColor = true;
			this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(44, 47);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(109, 25);
			this.textBox1.TabIndex = 1;
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(44, 104);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(219, 26);
			this.comboBox1.Sorted = true;
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new System.Drawing.Point(21, 24);
			this.listBox1.Name = "listBox1";
			this.listBox1.ScrollAlwaysVisible = true;
			this.listBox1.Size = new System.Drawing.Size(270, 130);
			this.listBox1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 365);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnSl_uoccnguyento);
			this.Controls.Add(this.btnSl_uocchan);
			this.Controls.Add(this.btnTong);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Combobox";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnCapnhat;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnTong;
		private System.Windows.Forms.Button btnSl_uocchan;
		private System.Windows.Forms.Button btnSl_uoccnguyento;
		private System.Windows.Forms.Button btnThoat;
	}
}


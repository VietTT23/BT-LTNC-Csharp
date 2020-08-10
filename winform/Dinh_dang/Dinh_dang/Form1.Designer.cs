namespace Dinh_dang
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtBlack = new System.Windows.Forms.RadioButton();
			this.rbtBlue = new System.Windows.Forms.RadioButton();
			this.rbtGreen = new System.Windows.Forms.RadioButton();
			this.rbtRed = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlText;
			this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập tên:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.textBox1.Location = new System.Drawing.Point(98, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(206, 25);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.groupBox1.Controls.Add(this.rbtBlack);
			this.groupBox1.Controls.Add(this.rbtBlue);
			this.groupBox1.Controls.Add(this.rbtGreen);
			this.groupBox1.Controls.Add(this.rbtRed);
			this.groupBox1.Location = new System.Drawing.Point(12, 85);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(177, 152);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Color";
			// 
			// rbtBlack
			// 
			this.rbtBlack.AutoSize = true;
			this.rbtBlack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.rbtBlack.Location = new System.Drawing.Point(11, 108);
			this.rbtBlack.Name = "rbtBlack";
			this.rbtBlack.Size = new System.Drawing.Size(67, 22);
			this.rbtBlack.TabIndex = 3;
			this.rbtBlack.TabStop = true;
			this.rbtBlack.Text = "Black";
			this.rbtBlack.UseVisualStyleBackColor = true;
			this.rbtBlack.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
			// 
			// rbtBlue
			// 
			this.rbtBlue.AutoSize = true;
			this.rbtBlue.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.rbtBlue.ForeColor = System.Drawing.Color.Blue;
			this.rbtBlue.Location = new System.Drawing.Point(11, 80);
			this.rbtBlue.Name = "rbtBlue";
			this.rbtBlue.Size = new System.Drawing.Size(59, 22);
			this.rbtBlue.TabIndex = 2;
			this.rbtBlue.TabStop = true;
			this.rbtBlue.Text = "Blue";
			this.rbtBlue.UseVisualStyleBackColor = true;
			this.rbtBlue.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
			// 
			// rbtGreen
			// 
			this.rbtGreen.AutoSize = true;
			this.rbtGreen.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.rbtGreen.ForeColor = System.Drawing.Color.Green;
			this.rbtGreen.Location = new System.Drawing.Point(11, 52);
			this.rbtGreen.Name = "rbtGreen";
			this.rbtGreen.Size = new System.Drawing.Size(71, 22);
			this.rbtGreen.TabIndex = 1;
			this.rbtGreen.TabStop = true;
			this.rbtGreen.Text = "Green";
			this.rbtGreen.UseVisualStyleBackColor = true;
			this.rbtGreen.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
			// 
			// rbtRed
			// 
			this.rbtRed.AutoSize = true;
			this.rbtRed.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.rbtRed.ForeColor = System.Drawing.Color.Red;
			this.rbtRed.Location = new System.Drawing.Point(11, 24);
			this.rbtRed.Name = "rbtRed";
			this.rbtRed.Size = new System.Drawing.Size(55, 22);
			this.rbtRed.TabIndex = 0;
			this.rbtRed.TabStop = true;
			this.rbtRed.Text = "Red";
			this.rbtRed.UseVisualStyleBackColor = true;
			this.rbtRed.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.groupBox2.Controls.Add(this.checkBox3);
			this.groupBox2.Controls.Add(this.checkBox2);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Location = new System.Drawing.Point(211, 85);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(182, 152);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Font";
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.checkBox3.Location = new System.Drawing.Point(20, 81);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(96, 22);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "Gạch chân";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.checkBox2.Location = new System.Drawing.Point(20, 53);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(114, 22);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Text = "Nghiêng Ilatic";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.checkBox1.Location = new System.Drawing.Point(20, 25);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(98, 22);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Đậm Bold";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(12, 302);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Lập trình bởi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label3.Location = new System.Drawing.Point(125, 302);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 18);
			this.label3.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(288, 383);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 33);
			this.button1.TabIndex = 5;
			this.button1.Text = "Thoát";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(405, 428);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Định dạng";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbtBlack;
		private System.Windows.Forms.RadioButton rbtBlue;
		private System.Windows.Forms.RadioButton rbtGreen;
		private System.Windows.Forms.RadioButton rbtRed;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}


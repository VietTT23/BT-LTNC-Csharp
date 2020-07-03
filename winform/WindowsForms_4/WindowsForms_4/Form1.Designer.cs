namespace WindowsForms_4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPhepToan = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.mot = new System.Windows.Forms.Button();
            this.hai = new System.Windows.Forms.Button();
            this.ba = new System.Windows.Forms.Button();
            this.cong = new System.Windows.Forms.Button();
            this.bon = new System.Windows.Forms.Button();
            this.nam = new System.Windows.Forms.Button();
            this.sau = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.bay = new System.Windows.Forms.Button();
            this.tam = new System.Windows.Forms.Button();
            this.chin = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.khong = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.bang = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.changeToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 13F);
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtPhepToan
            // 
            this.txtPhepToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhepToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhepToan.Location = new System.Drawing.Point(0, 30);
            this.txtPhepToan.Name = "txtPhepToan";
            this.txtPhepToan.Size = new System.Drawing.Size(406, 20);
            this.txtPhepToan.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKetQua.Location = new System.Drawing.Point(0, 50);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(406, 32);
            this.txtKetQua.TabIndex = 2;
            // 
            // mot
            // 
            this.mot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mot.Location = new System.Drawing.Point(3, 3);
            this.mot.Name = "mot";
            this.mot.Size = new System.Drawing.Size(95, 76);
            this.mot.TabIndex = 3;
            this.mot.Text = "1";
            this.mot.UseVisualStyleBackColor = true;
            this.mot.Click += new System.EventHandler(this.mot_Click);
            // 
            // hai
            // 
            this.hai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hai.Location = new System.Drawing.Point(104, 3);
            this.hai.Name = "hai";
            this.hai.Size = new System.Drawing.Size(95, 76);
            this.hai.TabIndex = 4;
            this.hai.Text = "2";
            this.hai.UseVisualStyleBackColor = true;
            this.hai.Click += new System.EventHandler(this.hai_Click);
            // 
            // ba
            // 
            this.ba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ba.Location = new System.Drawing.Point(205, 3);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(95, 76);
            this.ba.TabIndex = 5;
            this.ba.Text = "3";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.Click += new System.EventHandler(this.ba_Click);
            // 
            // cong
            // 
            this.cong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cong.Location = new System.Drawing.Point(306, 3);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(97, 76);
            this.cong.TabIndex = 6;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // bon
            // 
            this.bon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bon.Location = new System.Drawing.Point(3, 85);
            this.bon.Name = "bon";
            this.bon.Size = new System.Drawing.Size(95, 76);
            this.bon.TabIndex = 7;
            this.bon.Text = "4";
            this.bon.UseVisualStyleBackColor = true;
            this.bon.Click += new System.EventHandler(this.bon_Click);
            // 
            // nam
            // 
            this.nam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nam.Location = new System.Drawing.Point(104, 85);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(95, 76);
            this.nam.TabIndex = 8;
            this.nam.Text = "5";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.Click += new System.EventHandler(this.nam_Click);
            // 
            // sau
            // 
            this.sau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sau.Location = new System.Drawing.Point(205, 85);
            this.sau.Name = "sau";
            this.sau.Size = new System.Drawing.Size(95, 76);
            this.sau.TabIndex = 9;
            this.sau.Text = "6";
            this.sau.UseVisualStyleBackColor = true;
            this.sau.Click += new System.EventHandler(this.sau_Click);
            // 
            // tru
            // 
            this.tru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tru.Location = new System.Drawing.Point(306, 85);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(97, 76);
            this.tru.TabIndex = 10;
            this.tru.Text = "-";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.tru_Click);
            // 
            // bay
            // 
            this.bay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bay.Location = new System.Drawing.Point(3, 167);
            this.bay.Name = "bay";
            this.bay.Size = new System.Drawing.Size(95, 76);
            this.bay.TabIndex = 11;
            this.bay.Text = "7";
            this.bay.UseVisualStyleBackColor = true;
            this.bay.Click += new System.EventHandler(this.bay_Click);
            // 
            // tam
            // 
            this.tam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tam.Location = new System.Drawing.Point(104, 167);
            this.tam.Name = "tam";
            this.tam.Size = new System.Drawing.Size(95, 76);
            this.tam.TabIndex = 12;
            this.tam.Text = "8";
            this.tam.UseVisualStyleBackColor = true;
            this.tam.Click += new System.EventHandler(this.tam_Click);
            // 
            // chin
            // 
            this.chin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chin.Location = new System.Drawing.Point(205, 167);
            this.chin.Name = "chin";
            this.chin.Size = new System.Drawing.Size(95, 76);
            this.chin.TabIndex = 13;
            this.chin.Text = "9";
            this.chin.UseVisualStyleBackColor = true;
            this.chin.Click += new System.EventHandler(this.chin_Click);
            // 
            // nhan
            // 
            this.nhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nhan.Location = new System.Drawing.Point(306, 167);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(97, 76);
            this.nhan.TabIndex = 14;
            this.nhan.Text = "*";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // khong
            // 
            this.khong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.khong.Location = new System.Drawing.Point(3, 249);
            this.khong.Name = "khong";
            this.khong.Size = new System.Drawing.Size(95, 76);
            this.khong.TabIndex = 15;
            this.khong.Text = "0";
            this.khong.UseVisualStyleBackColor = true;
            this.khong.Click += new System.EventHandler(this.khong_Click);
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.clear.Location = new System.Drawing.Point(104, 249);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 76);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // bang
            // 
            this.bang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bang.Location = new System.Drawing.Point(205, 249);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(95, 76);
            this.bang.TabIndex = 17;
            this.bang.Text = "=";
            this.bang.UseVisualStyleBackColor = true;
            this.bang.Click += new System.EventHandler(this.bang_Click);
            // 
            // chia
            // 
            this.chia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chia.Location = new System.Drawing.Point(306, 249);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(97, 76);
            this.chia.TabIndex = 18;
            this.chia.Text = "/";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.chia_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.mot, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chia, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.hai, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bang, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ba, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cong, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.khong, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nhan, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.nam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.sau, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tam, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tru, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bay, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 328);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtPhepToan);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Máy tính của Trương Việt Thắng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtPhepToan;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Button mot;
        private System.Windows.Forms.Button hai;
        private System.Windows.Forms.Button ba;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button bon;
        private System.Windows.Forms.Button nam;
        private System.Windows.Forms.Button sau;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button bay;
        private System.Windows.Forms.Button tam;
        private System.Windows.Forms.Button chin;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button khong;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button bang;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


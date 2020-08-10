namespace TInh_tien_dien
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvbaocao = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxphong = new System.Windows.Forms.ComboBox();
			this.txtthanhtien = new System.Windows.Forms.TextBox();
			this.txttieuthu = new System.Windows.Forms.TextBox();
			this.txtsocu = new System.Windows.Forms.TextBox();
			this.txtthang = new System.Windows.Forms.TextBox();
			this.txtten = new System.Windows.Forms.TextBox();
			this.txtsomoi = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tinhtiendienDataSet = new TInh_tien_dien.tinhtiendienDataSet();
			this.tinhtiendienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baocaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baocaoTableAdapter = new TInh_tien_dien.tinhtiendienDataSetTableAdapters.baocaoTableAdapter();
			this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tieuthuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sodienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btntinhtien = new System.Windows.Forms.Button();
			this.btnthem = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvbaocao)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tinhtiendienDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tinhtiendienDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baocaoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(29, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "BÁO CÁO THU TIỀN ĐIỆN";
			// 
			// dgvbaocao
			// 
			this.dgvbaocao.AutoGenerateColumns = false;
			this.dgvbaocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvbaocao.BackgroundColor = System.Drawing.Color.White;
			this.dgvbaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvbaocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.phongDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.tieuthuDataGridViewTextBoxColumn,
            this.thanhtienDataGridViewTextBoxColumn,
            this.sodienDataGridViewTextBoxColumn});
			this.dgvbaocao.DataSource = this.baocaoBindingSource;
			this.dgvbaocao.Location = new System.Drawing.Point(368, 12);
			this.dgvbaocao.Name = "dgvbaocao";
			this.dgvbaocao.Size = new System.Drawing.Size(502, 387);
			this.dgvbaocao.TabIndex = 16;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbxphong);
			this.panel1.Controls.Add(this.txtthanhtien);
			this.panel1.Controls.Add(this.txttieuthu);
			this.panel1.Controls.Add(this.txtsocu);
			this.panel1.Controls.Add(this.txtthang);
			this.panel1.Controls.Add(this.txtten);
			this.panel1.Controls.Add(this.txtsomoi);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 53);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 346);
			this.panel1.TabIndex = 17;
			// 
			// cbxphong
			// 
			this.cbxphong.FormattingEnabled = true;
			this.cbxphong.Items.AddRange(new object[] {
            "Cửa gỗ xanh",
            "Cửa nhôm kính",
            "Cửa gỗ đỏ"});
			this.cbxphong.Location = new System.Drawing.Point(140, 73);
			this.cbxphong.Name = "cbxphong";
			this.cbxphong.Size = new System.Drawing.Size(202, 26);
			this.cbxphong.TabIndex = 29;
			// 
			// txtthanhtien
			// 
			this.txtthanhtien.Location = new System.Drawing.Point(140, 301);
			this.txtthanhtien.Name = "txtthanhtien";
			this.txtthanhtien.ReadOnly = true;
			this.txtthanhtien.Size = new System.Drawing.Size(202, 25);
			this.txtthanhtien.TabIndex = 28;
			// 
			// txttieuthu
			// 
			this.txttieuthu.Location = new System.Drawing.Point(140, 252);
			this.txttieuthu.Name = "txttieuthu";
			this.txttieuthu.ReadOnly = true;
			this.txttieuthu.Size = new System.Drawing.Size(202, 25);
			this.txttieuthu.TabIndex = 27;
			// 
			// txtsocu
			// 
			this.txtsocu.Location = new System.Drawing.Point(140, 162);
			this.txtsocu.Name = "txtsocu";
			this.txtsocu.Size = new System.Drawing.Size(202, 25);
			this.txtsocu.TabIndex = 26;
			// 
			// txtthang
			// 
			this.txtthang.Location = new System.Drawing.Point(140, 117);
			this.txtthang.Name = "txtthang";
			this.txtthang.Size = new System.Drawing.Size(202, 25);
			this.txtthang.TabIndex = 25;
			// 
			// txtten
			// 
			this.txtten.Location = new System.Drawing.Point(140, 33);
			this.txtten.Name = "txtten";
			this.txtten.Size = new System.Drawing.Size(202, 25);
			this.txtten.TabIndex = 24;
			// 
			// txtsomoi
			// 
			this.txtsomoi.Location = new System.Drawing.Point(140, 207);
			this.txtsomoi.Name = "txtsomoi";
			this.txtsomoi.Size = new System.Drawing.Size(202, 25);
			this.txtsomoi.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 304);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 18);
			this.label8.TabIndex = 22;
			this.label8.Text = "THÀNH TIỀN:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(29, 255);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 18);
			this.label7.TabIndex = 21;
			this.label7.Text = "TIÊU THỤ:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 18);
			this.label6.TabIndex = 20;
			this.label6.Text = "ĐIỆN SỐ MỚI:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 18);
			this.label5.TabIndex = 19;
			this.label5.Text = "ĐIỆN SỐ CŨ:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 18);
			this.label4.TabIndex = 18;
			this.label4.Text = "THÁNG:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 17;
			this.label3.Text = "PHÒNG:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 18);
			this.label2.TabIndex = 16;
			this.label2.Text = "HỌ TÊN:";
			// 
			// tinhtiendienDataSet
			// 
			this.tinhtiendienDataSet.DataSetName = "tinhtiendienDataSet";
			this.tinhtiendienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tinhtiendienDataSetBindingSource
			// 
			this.tinhtiendienDataSetBindingSource.DataSource = this.tinhtiendienDataSet;
			this.tinhtiendienDataSetBindingSource.Position = 0;
			// 
			// baocaoBindingSource
			// 
			this.baocaoBindingSource.DataMember = "baocao";
			this.baocaoBindingSource.DataSource = this.tinhtiendienDataSet;
			// 
			// baocaoTableAdapter
			// 
			this.baocaoTableAdapter.ClearBeforeFill = true;
			// 
			// tenDataGridViewTextBoxColumn
			// 
			this.tenDataGridViewTextBoxColumn.DataPropertyName = "ten";
			this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
			this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
			// 
			// phongDataGridViewTextBoxColumn
			// 
			this.phongDataGridViewTextBoxColumn.DataPropertyName = "phong";
			this.phongDataGridViewTextBoxColumn.HeaderText = "Phòng";
			this.phongDataGridViewTextBoxColumn.Name = "phongDataGridViewTextBoxColumn";
			// 
			// thangDataGridViewTextBoxColumn
			// 
			this.thangDataGridViewTextBoxColumn.DataPropertyName = "thang";
			this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
			this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
			// 
			// tieuthuDataGridViewTextBoxColumn
			// 
			this.tieuthuDataGridViewTextBoxColumn.DataPropertyName = "tieuthu";
			this.tieuthuDataGridViewTextBoxColumn.HeaderText = "Tiêu thụ";
			this.tieuthuDataGridViewTextBoxColumn.Name = "tieuthuDataGridViewTextBoxColumn";
			// 
			// thanhtienDataGridViewTextBoxColumn
			// 
			this.thanhtienDataGridViewTextBoxColumn.DataPropertyName = "thanhtien";
			this.thanhtienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
			this.thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
			// 
			// sodienDataGridViewTextBoxColumn
			// 
			this.sodienDataGridViewTextBoxColumn.DataPropertyName = "sodien";
			this.sodienDataGridViewTextBoxColumn.HeaderText = "sodien";
			this.sodienDataGridViewTextBoxColumn.Name = "sodienDataGridViewTextBoxColumn";
			// 
			// btntinhtien
			// 
			this.btntinhtien.Location = new System.Drawing.Point(44, 435);
			this.btntinhtien.Name = "btntinhtien";
			this.btntinhtien.Size = new System.Drawing.Size(75, 36);
			this.btntinhtien.TabIndex = 18;
			this.btntinhtien.Text = "Tính tiền";
			this.btntinhtien.UseVisualStyleBackColor = true;
			this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
			// 
			// btnthem
			// 
			this.btnthem.Location = new System.Drawing.Point(152, 435);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(75, 36);
			this.btnthem.TabIndex = 19;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseVisualStyleBackColor = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.Location = new System.Drawing.Point(257, 434);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(75, 37);
			this.btnxoa.TabIndex = 20;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseVisualStyleBackColor = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 483);
			this.Controls.Add(this.btnxoa);
			this.Controls.Add(this.btnthem);
			this.Controls.Add(this.btntinhtien);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvbaocao);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Tính tiền điện";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvbaocao)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tinhtiendienDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tinhtiendienDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baocaoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvbaocao;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxphong;
		private System.Windows.Forms.TextBox txtthanhtien;
		private System.Windows.Forms.TextBox txttieuthu;
		private System.Windows.Forms.TextBox txtsocu;
		private System.Windows.Forms.TextBox txtthang;
		private System.Windows.Forms.TextBox txtten;
		private System.Windows.Forms.TextBox txtsomoi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource tinhtiendienDataSetBindingSource;
		private tinhtiendienDataSet tinhtiendienDataSet;
		private System.Windows.Forms.BindingSource baocaoBindingSource;
		private tinhtiendienDataSetTableAdapters.baocaoTableAdapter baocaoTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tieuthuDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sodienDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btntinhtien;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.Button btnxoa;
	}
}


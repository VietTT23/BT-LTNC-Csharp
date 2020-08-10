namespace de_14
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.bntxoa = new System.Windows.Forms.Button();
			this.bntsua = new System.Windows.Forms.Button();
			this.bntthem = new System.Windows.Forms.Button();
			this.rbntnu = new System.Windows.Forms.RadioButton();
			this.rbntnam = new System.Windows.Forms.RadioButton();
			this.cbquequan = new System.Windows.Forms.ComboBox();
			this.txtten = new System.Windows.Forms.TextBox();
			this.txtma = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sVBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.de_14DataSet = new de_14.de_14DataSet();
			this.sVTableAdapter = new de_14.de_14DataSetTableAdapters.SVTableAdapter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sVBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.de_14DataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bntxoa);
			this.panel1.Controls.Add(this.bntsua);
			this.panel1.Controls.Add(this.bntthem);
			this.panel1.Controls.Add(this.rbntnu);
			this.panel1.Controls.Add(this.rbntnam);
			this.panel1.Controls.Add(this.cbquequan);
			this.panel1.Controls.Add(this.txtten);
			this.panel1.Controls.Add(this.txtma);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(535, 104);
			this.panel1.TabIndex = 0;
			// 
			// bntxoa
			// 
			this.bntxoa.Location = new System.Drawing.Point(457, 78);
			this.bntxoa.Name = "bntxoa";
			this.bntxoa.Size = new System.Drawing.Size(75, 23);
			this.bntxoa.TabIndex = 11;
			this.bntxoa.Text = "Xóa";
			this.bntxoa.UseVisualStyleBackColor = true;
			this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
			// 
			// bntsua
			// 
			this.bntsua.Location = new System.Drawing.Point(457, 45);
			this.bntsua.Name = "bntsua";
			this.bntsua.Size = new System.Drawing.Size(75, 23);
			this.bntsua.TabIndex = 10;
			this.bntsua.Text = "Sửa";
			this.bntsua.UseVisualStyleBackColor = true;
			this.bntsua.Click += new System.EventHandler(this.bntsua_Click);
			// 
			// bntthem
			// 
			this.bntthem.Location = new System.Drawing.Point(457, 11);
			this.bntthem.Name = "bntthem";
			this.bntthem.Size = new System.Drawing.Size(75, 23);
			this.bntthem.TabIndex = 9;
			this.bntthem.Text = "Thêm";
			this.bntthem.UseVisualStyleBackColor = true;
			this.bntthem.Click += new System.EventHandler(this.bntthem_Click);
			// 
			// rbntnu
			// 
			this.rbntnu.AutoSize = true;
			this.rbntnu.Location = new System.Drawing.Point(342, 14);
			this.rbntnu.Name = "rbntnu";
			this.rbntnu.Size = new System.Drawing.Size(39, 17);
			this.rbntnu.TabIndex = 8;
			this.rbntnu.TabStop = true;
			this.rbntnu.Text = "Nữ";
			this.rbntnu.UseVisualStyleBackColor = true;
			// 
			// rbntnam
			// 
			this.rbntnam.AutoSize = true;
			this.rbntnam.Location = new System.Drawing.Point(275, 14);
			this.rbntnam.Name = "rbntnam";
			this.rbntnam.Size = new System.Drawing.Size(47, 17);
			this.rbntnam.TabIndex = 7;
			this.rbntnam.TabStop = true;
			this.rbntnam.Text = "Nam";
			this.rbntnam.UseVisualStyleBackColor = true;
			// 
			// cbquequan
			// 
			this.cbquequan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbquequan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbquequan.FormattingEnabled = true;
			this.cbquequan.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
			this.cbquequan.Location = new System.Drawing.Point(275, 52);
			this.cbquequan.Name = "cbquequan";
			this.cbquequan.Size = new System.Drawing.Size(121, 21);
			this.cbquequan.TabIndex = 6;
			// 
			// txtten
			// 
			this.txtten.Location = new System.Drawing.Point(64, 52);
			this.txtten.Name = "txtten";
			this.txtten.Size = new System.Drawing.Size(100, 20);
			this.txtten.TabIndex = 5;
			// 
			// txtma
			// 
			this.txtma.Location = new System.Drawing.Point(64, 13);
			this.txtma.Name = "txtma";
			this.txtma.Size = new System.Drawing.Size(100, 20);
			this.txtma.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(210, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Quê quán:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(210, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Giới tính:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên SV:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã SV:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.tenSVDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.sVBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 122);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(535, 237);
			this.dataGridView1.TabIndex = 1;
			// 
			// maSVDataGridViewTextBoxColumn
			// 
			this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
			this.maSVDataGridViewTextBoxColumn.HeaderText = "Mã SV";
			this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
			// 
			// tenSVDataGridViewTextBoxColumn
			// 
			this.tenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV";
			this.tenSVDataGridViewTextBoxColumn.HeaderText = "Tên SV";
			this.tenSVDataGridViewTextBoxColumn.Name = "tenSVDataGridViewTextBoxColumn";
			// 
			// gioiTinhDataGridViewTextBoxColumn
			// 
			this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
			this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
			this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
			// 
			// queQuanDataGridViewTextBoxColumn
			// 
			this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
			this.queQuanDataGridViewTextBoxColumn.HeaderText = "Quê Quán";
			this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
			// 
			// sVBindingSource
			// 
			this.sVBindingSource.DataMember = "SV";
			this.sVBindingSource.DataSource = this.de_14DataSet;
			// 
			// de_14DataSet
			// 
			this.de_14DataSet.DataSetName = "de_14DataSet";
			this.de_14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sVTableAdapter
			// 
			this.sVTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 371);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sVBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.de_14DataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbntnu;
		private System.Windows.Forms.RadioButton rbntnam;
		private System.Windows.Forms.ComboBox cbquequan;
		private System.Windows.Forms.TextBox txtten;
		private System.Windows.Forms.TextBox txtma;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bntxoa;
		private System.Windows.Forms.Button bntsua;
		private System.Windows.Forms.Button bntthem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private de_14DataSet de_14DataSet;
		private System.Windows.Forms.BindingSource sVBindingSource;
		private de_14DataSetTableAdapters.SVTableAdapter sVTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenSVDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
	}
}


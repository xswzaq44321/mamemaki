namespace mamemaki
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.開啟OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.儲存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.結束XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.複製CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.貼上PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.numericUpDown_count = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown_margin = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
			this.button_generate = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_margin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(12, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(600, 600);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(785, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 檔案FToolStripMenuItem
			// 
			this.檔案FToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟OToolStripMenuItem,
            this.儲存SToolStripMenuItem,
            this.toolStripSeparator2,
            this.結束XToolStripMenuItem});
			this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
			this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.檔案FToolStripMenuItem.Text = "檔案(&F)";
			// 
			// 開啟OToolStripMenuItem
			// 
			this.開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
			this.開啟OToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.開啟OToolStripMenuItem.Text = "開啟(&O)";
			this.開啟OToolStripMenuItem.Click += new System.EventHandler(this.開啟OToolStripMenuItem_Click);
			// 
			// 儲存SToolStripMenuItem
			// 
			this.儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
			this.儲存SToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.儲存SToolStripMenuItem.Text = "儲存(&S)";
			this.儲存SToolStripMenuItem.Click += new System.EventHandler(this.儲存SToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
			// 
			// 結束XToolStripMenuItem
			// 
			this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
			this.結束XToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.結束XToolStripMenuItem.Text = "結束(&X)";
			this.結束XToolStripMenuItem.Click += new System.EventHandler(this.結束XToolStripMenuItem_Click);
			// 
			// 編輯EToolStripMenuItem
			// 
			this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.複製CToolStripMenuItem,
            this.貼上PToolStripMenuItem});
			this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
			this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.編輯EToolStripMenuItem.Text = "編輯(&E)";
			// 
			// 複製CToolStripMenuItem
			// 
			this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
			this.複製CToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.複製CToolStripMenuItem.Text = "複製(&C)";
			this.複製CToolStripMenuItem.Click += new System.EventHandler(this.複製CToolStripMenuItem_Click);
			// 
			// 貼上PToolStripMenuItem
			// 
			this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
			this.貼上PToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.貼上PToolStripMenuItem.Text = "貼上(&P)";
			this.貼上PToolStripMenuItem.Click += new System.EventHandler(this.貼上PToolStripMenuItem_Click);
			// 
			// numericUpDown_count
			// 
			this.numericUpDown_count.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numericUpDown_count.Location = new System.Drawing.Point(633, 111);
			this.numericUpDown_count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_count.Name = "numericUpDown_count";
			this.numericUpDown_count.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown_count.TabIndex = 1;
			this.numericUpDown_count.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDown_count.ValueChanged += new System.EventHandler(this.numericUpDown_count_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(629, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "points count";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(629, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "point\'s margin";
			// 
			// numericUpDown_margin
			// 
			this.numericUpDown_margin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numericUpDown_margin.Location = new System.Drawing.Point(633, 175);
			this.numericUpDown_margin.Name = "numericUpDown_margin";
			this.numericUpDown_margin.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown_margin.TabIndex = 5;
			this.numericUpDown_margin.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numericUpDown_margin.ValueChanged += new System.EventHandler(this.numericUpDown_margin_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(629, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "width x height";
			// 
			// numericUpDown_width
			// 
			this.numericUpDown_width.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numericUpDown_width.Location = new System.Drawing.Point(633, 51);
			this.numericUpDown_width.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_width.Name = "numericUpDown_width";
			this.numericUpDown_width.Size = new System.Drawing.Size(55, 23);
			this.numericUpDown_width.TabIndex = 6;
			this.numericUpDown_width.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
			this.numericUpDown_width.ValueChanged += new System.EventHandler(this.numericUpDown_width_ValueChanged);
			// 
			// numericUpDown_height
			// 
			this.numericUpDown_height.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numericUpDown_height.Location = new System.Drawing.Point(693, 51);
			this.numericUpDown_height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_height.Name = "numericUpDown_height";
			this.numericUpDown_height.Size = new System.Drawing.Size(55, 23);
			this.numericUpDown_height.TabIndex = 8;
			this.numericUpDown_height.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
			this.numericUpDown_height.ValueChanged += new System.EventHandler(this.numericUpDown_height_ValueChanged);
			// 
			// button_generate
			// 
			this.button_generate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_generate.Location = new System.Drawing.Point(633, 287);
			this.button_generate.Name = "button_generate";
			this.button_generate.Size = new System.Drawing.Size(120, 36);
			this.button_generate.TabIndex = 9;
			this.button_generate.Text = "generate";
			this.button_generate.UseVisualStyleBackColor = true;
			this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(633, 329);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(120, 23);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 10;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Voronoi Map (*.json)|*.json";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Voronoi Map (*.json)|*.json";
			// 
			// numericUpDown_size
			// 
			this.numericUpDown_size.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numericUpDown_size.Location = new System.Drawing.Point(633, 240);
			this.numericUpDown_size.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown_size.Name = "numericUpDown_size";
			this.numericUpDown_size.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown_size.TabIndex = 12;
			this.numericUpDown_size.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numericUpDown_size.ValueChanged += new System.EventHandler(this.numericUpDown_size_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(629, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 21);
			this.label4.TabIndex = 11;
			this.label4.Text = "point size";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(785, 634);
			this.Controls.Add(this.numericUpDown_size);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button_generate);
			this.Controls.Add(this.numericUpDown_height);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDown_width);
			this.Controls.Add(this.numericUpDown_margin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown_count);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(801, 673);
			this.MinimumSize = new System.Drawing.Size(801, 673);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_margin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 開啟OToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 儲存SToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown numericUpDown_count;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown_margin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown_width;
		private System.Windows.Forms.NumericUpDown numericUpDown_height;
		private System.Windows.Forms.Button button_generate;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.NumericUpDown numericUpDown_size;
		private System.Windows.Forms.Label label4;
	}
}


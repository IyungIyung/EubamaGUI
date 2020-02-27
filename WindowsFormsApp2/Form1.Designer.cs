namespace EubamaGui
{
	partial class Form1
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.topButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.downButton = new System.Windows.Forms.Button();
			this.bottomButton = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.push = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(918, 403);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(37, 276);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(875, 150);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(999, 403);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// topButton
			// 
			this.topButton.Location = new System.Drawing.Point(918, 277);
			this.topButton.Name = "topButton";
			this.topButton.Size = new System.Drawing.Size(75, 23);
			this.topButton.TabIndex = 4;
			this.topButton.Text = "top";
			this.topButton.UseVisualStyleBackColor = true;
			this.topButton.Click += new System.EventHandler(this.topButton_Click);
			// 
			// upButton
			// 
			this.upButton.Location = new System.Drawing.Point(918, 306);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(75, 23);
			this.upButton.TabIndex = 5;
			this.upButton.Text = "up";
			this.upButton.UseVisualStyleBackColor = true;
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// downButton
			// 
			this.downButton.Location = new System.Drawing.Point(918, 335);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(75, 23);
			this.downButton.TabIndex = 6;
			this.downButton.Text = "down";
			this.downButton.UseVisualStyleBackColor = true;
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// bottomButton
			// 
			this.bottomButton.Location = new System.Drawing.Point(918, 364);
			this.bottomButton.Name = "bottomButton";
			this.bottomButton.Size = new System.Drawing.Size(75, 23);
			this.bottomButton.TabIndex = 7;
			this.bottomButton.Text = "bottom";
			this.bottomButton.UseVisualStyleBackColor = true;
			this.bottomButton.Click += new System.EventHandler(this.bottomButton_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(37, 91);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(875, 150);
			this.dataGridView2.TabIndex = 8;
			// 
			// push
			// 
			this.push.Location = new System.Drawing.Point(435, 247);
			this.push.Name = "push";
			this.push.Size = new System.Drawing.Size(94, 23);
			this.push.TabIndex = 9;
			this.push.Text = "push to queue";
			this.push.UseVisualStyleBackColor = true;
			this.push.Click += new System.EventHandler(this.push_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1107, 434);
			this.Controls.Add(this.push);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.bottomButton);
			this.Controls.Add(this.downButton);
			this.Controls.Add(this.upButton);
			this.Controls.Add(this.topButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button topButton;
		private System.Windows.Forms.Button upButton;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button bottomButton;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button push;
	}
}


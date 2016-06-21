namespace CreateScriptGenerator
{
	partial class FrmMain
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
			this.tbPages = new System.Windows.Forms.TabControl();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnAddTable = new System.Windows.Forms.Button();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.gbDir = new System.Windows.Forms.GroupBox();
			this.btnDir = new System.Windows.Forms.Button();
			this.txtDir = new System.Windows.Forms.TextBox();
			this.gbDir.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbPages
			// 
			this.tbPages.Location = new System.Drawing.Point(4, 67);
			this.tbPages.Name = "tbPages";
			this.tbPages.SelectedIndex = 0;
			this.tbPages.Size = new System.Drawing.Size(716, 522);
			this.tbPages.TabIndex = 0;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(572, 595);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(91, 23);
			this.btnGenerate.TabIndex = 1;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnAddTable
			// 
			this.btnAddTable.Location = new System.Drawing.Point(154, 595);
			this.btnAddTable.Name = "btnAddTable";
			this.btnAddTable.Size = new System.Drawing.Size(91, 23);
			this.btnAddTable.TabIndex = 3;
			this.btnAddTable.Text = "Add Table";
			this.btnAddTable.UseVisualStyleBackColor = true;
			this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
			// 
			// txtTableName
			// 
			this.txtTableName.Location = new System.Drawing.Point(8, 595);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(142, 22);
			this.txtTableName.TabIndex = 4;
			// 
			// gbDir
			// 
			this.gbDir.Controls.Add(this.btnDir);
			this.gbDir.Controls.Add(this.txtDir);
			this.gbDir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDir.Location = new System.Drawing.Point(4, 1);
			this.gbDir.Margin = new System.Windows.Forms.Padding(4);
			this.gbDir.Name = "gbDir";
			this.gbDir.Padding = new System.Windows.Forms.Padding(4);
			this.gbDir.Size = new System.Drawing.Size(433, 59);
			this.gbDir.TabIndex = 5;
			this.gbDir.TabStop = false;
			this.gbDir.Text = "Class Directory";
			// 
			// btnDir
			// 
			this.btnDir.Image = global::CreateScriptGenerator.Properties.Resources.OpenFolder;
			this.btnDir.Location = new System.Drawing.Point(389, 25);
			this.btnDir.Margin = new System.Windows.Forms.Padding(4);
			this.btnDir.Name = "btnDir";
			this.btnDir.Size = new System.Drawing.Size(36, 25);
			this.btnDir.TabIndex = 1;
			this.btnDir.UseVisualStyleBackColor = true;
			this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
			// 
			// txtDir
			// 
			this.txtDir.Location = new System.Drawing.Point(9, 25);
			this.txtDir.Margin = new System.Windows.Forms.Padding(4);
			this.txtDir.Name = "txtDir";
			this.txtDir.Size = new System.Drawing.Size(371, 25);
			this.txtDir.TabIndex = 0;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 624);
			this.Controls.Add(this.gbDir);
			this.Controls.Add(this.txtTableName);
			this.Controls.Add(this.btnAddTable);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.tbPages);
			this.Name = "FrmMain";
			this.Text = "Createscript Generator";
			this.gbDir.ResumeLayout(false);
			this.gbDir.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tbPages;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnAddTable;
		private System.Windows.Forms.TextBox txtTableName;
		private System.Windows.Forms.GroupBox gbDir;
		private System.Windows.Forms.Button btnDir;
		private System.Windows.Forms.TextBox txtDir;
	}
}


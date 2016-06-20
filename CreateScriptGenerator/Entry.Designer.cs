namespace CreateScriptGenerator
{
	partial class Entry
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbNullable = new System.Windows.Forms.CheckBox();
			this.comEntries = new System.Windows.Forms.ComboBox();
			this.comTable = new System.Windows.Forms.ComboBox();
			this.cbPrimarykey = new System.Windows.Forms.CheckBox();
			this.comType = new System.Windows.Forms.ComboBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cbNullable
			// 
			this.cbNullable.AutoSize = true;
			this.cbNullable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbNullable.Location = new System.Drawing.Point(344, 6);
			this.cbNullable.Name = "cbNullable";
			this.cbNullable.Size = new System.Drawing.Size(18, 17);
			this.cbNullable.TabIndex = 17;
			this.cbNullable.UseVisualStyleBackColor = true;
			this.cbNullable.CheckedChanged += new System.EventHandler(this.cbNullable_CheckedChanged);
			// 
			// comEntries
			// 
			this.comEntries.FormattingEnabled = true;
			this.comEntries.Location = new System.Drawing.Point(522, 3);
			this.comEntries.Name = "comEntries";
			this.comEntries.Size = new System.Drawing.Size(121, 24);
			this.comEntries.TabIndex = 16;
			// 
			// comTable
			// 
			this.comTable.FormattingEnabled = true;
			this.comTable.Location = new System.Drawing.Point(381, 3);
			this.comTable.Name = "comTable";
			this.comTable.Size = new System.Drawing.Size(121, 24);
			this.comTable.TabIndex = 15;
			// 
			// cbPrimarykey
			// 
			this.cbPrimarykey.AutoSize = true;
			this.cbPrimarykey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPrimarykey.Location = new System.Drawing.Point(303, 6);
			this.cbPrimarykey.Name = "cbPrimarykey";
			this.cbPrimarykey.Size = new System.Drawing.Size(18, 17);
			this.cbPrimarykey.TabIndex = 14;
			this.cbPrimarykey.UseVisualStyleBackColor = true;
			this.cbPrimarykey.CheckedChanged += new System.EventHandler(this.cbPrimarykey_CheckedChanged);
			// 
			// comType
			// 
			this.comType.FormattingEnabled = true;
			this.comType.Location = new System.Drawing.Point(161, 3);
			this.comType.Name = "comType";
			this.comType.Size = new System.Drawing.Size(121, 24);
			this.comType.TabIndex = 13;
			// 
			// textName
			// 
			this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textName.Location = new System.Drawing.Point(3, 3);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(121, 24);
			this.textName.TabIndex = 12;
			// 
			// Entry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbNullable);
			this.Controls.Add(this.comEntries);
			this.Controls.Add(this.comTable);
			this.Controls.Add(this.cbPrimarykey);
			this.Controls.Add(this.comType);
			this.Controls.Add(this.textName);
			this.Name = "Entry";
			this.Size = new System.Drawing.Size(649, 29);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbNullable;
		private System.Windows.Forms.ComboBox comEntries;
		private System.Windows.Forms.ComboBox comTable;
		private System.Windows.Forms.CheckBox cbPrimarykey;
		private System.Windows.Forms.ComboBox comType;
		private System.Windows.Forms.TextBox textName;
	}
}

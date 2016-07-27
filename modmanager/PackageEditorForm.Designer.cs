namespace modmanager
{
	partial class PackageEditorForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageEditorForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.savePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePackageExistingManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.name_label = new System.Windows.Forms.Label();
			this.name_input = new System.Windows.Forms.TextBox();
			this.author_label = new System.Windows.Forms.Label();
			this.author_input = new System.Windows.Forms.TextBox();
			this.description_label = new System.Windows.Forms.Label();
			this.description_input = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mod_list = new System.Windows.Forms.ListBox();
			this.new_mod_button = new System.Windows.Forms.Button();
			this.edit_mod_button = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.menuStrip1.ForeColor = System.Drawing.Color.White;
			this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openPackageToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(912, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openPackageToolStripMenuItem
			// 
			this.openPackageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newPackageToolStripMenuItem,
			this.loadPackageToolStripMenuItem,
			this.toolStripSeparator1,
			this.savePackageToolStripMenuItem,
			this.savePackageExistingManifestToolStripMenuItem});
			this.openPackageToolStripMenuItem.Name = "openPackageToolStripMenuItem";
			this.openPackageToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.openPackageToolStripMenuItem.Text = "File";
			// 
			// newPackageToolStripMenuItem
			// 
			this.newPackageToolStripMenuItem.Name = "newPackageToolStripMenuItem";
			this.newPackageToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
			this.newPackageToolStripMenuItem.Text = "New Package";
			this.newPackageToolStripMenuItem.Click += new System.EventHandler(this.newPackageToolStripMenuItem_Click);
			// 
			// loadPackageToolStripMenuItem
			// 
			this.loadPackageToolStripMenuItem.Name = "loadPackageToolStripMenuItem";
			this.loadPackageToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
			this.loadPackageToolStripMenuItem.Text = "Open Package From Manifest";
			this.loadPackageToolStripMenuItem.Click += new System.EventHandler(this.loadPackageToolStripMenuItem_Click_1);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(296, 6);
			// 
			// savePackageToolStripMenuItem
			// 
			this.savePackageToolStripMenuItem.Name = "savePackageToolStripMenuItem";
			this.savePackageToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
			this.savePackageToolStripMenuItem.Text = "Save Package (New Manifest)";
			this.savePackageToolStripMenuItem.Click += new System.EventHandler(this.savePackageToolStripMenuItem_Click);
			// 
			// savePackageExistingManifestToolStripMenuItem
			// 
			this.savePackageExistingManifestToolStripMenuItem.Name = "savePackageExistingManifestToolStripMenuItem";
			this.savePackageExistingManifestToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
			this.savePackageExistingManifestToolStripMenuItem.Text = "Save Package (Existing Manifest)";
			this.savePackageExistingManifestToolStripMenuItem.Click += new System.EventHandler(this.savePackageExistingManifestToolStripMenuItem_Click);
			// 
			// name_label
			// 
			this.name_label.AutoSize = true;
			this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_label.Location = new System.Drawing.Point(16, 47);
			this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name_label.Name = "name_label";
			this.name_label.Size = new System.Drawing.Size(70, 25);
			this.name_label.TabIndex = 1;
			this.name_label.Text = "Name:";
			// 
			// name_input
			// 
			this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.name_input.Location = new System.Drawing.Point(132, 47);
			this.name_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.name_input.Name = "name_input";
			this.name_input.Size = new System.Drawing.Size(257, 22);
			this.name_input.TabIndex = 2;
			// 
			// author_label
			// 
			this.author_label.AutoSize = true;
			this.author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.author_label.Location = new System.Drawing.Point(15, 86);
			this.author_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.author_label.Name = "author_label";
			this.author_label.Size = new System.Drawing.Size(76, 25);
			this.author_label.TabIndex = 3;
			this.author_label.Text = "Author:";
			// 
			// author_input
			// 
			this.author_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.author_input.Location = new System.Drawing.Point(132, 86);
			this.author_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.author_input.Name = "author_input";
			this.author_input.Size = new System.Drawing.Size(257, 22);
			this.author_input.TabIndex = 4;
			// 
			// description_label
			// 
			this.description_label.AutoSize = true;
			this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description_label.Location = new System.Drawing.Point(15, 128);
			this.description_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.description_label.Name = "description_label";
			this.description_label.Size = new System.Drawing.Size(115, 25);
			this.description_label.TabIndex = 5;
			this.description_label.Text = "Description:";
			// 
			// description_input
			// 
			this.description_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.description_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description_input.Location = new System.Drawing.Point(20, 158);
			this.description_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.description_input.Multiline = true;
			this.description_input.Name = "description_input";
			this.description_input.Size = new System.Drawing.Size(369, 272);
			this.description_input.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(431, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Targeted files:";
			// 
			// mod_list
			// 
			this.mod_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mod_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mod_list.FormattingEnabled = true;
			this.mod_list.HorizontalScrollbar = true;
			this.mod_list.ItemHeight = 20;
			this.mod_list.Location = new System.Drawing.Point(436, 73);
			this.mod_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mod_list.Name = "mod_list";
			this.mod_list.Size = new System.Drawing.Size(460, 280);
			this.mod_list.TabIndex = 8;
			// 
			// new_mod_button
			// 
			this.new_mod_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.new_mod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.new_mod_button.Location = new System.Drawing.Point(436, 377);
			this.new_mod_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.new_mod_button.Name = "new_mod_button";
			this.new_mod_button.Size = new System.Drawing.Size(149, 53);
			this.new_mod_button.TabIndex = 9;
			this.new_mod_button.Text = "New";
			this.new_mod_button.UseVisualStyleBackColor = true;
			this.new_mod_button.Click += new System.EventHandler(this.new_mod_button_Click);
			// 
			// edit_mod_button
			// 
			this.edit_mod_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.edit_mod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edit_mod_button.Location = new System.Drawing.Point(593, 377);
			this.edit_mod_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.edit_mod_button.Name = "edit_mod_button";
			this.edit_mod_button.Size = new System.Drawing.Size(144, 53);
			this.edit_mod_button.TabIndex = 10;
			this.edit_mod_button.Text = "Edit";
			this.edit_mod_button.UseVisualStyleBackColor = true;
			this.edit_mod_button.Click += new System.EventHandler(this.edit_mod_button_Click);
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(745, 377);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 53);
			this.button1.TabIndex = 11;
			this.button1.Text = "Delete";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// PackageEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(912, 444);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.edit_mod_button);
			this.Controls.Add(this.new_mod_button);
			this.Controls.Add(this.mod_list);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.description_input);
			this.Controls.Add(this.description_label);
			this.Controls.Add(this.author_input);
			this.Controls.Add(this.author_label);
			this.Controls.Add(this.name_input);
			this.Controls.Add(this.name_label);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "PackageEditorForm";
			this.Text = "Package Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem openPackageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newPackageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadPackageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem savePackageToolStripMenuItem;
		private System.Windows.Forms.Label name_label;
		private System.Windows.Forms.TextBox name_input;
		private System.Windows.Forms.Label author_label;
		private System.Windows.Forms.TextBox author_input;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.TextBox description_input;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox mod_list;
		private System.Windows.Forms.Button new_mod_button;
		private System.Windows.Forms.Button edit_mod_button;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripMenuItem savePackageExistingManifestToolStripMenuItem;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}
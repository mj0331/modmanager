namespace modmanager
{
	partial class CreateProfileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfileForm));
			this.label1 = new System.Windows.Forms.Label();
			this.name_input = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.game_input = new System.Windows.Forms.TextBox();
			this.backup_input = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
			this.game_browse = new System.Windows.Forms.Button();
			this.backup_browse = new System.Windows.Forms.Button();
			this.create_profile_confirm = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.profile_input = new System.Windows.Forms.TextBox();
			this.profile_browse = new System.Windows.Forms.Button();
			this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
			this.mod_browse = new System.Windows.Forms.Button();
			this.mod_input = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// name_input
			// 
			this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.name_input.Location = new System.Drawing.Point(124, 10);
			this.name_input.Name = "name_input";
			this.name_input.Size = new System.Drawing.Size(448, 20);
			this.name_input.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Game executable:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Backup folder:";
			// 
			// game_input
			// 
			this.game_input.AllowDrop = true;
			this.game_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.game_input.Location = new System.Drawing.Point(124, 43);
			this.game_input.Name = "game_input";
			this.game_input.Size = new System.Drawing.Size(350, 20);
			this.game_input.TabIndex = 5;
			this.game_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.game_input_DragDrop);
			this.game_input.DragEnter += new System.Windows.Forms.DragEventHandler(this.game_input_DragEnter);
			// 
			// backup_input
			// 
			this.backup_input.AllowDrop = true;
			this.backup_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.backup_input.Location = new System.Drawing.Point(124, 105);
			this.backup_input.Name = "backup_input";
			this.backup_input.Size = new System.Drawing.Size(350, 20);
			this.backup_input.TabIndex = 6;
			this.backup_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.game_input_DragDrop);
			this.backup_input.DragEnter += new System.Windows.Forms.DragEventHandler(this.game_input_DragEnter);
			// 
			// game_browse
			// 
			this.game_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.game_browse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.game_browse.Location = new System.Drawing.Point(480, 43);
			this.game_browse.Name = "game_browse";
			this.game_browse.Size = new System.Drawing.Size(91, 23);
			this.game_browse.TabIndex = 7;
			this.game_browse.Text = "Browser";
			this.game_browse.UseVisualStyleBackColor = true;
			this.game_browse.Click += new System.EventHandler(this.game_browse_Click);
			// 
			// backup_browse
			// 
			this.backup_browse.AutoSize = true;
			this.backup_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backup_browse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.backup_browse.Location = new System.Drawing.Point(480, 103);
			this.backup_browse.Name = "backup_browse";
			this.backup_browse.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.backup_browse.Size = new System.Drawing.Size(91, 25);
			this.backup_browse.TabIndex = 8;
			this.backup_browse.Text = "Browse";
			this.backup_browse.UseVisualStyleBackColor = true;
			this.backup_browse.Click += new System.EventHandler(this.backup_browse_Click);
			// 
			// create_profile_confirm
			// 
			this.create_profile_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.create_profile_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.create_profile_confirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.create_profile_confirm.Location = new System.Drawing.Point(12, 163);
			this.create_profile_confirm.Name = "create_profile_confirm";
			this.create_profile_confirm.Size = new System.Drawing.Size(560, 57);
			this.create_profile_confirm.TabIndex = 9;
			this.create_profile_confirm.Text = "Create profile";
			this.create_profile_confirm.UseVisualStyleBackColor = true;
			this.create_profile_confirm.Click += new System.EventHandler(this.create_profile_confirm_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Profile save location:";
			// 
			// profile_input
			// 
			this.profile_input.AllowDrop = true;
			this.profile_input.Location = new System.Drawing.Point(124, 136);
			this.profile_input.Name = "profile_input";
			this.profile_input.Size = new System.Drawing.Size(350, 20);
			this.profile_input.TabIndex = 11;
			this.profile_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.game_input_DragDrop);
			this.profile_input.DragEnter += new System.Windows.Forms.DragEventHandler(this.game_input_DragEnter);
			// 
			// profile_browse
			// 
			this.profile_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.profile_browse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.profile_browse.Location = new System.Drawing.Point(480, 134);
			this.profile_browse.Name = "profile_browse";
			this.profile_browse.Size = new System.Drawing.Size(91, 23);
			this.profile_browse.TabIndex = 12;
			this.profile_browse.Text = "Browse";
			this.profile_browse.UseVisualStyleBackColor = true;
			this.profile_browse.Click += new System.EventHandler(this.profile_browse_Click);
			// 
			// mod_browse
			// 
			this.mod_browse.AutoSize = true;
			this.mod_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mod_browse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.mod_browse.Location = new System.Drawing.Point(480, 72);
			this.mod_browse.Name = "mod_browse";
			this.mod_browse.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.mod_browse.Size = new System.Drawing.Size(91, 25);
			this.mod_browse.TabIndex = 15;
			this.mod_browse.Text = "Browse";
			this.mod_browse.UseVisualStyleBackColor = true;
			this.mod_browse.Click += new System.EventHandler(this.mod_browse_Click);
			// 
			// mod_input
			// 
			this.mod_input.AllowDrop = true;
			this.mod_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mod_input.Location = new System.Drawing.Point(124, 74);
			this.mod_input.Name = "mod_input";
			this.mod_input.Size = new System.Drawing.Size(350, 20);
			this.mod_input.TabIndex = 14;
			this.mod_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.game_input_DragDrop);
			this.mod_input.DragEnter += new System.Windows.Forms.DragEventHandler(this.game_input_DragEnter);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Mod files folder:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// CreateProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(584, 230);
			this.Controls.Add(this.mod_browse);
			this.Controls.Add(this.mod_input);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.profile_browse);
			this.Controls.Add(this.profile_input);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.create_profile_confirm);
			this.Controls.Add(this.backup_browse);
			this.Controls.Add(this.game_browse);
			this.Controls.Add(this.backup_input);
			this.Controls.Add(this.game_input);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name_input);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CreateProfileForm";
			this.Text = "Create Profile";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox name_input;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox game_input;
		private System.Windows.Forms.TextBox backup_input;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
		private System.Windows.Forms.Button game_browse;
		private System.Windows.Forms.Button backup_browse;
		private System.Windows.Forms.Button create_profile_confirm;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox profile_input;
		private System.Windows.Forms.Button profile_browse;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
		private System.Windows.Forms.Button mod_browse;
		private System.Windows.Forms.TextBox mod_input;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}
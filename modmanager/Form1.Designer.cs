﻿namespace modmanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutThisProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modPackagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPackageToProfileFromTNTArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPackageToProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePackageFromProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.makeTNTArchiveFromJSONManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSelectedPackageInEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_profile_dialog = new System.Windows.Forms.OpenFileDialog();
            this.profile_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disabled_package_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enable_selected_button = new System.Windows.Forms.Button();
            this.disable_selected_button = new System.Windows.Forms.Button();
            this.enabled_package_list = new System.Windows.Forms.ListBox();
            this.disable_all_button = new System.Windows.Forms.Button();
            this.enable_all_button = new System.Windows.Forms.Button();
            this.selected_package_name_label = new System.Windows.Forms.Label();
            this.selected_package_author_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selected_package_description = new System.Windows.Forms.TextBox();
            this.open_manifest_dialog = new System.Windows.Forms.OpenFileDialog();
            this.open_tnt_dialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.modPackagesToolStripMenuItem1,
            this.modPackagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1259, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProfileToolStripMenuItem,
            this.loadProfileToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutThisProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // createProfileToolStripMenuItem
            // 
            this.createProfileToolStripMenuItem.Name = "createProfileToolStripMenuItem";
            this.createProfileToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.createProfileToolStripMenuItem.Text = "Create profile";
            this.createProfileToolStripMenuItem.Click += new System.EventHandler(this.createProfileToolStripMenuItem_Click);
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.loadProfileToolStripMenuItem.Text = "Load profile";
            this.loadProfileToolStripMenuItem.Click += new System.EventHandler(this.loadProfileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // aboutThisProfileToolStripMenuItem
            // 
            this.aboutThisProfileToolStripMenuItem.Name = "aboutThisProfileToolStripMenuItem";
            this.aboutThisProfileToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.aboutThisProfileToolStripMenuItem.Text = "About this profile";
            this.aboutThisProfileToolStripMenuItem.Click += new System.EventHandler(this.aboutThisProfileToolStripMenuItem_Click);
            // 
            // modPackagesToolStripMenuItem1
            // 
            this.modPackagesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPackageToProfileFromTNTArchiveToolStripMenuItem,
            this.addPackageToProfileToolStripMenuItem,
            this.removePackageFromProfileToolStripMenuItem,
            this.toolStripSeparator2,
            this.makeTNTArchiveFromJSONManifestToolStripMenuItem});
            this.modPackagesToolStripMenuItem1.Name = "modPackagesToolStripMenuItem1";
            this.modPackagesToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.modPackagesToolStripMenuItem1.Text = "Mod Packages";
            // 
            // addPackageToProfileFromTNTArchiveToolStripMenuItem
            // 
            this.addPackageToProfileFromTNTArchiveToolStripMenuItem.Name = "addPackageToProfileFromTNTArchiveToolStripMenuItem";
            this.addPackageToProfileFromTNTArchiveToolStripMenuItem.Size = new System.Drawing.Size(385, 26);
            this.addPackageToProfileFromTNTArchiveToolStripMenuItem.Text = "Add Package To Profile (From .TNT Archive)";
            this.addPackageToProfileFromTNTArchiveToolStripMenuItem.Click += new System.EventHandler(this.addPackageToProfileFromTNTArchiveToolStripMenuItem_Click);
            // 
            // addPackageToProfileToolStripMenuItem
            // 
            this.addPackageToProfileToolStripMenuItem.Name = "addPackageToProfileToolStripMenuItem";
            this.addPackageToProfileToolStripMenuItem.Size = new System.Drawing.Size(385, 26);
            this.addPackageToProfileToolStripMenuItem.Text = "Add Package To Profile (From JSON Manifest)";
            this.addPackageToProfileToolStripMenuItem.Click += new System.EventHandler(this.addPackageToProfileToolStripMenuItem_Click);
            // 
            // removePackageFromProfileToolStripMenuItem
            // 
            this.removePackageFromProfileToolStripMenuItem.Name = "removePackageFromProfileToolStripMenuItem";
            this.removePackageFromProfileToolStripMenuItem.Size = new System.Drawing.Size(385, 26);
            this.removePackageFromProfileToolStripMenuItem.Text = "Remove Selected Package From Profile";
            this.removePackageFromProfileToolStripMenuItem.Click += new System.EventHandler(this.removePackageFromProfileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(382, 6);
            // 
            // makeTNTArchiveFromJSONManifestToolStripMenuItem
            // 
            this.makeTNTArchiveFromJSONManifestToolStripMenuItem.Name = "makeTNTArchiveFromJSONManifestToolStripMenuItem";
            this.makeTNTArchiveFromJSONManifestToolStripMenuItem.Size = new System.Drawing.Size(385, 26);
            this.makeTNTArchiveFromJSONManifestToolStripMenuItem.Text = "Make .TNT Archive From .JSON Manifest";
            this.makeTNTArchiveFromJSONManifestToolStripMenuItem.Click += new System.EventHandler(this.makeTNTArchiveFromJSONManifestToolStripMenuItem_Click);
            // 
            // modPackagesToolStripMenuItem
            // 
            this.modPackagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewPackageToolStripMenuItem,
            this.openSelectedPackageInEditorToolStripMenuItem});
            this.modPackagesToolStripMenuItem.Name = "modPackagesToolStripMenuItem";
            this.modPackagesToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.modPackagesToolStripMenuItem.Text = "Package Editor";
            // 
            // createNewPackageToolStripMenuItem
            // 
            this.createNewPackageToolStripMenuItem.Name = "createNewPackageToolStripMenuItem";
            this.createNewPackageToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.createNewPackageToolStripMenuItem.Text = "Open Mod Package Editor";
            this.createNewPackageToolStripMenuItem.Click += new System.EventHandler(this.createNewPackageToolStripMenuItem_Click);
            // 
            // openSelectedPackageInEditorToolStripMenuItem
            // 
            this.openSelectedPackageInEditorToolStripMenuItem.Name = "openSelectedPackageInEditorToolStripMenuItem";
            this.openSelectedPackageInEditorToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.openSelectedPackageInEditorToolStripMenuItem.Text = "Open Selected Package In Editor";
            this.openSelectedPackageInEditorToolStripMenuItem.Click += new System.EventHandler(this.openSelectedPackageInEditorToolStripMenuItem_Click);
            // 
            // profile_label
            // 
            this.profile_label.AutoSize = true;
            this.profile_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_label.Location = new System.Drawing.Point(16, 42);
            this.profile_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profile_label.Name = "profile_label";
            this.profile_label.Size = new System.Drawing.Size(132, 42);
            this.profile_label.TabIndex = 1;
            this.profile_label.Text = "(none)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disabled mod packages";
            // 
            // disabled_package_list
            // 
            this.disabled_package_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disabled_package_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disabled_package_list.FormattingEnabled = true;
            this.disabled_package_list.ItemHeight = 20;
            this.disabled_package_list.Location = new System.Drawing.Point(29, 117);
            this.disabled_package_list.Margin = new System.Windows.Forms.Padding(4);
            this.disabled_package_list.Name = "disabled_package_list";
            this.disabled_package_list.Size = new System.Drawing.Size(252, 460);
            this.disabled_package_list.TabIndex = 3;
            this.disabled_package_list.SelectedIndexChanged += new System.EventHandler(this.disabled_package_list_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enabled mod packages";
            // 
            // enable_selected_button
            // 
            this.enable_selected_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enable_selected_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enable_selected_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enable_selected_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_selected_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enable_selected_button.Location = new System.Drawing.Point(313, 146);
            this.enable_selected_button.Margin = new System.Windows.Forms.Padding(4);
            this.enable_selected_button.Name = "enable_selected_button";
            this.enable_selected_button.Size = new System.Drawing.Size(81, 60);
            this.enable_selected_button.TabIndex = 6;
            this.enable_selected_button.Text = "›";
            this.enable_selected_button.UseVisualStyleBackColor = false;
            this.enable_selected_button.Click += new System.EventHandler(this.enable_selected_button_Click);
            // 
            // disable_selected_button
            // 
            this.disable_selected_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.disable_selected_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.disable_selected_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disable_selected_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disable_selected_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.disable_selected_button.Location = new System.Drawing.Point(313, 231);
            this.disable_selected_button.Margin = new System.Windows.Forms.Padding(4);
            this.disable_selected_button.Name = "disable_selected_button";
            this.disable_selected_button.Size = new System.Drawing.Size(81, 60);
            this.disable_selected_button.TabIndex = 7;
            this.disable_selected_button.Text = "‹";
            this.disable_selected_button.UseVisualStyleBackColor = false;
            this.disable_selected_button.Click += new System.EventHandler(this.disable_selected_button_Click);
            // 
            // enabled_package_list
            // 
            this.enabled_package_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enabled_package_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabled_package_list.FormattingEnabled = true;
            this.enabled_package_list.ItemHeight = 20;
            this.enabled_package_list.Location = new System.Drawing.Point(427, 117);
            this.enabled_package_list.Margin = new System.Windows.Forms.Padding(4);
            this.enabled_package_list.Name = "enabled_package_list";
            this.enabled_package_list.Size = new System.Drawing.Size(249, 460);
            this.enabled_package_list.TabIndex = 8;
            this.enabled_package_list.SelectedIndexChanged += new System.EventHandler(this.enabled_package_list_SelectedIndexChanged);
            // 
            // disable_all_button
            // 
            this.disable_all_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.disable_all_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.disable_all_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disable_all_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disable_all_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.disable_all_button.Location = new System.Drawing.Point(313, 455);
            this.disable_all_button.Margin = new System.Windows.Forms.Padding(4);
            this.disable_all_button.Name = "disable_all_button";
            this.disable_all_button.Size = new System.Drawing.Size(81, 60);
            this.disable_all_button.TabIndex = 10;
            this.disable_all_button.Text = "‹‹";
            this.disable_all_button.UseVisualStyleBackColor = false;
            this.disable_all_button.Click += new System.EventHandler(this.disable_all_button_Click);
            // 
            // enable_all_button
            // 
            this.enable_all_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enable_all_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enable_all_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enable_all_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_all_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enable_all_button.Location = new System.Drawing.Point(313, 370);
            this.enable_all_button.Margin = new System.Windows.Forms.Padding(4);
            this.enable_all_button.Name = "enable_all_button";
            this.enable_all_button.Size = new System.Drawing.Size(81, 60);
            this.enable_all_button.TabIndex = 9;
            this.enable_all_button.Text = "››";
            this.enable_all_button.UseVisualStyleBackColor = false;
            this.enable_all_button.Click += new System.EventHandler(this.enable_all_button_Click);
            // 
            // selected_package_name_label
            // 
            this.selected_package_name_label.AutoSize = true;
            this.selected_package_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_package_name_label.Location = new System.Drawing.Point(735, 52);
            this.selected_package_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selected_package_name_label.Name = "selected_package_name_label";
            this.selected_package_name_label.Size = new System.Drawing.Size(302, 31);
            this.selected_package_name_label.TabIndex = 11;
            this.selected_package_name_label.Text = "(no package selected)";
            // 
            // selected_package_author_label
            // 
            this.selected_package_author_label.AutoSize = true;
            this.selected_package_author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_package_author_label.Location = new System.Drawing.Point(737, 106);
            this.selected_package_author_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selected_package_author_label.Name = "selected_package_author_label";
            this.selected_package_author_label.Size = new System.Drawing.Size(139, 20);
            this.selected_package_author_label.TabIndex = 12;
            this.selected_package_author_label.Text = "By (author name)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(737, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description:";
            // 
            // selected_package_description
            // 
            this.selected_package_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_package_description.Location = new System.Drawing.Point(741, 170);
            this.selected_package_description.Margin = new System.Windows.Forms.Padding(4);
            this.selected_package_description.Multiline = true;
            this.selected_package_description.Name = "selected_package_description";
            this.selected_package_description.ReadOnly = true;
            this.selected_package_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selected_package_description.Size = new System.Drawing.Size(500, 419);
            this.selected_package_description.TabIndex = 14;
            // 
            // open_manifest_dialog
            // 
            this.open_manifest_dialog.FileName = "package.json";
            // 
            // open_tnt_dialog
            // 
            this.open_tnt_dialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1259, 617);
            this.Controls.Add(this.selected_package_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selected_package_author_label);
            this.Controls.Add(this.selected_package_name_label);
            this.Controls.Add(this.disable_all_button);
            this.Controls.Add(this.enable_all_button);
            this.Controls.Add(this.enabled_package_list);
            this.Controls.Add(this.disable_selected_button);
            this.Controls.Add(this.enable_selected_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disabled_package_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profile_label);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mod Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog open_profile_dialog;
		private System.Windows.Forms.Label profile_label;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem aboutThisProfileToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox disabled_package_list;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button enable_selected_button;
		private System.Windows.Forms.Button disable_selected_button;
		private System.Windows.Forms.ListBox enabled_package_list;
		private System.Windows.Forms.Button disable_all_button;
		private System.Windows.Forms.Button enable_all_button;
		private System.Windows.Forms.Label selected_package_name_label;
		private System.Windows.Forms.Label selected_package_author_label;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox selected_package_description;
		private System.Windows.Forms.ToolStripMenuItem modPackagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createNewPackageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openSelectedPackageInEditorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modPackagesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem addPackageToProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removePackageFromProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem makeTNTArchiveFromJSONManifestToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog open_manifest_dialog;
		private System.Windows.Forms.ToolStripMenuItem addPackageToProfileFromTNTArchiveToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog open_tnt_dialog;
	}
}


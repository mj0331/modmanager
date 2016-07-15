namespace modmanager
{
    partial class ModEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModEditor));
			this.label1 = new System.Windows.Forms.Label();
			this.modded_path = new System.Windows.Forms.TextBox();
			this.modded_browse = new System.Windows.Forms.Button();
			this.target_browse = new System.Windows.Forms.Button();
			this.target_path = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mod_confirm = new System.Windows.Forms.Button();
			this.moddedFile = new System.Windows.Forms.OpenFileDialog();
			this.targetFile = new System.Windows.Forms.OpenFileDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modded file:";
			// 
			// modded_path
			// 
			this.modded_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.modded_path.Location = new System.Drawing.Point(101, 12);
			this.modded_path.Name = "modded_path";
			this.modded_path.Size = new System.Drawing.Size(373, 20);
			this.modded_path.TabIndex = 1;
			// 
			// modded_browse
			// 
			this.modded_browse.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.modded_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modded_browse.ForeColor = System.Drawing.SystemColors.Control;
			this.modded_browse.Location = new System.Drawing.Point(480, 10);
			this.modded_browse.Name = "modded_browse";
			this.modded_browse.Size = new System.Drawing.Size(91, 23);
			this.modded_browse.TabIndex = 2;
			this.modded_browse.Text = "Browse";
			this.modded_browse.UseVisualStyleBackColor = true;
			this.modded_browse.Click += new System.EventHandler(this.modded_browse_Click);
			// 
			// target_browse
			// 
			this.target_browse.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.target_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.target_browse.ForeColor = System.Drawing.SystemColors.Control;
			this.target_browse.Location = new System.Drawing.Point(480, 44);
			this.target_browse.Name = "target_browse";
			this.target_browse.Size = new System.Drawing.Size(91, 23);
			this.target_browse.TabIndex = 5;
			this.target_browse.Text = "Browse";
			this.target_browse.UseVisualStyleBackColor = true;
			this.target_browse.Click += new System.EventHandler(this.target_browse_Click);
			// 
			// target_path
			// 
			this.target_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.target_path.Location = new System.Drawing.Point(101, 47);
			this.target_path.Name = "target_path";
			this.target_path.Size = new System.Drawing.Size(373, 20);
			this.target_path.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Target file:";
			// 
			// mod_confirm
			// 
			this.mod_confirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.mod_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mod_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mod_confirm.ForeColor = System.Drawing.SystemColors.Control;
			this.mod_confirm.Location = new System.Drawing.Point(15, 114);
			this.mod_confirm.Name = "mod_confirm";
			this.mod_confirm.Size = new System.Drawing.Size(556, 35);
			this.mod_confirm.TabIndex = 6;
			this.mod_confirm.Text = "Confirm";
			this.mod_confirm.UseVisualStyleBackColor = true;
			this.mod_confirm.Click += new System.EventHandler(this.mod_confirm_Click);
			// 
			// moddedFile
			// 
			this.moddedFile.FileName = "openFileDialog1";
			// 
			// targetFile
			// 
			this.targetFile.FileName = "openFileDialog2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(12, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Mod type:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Replacement",
            "Addition"});
			this.comboBox1.Location = new System.Drawing.Point(101, 81);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// ModEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(584, 161);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.mod_confirm);
			this.Controls.Add(this.target_browse);
			this.Controls.Add(this.target_path);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.modded_browse);
			this.Controls.Add(this.modded_path);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ModEditor";
			this.Text = "Mod Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modded_path;
        private System.Windows.Forms.Button modded_browse;
        private System.Windows.Forms.Button target_browse;
        private System.Windows.Forms.TextBox target_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mod_confirm;
        private System.Windows.Forms.OpenFileDialog moddedFile;
        private System.Windows.Forms.OpenFileDialog targetFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
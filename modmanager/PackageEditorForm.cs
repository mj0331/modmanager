﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace modmanager
{
    public partial class PackageEditorForm : Form
    {
        ModPackage Target;

        public PackageEditorForm()
        {
            InitializeComponent();
        }

        public PackageEditorForm(ModPackage p)
        {
            InitializeComponent();
            Target = p;
            UpdateDisplayData();
        }

        private void InitializeDialogs()
        {
            folderBrowserDialog1.Description = "Select a folder for the manifes file. That folder will be the root for the modded files' paths!";
            saveFileDialog1.Filter = "Package Manifest File (package.json)|package.json";
            saveFileDialog1.CheckFileExists = true;
        }

        public void UpdateDisplayData()
        {
            name_input.Text = Target.Name;
            author_input.Text = Target.Author;
            description_input.Text = Target.Description;
        }

        private void loadPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void edit_mod_button_Click(object sender, EventArgs e)
        {
           
        }

        private void savePackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string file_path = Path.Combine(folderBrowserDialog1.SelectedPath, "package.json");
                Target.WriteJSON(file_path);
                MessageBox.Show("Created package manifest at:\n" + file_path);
            }
        }
    }
}

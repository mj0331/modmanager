﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modmanager
{
    public partial class ModEditor : Form
    {
        ModPackage TargetPack;
        Mod ActiveMod;
        bool IsNew;

        public ModEditor(ModPackage pack)
        {
            InitializeComponent();
            ActiveMod = new Mod("", "");
            TargetPack = pack;
            IsNew = true;
            targetFile.InitialDirectory = Form1.ActiveProfile.GamePath;
        }

        public ModEditor(ModPackage pack, Mod m)
        {
            InitializeComponent();
            ActiveMod = m;
            TargetPack = pack;
            IsNew = false;
            targetFile.InitialDirectory = Form1.ActiveProfile.GamePath;
        }

        private void modded_browse_Click(object sender, EventArgs e)
        {
            if(moddedFile.ShowDialog() == DialogResult.OK)
            {
                modded_path.Text = moddedFile.FileName;
                ActiveMod.ModdedFile = moddedFile.FileName;
            }
        }

        private void target_browse_Click(object sender, EventArgs e)
        {
            if(targetFile.ShowDialog() == DialogResult.OK)
            {
                target_path.Text = targetFile.FileName;
                ActiveMod.TargetFile = targetFile.FileName;
            }
        }

        public Mod GetRawData()
        {
            if(ActiveMod.TargetFile == "" || ActiveMod.ModdedFile == "")
            {
                MessageBox.Show("One or more fields is empty!", "Error");
                return null;
            }
            else
            {
                return ActiveMod;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedText)
            {
                case "Replacement":
                    ActiveMod.ModType = Mod.Type.Replacement;
                    break;
                case "Addition":
                    ActiveMod.ModType = Mod.Type.Addition;
                    break;
                default:
                    break;
            }
        }

        private void mod_confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}

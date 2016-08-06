using System;
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
	public partial class ModEditor : Form
	{
		ModPackage TargetPack;
		Mod ActiveMod;

		public ModEditor(ModPackage pack)
		{
			InitializeComponent();
			ActiveMod = new Mod("", "");
			TargetPack = pack;
			targetFile.InitialDirectory = Form1.ActiveProfile.GamePath;
			UpdateDisplayData();
		}

		public ModEditor(ModPackage pack, Mod m)
		{
			InitializeComponent();
			ActiveMod = m;
			TargetPack = pack;
			targetFile.InitialDirectory = Form1.ActiveProfile.GamePath;
			UpdateDisplayData();
		}

		public void UpdateDisplayData()
		{
			modded_path.Text = ActiveMod.ModdedFile;
			target_path.Text = ActiveMod.TargetFile;
			comboBox1.SelectedIndex = (int)ActiveMod.ModType;
		}

		private void modded_browse_Click(object sender, EventArgs e)
		{
			if(moddedFile.ShowDialog() == DialogResult.OK)
			{
				modded_path.Text = moddedFile.FileName.TrimStart('\\');
				ActiveMod.ModdedFile = moddedFile.FileName.TrimStart('\\');
			}
		}

		private void target_browse_Click(object sender, EventArgs e)
		{
			if(targetFile.ShowDialog() == DialogResult.OK)
			{
				target_path.Text = targetFile.FileName.TrimStart('\\');
				ActiveMod.TargetFile = targetFile.FileName.TrimStart('\\');
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
			switch(comboBox1.SelectedItem.ToString())
			{
				case "Replacement":
					ActiveMod.ModType = Mod.Type.Replacement;
					string filename = Path.GetFileName(target_path.Text);
					if (!File.Exists(filename) && Directory.Exists(Path.Combine(Form1.ActiveProfile.GamePath, target_path.Text)))
					{
						ActiveMod.TargetFile = Path.Combine(target_path.Text, Path.GetFileName(modded_path.Text));
						target_path.Text = ActiveMod.TargetFile;
					}

					break;
				case "Addition":
					ActiveMod.ModType = Mod.Type.Addition;
					string target_file_path = Path.Combine(Form1.ActiveProfile.GamePath, target_path.Text);
					string ext = Path.GetExtension(target_file_path);

					if	(ext != string.Empty )
					{
						ActiveMod.TargetFile = Utils.GetLastDirectory(ActiveMod.TargetFile);
						target_path.Text = ActiveMod.TargetFile;
					}
					break;
				default:
					break;
			}
		}

		private void mod_confirm_Click(object sender, EventArgs e)
		{
			ActiveMod.TargetFile = target_path.Text;
			ActiveMod.ModdedFile = modded_path.Text;

			DialogResult = DialogResult.OK;
			Hide();
		}

		private void modded_path_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			if(files != null)
			{
				modded_path.Text = files[0];
				ActiveMod.ModdedFile = modded_path.Text;
			}
			
		}

		private void modded_path_DragEnter(object sender, DragEventArgs e)
		{
			if(e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void target_path_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void target_path_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (files != null)
			{
				target_path.Text = files[0];
				ActiveMod.TargetFile = target_path.Text;
			}
		}
	}
}

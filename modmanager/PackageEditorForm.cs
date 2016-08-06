using System;
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
			Target = new ModPackage("", "", "");
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

			UpdateModList();
		}

		public void UpdateTarget()
		{
			Target.Name = name_input.Text;
			Target.Author = author_input.Text;
			Target.Description = description_input.Text;

			Form1.UpdateProfileFile();
		}

		public void UpdateModList()
		{
			mod_list.Items.Clear();

			for(int i = 0; i < Target.ModCount; i++)
			{
				string display_string = Target.Mods[i].TargetFile;
				
				//If this is an Addition mod, also add the modded filename at the end
				if(Target.Mods[i].ModType == Mod.Type.Addition)
				{
					string fname = Utils.GetRelativePath(Target.Mods[i].ModdedFile, Utils.GetLastDirectory(Target.Mods[i].ModdedFile));
					display_string += "(" + fname + ")";
				}

				mod_list.Items.Add(display_string);
			}
		}

		private void loadPackageToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void edit_mod_button_Click(object sender, EventArgs e)
		{
		   	if(mod_list.SelectedItem != null)
			{
				string target = mod_list.SelectedItem.ToString();
				int index = target.IndexOf('(');

				//If the display string also contains the file name in between brackets(as it is the case for addition mods)
				if(index >= 0)
				{
					//Cut off the file name and brackets
					target = target.Substring(0, (index));
				}
				
				Mod t = Target.FindByTarget(target);
				
				if(t != null)
				{
					ModEditor modedit = new ModEditor(Target, t);
					if (modedit.ShowDialog() == DialogResult.OK)
					{
						Mod m = modedit.GetRawData();

						m.TargetFile = Utils.GetRelativePath(m.TargetFile, Form1.ActiveProfile.GamePath);

						Target.ReplaceMod(mod_list.SelectedItem.ToString(), m);
						UpdateTarget();
						UpdateDisplayData();
					}
				}
			}
		}

		private void savePackageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
				{
					UpdateTarget();
					string file_dir = folderBrowserDialog1.SelectedPath;
					string file_path = Path.Combine(file_dir, "package.json");

					//Update mod file paths to be relative to the manifest
					for (int i = 0; i < Target.ModCount; i++)
					{
						string rel_mod_path = Utils.GetRelativePath(Target.Mods[i].ModdedFile, file_dir);

						Target.Mods[i].ModdedFile = rel_mod_path;
					}

					Target.WriteJSON(file_path);
					MessageBox.Show("Created package manifest at:\n" + file_path);
				}
			}
			catch(Exception err)
			{
				MessageBox.Show("Error saving file:\n\n" + err.Message);
			}
			
		}

		private void savePackageExistingManifestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					UpdateTarget();

					string file_dir = Utils.GetLastDirectory(saveFileDialog1.FileName);
					//Update mod file paths to be relative to the manifest
					for (int i = 0; i < Target.ModCount; i++)
					{
						string rel_mod_path = Utils.GetRelativePath(Target.Mods[i].ModdedFile, file_dir);

						Target.Mods[i].ModdedFile = rel_mod_path;
					}

					Target.WriteJSON(saveFileDialog1.FileName);
					MessageBox.Show("Saved package manifest at:\n" + saveFileDialog1.FileName);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show("Error saving file:\n\n" + err.Message);
			}
			
		}

		private void new_mod_button_Click(object sender, EventArgs e)
		{
			ModEditor modedit = new ModEditor(Target);
			if(modedit.ShowDialog() == DialogResult.OK)
			{
				Mod m = modedit.GetRawData();

				m.TargetFile = Utils.GetRelativePath(m.TargetFile, Form1.ActiveProfile.GamePath);

				Target.AddMod(m);
				UpdateTarget();
				UpdateDisplayData();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (mod_list.SelectedItem != null)
			{
				Mod m = Target.FindByTarget(mod_list.SelectedItem.ToString());

				if(m != null)
				{
					Target.DeleteMod(m);
					UpdateTarget();
					UpdateDisplayData();
				}
			}
		}

		private void newPackageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Target = new ModPackage("", "", "");
			UpdateDisplayData();
		}

		private void loadPackageToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				if(openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					Target = ModPackage.FromJSON(openFileDialog1.FileName);

					if(Target.Name == null)
					{
						throw new Exception("Cannot create ModPackage object from the selected file. Make sure you select a vaild package manifest!");
					}

					UpdateDisplayData();
				}
			}
			catch(Exception err)
			{
				MessageBox.Show("Error opening file:\n\n" + err.Message);
			}
		}
	}
}

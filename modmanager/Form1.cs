using System;
using System.Windows.Forms;
using System.IO;

namespace modmanager
{
	public partial class Form1 : Form
	{
		public static Profile ActiveProfile;
		private static string PathToActiveProfile;

		private ModPackage SelectedPackage;

		public Form1()
		{
			InitializeComponent();
			InitModManager();
		}

		private void InitModManager()
		{
			ActiveProfile = new Profile("", "", "", "");

			this.Text = "Mod Manager - (no profile loaded)";
			open_profile_dialog.CheckFileExists = true;
			open_profile_dialog.CheckPathExists = true;
			open_profile_dialog.Filter = "JSON Files|*.json";
		}

		private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CreateProfileForm create_profile_form = new CreateProfileForm();
			create_profile_form.Show();
		}

		public void UpdatePackageInfo(ModPackage pack)
		{
			selected_package_name_label.Text = pack.Name;
			selected_package_author_label.Text = "By " + pack.Author;
			selected_package_description.Text = pack.Description;
		}

		public void UpdatePackageLists()
		{
			enabled_package_list.Items.Clear();
			disabled_package_list.Items.Clear();

			for (int i = 0; i < ActiveProfile.PackageCount; i++)
			{
				if (ActiveProfile.Packages[i].IsInstalled)
				{
					enabled_package_list.Items.Add(ActiveProfile.Packages[i].Name);
				}
				else
				{
					disabled_package_list.Items.Add(ActiveProfile.Packages[i].Name);
				}
			}
		}

		public static void UpdateProfileFile()
		{
			ActiveProfile.WriteJSON(PathToActiveProfile);
		}

		public void RefreshActiveProfileFromJSON()
		{
			UpdateActiveProfile(Profile.ReadJSON(PathToActiveProfile));
		}

		public void UpdateActiveProfile(Profile p)
		{
			ActiveProfile = p;
			

			this.Text = "Mod Manager - " + p.GameName;
			profile_label.Text = p.GameName;

			UpdatePackageLists();
			UpdateProfileFile();
		}

		public bool IsProfileLoaded()
		{
			if(ActiveProfile.GameName == "")
			{
				MessageBox.Show("No profile loaded!", "Error");
				return false;
			}

			return true;
		}

		private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			open_profile_dialog.ShowDialog();
			Stream s = open_profile_dialog.OpenFile();
			StreamReader sr = new StreamReader(s);
			Profile p = Profile.FromJSON(sr.ReadToEnd());
			sr.Close();
			s.Close();

			PathToActiveProfile = Path.GetDirectoryName(open_profile_dialog.FileName);
			UpdateActiveProfile(p);
		}

		private void aboutThisProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("About this profile: \n\n" + ActiveProfile.About());
		}

		private void SetSelectedPackage(ModPackage p)
		{
			SelectedPackage = p;
			UpdatePackageInfo(SelectedPackage);
		}

		private void disabled_package_list_SelectedIndexChanged(object sender, EventArgs e)
		{
			disabled_package_list.Select();
			if(disabled_package_list.SelectedItem != null)
			{
				SetSelectedPackage(ActiveProfile.Search(disabled_package_list.SelectedItem.ToString()));
			}
		}

		private void enabled_package_list_SelectedIndexChanged(object sender, EventArgs e)
		{
			enabled_package_list.Select();
			if(enabled_package_list.SelectedItem != null)
			{
				SetSelectedPackage(ActiveProfile.Search(enabled_package_list.SelectedItem.ToString()));
			}
		}



		private void enable_selected_button_Click(object sender, EventArgs e)
		{
			if (disabled_package_list.SelectedItem != null)
			{
				ModPackage pack = ActiveProfile.Search(disabled_package_list.SelectedItem.ToString());
				if(pack == null)
				{
					MessageBox.Show("Cannot find mod package '" + disabled_package_list.SelectedItem + "'!");
				}
				else
				{
					//Install each mod in the mod package
					for(int i = 0; i < pack.ModCount; i++)
					{
						pack.Mods[i].Install(ActiveProfile, pack);
					}

					//Update the profile after install is done
					pack.IsInstalled = true;
					ActiveProfile.Packages[ActiveProfile.FindPackageIndex(pack)] = pack;
					ActiveProfile.WriteJSON(PathToActiveProfile);
					UpdatePackageLists();
				}
			}           
		}

		private void disable_selected_button_Click(object sender, EventArgs e)
		{
			if(enabled_package_list.SelectedItem != null)
			{
				ModPackage pack = ActiveProfile.Search(enabled_package_list.SelectedItem.ToString());
				if (pack == null)
				{
					MessageBox.Show("Cannot find mod package '" + enabled_package_list.SelectedItem + "'!");
				}
				else
				{
					//Uninstall each mod in the mod package
					for (int i = 0; i < pack.ModCount; i++)
					{
						pack.Mods[i].Uninstall(ActiveProfile, pack);
					}

					//Update the profile after uninstall is done
					pack.IsInstalled = false;
					ActiveProfile.Packages[ActiveProfile.FindPackageIndex(pack)] = pack;
					ActiveProfile.WriteJSON(PathToActiveProfile);
					UpdatePackageLists();
				}
			}  
		}



		private void enable_all_button_Click(object sender, EventArgs e)
		{
			ModPackage pack;

			for (int i = 0; i < ActiveProfile.PackageCount; i++)
			{
				pack = ActiveProfile.Packages[i];
				pack.Install(ActiveProfile);
			}

			UpdatePackageLists();
		}

		private void disable_all_button_Click(object sender, EventArgs e)
		{
			ModPackage pack;

			for (int i = 0; i < ActiveProfile.PackageCount; i++)
			{
				pack = ActiveProfile.Packages[i];
				pack.Uninstall(ActiveProfile);
			}

			UpdatePackageLists();
		}

		private void createNewPackageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(IsProfileLoaded())
			{
				PackageEditorForm PackageEditor = new PackageEditorForm();
				PackageEditor.ShowDialog();
				RefreshActiveProfileFromJSON();
			}
		}

		private void openSelectedPackageInEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(IsProfileLoaded())
			{
				if(SelectedPackage == null || SelectedPackage.Name == "")
				{
					MessageBox.Show("Please select a package to open!", "Error");
				}
				else
				{
					PackageEditorForm PackageEditor = new PackageEditorForm(SelectedPackage);
					PackageEditor.Show();
				}               
			}
		}

		private void addPackageToProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(IsProfileLoaded())
			{
				if(open_profile_dialog.ShowDialog() == DialogResult.OK)
				{
					ModPackage pack = ModPackage.FromJSON(open_profile_dialog.FileName);
					if (pack == null)
					{
						MessageBox.Show("Error creating ModPackage object from file!", "Error");
					}
					else
					{
						if (ActiveProfile.HasDuplicate(pack))
						{
							MessageBox.Show("The mod you are trying to add to your profile is already added!");
						}
						else
						{
							pack.IsInstalled = false;
							pack.BackupIfNeeded(ActiveProfile);
							ActiveProfile.AddPackage(pack);
							UpdateActiveProfile(ActiveProfile);
						}
					}
				}
			}
		}

		private void removePackageFromProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(IsProfileLoaded())
			{
				if(SelectedPackage != null || SelectedPackage.Name != "")
				{
					ActiveProfile.RemovePackage(SelectedPackage);
					UpdateActiveProfile(ActiveProfile);
				}
			}
		}

		private void makeTNTArchiveFromJSONManifestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(open_manifest_dialog.ShowDialog() == DialogResult.OK)
			{
				Utils.MakeTNTArchiveFromManifest(open_manifest_dialog.FileName);
				MessageBox.Show("Created archive at:\n" + Utils.GetLastDirectory(Utils.GetLastDirectory(open_manifest_dialog.FileName)));
			}
		}

		private void addPackageToProfileFromTNTArchiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(IsProfileLoaded())
			{
				if (open_tnt_dialog.ShowDialog() == DialogResult.OK)
				{
					ModPackage pack = Utils.ExtractTNTArchive(open_tnt_dialog.FileName, ActiveProfile);

					if(pack == null)
					{
						MessageBox.Show("Error creating ModPackage from TNT archive!");
					}
					else
					{
						if(ActiveProfile.HasDuplicate(pack))
						{
							MessageBox.Show("The mod you are trying to add to your profile is already added!");
						}
						else
						{
							pack.IsInstalled = false;
							pack.BackupIfNeeded(ActiveProfile);
							ActiveProfile.AddPackage(pack);
							UpdateActiveProfile(ActiveProfile);
						}
					}
				}
			}			
		}
	}
}

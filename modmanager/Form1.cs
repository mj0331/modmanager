﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Drawing;

[assembly: AssemblyVersion("0.6.*")]
namespace modmanager
{

	public partial class Form1 : Form
	{
		public static Profile ActiveProfile;
		private static string PathToActiveProfile;
		public static string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		private ModPackage SelectedPackage;

		public Form1()
		{
			InitializeComponent();
			InitModManager();
		}

		private void InitModManager()
		{
			ActiveProfile = new Profile();

			menuStrip1.Renderer = new MenuRenderer();

			this.Text = "Mod Manager - (no profile loaded)";
			open_profile_dialog.CheckFileExists = true;
			open_profile_dialog.CheckPathExists = true;
			open_profile_dialog.Filter = "JSON Files|*.json";

			//Reload last profile from file if possible
			if(File.Exists("lastsession"))
			{
				string session_path = File.ReadAllText("lastsession");
				if(session_path != null || session_path != "")
				{
					Profile p = Profile.ReadJSON(session_path);
					PathToActiveProfile = Utils.GetLastDirectory(session_path);
					UpdateActiveProfile(p);
				}
			}
		}

		private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CreateProfileForm create_profile_form = new CreateProfileForm();
				if (create_profile_form.ShowDialog() == DialogResult.OK)
				{
					Profile NewProfile = create_profile_form.CreatedProfile;
					PathToActiveProfile = create_profile_form.CreatedProfilePath;

					UpdateActiveProfile(NewProfile);

					//Save profile path so it can be automatically loaded next time the mod manager starts
					File.WriteAllText("lastsession", Path.Combine(PathToActiveProfile, NewProfile.GameName + ".json"));
				}
			}catch(Exception err)
			{
				MessageBox.Show("Error creating profile:\n" + err.Message);
			}
			
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
			UpdateActiveProfile(Profile.ReadJSON(Path.Combine(PathToActiveProfile, ActiveProfile.GameName + ".json")));
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
			if(ActiveProfile.GameName == "" || ActiveProfile.GameName == null)
			{
				MessageBox.Show("No profile loaded!", "Error");
				return false;
			}

			return true;
		}

		private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (open_profile_dialog.ShowDialog() == DialogResult.OK)
				{
					Stream s = open_profile_dialog.OpenFile();
					StreamReader sr = new StreamReader(s);
					string contents = sr.ReadToEnd();
					Profile p = Profile.FromJSON(contents);
					sr.Close();
					s.Close();

					if(p.GameName == null)
					{
						throw new Exception("Invalid profile file!");
					}

					PathToActiveProfile = Path.GetDirectoryName(open_profile_dialog.FileName);

					//Save profile path so it can be automatically loaded next time the mod manager starts
					File.WriteAllText("lastsession", Path.Combine(PathToActiveProfile, p.GameName + ".json"));

					UpdateActiveProfile(p);
				}
			}catch(Exception err)
			{
				MessageBox.Show("Error opening profile file:\n\n" + err.Message);
			}
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
					//Check for conflicts
					string conflicting_mod;
					if(ActiveProfile.IsConflictingWithInstalled(pack, out conflicting_mod))
					{
						MessageBox.Show("This mod is conflicting with '" + conflicting_mod + "'.If you wish to install this mod, uninstall '" + conflicting_mod + "' first!\nInstallation canceled!");
					}
					else
					{
						//Install each mod in the mod package
						pack.Install(ActiveProfile);

						//Update the profile after install is done
						ActiveProfile.Packages[ActiveProfile.FindPackageIndex(pack)] = pack;
						ActiveProfile.WriteJSON(PathToActiveProfile);
						UpdatePackageLists();
						MessageBox.Show("Done installing '" + pack.Name + "'.");
					}
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
					pack.Uninstall(ActiveProfile);

					//Update the profile after uninstall is done
					ActiveProfile.Packages[ActiveProfile.FindPackageIndex(pack)] = pack;
					ActiveProfile.WriteJSON(PathToActiveProfile);
					UpdatePackageLists();
					MessageBox.Show("Done uninstalling '" + pack.Name + "'.");
				}
			}  
		}



		private void enable_all_button_Click(object sender, EventArgs e)
		{
			ModPackage pack;
			int pack_count = 0;

			for (int i = 0; i < ActiveProfile.PackageCount; i++)
			{
				pack = ActiveProfile.Packages[i];

				if(!pack.IsInstalled)
				{
					pack.Install(ActiveProfile);
					pack_count++;
				}
			}
			ActiveProfile.WriteJSON(PathToActiveProfile);
			UpdatePackageLists();
			MessageBox.Show("Done installing " + pack_count + " packages. " + (ActiveProfile.PackageCount - pack_count) + " already installed.");
		}

		private void disable_all_button_Click(object sender, EventArgs e)
		{

			ModPackage pack;
			int pack_count = 0;

			for (int i = 0; i < ActiveProfile.PackageCount; i++)
			{
				pack = ActiveProfile.Packages[i];

				if (pack.IsInstalled)
				{
					pack.Uninstall(ActiveProfile);
					pack_count++;
				}
			}
			ActiveProfile.WriteJSON(PathToActiveProfile);
			UpdatePackageLists();
			MessageBox.Show("Done uninstalling " + pack_count + " packages. " + (ActiveProfile.PackageCount - pack_count) + " already uninstalled.");
		}

		private void createNewPackageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(IsProfileLoaded())
			{
				PackageEditorForm PackageEditor = new PackageEditorForm();
				if(PackageEditor.ShowDialog() == DialogResult.OK)
				{
					RefreshActiveProfileFromJSON();
				}				
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
					if(MessageBox.Show("Are you sure you want to remove the mod package? This will also delete the mod from the mods folder!", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
					{
						if (!ActiveProfile.RemovePackage(SelectedPackage))
						{
							MessageBox.Show("Something went wrong :(");
						}

						UpdateActiveProfile(ActiveProfile);
					}
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
			try
			{
				if (IsProfileLoaded())
				{
					if (open_tnt_dialog.ShowDialog() == DialogResult.OK)
					{
						ModPackage pack = Utils.ExtractTNTArchive(open_tnt_dialog.FileName, ActiveProfile);

						if (pack == null)
						{
							throw new Exception("Error creating ModPackage from TNT archive!");
						}
						else
						{
							if (ActiveProfile.HasDuplicate(pack))
							{
								throw new Exception("The mod you are trying to add to your profile is already added!");
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
			catch(Exception err)
			{
				MessageBox.Show("Error adding mod to profile: \n\n" + err.Message);
			}		
		}

		private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!IsProfileLoaded())
			{
				return;
			}

			ProcessStartInfo proc = new ProcessStartInfo();
			proc.WorkingDirectory = ActiveProfile.GamePath;
			proc.FileName = Path.Combine(ActiveProfile.GamePath, ActiveProfile.ExecutableName);

			Process.Start(proc);			
		}

		private void startNoModsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(!IsProfileLoaded())
			{
				return;
			}

			//Create a profile backup to be restored after the game exits
			Profile temp = ActiveProfile;

			//Disable any enabled mod
			for(int i = 0; i < ActiveProfile.PackageCount; i++)
			{
				if(ActiveProfile.Packages[i].IsInstalled)
				{
					ActiveProfile.Packages[i].Uninstall(ActiveProfile, false);
				}
			}

			//Set up the game process
			ProcessStartInfo proc = new ProcessStartInfo();
			proc.WorkingDirectory = ActiveProfile.GamePath;
			proc.FileName = Path.Combine(ActiveProfile.GamePath, ActiveProfile.ExecutableName);

			using (Process p = Process.Start(proc))
			{
				p.WaitForExit();

				//After the game is over, restore the old profile
				ActiveProfile = temp;

				//Re-enable any previously enabled mod
				for (int i = 0; i < ActiveProfile.PackageCount; i++)
				{
					if (ActiveProfile.Packages[i].IsInstalled)
					{
						ActiveProfile.Packages[i].Install(ActiveProfile);
					}
				}
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string about_msg =	"Mod Manager\n" +
								"Simple mod management utility for Tooth and Tail\n" +
								"version " + Version + "\n\n" +
								"GitHub: https://github.com/mj0331/modmanager";

			MessageBox.Show(about_msg);
		}

		private void openGameFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(!IsProfileLoaded())
			{
				return;
			}

			Process.Start(ActiveProfile.GamePath);
		}
	}
}

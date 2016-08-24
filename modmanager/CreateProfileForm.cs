using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.IO;

namespace modmanager
{
	public partial class CreateProfileForm : Form
	{
		public Profile CreatedProfile;
		public string CreatedProfilePath;
		public string SteamPath;
		public string DefaultGamePath;
		public string DefaultModPath;
		public string DefaultBackupPath;
		public string DefaultProfilePath;

		public CreateProfileForm()
		{
			InitializeComponent();

			//Try and get the Steam install path from registry
			SteamPath = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Valve\\Steam", "SteamExe", null).ToString();

			if(SteamPath == null)
			{
				DialogResult = DialogResult.No;
				return;
			}

			SteamPath = Utils.Capitalize(Path.GetDirectoryName(SteamPath));

			//Default the .exe path to the TnT exe in steamapps
			DefaultGamePath = Path.Combine(SteamPath, "steamapps\\common\\ToothAndTail\\ToothAndTail.exe");
			DefaultModPath = Path.Combine(SteamPath, "steamapps\\common\\TnTModManagerFiles\\mods");
			DefaultBackupPath = Path.Combine(SteamPath, "steamapps\\common\\TnTModManagerFiles\\backup");
			DefaultProfilePath = Path.Combine(SteamPath, "steamapps\\common\\TnTModManagerFiles");

			if (!Directory.Exists(Path.Combine(SteamPath, "steamapps\\common\\TnTModManagerFiles")))
			{
				Directory.CreateDirectory(DefaultProfilePath);
				Directory.CreateDirectory(DefaultBackupPath);
				Directory.CreateDirectory(DefaultModPath);
			}

			name_input.Text = "Tooth And Tail - Default";
			game_input.Text = DefaultGamePath;
			backup_input.Text = DefaultBackupPath;
			mod_input.Text = DefaultModPath;
			profile_input.Text = DefaultProfilePath;

			CreatedProfile = new Profile();
		}

		private void game_browse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if(openFileDialog1.CheckFileExists)
				{
					game_input.Text = openFileDialog1.FileName;
				}
			}		
		}

		private void backup_browse_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
			{
				backup_input.Text = folderBrowserDialog2.SelectedPath;
			}				
		}

		private void profile_browse_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog3.ShowDialog() == DialogResult.OK)
			{
				profile_input.Text = folderBrowserDialog3.SelectedPath;
			}				
		}

		private bool ValidateInput()
		{
			if(name_input.TextLength > 0 &&
				game_input.TextLength > 0 &&
				mod_input.TextLength > 0 &&
				backup_input.TextLength > 0 &&
				profile_input.TextLength > 0)
			{
				return true;
			}

			return false;
		}

		private void CreateProfile()
		{
			try
			{
				Profile p = new Profile(name_input.Text, game_input.Text, mod_input.Text, backup_input.Text);
				CreatedProfile = p;
				CreatedProfilePath = profile_input.Text;
				p.WriteJSON(profile_input.Text);

				MessageBox.Show("Created profile:\n\n" + JsonConvert.SerializeObject(p, Formatting.Indented));
			}
			catch(Exception e)
			{
				MessageBox.Show("Error encountered while creating profile:\n" + e.Message);
			}
			
		}

		private void create_profile_confirm_Click(object sender, EventArgs e)
		{
			if(ValidateInput())
			{
				CreateProfile();
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Cannot create profile! One ore more fields are empty!", "Error");
			}
		}

		private void mod_browse_Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog4.ShowDialog() == DialogResult.OK)
			{
				mod_input.Text = folderBrowserDialog4.SelectedPath;
			}
		}
	}
}

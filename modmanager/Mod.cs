using System;
using System.IO;
using System.Windows.Forms;

namespace modmanager
{
	public class Mod
	{
		public string TargetFile;
		public string ModdedFile;
		public string BackupFile;
		public bool IsInstalled;
		public Type ModType;

		public enum Type
		{
			Replacement = 0,
			Addition
		}

		public Mod(string target, string modded)
		{
			TargetFile = target;
			ModdedFile = modded;
			IsInstalled = false;
		}

		public void SetBackup(Profile p)
		{
			BackupFile = Path.Combine(p.BackupRoot, TargetFile);
		}

		public string GetBackup()
		{
			return BackupFile;
		}

		public void SwapFiles(Profile p)
		{
			string f1_path = Path.Combine(p.BackupRoot, TargetFile);
			string f2_path = ModdedFile;

			File.Create("swap_buffer.temp");
			File.Replace(f1_path, f2_path, "swap_buffer.temp");
			File.Delete("swap_buffer.temp");
		}

		public void Install(Profile p, ModPackage pack)
		{
			switch(ModType)
			{
				case Type.Replacement:
					ReplaceInstall(p, pack);
					break;
				case Type.Addition:
					break;
				default:
					MessageBox.Show("Unknown mod procedure code: " + ModType);
					break;
					
			}
		}

		public void Uninstall(Profile p, ModPackage pack)
		{
			switch (ModType)
			{
				case Type.Replacement:
					ReplaceUninstall(p, pack);
					break;
				case Type.Addition:
					break;
				default:
					MessageBox.Show("Unknown mod procedure code: " + ModType);
					break;

			}
		}

		void ReplaceInstall(Profile p, ModPackage pack)
		{
			string target = Path.Combine(p.GamePath, TargetFile);
			string mod = Path.Combine(p.ModPath, pack.Name, ModdedFile);

			try
			{
				File.Copy(mod, target, true);
			}
			catch(Exception e)
			{
				MessageBox.Show("Error copying modded file into the game files!\n\nFROM:" + mod + "\nTO:" + target + "\n\n" + e.Message);
			}
		}

		void ReplaceUninstall(Profile p, ModPackage pack)
		{
			string target = Path.Combine(p.GamePath, TargetFile);
			string backup = Path.Combine(p.BackupRoot, BackupFile);

			try
			{
				File.Copy(backup, target, true);
			}
			catch (Exception e)
			{
				MessageBox.Show("Error copying backup file into the game files!\n\nFROM:" + backup + "\nTO:" + target + "\n\n" + e.Message);
			}
		}
	}
}


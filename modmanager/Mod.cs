using System;
using System.IO;

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
	}
}


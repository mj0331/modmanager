using System;
using System.IO;
using Newtonsoft.Json;

namespace modmanager
{
	public class Profile
	{
		const int LatestFileFormatVersion = 1;
		const int MaxPackageCount = 64000;
		const int PackageArraySizeIncrease = 8;

		public string GameName;
		public string GamePath;
		public string BackupRoot;
		public int FileFormatVersion;

		public int PackageCount;
		public ModPackage[] Packages;

		public Profile(string game_name, string game_path, string backup_root, int ff_version = Profile.LatestFileFormatVersion)
		{
			GameName = game_name;
			GamePath = game_path;
			BackupRoot = backup_root;
			FileFormatVersion = ff_version;

			PackageCount = 0;
			Packages = new ModPackage[PackageCount];
			
		}

		public string GetBackupRoot()
		{
			return BackupRoot;
		}

		public void WriteJSON(string profile_file_path)
		{
			string profile_json = JsonConvert.SerializeObject(this, Formatting.Indented);
			string profile_file = Path.Combine(profile_file_path, GameName + ".json");

			File.WriteAllText(profile_file, profile_json);
		}

		public static Profile ReadJSON(string profile_file_path)
		{
			string profile_json = File.ReadAllText(profile_file_path);

			return JsonConvert.DeserializeObject<Profile>(profile_json);
		}

		public static Profile FromJSON(string profile_json)
		{
			return JsonConvert.DeserializeObject<Profile>(profile_json);
		}

		public string About()
		{
			string about = "Game name: " + GameName + "\n" +
							"Game path: " + GamePath + "\n" +
							"Backup path: " + BackupRoot + "\n" +
							"Profile format version: " + FileFormatVersion + "\n";

			return about;
		}

		public void AddPackage(ModPackage pack)
		{
			if(PackageCount >= Packages.Length)
			{
				Array.Resize<ModPackage>(ref Packages, Packages.Length + PackageArraySizeIncrease);
			}

			Packages[PackageCount] = pack;
			PackageCount++;

		}

		public ModPackage Search(string name)
		{
			for(int i = 0; i < PackageCount; i++)
			{
				if(Packages[i].Name == name)
				{
					return Packages[i];
				}
			}

			return new ModPackage("", "", "");
		}
	}
}


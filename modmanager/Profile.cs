﻿using System;
using System.IO;
using Newtonsoft.Json;

namespace modmanager
{
	public class Profile
	{
		const int LatestFileFormatVersion = 2;
		const int PackageArraySizeIncrease = 8;

		public string GameName;
		public string GamePath;
		public string ExecutableName;
		public string ModPath;
		public string BackupRoot;
		public int FileFormatVersion;

		public int PackageCount;
		public ModPackage[] Packages;

		public Profile()
		{

		}

		public Profile(string game_name="", string full_exe_path="\\", string mod_path="", string backup_root="", int ff_version = Profile.LatestFileFormatVersion)
		{
			GameName = game_name;
			GamePath = Utils.GetLastDirectory(full_exe_path);
			ExecutableName = Utils.GetRelativePath(full_exe_path, GamePath);
			ModPath = mod_path;
			BackupRoot = backup_root;
			FileFormatVersion = ff_version;

			PackageCount = 0;
			Packages = new ModPackage[PackageCount];

			if (ff_version < LatestFileFormatVersion)
			{
				throw new Exception("Cannot create a profile. The given format version is outdated!");
			}			
		}

		public void WriteJSON(string profileFileDir)
		{
			string profile_json = JsonConvert.SerializeObject(this, Formatting.Indented);
			string profile_file = Path.Combine(profileFileDir, GameName + ".json");

			File.WriteAllText(profile_file, profile_json);
		}

		public static Profile ReadJSON(string profile_file_path)
		{
			string profile_json = File.ReadAllText(profile_file_path);
			return Profile.FromJSON(profile_json);
		}

		public static Profile FromJSON(string profile_json)
		{
			Profile p = JsonConvert.DeserializeObject<Profile>(profile_json);

			if (p.FileFormatVersion < LatestFileFormatVersion)
			{
				throw new Exception("Cannot create a profile. The given format version is outdated!");
			}

			return p;
		}

		public string About()
		{
			string about = "Game name: " + GameName + "\n" +
							"Game path: " + GamePath + "\n" +
							"Executable name: " + ExecutableName + "\n" +
							"Mods path: " + ModPath + "\n" +
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


		//Returns true if mod existed and has been deleted, false otherwise
		public bool RemovePackage(ModPackage pack)
		{
			bool replace = false;
			for (int i = 0; i < PackageCount; i++)
			{
				if (Packages[i].Name == pack.Name)
				{
					replace = true;
				}

				if(replace)
				{
					Packages[i] = Packages[i + 1];
				}
			}

			if(replace)
			{
				PackageCount--;
				string dir_path = Path.Combine(ModPath, pack.Name);
				return DeleteModFolder(dir_path);
			}

			return replace;
		}

		private bool DeleteModFolder(string folder_path)
		{
			try
			{
				Directory.Delete(folder_path, true);
				return true;
			}
			catch(Exception e)
			{
				return false;
			}
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
			return null;
		}

		public bool HasDuplicate(ModPackage p)
		{
			for(int i = 0; i < PackageCount; i++)
			{
				if(Packages[i].Name == p.Name)
				{
					return true;
				}
			}
			return false;
		}

		public int FindPackageIndex(ModPackage p)
		{
			for (int i = 0; i < PackageCount; i++)
			{
				if (Packages[i].Name == p.Name)
				{
					return i;
				}
			}
			return -1;
		}

		public bool IsOriginal(string rel_path)
		{
			//Assume file is not modded
			bool isOriginal = true;

			//Go through all the packages
			for(int i = 0; i < PackageCount; i++)
			{
				//If the package is installed check if it affects the file
				if(Packages[i].IsInstalled)
				{
					ModPackage pack = Packages[i];
					//Go through the files in the mod
					for (int j = 0; j < pack.ModCount; j++)
					{
						//If the target file matches the given file
						if(pack.Mods[j].TargetFile == rel_path)
						{
							//The given file if modded
							isOriginal = false;
						}
					}
				}
			}
			return isOriginal;
		}

		//Check if one of the mods in the pack in targeting the same file as an existing pack
		public bool IsConflictingWithInstalled(ModPackage p, out string conflicting_mod_name)
		{
			for(int i = 0; i < PackageCount; i++)
			{
				if(Packages[i].IsInstalled)
				{
					for (int j = 0; j < Packages[i].ModCount; j++)
					{
						for (int k = 0; k < p.ModCount; k++)
						{
							if (p.Mods[k].TargetFile == Packages[i].Mods[j].TargetFile)
							{
								conflicting_mod_name = Packages[i].Name;
								return true;
							}
						}
					}
				}
			}
			conflicting_mod_name = "";
			return false;
		}
	}
}


using System;
using System.IO;
using System.IO.Compression;
using System.Globalization;

namespace modmanager
{
	class Utils
	{
		public static string Capitalize(string s)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
		}

		public static string GetRelativePath(string full_path, string root)
		{
			//Make sure the root exists in the given path
			string lw_full_path = full_path.ToLower();
			string lw_root = root.ToLower();

			int start_index = lw_full_path.IndexOf(lw_root);

			if(start_index >= 0)
			{
				//Extract the part starting at the root
				int common_length = start_index + root.Length;
				string relative_path = full_path.Substring(common_length, full_path.Length - common_length);
				return relative_path.TrimStart('\\');
			}
			else
			{
				//If the root doesn't exist, return the full path
				//TODO: Change to null
				return full_path;
			}
		 
		}

		public static string GetLastDirectory(string path_with_filename)
		{
			//Gets the path of the directory right above the one given
			return path_with_filename.Substring(0, path_with_filename.LastIndexOf('\\'));
		}

		public static void MakeTNTArchiveFromManifest(string manifest_path)
		{
			//Get the data from the manifest file
			ModPackage pack = ModPackage.FromJSON(manifest_path);
			string manifest_dir = Path.GetDirectoryName(manifest_path);

			if (pack != null)
			{
				//Recalculate paths to modded files relative to manifest
				for(int i = 0; i < pack.ModCount; i++)
				{
					pack.Mods[i].ModdedFile = Utils.GetRelativePath(pack.Mods[i].ModdedFile, manifest_dir);
					pack.Mods[i].BackupFile = pack.Mods[i].TargetFile;
				}

				pack.WriteJSON(manifest_path);
			}

			string last_dir = Utils.GetLastDirectory(manifest_dir);
			string tnt_path = Path.Combine(last_dir, pack.Name + ".TNT");

			//If there's a tnt file already, overwrite it
			if(File.Exists(tnt_path))
			{
				File.Delete(tnt_path);
			}

			ZipFile.CreateFromDirectory(manifest_dir, tnt_path, CompressionLevel.Optimal, false);
		}


		public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			// Get the subdirectories for the specified directory.
			DirectoryInfo dir = new DirectoryInfo(sourceDirName);

			if (!dir.Exists)
			{
				throw new DirectoryNotFoundException(
					"Source directory does not exist or could not be found: "
					+ sourceDirName);
			}

			DirectoryInfo[] dirs = dir.GetDirectories();
			// If the destination directory doesn't exist, create it.
			if (!Directory.Exists(destDirName))
			{
				Directory.CreateDirectory(destDirName);
			}

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = dir.GetFiles();
			foreach (FileInfo file in files)
			{
				string temppath = Path.Combine(destDirName, file.Name);
				file.CopyTo(temppath, true);
			}

			// If copying subdirectories, copy them and their contents to new location.
			if (copySubDirs)
			{
				foreach (DirectoryInfo subdir in dirs)
				{
					string temppath = Path.Combine(destDirName, subdir.Name);
					DirectoryCopy(subdir.FullName, temppath, copySubDirs);
				}
			}
		}

		public static void DirectoryDelete(string dirName)
		{
			// Get the subdirectories for the specified directory.
			DirectoryInfo dir = new DirectoryInfo(dirName);

			if (!dir.Exists)
			{
				throw new DirectoryNotFoundException(
					"Source directory does not exist or could not be found: "
					+ dirName);
			}

			DirectoryInfo[] dirs = dir.GetDirectories();

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = dir.GetFiles();
			foreach (FileInfo file in files)
			{
				File.Delete(file.FullName);
			}

			// If copying subdirectories, copy them and their contents to new location.
			foreach (DirectoryInfo subdir in dirs)
			{
				DirectoryDelete(subdir.FullName);
			}
		}


		public static ModPackage ExtractTNTArchive(string archive_path, Profile p)
		{
			ModPackage pack = null;

			//Create the temporary paths at which the archive will be extracted
			string temp_path = Path.Combine(Path.GetTempPath(), "mmswap");
			string temp_json_path = Path.Combine(temp_path, "package.json");

			//Delete the existing directory if it exists
			if(Directory.Exists(temp_path))
			{
				Directory.Delete(temp_path, true);
			}
			
			//Extract the .TNT archive and get it's name
			ZipFile.ExtractToDirectory(archive_path, temp_path);
			pack = ModPackage.FromJSON(temp_json_path);

			//Create the final path at which the mod info will be stored
			string final_path = Path.Combine(p.ModPath, pack.Name);

			//And move the content from the temp path to it's final resting place
			try
			{
				//Directory.Move(temp_path, final_path);
				DirectoryCopy(temp_path, final_path, true);
			}
			catch (IOException e)
			{
				throw new Exception("Error creating folder for the mod. Is the mod already installed?\n____________________\n\n" + e);
			}

			return pack;
		}
	}
}

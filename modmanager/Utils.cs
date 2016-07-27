using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace modmanager
{
	class Utils
	{
		public static string GetRelativePath(string full_path, string root)
		{
			//Make sure the root exists in the given path
			int start_index = full_path.IndexOf(root);

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

			ZipFile.CreateFromDirectory(manifest_dir, Path.Combine(last_dir, pack.Name + ".TNT"), CompressionLevel.Optimal, false);
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
				Directory.Move(temp_path, final_path);
			}
			catch (IOException e)
			{
				throw new Exception("Error creating folder for the mod. Is the mod already installed?\n____________________\n\n" + e);
			}

			return pack;
		}
	}
}

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
			int start_index = full_path.IndexOf(root);

			if(start_index >= 0)
			{
				int common_length = start_index + root.Length;
				string relative_path = full_path.Substring(common_length, full_path.Length - common_length);
				return relative_path;
			}
			else
			{
				return full_path;
			}
		 
		}

		public static string GetLastDirectory(string path_with_filename)
		{
			return path_with_filename.Substring(0, path_with_filename.LastIndexOf('\\'));
		}

		public static void MakeTNTArchiveFromManifest(string manifest_path)
		{
			ModPackage pack = ModPackage.FromJSON(manifest_path);
			string manifest_dir = Path.GetDirectoryName(manifest_path);

			if (pack != null)
			{
				//Recalculate paths to modded files relative to manifest
				for(int i = 0; i < pack.ModCount; i++)
				{
					pack.Mods[i].ModdedFile = Utils.GetRelativePath(pack.Mods[i].ModdedFile, manifest_dir);
				}

				pack.WriteJSON(manifest_path);
			}

			string last_dir = Utils.GetLastDirectory(manifest_dir);

			ZipFile.CreateFromDirectory(manifest_dir, Path.Combine(last_dir, pack.Name + ".TNT"), CompressionLevel.Optimal, false);
		}
	}
}

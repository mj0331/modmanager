using System;
using System.IO;
using Newtonsoft.Json;

namespace modmanager
{
	public class ModPackage
	{
		const int ModArrayIncreaseSize = 8;

		public string Name;
		public string Author;
		public string Description;
		public bool IsInstalled;

		public int ModCount;
		public Mod[] Mods;

		public ModPackage(string name, string author, string description, bool isInstalled = false)
		{
			Name = name;
			Author = author;
			Description = description;
			IsInstalled = isInstalled;

			ModCount = 0;
			Mods = new Mod[ModCount];
		}

		public void WriteJSON(string file_path)
		{
			string package_json = JsonConvert.SerializeObject(this, Formatting.Indented);

			File.WriteAllText(file_path, package_json);
		}

		public void Install(Profile p)
		{
			//TODO: Implement acctual install code
			IsInstalled = true;
		}

		public void Uninstall(Profile p)
		{
			//TODO: Implement acctual uninstall code
			IsInstalled = false;
		}

		public static ModPackage FromJSON(string filepath)
		{
			ModPackage pack = JsonConvert.DeserializeObject<ModPackage>(File.ReadAllText(filepath));

			if(pack != null)
			{
				return pack;
			}

			return null;
		}

		public Mod FindByTarget(string rel_target_path)
		{
			for(int i = 0; i < ModCount; i++)
			{
				if(Mods[i].TargetFile == rel_target_path)
				{
					return Mods[i];
				}
			}

			return null;
		}

		public void AddMod(Mod m)
		{
			//Make sure there is always at least one empty slot
			if(ModCount >= Mods.Length - 1)
			{
				Array.Resize<Mod>(ref Mods, Mods.Length + ModArrayIncreaseSize + 1);
			}

			Mods[ModCount] = m;
			ModCount++;
		}

		public void DeleteMod(Mod m)
		{
			bool isFound = false;

			for(int i = 0; i < ModCount; i++)
			{
				if(Mods[i].TargetFile == m.TargetFile)
				{
					isFound = true;
				}

				if(isFound)
				{
					if(i == ModCount - 1)
					{
						Mods[i] = null;
					}
					else
					{
						Mods[i] = Mods[i + 1];
					}

					ModCount--;
				}
			}
		}
	}
}


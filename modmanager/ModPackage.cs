﻿using System;
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
			IsInstalled = false;

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

            return new ModPackage("", "", "");
        }

		public void AddMod(Mod m)
		{
            //Make sure there is always at least one empty slot
			if(ModCount >= Mods.Length - 1)
			{
				Array.Resize<Mod>(ref Mods, Mods.Length + ModArrayIncreaseSize);
			}

			Mods[ModCount] = m;
			ModCount++;
		}
	}
}

using System;
using System.Collections.Generic;
namespace modmanager
{
	public class ModPackage
	{
		public string Name;
		public string Author;
		public string Description;
		public bool IsInstalled;

		public List<Mod> Mods;

		public ModPackage(string name, string author, string description, bool isInstalled = false)
		{
			Name = name;
			Author = author;
			Description = description;
			IsInstalled = false;
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
	}
}


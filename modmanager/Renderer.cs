using System.Drawing;
using System.Windows.Forms;

namespace modmanager
{
	public class MenuRenderer : ToolStripProfessionalRenderer
	{
		public MenuRenderer() : base(new MenuColorTable())
		{

		}
	}

	public class MenuColorTable : ProfessionalColorTable
	{
		public override Color MenuItemSelected
		{
			get { return Color.LightGray; }
		}
		public override Color MenuItemBorder
		{
			get { return Color.LightGray; }
		}

		public override Color MenuItemSelectedGradientBegin
		{
			get { return Color.LightGray; }
		}
		public override Color MenuItemSelectedGradientEnd
		{
			get { return Color.LightGray; }
		}

		public override Color MenuItemPressedGradientBegin
		{
			get { return Color.LightGray; }
		}
		public override Color MenuItemPressedGradientEnd
		{
			get { return Color.LightGray; }
		}

	}

}

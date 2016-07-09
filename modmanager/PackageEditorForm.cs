using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modmanager
{
    public partial class PackageEditorForm : Form
    {
        ModPackage Target;

        public PackageEditorForm()
        {
            InitializeComponent();
        }

        public PackageEditorForm(ModPackage p)
        {
            InitializeComponent();
            Target = p;
            UpdateDisplayData();
        }

        public void UpdateDisplayData()
        {
            name_input.Text = Target.Name;
            author_input.Text = Target.Author;
            description_input.Text = Target.Description;
        }

        private void loadPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void edit_mod_button_Click(object sender, EventArgs e)
        {

        }
    }
}

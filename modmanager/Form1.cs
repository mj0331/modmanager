using System;
using System.Windows.Forms;
using System.IO;

namespace modmanager
{
    public partial class Form1 : Form
    {
        private Profile ActiveProfile;

        public Form1()
        {
            InitializeComponent();
            InitModManager();
        }

        private void InitModManager()
        {
            ActiveProfile = new Profile("", "", "");

            this.Text = "Mod Manager - (no profile loaded)";
            open_profile_dialog.CheckFileExists = true;
            open_profile_dialog.CheckPathExists = true;
            open_profile_dialog.Filter = "JSON Files (.json)|*.json";
        }

        private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProfileForm create_profile_form = new CreateProfileForm();
            create_profile_form.Show();
        }

        public void UpdatePackageInfo(ModPackage pack)
        {
            selected_package_name_label.Text = pack.Name;
            selected_package_author_label.Text = "By " + pack.Author;
            selected_package_description.Text = pack.Description;
        }

        public void UpdatePackageLists()
        {
            enabled_package_list.Items.Clear();
            disabled_package_list.Items.Clear();

            ModPackage pack;

            for (int i = 0; i < ActiveProfile.PackageCount; i++)
            {
                pack = ActiveProfile.Packages[i];

                if (pack.IsInstalled)
                {
                    enabled_package_list.Items.Add(pack.Name);
                }
                else
                {
                    disabled_package_list.Items.Add(pack.Name);
                }
            }
        }

        public void UpdateActiveProfile(Profile p)
        {
            ActiveProfile = p;

            //TODELETE
            ModPackage t1 = new ModPackage("test1", "mj0331", "Test mod #1");
            ModPackage t2 = new ModPackage("test2", "mj0331", "Test mod #2");

            ActiveProfile.AddPackage(t1);
            ActiveProfile.AddPackage(t2);

            this.Text = "Mod Manager - " + p.GameName;
            profile_label.Text = p.GameName;

            UpdatePackageLists();
        }

        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_profile_dialog.ShowDialog();
            Stream s = open_profile_dialog.OpenFile();
            StreamReader sr = new StreamReader(s);

            UpdateActiveProfile(Profile.FromJSON(sr.ReadToEnd()));

            s.Close();
        }

        private void aboutThisProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About this profile: \n\n" + ActiveProfile.About());
        }



        private void disabled_package_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            disabled_package_list.Select();
            if(disabled_package_list.SelectedItem != null)
            {
                UpdatePackageInfo(ActiveProfile.Search(disabled_package_list.SelectedItem.ToString()));
            }
        }

        private void enabled_package_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabled_package_list.Select();
            if(enabled_package_list.SelectedItem != null)
            {
                UpdatePackageInfo(ActiveProfile.Search(enabled_package_list.SelectedItem.ToString()));
            }
        }



        private void enable_selected_button_Click(object sender, EventArgs e)
        {
            
            if (disabled_package_list.SelectedItem != null)
            {
                ActiveProfile.Search(disabled_package_list.SelectedItem.ToString()).Install(ActiveProfile);
                UpdatePackageLists();
            }           
        }

        private void disable_selected_button_Click(object sender, EventArgs e)
        {
            if(enabled_package_list.SelectedItem != null)
            {
                ActiveProfile.Search(enabled_package_list.SelectedItem.ToString()).Uninstall(ActiveProfile);
                UpdatePackageLists();
            }  
        }



        private void enable_all_button_Click(object sender, EventArgs e)
        {
            ModPackage pack;

            for (int i = 0; i < ActiveProfile.PackageCount; i++)
            {
                pack = ActiveProfile.Packages[i];
                pack.Install(ActiveProfile);
            }

            UpdatePackageLists();
        }

        private void disable_all_button_Click(object sender, EventArgs e)
        {
            ModPackage pack;

            for (int i = 0; i < ActiveProfile.PackageCount; i++)
            {
                pack = ActiveProfile.Packages[i];
                pack.Uninstall(ActiveProfile);
            }

            UpdatePackageLists();
        }
    }
}

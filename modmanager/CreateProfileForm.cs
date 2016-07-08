using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace modmanager
{
    public partial class CreateProfileForm : Form
    {
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void game_browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            game_input.Text = folderBrowserDialog1.SelectedPath;
        }

        private void backup_browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            backup_input.Text = folderBrowserDialog2.SelectedPath;
        }

        private void profile_browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog3.ShowDialog();
            profile_input.Text = folderBrowserDialog3.SelectedPath;
        }

        private bool ValidateInput()
        {
            if(name_input.TextLength > 0 &&
                game_input.TextLength > 0 &&
                backup_input.TextLength > 0 &&
                profile_input.TextLength > 0)
            {
                return true;
            }

            return false;
        }

        private void CreateProfile()
        {
            Profile p = new Profile(name_input.Text, game_input.Text, backup_input.Text);
            p.WriteJSON(profile_input.Text);

            //DEBUG
            MessageBox.Show("Created profile:\n\n" + JsonConvert.SerializeObject(p, Formatting.Indented));
        }

        private void create_profile_confirm_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                CreateProfile();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cannot create profile! One ore more fields are empty!", "Error");
            }
        }
    }
}

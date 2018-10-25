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

///This form is used to redirect the player to different areas of the game quickly and easily.

namespace Mine_Sweeper
{
    public partial class Main_menu : Form
    {
        //Creates instance of muted variable that will be updated to check if the music is muted.
        Profile MainMenuProfileInstance;
        bool MenuMusicMuted;
        bool MenuSoundMuted;
        bool ChangingForm;

        public Main_menu(bool MusicMuted, bool SoundMuted)
        {
            InitializeComponent();
        }

        public Main_menu(Profile Profile, bool MusicMuted, bool SoundMuted)
        {
            //Runs initializecomponent method to create and display the form correctly.
            InitializeComponent();
            MainMenuProfileInstance = Profile;
            MenuMusicMuted = MusicMuted;
            MenuSoundMuted = SoundMuted;
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            //Checks if user  is signed in.
            if (MainMenuProfileInstance != null)
            {
                Play_button.Enabled = true;
                UserNotFound_label.Visible = false;
                UserNotFound2_label.Visible = false;
                MenuProfileName_label.Text = MainMenuProfileInstance.Name;
                MenuProfilePicture_picturebox.Image = ProfileImages_imagelist.Images[MainMenuProfileInstance.Image];
                MenuItemGame_button.Enabled = true;
            }
            else
            {
                Play_button.Enabled = false;
                UserNotFound_label.Visible = true;
                UserNotFound2_label.Visible = true;
            }

            if (MenuSoundMuted == true)
            {
                MenuItemSound_button.Checked = false;
            }

            if (MenuMusicMuted == true)
            {
                MenuItemMusic_button.Checked = false;
            }
        }

        private void GameScreenTransfer()
        {
            ChangingForm = true;
            //Creates a new instance of the options screen so as it can later be opened.
            Game_screen Game_screen = new Game_screen(MainMenuProfileInstance, MenuMusicMuted, MenuSoundMuted);
            //Displays the new Game screen form to the user.
            Game_screen.Show();
            this.Close();
        }

        private void ProfileScreenTransfer()
        {
            ChangingForm = true;
            //Creates a new instance of the options screen so as it can later be opened.
            Profile_screen Profile_screen = new Profile_screen(MainMenuProfileInstance, MenuMusicMuted, MenuSoundMuted);
            //Displays the new Profile screen form to the user.
            Profile_screen.Show();
            this.Close();
        }

        private void OptionsScreenTransfer()
        {
            ChangingForm = true;
            //Creates a new instance of the options screen so as it can later be opened.
            Options_screen Options_screen = new Options_screen(MainMenuProfileInstance, MenuMusicMuted, MenuSoundMuted);
            //Displays the new options screen form to the user.
            Options_screen.Show();
            //Hides this form for future use.
            this.Close();
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            //Closes the game entirely as the user wishes to quit.
            Application.Exit();
        }

        private void Options_button_Click(object sender, EventArgs e)
        {
            OptionsScreenTransfer();
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            GameScreenTransfer();
        }

        private void Profiles_button_Click(object sender, EventArgs e)
        {
            ProfileScreenTransfer();
        }

        private void Main_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangingForm == false)
            {
                Application.Exit();
            }
        }

        private void MenuItemHelp_button_Click(object sender, EventArgs e)
        {
            Help_screen HelpScreen = new Help_screen();
            HelpScreen.Show();
        }

        private void MenuItemOptions_button_Click(object sender, EventArgs e)
        {
            OptionsScreenTransfer();
        }

        private void MenuItemGame_button_Click(object sender, EventArgs e)
        {
            GameScreenTransfer();
        }

        private void MenuItemProfile_button_Click(object sender, EventArgs e)
        {
            ProfileScreenTransfer();
        }

        private void MenuItemSound_button_CheckedChanged(object sender, EventArgs e)
        {
            if (MenuItemSound_button.Checked == false)
            {
                MenuSoundMuted = true;
            }
            else
            {
                MenuSoundMuted = false;
            }
        }

        private void MenuItemMusic_button_CheckedChanged(object sender, EventArgs e)
        {
            if (MenuItemMusic_button.Checked == false)
            {
                MenuMusicMuted = true;
            }
            else
            {
                MenuMusicMuted = false;
            }
        }

        private void MenuItemExit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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

///This form is used as an introduction screen to the application, it is also responsible for the setting up of the profile bin file if one does not already exist within the file the application is contained in.

namespace Mine_Sweeper
{
    public partial class Splash_screen : Form
    {
        //Creates an instance of profile that can be passed onto the next form in the program. Will always be null on this screen.
        Profile SplashScreenProfileInstance;
        //Creates a bool for music and sound muted so as they can later be used to decide whether or not sound/music is played.
        bool MusicMuted = false;
        bool SoundMuted = false;

        public Splash_screen()
        {
            //Runs initializecomponent method to create and display the form as specified within the designer.
            InitializeComponent();
        }

        private void Splash_screen_Load(object sender, EventArgs e)
        {
            //Creates a Filestream in order to create a bin file if one does not already exist and then disposes the filestream and its contents so it may be used again later. If one already exists an exeption is thrown to the console.
            try
            { 
                FileStream BinCreator = new FileStream("profiles.bin", FileMode.CreateNew);
                BinCreator.Close();
                BinCreator.Dispose();
                Console.WriteLine("An instance of the Profiles.bin has now been created.");
            }
            catch (IOException I)
            {
                Console.WriteLine(I.Message);
            }
        }

        private void Flash_timer_Tick(object sender, EventArgs e)
        {
            //Checks if text is visible if not then makes it visible. If text is visible it makes it invisible. Has effect of flashing the text.
            if (Prompt_text.Visible == true)
            {
                //Makes text invisible
                Prompt_text.Visible = false;
            }
            else
            {
                //Makes text visible
                Prompt_text.Visible = true;
            }
        }

        private void Splash_screen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //calls the keypressed method which can be called by pressing a key even one of the mute buttons are selected.
            KeyPressed();
        }

        private void Splash_screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void SoundEffectToggle_button_Click(object sender, EventArgs e)
        {
            //Toggles the sound muted variable changing whether the game sound is muted or not and changes image to represent whether it is muted or not.
            if (SoundMuted == false)
            {
                SoundMuted = true;
                SoundEffectToggle_button.BackgroundImage = Properties.Resources.SoundDisabled_image;
            }
            else
            {
                SoundMuted = false;
                SoundEffectToggle_button.BackgroundImage = Properties.Resources.SoundEnabled_image;
            }
        }

        private void MusicToggle_button_Click(object sender, EventArgs e)
        {
            //Toggles the music muted variable changing whether music is played in the game or not and changes the image to the relevant icon for muting.
            if (MusicMuted == false)
            {
                MusicMuted = true;
                MusicToggle_button.BackgroundImage = Properties.Resources.MusicDisabled_image;
            }
            else
            {
                MusicMuted = false;
                MusicToggle_button.BackgroundImage = Properties.Resources.MusicEnabled_image;
            }
        }

        //Sends the user to a form of their choice (either the main menu or profile screen).
        public void KeyPressed()
        {
            //Stops the timer from flashing and taking up CPU processing as this form remains open but hidden so as to allow other forms to close without closing the entire application.
            Flash_timer.Stop();
            //Provides the user with the option of either moving to the profile screen to sign in directly or proceed to the main menu if they simply want to view the high scores or somthing else that does not require a sign in.
            if (MessageBox.Show("You are currently not signed in, please proceed to the profile screen to create your account and sign in.\nWould you like to go there now?", "Not signed in.", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //When a key is pressed it creates a new instance of the main menu screen and loads it.
                //Creates screen instance
                Main_menu newMainMenu = new Main_menu(SplashScreenProfileInstance, MusicMuted, SoundMuted);
                //Shows the main menu screen.
                newMainMenu.Show();
                //Hides form to keep program running.
                this.Hide();
            }
            else
            {
                //Creates an instance of the profile screen and sends the user there rather than the main menu.
                Profile_screen newProfileScreen = new Profile_screen(SplashScreenProfileInstance, MusicMuted, SoundMuted);
                newProfileScreen.Show();
                //Hides form to keep program running when other forms are closed.
                this.Hide();
            }
        }

        private void SoundEffectToggle_button_KeyDown(object sender, KeyEventArgs e)
        {
            //triggers keypressed to move the user to main menu/profile screen based on their choice.
            KeyPressed();
        }

        private void MusicToggle_button_KeyDown(object sender, KeyEventArgs e)
        {
            //triggers keypressed to move the user to main menu/profile screen based on their choice.
            KeyPressed();
        }
    }
}

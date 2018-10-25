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

///This is where the user can edit specific options regarding the operation of their game, allowing them to make it easier or harder to finish depending on their preference.

namespace Mine_Sweeper
{
    public partial class Options_screen : Form
    {
        //Creates an instance of the profile for the options screen.
        Profile OptionsProfileInstance;
        //States whether values have been changed and is used for asking if the user is sure they want to leave without applying settings.
        bool DiffChanged = false;
        //stores the value for the maximum number of bombs the user is allowed to select.
        int BombMax;
        //States whether the user is attempting to change the form to another form.
        bool ChangingForm = false;
        //Values used to determine what sound types are muted within the program.
        bool OptionsSoundMuted;
        bool OptionsMusicMuted;

        public Options_screen(Profile Profile, bool MusicMuted, bool SoundMuted)
        {
            InitializeComponent();
            //Assignes values passed in from other screens.
            OptionsProfileInstance = Profile;
            OptionsSoundMuted = SoundMuted;
            OptionsMusicMuted = MusicMuted;
        }

        //Changes the current form to the one the user requested after asking if they are sure they want to leave without saving changes, if they have changed any settings.
        private bool ChangeScreen()
        {
            //Determines whether the user chose to leave with the dialogue choice.
            bool Leave = false;
            //Transitions the player to the main menu screen, they will be asked if they are sure if they have made changes to one or more of the options, they will also be given the option to apply these changes before leaving.
            if (DiffChanged == true)
            {
                //Used to store the answer provided in the following question.
                DialogResult answer;
                //Asks question and supplies multi choice answers.
                answer = MessageBox.Show("Do you wish to apply these changes before you leave?", "Apply changes?", MessageBoxButtons.YesNoCancel);
                //if the user does wish to apply settings the settings will be applied before sending them to the chosen screen.
                if (answer == DialogResult.Yes)
                {
                    Leave = true;
                    ApplyChanges();
                }
                else if (answer == DialogResult.No)
                {
                    //The user leaves the screen without saving changes.
                    Leave = true;
                }
            }
            else
            {
                //There were no changes and the user leaves.
                Leave = true;
            }
            return Leave;
        }

        private void Main_Menu_button_Click(object sender, EventArgs e)
        {
            //Runs through the change screen process and if they choose they will be sent to the chosen screen.
            if (ChangeScreen() == true)
            {
                ReturnToMainMenu();
            }
        }

        //Sends user to main menu.
        private void ReturnToMainMenu()
        {
            //Sends user to main menu.
            ChangingForm = true;
            Main_menu newMain_menu = new Main_menu(OptionsProfileInstance, OptionsMusicMuted, OptionsSoundMuted);
            newMain_menu.Show();
            this.Close();
        }

        private void Options_screen_Load(object sender, EventArgs e)
        {
            //Determines if there is a profile active and if so, updates all options on screen to match current preferences.
            if (OptionsProfileInstance != null)
            {
                switch (OptionsProfileInstance.Difficulty)
                {
                    case 0:
                        {
                            //Difficulty is equal to custom.
                            Custom_checkbox.Checked = true;
                            break;
                        }
                    case 1:
                        {
                            //Difficulty is equal to easy.
                            Easy_checkbox.Checked = true;
                            break;
                        }
                    case 2:
                        {
                            //Difficulty is equal to normal.
                            Medium_checkbox.Checked = true;
                            break;
                        }
                    case 3:
                        {
                            //Difficulty is equal to hard.
                            Hard_checkbox.Checked = true;
                            break;
                        }
                }
                if (OptionsSoundMuted == true)
                {
                    //Updates whether the sound is currently muted.
                    MuteSound_button.Text = "Un-Mute sound effects";
                    SoundEffectsStatus_label.Text = "Sound effects are currently muted.";
                    MenuItemSound_button.Checked = false;
                }
                if (OptionsMusicMuted == true)
                {
                    //Updates whether the music is currently muted.
                    MuteMusic_button.Text = "Un-Mute Music";
                    SoundMusicStatus_label.Text = "Music is currently muted.";
                    MenuItemMusic_button.Checked = false;
                }
                MenuItemGame_button.Enabled = true;
            }
            else
            {
                //If the user is not signed in then they cannot change difficulties.
                Easy_checkbox.Enabled = false;
                Medium_checkbox.Enabled = false;
                Hard_checkbox.Enabled = false;
                Custom_checkbox.Enabled = false;
            }
        }

        //Toggles all of the values for each difficulty based on their default values.
        private void Easy_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //Calls method which changes all of the values relevant to this difficulty.
            EasyCheckboxValueChanger();
            DiffChanged = true;
        }

        private void Medium_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //Calls method which changes all of the values relevant to this difficulty.
            MediumCheckboxValueChanger();
            DiffChanged = true;
        }

        private void Hard_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //Calls method which changes all of the values relevant to this difficulty.
            HardCheckboxValueChanger();
            DiffChanged = true;
        }

        private void Custom_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //Calls method which changes all of the values relevant to this difficulty.
            CustomCheckboxValueChanger();
            DiffChanged = true;
        }

        private void Options_screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Allows this form to close if the screen is changing without closing the application.
            if (!ChangingForm)
            {
                Application.Exit();
            }
        }

        private void ApplyPermanent_button_Click(object sender, EventArgs e)
        {
            //Updates all information and sets it so the user can leave without recieving a prompt.
            ApplyChanges();
            DiffChanged = false;
        }

        //Updates the values of the profile and updates the instance in existance within the bin file.
        private void ApplyChanges()
        {
            //Update all changed information regarding options within the profile class.
            if (OptionsProfileInstance != null)
            {
                if (Custom_checkbox.Checked == true)
                {
                    OptionsProfileInstance.Difficulty = 0;
                    OptionsProfileInstance.Xsize = PlayWidth_trackbar.Value;
                    OptionsProfileInstance.Ysize = PlayHeight_trackbar.Value;
                    OptionsProfileInstance.BombNo = BombNumber_trackbar.Value;
                }
                else
                {
                    if (Easy_checkbox.Checked == true)
                    {
                        OptionsProfileInstance.Difficulty = 1;
                    }
                    else
                    {
                        if (Medium_checkbox.Checked == true)
                        {
                            OptionsProfileInstance.Difficulty = 2;
                        }
                        else
                        {
                            if (Hard_checkbox.Checked == true)
                            {
                                OptionsProfileInstance.Difficulty = 3;
                            }
                        }
                    }
                }
                OptionsProfileInstance.UpdateProfileDetails(OptionsProfileInstance);
            }
        }

        //Changes the maximum number of bombs that can be selected based on the size of the play area.
        private void UpdateBombLimit()
        {
            //Recalculates the maximum number of bombs that can be added to the game.
            BombMax = PlayWidth_trackbar.Value * PlayHeight_trackbar.Value;
            TotalSlotsDisplay.Text = "Total slots that will appear on screen: " + BombMax;
            BombNumber_trackbar.Maximum = BombMax;
            DiffChanged = true;
        }

        private void PlayWidth_trackbar_Scroll(object sender, EventArgs e)
        {
            //Changes the value for the width of the game.
            WidthDisplay_label.Text = PlayWidth_trackbar.Value.ToString();
            UpdateBombLimit();
            BombNoDisplay_label.Text = BombNumber_trackbar.Value.ToString();
        }

        private void PlayHeight_trackbar_Scroll(object sender, EventArgs e)
        {
            //Changes the value for the height of the game.
            HeightDisplay_label.Text = PlayHeight_trackbar.Value.ToString();
            UpdateBombLimit();
            BombNoDisplay_label.Text = BombNumber_trackbar.Value.ToString();
        }

        private void BombNumber_trackbar_Scroll(object sender, EventArgs e)
        {
            //Changes the value for the number of bombs in game.
            BombNoDisplay_label.Text = BombNumber_trackbar.Value.ToString();
            DiffChanged = true;
        }

        //Changes values based on whether or not the easy checkbox is checked.
        private void EasyCheckboxValueChanger()
        {
            //Updates all values to the easy preset.
            if (Easy_checkbox.Checked == true)
            {
                Medium_checkbox.Checked = false;
                Hard_checkbox.Checked = false;
                Custom_checkbox.Checked = false;
                BombNumber_trackbar.Enabled = false;
                PlayWidth_trackbar.Enabled = false;
                PlayHeight_trackbar.Enabled = false;
                PlayWidth_trackbar.Value = 8;
                PlayHeight_trackbar.Value = 8;
                UpdateBombLimit();
                BombNumber_trackbar.Value = 10;
                WidthDisplay_label.Text = "8";
                HeightDisplay_label.Text = "8";
                BombNoDisplay_label.Text = "10";
                BombNoDisplay_label.Text = BombNumber_trackbar.Value.ToString();
            }
            else
            {
                if (Hard_checkbox.Checked == false && Custom_checkbox.Checked == false)
                {
                    Medium_checkbox.Checked = true;
                }
            }

        }

        //Changes values based on whether the medium checkbox is checked.
        private void MediumCheckboxValueChanger()
        {
            //Updates all values to the medium preset.
            if (Medium_checkbox.Checked == true)
            {
                Easy_checkbox.Checked = false;
                Hard_checkbox.Checked = false;
                Custom_checkbox.Checked = false;
                BombNumber_trackbar.Enabled = false;
                PlayWidth_trackbar.Enabled = false;
                PlayHeight_trackbar.Enabled = false;
                PlayWidth_trackbar.Value = 16;
                PlayHeight_trackbar.Value = 16;
                UpdateBombLimit();
                BombNumber_trackbar.Value = 40;
                WidthDisplay_label.Text = "16";
                HeightDisplay_label.Text = "16";
                BombNoDisplay_label.Text = "40";
                BombNoDisplay_label.Text = BombNumber_trackbar.Value.ToString();
            }
            else
            {
                if (Easy_checkbox.Checked == false && Hard_checkbox.Checked == false && Custom_checkbox.Checked == false)
                {
                    Medium_checkbox.Checked = true;
                }
            }
        }

        //Changes values based on whether the hard checkbox is checked.
        private void HardCheckboxValueChanger()
        {
            //Updates all values to the hard preset.
            if (Hard_checkbox.Checked == true)
            {
                Medium_checkbox.Checked = false;
                Easy_checkbox.Checked = false;
                Custom_checkbox.Checked = false;
                BombNumber_trackbar.Enabled = false;
                PlayWidth_trackbar.Enabled = false;
                PlayHeight_trackbar.Enabled = false;
                PlayWidth_trackbar.Value = 32;
                PlayHeight_trackbar.Value = 16;
                UpdateBombLimit();
                BombNumber_trackbar.Value = 99;
                WidthDisplay_label.Text = "32";
                HeightDisplay_label.Text = "16";
                BombNoDisplay_label.Text = "99";
                BombNoDisplay_label.Text = BombNumber_trackbar.Value.ToString();
            }
            else
            {
                if (Easy_checkbox.Checked == false && Custom_checkbox.Checked == false)
                {
                    Medium_checkbox.Checked = true;
                }
            }
        }

        //Updates values based on whether the custom checkbox is checked.
        private void CustomCheckboxValueChanger()
        {
            //Updates all values to the custom preset and makes them all editable for the user so they can make their own difficulty.
            if (Custom_checkbox.Checked == true)
            {
                Easy_checkbox.Checked = false;
                Medium_checkbox.Checked = false;
                Hard_checkbox.Checked = false;
                BombNumber_trackbar.Enabled = true;
                PlayWidth_trackbar.Enabled = true;
                PlayHeight_trackbar.Enabled = true;
                PlayWidth_trackbar.Value = OptionsProfileInstance.Xsize;
                PlayHeight_trackbar.Value = OptionsProfileInstance.Ysize;
                UpdateBombLimit();
                BombNumber_trackbar.Value = OptionsProfileInstance.BombNo;
                WidthDisplay_label.Text = PlayWidth_trackbar.Value.ToString();
                HeightDisplay_label.Text = PlayHeight_trackbar.Value.ToString();
                BombNoDisplay_label.Text = BombNumber_trackbar.Value.ToString();
            }
            else
            {
                if (Easy_checkbox.Checked == false && Hard_checkbox.Checked == false)
                {
                    Medium_checkbox.Checked = true;
                }
            }

        }

        private void MuteSound_button_Click(object sender, EventArgs e)
        {
            //toggles whether the game sound is muted and updates the text and checkboxes as such.
            if (OptionsSoundMuted == false)
            {
                OptionsSoundMuted = true;
                MuteSound_button.Text = "Un-Mute sound effects";
                SoundEffectsStatus_label.Text = "Sound effects are currently muted.";
            }
            else
            {
                OptionsSoundMuted = false;
                MuteSound_button.Text = "Mute sound effects";
                SoundEffectsStatus_label.Text = "Sound effects are currently not muted.";
            }
            MenuItemSound_button.Checked = !OptionsSoundMuted;
        }

        private void MuteMusic_button_Click(object sender, EventArgs e)
        {
            //toggles whether the game music is muted and updates the text and checkboxes as such.
            if (OptionsMusicMuted == false)
            {
                OptionsMusicMuted = true;
                MuteMusic_button.Text = "Un-Mute Music";
                SoundMusicStatus_label.Text = "Music is currently muted.";
            }
            else
            {
                OptionsMusicMuted = false;
                MuteMusic_button.Text = "Mute Music";
                SoundMusicStatus_label.Text = "Music is currently not muted.";
            }
            MenuItemMusic_button.Checked = !OptionsMusicMuted;
        }

        private void MenuItemHelp_button_Click(object sender, EventArgs e)
        {
            //Opens a window for the help screen.
            Help_screen HelpScreen = new Help_screen();
            HelpScreen.Show();
        }

        private void MenuItemMainMenu_button_Click(object sender, EventArgs e)
        {
            //Runs through the change screen process and if they choose they will be sent to the chosen screen.
            if (ChangeScreen() == true)
            {
                ReturnToMainMenu();
            }
        }

        private void MenuItemGame_button_Click(object sender, EventArgs e)
        {
            //Runs through the change screen process and if they choose they will be sent to the chosen screen.
            if (ChangeScreen() == true)
            {
                ChangingForm = true;
                Game_screen GameScreen = new Game_screen(OptionsProfileInstance, OptionsMusicMuted, OptionsSoundMuted);
                GameScreen.Show();
                this.Close();
            }
        }

        private void MenuItemProfile_button_Click(object sender, EventArgs e)
        {
            //Runs through the change screen process and if they choose they will be sent to the chosen screen.
            if (ChangeScreen() == true)
            {
                ChangingForm = true;
                Profile_screen ProfileScreen = new Profile_screen(OptionsProfileInstance, OptionsMusicMuted, OptionsSoundMuted);
                ProfileScreen.Show();
                this.Close();
            }
        }

        private void MenuItemSound_button_CheckedChanged(object sender, EventArgs e)
        {
            //Toggles whether or not the game is muted and updates the buttons on the options screen.
            if (MenuItemSound_button.Checked == false)
            {
                OptionsSoundMuted = true;
                MuteSound_button.Text = "Un-Mute sound effects";
                SoundEffectsStatus_label.Text = "Sound effects are currently muted.";
            }
            else
            {
                OptionsSoundMuted = false;
                MuteSound_button.Text = "Mute sound effects";
                SoundEffectsStatus_label.Text = "Sound effects are currently not muted.";
            }
        }

        private void MenuItemMusic_button_CheckedChanged(object sender, EventArgs e)
        {
            //Toggles whether or not the game music is muted and updates the buttons on the options screen.
            if (MenuItemMusic_button.Checked == false)
            {
                OptionsMusicMuted = true;
                MuteMusic_button.Text = "Un-Mute Music";
                SoundMusicStatus_label.Text = "Music is currently muted.";
            }
            else
            {
                OptionsMusicMuted = false;
                MuteMusic_button.Text = "Mute Music";
                SoundMusicStatus_label.Text = "Music is currently not muted.";
            }
        }

        private void MenuItemExit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Custom_checkbox_Click(object sender, EventArgs e)
        {
            if (Custom_checkbox.Checked == true)
            {
                MessageBox.Show("Warning: Using custom settings may be unstable under certain conditons. Adding too many slots or too many mines can severely hinder performance and gameplay. proceed with caution.");
            }
        }
    }
}

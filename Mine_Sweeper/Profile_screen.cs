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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

///This is the form that is responsible for the setting up of the players profile information for use on later forms and other times the player opens the application.

namespace Mine_Sweeper
{
    public partial class Profile_screen : Form
    {
        //Changing form boolean used to determine whether the form is closing due to changing form or actually closing.
        bool ChangingForm = false;
        //Filestream used for reading the binary file for information on profiles.
        Stream sr;
        //Binary formatter used to serialize and deserialise the information contained within the binary file.
        BinaryFormatter bf = new BinaryFormatter();
        //Used to save a copy of the picturebox that was clicked and dragged.
        PictureBox DragDropSender;
        //The currently selected instance of the profile class for transport between forms.
        Profile ProfileScreenProfileInstance;
        //Temporary profile location used for scanning and comparing multiple profiles.
        Profile TempProfileLocation;
        //Used to count the number of profiles that are currently saved in the bin file.
        int ItemNo;
        //Determines which picture was last selected by the user.
        short PicturePending;
        //Saves the finalised number for the chosen picture of the user.
        short PictureNo = 0;
        //Determines whether the game music is muted.
        bool ProfileMusicMuted;
        //Determines whether the game sound is muted.
        bool ProfileSoundMuted;

        public Profile_screen(bool MusicMuted, bool SoundMuted)
        {
            InitializeComponent();
        }

        public Profile_screen(Profile Profile, bool MusicMuted, bool SoundMuted)
        {
            //Sets up the form as specified within the designer.
            InitializeComponent();
            //Passes data to this form from other forms and updates current data.
            ProfileScreenProfileInstance = Profile;
            ProfileMusicMuted = MusicMuted;
            ProfileSoundMuted = SoundMuted;
        }

        private void profile_creation_button_enabler_disabler()
        {
            //Ensures all essential profile creation fields are entered before the creation button becomes available for clicking. Else the button is set to disabled to as the user cannot proceed until the essential feilds are entered.
            if (NewUsername_textbox.Text != "" && Newpassword_textbox.Text != "" && Newpasswordconf_textbox.Text != "" && Createprofile_button.Enabled == false)
            {
                Createprofile_button.Enabled = true;
            }
            else
            {
                if (NewUsername_textbox.Text == "" || Newpasswordconf_textbox.Text == "" || Newpassword_textbox.Text == "")
                {
                    Createprofile_button.Enabled = false;
                }
            }
        }

        private void profile_selection_button_enabler_disabler()
        {
            //Prevents the user from clicking the use profile button if they have not selected a profile or have not attempted to put in a password, otherwise it is set to be disabled.
            if (Password_textbox.Text != "" && UseProfile_button.Enabled == false && Profileselection_combobox.SelectedItem != null)
            {
                UseProfile_button.Enabled = true;
            }
            else
            {
                if (Password_textbox.Text == "" && UseProfile_button.Enabled == true)
                {
                    UseProfile_button.Enabled = false;
                }
            }
        }

        //Sends user to main menu.
        private void MainMenuTransition()
        {
            //Opening menu screen and closing the current one.
            ChangingForm = true;
            Main_menu newMain_menu = new Main_menu(ProfileScreenProfileInstance, ProfileMusicMuted, ProfileSoundMuted);
            newMain_menu.Show();
            this.Close();
        }

        private void Main_Menu_button_Click(object sender, EventArgs e)
        {
            //Opens the main menu and closes the current screen.
            MainMenuTransition();
        }

        private void CreateProfile_button_Click(object sender, EventArgs e)
        {
            //Goes through each of the necessary levels of validation to ensure that the user has entered the correct details and has met the requirements on each, if not, a message will be displayed stating why they could not continue so they may fix their mistake.
            if (NewUsername_textbox.Text.Length >= 3 && NewUsername_textbox.Text.Length <= 30)
            {
                if (Newpassword_textbox.Text.Length >= 5 && Newpassword_textbox.Text.Length <= 30)
                {
                    if (Newpassword_textbox.Text == Newpasswordconf_textbox.Text)
                    {
                        if (PictureNo != 0)
                        {
                            if (UseUsername_checkbox.Checked == true || NameCreation_textbox.Text.Length > 0 && NameCreation_textbox.Text.Length < 30)
                            {
                                try
                                {
                                    if (WantToProvideAge_checkbox.Checked == true || int.Parse(AgeCreation_textbox.Text) <= 999 && int.Parse(AgeCreation_textbox.Text) >= 0)
                                    {
                                        try
                                        {
                                            //Creates an instance of the profile and writes it to the bin file if all validation is successful.
                                            //Creates profile instance with inputted data.
                                            Profile NewProfile = new Profile(NewUsername_textbox.Text, CountProfiles() + 1, NameCreation_textbox.Text, AgeCreation_textbox.Text, Newpassword_textbox.Text, PictureNo);
                                            //Calls the create new profile method contained within the profile so as to save it to the bin file with all current information.
                                            NewProfile.CreateNewProfile(NewProfile);
                                            //Sets all entered fields to empty, ready for next profile creation.
                                            NewUsername_textbox.Text = null;
                                            Newpassword_textbox.Text = null;
                                            AgeCreation_textbox.Text = null;
                                            NameCreation_textbox.Text = null;
                                            Newpasswordconf_textbox.Text = null;
                                            UseUsername_checkbox.Checked = false;
                                            WantToProvideAge_checkbox.Checked = false;
                                            //Sets the currently active profile to be the one that was just created.
                                            ProfileScreenProfileInstance = NewProfile;
                                            //Updates the combo box to add the new profile to the list of profiles available.
                                            UpdateProfilesListBoxData();
                                            //Changes the selected index of the combo box to be the profile that was just created.
                                            Profileselection_combobox.SelectedIndex = ProfileScreenProfileInstance.Profilenumber - 1;
                                            //Hides the profile creation panel to make the screen cleaner and easier to view.
                                            Newprofile_panel.Visible = false;
                                            //Informs the user of the changes and that they were successful and are now signed in.
                                            MessageBox.Show("Everything is ok. Profile created and signed into.");
                                        }
                                        catch
                                        {
                                            MessageBox.Show("The program was unable to create a profile to the provided specifications.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("It would seem that you have not entered in your age correctly, remember, if you do not wish to enter an age then check the box that states that you do not wish to enter an age.");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Please only use numbers when entering your age.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("A name must be entered, if you do not wish to enter a name then you can tick the box to the right of the field use only your username as your name.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please click and drag one of the potential profile images from the profile images menu onto your new profile image.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and password confirmation must match.");
                    }
                }
                else
                {
                    MessageBox.Show("Password must be between 5 and 30 characters long.");
                }
                
            }
            else
            {
                MessageBox.Show("Username must contain between 3 and 30 characters long.");
            }
        }

        private void Profile_screen_Load(object sender, EventArgs e)
        {
            //Updates combobox with profiles that the user can select.
            UpdateProfilesListBoxData();
            //Sets it so as the profile creation imagebox can be dragged to.
            NewProfileImage_imagebox.AllowDrop = true;
            //If the user is already signed in, the screen starts up with their current profile pre selected.
            if (ProfileScreenProfileInstance != null)
            {
                Profileselection_combobox.SelectedIndex = ProfileScreenProfileInstance.Profilenumber -1;
                MenuItemGame_button.Enabled = true;
            }

            //Updates the checkbox for sound being muted to be correct to whether it is muted.
            if (ProfileSoundMuted == true)
            {
                MenuItemSound_button.Checked = false;
            }

            //Updates the checkbox for music being muted to be correct to whether it is muted.
            if (ProfileMusicMuted == true)
            {
                MenuItemMusic_button.Checked = false;
            }
        }

        private void Password_textbox_TextChanged(object sender, EventArgs e)
        {
            //Checks that there is something in the password field and enables/disables the use profile button accordingly.
            profile_selection_button_enabler_disabler();
        }

        private void NewUsername_textbox_TextChanged(object sender, EventArgs e)
        {
            //Determines whether the create profile button is active due to whether the necessary fields are filled in.
            profile_creation_button_enabler_disabler();
            //Updates name to be username if the user does not wish to input a name.
            if (UseUsername_checkbox.Checked == true)
            {
                NameCreation_textbox.Text = NewUsername_textbox.Text;
            }
        }

        private void Newpassword_textbox_TextChanged(object sender, EventArgs e)
        {
            //Determines whether the profile can be created based on the necessary information being inputted.
            profile_creation_button_enabler_disabler();
        }

        private void Newpasswordconf_textbox_TextChanged(object sender, EventArgs e)
        {
            //Determines whether the profile can be created based on the necessary information being inputted.
            profile_creation_button_enabler_disabler();
        }

        private void Profile_screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ensures the application does not close if the form closes due to a simple changing of the screen.
            if (ChangingForm == false)
            {
                Application.Exit();
            }
        }

        private void PictureChoice1_picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            //States the number of image that was selected for later confirmation, sets the temporary picturebox location and calls the drag drop method.
            PicturePending = 1;
            DragDropSender = (PictureBox)sender;
            DragDropMethod();
        }
        private void PictureChoice2_picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            //States the number of image that was selected for later confirmation, sets the temporary picturebox location and calls the drag drop method.
            PicturePending = 2;
            DragDropSender = (PictureBox)sender;
            DragDropMethod();
        }
        private void PictureChoice3_picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            //States the number of image that was selected for later confirmation, sets the temporary picturebox location and calls the drag drop method.
            PicturePending = 3;
            DragDropSender = (PictureBox)sender;
            DragDropMethod();
        }
        private void PictureChoice4_picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            //States the number of image that was selected for later confirmation, sets the temporary picturebox location and calls the drag drop method.
            PicturePending = 4;
            DragDropSender = (PictureBox)sender;
            DragDropMethod();
        }
        private void PictureChoice5_picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            //States the number of image that was selected for later confirmation, sets the temporary picturebox location and calls the drag drop method.
            PicturePending = 5;
            DragDropSender = (PictureBox)sender;
            DragDropMethod();
        }

        public void DragDropMethod()
        {
            //performs a drag drop with the image and the copy effect.
            DoDragDrop(DragDropSender.Image, DragDropEffects.Copy);
        }

        private void NewProfileImage_imagebox_DragEnter(object sender, DragEventArgs e)
        {
            //Shows the effect of the drag drop.
            e.Effect = DragDropEffects.Copy;
        }

        private void NewProfileImage_imagebox_DragDrop(object sender, DragEventArgs e)
        {
            //Creates a location for the destination which is set to be the sender so as it can be treated as a picturebox. The image of the Picturebox is set to be that of the dragged droped image and the final image number is set to be the number of the pending image.
            PictureBox destination = (PictureBox)sender;
            destination.Image = (Bitmap)e.Data.GetData(typeof(Bitmap));
            PictureNo = PicturePending;
        }

        //Updates the list of profiles available within the combobox.
        public void UpdateProfilesListBoxData()
        {
            //Refreshes the Combobox to research for all profile instances contained within the bin file and displays them in a list within the combobox.
            //Removes current items.
            Profileselection_combobox.Items.Clear();
            try
            {
                //Opens and reads the bin.
                sr = File.OpenRead("profiles.bin");
                try
                {
                    //Loops through each profile instance and adds them to the combobox with their profile number displayed with them.
                    while (sr.Position < sr.Length)
                    {
                        TempProfileLocation = (Profile)bf.Deserialize(sr);
                        Profileselection_combobox.Items.Add(TempProfileLocation.Profilenumber + " - " + TempProfileLocation.ProfileName);
                    }
                }
                catch
                {
                    MessageBox.Show("An error was encountered while attempting to update the items within the profile list dropdown box, please try restarting the program to fix this issue, if this does not work, then please contact the developer for a fix.");
                }
                //Closes and disposes of the filestream as it is no longer required within this method.
                sr.Close();
            }
            catch
            {
                MessageBox.Show("An unexpected error was detected when attempting to access the profiles bin folder. This may mean the folder does not exist or this program for whatever reason does not have access to it. Please try and restart this program to solve the issue, if this does not fix the issue please contact the developer.");
            }
        }

        private void Profileselection_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assigns the currently selected profile to be the one that was clicked within the combobox.
            int SelectedProfileNo;
            //Flags for the while loop to continue looping.
            bool Proceed = true;
            //Determines the profile number of the selected profile.
            SelectedProfileNo = int.Parse(Profileselection_combobox.SelectedItem.ToString().Substring(0, Profileselection_combobox.SelectedItem.ToString().IndexOf(' ')));
            try
            {
                //Opens and reads the profiles bin file.
                sr = File.OpenRead("profiles.bin");
                try
                {
                    //Loops through each profile until the correct one is found.
                    while (sr.Position < sr.Length && Proceed == true)
                    {
                        TempProfileLocation = (Profile)bf.Deserialize(sr);
                        //Checks if the current profile is the correct one and if it is proceeds to stop the loop from looping and sets the texts to the correct values relevant to this profile.
                        if (TempProfileLocation.Profilenumber == SelectedProfileNo)
                        {
                            Proceed = false;
                            NameDisplay_label.Text = TempProfileLocation.Name;
                            AgeDisplay_label.Text = TempProfileLocation.Age;
                            //Clears the high scores tables so new information can be put in.
                            EasyScores_rtb.Text = null;
                            MediumScores_rtb.Text = null;
                            HardScores_rtb.Text = null;
                            //Loops through the scores for each difficulty for this profile and takes the best ones to be placed into the best scores text box.
                            for (short ScoreRank = 0; ScoreRank < 10; ScoreRank++)
                            {
                                if (TempProfileLocation.HighestScoresEasy[ScoreRank] != 1000)
                                {
                                    EasyScores_rtb.Text += ScoreRank+1 + " - " + TempProfileLocation.HighestScoresEasy[ScoreRank] + "\n";
                                }
                                else
                                {
                                    EasyScores_rtb.Text += ScoreRank+1 + " - \n";
                                }
                                if (TempProfileLocation.HighestScoresMedium[ScoreRank] != 1000)
                                {
                                    MediumScores_rtb.Text += ScoreRank+1 + " - " + TempProfileLocation.HighestScoresMedium[ScoreRank] + "\n";
                                }
                                else
                                {
                                    MediumScores_rtb.Text += ScoreRank+1 + " - \n";
                                }
                                if (TempProfileLocation.HighestScoresHard[ScoreRank] != 1000)
                                {
                                    HardScores_rtb.Text += ScoreRank+1 + " - " + TempProfileLocation.HighestScoresHard[ScoreRank] + "\n";
                                }
                                else
                                {
                                    HardScores_rtb.Text += ScoreRank+1 + " - \n";
                                }
                            }
                        }
                    }
                    CurrentProfileImage_imagebox.Image = ProfileImages_imagelist.Images[TempProfileLocation.Image];
                }
                catch
                {
                    MessageBox.Show("An unexpected error was detected while attempting to recieve information regarding the selected acccount. This may be as a result of an error within the file or due to incorrect formatting, please try restarting the program and if the problem persists then please contact the developer for a fix to this issue.");
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error was detected when attempting to access the profiles bin folder. This may mean the folder does not exist or this program for whatever reason does not have access to it. Please try and restart this program to solve the issue, if this does not fix the issue please contact the developer.");
            }
            //Closes and disposes the filestream.
            sr.Close();
        }

        private void UseUsername_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //Toggles whether the user wishes to provide a name to the program and instead replaces it with the username and makes it so as it is not a required field for input.
            if (UseUsername_checkbox.Checked == true)
            {
                NameCreation_textbox.Enabled = false;
                NameCreation_textbox.Text = NewUsername_textbox.Text;
            }
            else
            {
                NameCreation_textbox.Enabled = true;
                NameCreation_textbox.Text = null;
            }
        }

        private void WantToProvideAge_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //Toggles whether the user wishes to provide an age to the program and instead replaces it with the string "N/A" and makes it so as it is not a required field.
            if (WantToProvideAge_checkbox.Checked == true)
            {
                AgeCreation_textbox.Enabled = false;
                AgeCreation_textbox.Text = "N/A";
            }
            else
            {
                AgeCreation_textbox.Enabled = true;
                AgeCreation_textbox.Text = null;
            }
        }

        //Counts the current number of profiles in existance within the bin file.
        private int CountProfiles()
        {
            //Runs through the bin file counting the number of profiles that exist currently.
            //Sets item number to 0 for recounting.
            ItemNo = 0;
            try
            {
                //Opens and starts to read the bin file.
                sr = File.OpenRead("profiles.bin");
                try
                {
                    while(sr.Position < sr.Length)
                    {
                        //Reads the profile and increases the number that have been counted by one.
                        bf.Deserialize(sr);
                        ItemNo++;
                    }
                }
                catch
                {
                    MessageBox.Show("An error occured while moving through the profile list.");
                }
            }
            catch
            {
                MessageBox.Show("The file Profiles.bin could not be opened.");
            }
            //Closes and disposes of the filestream.
            sr.Close();
            return ItemNo;
        }

        private void OpenProfileCreation_button_Click(object sender, EventArgs e)
        {
            //Causes the panel which allows the user to create a new profile to appear (toggles it).
            if (Newprofile_panel.Visible == false)
            {
                Newprofile_panel.Visible = true;
            }
            else
            {
                Newprofile_panel.Visible = false;
            }
        }

        private void NewUsername_textbox_Enter(object sender, EventArgs e)
        {
            //Displays information on the selected field.
            TooltipDisplay_rtb.Text = "Minimum 4 characters, maximum 20 characters.";
        }

        private void NameCreation_textbox_Enter(object sender, EventArgs e)
        {
            //Displays information on the selected field.
            TooltipDisplay_rtb.Text = "This is the name by which the game will call you, it must be entered but you can call yourself whatever you want (25 character limit).";
        }

        private void AgeCreation_textbox_Enter(object sender, EventArgs e)
        {
            //Displays information on the selected field.
            TooltipDisplay_rtb.Text = "This is the age you want your minesweeper character to be, you can be as old as you like (not older than 999 but still pretty old), this feild is not necessary and can be ignored if you so wish. (if nothing is inputted your age will appear as 'NA')";
        }

        private void Newpassword_textbox_Enter(object sender, EventArgs e)
        {
            //Displays information on the selected field.
            TooltipDisplay_rtb.Text = "Minimum 4 characters, maximum 20 characters, and must match the confirmation password.";
        }

        private void Newpasswordconf_textbox_Enter(object sender, EventArgs e)
        {
            //Displays information on the selected field.
            TooltipDisplay_rtb.Text = "Minimum 4 characters, maximum 20 characters, and must match the password.";
        }

        private void ToolTipEnd_Leave(object sender, EventArgs e)
        {
            //Clears the information presented within the rich text box.
            TooltipDisplay_rtb.Text = null;
        }

        private void MenuItemHelp_button_Click(object sender, EventArgs e)
        {
            //Opens the help screen in another window.
            Help_screen HelpScreen = new Help_screen();
            HelpScreen.Show();
        }

        private void MenuItemMainMenu_button_Click(object sender, EventArgs e)
        {
            //Sends the user to the main menu through use of the main menu transition method.
            MainMenuTransition();
        }

        private void MenuItemOptions_button_Click(object sender, EventArgs e)
        {
            //Sends the user to the options screen, it also changes the changing form bool to true so as the application does not close
            ChangingForm = true;
            Options_screen OptionsScreen = new Options_screen(ProfileScreenProfileInstance, ProfileMusicMuted, ProfileSoundMuted);
            OptionsScreen.Show();
            this.Close();
        }

        private void MenuItemGame_button_Click(object sender, EventArgs e)
        {
            //Sends the user to the game screen, it also changes the changing form bool to true so as the application does not close
            ChangingForm = true;
            Game_screen GameScreen = new Game_screen(ProfileScreenProfileInstance, ProfileMusicMuted, ProfileSoundMuted);
            GameScreen.Show();
            this.Close();
        }

        private void MenuItemSound_button_CheckedChanged(object sender, EventArgs e)
        {
            //Updates the state of the muted game sound to whether or not it is muted.
            if (MenuItemSound_button.Checked == false)
            {
                ProfileSoundMuted = true;
            }
            else
            {
                ProfileSoundMuted = false;
            }
        }

        private void MenuItemMusic_button_CheckedChanged(object sender, EventArgs e)
        {
            //Updates the state of the muted music to whether or not it is muted.
            if (MenuItemMusic_button.Checked == false)
            {
                ProfileMusicMuted = true;
            }
            else
            {
                ProfileMusicMuted = false;
            }
        }

        private void MenuItemExit_button_Click(object sender, EventArgs e)
        {
            //Closes the application.
            Application.Exit();
        }

        private void UseProfile_button_Click(object sender, EventArgs e)
        {
            //Checks if the entered password is correct for the currently selected profile and if it is, sets the active profile to be the selected profile. After this it enables the ability for the user to go to the game screen as they are now signed in.
            if (Password_textbox.Text == TempProfileLocation.Password)
            {
                //Displays to the user that they were successful in signing in.
                MessageBox.Show("Password accepted -- Profile Changed.");
                //Updates profile to be the active profile.
                ProfileScreenProfileInstance = TempProfileLocation;
                //Enables the ability to click on the game button.
                MenuItemGame_button.Enabled = true;
            }
            else
            {
                //Tells the user that they incorrectly inputted the password.
                MessageBox.Show("This password is incorrect, please try again.");
            }
        }
    }
}

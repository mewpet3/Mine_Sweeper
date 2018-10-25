using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

///This form is used for the player to play the game itself and where the player will likely spent most of their time in this application.

namespace Mine_Sweeper
{
    public partial class Game_screen : Form
    {
        //Creates a bool for changing form which causes the program not to close if this screen is changing and closes itself.
        bool ChangingForm = false;
        //Bool that changes based on whether the game is running.
        bool GameRunning = false;
        //Determines the number of mines there will be.
        int MineNo;
        //Determines the size along the x axis of the playing area.
        int sizex;
        //Determines the size along the y axis of the playing area.
        int sizey;
        //Determines the location currently in use by the program along the x axis.
        int UseLocationx;
        //Determines the location currently in use by the program along the y axis. 
        int UseLocationy;
        //Determines the current x location on the grid of where the cells are being placed.
        int CurLocationX;
        //Determines the current y location on the grid of where the cells are being placed.
        int CurLocationY;
        //Determines how long the game has been going on for as that is the score.
        int CurScore;
        //Random number generator used to determine where mines are placed.
        Random rng = new Random();
        //Creates a 2 dimentional array for each button that would be a cell in the game.
        Button[,] MineSlot;
        //Sets a random variable for use by the random number generator.
        int random;
        //Sets a second random variable for use by the random number generator.
        int random2;
        //Variable used to count the surrounding mines around a specified cell.
        int MineSurroundCount;
        //Tracks how many mines there are left unflagged.
        int ActualMinesRemaining;
        //Determines whether when the game ends if it was a victory or a failure.
        bool EndVictory = false;
        //Creates an instance of the bomb exposion sound effect for later use.
        SoundPlayer BombSoundPlayer = new SoundPlayer(Properties.Resources.Bomb_SoundEffect);
        //Creates an instance of the victory sound effect for later use.
        SoundPlayer VictorySoundPlayer = new SoundPlayer(Properties.Resources.Win_SoundEffect);
        //Creates an instance of the clicking sound effect for later use.
        SoundPlayer ClickFeedbackSoundPlayer = new SoundPlayer(Properties.Resources.SatisfyingFeedback_SoundEffect);
        //Creates an instance of the profile class.
        Profile GameScreenProfileInstance;
        //Determines whether the game music is muted or not.
        bool GameMusicMuted;
        //Determines whether the game sound effects are muted or not.
        bool GameSoundMuted;

        public Game_screen(Profile Profile, bool MusicMuted, bool SoundMuted)
        {
            InitializeComponent();
            //Sets the game screen instance of the profile to be the current instance of the profile.
            GameScreenProfileInstance = Profile;
            //Updates whether the game music is currently muted.
            GameMusicMuted = MusicMuted;
            //Updates whether the game sound is currently muted.
            GameSoundMuted = SoundMuted;
        }

        private void Game_screen_Load(object sender, EventArgs e)
        {
            //Decides which difficulty is active and changes the game values based on the results.
            switch(GameScreenProfileInstance.Difficulty)
            {
                case 0:
                    {
                        //difficulty is custom and so game variables are set based on the previously determined preferences of the player which are saved to the profile class.
                        sizex = GameScreenProfileInstance.Xsize;
                        sizey = GameScreenProfileInstance.Ysize;
                        MineNo = GameScreenProfileInstance.BombNo;
                        break;
                    }
                case 1:
                    {
                        //difficuty is set to easy so game variables are set to easy preset.
                        sizex = 8;
                        sizey = 8;
                        MineNo = 10;
                        break;
                    }
                case 2:
                    {
                        //difficulty is set to medium so game variables are set to medium preset.
                        sizex = 16;
                        sizey = 16;
                        MineNo = 40;
                        break;
                    }
                case 3:
                    {
                        //difficulty is set to hard so game variables are set to hard preset.
                        sizex = 32;
                        sizey = 16;
                        MineNo = 99;
                        break;
                    }
            }

            //Checks if the game sound is muted and if so updates the menu bar as to this fact.
            if (GameSoundMuted == true)
            {
                MenuItemSound_button.Checked = false;
            }

            //Checks if the game music is muted and if so updates the menu bar as to this fact.
            if (GameMusicMuted == true)
            {
                MenuItemMusic_button.Checked = false;
            }
            //Sets the maximum value of the loading bar so as it is correctly calculated to load as things generate at the correct pace.
            GameLoad_progressbar.Maximum = (sizex * sizey);
        }

        private void Main_MenuTransition()
        {
            //Sets changing form to true so as the program does not close when changing form. Creates a new instance of the main menu screen, shows it and closes the current screen.
            ChangingForm = true;
            Main_menu Main_menu_screen = new Main_menu(GameScreenProfileInstance, GameMusicMuted, GameSoundMuted);
            Main_menu_screen.Show();
            this.Close();
        }

        private void Main_Menu_button_Click(object sender, EventArgs e)
        {
            //Checks if the user really wants to leave (only if the game is running) and if they do, send them to the main menu.
            if (ConfirmToLeave() == true)
            {
                Main_MenuTransition();
            }
        }

        private bool ConfirmToLeave()
        {
            //Checks that the game is running and if so asks the user if they are sure that they want to leave as their score will not be saved and their progress will be lost.
            bool Confirm = false;
            if (GameRunning == true)
            {
                //Displays message box with input as to whether or not they want to leave.
                if (MessageBox.Show("Are you sure you want to leave? If you do, your score will not save and the game will reset.", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Sets confirm to true as they wish to leave and ends the game and returns it all to normal before returning the user to the specified screen.
                    Confirm = true;
                    EndGame();
                    Game_timer.Enabled = false;
                    TimeDisplay_label.Text = "0";
                    RemoveMines();
                    Start_button.Enabled = true;
                }
            }
            else
            {
                //If the game is not running then they have nothing to lose if they leave confirming that they wish to leave.
                Confirm = true;
            }
            //Returns the conformation as to whether or not they wish to leave.
            return Confirm;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            //Sets the loading bar to 0 so as it starts from the start and making it visible, and then runs through the startup process by first setting the game to running.
            GameLoad_progressbar.Value = 0;
            GameLoad_progressbar.Visible = true;
            GameRunning = true;
            //Sets the number of mines remaining active to the number that exist.
            ActualMinesRemaining = MineNo;
            //Generates the cells.
            GenerateMineSlots();
            //Generates the mines within the cells randomly.
            GenerateMines();
            //Generates the number values representing how many mines surround each cell.
            GenerateNumbers();
            //disables the start button so as it cannot be pressed while the game is already running.
            Start_button.Enabled = false;
            //Enables the reset button so as the game can be reset at any time.
            Reset_button.Enabled = true;
            //Enables the timer to start counting and tracking the score.
            Game_timer.Enabled = true;
            //Disables the progress bar as it should be full by this point and loading is complete.
            GameLoad_progressbar.Visible = false;
        }

        private void Game_timer_Tick(object sender, EventArgs e)
        {
            //Increases the score variable and sets the score time display to represent the current score.
            CurScore++;
            TimeDisplay_label.Text = CurScore.ToString();
            if (CurScore == 999)
            {
                Game_timer.Stop();
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            //Resets the game screen by first stopping the timer,
            Game_timer.Enabled = false;
            //resetting the time display,
            TimeDisplay_label.Text = "0";
            //setting the current number of mines to 0,
            MinesCounter_label.Text = "0";
            //removing all the mineslots,
            RemoveMines();
            //reenabling the start button so as they can play again
            Start_button.Enabled = true;
            //and disabling the reset button as the game has now been reset.
            Reset_button.Enabled = false;
        }

        private void GenerateMineSlots()
        {
            //sets the current y locaton of the first row of cells to be 1 pixel down from the top of the panel.
            CurLocationY = 1;
            //Sets the bounds of the array of the mineslots to be equal to the number of mineslots there are along the x and y axis.
            MineSlot = new Button[sizex,sizey];
            //Sets the height of the buttons to be adaptable based on the number of them there are so as they can always all fit into the form by dividing the height of it by the number of them there are and subtracting it by 1 so as there is a bit of space..
            int ButtonHeight = (Game_panel.Height / sizey) -1;
            //Loops through all of the buttons within the array and sets up their default values (with the y axis).
            for (UseLocationy = 0; UseLocationy < sizey; UseLocationy++)
            {
                //sets the current x location of the first cell on the left to be 1 pixel to the right of the left of the panel.
                CurLocationX = 1;
                //Loops through all of the buttons within the array and sets up their default values (with the x axis).
                for (UseLocationx = 0; UseLocationx < sizex; UseLocationx++)
                {
                    //Creates a new instance of the button in that location.
                    MineSlot[UseLocationx, UseLocationy] = new Button();
                    //Sets it height to be accurate to the rest of them so they all fit.
                    MineSlot[UseLocationx, UseLocationy].Height = ButtonHeight;
                    //Sets the width to be equal to the height so they all remain square.
                    MineSlot[UseLocationx, UseLocationy].Width = ButtonHeight;
                    //Sets distance from the left of the panel to be equal to the current location x.
                    MineSlot[UseLocationx, UseLocationy].Left = CurLocationX;
                    //Sets distance from the top of the panel to be equal to the current location y.
                    MineSlot[UseLocationx, UseLocationy].Top = CurLocationY;
                    //Sets the Colour of the buttons to be white (to suit asthetic).
                    MineSlot[UseLocationx, UseLocationy].BackColor = System.Drawing.Color.White;
                    //Sets the image layout for the buttons to be stretch so the image will fit no matter the size of the button (unless ver small).
                    MineSlot[UseLocationx, UseLocationy].BackgroundImageLayout = ImageLayout.Stretch;
                    //Sets the tag of the buttons to be equal to their position within the array for future use.
                    MineSlot[UseLocationx, UseLocationy].Tag = (":" + UseLocationx + "," + UseLocationy).ToString();
                    //Increases the distance from the left of the screen by the distance of the height of the buttons.
                    CurLocationX += ButtonHeight +1;
                    //Adds the created button to the control (panel) so as it is displayed to the viewer.
                    Game_panel.Controls.Add(MineSlot[UseLocationx, UseLocationy]);
                    //Creates an event for when one of the buttons are clicked.
                    MineSlot[UseLocationx,UseLocationy].MouseDown += new MouseEventHandler(MineSlot_MouseDown);
                    //Increases the progress bars progress.
                    GameLoad_progressbar.Value += 1;
                }
                //Increases the distance from the top of the screen by the length of the buttons.
                CurLocationY += ButtonHeight +1;
            }
        }

        private void GenerateMines()
        {
            //Randomly places mines throughout the cells that are generated.
            //A loop that keeps going until there are the number of mines that was pre determined by the difficulty.
            for (int MineCount = 0; MineCount < MineNo; )
            {
                //Generates a new random number for the x coordinate.
                random = rng.Next(0,sizex);
                //Generates a new random number for the y coordinate.
                random2 = rng.Next(0,sizey);
                //Checkes if the location it is about to place a mine already has a mine and if it does, it does not increment the MineCount so the loop continues an extra time.
                if (MineSlot[random, random2].Tag.ToString().Substring(0, 1) != "m")
                {
                    //Sets the tag so as it can later be used to determine that this slot is a mine.
                    MineSlot[random, random2].Tag = "m" + MineSlot[random, random2].Tag;
                    MineCount++;
                }
            }
            //Displays on screen the number of mines that exist in the game.
            MinesCounter_label.Text = MineNo.ToString();
        }

        private void GenerateNumbers()
        {
            //Loops through every slot on screen and if it is not a mine it counts the number of mines surrounding it and places it into the tag.
            for (UseLocationy = 0; UseLocationy < sizey; UseLocationy++)
            {
                for (UseLocationx = 0; UseLocationx < sizex; UseLocationx++)
                {
                    //Determines the counted mines.
                    MineSurroundCount = 0;
                    //Tests if selected slot is a mine.
                    if (MineSlot[UseLocationx, UseLocationy].Tag.ToString().Substring(0, 1) != "m")
                    {
                        //Calls method to count the number of mines around this slot.
                        CountSurroundingForMines();
                        //Tags the selected slot to state the number of mines around it for future use.
                        MineSlot[UseLocationx, UseLocationy].Tag = MineSurroundCount.ToString() + MineSlot[UseLocationx,UseLocationy].Tag;
                    }
                }
            }
        }

        //Runs through each direction from the selected slot and if it is a mine increases the mine surround count by 1 if the slot in that direction is not outside the bounds of the array.
        private void CountSurroundingForMines()
        {            
            if (UseLocationx - 1 > -1 && UseLocationy - 1 > -1)
            {
                if (MineSlot[UseLocationx - 1, UseLocationy - 1].Tag.ToString().Substring(0, 1) == "m")
                {
                    MineSurroundCount++;
                }
            }

            if (UseLocationy - 1 > -1)
            {
                if (MineSlot[UseLocationx, UseLocationy - 1].Tag.ToString().Substring(0, 1) == "m")
                {
                    MineSurroundCount++;
                }
            }

            if (UseLocationx + 1 < sizex && UseLocationy - 1 > -1)
            {
                if (MineSlot[UseLocationx + 1, UseLocationy - 1].Tag.ToString().Substring(0, 1) == "m")
                {
                    MineSurroundCount++;
                }
            }

            if (UseLocationx - 1 > -1)
            {
                if (MineSlot[UseLocationx - 1, UseLocationy].Tag.ToString().Substring(0, 1) == "m")
                {
                    MineSurroundCount++;
                }
            }

            if (UseLocationx + 1 < sizex)
            {
                if (MineSlot[UseLocationx + 1, UseLocationy].Tag.ToString().Substring(0, 1) == "m")
                {
                    MineSurroundCount++;
                }
            }

            if (UseLocationx - 1 > -1 && UseLocationy + 1 < sizey)
            {
                if (MineSlot[UseLocationx - 1, UseLocationy + 1].Tag.ToString().Substring(0, 1) == "m")
                {
                    MineSurroundCount++;
                }
            }

            if (UseLocationy + 1 < sizey)
            {
                if (MineSlot[UseLocationx, UseLocationy + 1].Tag.ToString().Substring(0, 1) == "m")
                {
                    MineSurroundCount++;
                }
            }

            if (UseLocationx + 1 < sizex && UseLocationy + 1 < sizey)
            {
                if (MineSlot[UseLocationx + 1, UseLocationy + 1].Tag.ToString().Substring(0, 1) == "m")
                {
                    MineSurroundCount++;
                }
            }
        }

        //Runs through each mine slot and removes it from the panel and gamescreen so as to clear it.
        private void RemoveMines()
        {
            //loops through slots.
            for (int ForRemovalY = 0; ForRemovalY < sizey; ForRemovalY++ )
            {
                for (int ForRemovalX = 0; ForRemovalX < sizex; ForRemovalX++)
                {
                    //Removes them from the control.
                    Game_panel.Controls.Remove(MineSlot[ForRemovalX, ForRemovalY]);
                }
            }
        }

        //Occurs when a minesclot is clicked and provides feedback on what was clicked and also determines whether the game was won or not.
        private void MineSlot_MouseDown(object sender, MouseEventArgs e)
        {
            //Plays click sound is sound is not muted.
            if (GameSoundMuted == false)
            {
                ClickFeedbackSoundPlayer.Play();
            }
            //Sets the variable clickedbutton as the button that was clicked.
            Button ClickedButton = sender as Button;
            //Checkes if the button was left clicked and that the clicked button was not flagged.
            if (e.Button == System.Windows.Forms.MouseButtons.Left && ClickedButton.Text != "Flag!")
            {
                //Checks if the clicked button was a mine, if so the player loses and the game ends.
                if (ClickedButton.Tag.ToString().Contains('m'))
                {
                    //Displays mine image.
                    ClickedButton.BackgroundImage = Icons_imagelist.Images[0];
                    //Displays informative text stating that it was a mine.
                    ClickedButton.Text = "mine";
                    //Ends the game.
                    EndGame();
                }
                else
                {
                    //if the clicked button was not a mine then it displays the number of mines that surrounds it, which was stored in the first character of the tag.
                    ClickedButton.Text = ClickedButton.Tag.ToString().Substring(0,1);
                }
            }
            //Tests if it was a right click and if so flags the location if it is not already flagged and if so, removes the flag.
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (ClickedButton.Text != "Flag!")
                {
                    //Does not allow the user to place more flags than there are mines.
                    if (int.Parse(MinesCounter_label.Text) != 0)
                    {
                        //Places text on the clicked button stating that it is flagged.
                        ClickedButton.Text = "Flag!";
                        //Sets the image to be a flag.
                        ClickedButton.BackgroundImage = Icons_imagelist.Images[1];
                        //Decreases the number of mines displayed within the mine count display.
                        MinesCounter_label.Text = (int.Parse(MinesCounter_label.Text) - 1).ToString();
                        //If the flag was correctly placed the actual mines remaining count decreases by one and if there are no mines remaining the game ends with a victory.
                        if (ClickedButton.Tag.ToString().Substring(0, 1) == "m")
                        {
                            ActualMinesRemaining -= 1;
                            if (ActualMinesRemaining == 0)
                            {
                                EndVictory = true;
                                EndGame();
                            }
                        }
                    }
                }
                else
                {
                    //A flag is removed if a flag is right clicked and is made blank once more and the background image is removed with it.
                    //increases the mine count label by one.
                    MinesCounter_label.Text = (int.Parse(MinesCounter_label.Text) + 1).ToString();
                    //removes text.
                    ClickedButton.Text = "";
                    //removes image.
                    ClickedButton.BackgroundImage = null;
                    //if the flag was correct it increases the number of actual mines remaining by one.
                    if (ClickedButton.Tag.ToString().Substring(0,1) == "m")
                    {
                        ActualMinesRemaining += 1;
                    }
                }
            }
        }

        //Handles the ending of the game.
        private void EndGame()
        {
            //Sets the game to no longer run.
            GameRunning = false;
            //Stops the timer from counting.
            Game_timer.Stop();
            //Loops through each mineslot and disables them so the user can no longer interact with them. If the endgame was due to a loss or the attempt to quit mid game all of the mines will be revealed.
            for (UseLocationy = 0; UseLocationy < sizey; UseLocationy++)
            {
                for (UseLocationx = 0; UseLocationx < sizex; UseLocationx++)
                {
                    MineSlot[UseLocationx, UseLocationy].Enabled = false;
                    if (EndVictory == false)
                    {
                        if (MineSlot[UseLocationx, UseLocationy].Tag.ToString().Contains('m'))
                        {
                            MineSlot[UseLocationx, UseLocationy].Text = "Mine";
                            MineSlot[UseLocationx, UseLocationy].BackgroundImage = Icons_imagelist.Images[0];
                        }
                    }
                }
            }
            //If the ending was due to a victory then the score will be saved to the profile if it was better than any of the scores saved there and it will then be sorted, a message will be displayed as well congratulating the player on their success and displaying to them their achieved score. A congratulatory tune is also played if sound is not muted.
            if (EndVictory == true)
            {
                //Victory sound is played if sound is not muted.
                if (GameSoundMuted == false)
                {
                    VictorySoundPlayer.Play();
                }
                //Congratulates player and displays their new score.
                MessageBox.Show("Congrats, you won the game! You did a fantastic job!\nYou finished in " + CurScore + " seconds.");
                //Places the score into the array of the current profile and sorts it.
                GameScreenProfileInstance.ReturnScoreToHighScoreArray(CurScore);
                //Overwrites the profile in the bin file with the new information.
                GameScreenProfileInstance.UpdateProfileDetails(GameScreenProfileInstance);
                //Changes the endvictory to false for the next game.
                EndVictory = false;
            }
            //Bomb sound effect is played if the player lost the game or left the game before finishing if sound is not muted.
            else if (GameSoundMuted == false)
            {
                BombSoundPlayer.Play();
            }
            //The current score is set to 0 for the next playthrough.
            CurScore = 0;
        }

        private void Game_screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If the screen is not closing due to changing form then the entire application is closed.
            if (ChangingForm == false)
            {
                Application.Exit();
            }
        }

        private void MenuItemHelp_button_Click(object sender, EventArgs e)
        {
            //Opens the help window.
            Help_screen HelpScreen = new Help_screen();
            HelpScreen.Show();
        }

        private void MenuItemMainMenu_button_Click(object sender, EventArgs e)
        {
            //If they are sure they wish to leave they are sent to the main menu.
            if (ConfirmToLeave() == true)
            {
                Main_MenuTransition();
            }
        }

        private void MenuItemOptions_button_Click(object sender, EventArgs e)
        {
            //If they are sure they wish to leave they are sent to the options screen.
            if (ConfirmToLeave() == true)
            {
                ChangingForm = true;
                Options_screen OptionsScreen = new Options_screen(GameScreenProfileInstance, GameMusicMuted, GameSoundMuted);
                OptionsScreen.Show();
                this.Close();
            }
        }

        private void MenuItemGame_button_Click(object sender, EventArgs e)
        {
            //If they are sure they wish to leave they are sent to the m.
            if (ConfirmToLeave() == true)
            {
                ChangingForm = true;
                Game_screen GameScreen = new Game_screen(GameScreenProfileInstance, GameMusicMuted, GameSoundMuted);
                GameScreen.Show();
                this.Close();
            }
        }

        private void MenuItemProfile_button_Click(object sender, EventArgs e)
        {
            //If they are sure they wish to leave they are sent to the profile screen.
            if (ConfirmToLeave() == true)
            {
                ChangingForm = true;
                Profile_screen ProfileScreen = new Profile_screen(GameScreenProfileInstance, GameMusicMuted, GameSoundMuted);
                ProfileScreen.Show();
                this.Close();
            }
        }

        private void MenuItemSound_button_CheckedChanged(object sender, EventArgs e)
        {
            //Toggles the game sound off and on.
            if (MenuItemSound_button.Checked == false)
            {
                GameSoundMuted = true;
            }
            else
            {
                GameSoundMuted = false;
            }
        }

        private void MenuItemMusic_button_CheckedChanged(object sender, EventArgs e)
        {
            //Toggles the game music off and on.
            if (MenuItemMusic_button.Checked == false)
            {
                GameMusicMuted = true;
            }
            else
            {
                GameMusicMuted = false;
            }
        }

        private void MenuItemExit_button_Click(object sender, EventArgs e)
        {
            //If the user is sure they wish to leave then the application closes.
            if (ConfirmToLeave() == true)
            {
                Application.Exit();
            }
        }
    }
}
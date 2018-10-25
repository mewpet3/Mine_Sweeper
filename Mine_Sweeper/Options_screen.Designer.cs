namespace Mine_Sweeper
{
    partial class Options_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Menu_button = new System.Windows.Forms.Button();
            this.Easy_checkbox = new System.Windows.Forms.CheckBox();
            this.Difficultytitle_label = new System.Windows.Forms.Label();
            this.Medium_checkbox = new System.Windows.Forms.CheckBox();
            this.Hard_checkbox = new System.Windows.Forms.CheckBox();
            this.Custom_checkbox = new System.Windows.Forms.CheckBox();
            this.PlayAreaWidth_label = new System.Windows.Forms.Label();
            this.Difficulties_panel = new System.Windows.Forms.Panel();
            this.GameSettingsTitle_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ApplyPermanent_button = new System.Windows.Forms.Button();
            this.TotalSlotsDisplay = new System.Windows.Forms.Label();
            this.PlayHeight_trackbar = new System.Windows.Forms.TrackBar();
            this.PlayWidth_trackbar = new System.Windows.Forms.TrackBar();
            this.PlayAreaHeight_label = new System.Windows.Forms.Label();
            this.WidthDisplay_label = new System.Windows.Forms.Label();
            this.HeightDisplay_label = new System.Windows.Forms.Label();
            this.MinMaxHeight_label = new System.Windows.Forms.Label();
            this.MinMaxWidth_label = new System.Windows.Forms.Label();
            this.BombNumber_trackbar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.BombNoDisplay_label = new System.Windows.Forms.Label();
            this.MinBombNoDisplay_label = new System.Windows.Forms.Label();
            this.MaxBombNoDisplay_label = new System.Windows.Forms.Label();
            this.MinBombNo_label = new System.Windows.Forms.Label();
            this.MaxBombNo_label = new System.Windows.Forms.Label();
            this.TechnicalSettings_panel = new System.Windows.Forms.Panel();
            this.SoundEffectsStatus_label = new System.Windows.Forms.Label();
            this.SoundMusicStatus_label = new System.Windows.Forms.Label();
            this.MuteMusic_button = new System.Windows.Forms.Button();
            this.MuteSound_button = new System.Windows.Forms.Button();
            this.TechnicalSettingsTitle_label = new System.Windows.Forms.Label();
            this.GameMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemGoToDropDown_button = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMainMenu_button = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOptions_button = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGame_button = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProfile_button = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp_button = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsDropDown_button = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMusic_button = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSound_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Difficulties_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayHeight_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayWidth_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombNumber_trackbar)).BeginInit();
            this.TechnicalSettings_panel.SuspendLayout();
            this.GameMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Menu_button
            // 
            this.Main_Menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Menu_button.Location = new System.Drawing.Point(9, 596);
            this.Main_Menu_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_Menu_button.Name = "Main_Menu_button";
            this.Main_Menu_button.Size = new System.Drawing.Size(243, 88);
            this.Main_Menu_button.TabIndex = 0;
            this.Main_Menu_button.Text = "Main Menu";
            this.Main_Menu_button.UseVisualStyleBackColor = true;
            this.Main_Menu_button.Click += new System.EventHandler(this.Main_Menu_button_Click);
            // 
            // Easy_checkbox
            // 
            this.Easy_checkbox.AutoSize = true;
            this.Easy_checkbox.Location = new System.Drawing.Point(2, 30);
            this.Easy_checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Easy_checkbox.Name = "Easy_checkbox";
            this.Easy_checkbox.Size = new System.Drawing.Size(49, 17);
            this.Easy_checkbox.TabIndex = 5;
            this.Easy_checkbox.Text = "Easy";
            this.Easy_checkbox.UseVisualStyleBackColor = true;
            this.Easy_checkbox.CheckedChanged += new System.EventHandler(this.Easy_checkbox_CheckedChanged);
            // 
            // Difficultytitle_label
            // 
            this.Difficultytitle_label.AutoSize = true;
            this.Difficultytitle_label.Location = new System.Drawing.Point(3, 4);
            this.Difficultytitle_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Difficultytitle_label.Name = "Difficultytitle_label";
            this.Difficultytitle_label.Size = new System.Drawing.Size(138, 13);
            this.Difficultytitle_label.TabIndex = 6;
            this.Difficultytitle_label.Text = "Difficulty - Medium is default";
            // 
            // Medium_checkbox
            // 
            this.Medium_checkbox.AutoSize = true;
            this.Medium_checkbox.Checked = true;
            this.Medium_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Medium_checkbox.Location = new System.Drawing.Point(2, 53);
            this.Medium_checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Medium_checkbox.Name = "Medium_checkbox";
            this.Medium_checkbox.Size = new System.Drawing.Size(63, 17);
            this.Medium_checkbox.TabIndex = 7;
            this.Medium_checkbox.Text = "Medium";
            this.Medium_checkbox.UseVisualStyleBackColor = true;
            this.Medium_checkbox.CheckedChanged += new System.EventHandler(this.Medium_checkbox_CheckedChanged);
            // 
            // Hard_checkbox
            // 
            this.Hard_checkbox.AutoSize = true;
            this.Hard_checkbox.Location = new System.Drawing.Point(2, 76);
            this.Hard_checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hard_checkbox.Name = "Hard_checkbox";
            this.Hard_checkbox.Size = new System.Drawing.Size(49, 17);
            this.Hard_checkbox.TabIndex = 8;
            this.Hard_checkbox.Text = "Hard";
            this.Hard_checkbox.UseVisualStyleBackColor = true;
            this.Hard_checkbox.CheckedChanged += new System.EventHandler(this.Hard_checkbox_CheckedChanged);
            // 
            // Custom_checkbox
            // 
            this.Custom_checkbox.AutoSize = true;
            this.Custom_checkbox.Location = new System.Drawing.Point(2, 98);
            this.Custom_checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Custom_checkbox.Name = "Custom_checkbox";
            this.Custom_checkbox.Size = new System.Drawing.Size(61, 17);
            this.Custom_checkbox.TabIndex = 9;
            this.Custom_checkbox.Text = "Custom";
            this.Custom_checkbox.UseVisualStyleBackColor = true;
            this.Custom_checkbox.CheckedChanged += new System.EventHandler(this.Custom_checkbox_CheckedChanged);
            this.Custom_checkbox.Click += new System.EventHandler(this.Custom_checkbox_Click);
            // 
            // PlayAreaWidth_label
            // 
            this.PlayAreaWidth_label.AutoSize = true;
            this.PlayAreaWidth_label.Location = new System.Drawing.Point(594, 57);
            this.PlayAreaWidth_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayAreaWidth_label.Name = "PlayAreaWidth_label";
            this.PlayAreaWidth_label.Size = new System.Drawing.Size(115, 13);
            this.PlayAreaWidth_label.TabIndex = 11;
            this.PlayAreaWidth_label.Text = "Play area size:    Width";
            // 
            // Difficulties_panel
            // 
            this.Difficulties_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Difficulties_panel.Controls.Add(this.GameSettingsTitle_label);
            this.Difficulties_panel.Controls.Add(this.Custom_checkbox);
            this.Difficulties_panel.Controls.Add(this.Easy_checkbox);
            this.Difficulties_panel.Controls.Add(this.Difficultytitle_label);
            this.Difficulties_panel.Controls.Add(this.Medium_checkbox);
            this.Difficulties_panel.Controls.Add(this.Hard_checkbox);
            this.Difficulties_panel.Controls.Add(this.label4);
            this.Difficulties_panel.Controls.Add(this.PlayAreaWidth_label);
            this.Difficulties_panel.Location = new System.Drawing.Point(9, 33);
            this.Difficulties_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Difficulties_panel.Name = "Difficulties_panel";
            this.Difficulties_panel.Size = new System.Drawing.Size(1165, 338);
            this.Difficulties_panel.TabIndex = 15;
            // 
            // GameSettingsTitle_label
            // 
            this.GameSettingsTitle_label.AutoSize = true;
            this.GameSettingsTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameSettingsTitle_label.Location = new System.Drawing.Point(494, 4);
            this.GameSettingsTitle_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameSettingsTitle_label.Name = "GameSettingsTitle_label";
            this.GameSettingsTitle_label.Size = new System.Drawing.Size(137, 25);
            this.GameSettingsTitle_label.TabIndex = 17;
            this.GameSettingsTitle_label.Text = "Game settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Note: If selecting custom, high scores will not be saved.";
            // 
            // ApplyPermanent_button
            // 
            this.ApplyPermanent_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyPermanent_button.Location = new System.Drawing.Point(535, 644);
            this.ApplyPermanent_button.Name = "ApplyPermanent_button";
            this.ApplyPermanent_button.Size = new System.Drawing.Size(641, 39);
            this.ApplyPermanent_button.TabIndex = 18;
            this.ApplyPermanent_button.Text = "Apply settings to this session and set them as my profile default.";
            this.ApplyPermanent_button.UseVisualStyleBackColor = true;
            this.ApplyPermanent_button.Click += new System.EventHandler(this.ApplyPermanent_button_Click);
            // 
            // TotalSlotsDisplay
            // 
            this.TotalSlotsDisplay.AutoSize = true;
            this.TotalSlotsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSlotsDisplay.Location = new System.Drawing.Point(719, 193);
            this.TotalSlotsDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalSlotsDisplay.Name = "TotalSlotsDisplay";
            this.TotalSlotsDisplay.Size = new System.Drawing.Size(352, 24);
            this.TotalSlotsDisplay.TabIndex = 19;
            this.TotalSlotsDisplay.Text = "Total slots that will appear on screen: 100";
            // 
            // PlayHeight_trackbar
            // 
            this.PlayHeight_trackbar.Enabled = false;
            this.PlayHeight_trackbar.Location = new System.Drawing.Point(723, 113);
            this.PlayHeight_trackbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayHeight_trackbar.Maximum = 25;
            this.PlayHeight_trackbar.Minimum = 5;
            this.PlayHeight_trackbar.Name = "PlayHeight_trackbar";
            this.PlayHeight_trackbar.Size = new System.Drawing.Size(338, 45);
            this.PlayHeight_trackbar.TabIndex = 20;
            this.PlayHeight_trackbar.Value = 10;
            this.PlayHeight_trackbar.Scroll += new System.EventHandler(this.PlayHeight_trackbar_Scroll);
            // 
            // PlayWidth_trackbar
            // 
            this.PlayWidth_trackbar.Enabled = false;
            this.PlayWidth_trackbar.Location = new System.Drawing.Point(723, 63);
            this.PlayWidth_trackbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayWidth_trackbar.Maximum = 50;
            this.PlayWidth_trackbar.Minimum = 5;
            this.PlayWidth_trackbar.Name = "PlayWidth_trackbar";
            this.PlayWidth_trackbar.Size = new System.Drawing.Size(338, 45);
            this.PlayWidth_trackbar.TabIndex = 21;
            this.PlayWidth_trackbar.Value = 10;
            this.PlayWidth_trackbar.Scroll += new System.EventHandler(this.PlayWidth_trackbar_Scroll);
            // 
            // PlayAreaHeight_label
            // 
            this.PlayAreaHeight_label.AutoSize = true;
            this.PlayAreaHeight_label.Location = new System.Drawing.Point(604, 113);
            this.PlayAreaHeight_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayAreaHeight_label.Name = "PlayAreaHeight_label";
            this.PlayAreaHeight_label.Size = new System.Drawing.Size(118, 13);
            this.PlayAreaHeight_label.TabIndex = 22;
            this.PlayAreaHeight_label.Text = "Play area size:    Height";
            // 
            // WidthDisplay_label
            // 
            this.WidthDisplay_label.AutoSize = true;
            this.WidthDisplay_label.Location = new System.Drawing.Point(1065, 72);
            this.WidthDisplay_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthDisplay_label.Name = "WidthDisplay_label";
            this.WidthDisplay_label.Size = new System.Drawing.Size(19, 13);
            this.WidthDisplay_label.TabIndex = 23;
            this.WidthDisplay_label.Text = "16";
            // 
            // HeightDisplay_label
            // 
            this.HeightDisplay_label.AutoSize = true;
            this.HeightDisplay_label.Location = new System.Drawing.Point(1065, 122);
            this.HeightDisplay_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightDisplay_label.Name = "HeightDisplay_label";
            this.HeightDisplay_label.Size = new System.Drawing.Size(19, 13);
            this.HeightDisplay_label.TabIndex = 24;
            this.HeightDisplay_label.Text = "16";
            // 
            // MinMaxHeight_label
            // 
            this.MinMaxHeight_label.AutoSize = true;
            this.MinMaxHeight_label.Location = new System.Drawing.Point(1014, 147);
            this.MinMaxHeight_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinMaxHeight_label.Name = "MinMaxHeight_label";
            this.MinMaxHeight_label.Size = new System.Drawing.Size(134, 13);
            this.MinMaxHeight_label.TabIndex = 25;
            this.MinMaxHeight_label.Text = "(Minimum: 5, Maximum: 25)";
            // 
            // MinMaxWidth_label
            // 
            this.MinMaxWidth_label.AutoSize = true;
            this.MinMaxWidth_label.Location = new System.Drawing.Point(1014, 97);
            this.MinMaxWidth_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinMaxWidth_label.Name = "MinMaxWidth_label";
            this.MinMaxWidth_label.Size = new System.Drawing.Size(134, 13);
            this.MinMaxWidth_label.TabIndex = 26;
            this.MinMaxWidth_label.Text = "(Minimum: 5, Maximum: 50)";
            // 
            // BombNumber_trackbar
            // 
            this.BombNumber_trackbar.Enabled = false;
            this.BombNumber_trackbar.Location = new System.Drawing.Point(723, 279);
            this.BombNumber_trackbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BombNumber_trackbar.Maximum = 25;
            this.BombNumber_trackbar.Minimum = 5;
            this.BombNumber_trackbar.Name = "BombNumber_trackbar";
            this.BombNumber_trackbar.Size = new System.Drawing.Size(338, 45);
            this.BombNumber_trackbar.TabIndex = 27;
            this.BombNumber_trackbar.Value = 10;
            this.BombNumber_trackbar.Scroll += new System.EventHandler(this.BombNumber_trackbar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Number of bombs:";
            // 
            // BombNoDisplay_label
            // 
            this.BombNoDisplay_label.AutoSize = true;
            this.BombNoDisplay_label.Location = new System.Drawing.Point(1065, 288);
            this.BombNoDisplay_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BombNoDisplay_label.Name = "BombNoDisplay_label";
            this.BombNoDisplay_label.Size = new System.Drawing.Size(19, 13);
            this.BombNoDisplay_label.TabIndex = 29;
            this.BombNoDisplay_label.Text = "40";
            // 
            // MinBombNoDisplay_label
            // 
            this.MinBombNoDisplay_label.AutoSize = true;
            this.MinBombNoDisplay_label.Location = new System.Drawing.Point(738, 327);
            this.MinBombNoDisplay_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinBombNoDisplay_label.Name = "MinBombNoDisplay_label";
            this.MinBombNoDisplay_label.Size = new System.Drawing.Size(13, 13);
            this.MinBombNoDisplay_label.TabIndex = 30;
            this.MinBombNoDisplay_label.Text = "5";
            // 
            // MaxBombNoDisplay_label
            // 
            this.MaxBombNoDisplay_label.AutoSize = true;
            this.MaxBombNoDisplay_label.Location = new System.Drawing.Point(969, 327);
            this.MaxBombNoDisplay_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxBombNoDisplay_label.Name = "MaxBombNoDisplay_label";
            this.MaxBombNoDisplay_label.Size = new System.Drawing.Size(25, 13);
            this.MaxBombNoDisplay_label.TabIndex = 31;
            this.MaxBombNoDisplay_label.Text = "100";
            // 
            // MinBombNo_label
            // 
            this.MinBombNo_label.AutoSize = true;
            this.MinBombNo_label.Location = new System.Drawing.Point(625, 327);
            this.MinBombNo_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinBombNo_label.Name = "MinBombNo_label";
            this.MinBombNo_label.Size = new System.Drawing.Size(110, 13);
            this.MinBombNo_label.TabIndex = 32;
            this.MinBombNo_label.Text = "Minimum bomb count:";
            // 
            // MaxBombNo_label
            // 
            this.MaxBombNo_label.AutoSize = true;
            this.MaxBombNo_label.Location = new System.Drawing.Point(854, 327);
            this.MaxBombNo_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxBombNo_label.Name = "MaxBombNo_label";
            this.MaxBombNo_label.Size = new System.Drawing.Size(113, 13);
            this.MaxBombNo_label.TabIndex = 33;
            this.MaxBombNo_label.Text = "Maximum bomb count:";
            // 
            // TechnicalSettings_panel
            // 
            this.TechnicalSettings_panel.AutoSize = true;
            this.TechnicalSettings_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TechnicalSettings_panel.Controls.Add(this.SoundEffectsStatus_label);
            this.TechnicalSettings_panel.Controls.Add(this.SoundMusicStatus_label);
            this.TechnicalSettings_panel.Controls.Add(this.MuteMusic_button);
            this.TechnicalSettings_panel.Controls.Add(this.MuteSound_button);
            this.TechnicalSettings_panel.Controls.Add(this.TechnicalSettingsTitle_label);
            this.TechnicalSettings_panel.Location = new System.Drawing.Point(9, 376);
            this.TechnicalSettings_panel.Name = "TechnicalSettings_panel";
            this.TechnicalSettings_panel.Size = new System.Drawing.Size(1165, 215);
            this.TechnicalSettings_panel.TabIndex = 34;
            // 
            // SoundEffectsStatus_label
            // 
            this.SoundEffectsStatus_label.AutoSize = true;
            this.SoundEffectsStatus_label.Location = new System.Drawing.Point(272, 60);
            this.SoundEffectsStatus_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SoundEffectsStatus_label.Name = "SoundEffectsStatus_label";
            this.SoundEffectsStatus_label.Size = new System.Drawing.Size(187, 13);
            this.SoundEffectsStatus_label.TabIndex = 18;
            this.SoundEffectsStatus_label.Text = "Sound effects are not currently muted.";
            // 
            // SoundMusicStatus_label
            // 
            this.SoundMusicStatus_label.AutoSize = true;
            this.SoundMusicStatus_label.Location = new System.Drawing.Point(272, 154);
            this.SoundMusicStatus_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SoundMusicStatus_label.Name = "SoundMusicStatus_label";
            this.SoundMusicStatus_label.Size = new System.Drawing.Size(141, 13);
            this.SoundMusicStatus_label.TabIndex = 19;
            this.SoundMusicStatus_label.Text = "Music is not currently muted.";
            // 
            // MuteMusic_button
            // 
            this.MuteMusic_button.Location = new System.Drawing.Point(6, 121);
            this.MuteMusic_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MuteMusic_button.Name = "MuteMusic_button";
            this.MuteMusic_button.Size = new System.Drawing.Size(262, 79);
            this.MuteMusic_button.TabIndex = 20;
            this.MuteMusic_button.Text = "Mute music";
            this.MuteMusic_button.UseVisualStyleBackColor = true;
            this.MuteMusic_button.Click += new System.EventHandler(this.MuteMusic_button_Click);
            // 
            // MuteSound_button
            // 
            this.MuteSound_button.Location = new System.Drawing.Point(6, 27);
            this.MuteSound_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MuteSound_button.Name = "MuteSound_button";
            this.MuteSound_button.Size = new System.Drawing.Size(262, 79);
            this.MuteSound_button.TabIndex = 19;
            this.MuteSound_button.Text = "Mute sound effects";
            this.MuteSound_button.UseVisualStyleBackColor = true;
            this.MuteSound_button.Click += new System.EventHandler(this.MuteSound_button_Click);
            // 
            // TechnicalSettingsTitle_label
            // 
            this.TechnicalSettingsTitle_label.AutoSize = true;
            this.TechnicalSettingsTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicalSettingsTitle_label.Location = new System.Drawing.Point(479, 0);
            this.TechnicalSettingsTitle_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TechnicalSettingsTitle_label.Name = "TechnicalSettingsTitle_label";
            this.TechnicalSettingsTitle_label.Size = new System.Drawing.Size(169, 25);
            this.TechnicalSettingsTitle_label.TabIndex = 18;
            this.TechnicalSettingsTitle_label.Text = "Technical settings";
            // 
            // GameMenuStrip
            // 
            this.GameMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GameMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGoToDropDown_button,
            this.MenuItemHelp_button,
            this.MenuItemToolsDropDown_button});
            this.GameMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GameMenuStrip.Name = "GameMenuStrip";
            this.GameMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.GameMenuStrip.Size = new System.Drawing.Size(1186, 24);
            this.GameMenuStrip.TabIndex = 35;
            this.GameMenuStrip.Text = "GameMenuStrip";
            // 
            // MenuItemGoToDropDown_button
            // 
            this.MenuItemGoToDropDown_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemMainMenu_button,
            this.MenuItemOptions_button,
            this.MenuItemGame_button,
            this.MenuItemProfile_button,
            this.toolStripSeparator1,
            this.MenuItemExit_button});
            this.MenuItemGoToDropDown_button.Name = "MenuItemGoToDropDown_button";
            this.MenuItemGoToDropDown_button.Size = new System.Drawing.Size(51, 20);
            this.MenuItemGoToDropDown_button.Text = "Go To";
            // 
            // MenuItemMainMenu_button
            // 
            this.MenuItemMainMenu_button.Name = "MenuItemMainMenu_button";
            this.MenuItemMainMenu_button.Size = new System.Drawing.Size(152, 22);
            this.MenuItemMainMenu_button.Text = "Main Menu";
            this.MenuItemMainMenu_button.Click += new System.EventHandler(this.MenuItemMainMenu_button_Click);
            // 
            // MenuItemOptions_button
            // 
            this.MenuItemOptions_button.Checked = true;
            this.MenuItemOptions_button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemOptions_button.Enabled = false;
            this.MenuItemOptions_button.Name = "MenuItemOptions_button";
            this.MenuItemOptions_button.Size = new System.Drawing.Size(152, 22);
            this.MenuItemOptions_button.Text = "Options";
            // 
            // MenuItemGame_button
            // 
            this.MenuItemGame_button.Enabled = false;
            this.MenuItemGame_button.Name = "MenuItemGame_button";
            this.MenuItemGame_button.Size = new System.Drawing.Size(152, 22);
            this.MenuItemGame_button.Text = "Game";
            this.MenuItemGame_button.Click += new System.EventHandler(this.MenuItemGame_button_Click);
            // 
            // MenuItemProfile_button
            // 
            this.MenuItemProfile_button.Name = "MenuItemProfile_button";
            this.MenuItemProfile_button.Size = new System.Drawing.Size(152, 22);
            this.MenuItemProfile_button.Text = "Profiles";
            this.MenuItemProfile_button.Click += new System.EventHandler(this.MenuItemProfile_button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItemExit_button
            // 
            this.MenuItemExit_button.Name = "MenuItemExit_button";
            this.MenuItemExit_button.Size = new System.Drawing.Size(152, 22);
            this.MenuItemExit_button.Text = "Exit";
            this.MenuItemExit_button.Click += new System.EventHandler(this.MenuItemExit_button_Click);
            // 
            // MenuItemHelp_button
            // 
            this.MenuItemHelp_button.Name = "MenuItemHelp_button";
            this.MenuItemHelp_button.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHelp_button.Text = "Help";
            this.MenuItemHelp_button.Click += new System.EventHandler(this.MenuItemHelp_button_Click);
            // 
            // MenuItemToolsDropDown_button
            // 
            this.MenuItemToolsDropDown_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemMusic_button,
            this.MenuItemSound_button});
            this.MenuItemToolsDropDown_button.Name = "MenuItemToolsDropDown_button";
            this.MenuItemToolsDropDown_button.Size = new System.Drawing.Size(48, 20);
            this.MenuItemToolsDropDown_button.Text = "Tools";
            // 
            // MenuItemMusic_button
            // 
            this.MenuItemMusic_button.Checked = true;
            this.MenuItemMusic_button.CheckOnClick = true;
            this.MenuItemMusic_button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemMusic_button.Name = "MenuItemMusic_button";
            this.MenuItemMusic_button.Size = new System.Drawing.Size(113, 22);
            this.MenuItemMusic_button.Text = "Music";
            this.MenuItemMusic_button.CheckedChanged += new System.EventHandler(this.MenuItemMusic_button_CheckedChanged);
            // 
            // MenuItemSound_button
            // 
            this.MenuItemSound_button.Checked = true;
            this.MenuItemSound_button.CheckOnClick = true;
            this.MenuItemSound_button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemSound_button.Name = "MenuItemSound_button";
            this.MenuItemSound_button.Size = new System.Drawing.Size(113, 22);
            this.MenuItemSound_button.Text = "Sounds";
            this.MenuItemSound_button.CheckedChanged += new System.EventHandler(this.MenuItemSound_button_CheckedChanged);
            // 
            // Options_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.GameMenuStrip);
            this.Controls.Add(this.TechnicalSettings_panel);
            this.Controls.Add(this.MaxBombNo_label);
            this.Controls.Add(this.MinBombNo_label);
            this.Controls.Add(this.MaxBombNoDisplay_label);
            this.Controls.Add(this.MinBombNoDisplay_label);
            this.Controls.Add(this.BombNoDisplay_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BombNumber_trackbar);
            this.Controls.Add(this.MinMaxWidth_label);
            this.Controls.Add(this.MinMaxHeight_label);
            this.Controls.Add(this.HeightDisplay_label);
            this.Controls.Add(this.WidthDisplay_label);
            this.Controls.Add(this.PlayAreaHeight_label);
            this.Controls.Add(this.PlayWidth_trackbar);
            this.Controls.Add(this.PlayHeight_trackbar);
            this.Controls.Add(this.TotalSlotsDisplay);
            this.Controls.Add(this.ApplyPermanent_button);
            this.Controls.Add(this.Difficulties_panel);
            this.Controls.Add(this.Main_Menu_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Options_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_screen_FormClosing);
            this.Load += new System.EventHandler(this.Options_screen_Load);
            this.Difficulties_panel.ResumeLayout(false);
            this.Difficulties_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayHeight_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayWidth_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombNumber_trackbar)).EndInit();
            this.TechnicalSettings_panel.ResumeLayout(false);
            this.TechnicalSettings_panel.PerformLayout();
            this.GameMenuStrip.ResumeLayout(false);
            this.GameMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Main_Menu_button;
        private System.Windows.Forms.CheckBox Easy_checkbox;
        private System.Windows.Forms.Label Difficultytitle_label;
        private System.Windows.Forms.CheckBox Medium_checkbox;
        private System.Windows.Forms.CheckBox Hard_checkbox;
        private System.Windows.Forms.CheckBox Custom_checkbox;
        private System.Windows.Forms.Label PlayAreaWidth_label;
        private System.Windows.Forms.Panel Difficulties_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ApplyPermanent_button;
        private System.Windows.Forms.Label TotalSlotsDisplay;
        private System.Windows.Forms.TrackBar PlayHeight_trackbar;
        private System.Windows.Forms.TrackBar PlayWidth_trackbar;
        private System.Windows.Forms.Label PlayAreaHeight_label;
        private System.Windows.Forms.Label WidthDisplay_label;
        private System.Windows.Forms.Label HeightDisplay_label;
        private System.Windows.Forms.Label MinMaxHeight_label;
        private System.Windows.Forms.Label MinMaxWidth_label;
        private System.Windows.Forms.TrackBar BombNumber_trackbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BombNoDisplay_label;
        private System.Windows.Forms.Label MinBombNoDisplay_label;
        private System.Windows.Forms.Label MaxBombNoDisplay_label;
        private System.Windows.Forms.Label MinBombNo_label;
        private System.Windows.Forms.Label MaxBombNo_label;
        private System.Windows.Forms.Label GameSettingsTitle_label;
        private System.Windows.Forms.Panel TechnicalSettings_panel;
        private System.Windows.Forms.Label TechnicalSettingsTitle_label;
        private System.Windows.Forms.Button MuteMusic_button;
        private System.Windows.Forms.Button MuteSound_button;
        private System.Windows.Forms.Label SoundEffectsStatus_label;
        private System.Windows.Forms.Label SoundMusicStatus_label;
        private System.Windows.Forms.MenuStrip GameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGoToDropDown_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMainMenu_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOptions_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGame_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProfile_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsDropDown_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMusic_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSound_button;
    }
}
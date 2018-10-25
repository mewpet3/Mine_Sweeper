namespace Mine_Sweeper
{
    partial class Game_screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_screen));
            this.Main_Menu_button = new System.Windows.Forms.Button();
            this.Game_panel = new System.Windows.Forms.Panel();
            this.TimeDisplayLabel_label = new System.Windows.Forms.Label();
            this.TimeDisplay_label = new System.Windows.Forms.Label();
            this.Game_timer = new System.Windows.Forms.Timer(this.components);
            this.Start_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.MinesCounterLabel_label = new System.Windows.Forms.Label();
            this.MinesCounter_label = new System.Windows.Forms.Label();
            this.Icons_imagelist = new System.Windows.Forms.ImageList(this.components);
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
            this.GameLoad_progressbar = new System.Windows.Forms.ProgressBar();
            this.GameMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Menu_button
            // 
            this.Main_Menu_button.Location = new System.Drawing.Point(27, 634);
            this.Main_Menu_button.Margin = new System.Windows.Forms.Padding(2);
            this.Main_Menu_button.Name = "Main_Menu_button";
            this.Main_Menu_button.Size = new System.Drawing.Size(1203, 39);
            this.Main_Menu_button.TabIndex = 0;
            this.Main_Menu_button.Text = "Main Menu";
            this.Main_Menu_button.UseVisualStyleBackColor = true;
            this.Main_Menu_button.Click += new System.EventHandler(this.Main_Menu_button_Click);
            // 
            // Game_panel
            // 
            this.Game_panel.AutoScroll = true;
            this.Game_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Game_panel.Location = new System.Drawing.Point(27, 70);
            this.Game_panel.Margin = new System.Windows.Forms.Padding(2);
            this.Game_panel.Name = "Game_panel";
            this.Game_panel.Size = new System.Drawing.Size(1203, 535);
            this.Game_panel.TabIndex = 1;
            // 
            // TimeDisplayLabel_label
            // 
            this.TimeDisplayLabel_label.AutoSize = true;
            this.TimeDisplayLabel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDisplayLabel_label.Location = new System.Drawing.Point(23, 43);
            this.TimeDisplayLabel_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeDisplayLabel_label.Name = "TimeDisplayLabel_label";
            this.TimeDisplayLabel_label.Size = new System.Drawing.Size(108, 24);
            this.TimeDisplayLabel_label.TabIndex = 2;
            this.TimeDisplayLabel_label.Text = "Time taken:";
            // 
            // TimeDisplay_label
            // 
            this.TimeDisplay_label.AutoSize = true;
            this.TimeDisplay_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDisplay_label.Location = new System.Drawing.Point(138, 45);
            this.TimeDisplay_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeDisplay_label.Name = "TimeDisplay_label";
            this.TimeDisplay_label.Size = new System.Drawing.Size(20, 24);
            this.TimeDisplay_label.TabIndex = 3;
            this.TimeDisplay_label.Text = "0";
            // 
            // Game_timer
            // 
            this.Game_timer.Interval = 1000;
            this.Game_timer.Tick += new System.EventHandler(this.Game_timer_Tick);
            // 
            // Start_button
            // 
            this.Start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_button.Location = new System.Drawing.Point(1137, 30);
            this.Start_button.Margin = new System.Windows.Forms.Padding(2);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(93, 37);
            this.Start_button.TabIndex = 4;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Enabled = false;
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.Location = new System.Drawing.Point(1029, 30);
            this.Reset_button.Margin = new System.Windows.Forms.Padding(2);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(105, 37);
            this.Reset_button.TabIndex = 5;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // MinesCounterLabel_label
            // 
            this.MinesCounterLabel_label.AutoSize = true;
            this.MinesCounterLabel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinesCounterLabel_label.Location = new System.Drawing.Point(234, 43);
            this.MinesCounterLabel_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinesCounterLabel_label.Name = "MinesCounterLabel_label";
            this.MinesCounterLabel_label.Size = new System.Drawing.Size(66, 24);
            this.MinesCounterLabel_label.TabIndex = 6;
            this.MinesCounterLabel_label.Text = "Mines:";
            // 
            // MinesCounter_label
            // 
            this.MinesCounter_label.AutoSize = true;
            this.MinesCounter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinesCounter_label.Location = new System.Drawing.Point(305, 45);
            this.MinesCounter_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinesCounter_label.Name = "MinesCounter_label";
            this.MinesCounter_label.Size = new System.Drawing.Size(20, 24);
            this.MinesCounter_label.TabIndex = 7;
            this.MinesCounter_label.Text = "0";
            // 
            // Icons_imagelist
            // 
            this.Icons_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons_imagelist.ImageStream")));
            this.Icons_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons_imagelist.Images.SetKeyName(0, "Mine.png");
            this.Icons_imagelist.Images.SetKeyName(1, "Minesweeper flag.png");
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
            this.GameMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.GameMenuStrip.Size = new System.Drawing.Size(1265, 24);
            this.GameMenuStrip.TabIndex = 18;
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
            this.MenuItemOptions_button.Name = "MenuItemOptions_button";
            this.MenuItemOptions_button.Size = new System.Drawing.Size(152, 22);
            this.MenuItemOptions_button.Text = "Options";
            this.MenuItemOptions_button.Click += new System.EventHandler(this.MenuItemOptions_button_Click);
            // 
            // MenuItemGame_button
            // 
            this.MenuItemGame_button.Checked = true;
            this.MenuItemGame_button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemGame_button.Enabled = false;
            this.MenuItemGame_button.Name = "MenuItemGame_button";
            this.MenuItemGame_button.Size = new System.Drawing.Size(152, 22);
            this.MenuItemGame_button.Text = "Game";
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
            // GameLoad_progressbar
            // 
            this.GameLoad_progressbar.Location = new System.Drawing.Point(27, 608);
            this.GameLoad_progressbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GameLoad_progressbar.Name = "GameLoad_progressbar";
            this.GameLoad_progressbar.Size = new System.Drawing.Size(1202, 18);
            this.GameLoad_progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.GameLoad_progressbar.TabIndex = 0;
            this.GameLoad_progressbar.Visible = false;
            // 
            // Game_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1265, 682);
            this.Controls.Add(this.GameLoad_progressbar);
            this.Controls.Add(this.GameMenuStrip);
            this.Controls.Add(this.MinesCounter_label);
            this.Controls.Add(this.MinesCounterLabel_label);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.TimeDisplay_label);
            this.Controls.Add(this.TimeDisplayLabel_label);
            this.Controls.Add(this.Game_panel);
            this.Controls.Add(this.Main_Menu_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mine Sweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_screen_FormClosing);
            this.Load += new System.EventHandler(this.Game_screen_Load);
            this.GameMenuStrip.ResumeLayout(false);
            this.GameMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Main_Menu_button;
        private System.Windows.Forms.Panel Game_panel;
        private System.Windows.Forms.Label TimeDisplayLabel_label;
        private System.Windows.Forms.Label TimeDisplay_label;
        private System.Windows.Forms.Timer Game_timer;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Label MinesCounterLabel_label;
        private System.Windows.Forms.Label MinesCounter_label;
        private System.Windows.Forms.ImageList Icons_imagelist;
        private System.Windows.Forms.MenuStrip GameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGoToDropDown_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMainMenu_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOptions_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGame_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProfile_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsDropDown_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMusic_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSound_button;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ProgressBar GameLoad_progressbar;
    }
}
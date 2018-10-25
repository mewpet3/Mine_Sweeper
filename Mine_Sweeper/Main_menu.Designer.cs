namespace Mine_Sweeper
{
    partial class Main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.Play_button = new System.Windows.Forms.Button();
            this.Options_button = new System.Windows.Forms.Button();
            this.Quit_button = new System.Windows.Forms.Button();
            this.Profiles_button = new System.Windows.Forms.Button();
            this.UserNotFound_label = new System.Windows.Forms.Label();
            this.UserNotFound2_label = new System.Windows.Forms.Label();
            this.Hello_label = new System.Windows.Forms.Label();
            this.MenuProfileName_label = new System.Windows.Forms.Label();
            this.ProfileImages_imagelist = new System.Windows.Forms.ImageList(this.components);
            this.MenuProfilePicture_picturebox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.MenuProfilePicture_picturebox)).BeginInit();
            this.GameMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play_button
            // 
            this.Play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_button.Location = new System.Drawing.Point(370, 183);
            this.Play_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(375, 41);
            this.Play_button.TabIndex = 0;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Options_button
            // 
            this.Options_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options_button.Location = new System.Drawing.Point(370, 286);
            this.Options_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Options_button.Name = "Options_button";
            this.Options_button.Size = new System.Drawing.Size(375, 41);
            this.Options_button.TabIndex = 1;
            this.Options_button.Text = "Options";
            this.Options_button.UseVisualStyleBackColor = true;
            this.Options_button.Click += new System.EventHandler(this.Options_button_Click);
            // 
            // Quit_button
            // 
            this.Quit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_button.Location = new System.Drawing.Point(370, 403);
            this.Quit_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(375, 41);
            this.Quit_button.TabIndex = 3;
            this.Quit_button.Text = "Quit";
            this.Quit_button.UseVisualStyleBackColor = true;
            this.Quit_button.Click += new System.EventHandler(this.Quit_button_Click);
            // 
            // Profiles_button
            // 
            this.Profiles_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profiles_button.Location = new System.Drawing.Point(370, 343);
            this.Profiles_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Profiles_button.Name = "Profiles_button";
            this.Profiles_button.Size = new System.Drawing.Size(375, 41);
            this.Profiles_button.TabIndex = 5;
            this.Profiles_button.Text = "Profiles";
            this.Profiles_button.UseVisualStyleBackColor = true;
            this.Profiles_button.Click += new System.EventHandler(this.Profiles_button_Click);
            // 
            // UserNotFound_label
            // 
            this.UserNotFound_label.AutoSize = true;
            this.UserNotFound_label.Location = new System.Drawing.Point(471, 226);
            this.UserNotFound_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNotFound_label.Name = "UserNotFound_label";
            this.UserNotFound_label.Size = new System.Drawing.Size(163, 13);
            this.UserNotFound_label.TabIndex = 7;
            this.UserNotFound_label.Text = "Sorry, you need to sign in to play.";
            // 
            // UserNotFound2_label
            // 
            this.UserNotFound2_label.AutoSize = true;
            this.UserNotFound2_label.Location = new System.Drawing.Point(749, 358);
            this.UserNotFound2_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNotFound2_label.Name = "UserNotFound2_label";
            this.UserNotFound2_label.Size = new System.Drawing.Size(108, 13);
            this.UserNotFound2_label.TabIndex = 8;
            this.UserNotFound2_label.Text = "<-- Go here to sign in!";
            // 
            // Hello_label
            // 
            this.Hello_label.AutoSize = true;
            this.Hello_label.Location = new System.Drawing.Point(1023, 488);
            this.Hello_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hello_label.Name = "Hello_label";
            this.Hello_label.Size = new System.Drawing.Size(34, 13);
            this.Hello_label.TabIndex = 10;
            this.Hello_label.Text = "Hello,";
            // 
            // MenuProfileName_label
            // 
            this.MenuProfileName_label.AutoSize = true;
            this.MenuProfileName_label.Location = new System.Drawing.Point(1023, 501);
            this.MenuProfileName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuProfileName_label.Name = "MenuProfileName_label";
            this.MenuProfileName_label.Size = new System.Drawing.Size(101, 13);
            this.MenuProfileName_label.TabIndex = 11;
            this.MenuProfileName_label.Text = "[No profile selected]";
            // 
            // ProfileImages_imagelist
            // 
            this.ProfileImages_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ProfileImages_imagelist.ImageStream")));
            this.ProfileImages_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.ProfileImages_imagelist.Images.SetKeyName(0, "No_profile_image.png");
            this.ProfileImages_imagelist.Images.SetKeyName(1, "Temp_image_1.png");
            this.ProfileImages_imagelist.Images.SetKeyName(2, "Temp_image_2.png");
            this.ProfileImages_imagelist.Images.SetKeyName(3, "Temp_image_3.png");
            this.ProfileImages_imagelist.Images.SetKeyName(4, "Temp_image_4.png");
            this.ProfileImages_imagelist.Images.SetKeyName(5, "Temp_image_5.png");
            // 
            // MenuProfilePicture_picturebox
            // 
            this.MenuProfilePicture_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuProfilePicture_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuProfilePicture_picturebox.Image = global::Mine_Sweeper.Properties.Resources.No_profile_image;
            this.MenuProfilePicture_picturebox.InitialImage = null;
            this.MenuProfilePicture_picturebox.Location = new System.Drawing.Point(1025, 518);
            this.MenuProfilePicture_picturebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuProfilePicture_picturebox.Name = "MenuProfilePicture_picturebox";
            this.MenuProfilePicture_picturebox.Size = new System.Drawing.Size(150, 163);
            this.MenuProfilePicture_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuProfilePicture_picturebox.TabIndex = 9;
            this.MenuProfilePicture_picturebox.TabStop = false;
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
            this.GameMenuStrip.Size = new System.Drawing.Size(1184, 24);
            this.GameMenuStrip.TabIndex = 20;
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
            this.MenuItemMainMenu_button.Checked = true;
            this.MenuItemMainMenu_button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemMainMenu_button.Enabled = false;
            this.MenuItemMainMenu_button.Name = "MenuItemMainMenu_button";
            this.MenuItemMainMenu_button.Size = new System.Drawing.Size(152, 22);
            this.MenuItemMainMenu_button.Text = "Main Menu";
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
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 690);
            this.Controls.Add(this.MenuProfileName_label);
            this.Controls.Add(this.Hello_label);
            this.Controls.Add(this.MenuProfilePicture_picturebox);
            this.Controls.Add(this.UserNotFound2_label);
            this.Controls.Add(this.UserNotFound_label);
            this.Controls.Add(this.Profiles_button);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.Options_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.GameMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mine Sweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_menu_FormClosing);
            this.Load += new System.EventHandler(this.Main_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuProfilePicture_picturebox)).EndInit();
            this.GameMenuStrip.ResumeLayout(false);
            this.GameMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Options_button;
        private System.Windows.Forms.Button Quit_button;
        private System.Windows.Forms.Button Profiles_button;
        private System.Windows.Forms.Label UserNotFound_label;
        private System.Windows.Forms.Label UserNotFound2_label;
        private System.Windows.Forms.PictureBox MenuProfilePicture_picturebox;
        private System.Windows.Forms.Label Hello_label;
        private System.Windows.Forms.Label MenuProfileName_label;
        private System.Windows.Forms.ImageList ProfileImages_imagelist;
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
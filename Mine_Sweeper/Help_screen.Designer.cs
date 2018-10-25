namespace Mine_Sweeper
{
    partial class Help_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_screen));
            this.Close_button = new System.Windows.Forms.Button();
            this.Welcome_rtb = new System.Windows.Forms.RichTextBox();
            this.helpScreen_Tabcontrol = new System.Windows.Forms.TabControl();
            this.Welcome_tab = new System.Windows.Forms.TabPage();
            this.TheGame_tab = new System.Windows.Forms.TabPage();
            this.TheGame_rtb = new System.Windows.Forms.RichTextBox();
            this.TheGameImgInt_tab = new System.Windows.Forms.TabPage();
            this.TheGameImgs_rtb = new System.Windows.Forms.RichTextBox();
            this.TheGameImgFile_tab = new System.Windows.Forms.TabPage();
            this.TheGameImgsFile_rtb = new System.Windows.Forms.RichTextBox();
            this.Video_tab = new System.Windows.Forms.TabPage();
            this.VideoExample_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.helpScreen_Tabcontrol.SuspendLayout();
            this.Welcome_tab.SuspendLayout();
            this.TheGame_tab.SuspendLayout();
            this.TheGameImgInt_tab.SuspendLayout();
            this.TheGameImgFile_tab.SuspendLayout();
            this.Video_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoExample_wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.Location = new System.Drawing.Point(12, 690);
            this.Close_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(1059, 50);
            this.Close_button.TabIndex = 0;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Welcome_rtb
            // 
            this.Welcome_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Welcome_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_rtb.Location = new System.Drawing.Point(5, 6);
            this.Welcome_rtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Welcome_rtb.Name = "Welcome_rtb";
            this.Welcome_rtb.ReadOnly = true;
            this.Welcome_rtb.Size = new System.Drawing.Size(1039, 630);
            this.Welcome_rtb.TabIndex = 1;
            this.Welcome_rtb.Text = resources.GetString("Welcome_rtb.Text");
            // 
            // helpScreen_Tabcontrol
            // 
            this.helpScreen_Tabcontrol.Controls.Add(this.Welcome_tab);
            this.helpScreen_Tabcontrol.Controls.Add(this.TheGame_tab);
            this.helpScreen_Tabcontrol.Controls.Add(this.TheGameImgInt_tab);
            this.helpScreen_Tabcontrol.Controls.Add(this.TheGameImgFile_tab);
            this.helpScreen_Tabcontrol.Controls.Add(this.Video_tab);
            this.helpScreen_Tabcontrol.Location = new System.Drawing.Point(12, 12);
            this.helpScreen_Tabcontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpScreen_Tabcontrol.Name = "helpScreen_Tabcontrol";
            this.helpScreen_Tabcontrol.SelectedIndex = 0;
            this.helpScreen_Tabcontrol.Size = new System.Drawing.Size(1059, 672);
            this.helpScreen_Tabcontrol.TabIndex = 2;
            // 
            // Welcome_tab
            // 
            this.Welcome_tab.Controls.Add(this.Welcome_rtb);
            this.Welcome_tab.Location = new System.Drawing.Point(4, 25);
            this.Welcome_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Welcome_tab.Name = "Welcome_tab";
            this.Welcome_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Welcome_tab.Size = new System.Drawing.Size(1051, 643);
            this.Welcome_tab.TabIndex = 0;
            this.Welcome_tab.Text = "Welcome";
            this.Welcome_tab.UseVisualStyleBackColor = true;
            // 
            // TheGame_tab
            // 
            this.TheGame_tab.Controls.Add(this.TheGame_rtb);
            this.TheGame_tab.Location = new System.Drawing.Point(4, 25);
            this.TheGame_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheGame_tab.Name = "TheGame_tab";
            this.TheGame_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheGame_tab.Size = new System.Drawing.Size(1051, 643);
            this.TheGame_tab.TabIndex = 1;
            this.TheGame_tab.Text = "The game";
            this.TheGame_tab.UseVisualStyleBackColor = true;
            // 
            // TheGame_rtb
            // 
            this.TheGame_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TheGame_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheGame_rtb.Location = new System.Drawing.Point(5, 6);
            this.TheGame_rtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheGame_rtb.Name = "TheGame_rtb";
            this.TheGame_rtb.ReadOnly = true;
            this.TheGame_rtb.Size = new System.Drawing.Size(1039, 628);
            this.TheGame_rtb.TabIndex = 2;
            this.TheGame_rtb.Text = resources.GetString("TheGame_rtb.Text");
            // 
            // TheGameImgInt_tab
            // 
            this.TheGameImgInt_tab.Controls.Add(this.TheGameImgs_rtb);
            this.TheGameImgInt_tab.Location = new System.Drawing.Point(4, 25);
            this.TheGameImgInt_tab.Margin = new System.Windows.Forms.Padding(4);
            this.TheGameImgInt_tab.Name = "TheGameImgInt_tab";
            this.TheGameImgInt_tab.Padding = new System.Windows.Forms.Padding(4);
            this.TheGameImgInt_tab.Size = new System.Drawing.Size(1051, 643);
            this.TheGameImgInt_tab.TabIndex = 2;
            this.TheGameImgInt_tab.Text = "The game (With images) (Integrated)";
            this.TheGameImgInt_tab.UseVisualStyleBackColor = true;
            this.TheGameImgInt_tab.Enter += new System.EventHandler(this.TheGameImgInt_tab_Enter);
            // 
            // TheGameImgs_rtb
            // 
            this.TheGameImgs_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TheGameImgs_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheGameImgs_rtb.Location = new System.Drawing.Point(4, 6);
            this.TheGameImgs_rtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheGameImgs_rtb.Name = "TheGameImgs_rtb";
            this.TheGameImgs_rtb.ReadOnly = true;
            this.TheGameImgs_rtb.Size = new System.Drawing.Size(1039, 628);
            this.TheGameImgs_rtb.TabIndex = 3;
            this.TheGameImgs_rtb.Text = "";
            // 
            // TheGameImgFile_tab
            // 
            this.TheGameImgFile_tab.Controls.Add(this.TheGameImgsFile_rtb);
            this.TheGameImgFile_tab.Location = new System.Drawing.Point(4, 25);
            this.TheGameImgFile_tab.Margin = new System.Windows.Forms.Padding(4);
            this.TheGameImgFile_tab.Name = "TheGameImgFile_tab";
            this.TheGameImgFile_tab.Padding = new System.Windows.Forms.Padding(4);
            this.TheGameImgFile_tab.Size = new System.Drawing.Size(1051, 643);
            this.TheGameImgFile_tab.TabIndex = 3;
            this.TheGameImgFile_tab.Text = "The game (With images) (from file)";
            this.TheGameImgFile_tab.UseVisualStyleBackColor = true;
            this.TheGameImgFile_tab.Enter += new System.EventHandler(this.TheGameImgFile_tab_Enter);
            // 
            // TheGameImgsFile_rtb
            // 
            this.TheGameImgsFile_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TheGameImgsFile_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheGameImgsFile_rtb.Location = new System.Drawing.Point(4, 6);
            this.TheGameImgsFile_rtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheGameImgsFile_rtb.Name = "TheGameImgsFile_rtb";
            this.TheGameImgsFile_rtb.ReadOnly = true;
            this.TheGameImgsFile_rtb.Size = new System.Drawing.Size(1039, 628);
            this.TheGameImgsFile_rtb.TabIndex = 4;
            this.TheGameImgsFile_rtb.Text = "";
            // 
            // Video_tab
            // 
            this.Video_tab.Controls.Add(this.VideoExample_wmp);
            this.Video_tab.Location = new System.Drawing.Point(4, 25);
            this.Video_tab.Name = "Video_tab";
            this.Video_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Video_tab.Size = new System.Drawing.Size(1051, 643);
            this.Video_tab.TabIndex = 4;
            this.Video_tab.Text = "Gameplay example video";
            this.Video_tab.UseVisualStyleBackColor = true;
            this.Video_tab.Enter += new System.EventHandler(this.Video_tab_Enter);
            // 
            // VideoExample_wmp
            // 
            this.VideoExample_wmp.Enabled = true;
            this.VideoExample_wmp.Location = new System.Drawing.Point(6, 6);
            this.VideoExample_wmp.Name = "VideoExample_wmp";
            this.VideoExample_wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoExample_wmp.OcxState")));
            this.VideoExample_wmp.Size = new System.Drawing.Size(1039, 631);
            this.VideoExample_wmp.TabIndex = 0;
            // 
            // Help_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1083, 753);
            this.Controls.Add(this.helpScreen_Tabcontrol);
            this.Controls.Add(this.Close_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Help_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help_screen";
            this.Load += new System.EventHandler(this.Help_screen_Load);
            this.helpScreen_Tabcontrol.ResumeLayout(false);
            this.Welcome_tab.ResumeLayout(false);
            this.TheGame_tab.ResumeLayout(false);
            this.TheGameImgInt_tab.ResumeLayout(false);
            this.TheGameImgFile_tab.ResumeLayout(false);
            this.Video_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoExample_wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.RichTextBox Welcome_rtb;
        private System.Windows.Forms.TabControl helpScreen_Tabcontrol;
        private System.Windows.Forms.TabPage Welcome_tab;
        private System.Windows.Forms.TabPage TheGame_tab;
        private System.Windows.Forms.RichTextBox TheGame_rtb;
        private System.Windows.Forms.TabPage TheGameImgInt_tab;
        private System.Windows.Forms.RichTextBox TheGameImgs_rtb;
        private System.Windows.Forms.TabPage TheGameImgFile_tab;
        private System.Windows.Forms.RichTextBox TheGameImgsFile_rtb;
        private System.Windows.Forms.TabPage Video_tab;
        private AxWMPLib.AxWindowsMediaPlayer VideoExample_wmp;
    }
}
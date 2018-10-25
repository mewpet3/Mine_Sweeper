namespace Mine_Sweeper
{
    partial class Splash_screen
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
            this.Prompt_text = new System.Windows.Forms.Label();
            this.Flash_timer = new System.Windows.Forms.Timer(this.components);
            this.MusicToggle_button = new System.Windows.Forms.Button();
            this.SoundEffectToggle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prompt_text
            // 
            this.Prompt_text.AutoSize = true;
            this.Prompt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt_text.Location = new System.Drawing.Point(641, 430);
            this.Prompt_text.Name = "Prompt_text";
            this.Prompt_text.Size = new System.Drawing.Size(284, 29);
            this.Prompt_text.TabIndex = 0;
            this.Prompt_text.Text = "Press any key to continue";
            // 
            // Flash_timer
            // 
            this.Flash_timer.Enabled = true;
            this.Flash_timer.Interval = 1000;
            this.Flash_timer.Tick += new System.EventHandler(this.Flash_timer_Tick);
            // 
            // MusicToggle_button
            // 
            this.MusicToggle_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MusicToggle_button.BackgroundImage = global::Mine_Sweeper.Properties.Resources.MusicEnabled_image;
            this.MusicToggle_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MusicToggle_button.Location = new System.Drawing.Point(157, 715);
            this.MusicToggle_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MusicToggle_button.Name = "MusicToggle_button";
            this.MusicToggle_button.Size = new System.Drawing.Size(125, 125);
            this.MusicToggle_button.TabIndex = 2;
            this.MusicToggle_button.TabStop = false;
            this.MusicToggle_button.UseVisualStyleBackColor = true;
            this.MusicToggle_button.Click += new System.EventHandler(this.MusicToggle_button_Click);
            this.MusicToggle_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusicToggle_button_KeyDown);
            // 
            // SoundEffectToggle_button
            // 
            this.SoundEffectToggle_button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SoundEffectToggle_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SoundEffectToggle_button.BackgroundImage = global::Mine_Sweeper.Properties.Resources.SoundEnabled_image;
            this.SoundEffectToggle_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SoundEffectToggle_button.Location = new System.Drawing.Point(16, 715);
            this.SoundEffectToggle_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SoundEffectToggle_button.Name = "SoundEffectToggle_button";
            this.SoundEffectToggle_button.Size = new System.Drawing.Size(125, 125);
            this.SoundEffectToggle_button.TabIndex = 1;
            this.SoundEffectToggle_button.TabStop = false;
            this.SoundEffectToggle_button.UseVisualStyleBackColor = true;
            this.SoundEffectToggle_button.Click += new System.EventHandler(this.SoundEffectToggle_button_Click);
            this.SoundEffectToggle_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoundEffectToggle_button_KeyDown);
            // 
            // Splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1581, 853);
            this.Controls.Add(this.MusicToggle_button);
            this.Controls.Add(this.SoundEffectToggle_button);
            this.Controls.Add(this.Prompt_text);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mine Sweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Splash_screen_FormClosing);
            this.Load += new System.EventHandler(this.Splash_screen_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Splash_screen_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prompt_text;
        private System.Windows.Forms.Timer Flash_timer;
        private System.Windows.Forms.Button SoundEffectToggle_button;
        private System.Windows.Forms.Button MusicToggle_button;
    }
}


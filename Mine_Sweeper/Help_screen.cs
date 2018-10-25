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

///This form provides the player with helpful advice and teaches them how to play the game, as well as providing some helpful images to go along with the explanation.

namespace Mine_Sweeper
{
    public partial class Help_screen : Form
    {
        public Help_screen()
        {
            InitializeComponent();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_screen_Load(object sender, EventArgs e)
        {
            
        }

        //Does not load with form as it significantly impacts loading time to load images.
        private void TheGameImgInt_tab_Enter(object sender, EventArgs e)
        {
            try
            {
                //Reads in data contained within the rtf Help document integrated within the program so as an external file is not required.
                string rtf = Properties.Resources.Help;
                TheGameImgs_rtb.Rtf = rtf;
            }
            catch
            {
                TheGameImgs_rtb.Text = "Sorry, for some reason it would seem that the integrated RTF file is not working correctly, please resort to viewing either the game info from the file or the game info without images.";
            }
        }

        //Does not load with form as it significantly impacts loading time to load images.
        private void TheGameImgFile_tab_Enter(object sender, EventArgs e)
        {
            try
            {
                //Reads an external rtf file from where the exe is located so as to convey images as well as text.
                TheGameImgsFile_rtb.LoadFile("Help.rtf");
            }
            catch
            {
                TheGameImgsFile_rtb.Text = "Sorry, the file could not be found, please resort to using the integrated RTF game information instead.";
            }
        }

        private void Video_tab_Enter(object sender, EventArgs e)
        {
            try
            {
                VideoExample_wmp.URL = "Example of winning MineSweeper.avi";
                VideoExample_wmp.Width = Video_tab.Width;
                VideoExample_wmp.Height = Video_tab.Height;
            }
            catch
            {
                MessageBox.Show("The video file could not be found.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

///This class is the class which holds all of the values for each player, it is also used for saving this class to a bin file.

namespace Mine_Sweeper
{
    [Serializable]

    public class Profile
    {
        //Creating a name for the profile.
        private string name;
        //Creating an image location.
        private short image;
        //Creating an integer for the player number.
        private int profileNumber;
        //Creating a profilename.
        private string profileName;
        //Creating a password
        private string password;
        //creating an age
        private string age;
        //creating an int for the prefered bomb count for this player.
        private int bombno = 40;
        //Creating an int for the prefered xsize for this player.
        private int xsize = 16;
        //Creating an int for the prefered ysize for this player.
        private int ysize = 16;
        //Creating an int for the prefered difficulty (0 - custom, 1 - Easy, 2 - Medium (default), 3 - Hard).
        private int difficulty = 2;
        //Creating an array of highest scores that can be saved and replaced and recorded under a specified profile (for easy difficulty). It also sets all of the default values to 1000 so as to make it easier to test for scores to be less than the current scores.
        private int[] highestScoresEasy = { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };
        //Creating an array of highest scores that can be saved and replaced and recorded under a specified profile (for normal difficulty). It also sets all of the default values to 1000 so as to make it easier to test for scores to be less than the current scores.
        private int[] highestScoresMedium = { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };
        //Creating an array of highest scores that can be saved and replaced and recorded under a specified profile (for hard difficulty). It also sets all of the default values to 1000 so as to make it easier to test for scores to be less than the current scores.
        private int[] highestScoresHard = { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };

        public Profile()
        {

        }

        public Profile(string ProfileName, int ProfileNumber, string Name, string Age, string Password, short Image)
        {
            //Sets up each of the values within the class to be equal to its input upon the creation of the class.
            name = Name;
            profileName = ProfileName;
            image = Image;
            age = Age;
            profileNumber = ProfileNumber;
            profileName = ProfileName;
            password = Password;
        }

        //Allows other areas within the program to recieve data from this array but not change it as scores can only be added using the method contained within this class.
        public int[] HighestScoresEasy
        {
            get
            {
                return highestScoresEasy;
            }
        }

        //Allows other areas within the program to recieve data from this array but not change it as scores can only be added using the method contained within this class.
        public int[] HighestScoresMedium
        {
            get
            {
                return highestScoresMedium;
            }
        }

        //Allows other areas within the program to recieve data from this array but not change it as scores can only be added using the method contained within this class.
        public int[] HighestScoresHard
        {
            get
            {
                return highestScoresHard;
            }
        }

        //Allows other areas within the program to access and change the name of this profile.
        public string Name
        {
            set 
            { 
                name = value;
            }
            get 
            { 
                return name;
            }
        }

        //Allows other areas within the program to edit and view the value for image which is relevant to the imagelists found within the program.
        public short Image
        {
            set
            {
                image = value;
            }
            get
            {
                return image;
            }
        }

        //Allows other locations within the program to view and edit the profile number of this profile.
        public int Profilenumber
        {
            set
            {
                profileNumber = value;
            }
            get
            {
                return profileNumber;
            }
        }

        //Allows other areas within the program to view and edit the age of this profile.
        public string Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }

        //Allows other areas within the program to view and edit the difficulty of the program.
        public int Difficulty
        {
            set
            {
                difficulty = value;
            }
            get
            {
                return difficulty;
            }
        }

        //Allows the Xsize variable to be edited and used in other areas of the program.
        public int Xsize
        {
            set
            {
                xsize = value;
            }
            get
            {
                return xsize;
            }
        }

        //Allows the Ysize varaible to be edited and used in other areas of the program.
        public int Ysize
        {
            set
            {
                ysize = value;
            }
            get
            {
                return ysize;
            }
        }

        //Allows the BombNo variable to be edited and used in other areas of the program.
        public int BombNo
        {
            set
            {
                bombno = value;
            }
            get
            {
                return bombno;
            }
        }

        //Allows the ProfileName variable to be edited and used in other areas of the program.
        public string ProfileName
        {
            set
            {
                profileName = value;
            }
            get
            {
                return profileName;
            }
        }

        //Allows the password variable to be edited and used in other areas of the program.
        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }

        //Is used to write the entire set of profile details out to a string for bug testing purposes, is not used in the actual program.
        public string ToString()
        {
            return string.Format(" Current Details " + " : " + profileName + " : " + image + " " + profileNumber + " " + age + " " + name + " " + password + " " + age + " " + bombno + " " + xsize + " " + ysize + " " + difficulty);
        }

        //Recieves a handed in variable of the class profile so as it can replace a previous version of itself that existed inside the bin file previously.
        public void UpdateProfileDetails(Profile ProfileName)
        {
            //Creates a temporary location for read profiles.
            Profile ReadProfile;
            //Creates an instance of a filestream.
            Stream SR;
            try
            {
                //Gets the filestream to open the bin file with read write access.
                SR = File.Open("profiles.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //Creates a binary formatter so as to reformat the profile class into a bin format and back again.
                BinaryFormatter BF = new BinaryFormatter();
                bool found = false;
                //Variable created to track the position of the filestream.
                long pos = 0;
                try
                {
                    //Loops through all of the saved profiles.
                    while (SR.Position < SR.Length && found == false)
                    {
                        //Increases the pos variable to be equal to the current filestream position.
                        pos = SR.Position;
                        //Formates the read profile from a binary format to one that can be compared to the one the program is using.
                        ReadProfile = (Profile)BF.Deserialize(SR);
                        // Tests if the profile numbers are the same.
                        if (ReadProfile.profileNumber.CompareTo(ProfileName.profileNumber) == 0)
                        {
                            //Ends the loop early as it has found what it was looking for.
                            found = true;
                            //Moves the filestream back to where it found the profile.
                            SR.Seek(pos, SeekOrigin.Begin);
                            //Overwrittes the old profile with the new one.
                            BF.Serialize(SR, ProfileName);
                        }
                    }
                    //Closes the filestream.
                    SR.Close();
                }
                catch (SerializationException e)
                {
                    //Outputs error to console.
                    Console.WriteLine(e.Message);
                }
            }
            catch (IOException I)
            {
                //Outputs error to console.
                Console.WriteLine(I);
            }
        }

        public void CreateNewProfile(Profile ProfileName)
        {
            //Creates a new instance of a profile inside the bin file.
            Stream s;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                //Opens the bin file and starts reading from the end.
                s = File.Open("profiles.bin", FileMode.Append);
                //Formats the profile into binary and then writes it to the end of the file.
                bf.Serialize(s, ProfileName);
                //Closes the filestream
                s.Close();
            }
            catch (IOException e)
            {
                //Outputs error to console.
                Console.WriteLine(e.Message);
            }
        }

        public void ReturnScoreToHighScoreArray(int Score)
        {
            //Reads in a high score and places it within the array associated with the current difficulty then sorts it to ensure it is all in order.
            switch (difficulty)
            {
                case 1:
                    {
                        //Notices the current difficulty is easy so adds the score to the easy array (Using the difficulty array score placer method).
                        highestScoresEasy = DifficultyArrayScorePlacer(highestScoresEasy, Score);
                        break;
                    }
                case 2:
                    {
                        //Notices the current difficulty is medium so adds the score to the medium array (Using the difficulty array score placer method).
                        highestScoresMedium = DifficultyArrayScorePlacer(highestScoresMedium, Score);
                        break;
                    }
                case 3:
                    {
                        //Notices the current difficulty is hard so adds the high score to the hard array (Using the difficulty array score placer method).
                        highestScoresHard = DifficultyArrayScorePlacer(highestScoresHard, Score);
                        break;
                    }
            }
        }

        internal int[] DifficultyArrayScorePlacer(int[] Difficulty, int Score)
        {
            //Recieves the current difficulty and score to update and adds it to the end of the difficulty array before sorting it from lowest to highest.
            if (Difficulty[9] > Score || Difficulty[9] == 1000)
            {
                //Adds the new score onto the end if the score is less than the final position (default values of locations are 1000 so if there is no score there then it will always be less than 1000).
                Difficulty[9] = Score;
                //Uses the array sort method to sort the array.
                Array.Sort(Difficulty);
            }
            //Returns the final array with the added score to replace the old version of the array.
            return Difficulty;
        }
    }
}
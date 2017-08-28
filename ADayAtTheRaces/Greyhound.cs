using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Greyhound
    {
        private int _startingPosition; //Left property of pucture box before racing
        public int StartingPosition
        {
            get { return _startingPosition; }
            set { _startingPosition = value; }
        }

        private int _racetrackLength;
        public int RacetrackLength
        {
            get { return _racetrackLength; }
            set { _racetrackLength = value; }
        }

        private PictureBox _picture; //The picture box form element for which visually represents dog.
        public PictureBox Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        private int _location = 0; //How far the dog has run
        public int Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private Random _randomizer;
        public Random Randomizer
        {
            get { return _randomizer; }
            set { _randomizer = value; }
        }

        public Greyhound(int startingPosition, int racetrackLength, PictureBox picture, Random randomizer)
        {
            _startingPosition = startingPosition;
            _racetrackLength = racetrackLength;
            _location = 0;
            _picture = picture;
            _randomizer = randomizer;
        }

        //Determine a random number in a small range and then move the dog that distance
        //Returns true if dog has crossed finish line, else false
        public bool Run()
        {
            _location += (_randomizer.Next(10) + 1); //Move dog for random distance
            _picture.Left = _startingPosition + _location; //Update pictures' position

            if (_location >= _racetrackLength) //Check if dog has crossed finish line
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Reset dogs to start
        public void TakeStartingPosition()
        {
            _picture.Left = _startingPosition;
            _location = 0;
        }
    }
}

using System;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        private const int NUM_DOGS = 4; //Number of dogs running
        private const int NUM_GUYS = 3; //Number of guys betting
        private const int RACETRACK_LENGTH = 540 - 16; //Length of racetrack (position of finish line - starting position of dogs (left edge of image))

        private Greyhound[] _dogs; //List of running dogs
        private PictureBox[] _dogPictures; //List of dogs' pictures
        private Guy[] _guys; //List of betting guys

        private Random _randomizer; //Randomizer (shared with other classes)

        public Form1()
        {
            InitializeComponent(); //Build form
            InitializeVariables(); //Set dogs, guys and bets
        }

        private void InitializeVariables()
        {
            _randomizer = new Random();

            _dogPictures = new PictureBox[]
            {
                _pictureBoxDog1,
                _pictureBoxDog2,
                _pictureBoxDog3,
                _pictureBoxDog4
            };

            _dogs = new Greyhound[NUM_DOGS];
            for (int i = 0; i < NUM_DOGS; i++)
            {
                _dogs[i] = new Greyhound(_dogPictures[i].Left, RACETRACK_LENGTH, _dogPictures[i], _randomizer);
            }

            _guys = new Guy[NUM_GUYS];
            _guys[0] = new Guy("Joe", 50, _radioButtonJoe, _labelBetJoe);
            _guys[1] = new Guy("Bob", 75, _radioButtonBob, _labelBetBob);
            _guys[2] = new Guy("Al", 45, _radioButtonAl, _labelBetAl);

            foreach (Guy guy in _guys)
            {
                guy.ClearBet(); //Create empty Bet objects to prevent nullPointerExceptions
            }
        }

        //Button to set bet of a guy
        private void OnButtonBetClick(object sender, EventArgs e)
        {
            //Guy who bets is owner of currently selected radiobox and text of textbox left of button.
            if (!GetGuyByName(_labelBettorName.Text, out Guy bettor)) //Try to find guy from text of Button label.
            {
                MessageBox.Show($"Guy called \"{_labelBettorName.Text}\" not found.");
                return;
            }

            //Place bet, amount and dog from numeric Up Down's
            bettor.PlaceBet((int)_numericUpDownAmount.Value, (int)_numericUpDownDog.Value);
            _numericUpDownAmount.Value = Bet.MIN_AMOUNT; //Reset value of amount input field
            _numericUpDownDog.Value = 1; //Reset value of dogs input field
        }

        //Find guy object from given name. Returns true if guy was found, else false.
        private bool GetGuyByName(string name, out Guy bettor)
        {
            foreach (Guy guy in _guys)
            {
                if (guy.Name == name)
                {
                    bettor = guy;
                    return true;
                }
            }
            bettor = null;
            return false;
        }

        //If any of the three radioboxes changes, update text of Bet button label
        private void OnRadioButtonJoeCheckedChanged(object sender, EventArgs e)
        {
            _labelBettorName.Text = "Joe";
        }
        private void OnRadioButtonBobCheckedChanged(object sender, EventArgs e)
        {
            _labelBettorName.Text = "Bob";
        }
        private void OnRadioButtonAlCheckedChanged(object sender, EventArgs e)
        {
            _labelBettorName.Text = "Al";
        }

        //If game runs, move dogs at random speeds, and after each move check whether any dog has won.
        //After a dog has won, re-enable buttons, pay out guys and stop timer.
        private void OnTimerTick(object sender, EventArgs e)
        {
            foreach (Greyhound dog in _dogs)
            {
                bool hasWon = dog.Run(); //Move dogs, if return value is true, that dog has won.
                if (hasWon)
                {
                    _timer.Stop();
                    int dogNum = Array.IndexOf(_dogs, dog) + 1; //dogNum is for display, 1-indicated
                    MessageBox.Show($"Dog #{dogNum} has won the race!");
                    foreach (Guy guy in _guys) //Pay out guys
                    {
                        guy.Collect(dogNum); //Dogs 1-indicated
                    }
                    //Re-enable buttons
                    _buttonBet.Enabled = true;
                    _buttonRace.Enabled = true;
                    break;
                }
            }
        }

        //"Race!" button: reset dogs to starting position, start timer and disable Bet and Race buttons.
        private void OnButtonRaceClick(object sender, EventArgs e)
        {
            foreach (Greyhound dog in _dogs)
            {
                dog.TakeStartingPosition();
            }
            _buttonBet.Enabled = false;
            _buttonRace.Enabled = false;
            _timer.Start(); //Start the timer = start the race
        }
    }
}

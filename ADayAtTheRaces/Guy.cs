using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Guy
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Bet _myBet;
        public Bet MyBet
        {
            get { return _myBet; }
            set { _myBet = value; }
        }

        private int _cash;
        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        private RadioButton _myRadioButton;
        public RadioButton MyRadioButton
        {
            get { return _myRadioButton; }
            set { _myRadioButton = value; }
        }

        private Label _myLabel;
        public Label MyLabel
        {
            get { return _myLabel; }
            set { _myLabel = value; }
        }

        public Guy(string name, int cash, RadioButton radioButton, Label label)
        {
            _name = name;
            _cash = cash;
            _myRadioButton = radioButton;
            _myLabel = label;
            ClearBet();
        }

        public void UpdateLabels()
        {
            _myLabel.Text = _myBet.GetDescription();
            _myRadioButton.Text = $"{_name} has {_cash} bucks.";
        }

        public void ClearBet()
        {
            _myBet = new Bet(0, 0, this);
        }

        //Creates new bet if guy has enough cash
        //Returns true if bet could be placed, else false.
        public bool PlaceBet(int amount, int dog)
        {
            //Check whether the guy has enough cash and the bet amount is above or equal to the minimum bet and below or equal to maximum bet.
            if (amount <= _cash && amount >= Bet.MIN_AMOUNT && amount <= Bet.MAX_AMOUNT)
            {
                _myBet = new Bet(amount, dog, this);

                UpdateLabels();
                return true;
            }
            //If bet amount was too low return false and matching error message
            else if (amount < Bet.MIN_AMOUNT)
            {
                MessageBox.Show($"Minimum bet is ${Bet.MIN_AMOUNT}!");
                return false;
            }
            //If bet amount was higher than maximum bet amount return false and matching error message
            else if (amount > Bet.MAX_AMOUNT)
            {
                MessageBox.Show($"Maximum bet is ${Bet.MAX_AMOUNT}!");
                return false;
            }
            //Remaining case is that guy had not enough cash.
            else
            {
                MessageBox.Show($"{_name} does not have enough cash to bet ${amount}!");
                return false;
            }
        }

        //Give or take money from guy, reset bet and label texts
        public void Collect(int Winner)
        {
            _cash += _myBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRaces
{
    public class Bet
    {
        public const int MIN_AMOUNT = 5; //Minimum bet amount
        public const int MAX_AMOUNT = 15;//Maximum bet amount

        private int _amount; //Amout of the bet
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private int _dog; //Dog betted on
        public int Dog
        {
            get { return _dog; }
            set { _dog = value; }
        }

        private Guy _bettor; //Betting guy
        public Guy Bettor
        {
            get { return _bettor; }
            set { _bettor = value; }
        }

        public Bet(int amount, int dog, Guy bettor)
        {
            _amount = amount;
            _dog = dog;
            _bettor = bettor;
        }

        //Get string that describes bet, or if default bet (0$) is set return "Guy hasn't placed a bet".
        public string GetDescription()
        {
            if (_amount > 0)
            {
                return $"{_bettor.Name} bets {_amount}$ on dog #{_dog}.";
            }
            else
            {
                return $"{_bettor.Name} hasn't placed a bet.";
            }
        }

        //Check if guy has set on the winning dog, if yes return bet amount, else return negative bet amount.
        public int PayOut(int winner)
        {
            if (_dog == winner)
            {
                return _amount;
            }
            else
            {
                return -_amount;
            }
        }
    }
}

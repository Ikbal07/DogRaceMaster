using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogRace
{
    public class Bet {
        public int Amount;
        public int dogNum;
        public DogRacer Bettor;

        public Bet(int Amount, int dogNum, DogRacer Bettor) {
            this.Amount = Amount;
            this.dogNum = dogNum;
            this.Bettor = Bettor;
        }

        public string GetDescription() {
            string description = "";

            if(Amount > 0) {
                description = String.Format("{0} bets {1} on Dog #{2}",
                    Bettor.Name, Amount, dogNum);
            } else {
                description = String.Format("{0} hasn't placed any bets", 
                    Bettor.Name);
            }
            return description;
        }

        public int Pay(int Winner) {
            if (dogNum == Winner) {
                return Amount;
            }
            return -Amount;
        }
    }
}

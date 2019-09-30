using System.Windows.Forms;


namespace DogRace
{
    using System;

    public class Marry : DogRacer
    {
        public Marry(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setDogRacerName()
        {
            Name = "Marry";
        }
    }
}
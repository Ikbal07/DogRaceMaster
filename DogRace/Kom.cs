using System.Windows.Forms;

namespace DogRace
{
    using System;

    public class Kom : DogRacer
    {
        public Kom(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setDogRacerName()
        {
            Name = "Kom";
        }
    }
}
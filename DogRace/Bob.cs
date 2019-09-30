using System.Windows.Forms;

namespace DogRace
{
    public class Bob : DogRacer
    {
        public Bob(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setDogRacerName()
        {
            Name = "Bob";
        }
    }
}
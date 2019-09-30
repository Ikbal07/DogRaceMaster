using System;
using System.Windows.Forms;

namespace DogRace
{
    public class DogRacerFactory
    {
        public DogRacer getDogRacer(String Name,Label MaximumBet, Label bet)
        {
            DogRacer p;
            switch (Name.ToLower())
            {
                case "kom":
                     p = new Kom(null, MaximumBet, 50, bet);
                    break;
                   
                case "marry":
                    p =  new Marry(null, MaximumBet, 50, bet);
                    break;
                    
                case "bob":
                    p = new Bob(null, MaximumBet, 50, bet);
                    break;
                   
                default:
                    p =  null ;
                    break;
            }
            p.setDogRacerName();
            return p;
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogRace;
namespace DogRaceUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        DogRacerFactory pFactory = new DogRacerFactory();
        DogRacer Bob;
        Dogs[] Dogss = new Dogs[2];
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestWinnerOutcome()
        {
            Dogs.StartingPosition1 = 0;
            Dogs.dogracetrackLength1 = 50;
            int dogRacerAmount = 45;
            int DogsNumber = 2;
            int expectedWin = 90;
            int expectedLose = 0;
            Dogss[0] = new Dogs() { DogsPictureBox = null };
            Dogss[1] = new Dogs() { DogsPictureBox = null };
            Bob = pFactory.getDogRacer("Bob", null, null);
            Bob.Cash = dogRacerAmount;
            Bob.PlaceBet((int)dogRacerAmount, DogsNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Dogss.Length; i++)
                {
                    if (Dogs.Run(Dogss[i]))
                    {
                        win = i + 1;
                        Bob.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Bob.bet.dogNum == win)
            {
                Assert.AreEqual(expectedWin, Bob.Cash, "Account doesn't credited ");
            }
            if (Bob.bet.dogNum != win)
            {
                Assert.AreEqual(expectedLose, Bob.Cash, "Account doesn't debited ");

            }
        }
    }

}

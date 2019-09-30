using System;
using System.Windows.Forms;
using System.Drawing;

namespace DogRace
{
    public class Dogs {
        private static int StartingPosition;
        private static int dogracetrackLength;
        public PictureBox DogsPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int dogracetrackLength1 { get => dogracetrackLength; set => dogracetrackLength = value; }

        // generation across all Dogs objects

        public static bool Run(Dogs obj) {
            int distance = MyRandom.Next(2, 6);
            if (obj.DogsPictureBox != null)
            obj.MoveDogsPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (dogracetrackLength1 - StartingPosition1)) {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition() {
            MoveDogsPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveDogsPictureBox(int distance) {
            Point p = DogsPictureBox.Location;
            p.X += distance;
            DogsPictureBox.Location = p; //move Dogs in x-axis
        }
    }
}

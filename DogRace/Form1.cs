using System;
using System.Windows.Forms;

namespace DogRace {
    public partial class Form1 : Form {
        Dogs[] Dogss = new Dogs[4];

        DogRacerFactory pFactory = new DogRacerFactory();
        DogRacer[] DogRacers = new DogRacer[3];

        public Form1() {
            InitializeComponent();
            SetupdograceTrack();
        }

        private void SetupdograceTrack() {
            
            Dogs.StartingPosition1 = Dog1.Right - dogracetrack.Left; 
            Dogs.dogracetrackLength1 = dogracetrack.Size.Width - 70 ; //fixing length of dograce - till finish line
                
            Dogss[0] = new Dogs() { DogsPictureBox = Dog1};
            Dogss[1] = new Dogs() { DogsPictureBox = Dog2};
            Dogss[2] = new Dogs() { DogsPictureBox = Dog3};
            Dogss[3] = new Dogs() { DogsPictureBox = Dog4};

            DogRacers[0] = pFactory.getDogRacer("Kom",MaximumBet,KomBet); //getting Kom object from factory class
            DogRacers[1] = pFactory.getDogRacer("Marry", MaximumBet, MarryBet); //getting Marry object from factory class
            DogRacers[2] = pFactory.getDogRacer("Bob", MaximumBet, BobBet); //getting Bob object from factory class


            foreach (DogRacer DogRacer in DogRacers) {
                DogRacer.UpdateLabels();
            }
        }

        private void KomButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(DogRacers[0].Cash);
        }

        private void MarryButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(DogRacers[1].Cash);
        }

        private void BobButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(DogRacers[2].Cash);
        }

        private void setMaximumBetTextLabel(int Cash) {
            MaximumBet.Text= String.Format("Maximum Bet: ${0}", Cash);
        }

        // setting the bet for each DogRacer and updating labels respectively
        private void Bets_Click(object sender, EventArgs e) {
            int DogRacerNum = 0;

            if (KomButton.Checked) {
                DogRacerNum = 0;
            }
            if (MarryRButton.Checked) {
                DogRacerNum = 1;
            }
            if (BobRButton.Checked) {
                DogRacerNum = 2;
            }

            DogRacers[DogRacerNum].PlaceBet((int)dogRacerAmount.Value, (int)DogsNumber.Value);
            DogRacers[DogRacerNum].UpdateLabels();
        }

        private void dograce_Click(object sender, EventArgs e) {
            bool NoWinner = true;
            int winningDogs;
            dograce.Enabled = false; //disable start dograce button

            while (NoWinner) { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Dogss.Length; i++ ) {
                    if (Dogs.Run(Dogss[i])) { 
                        winningDogs = i + 1;
                        NoWinner = false;
                        MessageBox.Show("winner of the dograce is - Dogs #" + winningDogs);
                        foreach (DogRacer DogRacer in DogRacers) {
                            if (DogRacer.bet != null) {
                                DogRacer.Collect(winningDogs); //give double amount to all who've won or deduce betted amount
                                DogRacer.bet = null; 
                                DogRacer.UpdateLabels();
                            }
                        }
                        foreach (Dogs Dogs in Dogss) {
                            Dogs.TakeStartingPosition();
                        }
                        break;
                    }                    
                }                
            }
            if (DogRacers[0].busted && DogRacers[1].busted && DogRacers[2].busted){  //stop DogRacers from betting if they run out of cash
                String message = "Do you want to Play Again?";
                String title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes) {
                    SetupdograceTrack(); //restart game
                }
                else {
                    this.Close();  
                }

            }
            dograce.Enabled = true; //enable dograce button 
        }

        private void dogracetrack_Click(object sender, EventArgs e)
        {

        }

        private void dogRacerAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MaximumBet_Click(object sender, EventArgs e)
        {

        }

        private void DogsNumber_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

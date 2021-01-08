using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rockpaperscissor
{
    public partial class Form1 : Form
    {

        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;

        string[] compchoicelist = { "rock", "paper", "scissor", "scissor", "paper", "rock" };

        int randomnumber = 0;
        Random rnd = new Random();
        
        string compchoice;
        string playerchoice;
        int playerScore;
        int compScore;






        public Form1()
        {
            InitializeComponent();

            CountdownTimer.Enabled = true;

            playerchoice = "none";
            txtCountdown.Text = "5";

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Rock;
            playerchoice = "rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper1;
            playerchoice = "paper";
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissor1;
            playerchoice = "scissor";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
           
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timerPerRound -= 1;
            txtCountdown.Text = timerPerRound.ToString();

            txtRounds.Text = "Rounds :" + rounds;
            if (timerPerRound < 1)
            {

                CountdownTimer.Enabled = false;
                timerPerRound = 6;
                randomnumber = rnd.Next(0, compchoicelist.Length);

                compchoice = compchoicelist[randomnumber];


                switch(compchoice)
                {
                    case "rock":
                        picComp.Image = Properties.Resources.Rock;

                        break;

                    case "paper":
                        picComp.Image = Properties.Resources.paper1;

                        break;
                    case "scissor":
                        picComp.Image = Properties.Resources.scissor1;

                        break;
                }

                if (rounds > 0)
                {
                    checkgame();
                }
                else
                {
                    if(playerScore >compScore)
                    {
                        MessageBox.Show("Player won the game");

                    }
                    else
                    {
                        MessageBox.Show("Player won the game");

                    }
                    gameOver = true;
                }
            }
             
        }

        private void checkgame()
        {
            if( playerchoice=="rock" && compchoice=="paper")
            {

                compScore += 1;
                rounds -= 1;
                MessageBox.Show("Computer Win the Game " +
                    "Papper Covers Rock");
            }

            else if (playerchoice == "scissor" && compchoice == "rock")
            {

                compScore += 1;
                rounds -= 1;
                MessageBox.Show("Computer Win the Game" +
                    "Rock Breaks Scissor" );
            }
            else if (playerchoice == "paper" && compchoice == "scissor")
            {

                compScore += 1;
                rounds -= 1;
                MessageBox.Show("Computer Win the Game" +
                    "Scissor cuts Paper");
            }

            else if (playerchoice == "rock" && compchoice == "scissor")
            {

                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("Player Win the Game" +
                    " Rock breaks Scissor ");
            }
            else if (playerchoice == "paper" && compchoice == "rock")
            {

                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("Player Win the Game" +
                    "Paper covers Rock");

            }
            else if (playerchoice == "scissor" && compchoice == "paper")
            {

                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("Player Win the Game" +
                    "Scissor cuts Paper");
            }
            else if (playerchoice == "none")
            {

            
                MessageBox.Show("Make a choice");
            }
            else { MessageBox.Show("Draw!!"); }
            startNextRound();

        }

        private void startNextRound()
        {
            if (gameOver == true)
            {
                return;
            }

            txtScore.Text = "Player: " + playerScore + "    " + "Comp: " + compScore;
            playerchoice = "none";
            CountdownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.download;
            picComp.Image = Properties.Resources.download;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

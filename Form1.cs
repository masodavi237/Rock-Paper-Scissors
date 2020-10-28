using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RockPaperScissors : Form
    {
        Random Generator = new Random();
        int playerScore;
        int computeScore;
        int tied;
        int playerMove;
        int computerMove;



        public RockPaperScissors()
        {
            InitializeComponent();
            playerScore = 0;
            computeScore = 0;
            tied = 0;
            playerMove = 1;
            computerMove = 1;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            

            computerMove = Generator.Next(1, 4);

            if (computerMove == 1)
            {
                lblCompMoveDisp.Text = "Rock";
                pbxComputer.Image = rockPaperScissors.Properties.Resources.Rock;
            }
            else if (computerMove == 2)
            {
                lblCompMoveDisp.Text = "Paper";
                pbxComputer.Image = rockPaperScissors.Properties.Resources.Paper;
            }
            else
            {
                lblCompMoveDisp.Text = "Scissors";
                pbxComputer.Image = rockPaperScissors.Properties.Resources.Scissors;
            }

            
            if (rdbPlayerRock.Checked)
            {
                playerMove = 1;
            }
            else if (rdbPlayerPaper.Checked) 
            {
                playerMove = 2;
            }
            else if (rdbPlayerScissors.Checked)
            {
                playerMove = 3;
            }

            
            if (playerMove == computerMove)
            {
                tied += 1;
            }
            
            if (playerMove == 1)
            {
                switch (computerMove)
                {
                    case 2:
                        computeScore += 1;
                        break;
                    case 3:
                        playerScore += 1;
                        break;
                }
            }
            else if (playerMove == 2)
            {
                switch (computerMove)
                {
                    case 1:
                        playerScore += 1;
                        break;

                    case 3:
                        computeScore += 1;
                        break;
                }
            }
            else
            {
                switch (computerMove)
                {
                    case 1:
                        computeScore += 1;
                        break;

                    case 2:
                        playerScore += 1;
                        break;
                }
            }

            lblPlayerScore.Text = playerScore + "";
            lblComputerScore.Text = computeScore + "";
            lblTiesDisplay.Text = tied + "";
        }

        private void rdbPlayerRock_Checked(object sender, EventArgs e)
        {
            pbxPlayer.Image = rockPaperScissors.Properties.Resources.Rock;
        }

        private void rdbPlayerPaper_CheckedChanged(object sender, EventArgs e)
        {
            pbxPlayer.Image = rockPaperScissors.Properties.Resources.Paper;
        }

        private void rdbPlayerScissors_CheckedChanged(object sender, EventArgs e)
        {
            pbxPlayer.Image = rockPaperScissors.Properties.Resources.Scissors;
        }

       
    }
}

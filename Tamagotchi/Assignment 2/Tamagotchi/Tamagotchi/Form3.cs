using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class Form3 : Form
    {
        Random pick = new Random();
        int userChoice = 0,cChoice, userScore, compScore;
        public static int alteration; //amount changed to user pet's stats
        
        public Form3()
        {
            InitializeComponent();
            
            
        }

        private void rock_Click(object sender, EventArgs e)
        {
            userChoice = 1; //rock selected
        }

        private void paper_Click(object sender, EventArgs e)
        {
            userChoice = 2; //paper selected
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            userChoice = 3; //scissors selected
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            if (userChoice == 0) // No selection made by user
            {
                MessageBox.Show("Press Rock, Paper or Scissors first then press draw.");
            }
            cChoice = pick.Next(1, 4); //Computer randomly pick 1/2/3 to determine what it draws.
            if (userChoice == cChoice)
            {
                MessageBox.Show("We drew the same, no-one scores");
                userChoice = 0;
            }
            else
            {
                if ((userChoice == 1) && (cChoice == 2)) 
                {   //user choose rock computer chooses paper.
                    MessageBox.Show("You chose rock I chose paper so I win that round");
                    compScore++;
                }
                if ((userChoice == 1) && (cChoice == 3))
                {   //user chooses rock computer chooses scissors.
                    MessageBox.Show("You chose rock I chose scissors so you win that round");
                    userScore++;
                }
                if ((userChoice == 2) && (cChoice == 3))
                {   //user chooses paper computer chooses scissors
                    MessageBox.Show("You chose paper I chose scissors so I win that round");
                    compScore++;
                }
                if ((userChoice == 2) && (cChoice == 1))
                {   //user chooses paper computer chooses rock.
                    MessageBox.Show("You chose paper I chose rock so you win that round");
                    userScore++;
                }
                if ((userChoice == 3) && (cChoice == 1))
                {   //user chooses scissors computer chooses rock.
                    MessageBox.Show("You chose scissors I chose rock so I win that round");
                    compScore++;
                }
                if ((userChoice == 3) && (cChoice == 2))
                {   //user chooses scissors computer chooses paper.
                    MessageBox.Show("You chose scissors I chose paper so you win that round");
                    userScore++;
                }
                userChoice = 0;
            }

            if (userScore == 3) //User wins 3 rounds so wins overall
            {
                MessageBox.Show("You win well done!");
                alteration = 20;
                this.Close();
            }
            else
            {
                if (compScore == 3) //Computer wins 3 rounds so wins overall
                {
                    MessageBox.Show("I win, bad luck");
                    alteration = -20;
                    this.Close();
                }
            }
            cscore.Text = Convert.ToString(compScore);
            uscore.Text = Convert.ToString(userScore);

            
        }

       
    }
}

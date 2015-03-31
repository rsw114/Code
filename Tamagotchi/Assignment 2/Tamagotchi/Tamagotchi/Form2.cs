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
    public partial class Form2 : Form
    {
            public static Random target = new Random();
            public static int BoreAlt;
            public int rep = 0;
            public int tries = 3;

            
                       
            public int cGues = target.Next(1, 11); //computer picks number from 1 to 10
            public int uGues = 0;

        
          
                     

        public Form2()
        {
            InitializeComponent();
            guessBox.Text = "0";
            tryLabel.Text = "3";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entry = guessBox.Text;
            NumCheck(ref entry);
            uGues = Convert.ToInt32(entry);
            if ((uGues < 1) || (uGues > 10)) //error trap
            {
                MessageBox.Show("Invalid input, select a number from 1 to 10");
                
            }
            else
            {
                if ((rep == 2) && (uGues != cGues)) //Wrong guess and out of tries
                {
                    BoreAlt = 0;
                    MessageBox.Show("Sorry you lose.");
                    this.Close();
                }
                else
                {
                    if (uGues == cGues)
                    {
                        MessageBox.Show("Correct");
                        switch (rep)
                        {
                            case 0: //Correct on first guess
                                {
                                    BoreAlt = 15;
                                    break;
                                }
                            case 1: //Correct on second guess
                                {
                                    BoreAlt = 10;
                                    break;
                                }
                            case 2: //Correct on third guess
                                {
                                    BoreAlt = 5;
                                    break;
                                }
                        }

                        this.Close();
                    }
                    else
                    {
                        if (uGues > cGues) //Guess was too high
                        {
                            MessageBox.Show("Too high try again");
                            rep++;
                        }
                        else //Guess was too low
                        {
                            MessageBox.Show("Too low try again");
                            rep++;
                        }
                        tries--;
                        tryLabel.Text = Convert.ToString(tries);

                    }
                }


            }

        }
        private static void NumCheck(ref string Pnumber) // check if a number was entered
        {
            long num;
            bool isnum;
            Pnumber = Pnumber.Replace(" ", string.Empty); // removes any spaces 1 2 3 becomes 123
            isnum = long.TryParse(Pnumber, out num); // Checks if entered string can be used as a long integer.
            if (isnum == false)
            {
                MessageBox.Show("Invalid entry, please enter a number."); // entry is not a number, asks for another.
                Pnumber = "0";
                isnum = false;
            }         
        }
    }
}

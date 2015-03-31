using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.IO;


    
namespace Tamagotchi
{
    
    public partial class Form1 : Form
    {  
       public class Vpet
        {
            int health = 100, boredom = 0, hunger = 0;

            public int hungry(int amount) // Changes hunger
            {
                if (hunger - amount < 0) //prevent hunger going below 0
                {
                    hunger = 0;
                }
                else
                {
                    hunger = hunger - amount;
                }
                return hunger;
            }

            public int yawning(int amount) //change boredom
            {
                if (boredom - amount < 0) //prevent boredom going below 0
                {
                    boredom = 0;
                }
                else
                {
                    boredom = boredom - amount;
                }
                return boredom;
            }

            public int lifey(int amount) //change health
            {
                if (health + amount >= 100) //prevent health going above 100
                {
                    health = 100;
                }
                else
                {
                    health = health + amount;
                }
             
                return health;

            }
        
            public int hungerstate
            {
                get
                {
                    return hunger;
                }

                set
                {
                    hunger = value;
                }
            }
            public int boredomstate
            {
                get
                {
                    return boredom;
                }

                set
                {
                    boredom = value;
                }
            }
            public int healthstate
            {
                get
                {
                    return health;
                }

                set
                {
                    health = value;
                }
            }       
     }


        Vpet pet1 = new Vpet(); //user interacting pet
        Vpet autopet = new Vpet(); //computer controlled pet
        
       
        public Form1()
        {
            
            InitializeComponent();
            pictureBox1.Load("NiceDog.jpg");
            fed.Text = Convert.ToString(pet1.hungerstate);
            healthy.Text = Convert.ToString(pet1.healthstate);
            bored.Text = Convert.ToString(pet1.boredomstate);
            timer1.Interval = 2000; //2 second interval on timer 1
            timer1.Start();
            
        }



        private void play_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //stop timer until done playing
            Form2 F2 = new Form2(); //Switch to form 2
            F2.ShowDialog();
            int changer = Form2.BoreAlt; //Get amount to change from form 2
            pet1.yawning(changer);
            bored.Text = Convert.ToString(pet1.boredomstate);
            timer1.Start();
        }

        private void heal_Click(object sender, EventArgs e)
        {
            pet1.healthstate = pet1.lifey(10);
            healthy.Text = Convert.ToString(pet1.healthstate);
            
        }

        private void feed_Click(object sender, EventArgs e)
        {
            pet1.hungry(10);
            fed.Text = Convert.ToString(pet1.hungerstate);
        }

        private void battle_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //stop timer until done with the battle
            if (autopet.boredomstate == 100)
            {
                MessageBox.Show("The computer's pet get bored and has wandered off so you can't play.");
            }
            else
            {
                Form3 F3 = new Form3(); //Switch to form 3
                F3.ShowDialog();
                int changer = Form3.alteration; //Get amount to change stats by from form 3
                pet1.yawning(changer);
                pet1.lifey(changer);
                pet1.hungry(changer);
                autopet.yawning(20);
                fed.Text = Convert.ToString(pet1.hungerstate);
                healthy.Text = Convert.ToString(pet1.healthstate);
                bored.Text = Convert.ToString(pet1.boredomstate);
            }
            timer1.Start();
        }

        private void qsave_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            saveFileDialog1.ShowDialog();
            Application.Exit();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName; //set up save file name
            File.WriteAllText(name, "Hunger: " + fed.Text + "\r\n" + "Boredom: " + bored.Text
            + "\r\n" + "Health: " + healthy.Text); //saves states to file and location chosen by user

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if ((pet1.healthstate < 50) || (pet1.boredomstate > 50) || (pet1.hungerstate > 50)) 
            {
                pictureBox1.Load("AngryDog.jpg");
            }
            else
            {
                pictureBox1.Load("NiceDog.jpg");
            }
            pet1.hungerstate = pet1.hungerstate + 1;
            pet1.boredomstate = pet1.boredomstate + 1;
            pet1.healthstate = pet1.healthstate - 1;
            autopet.boredomstate = autopet.boredomstate + 2;
            fed.Text = Convert.ToString(pet1.hungerstate);
            healthy.Text = Convert.ToString(pet1.healthstate);
            bored.Text = Convert.ToString(pet1.boredomstate);
      
            if ((pet1.hungerstate >= 100) || (pet1.boredomstate >= 100) || (pet1.healthstate <=0))
            {

                timer1.Stop();
                MessageBox.Show("You have neglected your pet and it has been recovered by the animal shelter.");
                MessageBox.Show("Your pet was " +pet1.healthstate+" healthy, "+pet1.hungerstate+" hungry and "+pet1.boredomstate+" bored.");
                Application.Exit();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}

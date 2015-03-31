using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Player : Character // Child of Character
    {
        private int score, hunger;

        public Player()
        { }

        public Player(int score, int hunger)
        {
            this.score = score;
            this.hunger = hunger;
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }
    }
}

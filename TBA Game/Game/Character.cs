using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Character
    {
        private string name;
        private int health, wisdom, strength;

        public Character(string name, int health, int wisdom, int strength) // constructor class
        {
            this.name = name;
            this.health = health;
            this.wisdom = wisdom;
            this.strength = strength;
        }

        public Character()
        { }

        // getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Wisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

    }
}

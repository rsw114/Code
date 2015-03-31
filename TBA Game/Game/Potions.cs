using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Potions
    {
        private string pname;
        private int pamount;

        public Potions(string pname, int pamount)
        {
            this.pname = pname;
            this.pamount = pamount;
        }

        public Potions()
        { }
        public string PName
        {
            get { return pname; }
            set { pname = value; }
        }

        public int PAmount
        {
            get { return pamount; }
            set { pamount = value; }
        }


    }
}

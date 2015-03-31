using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Weapons
    {
        string w_name;
        bool got;

        public Weapons(string w_name, bool got)
        {
            this.w_name = w_name;
            this.got = got;
        }

        public Weapons()
        { }
        public string W_Name
        {
            get { return w_name; }
            set { w_name = value; }
        }

        public bool Got
        {
            get { return got; }
            set { got = value; }
        }
    }

}

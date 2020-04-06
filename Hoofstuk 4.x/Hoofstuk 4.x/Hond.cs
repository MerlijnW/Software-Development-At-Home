using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_4.x
{
    public class Hond : Huisdier , Graver
    {
        public Hond(String naam) : base(naam)
        {

        }
        public void kwispel()
        {
            Console.WriteLine("Kwispel");
        }

        override
        public void maakGeluid()
        {
            Console.WriteLine("Woef");
        }

        public void graaf()
        {
            Console.WriteLine("Diggy dig");
        }
    }
}

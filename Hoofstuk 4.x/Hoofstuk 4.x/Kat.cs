using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_4.x
{
    public class Kat : Huisdier
    {
        public Kat(String naam) : base(naam)
        {

        }
        public void spin()
        {
            Console.WriteLine("Purr");
        }

        override
        public void maakGeluid()
        {
            Console.WriteLine("Meow");
        }
    }
}

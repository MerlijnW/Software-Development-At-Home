using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_4.x
{
    public class Hamster : Huisdier , Graver , Klimmer
    {
        public Hamster(String naam) : base(naam)
        {

        }

        override
        public void maakGeluid()
        {
            Console.WriteLine("Squeek");
        }
        public void graaf()
        {
            Console.WriteLine("Diggy dig");
        }
        public void klim()
        {
            Console.WriteLine("klim klim");
        }
    }
}

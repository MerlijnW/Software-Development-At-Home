using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_4.x
{
    class Program
    {
        static void Main(string[] args)
        {
            Kat kat = new Kat("Kat1");
            kat.maakGeluid();
            kat.spin();

            Hond hond = new Hond("hond1");
            hond.maakGeluid();
            hond.kwispel();

            Hamster hamster = new Hamster("hamster1");
            hamster.maakGeluid();

            Dierenwinkel winkel = new Dierenwinkel();

            winkel.voegToe(kat);
            winkel.voegToe(hond);
            winkel.voegToe(hamster);
            winkel.printOverzicht();
            Console.ReadKey();
        }
    }
}

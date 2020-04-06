using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_4.x
{
    class Dierenwinkel
    {
        private ArrayList lijst;
        public Dierenwinkel()
        {
            lijst = new ArrayList();
        }
        public void voegToe(Huisdier dier)
        {
            lijst.Add(dier);
        }
        public void printOverzicht()
        {
            foreach (Huisdier dier in lijst)
            {
                if (dier is Kat)
                {
                    ((Kat)dier).maakGeluid();
                    ((Kat)dier).klim();
                }
                if (dier is Hond)
                {
                    ((Hond)dier).maakGeluid();
                    ((Hond)dier).graaf();
                }
                if (dier is Hamster)
                {
                    ((Hamster)dier).maakGeluid();
                    ((Hamster)dier).graaf();
                    ((Hamster)dier).klim();
                }
                Console.WriteLine(" zegt " + dier.getNaam());

            }
        }
    }
}

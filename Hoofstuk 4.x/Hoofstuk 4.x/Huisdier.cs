using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_4.x
{
    public abstract class Huisdier
    {
        private string naam;

        public Huisdier(string naam)
        {
            this.naam = naam;
        }
        public string getNaam()
        {
            return this.naam;
        }
        public abstract void maakGeluid();
    }
}

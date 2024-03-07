using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrawy.Klasy
{
    class Danie
    {
        private float waga;
        private bool dlaAlergikow;
        public Danie()
        {
            waga = 0;
            dlaAlergikow = false;
        }
        public Danie(float waga, bool dlaAlergikow)
        {
            this.waga = waga;
            this.dlaAlergikow = dlaAlergikow;

        }
        public string PokazInfo()
        {
            return "Jestem bliżej nieokreśloną potrawą i ważę " + waga + ".";
        }
    }
}

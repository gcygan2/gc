using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrawy.Klasy
{

    class Rosol : Danie
    {
        float masaMiesa;    
        public Rosol(float masaMiesa, float waga, bool dlaAlergikow) : base (waga, dlaAlergikow)
        {
            this.masaMiesa = masaMiesa;
        }

    }
}

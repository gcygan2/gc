using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa.Klasy
{
    class Uczen
    {
        private string imie;
        private char plec;
        public Uczen ()
        {
            imie = "Jaś";
            plec = 'M';
        }
        public void WprowadzDane (string imie, char plec)
        {
            this.imie = imie;
            this.plec = plec;
        }
        public bool CzyDziewczyna()
        {
            return (plec == 'K')? true : false;
        }
        public string PrzedstawSie()
        {
            return "Mam na imię " + imie + ". Jestem " + 
                ((plec == 'K')? "kobietą." : "mężczyzną.");
        }
    }
}

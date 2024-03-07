using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KLasy
{
    class Pojazd
    {
        private int liczbaSilnikow;
        private int liczbaKol;
        //konstruktor domyślny
        public Pojazd ()
        {
            liczbaKol = 4;
            liczbaSilnikow = 1;
        }
        public Pojazd(int liczbaKol, int liczbaSilnikow)
        {
            this.liczbaKol = liczbaKol;
            this.liczbaSilnikow = liczbaSilnikow;
        }
        public int PokazLiczbeKol()
        {
            return liczbaKol;
        }
        public int PokazLiczbeSilnikow()
        {
            return liczbaSilnikow;
        }
        public void WprowadzParametry (int liczbaSilnikow, int liczbaKol)
        {
            this.liczbaSilnikow = liczbaSilnikow;
            this.liczbaKol = liczbaKol;
        }
        public string PrzedstawSie ()
        {
            return "Jestem pojazdem. Mam " + liczbaKol.ToString() + " kół(koła) i " 
                + liczbaSilnikow.ToString() + " silnik (ów).";
        }
    }
}

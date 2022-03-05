using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Ulamek
    {
        private int licznik;
        private int mianownik;

        public Ulamek()
        {

        }
        public Ulamek(Ulamek previousUlamek)
        {
            Mianownik = previousUlamek.Mianownik;
            Licznik = previousUlamek.Licznik;
        }

        public Ulamek(int mianownik, int licznik)
        {
            Mianownik = mianownik;
            Licznik = licznik;
        }

        public int Mianownik { get; set; }

        public int Licznik { get; set; }

     

        public override string ToString()
        {
            return "Licznik to " + Licznik + " a mianownik to " + Mianownik.ToString(); ;
        }
        
    }
}
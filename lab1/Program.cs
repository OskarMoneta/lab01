using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek ulamek1 = new Ulamek(10, 20);
            Ulamek ulamek2 = new Ulamek(ulamek1);
            
            ulamek1.Mianownik = 39;
            ulamek2.Mianownik = 41;

            ulamek2.Licznik = 25;

            Console.WriteLine(ulamek1.ToString());
            Console.WriteLine(ulamek2.ToString());
            
            Console.ReadKey();
        }
    }
}

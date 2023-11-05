using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizm
{
    internal class polimofizm2
    {
        static void Main(string [] args)
        {
            double objetosc = 0;
            Pudelko p1 = new Pudelko();
            Pudelko p2 = new Pudelko();
            Pudelko p3 = new Pudelko();

            p1.PobierzDlugosc(3.5);
            p1.PobierzSzerokosc(4.0);
            p1.PobierzWysokosc(5.5);

            p2.PobierzDlugosc(2.5);
            p2.PobierzSzerokosc(5.0);
            p2.PobierzWysokosc(4.5);

            p3.PobierzDlugosc(12.5);
            p3.PobierzSzerokosc(15.0);
            p3.PobierzWysokosc(14.5);


            objetosc = p1.ObliczObjetosc();
            Console.WriteLine($"Objetosc 1 to: {objetosc}");

            objetosc = p2.ObliczObjetosc();
            Console.WriteLine($"objetosc 2 to: {objetosc}");

            p3 = p1 + p2;

            objetosc = p3.ObliczObjetosc();
            Console.WriteLine($"objetosc 3 to: {objetosc}");
            Console.Read();

        }
    }
}

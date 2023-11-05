using System;

namespace polimorfizm
{
    class Pudelko
    {
        private double dlugosc;
        private double szerokosc;
        private double wysokosc;
        public void PobierzDlugosc(double d)
        {
            dlugosc = d;
        }
        public void PobierzWysokosc(double w)
        {
            wysokosc = w;
        }
        public void Pobierzszerokosc(double s)
        {
            szerokosc = s;
        }
        public double ObliczObjetosc()
        {
            return (dlugosc * szerokosc * wysokosc);
        }
        public static Pudelko operator +(Pudelko a, Pudelko b)
        {
            Pudelko pud = new Pudelko();
            pud.wysokosc = a.wysokosc + b.wysokosc;
            pud.szerokosc = a.szerokosc + b.szerokosc;
            pud.dlugosc = a.dlugosc + b.dlugosc;
            return pud;
        }
    }
}

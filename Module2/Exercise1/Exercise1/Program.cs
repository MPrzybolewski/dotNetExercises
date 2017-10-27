using System;
using System.Collections.Generic;
using System.Globalization;

namespace Zad1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Osoba os1 = new Osoba("Jan", "Nowak", 1, "Kwiatowa", "Piotrkow Tryb", "97-300", 23, 12);
            Osoba klon1 = os1.Klonuj();
            Console.WriteLine("Oryginał: {0}", os1.ZwrocInformacjeOsobowe());
            Console.WriteLine("Klon: {0}", klon1.ZwrocInformacjeOsobowe());
            Console.WriteLine("\nZmieniamy klona\n");
            klon1.ZmienDaneOsobowe();

            Console.WriteLine("Oryginał: {0}", os1.ZwrocInformacjeOsobowe());
            Console.WriteLine("Klon: {0}", klon1.ZwrocInformacjeOsobowe());

            Console.WriteLine("\nKopiowanie głębokie\n");
            
            Adres adr = new Adres(13);

            Osoba os2 = new Osoba("Jacek", "Wiśniewski", 10, adr);
            Osoba klon2 = new Osoba(os2);

            Console.WriteLine("\n Orginal drugi: {0}", os2.ZwrocInformacjeOsobowe());
            Console.WriteLine("Klon drugi: {0}", klon2.ZwrocInformacjeOsobowe());

            Console.WriteLine("\n Zmienamy drugiego klona\n");
            klon2.ZmienDaneOsobowe();

            Console.WriteLine("\n Orginal drugi: {0}", os2.ZwrocInformacjeOsobowe());
            Console.WriteLine("Klon drugi: {0}", klon2.ZwrocInformacjeOsobowe());

            Console.ReadKey();

        }
    }
}
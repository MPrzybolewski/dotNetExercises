using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Zad1
{
    public class Adres
    {
        private string nazwaUlicy;
        private string miejscowosc;
        private int numerDomu;
        private int? numerMieszkania;
        private string kod;

        public Adres(string nazwaUlicy, string miejscowosc, string kod, int numerDomu, int? numerMieszkania)
        {
            this.nazwaUlicy = nazwaUlicy;
            this.miejscowosc = miejscowosc;
            this.numerDomu = numerDomu;
            this.numerMieszkania = numerMieszkania;
            this.kod = kod;
        }


        public Adres(string nazwaUlicy, int numerDomu, int? numerMieszkania)
            : this(nazwaUlicy, "Warszawa", "02-222", numerDomu, numerMieszkania){}
        
        public Adres(int numerDomu, int? numerMieszkania)
            : this("Aleje jerozolimskie", numerDomu, numerMieszkania){}

        public Adres(int numerDomu)
            : this(numerDomu, null){}

        public Adres(Adres adres)
            : this(adres.nazwaUlicy, adres.miejscowosc, adres.kod, adres.numerDomu, adres.numerMieszkania){}


        public string zwrocInformacjeAdresowe()
        {
            return numerMieszkania != null
                ? string.Format("ul. {0} {1} m.{2} {3} {4}", nazwaUlicy, numerDomu, numerMieszkania, miejscowosc, kod)
                : string.Format("ul. {0} {1}  {3} {4}", nazwaUlicy, numerDomu, miejscowosc, kod);
        }

        public string Miejscowosc
        {
            get => miejscowosc;
            set => miejscowosc = value;
        }

        public int NumerDomu
        {
            get => numerDomu;
            set => numerDomu = value;
        }

        public int? NumerMieszkania
        {
            get => numerMieszkania;
            set => numerMieszkania = value;
        }
        
        public string Kod
        {
            get => kod;
            set => kod = value;
        }
        
        public string NazwaUlicy
        {
            get => nazwaUlicy;
            set => nazwaUlicy = value;
        }

        public void zmienAdres()
        {
            Console.WriteLine("Podaj nazwe miejscowosci: ");
            miejscowosc = Console.ReadLine();

            Console.WriteLine("Podaj kod: ");
            kod = Console.ReadLine();

            Console.WriteLine("Podaj nazwe ulicy: ");
            nazwaUlicy = Console.ReadLine();

            do
            {
                Console.WriteLine("Podaj numer domu: ");
            } while (!int.TryParse(Console.ReadLine(), out numerDomu));

            Console.WriteLine("Czy jest numer mieszkania ?");
            char c = Console.ReadKey().KeyChar;
            if (c == 't')
            {
                Console.WriteLine();
                int i;
                do
                {
                    Console.WriteLine("Podaj numer mieszkania: ");
                } while (!int.TryParse(Console.ReadLine(), out i));
                numerMieszkania = i;
            }
            else
            {
                numerMieszkania = null;
                
            }


        }
        

    }
}
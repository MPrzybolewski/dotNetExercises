using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kadry;

namespace Zad1
{
    class AdresDlaKonsoli
    {
        private Adres adres;

        public Adres Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public AdresDlaKonsoli()
        {
            Console.WriteLine("Podaj nazwę miejscowości: ");
            string miejscowosc = Console.ReadLine();
            Console.WriteLine("Podaj kod: ");
            string kod = Console.ReadLine();
            Console.WriteLine("Podaj nazwe ulicy: ");
            string nazwaUlicy = Console.ReadLine();
            int numerDomu;
            do
            {
                Console.WriteLine("Podaj numer domu: "); 
            } while (!int.TryParse(Console.ReadLine(),out numerDomu));
            Console.WriteLine("Czy jest numer zamieszkania <t/n>:");
            char c = Console.ReadKey().KeyChar;
            int? numerMieszkania;
            if (c == 't')
            {
                int i;
                Console.WriteLine();
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

            this.Adres = new Adres(numerDomu, numerMieszkania, nazwaUlicy, kod, miejscowosc);
        }

        public AdresDlaKonsoli(Adres adres)
        {
            this.Adres = adres;
        }


        public void ZmienMiejscowosc()
        {
            Console.WriteLine("Podaj miejscowość: ");
            Adres.Miejscowosc = Console.ReadLine();
        }

        public void ZmienKod()
        {
            Console.Write("Podaj kod: ");
            Adres.Kod = Console.ReadLine();
        }

        public void ZmienUlice()
        {
            Console.Write("Podaj nazwę ulicy: ");
            Adres.NazwaUlicy = Console.ReadLine();
        }

        public void ZmienNumerDomu()
        {
            int numerDomu;
            do
            {
                Console.Write("Podaj numer domu: ");
            } while (!int.TryParse(Console.ReadLine(), out numerDomu));
            Adres.NumerDomu = numerDomu;
        }

        public void ZmienNrMieszkania()
        {
            Console.Write("Czy jest numer mieszkania <t/n>: ");
            char c = Console.ReadKey().KeyChar;
            if (c == 't')
            {
                int i;
                Console.WriteLine();
                do
                {
                    Console.Write("Podaj numer meszkania: ");
                } while (!int.TryParse(Console.ReadLine(), out i));
                Adres.NumerMieszkania = i;
            }
            else
            {
                Adres.NumerMieszkania = null;
            }
        }

        public void ZmienAdres()
        {
            ZmienMiejscowosc();
            ZmienKod();
            ZmienUlice();
            ZmienNumerDomu();
            ZmienNrMieszkania();
        }

        public void WypiszAdres()
        {
            Console.Write("{0} {1} ul. {2} nr {3}", Adres.Kod, Adres.Miejscowosc, Adres.NazwaUlicy, adres.NumerDomu);
            if (Adres.NumerMieszkania != null)
            {
                Console.Write("/{0}", Adres.Miejscowosc);
            }


        }
    }
}

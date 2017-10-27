using System;

namespace Zad1
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int numerEwidencyjny;
        private Adres adresZamieszkania;

        public Osoba(string imie, string nazwisko, int numerEwidencyjny, string nazwaUlicy, string miejscowosc,
            string kod, int numerDomu, int? numerMieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerEwidencyjny = numerEwidencyjny;
            adresZamieszkania = new Adres(nazwaUlicy, miejscowosc, kod, numerDomu, numerMieszkania);
        }

        public Osoba(string imie, string nazwisko, int numerEwidencyjny, Adres adresZamieszkania)
            : this(imie, nazwisko, numerEwidencyjny, adresZamieszkania.NazwaUlicy, adresZamieszkania.Miejscowosc,
                adresZamieszkania.Kod, adresZamieszkania.NumerDomu, adresZamieszkania.NumerMieszkania){}
        
       public Osoba(string imie, int numerEwidencyjny,int numerDomu)
           : this(imie, "Kowalski", numerEwidencyjny, "Aleje jerozolimskie", "Warszawa", "02-222", numerDomu, null){}

        public Osoba(Osoba osoba)
        {
            imie = osoba.imie;
            nazwisko = osoba.nazwisko;
            numerEwidencyjny = osoba.numerEwidencyjny;
            adresZamieszkania = osoba.adresZamieszkania;
        }

        public string ZwrocInformacjeOsobowe()
        {
            return string.Format("Pan(i) {0} {1} o numerze ewidyncyjnym: {2} zamieszkały(a): {3}", imie, nazwisko,
                numerEwidencyjny, adresZamieszkania.zwrocInformacjeAdresowe());
        }

        public Osoba Klonuj()
        {
            return (Osoba) this.MemberwiseClone();
        }

        public void ZmienDaneOsobowe()
        {
            Console.WriteLine("Podaj imie: ");
            imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();

            do
            {
                Console.WriteLine("Podaj numer ewidencyjny: ");
            } while (!int.TryParse(Console.ReadLine(), out numerEwidencyjny));

            adresZamieszkania.zmienAdres();
        }
            
          
    }
}
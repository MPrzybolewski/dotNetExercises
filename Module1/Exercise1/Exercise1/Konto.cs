using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Konto
    {
        private Osoba wlasciciel;
        private decimal saldo;
        private int pin;

        public Konto(string imie, string nazwisko)
        {
            this.wlasciciel = new Osoba(imie, nazwisko);
            this.saldo = 0;
            this.pin = 0;
        }

        private bool checkPin(int pin)
        {
            if (this.pin == pin)
            {
                return true;
            }
            return false;
        }

        public void changePin(int pin)
        {
            if (checkPin(pin))
            {
                Console.WriteLine("Podaj nowy pin: ");
                this.pin = int.Parse(Console.ReadLine());
                Console.WriteLine("Udało się zmienić pin");
            } else
            {
                Console.WriteLine("Zły pin");
            }
        }

        public void withdrawMoney(int pin, decimal amount)
        {
            if (checkPin(pin))
            {
                if((saldo - amount) < 0)
                {
                    Console.WriteLine("Nie możesz wypłacić takiej kwoty");
                } else
                {
                    this.saldo = this.saldo - amount;
                    Console.WriteLine("Wypłata gotowa");
                }

            } else
            {
                Console.WriteLine("Zły pin");
            }

        }

        public void makeDeposit(int pin, decimal amount)
        {
            if (checkPin(pin))
            {
                if(amount > 0)
                {
                    this.saldo += amount;
                    Console.WriteLine("Udało się wpłacić pieniądze");
                } else
                {
                    Console.WriteLine("Zła wartość depozytu");
                }
            } else
            {
                Console.WriteLine("Zły pin");
            }
        }

        public void getInformationAboutAccount(int pin)
        {
            if (checkPin(pin))
            {
                Console.WriteLine("Informacje na temat konta");
                Console.WriteLine("Imie: " + wlasciciel.imie);
                Console.WriteLine("Nazwisko: " + wlasciciel.nazwisko);
                Console.WriteLine("Saldo: " + saldo);
            } else 
            {
                Console.WriteLine("Zły pin");
            }
        } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto konto1 = new Konto("Jan", "Kowalski");
            konto1.changePin(0); //aby reszta miała sens wpisz 1234
            konto1.makeDeposit(1111, 3000); //sprawdzenie czy działa wykrywanie błędnego pinu
            konto1.makeDeposit(1234, 3000); 
            konto1.withdrawMoney(1234, 5000); //sprawdzenie czy działa błąd związany z wypłacaniem zbyt dużej ilości pieniędzy
            konto1.withdrawMoney(1234, 2000);
            konto1.getInformationAboutAccount(1234);
        }
    }
}

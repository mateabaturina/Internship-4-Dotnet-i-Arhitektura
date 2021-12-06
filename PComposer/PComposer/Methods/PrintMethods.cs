using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Methods
{
    class PrintMethods
    {
        public static void PrintLoginInput()
        {
            Console.Clear();
            Console.WriteLine("Dobrodošli u PComposer!");
            Console.WriteLine("Molim vas unesite svoje podatke.");
        }

        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Odaberite akciju:");
            Console.WriteLine();
            Console.WriteLine("1 - Sastavi i naruci novo racunalo");
            Console.WriteLine("2 - Prikazi moje narudzbe");
            Console.WriteLine("3 - Odjavi se");
            Console.Write("\r\nUnesite odabir: ");
        }

        public static void PrintComputerCase()
        {
            Console.Clear();
            Console.WriteLine("Odaberite kuciste:");
        }

        public static void PrintHardDisc()
        {
            Console.Clear();
            Console.WriteLine("Odaberite Hard disk:");
        }

        public static void PrintProcessor()
        {
            Console.Clear();
            Console.WriteLine("Odaberite procesor:");
        }

        public static void PrintRAM()
        {
            Console.Clear();
            Console.WriteLine("Odaberite RAM:");
        }

        public static void PrintEndOfOrder()
        {
            Console.Clear();
            Console.WriteLine("Uspjesno izvrsena narudzba!");
            Console.Write("Pritisnite Enter za povratak na izbornik...");
            Console.ReadLine();
        }

        public static void PrintShowOrdersMenu()
        {
            Console.Clear();

            //PrintOrder();

            Console.WriteLine("Odaberite akciju:");
            Console.WriteLine();
            Console.WriteLine("1 - Zakljucite kupovinu");
            Console.WriteLine("2 - Sastavite novo racunalo");
            Console.WriteLine("3 - Odustanite od narudbe");
            Console.Write("\r\nUnesite odabir: ");
        }

        public static void PrintConcludePurchase()
        {
            Console.Clear();

            Console.WriteLine("Zakljucite kupovinu:");
            Console.WriteLine();
            Console.WriteLine("1 - Da");
            Console.WriteLine("2 - Ne");
            Console.Write("\r\nUnesite odabir: ");
        }

        public static void PrintSelectDeliveryMethod()
        {
            Console.WriteLine("Molimo odaberite nacin dostave:");
            Console.WriteLine();
            Console.WriteLine("1 - Osobno preuzimanje");
            Console.WriteLine("2 - Dostava na kucnu adresu");
        }

        public static void PrintSelectDiscountMenu()
        {
            Console.Clear();
            Console.WriteLine("Odaberite popust:");
            Console.WriteLine();
            Console.WriteLine("1 - Kupon popust za vjerno clanstvo");
            Console.WriteLine("2 - Popust na kolicinu");
            Console.WriteLine("3 - Popust unosom koda");
            Console.Write("\r\nUnesite odabir: ");
        }
    }
}

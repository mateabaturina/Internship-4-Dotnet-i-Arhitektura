using System;

namespace PComposer
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLogin();
        }

        private static void PrintLogin()
        {
            Console.Clear();
            Console.WriteLine("Dobrodošli u PComposer!");
            Console.WriteLine("Molim vas unesite svoje podatke.");
            Console.Write("\r\nUnesite ime: ");
            var name = Console.ReadLine();
            Console.Write("\rUnesite prezime: ");
            var surname = Console.ReadLine();
            Console.Write("\rUnesite adresu: ");
            var adress = Console.ReadLine();


            Console.Clear();

            var showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Odaberite akciju:");
            Console.WriteLine();
            Console.WriteLine("1 - Sastavi i naruci novo racunalo");
            Console.WriteLine("2 - Prikazi moje narudzbe");
            Console.WriteLine("3 - Odjavi se");
            Console.Write("\r\nUnesite odabir: ");
        }

        private static bool MainMenu()
        {
            PrintMenu();

            switch (Console.ReadLine())
            {
                /*case "1":
                    CreatingNewComputer();
                    return true;
                case "2":
                    ShowOrders();
                    return true;*/
                case "3":
                    Console.WriteLine("Izašli ste iz aplikacije. Doviđenja!");
                    return false;
                default:
                    return true;
            }
        }

    }
}

using System;

namespace PComposer
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginInput();
        }

        private static void LoginInput()
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

            DomainLayer.GetSetData.SetData.Login(name, surname, adress);

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
                case "1":
                    CreatingNewComputer();
                    return true;
                /*case "2":
                    ShowOrders();
                    return true;*/
                case "3":
                    Console.WriteLine("Izašli ste iz aplikacije. Doviđenja!");
                    return false;
                default:
                    return true;
            }
        }

        private static void PrintCreatingNewComputerMenu()
        {
            Console.Clear();
            Console.WriteLine("Dobrodosli u sastavljanje novog racunala!");
            Console.WriteLine("Odaberite akciju:");
            Console.WriteLine();
            Console.WriteLine("1 - Kuciste");
            Console.WriteLine("2 - Hard disk");
            Console.WriteLine("3 - Procesor");
            Console.WriteLine("4 - RAM");
            Console.WriteLine("5 - Povratak na glavni izbornik");
            Console.Write("\r\nUnesite odabir: ");
        }

        private static void CreatingNewComputer()
        {
            PrintCreatingNewComputerMenu();

            Console.Clear();

            var showMenu = true;
            while (showMenu)
            {
                showMenu = CreatingNewComputerMenu();
            }

        }

        private static bool CreatingNewComputerMenu()
        {
            PrintCreatingNewComputerMenu();

            switch (Console.ReadLine())
            {
                case "1":
                    SelectComputerCase();
                    return true;
                case "2":
                    SelectHardDisc();
                    return true;
                case "3":
                    SelectProcessor();
                    return true;
                case "4":
                    SelectRAM();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        private static void SelectComputerCase()
        {
            Console.Clear();
            Console.WriteLine("Odaberite kuciste:");

            var listOfComputerCase = DomainLayer.GetSetData.GetData.GetComputerCase();

            var count = 1;

            foreach (var computerCase in listOfComputerCase)
            {
                Console.WriteLine(count++ + " - " + computerCase);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            Console.ReadLine();
        }

        private static void SelectHardDisc()
        {
            Console.Clear();
            Console.WriteLine("Odaberite Hard disk:");

            var listOfHardDiscs = DomainLayer.GetSetData.GetData.GetHardDisc();

            var count = 1;

            foreach (var hardDisc in listOfHardDiscs)
            {
                Console.WriteLine(count++ + " - " + hardDisc);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            Console.ReadLine();
        }

        private static void SelectProcessor()
        {
            Console.Clear();
            Console.WriteLine("Odaberite procesor:");

            var listOfProcessors = DomainLayer.GetSetData.GetData.GetProcessor();

            var count = 1;

            foreach (var processor in listOfProcessors)
            {
                Console.WriteLine(count++ + " - " + processor);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            Console.ReadLine();
        }

        private static void SelectRAM()
        {
            Console.Clear();
            Console.WriteLine("Odaberite RAM:");

            var listOfRAMs = DomainLayer.GetSetData.GetData.GetRAM();

            var count = 1;

            foreach (var RAM in listOfRAMs)
            {
                Console.WriteLine(count++ + " - " + RAM);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            Console.ReadLine();
        }

    }
}

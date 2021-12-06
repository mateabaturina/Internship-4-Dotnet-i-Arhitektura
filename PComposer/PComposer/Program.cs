using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities;
using PresentationLayer.Methods;

namespace PComposer
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfOrders = new List<Computer>();

            LoginInput();
        }

        private static void LoginInput()
        {
            PrintMethods.PrintLoginInput();

            var name = ValidateMethods.NameInput();

            var surname = ValidateMethods.SurnameInput();

            Console.Write("\rUnesite adresu: ");
            var adress = Console.ReadLine();

            DomainLayer.GetSetData.SetData.Login(name, surname, adress);

            var showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }        

        private static bool MainMenu()
        {
            PrintMethods.PrintMenu();

            switch (Console.ReadLine())
            {
                case "1":
                    CreatingNewComputer();
                    return true;
                case "2":
                    ShowOrders();
                    return true;
                case "3":
                    Console.WriteLine("Izašli ste iz aplikacije. Doviđenja!");
                    return false;
                default:
                    return true;
            }
        }

        private static void CreatingNewComputer()
        {
            foreach (int value in Enumerable.Range(1, 5))
            {

                switch (value)
                {
                    case 1:
                        SelectComputerCase();
                        break;
                    case 2:
                        SelectHardDisc();
                        break;
                    case 3:
                        SelectProcessor();
                        break;
                    case 4:
                        SelectRAM();
                        break;
                    case 5:
                        PrintMethods.PrintEndOfOrder();
                        break;
                }
            }
        }

        private static void SelectComputerCase()
        {
            PrintMethods.PrintComputerCase();

            var listOfComputerCases = DomainLayer.GetSetData.GetData.GetComputerCase();

            var count = 1;

            foreach (var computerCase in listOfComputerCases)
            {
                Console.WriteLine(count++ + " - " + computerCase);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            var userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    DomainLayer.GetSetData.SetData.SetComputerCase(listOfComputerCases[0]);
                    break;

                case "1":
                    DomainLayer.GetSetData.SetData.SetComputerCase(listOfComputerCases[1]);
                    break;

                case "2":
                    DomainLayer.GetSetData.SetData.SetComputerCase(listOfComputerCases[2]);
                    break;
            }
        }

        private static void SelectHardDisc()
        {
            PrintMethods.PrintHardDisc();

            var listOfHardDiscs = DomainLayer.GetSetData.GetData.GetHardDisc();

            var count = 1;

            foreach (var hardDisc in listOfHardDiscs)
            {
                Console.WriteLine(count++ + " - " + hardDisc);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            var userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    DomainLayer.GetSetData.SetData.SetHardDisc(listOfHardDiscs[0]);
                    break;

                case "1":
                    DomainLayer.GetSetData.SetData.SetHardDisc(listOfHardDiscs[1]);
                    break;

                case "2":
                    DomainLayer.GetSetData.SetData.SetHardDisc(listOfHardDiscs[2]);
                    break;

                case "3":
                    DomainLayer.GetSetData.SetData.SetHardDisc(listOfHardDiscs[3]);
                    break;
            }
        }

        private static void SelectProcessor()
        {
            PrintMethods.PrintProcessor();

            var listOfProcessors = DomainLayer.GetSetData.GetData.GetProcessor();

            var count = 1;

            foreach (var processor in listOfProcessors)
            {
                Console.WriteLine(count++ + " - " + processor);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            var userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    DomainLayer.GetSetData.SetData.SetProcessor(listOfProcessors[0]);
                    break;

                case "1":
                    DomainLayer.GetSetData.SetData.SetProcessor(listOfProcessors[1]);
                    break;

                case "2":
                    DomainLayer.GetSetData.SetData.SetProcessor(listOfProcessors[2]);
                    break;

                case "3":
                    DomainLayer.GetSetData.SetData.SetProcessor(listOfProcessors[3]);
                    break;
            }
        }

        private static void SelectRAM()
        {
            PrintMethods.PrintRAM();

            var listOfRAMs = DomainLayer.GetSetData.GetData.GetRAM();

            var count = 0;

            foreach (var RAM in listOfRAMs)
            {
                Console.WriteLine(count++ + " - " + RAM);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            var userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    DomainLayer.GetSetData.SetData.SetRAM(listOfRAMs[0]);
                    break;

                case "1":
                    DomainLayer.GetSetData.SetData.SetRAM(listOfRAMs[1]);
                    break;
            }           
        }       

        private static bool ShowOrdersMenu()
        {
            PrintMethods.PrintShowOrdersMenu();

            switch (Console.ReadLine())
            {
                /*case "1":
                    ConcludePurchase();
                    return true;*/
                case "2":
                    CreatingNewComputer();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void ShowOrders()
        {
            var showMenu = true;
            while (showMenu)
            {
                showMenu = ShowOrdersMenu();
            }
        }

        /*private static void PrintOrder()
        {   
            var user = DomainLayer.DomainLayer.NewUser;
            var computer = DomainLayer.DomainLayer.NewComputer;
            var weight = computer.WeightOfTheComputer();

            Console.WriteLine("Kupac: " + user.Name + " " + user.Surname);
            Console.WriteLine("Tezina racunala je " + computer.WeightOfTheComputer() + " kg.");
            Console.WriteLine("Cijena racunala je " + computer.ComponentsPrice() + " kn.");
            Console.WriteLine("Cijena dostave je " + Delivery(weight) + " kn.");
            Console.ReadLine();
        }*/

        private static int Delivery(float weight)
        {
            var user = DomainLayer.DomainLayer.NewUser;
            var priceOfDelivery = 0;

            if (weight < 3)
                priceOfDelivery = 5 * (user.Distance / 10);
            
            if (weight >= 3 & weight < 10)
                priceOfDelivery = 3 * (user.Distance / 5);

            if (weight >= 10)
                priceOfDelivery = 50 +  10 * (user.Distance / 20);

            return priceOfDelivery;
        }
    }
}

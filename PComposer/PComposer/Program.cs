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
            LoginInput();
        }

        private static void LoginInput()
        {   
            PrintMethods.PrintLoginInput();

            var name = ValidateMethods.NameInput();

            var surname = ValidateMethods.SurnameInput();

            Console.Write("\r\nUnesite adresu: ");
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

        static List<Computer> listOfOrders = new List<Computer>();

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
            userChoice = ValidateMethods.Checking1To3Input(userChoice);

            switch (userChoice)
            {
                case "1":
                    DomainLayer.GetSetData.SetData.SetComputerCase(listOfComputerCases[0]);
                    break;

                case "2":
                    DomainLayer.GetSetData.SetData.SetComputerCase(listOfComputerCases[1]);
                    break;

                case "3":
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
            userChoice = ValidateMethods.Checking1To4Input(userChoice);

            switch (userChoice)
            {
                case "1":
                    DomainLayer.GetSetData.SetData.SetHardDisc(listOfHardDiscs[0]);
                    break;

                case "2":
                    DomainLayer.GetSetData.SetData.SetHardDisc(listOfHardDiscs[1]);
                    break;

                case "3":
                    DomainLayer.GetSetData.SetData.SetHardDisc(listOfHardDiscs[2]);
                    break;

                case "4":
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
            userChoice = ValidateMethods.Checking1To4Input(userChoice);

            switch (userChoice)
            {
                case "1":
                    DomainLayer.GetSetData.SetData.SetProcessor(listOfProcessors[0]);
                    break;

                case "2":
                    DomainLayer.GetSetData.SetData.SetProcessor(listOfProcessors[1]);
                    break;

                case "3":
                    DomainLayer.GetSetData.SetData.SetProcessor(listOfProcessors[2]);
                    break;

                case "4":
                    DomainLayer.GetSetData.SetData.SetProcessor(listOfProcessors[3]);
                    break;
            }
        }

        private static void SelectRAM()
        {
            PrintMethods.PrintRAM();

            var listOfRAMs = DomainLayer.GetSetData.GetData.GetRAM();

            var count = 1;

            foreach (var RAM in listOfRAMs)
            {
                Console.WriteLine(count++ + " - " + RAM);
            }

            Console.WriteLine("\r\nUnesite odabir: ");
            var userChoice = Console.ReadLine();
            userChoice = ValidateMethods.Checking1To2Input(userChoice);

            switch (userChoice)
            {
                case "1":
                    DomainLayer.GetSetData.SetData.SetRAM(listOfRAMs[0]);
                    break;

                case "2":
                    DomainLayer.GetSetData.SetData.SetRAM(listOfRAMs[1]);
                    break;
            }

            listOfOrders.Add(DomainLayer.DomainLayer.NewComputer);
        }

        private static void Orders()
        {
            var count = 1;

            foreach (var order in listOfOrders)
            {
                Console.WriteLine();
                Console.WriteLine("Narudzba " + count++ + " :");
                Console.WriteLine("Kuciste: " + order.ComputerCase +
                                  "\nHard disk: " + order.HardDisk +
                                  "\nProcesor: " + order.Processor +
                                  "\nRAM: " + order.RAM);
            }
        }

        private static bool ShowOrdersMenu()
        {
            Console.Clear();

            Orders();

            PrintMethods.PrintShowOrdersMenu();

            switch (Console.ReadLine())
            {
                case "1":
                    ConcludePurchase();
                    return true;
                case "2":
                    CreatingNewComputer();
                    return true;
                case "3":
                    listOfOrders.Clear();
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

        private static bool ConcludePurchase()
        {
            PrintMethods.PrintConcludePurchase();

            Console.Write("\r\nUnesite odabir: ");
            var userChoice = Console.ReadLine();
            userChoice = ValidateMethods.Checking1To2Input(userChoice);

            switch (userChoice)
            {
                case "1":
                    EndPurchase();
                    return true;
                case "2":
                    return false;
                default:
                    return true;
            }
        }

        private static void EndPurchase()
        {            
            var weight = CalculateWeight();

            var priceOfDelivery = AdditionMethods.SelectDeliveryMethod(weight);

            var totalPrice = CalculateTotalPrice() + priceOfDelivery;

            var priceWithDiscount = AdditionMethods.SelectDiscount(totalPrice);

            Console.Clear();

            Console.WriteLine("Racun:");

            OrdersPrice();

            Console.WriteLine("\nCijena usluge sastavljanja: " + 25 * (4* listOfOrders.Count) + " kn.");
            Console.WriteLine("Cijena dostave: " + priceOfDelivery + " kn.");
            Console.WriteLine("Ukupna cijena: " + totalPrice + " kn.");
            Console.WriteLine("Ukupna cijena sa popustom: " + priceWithDiscount  + " kn.");
            Console.ReadLine();
        }

        private static float CalculateWeight()
        {
            float weight = 0;

            foreach (var computer in listOfOrders)
                weight += computer.WeightOfTheComputer();

            return weight;
        }

        private static float CalculateTotalPrice()
        {
            float totalPrice = 0;

            foreach (var computer in listOfOrders)
                totalPrice += computer.ComponentsPrice();

            return totalPrice;
        }

        private static void OrdersPrice()
        {
            var count = 1;

            foreach (var computer in listOfOrders)
            {
                Console.WriteLine("\nCijena racunala " + count++ + " : " + computer.ComponentsPrice() + " kn.");
                Console.WriteLine("Cijena kucista: " + computer.ComputerCase.Price + " kn.");
                Console.WriteLine("Cijena Hard diska: " + computer.HardDisk.Price + " kn.");
                Console.WriteLine("Cijena procesora: " + computer.Processor.Price + " kn.");
                Console.WriteLine("Cijena RAMa: " + computer.RAM.Price + " kn.");
            }
        }
        
    }
}

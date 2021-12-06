using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Methods
{
    class ValidateMethods
    {
        static bool CheckingName(string name)
        {
            return name.Any(char.IsDigit) || name == "";
        }

        public static string CheckingNameInput(string name)
        {
            while (CheckingName(name))
            {
                Console.WriteLine("Ime ne može biti prazno ili sadržavati brojeve! Molim vas ponovo unesite.");
                Console.Write("\r\nUnesite ime i prezime: ");
                name = Console.ReadLine();
            }

            return name;
        }

        public static string CheckingSurnameInput(string name)
        {
            while (CheckingName(name))
            {
                Console.WriteLine("Ime ne može biti prazno ili sadržavati brojeve! Molim vas ponovo unesite.");
                Console.Write("\r\nUnesite ime i prezime: ");
                name = Console.ReadLine();
            }

            return name;
        }

        public static string NameInput()
        {
            Console.Write("\r\nUnesite ime: ");
            var name = Console.ReadLine();

            name = CheckingNameInput(name);

            return name;
        }

        public static string SurnameInput()
        {
            Console.Write("\r\nUnesite prezime: ");
            var surname = Console.ReadLine();

            surname = CheckingSurnameInput(surname);

            return surname;
        }
    }
}

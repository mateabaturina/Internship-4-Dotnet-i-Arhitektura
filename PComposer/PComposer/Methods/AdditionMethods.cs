using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Methods
{
    class AdditionMethods
    {
        public static int SelectDeliveryMethod(float weight)
        {
            var priceOfDelivery = 0;

            PrintMethods.PrintSelectDeliveryMethod();

            Console.Write("\r\nUnesite odabir: ");

            switch (Console.ReadLine())
            {
                case "1":
                    priceOfDelivery = 0;
                    break;
                case "2":
                    priceOfDelivery = DeliveryOnHouseAddress(weight);
                    break;
            }

            return priceOfDelivery;
        }

        public static int DeliveryOnHouseAddress(float weight)
        {
            var user = DomainLayer.DomainLayer.NewUser;
            var priceOfDelivery = 0;

            if (weight < 3)
                priceOfDelivery = 5 * (user.Distance / 10);

            if (weight >= 3 & weight < 10)
                priceOfDelivery = 3 * (user.Distance / 5);

            if (weight >= 10)
                priceOfDelivery = 50 + 10 * (user.Distance / 20);

            return priceOfDelivery;
        }

        private static void SelectDiscount()
        {
            var showMenu = true;
            while (showMenu)
            {
                showMenu = SelectDiscountMenu();
            }
        }

        public static bool SelectDiscountMenu()
        {
            PrintMethods.PrintSelectDiscountMenu();

            switch (Console.ReadLine())
            {
                /*case "1":
                    FaithfulMembershipDiscount();
                    return true;
                case "2":
                    QuantityDicount();
                    return true;
                case "3":
                    CodeDiscount();
                    return true;*/
                default:
                    return true;
            }
        }
    }
}

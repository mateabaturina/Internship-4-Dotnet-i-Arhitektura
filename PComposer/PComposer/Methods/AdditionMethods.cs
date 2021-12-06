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

        public static int SelectDiscount(float totalPrice)
        {
            var priceWithDiscount = 0;

            PrintMethods.PrintSelectDiscount();

            switch (Console.ReadLine())
            {
                case "1":
                    priceWithDiscount = FaithfulMembershipDiscount(totalPrice);
                    break;
                case "4":
                    priceWithDiscount = (int)totalPrice;
                    break;
            }

            return priceWithDiscount;
        }

        public static int FaithfulMembershipDiscount(float totalPrice)
        {
            var priceWithDiscount = totalPrice - 100;

            return (int)priceWithDiscount;
        }
    }
}

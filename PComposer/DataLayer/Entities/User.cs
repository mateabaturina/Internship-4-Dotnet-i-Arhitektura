using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Distance { get; set; }

        public User(string name, string surname, string address)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Distance = RandomDistance();
        }

        public static int RandomDistance()
        {
            Random randomDistance = new Random();
            return (randomDistance.Next(50, 1000));
        }
    }
}

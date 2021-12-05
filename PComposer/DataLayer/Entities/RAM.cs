using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class RAM: Component
    {
        public RAM(int size, int price)
        {
            Size = size;
            Price = price;
        }

        public override string ToString()
        {
            return $"Velicina: {Size}, Cijena: {Price} kn";
        }
    }
}

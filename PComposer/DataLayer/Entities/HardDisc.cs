using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Enums;

namespace DataLayer.Entities
{
    public class HardDisc: Component
    {
        public Drive TypeOfDrive { get; set; }

        public HardDisc(Drive typeOfDrive, int weight, int size, int price)
        {
            TypeOfDrive = typeOfDrive;
            Weight = weight;
            Size = size;
            Price = price;
        }

        public override string ToString()
        {
            return $"Tip: {TypeOfDrive}, Tezina: {Weight} kg, Velicina: {Size}, Cijena: {Price} kn";
        }

    }
}

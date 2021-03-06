using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Enums;

namespace DataLayer.Entities
{
    public class ComputerCase: Component
    {
        public ComputerCaseMaterials Material { get; set; }
        public ComputerCase(ComputerCaseMaterials material, float weight, int price)
        {
            Material = material;
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"Materijal: {Material}, Tezina: {Weight} kg, Cijena: {Price} kn";
        }
    }
}

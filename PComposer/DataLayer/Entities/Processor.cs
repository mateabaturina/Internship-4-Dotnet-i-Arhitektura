using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Enums;

namespace DataLayer.Entities
{
    class Processor: Component
    {
        public Core TypeOfCore { get; set; }
        public ListOfManufacturers Manufacturer { get; set;}

        public Processor(Core typeOfCore, ListOfManufacturers manufacturer, int price)
        {
            TypeOfCore = typeOfCore;
            Manufacturer = manufacturer;
            Price = price;
        }
        public override string ToString()
        {
            return $"Tip: {TypeOfCore}, Proizvodac: {Manufacturer}, Cijena: {Price} kn";
        }
    }
}

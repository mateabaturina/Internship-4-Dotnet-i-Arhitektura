using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Enums;

namespace DataLayer.Entities
{
    class Processor
    {
        public Core TypeOfCore { get; set; }
        public ListOfManufacturers Manufecterer { get; set;}

        public Processor(Core typeOfCore, ListOfManufacturers manufacterer)
        {
            TypeOfCore = typeOfCore;
            Manufecterer = manufacterer;
        }
    }
}

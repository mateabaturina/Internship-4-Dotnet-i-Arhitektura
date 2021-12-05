using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Enums;

namespace DataLayer.Entities
{
    class HardDisk: Component
    {
        public Drive TypeOfDrive { get; set; }

        public HardDisk(Drive typeOfDrive, int weight, int size, int price)
        {
            TypeOfDrive = typeOfDrive;
            Weight = weight;
            Size = size;
            Price = price;
        }

    }
}

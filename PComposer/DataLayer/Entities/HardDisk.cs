using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Enums;

namespace DataLayer.Entities
{
    class HardDisk
    {
        public Drive TypeOfDrive { get; set; }
        public int Weight { get; set; }
        public int Size { get; set; }

        public HardDisk(Drive typeOfDrive, int weight, int size)
        {
            TypeOfDrive = typeOfDrive;
            Weight = weight;
            Size = size;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Enums;

namespace DataLayer.Entities
{
    class ComputerCase
    {
        public ComputerCaseMaterials Material { get; set; }
        public float Weight { get; set; }

        public ComputerCase(ComputerCaseMaterials material, float weight)
        {
            Material = material;
            Weight = weight;
        }
    }
}

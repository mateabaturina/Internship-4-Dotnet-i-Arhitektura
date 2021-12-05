using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Computer
    {
        public ComputerCase ComputerCase { get; set; }
        public HardDisc HardDisk { get; set; }
        public Processor Processor { get; set; }
        public RAM RAM { get; set; }

        public float WeightOfTheComputer()
        {
            return (HardDisk.Weight + ComputerCase.Weight);
        }
        public int ComponentsPrice()
        {
            return (RAM.Price + HardDisk.Price + Processor.Price + ComputerCase.Price);
        }

    }
}

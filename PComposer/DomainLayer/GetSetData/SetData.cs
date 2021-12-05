using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace DomainLayer.GetSetData
{
    public class SetData
    {
        public static void Login(string name, string surname, string address)
        {
            DomainLayer.NewUser = new(name, surname, address);
        }

        public static void SetComputerCase(ComputerCase computerCase)
        {
            DomainLayer.NewComputer.ComputerCase = computerCase;
        }

        public static void SetHardDisc(HardDisc hardDisk)
        {
            DomainLayer.NewComputer.HardDisk = hardDisk;
        }

        public static void SetProcessor(Processor processor)
        {
            DomainLayer.NewComputer.Processor = processor;
        }

        public static void SetRAM(RAM RAM)
        {
            DomainLayer.NewComputer.RAM = RAM;
        }
    }
}

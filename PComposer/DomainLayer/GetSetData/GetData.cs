using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer;

namespace DomainLayer.GetSetData
{
    public class GetData
    {
        public static List<ComputerCase> GetComputerCase()
        {
            var computerCase = new List<ComputerCase>();

            foreach (var component in DataSeeds.Components)
            {
                if (component is ComputerCase)
                {
                    computerCase.Add(component as ComputerCase);
                }
            }

            return computerCase;
        }

        public static List<HardDisc> GetHardDisc()
        {
            var hardDisc = new List<HardDisc>();

            foreach (var component in DataSeeds.Components)
            {
                if (component is HardDisc)
                {
                    hardDisc.Add(component as HardDisc);
                }
            }

            return hardDisc;
        }

        public static List<Processor> GetProcessor()
        {
            var processor = new List<Processor>();

            foreach (var component in DataSeeds.Components)
            {
                if (component is Processor)
                {
                    processor.Add(component as Processor);
                }
            }

            return processor;
        }

        public static List<RAM> GetRAM()
        {
            var RAM = new List<RAM>();

            foreach (var component in DataSeeds.Components)
            {
                if (component is RAM)
                {
                    RAM.Add(component as RAM);
                }
            }

            return RAM;
        }
    }
}

using System;
using System.Collections.Generic;
using DataLayer.Entities;
using DataLayer.Enums;

namespace DataLayer
{
    public class DataSeeds
    {
        public static readonly List<Component> Components = new()
        {
            new ComputerCase(material: ComputerCaseMaterials.Metal, weight: 1.5F, price: 200),
            new ComputerCase(material: ComputerCaseMaterials.Plastic, weight: 1F, price: 150),
            new ComputerCase(material: ComputerCaseMaterials.Carbon, weight: 0.5F, price: 300),

            new HardDisk(typeOfDrive: Drive.HDD, weight: 2, size: 2, price: 350),
            new HardDisk(typeOfDrive: Drive.HDD, weight: 1, size: 1, price: 300),
            new HardDisk(typeOfDrive: Drive.SSD, weight: 0, size: 2, price: 600),
            new HardDisk(typeOfDrive: Drive.SSD, weight: 0, size: 1, price: 550),

            new Processor(typeOfCore: Core.DecaCore, manufacturer: ListOfManufacturers.AMD, price: 3500),
            new Processor(typeOfCore: Core.OctaCore, manufacturer: ListOfManufacturers.Intel, price: 3000),
            new Processor(typeOfCore: Core.OctaCore, manufacturer: ListOfManufacturers.AMD, price: 2500),
            new Processor(typeOfCore: Core.QuadCore, manufacturer: ListOfManufacturers.Intel, price: 800),

            new RAM(size: 4, price: 90),
            new RAM(size: 8, price: 250),
        };
    }
}

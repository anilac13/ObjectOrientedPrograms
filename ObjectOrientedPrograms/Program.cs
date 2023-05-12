using ObjectOrientedPrograms.InventoryDataManagement;
using System;
namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\BridgeLabs\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\InventoryDataManagement\\Inventory.json";
            ReadTheData readTheData = new ReadTheData();
            InventoryDetails data = readTheData.Read(filePath);
            //for (int i = 0; i<data.typesOfRice.Count; i++)
            //{
            //    Console.WriteLine(data.typesOfRice[i].name);
            //    Console.WriteLine(data.typesOfRice[i].weight);
            //    Console.WriteLine(data.typesOfRice[i].pricePerKg);
            //}
            Console.WriteLine("Types of Rice");
            Console.WriteLine("============================");
            foreach (var item in data.typesOfRice)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.weight);
                Console.WriteLine(item.pricePerKg);
                int inventoryPrice = item.weight * item.pricePerKg;
                Console.WriteLine("The price of {0} for {1}Kg is {2}Rs", item.name, item.weight, inventoryPrice);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("\nTypes of Pulses");
            Console.WriteLine("============================");
            foreach (var item in data.typesOfPulses)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.weight);
                Console.WriteLine(item.pricePerKg);
                int inventoryPrice = item.weight * item.pricePerKg;
                Console.WriteLine("The price of {0} for {1}Kg is {2}Rs", item.name, item.weight, inventoryPrice);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("\nTypes of Wheat");
            Console.WriteLine("============================");
            foreach (var item in data.typesOfWheat)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.weight);
                Console.WriteLine(item.pricePerKg);
                int inventoryPrice = item.weight * item.pricePerKg;
                Console.WriteLine("The price of {0} for {1}Kg is {2}Rs", item.name, item.weight, inventoryPrice);
                Console.WriteLine("---------------------------");
            }
        }
    }
}